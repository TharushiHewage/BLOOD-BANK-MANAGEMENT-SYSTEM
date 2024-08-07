<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class blood_stock_details_with_barcode
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
        Panel1_bloodbaginfo = New Panel()
        Panel1 = New Panel()
        txtbloodtype = New TextBox()
        PictureBox1 = New PictureBox()
        txtcollectionsite = New TextBox()
        txtstorage = New TextBox()
        txttested = New TextBox()
        txtID = New TextBox()
        txtgender = New TextBox()
        txtage = New TextBox()
        txtexpire = New TextBox()
        txtcollection = New TextBox()
        txtvolume = New TextBox()
        txtcompo = New TextBox()
        Label16 = New Label()
        Label15 = New Label()
        Label13 = New Label()
        Label12 = New Label()
        Label11 = New Label()
        Label10 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label1 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        btnclear = New Button()
        btnsave = New Button()
        btnGenerateBarcode = New Button()
        btnprint = New Button()
        btnreport = New Button()
        Panel1_bloodbaginfo.SuspendLayout()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1_bloodbaginfo
        ' 
        Panel1_bloodbaginfo.BackColor = Color.OldLace
        Panel1_bloodbaginfo.BorderStyle = BorderStyle.FixedSingle
        Panel1_bloodbaginfo.Controls.Add(Panel1)
        Panel1_bloodbaginfo.Controls.Add(Label3)
        Panel1_bloodbaginfo.Controls.Add(Label2)
        Panel1_bloodbaginfo.Location = New Point(183, 25)
        Panel1_bloodbaginfo.Name = "Panel1_bloodbaginfo"
        Panel1_bloodbaginfo.Size = New Size(806, 794)
        Panel1_bloodbaginfo.TabIndex = 0
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(txtbloodtype)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(txtcollectionsite)
        Panel1.Controls.Add(txtstorage)
        Panel1.Controls.Add(txttested)
        Panel1.Controls.Add(txtID)
        Panel1.Controls.Add(txtgender)
        Panel1.Controls.Add(txtage)
        Panel1.Controls.Add(txtexpire)
        Panel1.Controls.Add(txtcollection)
        Panel1.Controls.Add(txtvolume)
        Panel1.Controls.Add(txtcompo)
        Panel1.Controls.Add(Label16)
        Panel1.Controls.Add(Label15)
        Panel1.Controls.Add(Label13)
        Panel1.Controls.Add(Label12)
        Panel1.Controls.Add(Label11)
        Panel1.Controls.Add(Label10)
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(63, 101)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(679, 676)
        Panel1.TabIndex = 81
        ' 
        ' txtbloodtype
        ' 
        txtbloodtype.BorderStyle = BorderStyle.None
        txtbloodtype.Font = New Font("Arial", 36F, FontStyle.Bold, GraphicsUnit.Point)
        txtbloodtype.Location = New Point(490, 50)
        txtbloodtype.Multiline = True
        txtbloodtype.Name = "txtbloodtype"
        txtbloodtype.Size = New Size(188, 92)
        txtbloodtype.TabIndex = 28
        txtbloodtype.Text = "B+"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(208, 482)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(312, 147)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 26
        PictureBox1.TabStop = False
        ' 
        ' txtcollectionsite
        ' 
        txtcollectionsite.Location = New Point(249, 439)
        txtcollectionsite.Name = "txtcollectionsite"
        txtcollectionsite.Size = New Size(231, 27)
        txtcollectionsite.TabIndex = 25
        ' 
        ' txtstorage
        ' 
        txtstorage.Location = New Point(249, 388)
        txtstorage.Name = "txtstorage"
        txtstorage.Size = New Size(231, 27)
        txtstorage.TabIndex = 24
        ' 
        ' txttested
        ' 
        txttested.Location = New Point(249, 342)
        txttested.Name = "txttested"
        txttested.Size = New Size(231, 27)
        txttested.TabIndex = 23
        ' 
        ' txtID
        ' 
        txtID.Font = New Font("Arial Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        txtID.Location = New Point(249, 42)
        txtID.Name = "txtID"
        txtID.Size = New Size(231, 31)
        txtID.TabIndex = 20
        ' 
        ' txtgender
        ' 
        txtgender.Location = New Point(249, 296)
        txtgender.Name = "txtgender"
        txtgender.Size = New Size(231, 27)
        txtgender.TabIndex = 21
        ' 
        ' txtage
        ' 
        txtage.Location = New Point(249, 249)
        txtage.Name = "txtage"
        txtage.Size = New Size(231, 27)
        txtage.TabIndex = 19
        ' 
        ' txtexpire
        ' 
        txtexpire.Location = New Point(249, 208)
        txtexpire.Name = "txtexpire"
        txtexpire.Size = New Size(231, 27)
        txtexpire.TabIndex = 18
        ' 
        ' txtcollection
        ' 
        txtcollection.Location = New Point(249, 169)
        txtcollection.Name = "txtcollection"
        txtcollection.Size = New Size(231, 27)
        txtcollection.TabIndex = 17
        ' 
        ' txtvolume
        ' 
        txtvolume.Location = New Point(249, 131)
        txtvolume.Name = "txtvolume"
        txtvolume.Size = New Size(231, 27)
        txtvolume.TabIndex = 16
        ' 
        ' txtcompo
        ' 
        txtcompo.Location = New Point(249, 87)
        txtcompo.Name = "txtcompo"
        txtcompo.Size = New Size(231, 27)
        txtcompo.TabIndex = 14
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label16.Location = New Point(518, 153)
        Label16.Name = "Label16"
        Label16.Size = New Size(97, 19)
        Label16.TabIndex = 13
        Label16.Text = "Blood Type"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label15.Location = New Point(83, 87)
        Label15.Name = "Label15"
        Label15.Size = New Size(100, 19)
        Label15.TabIndex = 12
        Label15.Text = "Component"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label13.Location = New Point(85, 482)
        Label13.Name = "Label13"
        Label13.Size = New Size(75, 19)
        Label13.TabIndex = 10
        Label13.Text = "Barcode"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label12.Location = New Point(83, 439)
        Label12.Name = "Label12"
        Label12.Size = New Size(122, 19)
        Label12.TabIndex = 9
        Label12.Text = "Collection Site"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label11.Location = New Point(83, 388)
        Label11.Name = "Label11"
        Label11.Size = New Size(71, 19)
        Label11.TabIndex = 8
        Label11.Text = "Storage"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label10.Location = New Point(83, 342)
        Label10.Name = "Label10"
        Label10.Size = New Size(61, 19)
        Label10.TabIndex = 7
        Label10.Text = "Tested"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.Location = New Point(83, 296)
        Label8.Name = "Label8"
        Label8.Size = New Size(121, 19)
        Label8.TabIndex = 5
        Label8.Text = "Donor Gender"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.Location = New Point(83, 249)
        Label7.Name = "Label7"
        Label7.Size = New Size(92, 19)
        Label7.TabIndex = 4
        Label7.Text = "Donor Age"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(83, 212)
        Label6.Name = "Label6"
        Label6.Size = New Size(100, 19)
        Label6.TabIndex = 3
        Label6.Text = "Expiry Date"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(83, 173)
        Label5.Name = "Label5"
        Label5.Size = New Size(128, 19)
        Label5.TabIndex = 2
        Label5.Text = "Collection Date"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(85, 135)
        Label4.Name = "Label4"
        Label4.Size = New Size(66, 19)
        Label4.TabIndex = 1
        Label4.Text = "Volume"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Black", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(83, 45)
        Label1.Name = "Label1"
        Label1.Size = New Size(145, 26)
        Label1.TabIndex = 0
        Label1.Text = "Blood Bag ID "
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(283, 66)
        Label3.Name = "Label3"
        Label3.Size = New Size(251, 21)
        Label3.TabIndex = 80
        Label3.Text = "BLOOD BAG INFORMATION"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.Firebrick
        Label2.Location = New Point(286, 27)
        Label2.Name = "Label2"
        Label2.Size = New Size(248, 24)
        Label2.TabIndex = 79
        Label2.Text = "~LIFELINE BLOOD BANK~"
        ' 
        ' btnclear
        ' 
        btnclear.BackColor = Color.Gold
        btnclear.FlatStyle = FlatStyle.Popup
        btnclear.Font = New Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        btnclear.Location = New Point(54, 437)
        btnclear.Name = "btnclear"
        btnclear.Size = New Size(94, 29)
        btnclear.TabIndex = 4
        btnclear.Text = "Clear"
        btnclear.UseVisualStyleBackColor = False
        ' 
        ' btnsave
        ' 
        btnsave.BackColor = Color.YellowGreen
        btnsave.FlatStyle = FlatStyle.Popup
        btnsave.Font = New Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        btnsave.Location = New Point(54, 379)
        btnsave.Name = "btnsave"
        btnsave.Size = New Size(94, 29)
        btnsave.TabIndex = 3
        btnsave.Text = "Save"
        btnsave.UseVisualStyleBackColor = False
        ' 
        ' btnGenerateBarcode
        ' 
        btnGenerateBarcode.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        btnGenerateBarcode.FlatStyle = FlatStyle.Popup
        btnGenerateBarcode.Font = New Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        btnGenerateBarcode.Location = New Point(54, 319)
        btnGenerateBarcode.Name = "btnGenerateBarcode"
        btnGenerateBarcode.Size = New Size(106, 29)
        btnGenerateBarcode.TabIndex = 1
        btnGenerateBarcode.Text = "Generate"
        btnGenerateBarcode.UseVisualStyleBackColor = False
        ' 
        ' btnprint
        ' 
        btnprint.BackColor = Color.SandyBrown
        btnprint.FlatStyle = FlatStyle.Popup
        btnprint.Font = New Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        btnprint.Location = New Point(54, 497)
        btnprint.Name = "btnprint"
        btnprint.Size = New Size(94, 29)
        btnprint.TabIndex = 2
        btnprint.Text = "Print"
        btnprint.UseVisualStyleBackColor = False
        ' 
        ' btnreport
        ' 
        btnreport.BackColor = Color.Tomato
        btnreport.FlatStyle = FlatStyle.Popup
        btnreport.Font = New Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        btnreport.Location = New Point(54, 557)
        btnreport.Name = "btnreport"
        btnreport.Size = New Size(94, 29)
        btnreport.TabIndex = 5
        btnreport.Text = "Report"
        btnreport.UseVisualStyleBackColor = False
        ' 
        ' blood_stock_details_with_barcode
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1057, 924)
        Controls.Add(btnreport)
        Controls.Add(btnprint)
        Controls.Add(btnGenerateBarcode)
        Controls.Add(btnclear)
        Controls.Add(btnsave)
        Controls.Add(Panel1_bloodbaginfo)
        FormBorderStyle = FormBorderStyle.None
        Name = "blood_stock_details_with_barcode"
        Text = "blood_stock_details_with_barcode"
        Panel1_bloodbaginfo.ResumeLayout(False)
        Panel1_bloodbaginfo.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1_bloodbaginfo As Panel
    Friend WithEvents btnGenerateBarcode As Button
    Friend WithEvents btnprint As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnsave As Button
    Friend WithEvents btnclear As Button
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtexpire As TextBox
    Friend WithEvents txtcollection As TextBox
    Friend WithEvents txtvolume As TextBox
    Friend WithEvents txtcompo As TextBox
    Friend WithEvents txtcollectionsite As TextBox
    Friend WithEvents txtstorage As TextBox
    Friend WithEvents txttested As TextBox
    Friend WithEvents txtgender As TextBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtage As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtbloodtype As TextBox
    Friend WithEvents btnreport As Button
End Class
