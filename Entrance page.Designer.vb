<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Entrance_page
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Entrance_page))
        Panel1_entrance = New Panel()
        PictureBox1 = New PictureBox()
        btngetstarted = New Button()
        Lblgiveblood = New Label()
        lblbegrateful = New Label()
        Label2 = New Label()
        Label1 = New Label()
        lblbloodbank = New Label()
        lbllifeline = New Label()
        lblwelcometo = New Label()
        Panel1 = New Panel()
        lblexit = New Label()
        Panel1_entrance.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1_entrance
        ' 
        Panel1_entrance.Controls.Add(PictureBox1)
        Panel1_entrance.Controls.Add(btngetstarted)
        Panel1_entrance.Controls.Add(Lblgiveblood)
        Panel1_entrance.Controls.Add(lblbegrateful)
        Panel1_entrance.Controls.Add(Label2)
        Panel1_entrance.Controls.Add(Label1)
        Panel1_entrance.Controls.Add(lblbloodbank)
        Panel1_entrance.Controls.Add(lbllifeline)
        Panel1_entrance.Controls.Add(lblwelcometo)
        Panel1_entrance.Location = New Point(0, 43)
        Panel1_entrance.Name = "Panel1_entrance"
        Panel1_entrance.Size = New Size(1638, 783)
        Panel1_entrance.TabIndex = 0
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(720, 156)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(151, 140)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 35
        PictureBox1.TabStop = False
        ' 
        ' btngetstarted
        ' 
        btngetstarted.BackColor = SystemColors.ActiveCaption
        btngetstarted.FlatStyle = FlatStyle.Popup
        btngetstarted.Font = New Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        btngetstarted.Location = New Point(643, 666)
        btngetstarted.Name = "btngetstarted"
        btngetstarted.Size = New Size(270, 64)
        btngetstarted.TabIndex = 34
        btngetstarted.Text = "Visit Us"
        btngetstarted.UseVisualStyleBackColor = False
        ' 
        ' Lblgiveblood
        ' 
        Lblgiveblood.AutoSize = True
        Lblgiveblood.Font = New Font("Times New Roman", 19.8000011F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Lblgiveblood.ForeColor = Color.Yellow
        Lblgiveblood.Location = New Point(628, 523)
        Lblgiveblood.Name = "Lblgiveblood"
        Lblgiveblood.Size = New Size(313, 156)
        Lblgiveblood.TabIndex = 32
        Lblgiveblood.Text = "Give Blood Save Life" & vbCrLf & vbCrLf & vbCrLf & vbCrLf
        ' 
        ' lblbegrateful
        ' 
        lblbegrateful.AutoSize = True
        lblbegrateful.Font = New Font("Times New Roman", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point)
        lblbegrateful.ForeColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        lblbegrateful.Location = New Point(518, 475)
        lblbegrateful.Name = "lblbegrateful"
        lblbegrateful.Size = New Size(597, 204)
        lblbegrateful.TabIndex = 31
        lblbegrateful.Text = "Be Grateful And Donate Blood" & vbCrLf & vbCrLf & vbCrLf & vbCrLf
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(436, 276)
        Label2.Name = "Label2"
        Label2.Size = New Size(0, 20)
        Label2.TabIndex = 29
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(448, 298)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 20)
        Label1.TabIndex = 28
        ' 
        ' lblbloodbank
        ' 
        lblbloodbank.AutoSize = True
        lblbloodbank.FlatStyle = FlatStyle.Flat
        lblbloodbank.Font = New Font("Times New Roman", 28.2F, FontStyle.Bold, GraphicsUnit.Point)
        lblbloodbank.ForeColor = Color.Yellow
        lblbloodbank.Location = New Point(628, 364)
        lblbloodbank.Name = "lblbloodbank"
        lblbloodbank.Size = New Size(341, 159)
        lblbloodbank.TabIndex = 27
        lblbloodbank.Text = "BLOOD BANK" & vbCrLf & vbCrLf & vbCrLf
        ' 
        ' lbllifeline
        ' 
        lbllifeline.AutoSize = True
        lbllifeline.Font = New Font("Times New Roman", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point)
        lbllifeline.ForeColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        lbllifeline.Location = New Point(683, 313)
        lbllifeline.Name = "lbllifeline"
        lbllifeline.Size = New Size(230, 51)
        lbllifeline.TabIndex = 26
        lbllifeline.Text = "LIFELINE"
        ' 
        ' lblwelcometo
        ' 
        lblwelcometo.AutoSize = True
        lblwelcometo.Font = New Font("Times New Roman", 72F, FontStyle.Bold, GraphicsUnit.Point)
        lblwelcometo.ForeColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        lblwelcometo.Location = New Point(469, 0)
        lblwelcometo.Name = "lblwelcometo"
        lblwelcometo.Size = New Size(740, 540)
        lblwelcometo.TabIndex = 25
        lblwelcometo.Text = "WELCOME " & vbCrLf & vbCrLf & vbCrLf & vbCrLf
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Red
        Panel1.Controls.Add(lblexit)
        Panel1.Location = New Point(0, -5)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1659, 48)
        Panel1.TabIndex = 1
        ' 
        ' lblexit
        ' 
        lblexit.FlatStyle = FlatStyle.Flat
        lblexit.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        lblexit.Location = New Point(1507, 14)
        lblexit.Name = "lblexit"
        lblexit.Size = New Size(42, 31)
        lblexit.TabIndex = 34
        lblexit.Text = "x"
        ' 
        ' Entrance_page
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1650, 850)
        Controls.Add(Panel1)
        Controls.Add(Panel1_entrance)
        FormBorderStyle = FormBorderStyle.None
        Name = "Entrance_page"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Entrance_page"
        Panel1_entrance.ResumeLayout(False)
        Panel1_entrance.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1_entrance As Panel
    Friend WithEvents lblwelcometo As Label
    Friend WithEvents lblbloodbank As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Lblgiveblood As Label
    Friend WithEvents lblbegrateful As Label
    Friend WithEvents btngetstarted As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblexit As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lbllifeline As Label
End Class
