<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class splash_screen_loading
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
        components = New ComponentModel.Container()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(splash_screen_loading))
        Timer1 = New Timer(components)
        ProgressBar1_splash = New ProgressBar()
        Lblloading = New Label()
        Label1 = New Label()
        lbllifeline = New Label()
        lblbloodbank = New Label()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Timer1
        ' 
        ' 
        ' ProgressBar1_splash
        ' 
        ProgressBar1_splash.ForeColor = Color.Moccasin
        ProgressBar1_splash.Location = New Point(278, 533)
        ProgressBar1_splash.Name = "ProgressBar1_splash"
        ProgressBar1_splash.Size = New Size(553, 36)
        ProgressBar1_splash.TabIndex = 0
        ' 
        ' Lblloading
        ' 
        Lblloading.AutoSize = True
        Lblloading.Font = New Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        Lblloading.ForeColor = SystemColors.ButtonFace
        Lblloading.Location = New Point(278, 482)
        Lblloading.Name = "Lblloading"
        Lblloading.Size = New Size(105, 33)
        Lblloading.TabIndex = 1
        Lblloading.Text = "Label1"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 48F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        Label1.Location = New Point(363, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(349, 180)
        Label1.TabIndex = 2
        Label1.Text = "Welcome" & vbCrLf & " "
        ' 
        ' lbllifeline
        ' 
        lbllifeline.AutoSize = True
        lbllifeline.Font = New Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point)
        lbllifeline.ForeColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        lbllifeline.Location = New Point(419, 222)
        lbllifeline.Name = "lbllifeline"
        lbllifeline.Size = New Size(214, 45)
        lbllifeline.TabIndex = 27
        lbllifeline.Text = "LIFELINE"
        ' 
        ' lblbloodbank
        ' 
        lblbloodbank.AutoSize = True
        lblbloodbank.FlatStyle = FlatStyle.Flat
        lblbloodbank.Font = New Font("Times New Roman", 28.2F, FontStyle.Bold, GraphicsUnit.Point)
        lblbloodbank.ForeColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        lblbloodbank.Location = New Point(363, 267)
        lblbloodbank.Name = "lblbloodbank"
        lblbloodbank.Size = New Size(341, 159)
        lblbloodbank.TabIndex = 28
        lblbloodbank.Text = "BLOOD BANK" & vbCrLf & vbCrLf & vbCrLf
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(466, 107)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(119, 93)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 36
        PictureBox1.TabStop = False
        ' 
        ' splash_screen_loading
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.IndianRed
        ClientSize = New Size(1048, 627)
        Controls.Add(PictureBox1)
        Controls.Add(lblbloodbank)
        Controls.Add(lbllifeline)
        Controls.Add(Label1)
        Controls.Add(Lblloading)
        Controls.Add(ProgressBar1_splash)
        FormBorderStyle = FormBorderStyle.None
        Name = "splash_screen_loading"
        StartPosition = FormStartPosition.CenterScreen
        Text = "splash_screen_loading"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Timer1 As Timer
    Friend WithEvents ProgressBar1_splash As ProgressBar
    Friend WithEvents Lblloading As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lbllifeline As Label
    Friend WithEvents lblbloodbank As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
