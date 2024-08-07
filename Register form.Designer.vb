<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Register_form
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Register_form))
        Panel1_register = New Panel()
        CheckBox1_viewpass = New CheckBox()
        PictureBox1 = New PictureBox()
        lblemail = New Label()
        txtemail = New TextBox()
        btnregister = New Button()
        lblwelcome2 = New Label()
        txtconfirmpass = New TextBox()
        txtpass = New TextBox()
        txtusername = New TextBox()
        txtlastname = New TextBox()
        txtfirstname = New TextBox()
        lblregiuser = New Label()
        lbllogin = New Label()
        lblconfirmpass = New Label()
        lblpass = New Label()
        lblusername = New Label()
        lbllastname = New Label()
        lblfirstname = New Label()
        lblexit = New Label()
        Panel2 = New Panel()
        Panel1_register.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1_register
        ' 
        Panel1_register.Controls.Add(CheckBox1_viewpass)
        Panel1_register.Controls.Add(PictureBox1)
        Panel1_register.Controls.Add(lblemail)
        Panel1_register.Controls.Add(txtemail)
        Panel1_register.Controls.Add(btnregister)
        Panel1_register.Controls.Add(lblwelcome2)
        Panel1_register.Controls.Add(txtconfirmpass)
        Panel1_register.Controls.Add(txtpass)
        Panel1_register.Controls.Add(txtusername)
        Panel1_register.Controls.Add(txtlastname)
        Panel1_register.Controls.Add(txtfirstname)
        Panel1_register.Controls.Add(lblregiuser)
        Panel1_register.Controls.Add(lbllogin)
        Panel1_register.Controls.Add(lblconfirmpass)
        Panel1_register.Controls.Add(lblpass)
        Panel1_register.Controls.Add(lblusername)
        Panel1_register.Controls.Add(lbllastname)
        Panel1_register.Controls.Add(lblfirstname)
        Panel1_register.Font = New Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Panel1_register.Location = New Point(42, 63)
        Panel1_register.Name = "Panel1_register"
        Panel1_register.Size = New Size(862, 646)
        Panel1_register.TabIndex = 0
        ' 
        ' CheckBox1_viewpass
        ' 
        CheckBox1_viewpass.AutoSize = True
        CheckBox1_viewpass.Location = New Point(775, 295)
        CheckBox1_viewpass.Name = "CheckBox1_viewpass"
        CheckBox1_viewpass.Size = New Size(18, 17)
        CheckBox1_viewpass.TabIndex = 31
        CheckBox1_viewpass.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(372, 88)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(99, 78)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 30
        PictureBox1.TabStop = False
        ' 
        ' lblemail
        ' 
        lblemail.AutoSize = True
        lblemail.Font = New Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        lblemail.Location = New Point(80, 333)
        lblemail.Name = "lblemail"
        lblemail.Size = New Size(68, 25)
        lblemail.TabIndex = 27
        lblemail.Text = "Email"
        ' 
        ' txtemail
        ' 
        txtemail.Font = New Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        txtemail.Location = New Point(80, 361)
        txtemail.Name = "txtemail"
        txtemail.Size = New Size(293, 27)
        txtemail.TabIndex = 26
        ' 
        ' btnregister
        ' 
        btnregister.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        btnregister.FlatStyle = FlatStyle.Popup
        btnregister.Font = New Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        btnregister.ForeColor = SystemColors.Window
        btnregister.Location = New Point(268, 435)
        btnregister.Name = "btnregister"
        btnregister.Size = New Size(317, 46)
        btnregister.TabIndex = 25
        btnregister.Text = "Register"
        btnregister.UseVisualStyleBackColor = False
        ' 
        ' lblwelcome2
        ' 
        lblwelcome2.AutoSize = True
        lblwelcome2.Font = New Font("Times New Roman", 36F, FontStyle.Bold, GraphicsUnit.Point)
        lblwelcome2.ForeColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        lblwelcome2.Location = New Point(258, 17)
        lblwelcome2.Name = "lblwelcome2"
        lblwelcome2.Size = New Size(371, 68)
        lblwelcome2.TabIndex = 24
        lblwelcome2.Text = "WELCOME "
        ' 
        ' txtconfirmpass
        ' 
        txtconfirmpass.Font = New Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        txtconfirmpass.Location = New Point(476, 361)
        txtconfirmpass.Name = "txtconfirmpass"
        txtconfirmpass.Size = New Size(293, 27)
        txtconfirmpass.TabIndex = 21
        ' 
        ' txtpass
        ' 
        txtpass.Font = New Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        txtpass.Location = New Point(476, 290)
        txtpass.Name = "txtpass"
        txtpass.Size = New Size(293, 27)
        txtpass.TabIndex = 20
        txtpass.UseSystemPasswordChar = True
        ' 
        ' txtusername
        ' 
        txtusername.Font = New Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        txtusername.Location = New Point(80, 290)
        txtusername.Name = "txtusername"
        txtusername.Size = New Size(293, 27)
        txtusername.TabIndex = 19
        ' 
        ' txtlastname
        ' 
        txtlastname.Font = New Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        txtlastname.Location = New Point(476, 212)
        txtlastname.Name = "txtlastname"
        txtlastname.Size = New Size(293, 27)
        txtlastname.TabIndex = 18
        ' 
        ' txtfirstname
        ' 
        txtfirstname.Font = New Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        txtfirstname.Location = New Point(80, 212)
        txtfirstname.Name = "txtfirstname"
        txtfirstname.Size = New Size(293, 27)
        txtfirstname.TabIndex = 17
        ' 
        ' lblregiuser
        ' 
        lblregiuser.AutoSize = True
        lblregiuser.Font = New Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        lblregiuser.ForeColor = SystemColors.ActiveCaptionText
        lblregiuser.Location = New Point(80, 502)
        lblregiuser.Name = "lblregiuser"
        lblregiuser.Size = New Size(194, 25)
        lblregiuser.TabIndex = 16
        lblregiuser.Text = "A Registerd User?" & vbCrLf
        ' 
        ' lbllogin
        ' 
        lbllogin.AutoSize = True
        lbllogin.Font = New Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        lbllogin.ForeColor = SystemColors.HotTrack
        lbllogin.Location = New Point(477, 502)
        lbllogin.Name = "lbllogin"
        lbllogin.Size = New Size(120, 25)
        lbllogin.TabIndex = 15
        lbllogin.Text = "Login here"
        ' 
        ' lblconfirmpass
        ' 
        lblconfirmpass.AutoSize = True
        lblconfirmpass.Font = New Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        lblconfirmpass.Location = New Point(476, 333)
        lblconfirmpass.Name = "lblconfirmpass"
        lblconfirmpass.Size = New Size(199, 25)
        lblconfirmpass.TabIndex = 14
        lblconfirmpass.Text = "Confirm Password"
        ' 
        ' lblpass
        ' 
        lblpass.AutoSize = True
        lblpass.Font = New Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        lblpass.Location = New Point(476, 262)
        lblpass.Name = "lblpass"
        lblpass.Size = New Size(109, 25)
        lblpass.TabIndex = 13
        lblpass.Text = "Password"
        ' 
        ' lblusername
        ' 
        lblusername.AutoSize = True
        lblusername.Font = New Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        lblusername.Location = New Point(80, 262)
        lblusername.Name = "lblusername"
        lblusername.Size = New Size(124, 25)
        lblusername.TabIndex = 12
        lblusername.Text = "User Name"
        ' 
        ' lbllastname
        ' 
        lbllastname.AutoSize = True
        lbllastname.Font = New Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        lbllastname.Location = New Point(476, 184)
        lbllastname.Name = "lbllastname"
        lbllastname.Size = New Size(121, 25)
        lbllastname.TabIndex = 11
        lbllastname.Text = "Last Name"
        ' 
        ' lblfirstname
        ' 
        lblfirstname.AutoSize = True
        lblfirstname.Font = New Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        lblfirstname.Location = New Point(80, 184)
        lblfirstname.Name = "lblfirstname"
        lblfirstname.Size = New Size(124, 25)
        lblfirstname.TabIndex = 10
        lblfirstname.Text = "First Name"
        ' 
        ' lblexit
        ' 
        lblexit.FlatStyle = FlatStyle.Flat
        lblexit.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        lblexit.Location = New Point(912, 0)
        lblexit.Name = "lblexit"
        lblexit.Size = New Size(25, 36)
        lblexit.TabIndex = 8
        lblexit.Text = "x"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Red
        Panel2.Controls.Add(lblexit)
        Panel2.Location = New Point(-4, -1)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(951, 46)
        Panel2.TabIndex = 9
        ' 
        ' Register_form
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(945, 745)
        Controls.Add(Panel2)
        Controls.Add(Panel1_register)
        FormBorderStyle = FormBorderStyle.None
        Name = "Register_form"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Register_form"
        Panel1_register.ResumeLayout(False)
        Panel1_register.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1_register As Panel
    Friend WithEvents lblexit As Label
    Friend WithEvents lblregiuser As Label
    Friend WithEvents lbllogin As Label
    Friend WithEvents lblconfirmpass As Label
    Friend WithEvents lblpass As Label
    Friend WithEvents lblusername As Label
    Friend WithEvents lbllastname As Label
    Friend WithEvents lblfirstname As Label
    Friend WithEvents txtconfirmpass As TextBox
    Friend WithEvents txtpass As TextBox
    Friend WithEvents txtusername As TextBox
    Friend WithEvents txtlastname As TextBox
    Friend WithEvents txtfirstname As TextBox
    Friend WithEvents btnregister As Button
    Friend WithEvents lblwelcome2 As Label
    Friend WithEvents lblemail As Label
    Friend WithEvents txtemail As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents CheckBox1_viewpass As CheckBox
End Class
