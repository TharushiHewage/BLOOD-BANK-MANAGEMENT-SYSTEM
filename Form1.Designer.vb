<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        lblexit1 = New Label()
        Panel3_username = New Panel()
        txtusername = New TextBox()
        PictureBox3_username = New PictureBox()
        PictureBox2_adminpic = New PictureBox()
        Lbladminlogin = New Label()
        btnlogin = New Button()
        lblnewuser = New Label()
        lblregister = New Label()
        Panel2_pass = New Panel()
        Txtpass = New TextBox()
        PictureBox1_pass = New PictureBox()
        Panel1_login = New Panel()
        Panel2_forget = New Panel()
        txtanswer = New TextBox()
        lblsecurity = New Label()
        btnsubmit = New Button()
        btnforget = New Button()
        Panel1 = New Panel()
        Label1 = New Label()
        CheckBox1_viewpass = New CheckBox()
        Panel2_login = New Panel()
        Panel3_username.SuspendLayout()
        CType(PictureBox3_username, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2_adminpic, ComponentModel.ISupportInitialize).BeginInit()
        Panel2_pass.SuspendLayout()
        CType(PictureBox1_pass, ComponentModel.ISupportInitialize).BeginInit()
        Panel1_login.SuspendLayout()
        Panel2_forget.SuspendLayout()
        Panel2_login.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblexit1
        ' 
        lblexit1.AutoSize = True
        lblexit1.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        lblexit1.Location = New Point(796, 8)
        lblexit1.Name = "lblexit1"
        lblexit1.Size = New Size(22, 25)
        lblexit1.TabIndex = 7
        lblexit1.Text = "x"
        ' 
        ' Panel3_username
        ' 
        Panel3_username.Controls.Add(txtusername)
        Panel3_username.Controls.Add(PictureBox3_username)
        Panel3_username.Location = New Point(113, 278)
        Panel3_username.Name = "Panel3_username"
        Panel3_username.Size = New Size(323, 58)
        Panel3_username.TabIndex = 7
        ' 
        ' txtusername
        ' 
        txtusername.BorderStyle = BorderStyle.None
        txtusername.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        txtusername.ForeColor = Color.Black
        txtusername.Location = New Point(56, 15)
        txtusername.Name = "txtusername"
        txtusername.Size = New Size(254, 23)
        txtusername.TabIndex = 1
        ' 
        ' PictureBox3_username
        ' 
        PictureBox3_username.BackColor = Color.White
        PictureBox3_username.Image = CType(resources.GetObject("PictureBox3_username.Image"), Image)
        PictureBox3_username.Location = New Point(3, 3)
        PictureBox3_username.Name = "PictureBox3_username"
        PictureBox3_username.Size = New Size(31, 35)
        PictureBox3_username.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3_username.TabIndex = 0
        PictureBox3_username.TabStop = False
        ' 
        ' PictureBox2_adminpic
        ' 
        PictureBox2_adminpic.Image = CType(resources.GetObject("PictureBox2_adminpic.Image"), Image)
        PictureBox2_adminpic.Location = New Point(188, 65)
        PictureBox2_adminpic.Name = "PictureBox2_adminpic"
        PictureBox2_adminpic.Size = New Size(156, 156)
        PictureBox2_adminpic.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2_adminpic.TabIndex = 8
        PictureBox2_adminpic.TabStop = False
        ' 
        ' Lbladminlogin
        ' 
        Lbladminlogin.AutoSize = True
        Lbladminlogin.FlatStyle = FlatStyle.Flat
        Lbladminlogin.Font = New Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Lbladminlogin.Location = New Point(198, 237)
        Lbladminlogin.Name = "Lbladminlogin"
        Lbladminlogin.Size = New Size(141, 25)
        Lbladminlogin.TabIndex = 9
        Lbladminlogin.Text = "Admin Login"
        ' 
        ' btnlogin
        ' 
        btnlogin.BackColor = Color.Gray
        btnlogin.FlatStyle = FlatStyle.Popup
        btnlogin.Font = New Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        btnlogin.Location = New Point(110, 454)
        btnlogin.Name = "btnlogin"
        btnlogin.Size = New Size(323, 51)
        btnlogin.TabIndex = 10
        btnlogin.Text = "Login"
        btnlogin.UseVisualStyleBackColor = False
        ' 
        ' lblnewuser
        ' 
        lblnewuser.AutoSize = True
        lblnewuser.FlatStyle = FlatStyle.Flat
        lblnewuser.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblnewuser.Location = New Point(110, 534)
        lblnewuser.Name = "lblnewuser"
        lblnewuser.Size = New Size(121, 23)
        lblnewuser.TabIndex = 11
        lblnewuser.Text = "A New User?"
        ' 
        ' lblregister
        ' 
        lblregister.AutoSize = True
        lblregister.FlatStyle = FlatStyle.Flat
        lblregister.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblregister.ForeColor = SystemColors.HotTrack
        lblregister.Location = New Point(295, 534)
        lblregister.Name = "lblregister"
        lblregister.Size = New Size(125, 23)
        lblregister.TabIndex = 12
        lblregister.Text = "Register here"
        ' 
        ' Panel2_pass
        ' 
        Panel2_pass.Controls.Add(Txtpass)
        Panel2_pass.Controls.Add(PictureBox1_pass)
        Panel2_pass.Location = New Point(113, 342)
        Panel2_pass.Name = "Panel2_pass"
        Panel2_pass.Size = New Size(323, 58)
        Panel2_pass.TabIndex = 13
        ' 
        ' Txtpass
        ' 
        Txtpass.BorderStyle = BorderStyle.None
        Txtpass.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Txtpass.ForeColor = Color.Black
        Txtpass.Location = New Point(56, 15)
        Txtpass.Name = "Txtpass"
        Txtpass.PasswordChar = "*"c
        Txtpass.Size = New Size(254, 23)
        Txtpass.TabIndex = 1
        ' 
        ' PictureBox1_pass
        ' 
        PictureBox1_pass.BackColor = Color.White
        PictureBox1_pass.Image = CType(resources.GetObject("PictureBox1_pass.Image"), Image)
        PictureBox1_pass.Location = New Point(0, 0)
        PictureBox1_pass.Name = "PictureBox1_pass"
        PictureBox1_pass.Size = New Size(31, 35)
        PictureBox1_pass.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1_pass.TabIndex = 0
        PictureBox1_pass.TabStop = False
        ' 
        ' Panel1_login
        ' 
        Panel1_login.Controls.Add(Panel2_forget)
        Panel1_login.Controls.Add(btnforget)
        Panel1_login.Controls.Add(Panel1)
        Panel1_login.Controls.Add(Label1)
        Panel1_login.Controls.Add(CheckBox1_viewpass)
        Panel1_login.Controls.Add(Panel2_pass)
        Panel1_login.Controls.Add(lblregister)
        Panel1_login.Controls.Add(lblnewuser)
        Panel1_login.Controls.Add(btnlogin)
        Panel1_login.Controls.Add(Lbladminlogin)
        Panel1_login.Controls.Add(PictureBox2_adminpic)
        Panel1_login.Controls.Add(Panel3_username)
        Panel1_login.Location = New Point(151, 53)
        Panel1_login.Name = "Panel1_login"
        Panel1_login.Size = New Size(549, 863)
        Panel1_login.TabIndex = 8
        ' 
        ' Panel2_forget
        ' 
        Panel2_forget.Controls.Add(txtanswer)
        Panel2_forget.Controls.Add(lblsecurity)
        Panel2_forget.Controls.Add(btnsubmit)
        Panel2_forget.Location = New Point(24, 660)
        Panel2_forget.Name = "Panel2_forget"
        Panel2_forget.Size = New Size(504, 163)
        Panel2_forget.TabIndex = 39
        ' 
        ' txtanswer
        ' 
        txtanswer.Font = New Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        txtanswer.Location = New Point(63, 62)
        txtanswer.Name = "txtanswer"
        txtanswer.Size = New Size(370, 27)
        txtanswer.TabIndex = 41
        ' 
        ' lblsecurity
        ' 
        lblsecurity.AutoSize = True
        lblsecurity.Font = New Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        lblsecurity.ForeColor = Color.Snow
        lblsecurity.Location = New Point(54, 18)
        lblsecurity.Name = "lblsecurity"
        lblsecurity.Size = New Size(392, 21)
        lblsecurity.TabIndex = 40
        lblsecurity.Text = "ENTER YOUR REGISTERD EMAIL ADDRESS"
        ' 
        ' btnsubmit
        ' 
        btnsubmit.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        btnsubmit.FlatStyle = FlatStyle.Popup
        btnsubmit.Font = New Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        btnsubmit.Location = New Point(196, 113)
        btnsubmit.Name = "btnsubmit"
        btnsubmit.Size = New Size(94, 29)
        btnsubmit.TabIndex = 39
        btnsubmit.Text = "Submit"
        btnsubmit.UseVisualStyleBackColor = False
        ' 
        ' btnforget
        ' 
        btnforget.BackColor = Color.RosyBrown
        btnforget.FlatStyle = FlatStyle.Popup
        btnforget.Font = New Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        btnforget.Location = New Point(169, 604)
        btnforget.Name = "btnforget"
        btnforget.Size = New Size(188, 40)
        btnforget.TabIndex = 35
        btnforget.Text = "Forgot password"
        btnforget.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.PaleGreen
        Panel1.ForeColor = Color.Black
        Panel1.Location = New Point(0, 594)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(549, 4)
        Panel1.TabIndex = 34
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(140, 415)
        Label1.Name = "Label1"
        Label1.Size = New Size(123, 19)
        Label1.TabIndex = 33
        Label1.Text = "Show password"
        ' 
        ' CheckBox1_viewpass
        ' 
        CheckBox1_viewpass.AutoSize = True
        CheckBox1_viewpass.Location = New Point(116, 417)
        CheckBox1_viewpass.Name = "CheckBox1_viewpass"
        CheckBox1_viewpass.Size = New Size(18, 17)
        CheckBox1_viewpass.TabIndex = 32
        CheckBox1_viewpass.UseVisualStyleBackColor = True
        ' 
        ' Panel2_login
        ' 
        Panel2_login.BackColor = Color.Red
        Panel2_login.Controls.Add(lblexit1)
        Panel2_login.Location = New Point(-1, 1)
        Panel2_login.Name = "Panel2_login"
        Panel2_login.Size = New Size(847, 46)
        Panel2_login.TabIndex = 9
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(240), CByte(244), CByte(247))
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(844, 888)
        Controls.Add(Panel2_login)
        Controls.Add(Panel1_login)
        FormBorderStyle = FormBorderStyle.None
        MaximizeBox = False
        MinimizeBox = False
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "login"
        Panel3_username.ResumeLayout(False)
        Panel3_username.PerformLayout()
        CType(PictureBox3_username, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2_adminpic, ComponentModel.ISupportInitialize).EndInit()
        Panel2_pass.ResumeLayout(False)
        Panel2_pass.PerformLayout()
        CType(PictureBox1_pass, ComponentModel.ISupportInitialize).EndInit()
        Panel1_login.ResumeLayout(False)
        Panel1_login.PerformLayout()
        Panel2_forget.ResumeLayout(False)
        Panel2_forget.PerformLayout()
        Panel2_login.ResumeLayout(False)
        Panel2_login.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents lblexit1 As Label
    Friend WithEvents Panel3_username As Panel
    Friend WithEvents txtusername As TextBox
    Friend WithEvents PictureBox3_username As PictureBox
    Friend WithEvents PictureBox2_adminpic As PictureBox
    Friend WithEvents Lbladminlogin As Label
    Friend WithEvents btnlogin As Button
    Friend WithEvents lblnewuser As Label
    Friend WithEvents lblregister As Label
    Friend WithEvents Panel2_pass As Panel
    Friend WithEvents Txtpass As TextBox
    Friend WithEvents PictureBox1_pass As PictureBox
    Friend WithEvents Panel1_login As Panel
    Friend WithEvents Panel2_login As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents CheckBox1_viewpass As CheckBox
    Friend WithEvents btnforget As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2_forget As Panel
    Friend WithEvents txtanswer As TextBox
    Friend WithEvents lblsecurity As Label
    Friend WithEvents btnsubmit As Button
End Class
