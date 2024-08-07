<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Doctor_Registration
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
        btndelete = New Button()
        btnsearch = New Button()
        btnedit = New Button()
        txtadmin = New TextBox()
        txtnic = New TextBox()
        lbladmin = New Label()
        lblnic = New Label()
        Label12 = New Label()
        DateTimePicker2_date = New DateTimePicker()
        btnclear = New Button()
        btnsave = New Button()
        lbldate = New Label()
        txtsearch = New TextBox()
        txtmobile = New TextBox()
        txtname = New TextBox()
        lblmobile = New Label()
        lblname = New Label()
        txtemail = New TextBox()
        lblemail = New Label()
        DataGridView1 = New DataGridView()
        lblpastex = New Label()
        txtpastex = New TextBox()
        txtduty = New TextBox()
        Label1 = New Label()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewTextBoxColumn()
        Column7 = New DataGridViewTextBoxColumn()
        Column8 = New DataGridViewTextBoxColumn()
        Column9 = New DataGridViewTextBoxColumn()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btndelete
        ' 
        btndelete.BackColor = Color.IndianRed
        btndelete.FlatStyle = FlatStyle.Popup
        btndelete.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btndelete.Location = New Point(855, 565)
        btndelete.Name = "btndelete"
        btndelete.Size = New Size(94, 35)
        btndelete.TabIndex = 124
        btndelete.Text = "Delete"
        btndelete.UseVisualStyleBackColor = False
        ' 
        ' btnsearch
        ' 
        btnsearch.BackColor = Color.FromArgb(CByte(128), CByte(64), CByte(64))
        btnsearch.FlatStyle = FlatStyle.Popup
        btnsearch.Font = New Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        btnsearch.ForeColor = SystemColors.ButtonHighlight
        btnsearch.Location = New Point(523, 35)
        btnsearch.Name = "btnsearch"
        btnsearch.Size = New Size(94, 34)
        btnsearch.TabIndex = 118
        btnsearch.Text = "Search"
        btnsearch.UseVisualStyleBackColor = False
        ' 
        ' btnedit
        ' 
        btnedit.BackColor = Color.CornflowerBlue
        btnedit.FlatStyle = FlatStyle.Popup
        btnedit.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnedit.Location = New Point(655, 565)
        btnedit.Name = "btnedit"
        btnedit.Size = New Size(94, 35)
        btnedit.TabIndex = 116
        btnedit.Text = "Edit"
        btnedit.UseVisualStyleBackColor = False
        ' 
        ' txtadmin
        ' 
        txtadmin.Font = New Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        txtadmin.Location = New Point(221, 360)
        txtadmin.Name = "txtadmin"
        txtadmin.Size = New Size(202, 34)
        txtadmin.TabIndex = 114
        txtadmin.Text = "Tharushi"
        ' 
        ' txtnic
        ' 
        txtnic.Font = New Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        txtnic.Location = New Point(220, 119)
        txtnic.Name = "txtnic"
        txtnic.Size = New Size(200, 34)
        txtnic.TabIndex = 110
        ' 
        ' lbladmin
        ' 
        lbladmin.AutoSize = True
        lbladmin.Font = New Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        lbladmin.Location = New Point(57, 360)
        lbladmin.Name = "lbladmin"
        lbladmin.Size = New Size(152, 27)
        lbladmin.TabIndex = 109
        lbladmin.Text = "Admin Name"
        ' 
        ' lblnic
        ' 
        lblnic.AutoSize = True
        lblnic.Font = New Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        lblnic.Location = New Point(53, 119)
        lblnic.Name = "lblnic"
        lblnic.Size = New Size(51, 27)
        lblnic.TabIndex = 105
        lblnic.Text = "NIC"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        Label12.Font = New Font("Arial", 22.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label12.ForeColor = Color.FromArgb(CByte(179), CByte(14), CByte(8))
        Label12.Location = New Point(19, 19)
        Label12.Name = "Label12"
        Label12.Size = New Size(349, 44)
        Label12.TabIndex = 104
        Label12.Text = "Staff Registrations"
        ' 
        ' DateTimePicker2_date
        ' 
        DateTimePicker2_date.Font = New Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        DateTimePicker2_date.Format = DateTimePickerFormat.Short
        DateTimePicker2_date.Location = New Point(221, 416)
        DateTimePicker2_date.Name = "DateTimePicker2_date"
        DateTimePicker2_date.Size = New Size(202, 34)
        DateTimePicker2_date.TabIndex = 101
        ' 
        ' btnclear
        ' 
        btnclear.BackColor = Color.Gold
        btnclear.FlatStyle = FlatStyle.Popup
        btnclear.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnclear.Location = New Point(755, 565)
        btnclear.Name = "btnclear"
        btnclear.Size = New Size(94, 35)
        btnclear.TabIndex = 100
        btnclear.Text = "Clear"
        btnclear.UseVisualStyleBackColor = False
        ' 
        ' btnsave
        ' 
        btnsave.BackColor = Color.YellowGreen
        btnsave.FlatStyle = FlatStyle.Popup
        btnsave.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnsave.Location = New Point(555, 565)
        btnsave.Name = "btnsave"
        btnsave.Size = New Size(94, 35)
        btnsave.TabIndex = 99
        btnsave.Text = "Add"
        btnsave.UseVisualStyleBackColor = False
        ' 
        ' lbldate
        ' 
        lbldate.AutoSize = True
        lbldate.Font = New Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        lbldate.Location = New Point(57, 415)
        lbldate.Name = "lbldate"
        lbldate.Size = New Size(63, 27)
        lbldate.TabIndex = 97
        lbldate.Text = "Date"
        ' 
        ' txtsearch
        ' 
        txtsearch.Font = New Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        txtsearch.Location = New Point(623, 35)
        txtsearch.Multiline = True
        txtsearch.Name = "txtsearch"
        txtsearch.Size = New Size(370, 33)
        txtsearch.TabIndex = 96
        ' 
        ' txtmobile
        ' 
        txtmobile.Font = New Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        txtmobile.Location = New Point(220, 266)
        txtmobile.Name = "txtmobile"
        txtmobile.Size = New Size(202, 34)
        txtmobile.TabIndex = 93
        ' 
        ' txtname
        ' 
        txtname.Font = New Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        txtname.Location = New Point(221, 163)
        txtname.Name = "txtname"
        txtname.Size = New Size(202, 34)
        txtname.TabIndex = 92
        ' 
        ' lblmobile
        ' 
        lblmobile.AutoSize = True
        lblmobile.Font = New Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        lblmobile.Location = New Point(56, 262)
        lblmobile.Name = "lblmobile"
        lblmobile.Size = New Size(86, 27)
        lblmobile.TabIndex = 86
        lblmobile.Text = "Mobile"
        ' 
        ' lblname
        ' 
        lblname.AutoSize = True
        lblname.Font = New Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        lblname.Location = New Point(56, 163)
        lblname.Name = "lblname"
        lblname.Size = New Size(74, 27)
        lblname.TabIndex = 85
        lblname.Text = "Name"
        ' 
        ' txtemail
        ' 
        txtemail.Font = New Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        txtemail.Location = New Point(221, 313)
        txtemail.Name = "txtemail"
        txtemail.Size = New Size(202, 34)
        txtemail.TabIndex = 125
        ' 
        ' lblemail
        ' 
        lblemail.AutoSize = True
        lblemail.Font = New Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        lblemail.Location = New Point(57, 310)
        lblemail.Name = "lblemail"
        lblemail.Size = New Size(73, 27)
        lblemail.TabIndex = 126
        lblemail.Text = "Email"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8, Column9})
        DataGridView1.Location = New Point(494, 119)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(512, 414)
        DataGridView1.TabIndex = 127
        ' 
        ' lblpastex
        ' 
        lblpastex.AutoSize = True
        lblpastex.Font = New Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        lblpastex.Location = New Point(55, 211)
        lblpastex.Name = "lblpastex"
        lblpastex.Size = New Size(191, 27)
        lblpastex.TabIndex = 128
        lblpastex.Text = "Past Experience"
        ' 
        ' txtpastex
        ' 
        txtpastex.Font = New Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        txtpastex.Location = New Point(221, 211)
        txtpastex.Name = "txtpastex"
        txtpastex.Size = New Size(202, 34)
        txtpastex.TabIndex = 129
        ' 
        ' txtduty
        ' 
        txtduty.Font = New Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        txtduty.Location = New Point(221, 474)
        txtduty.Name = "txtduty"
        txtduty.Size = New Size(202, 34)
        txtduty.TabIndex = 131
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(57, 474)
        Label1.Name = "Label1"
        Label1.Size = New Size(63, 27)
        Label1.TabIndex = 130
        Label1.Text = "Duty"
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
        Column4.HeaderText = "Past Experience"
        Column4.MinimumWidth = 6
        Column4.Name = "Column4"
        Column4.Width = 140
        ' 
        ' Column5
        ' 
        Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column5.HeaderText = "Mobile"
        Column5.MinimumWidth = 6
        Column5.Name = "Column5"
        Column5.Width = 85
        ' 
        ' Column6
        ' 
        Column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column6.HeaderText = "Email"
        Column6.MinimumWidth = 6
        Column6.Name = "Column6"
        Column6.Width = 75
        ' 
        ' Column7
        ' 
        Column7.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column7.HeaderText = "Admin Name"
        Column7.MinimumWidth = 6
        Column7.Name = "Column7"
        Column7.Width = 126
        ' 
        ' Column8
        ' 
        Column8.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column8.HeaderText = "Date"
        Column8.MinimumWidth = 6
        Column8.Name = "Column8"
        Column8.Width = 70
        ' 
        ' Column9
        ' 
        Column9.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column9.HeaderText = "Duty"
        Column9.MinimumWidth = 6
        Column9.Name = "Column9"
        Column9.Width = 69
        ' 
        ' Doctor_Registration
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.OldLace
        ClientSize = New Size(1048, 643)
        Controls.Add(txtduty)
        Controls.Add(Label1)
        Controls.Add(txtpastex)
        Controls.Add(lblpastex)
        Controls.Add(DataGridView1)
        Controls.Add(lblemail)
        Controls.Add(txtemail)
        Controls.Add(btndelete)
        Controls.Add(btnsearch)
        Controls.Add(btnedit)
        Controls.Add(txtadmin)
        Controls.Add(txtnic)
        Controls.Add(lbladmin)
        Controls.Add(lblnic)
        Controls.Add(Label12)
        Controls.Add(DateTimePicker2_date)
        Controls.Add(btnclear)
        Controls.Add(btnsave)
        Controls.Add(lbldate)
        Controls.Add(txtsearch)
        Controls.Add(txtmobile)
        Controls.Add(txtname)
        Controls.Add(lblmobile)
        Controls.Add(lblname)
        FormBorderStyle = FormBorderStyle.None
        Name = "Doctor_Registration"
        Text = "Doctor_Registration"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btndelete As Button
    Friend WithEvents btnsearch As Button
    Friend WithEvents btnedit As Button
    Friend WithEvents txtadmin As TextBox
    Friend WithEvents txtnic As TextBox
    Friend WithEvents lbladmin As Label
    Friend WithEvents lblnic As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents DateTimePicker2_date As DateTimePicker
    Friend WithEvents btnclear As Button
    Friend WithEvents btnsave As Button
    Friend WithEvents lbldate As Label
    Friend WithEvents txtsearch As TextBox
    Friend WithEvents txtmobile As TextBox
    Friend WithEvents txtname As TextBox
    Friend WithEvents lblmobile As Label
    Friend WithEvents lblname As Label
    Friend WithEvents txtemail As TextBox
    Friend WithEvents lblemail As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents lblpastex As Label
    Friend WithEvents txtpastex As TextBox
    Friend WithEvents txtduty As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
End Class
