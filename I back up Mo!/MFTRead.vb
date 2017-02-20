Imports System.Runtime.InteropServices

Public Class MFTRead
    'Saves info for displaying
    Public strInfo As String

    Public Function GetDrivesList() As List(Of String)
        Dim lst As New List(Of String)
        For Each drive As IO.DriveInfo In IO.DriveInfo.GetDrives()
            lst.Add(drive.Name)
        Next
        Return lst
    End Function

    Public Function IsNFTSDrive(ByVal strDrive As String) As Boolean
        Dim Hnd As Integer, nRead As Integer
        Dim ret As UInt32
        Dim Buffer(1024) As Byte
        Hnd = CreateFile("\\.\" & Mid(strDrive, 1, 2), GENERIC_READ Or GENERIC_WRITE, FILE_SHARE_READ Or FILE_SHARE_WRITE, _
        Nothing, OPEN_EXISTING, FILE_ATTRIBUTE_NORMAL Or FILE_FLAG_OVERLAPPED, IntPtr.Zero)
        If (Hnd <> INVALID_HANDLE_VALUE) Then
            ret = ReadFile(Hnd, Buffer, 1024, nRead, New System.Threading.NativeOverlapped)
        Else
            Return False
        End If
        If ret = 0 Then
            ret = WaitForSingleObject(Hnd, INFINITE)
            Select Case ret
                Case WAIT_OBJECT_0
                Case WAIT_TIMEOUT
            End Select
        Else
            Return False
        End If
        CloseHandle(Hnd)
        Return Buffer(3) = 78 And Buffer(4) = 84 And Buffer(5) = 70 And Buffer(6) = 83
    End Function

    Public Function GetFiles(ByVal strDrive As String, ByVal bnAllFiles As Boolean) As DataTable
        Dim Hnd As Integer, nRead As Integer
        Dim ret As UInt32
        Dim Buffer(1024) As Byte

        Dim BytesPerSect As Long
        Dim SectperCluster As Long
        Dim MFTCluster As Long
        Dim intIgnoredFiles As Integer = 0

        Dim NO As System.Threading.NativeOverlapped
        'Read Partition Info
        Hnd = CreateFile("\\.\" & Mid(strDrive, 1, 2), GENERIC_READ Or GENERIC_WRITE, FILE_SHARE_READ Or FILE_SHARE_WRITE, _
        Nothing, OPEN_EXISTING, FILE_ATTRIBUTE_NORMAL Or FILE_FLAG_OVERLAPPED, IntPtr.Zero)
        If (Hnd <> INVALID_HANDLE_VALUE) Then
            ret = ReadFile(Hnd, Buffer, 1024, nRead, NO)
        Else
            Return Nothing
        End If
        If ret = 0 Then
            ret = WaitForSingleObject(Hnd, INFINITE)
            Select Case ret
                Case WAIT_OBJECT_0
                Case WAIT_TIMEOUT
            End Select
        Else
            Return Nothing
        End If
        BytesPerSect = LittleEndianHEXToDecimal(Buffer, &HB, 2)
        SectperCluster = LittleEndianHEXToDecimal(Buffer, &HD, 1)
        MFTCluster = LittleEndianHEXToDecimal(Buffer, &H30, 8)
        'Read MFT
        SetReadFileOffset(NO, MFTCluster * SectperCluster * BytesPerSect)
        ret = ReadFile(Hnd, Buffer, 1024, nRead, NO)
        If ret = 0 Then
            ret = WaitForSingleObject(Hnd, INFINITE)
            Select Case ret
                Case WAIT_OBJECT_0
                Case Else
            End Select
        Else
            Return Nothing
        End If
        'Read MFT Dataruns
        Dim drs As MFTDataRuns
        Dim offset As Long = LittleEndianHEXToDecimal(Buffer, 20, 2) + 1
        Dim Attributes = GetAttributes(Buffer)
        For Each MFTAttribute In Attributes
            If MFTAttribute.AttributeType = &H80 Then
                drs = New MFTDataRuns(Buffer, offset - 1)
            Else
                offset += MFTAttribute.Length
            End If
        Next
        Dim dtFiles As New DataTable
        dtFiles.Columns.Add("ShortFileName", GetType(String))
        dtFiles.Columns.Add("LongFileName", GetType(String))
        Dim FileNameLenght As Integer
        'Read Files
        For Each dr In drs.DataRuns
            Dim Pos As Int64 = 0
            Do
                Dim strShortFileName As String = ""
                Dim strLongFileName As String = ""
                SetReadFileOffset(NO, (dr.Place * SectperCluster * BytesPerSect) + Pos)
                ret = ReadFile(Hnd, Buffer, 1024, nRead, NO)
                If ret = 0 Then
                    ret = WaitForSingleObject(Hnd, INFINITE)
                    Select Case ret
                        Case WAIT_OBJECT_0
                        Case Else
                    End Select
                Else
                    Return Nothing
                End If
                If Buffer(0) = 70 And Buffer(1) = 73 And Buffer(2) = 76 And Buffer(3) = 69 Then
                    If bnAllFiles Or (Not bnAllFiles And BitConverter.ToInt16(Buffer, 22) = 0) Then
                        Attributes = GetAttributes(Buffer)
                        offset = LittleEndianHEXToDecimal(Buffer, 20, 2) + 1
                        For Each Attribute In Attributes
                            'FileName
                            If Attribute.AttributeType = &H30 Then
                                FileNameLenght = Buffer(offset + Marshal.SizeOf(Attribute) + 63)
                                If strShortFileName = "" Then
                                    strShortFileName = System.Text.UnicodeEncoding.Unicode.GetString(Buffer, offset + Len(Attribute) + 65, FileNameLenght * 2)
                                Else
                                    strLongFileName = System.Text.UnicodeEncoding.Unicode.GetString(Buffer, offset + Len(Attribute) + 65, FileNameLenght * 2)
                                End If
                            End If
                            offset += Attribute.Length
                        Next
                        'Exclude with no data
                        If Not IsNothing(strShortFileName) AndAlso strShortFileName <> "" Then
                            Dim dtr = dtFiles.NewRow
                            dtr("ShortFileName") = strShortFileName
                            dtr("LongFileName") = strLongFileName
                            dtFiles.Rows.Add(dtr)
                        Else
                            intIgnoredFiles += 1
                        End If
                    End If
                End If
                Pos += 1024
            Loop Until (Pos / BytesPerSect / SectperCluster) >= dr.Length

        Next
        CloseHandle(Hnd)
        If bnAllFiles Then
            strInfo = dtFiles.Rows.Count & " Files Found."
        Else
            strInfo = dtFiles.Rows.Count & " Files Found, (" & intIgnoredFiles & " ignored)"
        End If

        Return dtFiles
    End Function

    Private Function LittleEndianHEXToDecimal(ByRef Buffer As Byte(), ByVal offset As Long, ByVal Length As Long) As Long
        If Length = 1 Then
            Return BitConverter.ToInt16(Buffer, offset)
        End If
        If Length = 2 Then
            Return BitConverter.ToInt16(Buffer, offset)
        End If
        If Length = 4 Then
            Return BitConverter.ToInt32(Buffer, offset)
        End If
        If Length = 8 Then
            Return BitConverter.ToInt64(Buffer, offset)
        End If

    End Function

    Private Function GetAttributes(ByVal Buffer() As Byte) As List(Of MFTAttribute)
        Dim _Attributes As New List(Of MFTAttribute)
        Dim _AttributeOffset As Long
        Dim intFileAttribute As Integer = 0
        _AttributeOffset = LittleEndianHEXToDecimal(Buffer, 20, 2) + 1
        Do
            Dim _intAttributePtr As IntPtr = Marshal.AllocHGlobal(24)
            Dim _Attribute As MFTAttribute
            Try
                Marshal.Copy(Buffer, _AttributeOffset - 1, _intAttributePtr, 24)
                _Attribute = Marshal.PtrToStructure(_intAttributePtr, _Attribute.GetType())
                Marshal.FreeHGlobal(_intAttributePtr)
            Catch ex As Exception
                Try
                    Marshal.FreeHGlobal(_intAttributePtr)
                Catch
                End Try
            End Try
            If _Attribute.AttributeType = &H30 Then
                intFileAttribute += 1
            End If
            _Attributes.Add(_Attribute)
            _AttributeOffset += _Attribute.Length
            'Just read filename attribute and then exit, its faster since we dont need the others
            If intFileAttribute = 2 Then
                Exit Do
            End If
            If _Attribute.AttributeType = -1 Then
                Exit Do
            End If
        Loop Until _AttributeOffset >= 1024
        Return _Attributes
    End Function

    Private Sub SetReadFileOffset(ByRef NO As System.Threading.NativeOverlapped, ByRef curBig As Int64)
        Dim lowoffset() As Byte = BitConverter.GetBytes(curBig)
        Dim highoffset As Int32 = BitConverter.ToInt32(lowoffset, 0)
        Dim high As Int32
        Dim lastbytes(3) As Byte
        Array.Copy(lowoffset, 4, lastbytes, 0, 4)
        high = BitConverter.ToInt32(lastbytes, 0)
        NO.OffsetLow = highoffset
        NO.OffsetHigh = high
    End Sub

    Public Class MFTDataRuns
        Dim _buffer() As Byte
        Dim _AttributeOffset As Integer
        Public Sub New(ByVal buffer() As Byte, ByVal AttributeOffset As Integer)
            _buffer = buffer
            _AttributeOffset = AttributeOffset
        End Sub
        Public ReadOnly Property DataRuns() As DataRun()
            Get
                Dim _DataRuns(0) As DataRun
                Dim datarunstartoffset As Integer = _buffer(_AttributeOffset + 32)
                '_buffer(_attributeoffset+datarunstartoffset) = first dr byte
                While _buffer(_AttributeOffset + datarunstartoffset) <> 0
                    Dim drLenght As Integer = Val(Strings.Right("00" & Hex(_buffer(_AttributeOffset + datarunstartoffset)), 2)(0)) + Val(Strings.Right("00" & Hex(_buffer(_AttributeOffset + datarunstartoffset)), 2)(1))
                    Dim drBytes(drLenght) As Byte
                    Array.Copy(_buffer, _AttributeOffset + datarunstartoffset, drBytes, 0, drLenght + 1)
                    _DataRuns(UBound(_DataRuns)) = New DataRun(drBytes)
                    ReDim Preserve _DataRuns(UBound(_DataRuns) + 1)
                    datarunstartoffset += drLenght + 1
                End While
                'delete last pos
                ReDim Preserve _DataRuns(UBound(_DataRuns) - 1)
                'get real location
                Dim lastpos As Int64 = 0
                For Each dr As DataRun In _DataRuns
                    If lastpos <> 0 Then
                        dr.Place = lastpos + If(dr.IsNegative, dr.Place * -1, dr.Place)
                        lastpos = dr.Place
                    Else
                        lastpos = dr.Place
                    End If
                Next
                Return _DataRuns
            End Get
        End Property
        Public Class DataRun
            Dim _Place As Int64
            Dim _Length As Int64
            Dim _IsNegative As Boolean

            Public Sub New(ByVal buffer() As Byte)
                'first datarun byte is lenght of data run, lenght was already filtered before
                'but also tells me how many bytes are for localization and for lenght
                'so we evaluate it
                Dim strHexDRLenght As String = Hex(buffer(0)) '32 ultimos 3, localizacion, primeros 2 desp
                Dim _LengthCount As Integer = Val(strHexDRLenght(1)) '2
                Dim _PlaceCount As Integer = Val(strHexDRLenght(0)) '3
                Dim length(0) As Byte
                For i As Integer = 0 To UBound(buffer)
                    Dim count As Integer = 0
                    If i > 0 Then
                        If i <= _LengthCount Then
                            length(UBound(length)) = buffer(i)
                            ReDim Preserve length(UBound(length) + 1)
                        Else
                            Exit For
                        End If
                    End If
                Next
                Dim place(0) As Byte
                For i As Integer = 0 To UBound(buffer)
                    Dim count As Integer = 0
                    If i > _LengthCount Then
                        If i <= _PlaceCount + _LengthCount Then
                            place(UBound(place)) = buffer(i)
                            ReDim Preserve place(UBound(place) + 1)
                        Else
                            Exit For
                        End If
                    End If
                Next
                _Length = ReadNum(length, False)
                _Place = ReadNum(place, True)
            End Sub
            Public Property Place() As Int64
                Get
                    Return _Place
                End Get
                Set(ByVal value As Int64)
                    _Place = value
                End Set
            End Property
            Public ReadOnly Property Length() As Int64
                Get
                    Return _Length
                End Get
            End Property
            Public ReadOnly Property IsNegative() As Boolean
                Get
                    Return _IsNegative
                End Get
            End Property
            Private Function ReadNum(ByVal buffer() As Byte, ByVal bnCheckNegative As Boolean) As Int64
                Dim strHex As String = ""
                For i As Integer = UBound(buffer) - 1 To 0 Step -1
                    strHex &= Strings.Right("00" & Hex(buffer(i)), 2)
                Next
                If ("&H" & strHex(0) & strHex(1)) > 128 And bnCheckNegative Then
                    _IsNegative = True
                    Return Val(Int64.Parse(strHex, Globalization.NumberStyles.HexNumber) Xor Int64.Parse(Strings.StrDup(strHex.Length, "F"), Globalization.NumberStyles.HexNumber)) + 1
                Else
                    Return Int64.Parse(strHex, Globalization.NumberStyles.HexNumber)
                End If
            End Function

        End Class
    End Class
End Class
