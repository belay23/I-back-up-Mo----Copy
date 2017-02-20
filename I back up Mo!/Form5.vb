Public Class Form5

    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles BunifuImageButton2.Click
        Close()
    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label2.Text = System.DateTime.Now.ToString("MM/dd/yyyy dddd  hh:mm:ss")

    End Sub

    Private Sub BunifuImageButton3_Click(sender As Object, e As EventArgs) Handles IBBack.Click
        Form1.Show()
        Me.Hide()

    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()

    End Sub

    Private Sub IBBack_MouseHover(sender As Object, e As EventArgs) Handles IBBack.MouseHover
        Me.ToolTip1.SetToolTip(Me.IBBack, "Back to Home")

    End Sub

    Private Sub tilerecovery_Click(sender As Object, e As EventArgs) Handles tiletutorial.Click

    End Sub

    Private Sub tiletutorial_MouseHover(sender As Object, e As EventArgs) Handles tiletutorial.MouseHover
        Me.ToolTip1.SetToolTip(Me.tiletutorial, "ABAX Video Tutorial")
    End Sub

    Private Sub tilemanual_Click(sender As Object, e As EventArgs) Handles tilemanual.Click

    End Sub

    Private Sub tilemanual_MouseHover(sender As Object, e As EventArgs) Handles tilemanual.MouseHover
        Me.ToolTip1.SetToolTip(Me.tilemanual, "ABAX User's Manual")
    End Sub
End Class