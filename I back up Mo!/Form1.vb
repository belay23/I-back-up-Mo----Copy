Public Class Form1
    Private tt As ToolTip = New ToolTip()
    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles IBclose.Click
        Close()

    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles IBminimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label2.Text = System.DateTime.Now.ToString("MM/dd/yyyy dddd  hh:mm:ss")
    End Sub
    Private Sub tilecompress_Click(sender As Object, e As EventArgs) Handles tilecompress.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub tilerecovery_Click(sender As Object, e As EventArgs) Handles tilerec1.Click
        Form3.Show()
        Me.Hide()
    End Sub
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
    Private Sub tilehelp_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub PictureBox5_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub BunifuImageButton3_Click(sender As Object, e As EventArgs) Handles BunifuImageButton3.Click
        Form5.Show()
        Me.Hide()
    End Sub
    Private Sub BunifuImageButton4_Click(sender As Object, e As EventArgs) Handles BunifuImageButton4.Click
        Form4.Show()
        Me.Hide()
    End Sub
    Private Sub tilerec1_MouseEnter(sender As Object, e As EventArgs) Handles tilerec1.MouseEnter
        tilerec1.Visible = False
    End Sub
    Private Sub pbrec_Click(sender As Object, e As EventArgs) Handles pbrec.Click
        Form3.Show()
        Me.Hide()
    End Sub
    Private Sub pbrec_MouseLeave(sender As Object, e As EventArgs) Handles pbrec.MouseLeave
        tilerec1.Visible = True
    End Sub
    Private Sub PictureBox5_Click_1(sender As Object, e As EventArgs) Handles pbcomp.Click
        Form2.Show()
        Me.Hide()
    End Sub
    Private Sub tilecompress_MouseEnter(sender As Object, e As EventArgs) Handles tilecompress.MouseEnter

    End Sub
    Private Sub pbcomp_MouseLeave(sender As Object, e As EventArgs) Handles pbcomp.MouseLeave
        tilecompress.Visible = True
    End Sub
    Private Sub BunifuImageButton3_MouseHover(sender As Object, e As EventArgs) Handles BunifuImageButton3.MouseHover
        Me.ToolTip1.SetToolTip(Me.BunifuImageButton3, "Help")

    End Sub

    Private Sub BunifuImageButton4_MouseHover(sender As Object, e As EventArgs) Handles BunifuImageButton4.MouseHover
        Me.ToolTip2.SetToolTip(Me.BunifuImageButton4, "About")
    End Sub
    Private Sub ToolTip2_Popup(sender As Object, e As PopupEventArgs) Handles ToolTip2.Popup

    End Sub
    Private Sub tilecompress_MouseHover(sender As Object, e As EventArgs) Handles tilecompress.MouseHover
        'tilecompress.Visible = False
        tilecompress.Hide()

    End Sub
End Class
