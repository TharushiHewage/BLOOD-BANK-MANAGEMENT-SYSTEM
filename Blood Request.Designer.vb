<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Blood_Request
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
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As DataGridViewCellStyle = New DataGridViewCellStyle()
        lblhospital_name = New Label()
        lbl_contact_number = New Label()
        lbl_quantity = New Label()
        lbl_email = New Label()
        lbl_blood = New Label()
        lbl_date = New Label()
        txt_centername = New TextBox()
        txt_contactnumber = New TextBox()
        txt_email = New TextBox()
        txt_quantity = New TextBox()
        DataGridView1 = New DataGridView()
        ComboBox1_selectblood = New ComboBox()
        DateTimePicker1_requestdate = New DateTimePicker()
        Label1 = New Label()
        Label2 = New Label()
        txtstatus = New TextBox()
        txtsearch = New TextBox()
        btnsearch = New Button()
        Panel1 = New Panel()
        lblOMinus = New Label()
        lblOPlus = New Label()
        lblABMinus = New Label()
        lblABPlus = New Label()
        lblBMinus = New Label()
        lblBPlus = New Label()
        lblAMinus = New Label()
        lblAPlus = New Label()
        btndelete = New Button()
        btnedit = New Button()
        btnclear = New Button()
        btnsave = New Button()
        Label3 = New Label()
        ComboBox1_component = New ComboBox()
        txtid = New TextBox()
        Label12 = New Label()
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
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblhospital_name
        ' 
        lblhospital_name.AutoSize = True
        lblhospital_name.Font = New Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        lblhospital_name.Location = New Point(52, 149)
        lblhospital_name.Name = "lblhospital_name"
        lblhospital_name.Size = New Size(338, 27)
        lblhospital_name.TabIndex = 34
        lblhospital_name.Text = "Blood Request center's name"
        ' 
        ' lbl_contact_number
        ' 
        lbl_contact_number.AutoSize = True
        lbl_contact_number.Font = New Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        lbl_contact_number.Location = New Point(54, 187)
        lbl_contact_number.Name = "lbl_contact_number"
        lbl_contact_number.Size = New Size(193, 27)
        lbl_contact_number.TabIndex = 35
        lbl_contact_number.Text = "Contact Number"
        ' 
        ' lbl_quantity
        ' 
        lbl_quantity.AutoSize = True
        lbl_quantity.Font = New Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        lbl_quantity.Location = New Point(54, 331)
        lbl_quantity.Name = "lbl_quantity"
        lbl_quantity.Size = New Size(107, 27)
        lbl_quantity.TabIndex = 36
        lbl_quantity.Text = "Quantity"
        ' 
        ' lbl_email
        ' 
        lbl_email.AutoSize = True
        lbl_email.Font = New Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        lbl_email.Location = New Point(54, 231)
        lbl_email.Name = "lbl_email"
        lbl_email.Size = New Size(171, 27)
        lbl_email.TabIndex = 37
        lbl_email.Text = "Email Address"
        ' 
        ' lbl_blood
        ' 
        lbl_blood.AutoSize = True
        lbl_blood.Font = New Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        lbl_blood.Location = New Point(52, 284)
        lbl_blood.Name = "lbl_blood"
        lbl_blood.Size = New Size(253, 27)
        lbl_blood.TabIndex = 38
        lbl_blood.Text = "Request Blood Group"
        ' 
        ' lbl_date
        ' 
        lbl_date.AutoSize = True
        lbl_date.Font = New Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        lbl_date.Location = New Point(52, 377)
        lbl_date.Name = "lbl_date"
        lbl_date.Size = New Size(162, 27)
        lbl_date.TabIndex = 39
        lbl_date.Text = "Request Date"
        ' 
        ' txt_centername
        ' 
        txt_centername.Font = New Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        txt_centername.Location = New Point(371, 146)
        txt_centername.Multiline = True
        txt_centername.Name = "txt_centername"
        txt_centername.Size = New Size(192, 27)
        txt_centername.TabIndex = 43
        ' 
        ' txt_contactnumber
        ' 
        txt_contactnumber.Font = New Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        txt_contactnumber.Location = New Point(371, 187)
        txt_contactnumber.Name = "txt_contactnumber"
        txt_contactnumber.Size = New Size(192, 34)
        txt_contactnumber.TabIndex = 44
        ' 
        ' txt_email
        ' 
        txt_email.Font = New Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        txt_email.Location = New Point(371, 228)
        txt_email.Name = "txt_email"
        txt_email.Size = New Size(192, 34)
        txt_email.TabIndex = 45
        ' 
        ' txt_quantity
        ' 
        txt_quantity.Font = New Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        txt_quantity.Location = New Point(371, 323)
        txt_quantity.Name = "txt_quantity"
        txt_quantity.Size = New Size(192, 34)
        txt_quantity.TabIndex = 47
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8, Column9, Column10})
        DataGridView1.Location = New Point(652, 377)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(597, 260)
        DataGridView1.TabIndex = 49
        ' 
        ' ComboBox1_selectblood
        ' 
        ComboBox1_selectblood.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox1_selectblood.Font = New Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        ComboBox1_selectblood.FormattingEnabled = True
        ComboBox1_selectblood.Items.AddRange(New Object() {"A-", "A+", "B-", "B+", "O-", "O+", "AB-", "AB+"})
        ComboBox1_selectblood.Location = New Point(371, 276)
        ComboBox1_selectblood.Name = "ComboBox1_selectblood"
        ComboBox1_selectblood.Size = New Size(192, 35)
        ComboBox1_selectblood.TabIndex = 54
        ' 
        ' DateTimePicker1_requestdate
        ' 
        DateTimePicker1_requestdate.Font = New Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        DateTimePicker1_requestdate.Location = New Point(371, 369)
        DateTimePicker1_requestdate.Name = "DateTimePicker1_requestdate"
        DateTimePicker1_requestdate.Size = New Size(192, 34)
        DateTimePicker1_requestdate.TabIndex = 55
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        Label1.Font = New Font("Arial", 22.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.FromArgb(CByte(179), CByte(14), CByte(8))
        Label1.Location = New Point(30, 29)
        Label1.Name = "Label1"
        Label1.Size = New Size(283, 44)
        Label1.TabIndex = 60
        Label1.Text = "Blood Request"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(52, 459)
        Label2.Name = "Label2"
        Label2.Size = New Size(183, 27)
        Label2.TabIndex = 61
        Label2.Text = "Request Status"
        ' 
        ' txtstatus
        ' 
        txtstatus.Font = New Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        txtstatus.Location = New Point(371, 451)
        txtstatus.Multiline = True
        txtstatus.Name = "txtstatus"
        txtstatus.Size = New Size(192, 27)
        txtstatus.TabIndex = 62
        ' 
        ' txtsearch
        ' 
        txtsearch.Location = New Point(831, 40)
        txtsearch.Multiline = True
        txtsearch.Name = "txtsearch"
        txtsearch.Size = New Size(346, 33)
        txtsearch.TabIndex = 63
        ' 
        ' btnsearch
        ' 
        btnsearch.BackColor = Color.FromArgb(CByte(128), CByte(64), CByte(64))
        btnsearch.FlatStyle = FlatStyle.Popup
        btnsearch.Font = New Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        btnsearch.ForeColor = SystemColors.ButtonHighlight
        btnsearch.Location = New Point(727, 40)
        btnsearch.Name = "btnsearch"
        btnsearch.Size = New Size(94, 34)
        btnsearch.TabIndex = 65
        btnsearch.Text = "Search"
        btnsearch.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Wheat
        Panel1.Controls.Add(lblOMinus)
        Panel1.Controls.Add(lblOPlus)
        Panel1.Controls.Add(lblABMinus)
        Panel1.Controls.Add(lblABPlus)
        Panel1.Controls.Add(lblBMinus)
        Panel1.Controls.Add(lblBPlus)
        Panel1.Controls.Add(lblAMinus)
        Panel1.Controls.Add(lblAPlus)
        Panel1.Location = New Point(727, 124)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(477, 217)
        Panel1.TabIndex = 66
        ' 
        ' lblOMinus
        ' 
        lblOMinus.AutoSize = True
        lblOMinus.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblOMinus.Location = New Point(367, 153)
        lblOMinus.Name = "lblOMinus"
        lblOMinus.Size = New Size(82, 24)
        lblOMinus.TabIndex = 7
        lblOMinus.Text = "Label11"
        ' 
        ' lblOPlus
        ' 
        lblOPlus.AutoSize = True
        lblOPlus.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblOPlus.Location = New Point(367, 34)
        lblOPlus.Name = "lblOPlus"
        lblOPlus.Size = New Size(83, 24)
        lblOPlus.TabIndex = 6
        lblOPlus.Text = "Label10"
        ' 
        ' lblABMinus
        ' 
        lblABMinus.AutoSize = True
        lblABMinus.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblABMinus.Location = New Point(248, 153)
        lblABMinus.Name = "lblABMinus"
        lblABMinus.Size = New Size(72, 24)
        lblABMinus.TabIndex = 5
        lblABMinus.Text = "Label9"
        ' 
        ' lblABPlus
        ' 
        lblABPlus.AutoSize = True
        lblABPlus.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblABPlus.Location = New Point(248, 34)
        lblABPlus.Name = "lblABPlus"
        lblABPlus.Size = New Size(72, 24)
        lblABPlus.TabIndex = 4
        lblABPlus.Text = "Label8"
        ' 
        ' lblBMinus
        ' 
        lblBMinus.AutoSize = True
        lblBMinus.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblBMinus.Location = New Point(133, 151)
        lblBMinus.Name = "lblBMinus"
        lblBMinus.Size = New Size(72, 24)
        lblBMinus.TabIndex = 3
        lblBMinus.Text = "Label7"
        ' 
        ' lblBPlus
        ' 
        lblBPlus.AutoSize = True
        lblBPlus.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblBPlus.Location = New Point(133, 29)
        lblBPlus.Name = "lblBPlus"
        lblBPlus.Size = New Size(72, 24)
        lblBPlus.TabIndex = 2
        lblBPlus.Text = "Label6"
        ' 
        ' lblAMinus
        ' 
        lblAMinus.AutoSize = True
        lblAMinus.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblAMinus.Location = New Point(34, 151)
        lblAMinus.Name = "lblAMinus"
        lblAMinus.Size = New Size(72, 24)
        lblAMinus.TabIndex = 1
        lblAMinus.Text = "Label5"
        ' 
        ' lblAPlus
        ' 
        lblAPlus.AutoSize = True
        lblAPlus.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblAPlus.Location = New Point(34, 29)
        lblAPlus.Name = "lblAPlus"
        lblAPlus.Size = New Size(72, 24)
        lblAPlus.TabIndex = 0
        lblAPlus.Text = "Label4"
        ' 
        ' btndelete
        ' 
        btndelete.BackColor = Color.IndianRed
        btndelete.FlatStyle = FlatStyle.Popup
        btndelete.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btndelete.Location = New Point(398, 569)
        btndelete.Name = "btndelete"
        btndelete.Size = New Size(94, 35)
        btndelete.TabIndex = 88
        btndelete.Text = "Delete"
        btndelete.UseVisualStyleBackColor = False
        ' 
        ' btnedit
        ' 
        btnedit.BackColor = Color.CornflowerBlue
        btnedit.FlatStyle = FlatStyle.Popup
        btnedit.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnedit.Location = New Point(198, 569)
        btnedit.Name = "btnedit"
        btnedit.Size = New Size(94, 35)
        btnedit.TabIndex = 87
        btnedit.Text = "Edit"
        btnedit.UseVisualStyleBackColor = False
        ' 
        ' btnclear
        ' 
        btnclear.BackColor = Color.Gold
        btnclear.FlatStyle = FlatStyle.Popup
        btnclear.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnclear.Location = New Point(298, 569)
        btnclear.Name = "btnclear"
        btnclear.Size = New Size(94, 35)
        btnclear.TabIndex = 86
        btnclear.Text = "Clear"
        btnclear.UseVisualStyleBackColor = False
        ' 
        ' btnsave
        ' 
        btnsave.BackColor = Color.YellowGreen
        btnsave.FlatStyle = FlatStyle.Popup
        btnsave.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnsave.Location = New Point(70, 569)
        btnsave.Name = "btnsave"
        btnsave.Size = New Size(122, 35)
        btnsave.TabIndex = 85
        btnsave.Text = "Add"
        btnsave.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(52, 418)
        Label3.Name = "Label3"
        Label3.Size = New Size(141, 27)
        Label3.TabIndex = 89
        Label3.Text = "Component"
        ' 
        ' ComboBox1_component
        ' 
        ComboBox1_component.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox1_component.Font = New Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        ComboBox1_component.FormattingEnabled = True
        ComboBox1_component.Location = New Point(371, 410)
        ComboBox1_component.Name = "ComboBox1_component"
        ComboBox1_component.Size = New Size(192, 35)
        ComboBox1_component.TabIndex = 90
        ' 
        ' txtid
        ' 
        txtid.Font = New Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        txtid.Location = New Point(371, 108)
        txtid.Multiline = True
        txtid.Name = "txtid"
        txtid.Size = New Size(192, 27)
        txtid.TabIndex = 92
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label12.Location = New Point(52, 111)
        Label12.Name = "Label12"
        Label12.Size = New Size(205, 27)
        Label12.TabIndex = 91
        Label12.Text = "Blood Request ID"
        ' 
        ' Column1
        ' 
        Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        DataGridViewCellStyle1.Font = New Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Column1.DefaultCellStyle = DataGridViewCellStyle1
        Column1.HeaderText = "Amount of blood request"
        Column1.MinimumWidth = 6
        Column1.Name = "Column1"
        Column1.Width = 119
        ' 
        ' Column2
        ' 
        Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle2.Font = New Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Column2.DefaultCellStyle = DataGridViewCellStyle2
        Column2.HeaderText = "Blood Request ID"
        Column2.MinimumWidth = 6
        Column2.Name = "Column2"
        Column2.Width = 112
        ' 
        ' Column3
        ' 
        Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle3.Font = New Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Column3.DefaultCellStyle = DataGridViewCellStyle3
        Column3.HeaderText = "Blood Request center name"
        Column3.MinimumWidth = 6
        Column3.Name = "Column3"
        Column3.Width = 146
        ' 
        ' Column4
        ' 
        Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle4.Font = New Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Column4.DefaultCellStyle = DataGridViewCellStyle4
        Column4.HeaderText = "Contact Number"
        Column4.MinimumWidth = 6
        Column4.Name = "Column4"
        Column4.Width = 119
        ' 
        ' Column5
        ' 
        Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle5.Font = New Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Column5.DefaultCellStyle = DataGridViewCellStyle5
        Column5.HeaderText = "Email "
        Column5.MinimumWidth = 6
        Column5.Name = "Column5"
        Column5.Width = 73
        ' 
        ' Column6
        ' 
        Column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle6.Font = New Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Column6.DefaultCellStyle = DataGridViewCellStyle6
        Column6.HeaderText = "Request Blood Group"
        Column6.MinimumWidth = 6
        Column6.Name = "Column6"
        Column6.Width = 112
        ' 
        ' Column7
        ' 
        Column7.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle7.Font = New Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Column7.DefaultCellStyle = DataGridViewCellStyle7
        Column7.HeaderText = "Quantity"
        Column7.MinimumWidth = 6
        Column7.Name = "Column7"
        Column7.Width = 83
        ' 
        ' Column8
        ' 
        Column8.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle8.Font = New Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Column8.DefaultCellStyle = DataGridViewCellStyle8
        Column8.HeaderText = "Request Date"
        Column8.MinimumWidth = 6
        Column8.Name = "Column8"
        Column8.Width = 104
        ' 
        ' Column9
        ' 
        Column9.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle9.Font = New Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Column9.DefaultCellStyle = DataGridViewCellStyle9
        Column9.HeaderText = "Component"
        Column9.MinimumWidth = 6
        Column9.Name = "Column9"
        Column9.Width = 103
        ' 
        ' Column10
        ' 
        Column10.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle10.Font = New Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Column10.DefaultCellStyle = DataGridViewCellStyle10
        Column10.HeaderText = "Request Status"
        Column10.MinimumWidth = 6
        Column10.Name = "Column10"
        Column10.Width = 111
        ' 
        ' Blood_Request
        ' 
        AutoScaleDimensions = New SizeF(7F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.OldLace
        ClientSize = New Size(1272, 669)
        Controls.Add(txtid)
        Controls.Add(Label12)
        Controls.Add(ComboBox1_component)
        Controls.Add(Label3)
        Controls.Add(btndelete)
        Controls.Add(btnedit)
        Controls.Add(btnclear)
        Controls.Add(btnsave)
        Controls.Add(Panel1)
        Controls.Add(btnsearch)
        Controls.Add(txtsearch)
        Controls.Add(txtstatus)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(DateTimePicker1_requestdate)
        Controls.Add(ComboBox1_selectblood)
        Controls.Add(DataGridView1)
        Controls.Add(txt_quantity)
        Controls.Add(txt_email)
        Controls.Add(txt_contactnumber)
        Controls.Add(txt_centername)
        Controls.Add(lbl_date)
        Controls.Add(lbl_blood)
        Controls.Add(lbl_email)
        Controls.Add(lbl_quantity)
        Controls.Add(lbl_contact_number)
        Controls.Add(lblhospital_name)
        Font = New Font("Arial Narrow", 9F, FontStyle.Regular, GraphicsUnit.Point)
        FormBorderStyle = FormBorderStyle.None
        Name = "Blood_Request"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Blood_Request"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents lblhospital_name As Label
    Friend WithEvents lbl_contact_number As Label
    Friend WithEvents lbl_quantity As Label
    Friend WithEvents lbl_email As Label
    Friend WithEvents lbl_blood As Label
    Friend WithEvents lbl_date As Label
    Friend WithEvents txt_centername As TextBox
    Friend WithEvents txt_contactnumber As TextBox
    Friend WithEvents txt_email As TextBox
    Friend WithEvents txt_quantity As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ComboBox1_selectblood As ComboBox
    Friend WithEvents DateTimePicker1_requestdate As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtstatus As TextBox
    Friend WithEvents txtsearch As TextBox
    Friend WithEvents btnsearch As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btndelete As Button
    Friend WithEvents btnedit As Button
    Friend WithEvents btnclear As Button
    Friend WithEvents btnsave As Button
    Friend WithEvents LabelOMinus As Label
    Friend WithEvents LabelOPlus As Label
    Friend WithEvents LabelABMinus As Label
    Friend WithEvents LabelABPlus As Label
    Friend WithEvents LabelBMinus As Label
    Friend WithEvents LabelBPlus As Label
    Friend WithEvents LabelAMinus As Label
    Friend WithEvents LabelAPlus As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBox1_component As ComboBox
    Friend WithEvents txtid As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents lblAPlus As Label
    Friend WithEvents lblAMinus As Label
    Friend WithEvents lblBPlus As Label
    Friend WithEvents lblBMinus As Label
    Friend WithEvents lblABPlus As Label
    Friend WithEvents lblABMinus As Label
    Friend WithEvents lblOPlus As Label
    Friend WithEvents lblOMinus As Label
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
End Class
