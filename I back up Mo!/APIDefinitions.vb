Imports System.Runtime.InteropServices

Module APIDefinitions

#Region "Functions"
    Public Declare Auto Function CreateFile Lib "kernel32.dll" (ByVal lpFileName As String, _
        ByVal dwDesiredAccess As Int32, ByVal dwShareMode As Int32, ByRef lpSecurityAttributes As SECURITY_ATTRIBUTES, _
        ByVal dwCreationDisposition As Int32, ByVal dwFlagsAndAttributes As Int32, ByVal hTemplateFile As IntPtr) As Integer

    Public Declare Auto Function ReadFile Lib "Kernel32.dll" ( _
        ByVal hndRef As Integer, ByVal lpBuffer As Byte(), _
        ByVal numberOfBytesToRead As Integer, ByRef numberOfBytesRead As Integer, ByRef Overlapped As System.Threading.NativeOverlapped) As Boolean

    <DllImport("kernel32", SetLastError:=True)> _
    Function WaitForSingleObject( _
        ByVal handle As IntPtr, _
        ByVal milliseconds As UInt32) As UInt32
    End Function

    Public Declare Auto Function CloseHandle Lib "kernel32.dll" (ByVal hObject As IntPtr) As Boolean
#End Region

#Region "Const"
    Public Const INFINITE As UInt32 = &HFFFFFFFFUI
    Public Const WAIT_ABANDONED As UInt32 = &H80UI
    Public Const WAIT_OBJECT_0 As UInt32 = &H0UI
    Public Const WAIT_TIMEOUT As UInt32 = &H102UI

    Public Const GENERIC_READ As Int32 = &H80000000
    Public Const GENERIC_WRITE As Int32 = &H40000000
    Public Const OPEN_EXISTING As Int32 = 3
    Public Const FILE_ATTRIBUTE_NORMAL As Int32 = 80
    Public Const FILE_FLAG_OVERLAPPED As Int32 = &H40000000

    Public Const FILE_SHARE_READ = &H1
    Public Const FILE_SHARE_WRITE = &H2
    Public Const INVALID_HANDLE_VALUE = -1
    Public Const INVALID_SET_FILE_POINTER = -1
    Public Const FILE_BEGIN = 0


#End Region

#Region "Structures"
    Public Structure SECURITY_ATTRIBUTES
        Dim nLength As Integer
        Dim lpSecurityDescriptor As Integer
        Dim bInheritHandle As Boolean
    End Structure
    <StructLayout(LayoutKind.Sequential)> _
    Public Structure MFTAttribute
        Dim AttributeType As Int32
        Dim Length As Int32
        Dim NonResidentFlag As Byte
        Dim NameLength As Byte
        Dim OffsetToTheName As Int16
        Dim Flags As Int16
        Dim AttributeID As Int16
        Dim LengthOfTheAttribute As Int32
        Dim OffsetToTheAttribute As Int16
        Dim IndexedFlag As Byte
        Dim Padding As Byte
    End Structure
#End Region


End Module
