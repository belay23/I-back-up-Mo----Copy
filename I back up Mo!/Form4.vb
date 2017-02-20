Public Class Form4

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles BunifuImageButton2.Click
        Me.Close()

    End Sub

    Private Sub BunifuImageButton3_Click(sender As Object, e As EventArgs) Handles IBback.Click
        Form1.Show()
        Me.Hide()

    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label2.Text = System.DateTime.Now.ToString("MM/dd/yyyy dddd  hh:mm:ss")

    End Sub

    Private Sub IBback_MouseHover(sender As Object, e As EventArgs) Handles IBback.MouseHover
        Me.ToolTip1.SetToolTip(Me.IBback, "Home")

    End Sub

    Private Sub ToolTip1_Popup(sender As Object, e As PopupEventArgs) Handles ToolTip1.Popup

    End Sub

   
    Private Sub BunifuThinButton1_Click_1(sender As Object, e As EventArgs) Handles btnabax.Click
        btnabax.BackColor = Color.Black
        btnabax.ForeColor = Color.Transparent
        btnmath.BackColor = Color.Transparent
        btnmath.ForeColor = Color.Transparent
        btndev.BackColor = Color.Transparent
        btndev.ForeColor = Color.Transparent
        pbabax.Visible = True
        pbmathbehind.Visible = False
        pbdevelopers.Visible = False

    End Sub

    Private Sub btnmath_Click(sender As Object, e As EventArgs) Handles btnmath.Click
        btnmath.BackColor = Color.Black
        btnmath.ForeColor = Color.Transparent
        btnabax.BackColor = Color.Transparent
        btnabax.ForeColor = Color.Transparent
        btndev.BackColor = Color.Transparent
        btndev.ForeColor = Color.Transparent
        pbmathbehind.Visible = True
        pbabax.Visible = False
        pbdevelopers.Visible = False


    End Sub

    Private Sub btndev_Click(sender As Object, e As EventArgs) Handles btndev.Click

        btndev.BackColor = Color.Black
        btndev.ForeColor = Color.Transparent
        btnmath.BackColor = Color.Transparent
        btnmath.ForeColor = Color.Transparent
        btnabax.BackColor = Color.Transparent
        btnabax.ForeColor = Color.Transparent
        pbdevelopers.Visible = True
        pbmathbehind.Visible = False
        pbabax.Visible = False
    End Sub
End Class