<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Add_new_donor
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        lblname = New Label()
        lblmobile = New Label()
        lbldateofbirth = New Label()
        lblgender = New Label()
        lblemail = New Label()
        lblblood_group = New Label()
        lbladdress = New Label()
        txtname = New TextBox()
        txtmobile = New TextBox()
        txtbloodqty = New TextBox()
        txtstatus = New TextBox()
        txtsearch = New TextBox()
        lbldate = New Label()
        DataGridView1 = New DataGridView()
        NewDonorID = New DataGridViewTextBoxColumn()
        Column16 = New DataGridViewTextBoxColumn()
        Column17 = New DataGridViewTextBoxColumn()
        Column18 = New DataGridViewTextBoxColumn()
        Column19 = New DataGridViewTextBoxColumn()
        Column20 = New DataGridViewTextBoxColumn()
        Column21 = New DataGridViewTextBoxColumn()
        Column22 = New DataGridViewTextBoxColumn()
        Column23 = New DataGridViewTextBoxColumn()
        Column24 = New DataGridViewTextBoxColumn()
        Column25 = New DataGridViewTextBoxColumn()
        Column26 = New DataGridViewTextBoxColumn()
        Column27 = New DataGridViewTextBoxColumn()
        Column28 = New DataGridViewTextBoxColumn()
        Column29 = New DataGridViewTextBoxColumn()
        Column30 = New DataGridViewTextBoxColumn()
        Column31 = New DataGridViewTextBoxColumn()
        btnsave = New Button()
        btnclear = New Button()
        DateTimePicker2_date = New DateTimePicker()
        ComboBox1_gender = New ComboBox()
        ComboBox2_bloodgroup = New ComboBox()
        Label12 = New Label()
        lblnic = New Label()
        lblmedical = New Label()
        lblweight = New Label()
        lblage = New Label()
        lbladmin = New Label()
        txtnic = New TextBox()
        txtage = New TextBox()
        txtweight = New TextBox()
        txtadmin = New TextBox()
        btnshowprint = New Button()
        btnedit = New Button()
        txtmedical = New TextBox()
        btnsearch = New Button()
        txtdateofbirth = New TextBox()
        lblcertificate = New Label()
        lbldoctor = New Label()
        txtdoctor = New TextBox()
        txtcertificate = New TextBox()
        btndelete = New Button()
        txtdonorid = New TextBox()
        Label1 = New Label()
        btnbloodstock = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblname
        ' 
        lblname.AutoSize = True
        lblname.Font = New Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        lblname.Location = New Point(49, 201)
        lblname.Name = "lblname"
        lblname.Size = New Size(74, 27)
        lblname.TabIndex = 2
        lblname.Text = "Name"
        ' 
        ' lblmobile
        ' 
        lblmobile.AutoSize = True
        lblmobile.Font = New Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        lblmobile.Location = New Point(49, 242)
        lblmobile.Name = "lblmobile"
        lblmobile.Size = New Size(86, 27)
        lblmobile.TabIndex = 3
        lblmobile.Text = "Mobile"
        ' 
        ' lbldateofbirth
        ' 
        lbldateofbirth.AutoSize = True
        lbldateofbirth.Font = New Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        lbldateofbirth.Location = New Point(48, 285)
        lbldateofbirth.Name = "lbldateofbirth"
        lbldateofbirth.Size = New Size(153, 27)
        lbldateofbirth.TabIndex = 4
        lbldateofbirth.Text = "Date of Birth"
        ' 
        ' lblgender
        ' 
        lblgender.AutoSize = True
        lblgender.Font = New Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        lblgender.Location = New Point(48, 338)
        lblgender.Name = "lblgender"
        lblgender.Size = New Size(94, 27)
        lblgender.TabIndex = 5
        lblgender.Text = "Gender"
        ' 
        ' lblemail
        ' 
        lblemail.AutoSize = True
        lblemail.Font = New Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        lblemail.Location = New Point(50, 437)
        lblemail.Name = "lblemail"
        lblemail.Size = New Size(121, 27)
        lblemail.TabIndex = 6
        lblemail.Text = "Blood Qty"
        ' 
        ' lblblood_group
        ' 
        lblblood_group.AutoSize = True
        lblblood_group.Font = New Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        lblblood_group.Location = New Point(50, 484)
        lblblood_group.Name = "lblblood_group"
        lblblood_group.Size = New Size(154, 27)
        lblblood_group.TabIndex = 7
        lblblood_group.Text = "Blood Group"
        ' 
        ' lbladdress
        ' 
        lbladdress.AutoSize = True
        lbladdress.Font = New Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        lbladdress.Location = New Point(48, 529)
        lbladdress.Name = "lbladdress"
        lbladdress.Size = New Size(193, 27)
        lbladdress.TabIndex = 8
        lbladdress.Text = "Donation Status"
        ' 
        ' txtname
        ' 
        txtname.Font = New Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        txtname.Location = New Point(215, 201)
        txtname.Name = "txtname"
        txtname.Size = New Size(202, 34)
        txtname.TabIndex = 10
        ' 
        ' txtmobile
        ' 
        txtmobile.Font = New Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        txtmobile.Location = New Point(215, 246)
        txtmobile.Name = "txtmobile"
        txtmobile.Size = New Size(202, 34)
        txtmobile.TabIndex = 11
        ' 
        ' txtbloodqty
        ' 
        txtbloodqty.Font = New Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        txtbloodqty.Location = New Point(213, 434)
        txtbloodqty.Name = "txtbloodqty"
        txtbloodqty.Size = New Size(202, 34)
        txtbloodqty.TabIndex = 14
        ' 
        ' txtstatus
        ' 
        txtstatus.Font = New Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        txtstatus.Location = New Point(215, 529)
        txtstatus.Name = "txtstatus"
        txtstatus.Size = New Size(202, 34)
        txtstatus.TabIndex = 16
        txtstatus.Text = "Donated"
        ' 
        ' txtsearch
        ' 
        txtsearch.Font = New Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        txtsearch.Location = New Point(695, 26)
        txtsearch.Multiline = True
        txtsearch.Name = "txtsearch"
        txtsearch.Size = New Size(300, 33)
        txtsearch.TabIndex = 17
        ' 
        ' lbldate
        ' 
        lbldate.AutoSize = True
        lbldate.Font = New Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        lbldate.Location = New Point(50, 386)
        lbldate.Name = "lbldate"
        lbldate.Size = New Size(63, 27)
        lbldate.TabIndex = 19
        lbldate.Text = "Date"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {NewDonorID, Column16, Column17, Column18, Column19, Column20, Column21, Column22, Column23, Column24, Column25, Column26, Column27, Column28, Column29, Column30, Column31})
        DataGridView1.Location = New Point(448, 353)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(564, 278)
        DataGridView1.TabIndex = 21
        ' 
        ' NewDonorID
        ' 
        NewDonorID.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        NewDonorID.DefaultCellStyle = DataGridViewCellStyle1
        NewDonorID.HeaderText = "NewDonorID"
        NewDonorID.MinimumWidth = 6
        NewDonorID.Name = "NewDonorID"
        NewDonorID.Width = 125
        ' 
        ' Column16
        ' 
        Column16.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column16.HeaderText = "Donor ID"
        Column16.MinimumWidth = 6
        Column16.Name = "Column16"
        Column16.Width = 99
        ' 
        ' Column17
        ' 
        Column17.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column17.HeaderText = "NIC"
        Column17.MinimumWidth = 6
        Column17.Name = "Column17"
        Column17.Width = 62
        ' 
        ' Column18
        ' 
        Column18.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column18.HeaderText = "Name"
        Column18.MinimumWidth = 6
        Column18.Name = "Column18"
        Column18.Width = 78
        ' 
        ' Column19
        ' 
        Column19.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column19.HeaderText = "Mobile"
        Column19.MinimumWidth = 6
        Column19.Name = "Column19"
        Column19.Width = 85
        ' 
        ' Column20
        ' 
        Column20.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column20.HeaderText = "DateofBirth"
        Column20.MinimumWidth = 6
        Column20.Name = "Column20"
        Column20.Width = 115
        ' 
        ' Column21
        ' 
        Column21.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column21.HeaderText = "Gender"
        Column21.MinimumWidth = 6
        Column21.Name = "Column21"
        Column21.Width = 86
        ' 
        ' Column22
        ' 
        Column22.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column22.HeaderText = "Date"
        Column22.MinimumWidth = 6
        Column22.Name = "Column22"
        Column22.Width = 70
        ' 
        ' Column23
        ' 
        Column23.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column23.HeaderText = "Blood Qty"
        Column23.MinimumWidth = 6
        Column23.Name = "Column23"
        Column23.Width = 105
        ' 
        ' Column24
        ' 
        Column24.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column24.HeaderText = "BloodGroup"
        Column24.MinimumWidth = 6
        Column24.Name = "Column24"
        Column24.Width = 119
        ' 
        ' Column25
        ' 
        Column25.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column25.HeaderText = "DonationStatus"
        Column25.MinimumWidth = 6
        Column25.Name = "Column25"
        Column25.Width = 140
        ' 
        ' Column26
        ' 
        Column26.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column26.HeaderText = "Age"
        Column26.MinimumWidth = 6
        Column26.Name = "Column26"
        Column26.Width = 65
        ' 
        ' Column27
        ' 
        Column27.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column27.HeaderText = "Weight"
        Column27.MinimumWidth = 6
        Column27.Name = "Column27"
        Column27.Width = 85
        ' 
        ' Column28
        ' 
        Column28.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column28.HeaderText = "HealthCondition"
        Column28.MinimumWidth = 6
        Column28.Name = "Column28"
        Column28.Width = 147
        ' 
        ' Column29
        ' 
        Column29.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column29.HeaderText = "AdminName"
        Column29.MinimumWidth = 6
        Column29.Name = "Column29"
        Column29.Width = 122
        ' 
        ' Column30
        ' 
        Column30.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column30.HeaderText = "DoctorName"
        Column30.MinimumWidth = 6
        Column30.Name = "Column30"
        Column30.Width = 124
        ' 
        ' Column31
        ' 
        Column31.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column31.HeaderText = "CertificateIssue"
        Column31.MinimumWidth = 6
        Column31.Name = "Column31"
        Column31.Width = 138
        ' 
        ' btnsave
        ' 
        btnsave.BackColor = Color.YellowGreen
        btnsave.FlatStyle = FlatStyle.Popup
        btnsave.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnsave.Location = New Point(901, 178)
        btnsave.Name = "btnsave"
        btnsave.Size = New Size(94, 35)
        btnsave.TabIndex = 22
        btnsave.Text = "Add"
        btnsave.UseVisualStyleBackColor = False
        ' 
        ' btnclear
        ' 
        btnclear.BackColor = Color.Gold
        btnclear.FlatStyle = FlatStyle.Popup
        btnclear.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnclear.Location = New Point(901, 260)
        btnclear.Name = "btnclear"
        btnclear.Size = New Size(94, 35)
        btnclear.TabIndex = 24
        btnclear.Text = "Clear"
        btnclear.UseVisualStyleBackColor = False
        ' 
        ' DateTimePicker2_date
        ' 
        DateTimePicker2_date.Font = New Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        DateTimePicker2_date.Format = DateTimePickerFormat.Short
        DateTimePicker2_date.Location = New Point(215, 387)
        DateTimePicker2_date.Name = "DateTimePicker2_date"
        DateTimePicker2_date.Size = New Size(202, 34)
        DateTimePicker2_date.TabIndex = 29
        ' 
        ' ComboBox1_gender
        ' 
        ComboBox1_gender.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox1_gender.Font = New Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        ComboBox1_gender.FormattingEnabled = True
        ComboBox1_gender.Items.AddRange(New Object() {"Male", "Female"})
        ComboBox1_gender.Location = New Point(213, 342)
        ComboBox1_gender.Name = "ComboBox1_gender"
        ComboBox1_gender.Size = New Size(202, 35)
        ComboBox1_gender.TabIndex = 30
        ' 
        ' ComboBox2_bloodgroup
        ' 
        ComboBox2_bloodgroup.DisplayMember = "A-"
        ComboBox2_bloodgroup.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox2_bloodgroup.Font = New Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        ComboBox2_bloodgroup.FormattingEnabled = True
        ComboBox2_bloodgroup.Items.AddRange(New Object() {"A-", "A+", "B-", "B+", "O-", "O+", "AB-", "AB+"})
        ComboBox2_bloodgroup.Location = New Point(213, 484)
        ComboBox2_bloodgroup.Name = "ComboBox2_bloodgroup"
        ComboBox2_bloodgroup.Size = New Size(202, 35)
        ComboBox2_bloodgroup.TabIndex = 31
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        Label12.Font = New Font("Arial", 22.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label12.ForeColor = Color.FromArgb(CByte(179), CByte(14), CByte(8))
        Label12.Location = New Point(12, 26)
        Label12.Name = "Label12"
        Label12.Size = New Size(565, 44)
        Label12.TabIndex = 41
        Label12.Text = " Donor Registration(Approved)"
        ' 
        ' lblnic
        ' 
        lblnic.AutoSize = True
        lblnic.Font = New Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        lblnic.Location = New Point(50, 151)
        lblnic.Name = "lblnic"
        lblnic.Size = New Size(51, 27)
        lblnic.TabIndex = 42
        lblnic.Text = "NIC"
        ' 
        ' lblmedical
        ' 
        lblmedical.AutoSize = True
        lblmedical.Font = New Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        lblmedical.Location = New Point(462, 147)
        lblmedical.Name = "lblmedical"
        lblmedical.Size = New Size(198, 27)
        lblmedical.TabIndex = 43
        lblmedical.Text = "Health condition"
        ' 
        ' lblweight
        ' 
        lblweight.AutoSize = True
        lblweight.Font = New Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        lblweight.Location = New Point(462, 94)
        lblweight.Name = "lblweight"
        lblweight.Size = New Size(90, 27)
        lblweight.TabIndex = 44
        lblweight.Text = "Weight"
        ' 
        ' lblage
        ' 
        lblage.AutoSize = True
        lblage.Font = New Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        lblage.Location = New Point(48, 579)
        lblage.Name = "lblage"
        lblage.Size = New Size(56, 27)
        lblage.TabIndex = 45
        lblage.Text = "Age"
        ' 
        ' lbladmin
        ' 
        lbladmin.AutoSize = True
        lbladmin.Font = New Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        lbladmin.Location = New Point(462, 203)
        lbladmin.Name = "lbladmin"
        lbladmin.Size = New Size(152, 27)
        lbladmin.TabIndex = 47
        lbladmin.Text = "Admin Name"
        ' 
        ' txtnic
        ' 
        txtnic.Font = New Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        txtnic.Location = New Point(217, 151)
        txtnic.Name = "txtnic"
        txtnic.Size = New Size(200, 34)
        txtnic.TabIndex = 48
        ' 
        ' txtage
        ' 
        txtage.Font = New Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        txtage.Location = New Point(215, 579)
        txtage.Name = "txtage"
        txtage.Size = New Size(202, 34)
        txtage.TabIndex = 49
        ' 
        ' txtweight
        ' 
        txtweight.Font = New Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        txtweight.Location = New Point(668, 89)
        txtweight.Name = "txtweight"
        txtweight.Size = New Size(194, 34)
        txtweight.TabIndex = 50
        ' 
        ' txtadmin
        ' 
        txtadmin.Font = New Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        txtadmin.Location = New Point(669, 201)
        txtadmin.Name = "txtadmin"
        txtadmin.Size = New Size(194, 34)
        txtadmin.TabIndex = 55
        txtadmin.Text = "Tharushi"
        ' 
        ' btnshowprint
        ' 
        btnshowprint.BackColor = Color.Goldenrod
        btnshowprint.FlatStyle = FlatStyle.Popup
        btnshowprint.Font = New Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        btnshowprint.Location = New Point(874, 79)
        btnshowprint.Name = "btnshowprint"
        btnshowprint.Size = New Size(162, 52)
        btnshowprint.TabIndex = 56
        btnshowprint.Text = "Print Certificate"
        btnshowprint.UseVisualStyleBackColor = False
        ' 
        ' btnedit
        ' 
        btnedit.BackColor = Color.CornflowerBlue
        btnedit.FlatStyle = FlatStyle.Popup
        btnedit.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnedit.Location = New Point(901, 219)
        btnedit.Name = "btnedit"
        btnedit.Size = New Size(94, 35)
        btnedit.TabIndex = 57
        btnedit.Text = "Edit"
        btnedit.UseVisualStyleBackColor = False
        ' 
        ' txtmedical
        ' 
        txtmedical.Font = New Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        txtmedical.Location = New Point(668, 147)
        txtmedical.Name = "txtmedical"
        txtmedical.Size = New Size(194, 34)
        txtmedical.TabIndex = 58
        ' 
        ' btnsearch
        ' 
        btnsearch.BackColor = Color.FromArgb(CByte(128), CByte(64), CByte(64))
        btnsearch.FlatStyle = FlatStyle.Popup
        btnsearch.Font = New Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        btnsearch.ForeColor = SystemColors.ButtonHighlight
        btnsearch.Location = New Point(595, 25)
        btnsearch.Name = "btnsearch"
        btnsearch.Size = New Size(94, 34)
        btnsearch.TabIndex = 60
        btnsearch.Text = "Search"
        btnsearch.UseVisualStyleBackColor = False
        ' 
        ' txtdateofbirth
        ' 
        txtdateofbirth.Font = New Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        txtdateofbirth.Location = New Point(215, 288)
        txtdateofbirth.Name = "txtdateofbirth"
        txtdateofbirth.Size = New Size(202, 34)
        txtdateofbirth.TabIndex = 61
        ' 
        ' lblcertificate
        ' 
        lblcertificate.AutoSize = True
        lblcertificate.Font = New Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        lblcertificate.Location = New Point(462, 310)
        lblcertificate.Name = "lblcertificate"
        lblcertificate.Size = New Size(193, 27)
        lblcertificate.TabIndex = 62
        lblcertificate.Text = "Certificate Issue"
        ' 
        ' lbldoctor
        ' 
        lbldoctor.AutoSize = True
        lbldoctor.Font = New Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        lbldoctor.Location = New Point(462, 254)
        lbldoctor.Name = "lbldoctor"
        lbldoctor.Size = New Size(173, 27)
        lbldoctor.TabIndex = 63
        lbldoctor.Text = "Doctor's Name"
        ' 
        ' txtdoctor
        ' 
        txtdoctor.Font = New Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        txtdoctor.Location = New Point(668, 257)
        txtdoctor.Name = "txtdoctor"
        txtdoctor.Size = New Size(194, 34)
        txtdoctor.TabIndex = 64
        ' 
        ' txtcertificate
        ' 
        txtcertificate.Font = New Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        txtcertificate.Location = New Point(670, 310)
        txtcertificate.Name = "txtcertificate"
        txtcertificate.Size = New Size(193, 34)
        txtcertificate.TabIndex = 65
        ' 
        ' btndelete
        ' 
        btndelete.BackColor = Color.IndianRed
        btndelete.FlatStyle = FlatStyle.Popup
        btndelete.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btndelete.Location = New Point(901, 302)
        btndelete.Name = "btndelete"
        btndelete.Size = New Size(94, 35)
        btndelete.TabIndex = 84
        btndelete.Text = "Delete"
        btndelete.UseVisualStyleBackColor = False
        ' 
        ' txtdonorid
        ' 
        txtdonorid.Font = New Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        txtdonorid.Location = New Point(217, 104)
        txtdonorid.Name = "txtdonorid"
        txtdonorid.Size = New Size(200, 34)
        txtdonorid.TabIndex = 128
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(50, 104)
        Label1.Name = "Label1"
        Label1.Size = New Size(109, 27)
        Label1.TabIndex = 127
        Label1.Text = "Donor ID"
        ' 
        ' btnbloodstock
        ' 
        btnbloodstock.BackColor = SystemColors.AppWorkspace
        btnbloodstock.FlatStyle = FlatStyle.Popup
        btnbloodstock.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnbloodstock.Location = New Point(874, 137)
        btnbloodstock.Name = "btnbloodstock"
        btnbloodstock.Size = New Size(162, 35)
        btnbloodstock.TabIndex = 129
        btnbloodstock.Text = "Blood Stock"
        btnbloodstock.UseVisualStyleBackColor = False
        ' 
        ' Add_new_donor
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.OldLace
        ClientSize = New Size(1048, 643)
        Controls.Add(btnbloodstock)
        Controls.Add(txtdonorid)
        Controls.Add(Label1)
        Controls.Add(btndelete)
        Controls.Add(txtcertificate)
        Controls.Add(txtdoctor)
        Controls.Add(lbldoctor)
        Controls.Add(lblcertificate)
        Controls.Add(txtdateofbirth)
        Controls.Add(btnsearch)
        Controls.Add(txtmedical)
        Controls.Add(btnedit)
        Controls.Add(btnshowprint)
        Controls.Add(txtadmin)
        Controls.Add(txtweight)
        Controls.Add(txtage)
        Controls.Add(txtnic)
        Controls.Add(lbladmin)
        Controls.Add(lblage)
        Controls.Add(lblweight)
        Controls.Add(lblmedical)
        Controls.Add(lblnic)
        Controls.Add(Label12)
        Controls.Add(ComboBox2_bloodgroup)
        Controls.Add(ComboBox1_gender)
        Controls.Add(DateTimePicker2_date)
        Controls.Add(btnclear)
        Controls.Add(btnsave)
        Controls.Add(DataGridView1)
        Controls.Add(lbldate)
        Controls.Add(txtsearch)
        Controls.Add(txtstatus)
        Controls.Add(txtbloodqty)
        Controls.Add(txtmobile)
        Controls.Add(txtname)
        Controls.Add(lbladdress)
        Controls.Add(lblblood_group)
        Controls.Add(lblemail)
        Controls.Add(lblgender)
        Controls.Add(lbldateofbirth)
        Controls.Add(lblmobile)
        Controls.Add(lblname)
        FormBorderStyle = FormBorderStyle.None
        Name = "Add_new_donor"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Add_new_donor"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents lblname As Label
    Friend WithEvents lblmobile As Label
    Friend WithEvents lbldateofbirth As Label
    Friend WithEvents lblgender As Label
    Friend WithEvents lblemail As Label
    Friend WithEvents lblblood_group As Label
    Friend WithEvents lbladdress As Label
    Friend WithEvents txtname As TextBox
    Friend WithEvents txtmobile As TextBox
    Friend WithEvents txtbloodqty As TextBox
    Friend WithEvents txtstatus As TextBox
    Friend WithEvents txtsearch As TextBox
    Friend WithEvents lbldate As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnsave As Button
    Friend WithEvents btnclear As Button
    Friend WithEvents DateTimePicker2_date As DateTimePicker
    Friend WithEvents ComboBox1_gender As ComboBox
    Friend WithEvents ComboBox2_bloodgroup As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents lblnic As Label
    Friend WithEvents lblmedical As Label
    Friend WithEvents lblweight As Label
    Friend WithEvents lblage As Label
    Friend WithEvents lbladmin As Label
    Friend WithEvents txtnic As TextBox
    Friend WithEvents txtage As TextBox
    Friend WithEvents txtweight As TextBox
    Friend WithEvents txtadmin As TextBox
    Friend WithEvents btnshowprint As Button
    Friend WithEvents btnedit As Button
    Friend WithEvents txtmedical As TextBox
    Friend WithEvents btnsearch As Button
    Friend WithEvents txtdateofbirth As TextBox
    Friend WithEvents lblcertificate As Label
    Friend WithEvents lbldoctor As Label
    Friend WithEvents txtdoctor As TextBox
    Friend WithEvents txtcertificate As TextBox
    Friend WithEvents btndelete As Button
    Friend WithEvents NewDonorID As DataGridViewTextBoxColumn
    Friend WithEvents Column16 As DataGridViewTextBoxColumn
    Friend WithEvents Column17 As DataGridViewTextBoxColumn
    Friend WithEvents Column18 As DataGridViewTextBoxColumn
    Friend WithEvents Column19 As DataGridViewTextBoxColumn
    Friend WithEvents Column20 As DataGridViewTextBoxColumn
    Friend WithEvents Column21 As DataGridViewTextBoxColumn
    Friend WithEvents Column22 As DataGridViewTextBoxColumn
    Friend WithEvents Column23 As DataGridViewTextBoxColumn
    Friend WithEvents Column24 As DataGridViewTextBoxColumn
    Friend WithEvents Column25 As DataGridViewTextBoxColumn
    Friend WithEvents Column26 As DataGridViewTextBoxColumn
    Friend WithEvents Column27 As DataGridViewTextBoxColumn
    Friend WithEvents Column28 As DataGridViewTextBoxColumn
    Friend WithEvents Column29 As DataGridViewTextBoxColumn
    Friend WithEvents Column30 As DataGridViewTextBoxColumn
    Friend WithEvents Column31 As DataGridViewTextBoxColumn
    Friend WithEvents txtdonorid As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnbloodstock As Button
End Class
