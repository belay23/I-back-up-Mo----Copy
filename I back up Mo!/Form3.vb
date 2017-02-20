Public Class Form3
    Dim MFTRead As New MFTRead
    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles BunifuImageButton2.Click
        Close()
    End Sub

    Private Sub BunifuImageButton4_Click(sender As Object, e As EventArgs) Handles BunifuImageButton4.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        cboDrives.DataSource = MFTRead.GetDrivesList()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblclock.Text = System.DateTime.Now.ToString("MM/dd/yyyy dddd  hh:mm:ss")
    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub BunifuImageButton3_Click(sender As Object, e As EventArgs) Handles BunifuImageButton3.Click

    End Sub

    Private Sub BunifuImageButton1_MouseHover(sender As Object, e As EventArgs) Handles BunifuImageButton1.MouseHover
        Me.ToolTip1.SetToolTip(Me.BunifuImageButton1, "Home")
    End Sub

    Private Sub ToolTip1_Popup(sender As Object, e As PopupEventArgs) Handles ToolTip1.Popup

    End Sub

    Private Sub cboDrives_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDrives.SelectedIndexChanged
        If MFTRead.IsNFTSDrive(cboDrives.Text) Then
            btnScan.Enabled = True
            lblIsNTFS.Text = "NTFS"
            lblIsNTFS.Visible = True
        Else
            btnScan.Enabled = True
            lblIsNTFS.Visible = False
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged

    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged

    End Sub

    Private Sub CheckBox6_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox6.CheckedChanged

    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged

    End Sub

    Private Sub btnScan_Click(sender As Object, e As EventArgs) Handles btnScan.Click
        DataGridView1.DataSource = MFTRead.GetFiles(cboDrives.Text, chkAll.Checked)
        lblInfo.Text = MFTRead.strInfo
    End Sub
End Class