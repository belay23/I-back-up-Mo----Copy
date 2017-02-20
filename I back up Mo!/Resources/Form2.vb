Imports System.IO
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Runtime.InteropServices
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Windows.Forms
Imports GongSolutions.Shell
Imports System.Threading
Imports System.Threading.Tasks
Imports Ionic.Zip.ZipFile
Imports System.ThreadStaticAttribute
Imports Ionic.Zip
Imports Ionic.Zlib



Public Class Form2
    Dim isdir As Boolean = False

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblclock.Text = System.DateTime.Now.ToString("MM/dd/yyyy dddd  hh:mm:ss")

    End Sub

    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles BunifuImageButton2.Click
        Close()

    End Sub

    Private Sub BunifuImageButton4_Click(sender As Object, e As EventArgs) Handles BunifuImageButton4.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        Form1.Show()
        Me.Hide()

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub BunifuImageButton1_MouseHover(sender As Object, e As EventArgs) Handles BunifuImageButton1.MouseHover
        Me.ToolTip1.SetToolTip(Me.BunifuImageButton1, "Home")

    End Sub

    Private Sub ToolTip1_Popup(sender As Object, e As PopupEventArgs) Handles ToolTip1.Popup

    End Sub
    Sub OnFileSelected(filename As String)
        txtfolder.Text = (filename)
    End Sub

    Sub UpdateOpenButtonState()
        If (ShellView1.SelectedItems.Length > 0) Or (txtfolder.Text.Length > 0) Then
            bunifucompress.Enabled = True
        End If
    End Sub

    Sub txtfolder_FilenameEntered()
        OnFileSelected(txtfolder.Text)
    End Sub

    Sub openButton_Click()
        ' If Not ShellView1.NavigateSelectedFolder() Then
        Dim selected As ShellItem() = ShellView1.SelectedItems
        'Dim dir As String = "@C:\temp"
        ''If txtfolder.Text Like dir Then
        '    isdir = True
        'End If

        If selected.Length > 0 Then
            OnFileSelected(selected(0).FileSystemPath)
        ElseIf File.Exists(txtfolder.Text) Then
            OnFileSelected(txtfolder.Text)
        ElseIf Directory.Exists(txtfolder.Text) Then
            OnFileSelected(txtfolder.Text)
        End If

        If Directory.Exists(txtfolder.Text) Then
            MsgBox("folder")
            isdir = True
            'It's a folder path, do something
        ElseIf File.Exists(txtfolder.Text) Then
            'MsgBox("file")
            'It's a file path, do something
        Else
            MessageBox.Show("Please enter a valid file or folder path", _
                            "Error!", _
                            MessageBoxButtons.OK, _
                            MessageBoxIcon.Error)
        End If



    End Sub
    Private Sub bunifucompress_Click(sender As Object, e As EventArgs) Handles bunifucompress.Click

        If (String.IsNullOrEmpty(txtfolder.Text)) Then

            MessageBox.Show("Please select your folder.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtfolder.Focus()
            Return
        End If

        Dim path As String = txtfolder.Text
        Dim container As String = ""
        Dim fi As New FileInfo(path)

        Dim zip As Ionic.Zip.ZipFile = New Ionic.Zip.ZipFile()

        If (isdir) = False Then

            zip.AddFile(path)


        Else
            zip.AddDirectory(path)

        End If


        Dim di = New System.IO.DirectoryInfo(path)
        container = path.Replace(di.Name.ToString(), String.Empty)
        'zip.SaveProgress += Zip_SaveProgress()
        
        If (isdir) = False Then
            zip.Save(String.Format("{0}/{1}.abx", di.Parent.FullName, fi.Name))
        Else
            zip.Save(String.Format("" + container + "{0}.abx", di.Name.ToString()))
            zip.Dispose()
        End If
        MessageBox.Show("Compress File/Folder Successfully created", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Sub Zip_SaveProgress(sender As Object, e As Ionic.Zip.SaveProgressEventArgs)
        If e.EventType = Ionic.Zip.ZipProgressEventType.Saving_BeforeWriteEntry Then
            cprogress.Invoke(New MethodInvoker(Sub()
                                                   cprogress.MaxValue = e.EntriesTotal
                                                   cprogress.Value = e.EntriesSaved + 1
                                                   cprogress.Update()

                                               End Sub))
        End If

    End Sub

    Private Sub ShellView1_Click(sender As Object, e As EventArgs) Handles ShellView1.Click

    End Sub

    Private Sub ShellView1_SelectionChanged(sender As Object, e As EventArgs) Handles ShellView1.SelectionChanged
        bunifucompress.Enabled = True
        openButton_Click()
    End Sub

    Private Sub bunifudecompress_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bunifudecompress.Click
        

    End Sub
    Sub unziped()
        MsgBox("Successfully Extract the File")
    End Sub

    Private Function Zip_SaveProgress(e As Ionic.Zip.SaveProgressEventArgs) As Object
        Throw New NotImplementedException
    End Function

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Using ofd As New OpenFileDialog
            ofd.Filter = "ZipFile|*.abx"
            If ofd.ShowDialog = Windows.Forms.DialogResult.OK Then
                Dim file As String = ofd.FileName
                Dim cu As New Unzip(file, Path.Combine(Path.GetDirectoryName(file), "File"))
                AddHandler cu.UnzipFinishd, AddressOf unziped
                cu.Unzipnow()

            End If

        End Using
    End Sub
End Class