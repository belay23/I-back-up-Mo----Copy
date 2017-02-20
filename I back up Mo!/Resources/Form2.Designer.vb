<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.BunifuImageButton3 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BunifuImageButton4 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.lblclock = New System.Windows.Forms.Label()
        Me.BunifuImageButton2 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.bunifudecompress = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.bunifucompress = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.cprogress = New Bunifu.Framework.UI.BunifuCircleProgressbar()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BunifuImageButton1 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.BunifuImageButton5 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.ShellView1 = New GongSolutions.Shell.ShellView()
        Me.ShellTreeView1 = New GongSolutions.Shell.ShellTreeView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtfolder = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        CType(Me.BunifuImageButton3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'BunifuImageButton3
        '
        Me.BunifuImageButton3.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton3.Image = Global.I_back_up_Mo_.My.Resources.Resources.compress
        Me.BunifuImageButton3.ImageActive = Nothing
        Me.BunifuImageButton3.Location = New System.Drawing.Point(304, 23)
        Me.BunifuImageButton3.Name = "BunifuImageButton3"
        Me.BunifuImageButton3.Size = New System.Drawing.Size(51, 48)
        Me.BunifuImageButton3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton3.TabIndex = 6
        Me.BunifuImageButton3.TabStop = False
        Me.BunifuImageButton3.Zoom = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(349, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(290, 18)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "ABAX: Compress / Decompress Files"
        '
        'BunifuImageButton4
        '
        Me.BunifuImageButton4.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton4.Image = Global.I_back_up_Mo_.My.Resources.Resources.appbar_minus
        Me.BunifuImageButton4.ImageActive = Nothing
        Me.BunifuImageButton4.Location = New System.Drawing.Point(780, 0)
        Me.BunifuImageButton4.Name = "BunifuImageButton4"
        Me.BunifuImageButton4.Size = New System.Drawing.Size(40, 34)
        Me.BunifuImageButton4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton4.TabIndex = 9
        Me.BunifuImageButton4.TabStop = False
        Me.BunifuImageButton4.Zoom = 0
        '
        'lblclock
        '
        Me.lblclock.AutoSize = True
        Me.lblclock.BackColor = System.Drawing.Color.Transparent
        Me.lblclock.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblclock.ForeColor = System.Drawing.Color.White
        Me.lblclock.Location = New System.Drawing.Point(591, 9)
        Me.lblclock.Name = "lblclock"
        Me.lblclock.Size = New System.Drawing.Size(22, 16)
        Me.lblclock.TabIndex = 10
        Me.lblclock.Text = "00"
        '
        'BunifuImageButton2
        '
        Me.BunifuImageButton2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton2.Image = Global.I_back_up_Mo_.My.Resources.Resources.appbar_close
        Me.BunifuImageButton2.ImageActive = Nothing
        Me.BunifuImageButton2.Location = New System.Drawing.Point(822, 0)
        Me.BunifuImageButton2.Name = "BunifuImageButton2"
        Me.BunifuImageButton2.Size = New System.Drawing.Size(38, 34)
        Me.BunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton2.TabIndex = 8
        Me.BunifuImageButton2.TabStop = False
        Me.BunifuImageButton2.Zoom = 0
        '
        'Timer1
        '
        '
        'bunifudecompress
        '
        Me.bunifudecompress.Activecolor = System.Drawing.Color.DarkCyan
        Me.bunifudecompress.BackColor = System.Drawing.Color.Transparent
        Me.bunifudecompress.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bunifudecompress.BorderRadius = 0
        Me.bunifudecompress.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.bunifudecompress.ButtonText = "  Extract"
        Me.bunifudecompress.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bunifudecompress.Iconcolor = System.Drawing.Color.Transparent
        Me.bunifudecompress.Iconimage = Global.I_back_up_Mo_.My.Resources.Resources.appbar_cabinet_files
        Me.bunifudecompress.Iconimage_right = Nothing
        Me.bunifudecompress.Iconimage_right_Selected = Nothing
        Me.bunifudecompress.Iconimage_Selected = Nothing
        Me.bunifudecompress.IconZoom = 90.0R
        Me.bunifudecompress.IsTab = False
        Me.bunifudecompress.Location = New System.Drawing.Point(682, 423)
        Me.bunifudecompress.Name = "bunifudecompress"
        Me.bunifudecompress.Normalcolor = System.Drawing.Color.Transparent
        Me.bunifudecompress.OnHovercolor = System.Drawing.Color.SkyBlue
        Me.bunifudecompress.OnHoverTextColor = System.Drawing.Color.White
        Me.bunifudecompress.selected = False
        Me.bunifudecompress.Size = New System.Drawing.Size(166, 54)
        Me.bunifudecompress.TabIndex = 10
        Me.bunifudecompress.Textcolor = System.Drawing.Color.White
        Me.bunifudecompress.TextFont = New System.Drawing.Font("Segoe UI Symbol", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'bunifucompress
        '
        Me.bunifucompress.Activecolor = System.Drawing.Color.DarkCyan
        Me.bunifucompress.BackColor = System.Drawing.Color.Transparent
        Me.bunifucompress.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bunifucompress.BorderRadius = 0
        Me.bunifucompress.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.bunifucompress.ButtonText = "Compress"
        Me.bunifucompress.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bunifucompress.Iconcolor = System.Drawing.Color.Transparent
        Me.bunifucompress.Iconimage = Global.I_back_up_Mo_.My.Resources.Resources.appbar_archive
        Me.bunifucompress.Iconimage_right = Nothing
        Me.bunifucompress.Iconimage_right_Selected = Nothing
        Me.bunifucompress.Iconimage_Selected = Nothing
        Me.bunifucompress.IconZoom = 90.0R
        Me.bunifucompress.IsTab = False
        Me.bunifucompress.Location = New System.Drawing.Point(682, 347)
        Me.bunifucompress.Name = "bunifucompress"
        Me.bunifucompress.Normalcolor = System.Drawing.Color.Transparent
        Me.bunifucompress.OnHovercolor = System.Drawing.Color.SkyBlue
        Me.bunifucompress.OnHoverTextColor = System.Drawing.Color.White
        Me.bunifucompress.selected = False
        Me.bunifucompress.Size = New System.Drawing.Size(163, 56)
        Me.bunifucompress.TabIndex = 9
        Me.bunifucompress.Textcolor = System.Drawing.Color.White
        Me.bunifucompress.TextFont = New System.Drawing.Font("Segoe UI Symbol", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'cprogress
        '
        Me.cprogress.BackColor = System.Drawing.Color.Transparent
        Me.cprogress.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!)
        Me.cprogress.ForeColor = System.Drawing.Color.DarkTurquoise
        Me.cprogress.LabelVisible = True
        Me.cprogress.LineThickness = 10
        Me.cprogress.Location = New System.Drawing.Point(687, 107)
        Me.cprogress.Margin = New System.Windows.Forms.Padding(10, 9, 10, 9)
        Me.cprogress.MaxValue = 100
        Me.cprogress.Name = "cprogress"
        Me.cprogress.ProgressBackColor = System.Drawing.Color.LightSteelBlue
        Me.cprogress.ProgressColor = System.Drawing.Color.RoyalBlue
        Me.cprogress.Size = New System.Drawing.Size(156, 156)
        Me.cprogress.TabIndex = 8
        Me.cprogress.Value = 0
        '
        'Panel2
        '
        Me.Panel2.Location = New System.Drawing.Point(16, 72)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(816, 7)
        Me.Panel2.TabIndex = 12
        '
        'BunifuImageButton1
        '
        Me.BunifuImageButton1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton1.Image = Global.I_back_up_Mo_.My.Resources.Resources.appbar_home
        Me.BunifuImageButton1.ImageActive = Nothing
        Me.BunifuImageButton1.Location = New System.Drawing.Point(-1, 481)
        Me.BunifuImageButton1.Name = "BunifuImageButton1"
        Me.BunifuImageButton1.Size = New System.Drawing.Size(47, 43)
        Me.BunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton1.TabIndex = 25
        Me.BunifuImageButton1.TabStop = False
        Me.BunifuImageButton1.Zoom = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.I_back_up_Mo_.My.Resources.Resources.final___Copy
        Me.PictureBox1.Location = New System.Drawing.Point(-14, -49)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(256, 150)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 65
        Me.PictureBox1.TabStop = False
        '
        'ToolTip1
        '
        '
        'BunifuImageButton5
        '
        Me.BunifuImageButton5.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton5.Image = Global.I_back_up_Mo_.My.Resources.Resources.BAXFINAL1
        Me.BunifuImageButton5.ImageActive = Nothing
        Me.BunifuImageButton5.Location = New System.Drawing.Point(103, 14)
        Me.BunifuImageButton5.Name = "BunifuImageButton5"
        Me.BunifuImageButton5.Size = New System.Drawing.Size(120, 51)
        Me.BunifuImageButton5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton5.TabIndex = 66
        Me.BunifuImageButton5.TabStop = False
        Me.BunifuImageButton5.Zoom = 0
        '
        'ShellView1
        '
        Me.ShellView1.Location = New System.Drawing.Point(187, 54)
        Me.ShellView1.Name = "ShellView1"
        Me.ShellView1.Size = New System.Drawing.Size(455, 250)
        Me.ShellView1.StatusBar = Nothing
        Me.ShellView1.TabIndex = 71
        Me.ShellView1.Text = "ShellView1"
        Me.ShellView1.View = GongSolutions.Shell.ShellViewStyle.Details
        '
        'ShellTreeView1
        '
        Me.ShellTreeView1.Location = New System.Drawing.Point(23, 118)
        Me.ShellTreeView1.Name = "ShellTreeView1"
        Me.ShellTreeView1.ShellView = Me.ShellView1
        Me.ShellTreeView1.Size = New System.Drawing.Size(175, 275)
        Me.ShellTreeView1.TabIndex = 70
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Symbol", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label4.Location = New System.Drawing.Point(191, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 17)
        Me.Label4.TabIndex = 69
        Me.Label4.Text = "File name:"
        '
        'txtfolder
        '
        Me.txtfolder.Location = New System.Drawing.Point(283, 118)
        Me.txtfolder.Name = "txtfolder"
        Me.txtfolder.Size = New System.Drawing.Size(376, 20)
        Me.txtfolder.TabIndex = 68
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ShellView1)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(17, 90)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(651, 312)
        Me.GroupBox1.TabIndex = 72
        Me.GroupBox1.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.TextBox1.Enabled = False
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(-2, -2)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(656, 24)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.Text = "Compress Files"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.TextBox3)
        Me.GroupBox2.Controls.Add(Me.TextBox2)
        Me.GroupBox2.Location = New System.Drawing.Point(16, 413)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(652, 65)
        Me.GroupBox2.TabIndex = 73
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(616, 29)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(30, 23)
        Me.Button1.TabIndex = 76
        Me.Button1.Text = "..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Symbol", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label2.Location = New System.Drawing.Point(8, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 17)
        Me.Label2.TabIndex = 75
        Me.Label2.Text = "File name:"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(87, 31)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(523, 20)
        Me.TextBox3.TabIndex = 74
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.TextBox2.Enabled = False
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.ForeColor = System.Drawing.Color.White
        Me.TextBox2.Location = New System.Drawing.Point(-2, -3)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(656, 24)
        Me.TextBox2.TabIndex = 70
        Me.TextBox2.Text = "Decompress Files"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.I_back_up_Mo_.My.Resources.Resources.jjj
        Me.ClientSize = New System.Drawing.Size(862, 524)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.ShellTreeView1)
        Me.Controls.Add(Me.txtfolder)
        Me.Controls.Add(Me.BunifuImageButton5)
        Me.Controls.Add(Me.BunifuImageButton1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.bunifudecompress)
        Me.Controls.Add(Me.bunifucompress)
        Me.Controls.Add(Me.cprogress)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BunifuImageButton4)
        Me.Controls.Add(Me.lblclock)
        Me.Controls.Add(Me.BunifuImageButton2)
        Me.Controls.Add(Me.BunifuImageButton3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form2"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.BunifuImageButton3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BunifuImageButton3 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BunifuImageButton4 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents lblclock As System.Windows.Forms.Label
    Friend WithEvents BunifuImageButton2 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents bunifudecompress As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents bunifucompress As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents cprogress As Bunifu.Framework.UI.BunifuCircleProgressbar
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents BunifuImageButton1 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents BunifuImageButton5 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents ShellView1 As GongSolutions.Shell.ShellView
    Friend WithEvents ShellTreeView1 As GongSolutions.Shell.ShellTreeView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtfolder As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
