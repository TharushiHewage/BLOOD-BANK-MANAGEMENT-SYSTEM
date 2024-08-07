<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Blood_stock
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
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Button1 = New Button()
        Label12 = New Label()
        Label27 = New Label()
        Panel2 = New Panel()
        lblcompany_name = New Label()
        Label6 = New Label()
        btnsave = New Button()
        btnprint = New Button()
        btnGenerateBarcode = New Button()
        lblnic = New Label()
        lblbloodbagid = New Label()
        lblname = New Label()
        lblbloodtype = New Label()
        lblcomponent = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Label1 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label7 = New Label()
        Label10 = New Label()
        btndelete = New Button()
        btnedit = New Button()
        btnclear = New Button()
        btnadd = New Button()
        ComboBox1_bloodtype = New ComboBox()
        DateTimePicker1 = New DateTimePicker()
        DateTimePicker2 = New DateTimePicker()
        DataGridView1 = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewTextBoxColumn()
        Column7 = New DataGridViewTextBoxColumn()
        Column8 = New DataGridViewTextBoxColumn()
        Column9 = New DataGridViewTextBoxColumn()
        Column10 = New DataGridViewTextBoxColumn()
        Column11 = New DataGridViewTextBoxColumn()
        Column12 = New DataGridViewTextBoxColumn()
        Column13 = New DataGridViewTextBoxColumn()
        Column14 = New DataGridViewTextBoxColumn()
        Column15 = New DataGridViewTextBoxColumn()
        btnsearch = New Button()
        Label11 = New Label()
        txtsearch = New TextBox()
        ComboBox2_gender = New ComboBox()
        txtnic = New TextBox()
        txtname = New TextBox()
        txtbloodbagid = New TextBox()
        txtvolume = New TextBox()
        txtdonorage = New TextBox()
        txttested = New TextBox()
        txtstorage = New TextBox()
        txtcollectionsite = New TextBox()
        txtdonorregistration_id = New TextBox()
        Label2 = New Label()
        ComboBox1_component = New ComboBox()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Peru
        Button1.FlatStyle = FlatStyle.Popup
        Button1.Font = New Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.Location = New Point(1215, 106)
        Button1.Name = "Button1"
        Button1.Size = New Size(106, 40)
        Button1.TabIndex = 39
        Button1.Text = "Print"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label12.ForeColor = Color.FromArgb(CByte(179), CByte(14), CByte(8))
        Label12.Location = New Point(772, 140)
        Label12.Name = "Label12"
        Label12.Size = New Size(0, 19)
        Label12.TabIndex = 41
        ' 
        ' Label27
        ' 
        Label27.AutoSize = True
        Label27.Font = New Font("Arial Rounded MT Bold", 22.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label27.ForeColor = Color.FromArgb(CByte(179), CByte(14), CByte(8))
        Label27.Location = New Point(389, -44)
        Label27.Name = "Label27"
        Label27.Size = New Size(235, 43)
        Label27.TabIndex = 44
        Label27.Text = "Blood Stock"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(179), CByte(14), CByte(8))
        Panel2.Location = New Point(-80, -97)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1209, 66)
        Panel2.TabIndex = 67
        ' 
        ' lblcompany_name
        ' 
        lblcompany_name.AutoSize = True
        lblcompany_name.Font = New Font("Arial Black", 16.2F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        lblcompany_name.ForeColor = Color.FromArgb(CByte(179), CByte(14), CByte(8))
        lblcompany_name.Location = New Point(307, -54)
        lblcompany_name.Name = "lblcompany_name"
        lblcompany_name.Size = New Size(367, 40)
        lblcompany_name.TabIndex = 70
        lblcompany_name.Text = "LIFELINE BLOODBANK"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(579, 393)
        Label6.Name = "Label6"
        Label6.Size = New Size(0, 27)
        Label6.TabIndex = 75
        ' 
        ' btnsave
        ' 
        btnsave.Location = New Point(406, 751)
        btnsave.Name = "btnsave"
        btnsave.Size = New Size(94, 29)
        btnsave.TabIndex = 79
        btnsave.Text = "Save"
        btnsave.UseVisualStyleBackColor = True
        ' 
        ' btnprint
        ' 
        btnprint.Location = New Point(765, 751)
        btnprint.Name = "btnprint"
        btnprint.Size = New Size(94, 29)
        btnprint.TabIndex = 78
        btnprint.Text = "Print"
        btnprint.UseVisualStyleBackColor = True
        ' 
        ' btnGenerateBarcode
        ' 
        btnGenerateBarcode.Location = New Point(246, 751)
        btnGenerateBarcode.Name = "btnGenerateBarcode"
        btnGenerateBarcode.Size = New Size(94, 29)
        btnGenerateBarcode.TabIndex = 77
        btnGenerateBarcode.Text = "Generate"
        btnGenerateBarcode.UseVisualStyleBackColor = True
        ' 
        ' lblnic
        ' 
        lblnic.AutoSize = True
        lblnic.Font = New Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        lblnic.Location = New Point(48, 98)
        lblnic.Name = "lblnic"
        lblnic.Size = New Size(51, 27)
        lblnic.TabIndex = 81
        lblnic.Text = "NIC"
        ' 
        ' lblbloodbagid
        ' 
        lblbloodbagid.AutoSize = True
        lblbloodbagid.Font = New Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        lblbloodbagid.Location = New Point(48, 225)
        lblbloodbagid.Name = "lblbloodbagid"
        lblbloodbagid.Size = New Size(156, 27)
        lblbloodbagid.TabIndex = 82
        lblbloodbagid.Text = "Blood Bag ID"
        ' 
        ' lblname
        ' 
        lblname.AutoSize = True
        lblname.Font = New Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        lblname.Location = New Point(48, 160)
        lblname.Name = "lblname"
        lblname.Size = New Size(74, 27)
        lblname.TabIndex = 83
        lblname.Text = "Name"
        ' 
        ' lblbloodtype
        ' 
        lblbloodtype.AutoSize = True
        lblbloodtype.Font = New Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        lblbloodtype.Location = New Point(48, 287)
        lblbloodtype.Name = "lblbloodtype"
        lblbloodtype.Size = New Size(135, 27)
        lblbloodtype.TabIndex = 84
        lblbloodtype.Text = "Blood Type"
        ' 
        ' lblcomponent
        ' 
        lblcomponent.AutoSize = True
        lblcomponent.Font = New Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        lblcomponent.Location = New Point(45, 393)
        lblcomponent.Name = "lblcomponent"
        lblcomponent.Size = New Size(141, 27)
        lblcomponent.TabIndex = 85
        lblcomponent.Text = "Component"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.Location = New Point(48, 450)
        Label8.Name = "Label8"
        Label8.Size = New Size(93, 27)
        Label8.TabIndex = 86
        Label8.Text = "Volume"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label9.Location = New Point(48, 510)
        Label9.Name = "Label9"
        Label9.Size = New Size(184, 27)
        Label9.TabIndex = 87
        Label9.Text = "Collection Date"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(560, 98)
        Label1.Name = "Label1"
        Label1.Size = New Size(137, 27)
        Label1.TabIndex = 88
        Label1.Text = "Expiry Date"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(563, 165)
        Label3.Name = "Label3"
        Label3.Size = New Size(130, 27)
        Label3.TabIndex = 89
        Label3.Text = "Donor Age"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(563, 225)
        Label4.Name = "Label4"
        Label4.Size = New Size(94, 27)
        Label4.TabIndex = 90
        Label4.Text = "Gender"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(563, 285)
        Label5.Name = "Label5"
        Label5.Size = New Size(86, 27)
        Label5.TabIndex = 91
        Label5.Text = "Tested"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.Location = New Point(563, 343)
        Label7.Name = "Label7"
        Label7.Size = New Size(98, 27)
        Label7.TabIndex = 92
        Label7.Text = "Storage"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label10.Location = New Point(563, 393)
        Label10.Name = "Label10"
        Label10.Size = New Size(176, 27)
        Label10.TabIndex = 93
        Label10.Text = "Collection Site"
        ' 
        ' btndelete
        ' 
        btndelete.BackColor = Color.IndianRed
        btndelete.FlatStyle = FlatStyle.Popup
        btndelete.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btndelete.Location = New Point(387, 573)
        btndelete.Name = "btndelete"
        btndelete.Size = New Size(94, 35)
        btndelete.TabIndex = 97
        btndelete.Text = "Delete"
        btndelete.UseVisualStyleBackColor = False
        ' 
        ' btnedit
        ' 
        btnedit.BackColor = Color.CornflowerBlue
        btnedit.FlatStyle = FlatStyle.Popup
        btnedit.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnedit.Location = New Point(162, 573)
        btnedit.Name = "btnedit"
        btnedit.Size = New Size(94, 35)
        btnedit.TabIndex = 96
        btnedit.Text = "Edit"
        btnedit.UseVisualStyleBackColor = False
        ' 
        ' btnclear
        ' 
        btnclear.BackColor = Color.Gold
        btnclear.FlatStyle = FlatStyle.Popup
        btnclear.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnclear.Location = New Point(274, 573)
        btnclear.Name = "btnclear"
        btnclear.Size = New Size(94, 35)
        btnclear.TabIndex = 95
        btnclear.Text = "Clear"
        btnclear.UseVisualStyleBackColor = False
        ' 
        ' btnadd
        ' 
        btnadd.BackColor = Color.YellowGreen
        btnadd.FlatStyle = FlatStyle.Popup
        btnadd.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnadd.Location = New Point(48, 573)
        btnadd.Name = "btnadd"
        btnadd.Size = New Size(94, 35)
        btnadd.TabIndex = 94
        btnadd.Text = "Add"
        btnadd.UseVisualStyleBackColor = False
        ' 
        ' ComboBox1_bloodtype
        ' 
        ComboBox1_bloodtype.Font = New Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        ComboBox1_bloodtype.FormattingEnabled = True
        ComboBox1_bloodtype.Location = New Point(298, 285)
        ComboBox1_bloodtype.Name = "ComboBox1_bloodtype"
        ComboBox1_bloodtype.Size = New Size(194, 27)
        ComboBox1_bloodtype.TabIndex = 98
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Font = New Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        DateTimePicker1.Format = DateTimePickerFormat.Short
        DateTimePicker1.Location = New Point(298, 510)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(194, 27)
        DateTimePicker1.TabIndex = 99
        ' 
        ' DateTimePicker2
        ' 
        DateTimePicker2.Font = New Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        DateTimePicker2.Format = DateTimePickerFormat.Short
        DateTimePicker2.Location = New Point(745, 99)
        DateTimePicker2.Name = "DateTimePicker2"
        DateTimePicker2.Size = New Size(186, 27)
        DateTimePicker2.TabIndex = 100
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8, Column9, Column10, Column11, Column12, Column13, Column14, Column15})
        DataGridView1.Location = New Point(528, 450)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(497, 188)
        DataGridView1.TabIndex = 101
        ' 
        ' Column1
        ' 
        Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Column1.DefaultCellStyle = DataGridViewCellStyle1
        Column1.HeaderText = "ID"
        Column1.MinimumWidth = 6
        Column1.Name = "Column1"
        Column1.Width = 53
        ' 
        ' Column2
        ' 
        Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column2.HeaderText = "NIC"
        Column2.MinimumWidth = 6
        Column2.Name = "Column2"
        Column2.Width = 62
        ' 
        ' Column3
        ' 
        Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column3.HeaderText = "Name"
        Column3.MinimumWidth = 6
        Column3.Name = "Column3"
        Column3.Width = 78
        ' 
        ' Column4
        ' 
        Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle2.BackColor = Color.White
        Column4.DefaultCellStyle = DataGridViewCellStyle2
        Column4.HeaderText = "Blood Bag ID"
        Column4.MinimumWidth = 6
        Column4.Name = "Column4"
        Column4.Width = 103
        ' 
        ' Column5
        ' 
        Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column5.HeaderText = "Blood Type"
        Column5.MinimumWidth = 6
        Column5.Name = "Column5"
        Column5.Width = 104
        ' 
        ' Column6
        ' 
        Column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle3.BackColor = Color.White
        Column6.DefaultCellStyle = DataGridViewCellStyle3
        Column6.HeaderText = "Donor Registration ID"
        Column6.MinimumWidth = 6
        Column6.Name = "Column6"
        Column6.Width = 150
        ' 
        ' Column7
        ' 
        Column7.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column7.HeaderText = "Component"
        Column7.MinimumWidth = 6
        Column7.Name = "Column7"
        Column7.Width = 116
        ' 
        ' Column8
        ' 
        Column8.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column8.HeaderText = "Volume"
        Column8.MinimumWidth = 6
        Column8.Name = "Column8"
        Column8.Width = 88
        ' 
        ' Column9
        ' 
        Column9.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column9.HeaderText = "Collection Date"
        Column9.MinimumWidth = 6
        Column9.Name = "Column9"
        Column9.Width = 129
        ' 
        ' Column10
        ' 
        Column10.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column10.HeaderText = "Expiry Date"
        Column10.MinimumWidth = 6
        Column10.Name = "Column10"
        Column10.Width = 105
        ' 
        ' Column11
        ' 
        Column11.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column11.HeaderText = "Donor Age"
        Column11.MinimumWidth = 6
        Column11.Name = "Column11"
        Column11.Width = 102
        ' 
        ' Column12
        ' 
        Column12.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column12.HeaderText = "Gender"
        Column12.MinimumWidth = 6
        Column12.Name = "Column12"
        Column12.Width = 86
        ' 
        ' Column13
        ' 
        Column13.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column13.HeaderText = "Tested"
        Column13.MinimumWidth = 6
        Column13.Name = "Column13"
        Column13.Width = 81
        ' 
        ' Column14
        ' 
        Column14.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column14.HeaderText = "Storage"
        Column14.MinimumWidth = 6
        Column14.Name = "Column14"
        Column14.Width = 90
        ' 
        ' Column15
        ' 
        Column15.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column15.HeaderText = "Collection Site"
        Column15.MinimumWidth = 6
        Column15.Name = "Column15"
        Column15.Width = 123
        ' 
        ' btnsearch
        ' 
        btnsearch.BackColor = Color.FromArgb(CByte(128), CByte(64), CByte(64))
        btnsearch.FlatStyle = FlatStyle.Popup
        btnsearch.Font = New Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        btnsearch.ForeColor = SystemColors.ButtonHighlight
        btnsearch.Location = New Point(408, 27)
        btnsearch.Name = "btnsearch"
        btnsearch.Size = New Size(114, 34)
        btnsearch.TabIndex = 104
        btnsearch.Text = "Search"
        btnsearch.UseVisualStyleBackColor = False
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        Label11.Font = New Font("Arial", 22.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label11.ForeColor = Color.FromArgb(CByte(179), CByte(14), CByte(8))
        Label11.Location = New Point(31, 27)
        Label11.Name = "Label11"
        Label11.Size = New Size(237, 44)
        Label11.TabIndex = 103
        Label11.Text = "Blood Stock"
        ' 
        ' txtsearch
        ' 
        txtsearch.Location = New Point(528, 28)
        txtsearch.Multiline = True
        txtsearch.Name = "txtsearch"
        txtsearch.Size = New Size(341, 33)
        txtsearch.TabIndex = 102
        ' 
        ' ComboBox2_gender
        ' 
        ComboBox2_gender.Font = New Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        ComboBox2_gender.FormattingEnabled = True
        ComboBox2_gender.Location = New Point(745, 225)
        ComboBox2_gender.Name = "ComboBox2_gender"
        ComboBox2_gender.Size = New Size(186, 27)
        ComboBox2_gender.TabIndex = 105
        ' 
        ' txtnic
        ' 
        txtnic.Font = New Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        txtnic.Location = New Point(298, 98)
        txtnic.Name = "txtnic"
        txtnic.Size = New Size(194, 27)
        txtnic.TabIndex = 106
        ' 
        ' txtname
        ' 
        txtname.Font = New Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        txtname.Location = New Point(298, 160)
        txtname.Name = "txtname"
        txtname.Size = New Size(194, 27)
        txtname.TabIndex = 107
        ' 
        ' txtbloodbagid
        ' 
        txtbloodbagid.Font = New Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        txtbloodbagid.Location = New Point(298, 225)
        txtbloodbagid.Name = "txtbloodbagid"
        txtbloodbagid.Size = New Size(194, 27)
        txtbloodbagid.TabIndex = 108
        ' 
        ' txtvolume
        ' 
        txtvolume.Font = New Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        txtvolume.Location = New Point(298, 454)
        txtvolume.Name = "txtvolume"
        txtvolume.Size = New Size(194, 27)
        txtvolume.TabIndex = 110
        ' 
        ' txtdonorage
        ' 
        txtdonorage.Font = New Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        txtdonorage.Location = New Point(745, 165)
        txtdonorage.Name = "txtdonorage"
        txtdonorage.Size = New Size(186, 27)
        txtdonorage.TabIndex = 111
        ' 
        ' txttested
        ' 
        txttested.Font = New Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        txttested.Location = New Point(745, 284)
        txttested.Name = "txttested"
        txttested.Size = New Size(186, 27)
        txttested.TabIndex = 112
        ' 
        ' txtstorage
        ' 
        txtstorage.Font = New Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        txtstorage.Location = New Point(745, 343)
        txtstorage.Name = "txtstorage"
        txtstorage.Size = New Size(186, 27)
        txtstorage.TabIndex = 113
        ' 
        ' txtcollectionsite
        ' 
        txtcollectionsite.Font = New Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        txtcollectionsite.Location = New Point(745, 393)
        txtcollectionsite.Name = "txtcollectionsite"
        txtcollectionsite.Size = New Size(186, 27)
        txtcollectionsite.TabIndex = 114
        ' 
        ' txtdonorregistration_id
        ' 
        txtdonorregistration_id.Font = New Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        txtdonorregistration_id.Location = New Point(298, 347)
        txtdonorregistration_id.Name = "txtdonorregistration_id"
        txtdonorregistration_id.Size = New Size(194, 27)
        txtdonorregistration_id.TabIndex = 116
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(48, 343)
        Label2.Name = "Label2"
        Label2.Size = New Size(253, 27)
        Label2.TabIndex = 115
        Label2.Text = "Donor Registration ID"
        ' 
        ' ComboBox1_component
        ' 
        ComboBox1_component.Font = New Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        ComboBox1_component.FormattingEnabled = True
        ComboBox1_component.Location = New Point(298, 397)
        ComboBox1_component.Name = "ComboBox1_component"
        ComboBox1_component.Size = New Size(194, 27)
        ComboBox1_component.TabIndex = 117
        ' 
        ' Blood_stock
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.OldLace
        ClientSize = New Size(1092, 692)
        Controls.Add(ComboBox1_component)
        Controls.Add(txtdonorregistration_id)
        Controls.Add(Label2)
        Controls.Add(txtcollectionsite)
        Controls.Add(txtstorage)
        Controls.Add(txttested)
        Controls.Add(txtdonorage)
        Controls.Add(txtvolume)
        Controls.Add(txtbloodbagid)
        Controls.Add(txtname)
        Controls.Add(txtnic)
        Controls.Add(ComboBox2_gender)
        Controls.Add(btnsearch)
        Controls.Add(Label11)
        Controls.Add(txtsearch)
        Controls.Add(DataGridView1)
        Controls.Add(DateTimePicker2)
        Controls.Add(DateTimePicker1)
        Controls.Add(ComboBox1_bloodtype)
        Controls.Add(btndelete)
        Controls.Add(btnedit)
        Controls.Add(btnclear)
        Controls.Add(btnadd)
        Controls.Add(Label10)
        Controls.Add(Label7)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label1)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(lblcomponent)
        Controls.Add(lblbloodtype)
        Controls.Add(lblname)
        Controls.Add(lblbloodbagid)
        Controls.Add(lblnic)
        Controls.Add(btnsave)
        Controls.Add(btnprint)
        Controls.Add(btnGenerateBarcode)
        Controls.Add(Panel2)
        Controls.Add(lblcompany_name)
        Controls.Add(Label6)
        Controls.Add(Label27)
        Controls.Add(Label12)
        Controls.Add(Button1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Blood_stock"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Blood_stock"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblcompany_name As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnsave As Button
    Friend WithEvents btnprint As Button
    Friend WithEvents btnGenerateBarcode As Button
    Friend WithEvents lblnic As Label
    Friend WithEvents lblbloodbagid As Label
    Friend WithEvents lblname As Label
    Friend WithEvents lblbloodtype As Label
    Friend WithEvents lblcomponent As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents btndelete As Button
    Friend WithEvents btnedit As Button
    Friend WithEvents btnclear As Button
    Friend WithEvents btnadd As Button
    Friend WithEvents ComboBox1_bloodtype As ComboBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnsearch As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents txtsearch As TextBox
    Friend WithEvents ComboBox2_gender As ComboBox
    Friend WithEvents txtnic As TextBox
    Friend WithEvents txtname As TextBox
    Friend WithEvents txtbloodbagid As TextBox
    Friend WithEvents txtvolume As TextBox
    Friend WithEvents txtdonorage As TextBox
    Friend WithEvents txttested As TextBox
    Friend WithEvents txtstorage As TextBox
    Friend WithEvents txtcollectionsite As TextBox
    Friend WithEvents txtdonorregistration_id As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBox1_component As ComboBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents Column12 As DataGridViewTextBoxColumn
    Friend WithEvents Column13 As DataGridViewTextBoxColumn
    Friend WithEvents Column14 As DataGridViewTextBoxColumn
    Friend WithEvents Column15 As DataGridViewTextBoxColumn
End Class
