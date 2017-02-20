Imports System.IO
Public Class Unzip
    Private _file As String
    Private _folder As String
    Private _towhere As String

    Private _shell As Shell32.IShellDispatch2

    Public Event Unzipstart()
    Public Event UnzipFinishd()
    Public Sub New(ByVal file As String, ByVal towhere As String)
        _file = file
        _towhere = towhere
        _folder = Path.Combine(Path.GetDirectoryName(_file), _towhere)
        _shell = CreateObject("Shell.Application")
    End Sub

    Public Function Unzipnow() As Boolean
        If Directory.Exists(_folder) = False Then
            Directory.CreateDirectory(_folder)
        End If

        RaiseEvent Unzipstart()

        Dim temp As Shell32.Folder = _shell.NameSpace((_folder))
        If temp IsNot Nothing Then
            temp.CopyHere(_shell.NameSpace((_file)).Items)
        End If

        RaiseEvent UnzipFinishd()

        Return True
    End Function
    Public Property UnzipFile() As String
        Get
            Return _file
        End Get
        Set(ByVal value As String)
            _file = value
        End Set
    End Property

    Public Property UnzipTo() As String
        Get
            Return _towhere
        End Get
        Set(ByVal value As String)
            _towhere = value
        End Set
    End Property
End Class
