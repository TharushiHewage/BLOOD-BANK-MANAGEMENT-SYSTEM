<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dashboard_form
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(dashboard_form))
        PanelTittlebar = New Panel()
        btnadminpic = New Button()
        lblname = New Label()
        btnaboutus = New Button()
        ButtonMaximized = New Button()
        btnLogout = New Button()
        Btndoctor = New Button()
        btneligibilityform = New Button()
        Btnminimize = New Button()
        Btnbloodrequest = New Button()
        btnexit = New Button()
        Btnbloodstock = New Button()
        Panel1 = New Panel()
        Panel4 = New Panel()
        Panel3 = New Panel()
        PanelDekstop = New Panel()
        lblApproved = New Label()
        LabelOMinus = New Label()
        LabelOPlus = New Label()
        LabelABMinus = New Label()
        LabelABPlus = New Label()
        LabelBMinus = New Label()
        LabelBPlus = New Label()
        LabelAMinus = New Label()
        LabelAPlus = New Label()
        lbltotal_doctor = New Label()
        lbltotal_blood = New Label()
        btntotaldoctor = New Button()
        btn_approvedblood = New Button()
        btntotalbloodstock_available = New Button()
        Panel5_eligibility = New Panel()
        btncheck2 = New Button()
        Label1 = New Label()
        lblregiuser = New Label()
        PictureBox1 = New PictureBox()
        Label1_eligible = New Label()
        btncheck1 = New Button()
        lblage = New Label()
        Panel5 = New Panel()
        PanelTittlebar.SuspendLayout()
        Panel1.SuspendLayout()
        PanelDekstop.SuspendLayout()
        Panel5_eligibility.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PanelTittlebar
        ' 
        PanelTittlebar.BackColor = Color.FromArgb(CByte(179), CByte(14), CByte(8))
        PanelTittlebar.Controls.Add(btnadminpic)
        PanelTittlebar.Controls.Add(lblname)
        PanelTittlebar.Controls.Add(btnaboutus)
        PanelTittlebar.Controls.Add(ButtonMaximized)
        PanelTittlebar.Controls.Add(btnLogout)
        PanelTittlebar.Controls.Add(Btndoctor)
        PanelTittlebar.Controls.Add(btneligibilityform)
        PanelTittlebar.Controls.Add(Btnminimize)
        PanelTittlebar.Controls.Add(Btnbloodrequest)
        PanelTittlebar.Controls.Add(btnexit)
        PanelTittlebar.Controls.Add(Btnbloodstock)
        PanelTittlebar.Dock = DockStyle.Top
        PanelTittlebar.Location = New Point(0, 0)
        PanelTittlebar.Name = "PanelTittlebar"
        PanelTittlebar.Size = New Size(1749, 156)
        PanelTittlebar.TabIndex = 0
        ' 
        ' btnadminpic
        ' 
        btnadminpic.BackgroundImage = CType(resources.GetObject("btnadminpic.BackgroundImage"), Image)
        btnadminpic.BackgroundImageLayout = ImageLayout.Stretch
        btnadminpic.FlatStyle = FlatStyle.Flat
        btnadminpic.ForeColor = Color.FromArgb(CByte(179), CByte(14), CByte(8))
        btnadminpic.Location = New Point(63, 30)
        btnadminpic.Name = "btnadminpic"
        btnadminpic.Size = New Size(32, 31)
        btnadminpic.TabIndex = 31
        btnadminpic.UseVisualStyleBackColor = True
        ' 
        ' lblname
        ' 
        lblname.AutoSize = True
        lblname.FlatStyle = FlatStyle.Flat
        lblname.Font = New Font("Arial", 13F, FontStyle.Bold, GraphicsUnit.Point)
        lblname.ForeColor = Color.White
        lblname.Location = New Point(41, 78)
        lblname.Name = "lblname"
        lblname.Size = New Size(77, 26)
        lblname.TabIndex = 30
        lblname.Text = "Admin"
        ' 
        ' btnaboutus
        ' 
        btnaboutus.BackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        btnaboutus.FlatAppearance.BorderSize = 0
        btnaboutus.FlatStyle = FlatStyle.Flat
        btnaboutus.Font = New Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point)
        btnaboutus.ForeColor = Color.White
        btnaboutus.Location = New Point(1521, 78)
        btnaboutus.Name = "btnaboutus"
        btnaboutus.Size = New Size(191, 63)
        btnaboutus.TabIndex = 29
        btnaboutus.Text = "About Us"
        btnaboutus.UseVisualStyleBackColor = False
        ' 
        ' ButtonMaximized
        ' 
        ButtonMaximized.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        ButtonMaximized.BackColor = Color.FromArgb(CByte(179), CByte(14), CByte(8))
        ButtonMaximized.FlatAppearance.BorderSize = 0
        ButtonMaximized.FlatStyle = FlatStyle.Flat
        ButtonMaximized.Font = New Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        ButtonMaximized.ForeColor = SystemColors.ButtonFace
        ButtonMaximized.Image = CType(resources.GetObject("ButtonMaximized.Image"), Image)
        ButtonMaximized.Location = New Point(1619, 12)
        ButtonMaximized.Name = "ButtonMaximized"
        ButtonMaximized.Size = New Size(41, 36)
        ButtonMaximized.TabIndex = 24
        ButtonMaximized.UseVisualStyleBackColor = False
        ' 
        ' btnLogout
        ' 
        btnLogout.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnLogout.BackColor = Color.FromArgb(CByte(179), CByte(14), CByte(8))
        btnLogout.FlatAppearance.BorderSize = 0
        btnLogout.FlatStyle = FlatStyle.Flat
        btnLogout.Font = New Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        btnLogout.ForeColor = SystemColors.ButtonFace
        btnLogout.Image = CType(resources.GetObject("btnLogout.Image"), Image)
        btnLogout.Location = New Point(1459, 12)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(41, 36)
        btnLogout.TabIndex = 23
        btnLogout.UseVisualStyleBackColor = False
        ' 
        ' Btndoctor
        ' 
        Btndoctor.BackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        Btndoctor.FlatAppearance.BorderSize = 0
        Btndoctor.FlatStyle = FlatStyle.Flat
        Btndoctor.Font = New Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Btndoctor.ForeColor = Color.White
        Btndoctor.Location = New Point(1191, 78)
        Btndoctor.Name = "Btndoctor"
        Btndoctor.Size = New Size(258, 63)
        Btndoctor.TabIndex = 28
        Btndoctor.Text = "Medical Officer"
        Btndoctor.UseVisualStyleBackColor = False
        ' 
        ' btneligibilityform
        ' 
        btneligibilityform.BackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        btneligibilityform.FlatAppearance.BorderSize = 0
        btneligibilityform.FlatStyle = FlatStyle.Flat
        btneligibilityform.Font = New Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point)
        btneligibilityform.ForeColor = Color.White
        btneligibilityform.Location = New Point(179, 78)
        btneligibilityform.Name = "btneligibilityform"
        btneligibilityform.Size = New Size(324, 63)
        btneligibilityform.TabIndex = 27
        btneligibilityform.Text = "Donation conditions"
        btneligibilityform.UseVisualStyleBackColor = False
        ' 
        ' Btnminimize
        ' 
        Btnminimize.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Btnminimize.BackColor = Color.FromArgb(CByte(179), CByte(14), CByte(8))
        Btnminimize.FlatAppearance.BorderSize = 0
        Btnminimize.FlatStyle = FlatStyle.Flat
        Btnminimize.Font = New Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Btnminimize.ForeColor = SystemColors.ButtonFace
        Btnminimize.Image = CType(resources.GetObject("Btnminimize.Image"), Image)
        Btnminimize.Location = New Point(1547, 12)
        Btnminimize.Name = "Btnminimize"
        Btnminimize.Size = New Size(41, 36)
        Btnminimize.TabIndex = 21
        Btnminimize.UseVisualStyleBackColor = False
        ' 
        ' Btnbloodrequest
        ' 
        Btnbloodrequest.BackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        Btnbloodrequest.FlatAppearance.BorderSize = 0
        Btnbloodrequest.FlatStyle = FlatStyle.Flat
        Btnbloodrequest.Font = New Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Btnbloodrequest.ForeColor = Color.White
        Btnbloodrequest.Location = New Point(570, 78)
        Btnbloodrequest.Name = "Btnbloodrequest"
        Btnbloodrequest.Size = New Size(248, 63)
        Btnbloodrequest.TabIndex = 26
        Btnbloodrequest.Text = "Blood Request"
        Btnbloodrequest.UseVisualStyleBackColor = False
        ' 
        ' btnexit
        ' 
        btnexit.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnexit.BackColor = Color.FromArgb(CByte(179), CByte(14), CByte(8))
        btnexit.FlatAppearance.BorderSize = 0
        btnexit.FlatStyle = FlatStyle.Flat
        btnexit.Font = New Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        btnexit.ForeColor = SystemColors.ButtonFace
        btnexit.Image = CType(resources.GetObject("btnexit.Image"), Image)
        btnexit.Location = New Point(1683, 12)
        btnexit.Name = "btnexit"
        btnexit.Size = New Size(41, 36)
        btnexit.TabIndex = 20
        btnexit.UseVisualStyleBackColor = False
        ' 
        ' Btnbloodstock
        ' 
        Btnbloodstock.BackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        Btnbloodstock.FlatAppearance.BorderSize = 0
        Btnbloodstock.FlatStyle = FlatStyle.Flat
        Btnbloodstock.Font = New Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Btnbloodstock.ForeColor = Color.White
        Btnbloodstock.Location = New Point(886, 78)
        Btnbloodstock.Name = "Btnbloodstock"
        Btnbloodstock.Size = New Size(234, 63)
        Btnbloodstock.TabIndex = 25
        Btnbloodstock.Text = "Blood Stock"
        Btnbloodstock.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(179), CByte(14), CByte(8))
        Panel1.Controls.Add(Panel4)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 156)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(66, 946)
        Panel1.TabIndex = 21
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.FromArgb(CByte(179), CByte(14), CByte(8))
        Panel4.Dock = DockStyle.Left
        Panel4.Location = New Point(0, 0)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(66, 946)
        Panel4.TabIndex = 22
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(179), CByte(14), CByte(8))
        Panel3.Dock = DockStyle.Bottom
        Panel3.Location = New Point(66, 991)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1683, 111)
        Panel3.TabIndex = 22
        ' 
        ' PanelDekstop
        ' 
        PanelDekstop.BackColor = Color.OldLace
        PanelDekstop.Controls.Add(lblApproved)
        PanelDekstop.Controls.Add(LabelOMinus)
        PanelDekstop.Controls.Add(LabelOPlus)
        PanelDekstop.Controls.Add(LabelABMinus)
        PanelDekstop.Controls.Add(LabelABPlus)
        PanelDekstop.Controls.Add(LabelBMinus)
        PanelDekstop.Controls.Add(LabelBPlus)
        PanelDekstop.Controls.Add(LabelAMinus)
        PanelDekstop.Controls.Add(LabelAPlus)
        PanelDekstop.Controls.Add(lbltotal_doctor)
        PanelDekstop.Controls.Add(lbltotal_blood)
        PanelDekstop.Controls.Add(btntotaldoctor)
        PanelDekstop.Controls.Add(btn_approvedblood)
        PanelDekstop.Controls.Add(btntotalbloodstock_available)
        PanelDekstop.Controls.Add(Panel5_eligibility)
        PanelDekstop.Dock = DockStyle.Fill
        PanelDekstop.Font = New Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        PanelDekstop.Location = New Point(66, 156)
        PanelDekstop.Name = "PanelDekstop"
        PanelDekstop.Size = New Size(1683, 835)
        PanelDekstop.TabIndex = 23
        ' 
        ' lblApproved
        ' 
        lblApproved.AutoSize = True
        lblApproved.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        lblApproved.Font = New Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point)
        lblApproved.Location = New Point(864, 645)
        lblApproved.Name = "lblApproved"
        lblApproved.Size = New Size(110, 35)
        lblApproved.TabIndex = 37
        lblApproved.Text = "Label2"
        ' 
        ' LabelOMinus
        ' 
        LabelOMinus.AutoSize = True
        LabelOMinus.Font = New Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        LabelOMinus.Location = New Point(1436, 596)
        LabelOMinus.Name = "LabelOMinus"
        LabelOMinus.Size = New Size(105, 33)
        LabelOMinus.TabIndex = 36
        LabelOMinus.Text = "Label9"
        ' 
        ' LabelOPlus
        ' 
        LabelOPlus.AutoSize = True
        LabelOPlus.Font = New Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        LabelOPlus.Location = New Point(1232, 596)
        LabelOPlus.Name = "LabelOPlus"
        LabelOPlus.Size = New Size(105, 33)
        LabelOPlus.TabIndex = 35
        LabelOPlus.Text = "Label8"
        ' 
        ' LabelABMinus
        ' 
        LabelABMinus.AutoSize = True
        LabelABMinus.Font = New Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        LabelABMinus.Location = New Point(1436, 446)
        LabelABMinus.Name = "LabelABMinus"
        LabelABMinus.Size = New Size(105, 33)
        LabelABMinus.TabIndex = 34
        LabelABMinus.Text = "Label7"
        ' 
        ' LabelABPlus
        ' 
        LabelABPlus.AutoSize = True
        LabelABPlus.Font = New Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        LabelABPlus.Location = New Point(1232, 460)
        LabelABPlus.Name = "LabelABPlus"
        LabelABPlus.Size = New Size(105, 33)
        LabelABPlus.TabIndex = 33
        LabelABPlus.Text = "Label6"
        ' 
        ' LabelBMinus
        ' 
        LabelBMinus.AutoSize = True
        LabelBMinus.Font = New Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        LabelBMinus.Location = New Point(1436, 328)
        LabelBMinus.Name = "LabelBMinus"
        LabelBMinus.Size = New Size(105, 33)
        LabelBMinus.TabIndex = 32
        LabelBMinus.Text = "Label5"
        ' 
        ' LabelBPlus
        ' 
        LabelBPlus.AutoSize = True
        LabelBPlus.Font = New Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        LabelBPlus.Location = New Point(1234, 328)
        LabelBPlus.Name = "LabelBPlus"
        LabelBPlus.Size = New Size(105, 33)
        LabelBPlus.TabIndex = 31
        LabelBPlus.Text = "Label4"
        ' 
        ' LabelAMinus
        ' 
        LabelAMinus.AutoSize = True
        LabelAMinus.Font = New Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        LabelAMinus.Location = New Point(1436, 167)
        LabelAMinus.Name = "LabelAMinus"
        LabelAMinus.Size = New Size(105, 33)
        LabelAMinus.TabIndex = 30
        LabelAMinus.Text = "Label3"
        ' 
        ' LabelAPlus
        ' 
        LabelAPlus.AutoSize = True
        LabelAPlus.Font = New Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        LabelAPlus.Location = New Point(1232, 167)
        LabelAPlus.Name = "LabelAPlus"
        LabelAPlus.Size = New Size(105, 33)
        LabelAPlus.TabIndex = 29
        LabelAPlus.Text = "Label2"
        ' 
        ' lbltotal_doctor
        ' 
        lbltotal_doctor.AutoSize = True
        lbltotal_doctor.BackColor = Color.PaleGoldenrod
        lbltotal_doctor.FlatStyle = FlatStyle.Popup
        lbltotal_doctor.Font = New Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point)
        lbltotal_doctor.Location = New Point(864, 428)
        lbltotal_doctor.Name = "lbltotal_doctor"
        lbltotal_doctor.Size = New Size(110, 35)
        lbltotal_doctor.TabIndex = 27
        lbltotal_doctor.Text = "Label2"
        ' 
        ' lbltotal_blood
        ' 
        lbltotal_blood.AutoSize = True
        lbltotal_blood.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        lbltotal_blood.FlatStyle = FlatStyle.Popup
        lbltotal_blood.Font = New Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point)
        lbltotal_blood.Location = New Point(864, 201)
        lbltotal_blood.Name = "lbltotal_blood"
        lbltotal_blood.Size = New Size(110, 35)
        lbltotal_blood.TabIndex = 26
        lbltotal_blood.Text = "Label1"
        ' 
        ' btntotaldoctor
        ' 
        btntotaldoctor.BackColor = Color.PaleGoldenrod
        btntotaldoctor.FlatStyle = FlatStyle.Popup
        btntotaldoctor.Location = New Point(707, 338)
        btntotaldoctor.Name = "btntotaldoctor"
        btntotaldoctor.Size = New Size(416, 135)
        btntotaldoctor.TabIndex = 25
        btntotaldoctor.Text = "Total Medical officers Available" & vbCrLf
        btntotaldoctor.UseVisualStyleBackColor = False
        ' 
        ' btn_approvedblood
        ' 
        btn_approvedblood.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        btn_approvedblood.FlatStyle = FlatStyle.Popup
        btn_approvedblood.Location = New Point(707, 560)
        btn_approvedblood.Name = "btn_approvedblood"
        btn_approvedblood.Size = New Size(416, 135)
        btn_approvedblood.TabIndex = 24
        btn_approvedblood.Text = "Approved Blood Request"
        btn_approvedblood.UseVisualStyleBackColor = False
        ' 
        ' btntotalbloodstock_available
        ' 
        btntotalbloodstock_available.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        btntotalbloodstock_available.FlatStyle = FlatStyle.Popup
        btntotalbloodstock_available.Location = New Point(707, 116)
        btntotalbloodstock_available.Name = "btntotalbloodstock_available"
        btntotalbloodstock_available.Size = New Size(416, 135)
        btntotalbloodstock_available.TabIndex = 23
        btntotalbloodstock_available.Text = "Total Blood Stock Available"
        btntotalbloodstock_available.UseVisualStyleBackColor = False
        ' 
        ' Panel5_eligibility
        ' 
        Panel5_eligibility.BackColor = Color.NavajoWhite
        Panel5_eligibility.Controls.Add(btncheck2)
        Panel5_eligibility.Controls.Add(Label1)
        Panel5_eligibility.Controls.Add(lblregiuser)
        Panel5_eligibility.Controls.Add(PictureBox1)
        Panel5_eligibility.Controls.Add(Label1_eligible)
        Panel5_eligibility.Controls.Add(btncheck1)
        Panel5_eligibility.Controls.Add(lblage)
        Panel5_eligibility.Location = New Point(43, 45)
        Panel5_eligibility.Name = "Panel5_eligibility"
        Panel5_eligibility.Size = New Size(580, 802)
        Panel5_eligibility.TabIndex = 21
        ' 
        ' btncheck2
        ' 
        btncheck2.BackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        btncheck2.FlatStyle = FlatStyle.Popup
        btncheck2.Font = New Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        btncheck2.ForeColor = Color.White
        btncheck2.Location = New Point(212, 656)
        btncheck2.Name = "btncheck2"
        btncheck2.Size = New Size(149, 42)
        btncheck2.TabIndex = 31
        btncheck2.Text = "Click Here"
        btncheck2.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = SystemColors.ActiveCaptionText
        Label1.Location = New Point(150, 578)
        Label1.Name = "Label1"
        Label1.Size = New Size(276, 38)
        Label1.TabIndex = 30
        Label1.Text = "A rejected donor?" & vbCrLf
        ' 
        ' lblregiuser
        ' 
        lblregiuser.AutoSize = True
        lblregiuser.Font = New Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point)
        lblregiuser.ForeColor = SystemColors.ActiveCaptionText
        lblregiuser.Location = New Point(150, 415)
        lblregiuser.Name = "lblregiuser"
        lblregiuser.Size = New Size(298, 38)
        lblregiuser.TabIndex = 29
        lblregiuser.Text = "A approved donor?" & vbCrLf
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(122, 119)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(323, 238)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 22
        PictureBox1.TabStop = False
        ' 
        ' Label1_eligible
        ' 
        Label1_eligible.AutoSize = True
        Label1_eligible.BackColor = Color.NavajoWhite
        Label1_eligible.FlatStyle = FlatStyle.Flat
        Label1_eligible.Font = New Font("Arial", 22.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label1_eligible.ForeColor = SystemColors.ActiveCaptionText
        Label1_eligible.Location = New Point(112, 38)
        Label1_eligible.Name = "Label1_eligible"
        Label1_eligible.Size = New Size(366, 44)
        Label1_eligible.TabIndex = 15
        Label1_eligible.Text = " Donor Registration"
        ' 
        ' btncheck1
        ' 
        btncheck1.BackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        btncheck1.FlatStyle = FlatStyle.Popup
        btncheck1.Font = New Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        btncheck1.ForeColor = Color.White
        btncheck1.Location = New Point(212, 486)
        btncheck1.Name = "btncheck1"
        btncheck1.Size = New Size(149, 42)
        btncheck1.TabIndex = 18
        btncheck1.Text = "Click Here"
        btncheck1.UseVisualStyleBackColor = False
        ' 
        ' lblage
        ' 
        lblage.AutoSize = True
        lblage.Font = New Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point)
        lblage.Location = New Point(55, 398)
        lblage.Name = "lblage"
        lblage.Size = New Size(0, 35)
        lblage.TabIndex = 16
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.FromArgb(CByte(179), CByte(14), CByte(8))
        Panel5.Dock = DockStyle.Right
        Panel5.Location = New Point(1683, 156)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(66, 835)
        Panel5.TabIndex = 23
        ' 
        ' dashboard_form
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1749, 1102)
        Controls.Add(Panel5)
        Controls.Add(PanelDekstop)
        Controls.Add(Panel3)
        Controls.Add(Panel1)
        Controls.Add(PanelTittlebar)
        FormBorderStyle = FormBorderStyle.None
        Name = "dashboard_form"
        StartPosition = FormStartPosition.CenterScreen
        Text = "dashboard_form"
        PanelTittlebar.ResumeLayout(False)
        PanelTittlebar.PerformLayout()
        Panel1.ResumeLayout(False)
        PanelDekstop.ResumeLayout(False)
        PanelDekstop.PerformLayout()
        Panel5_eligibility.ResumeLayout(False)
        Panel5_eligibility.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PanelTittlebar As Panel
    Friend WithEvents Btnminimize As Button
    Friend WithEvents btnexit As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents ButtonMaximized As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PanelDekstop As Panel
    Friend WithEvents Btndoctor As Button
    Friend WithEvents btneligibilityform As Button
    Friend WithEvents Btnbloodrequest As Button
    Friend WithEvents Btnbloodstock As Button
    Friend WithEvents Panel5_eligibility As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1_eligible As Label
    Friend WithEvents btncheck1 As Button
    Friend WithEvents lblage As Label
    Friend WithEvents btnaboutus As Button
    Friend WithEvents lblname As Label
    Friend WithEvents btnadminpic As Button
    Friend WithEvents btn_approvedblood As Button
    Friend WithEvents btntotalbloodstock_available As Button
    Friend WithEvents btntotaldoctor As Button
    Friend WithEvents lbltotal_blood As Label
    Friend WithEvents lbltotal_doctor As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents lblregiuser As Label
    Friend WithEvents btncheck2 As Button
    Friend WithEvents LabelOMinus As Label
    Friend WithEvents LabelOPlus As Label
    Friend WithEvents LabelABMinus As Label
    Friend WithEvents LabelABPlus As Label
    Friend WithEvents LabelBMinus As Label
    Friend WithEvents LabelBPlus As Label
    Friend WithEvents LabelAMinus As Label
    Friend WithEvents LabelAPlus As Label
    Friend WithEvents lblApproved As Label
End Class
