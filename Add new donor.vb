Imports System.ComponentModel.DataAnnotations
Imports System.Drawing.Printing
Imports System.Text.RegularExpressions
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient
Imports Mysqlx

Public Class Add_new_donor
    Dim conn As New MySqlConnection("server=localhost;port=3306;username=root;password=;database=bloodbank")
    Dim dr As MySqlDataReader
    Dim i As Integer


    Private Sub Add_new_donor_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DGV_load()
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click

        If String.IsNullOrEmpty(txtnic.Text) OrElse
            String.IsNullOrEmpty(txtname.Text) OrElse
            String.IsNullOrEmpty(txtmobile.Text) OrElse
            String.IsNullOrEmpty(ComboBox1_gender.Text) OrElse
            String.IsNullOrEmpty(txtbloodqty.Text) OrElse
            String.IsNullOrEmpty(ComboBox2_bloodgroup.Text) OrElse
            String.IsNullOrEmpty(txtstatus.Text) OrElse
            String.IsNullOrEmpty(txtage.Text) OrElse
            String.IsNullOrEmpty(txtweight.Text) OrElse
            String.IsNullOrEmpty(txtmedical.Text) OrElse
            String.IsNullOrEmpty(txtdoctor.Text) OrElse
            String.IsNullOrEmpty(txtcertificate.Text) Then


            MessageBox.Show("All the required fields must be filled.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If String.IsNullOrEmpty(txtdonorid.Text) Then
            txtdonorid.Text = GenerateRejectedDonorID()
        End If
        save()



        DGV_load()

    End Sub

    Private Function GenerateRejectedDonorID() As String
        Dim newID As String = "A"
        Dim lastID As String = ""

        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT DonorID FROM `add_new_donor` ORDER BY DonorID DESC LIMIT 1", conn)
            dr = cmd.ExecuteReader()
            If dr.Read() Then
                lastID = dr("DonorID").ToString()
            End If
            dr.Close()

            If String.IsNullOrEmpty(lastID) Then
                newID &= "00001"
            Else
                Dim numericPart As Integer = Integer.Parse(lastID.Substring(1))
                newID &= (numericPart + 1).ToString("D5")
            End If
        Catch ex As Exception
            MessageBox.Show("Error generating Donor ID: " & ex.Message)
        Finally
            conn.Close()
        End Try

        Return newID
    End Function
    Public Sub save()
        Try
            conn.Open()

            ' Strip units from age and weight
            Dim ageValue As String = txtage.Text.Replace(" Years", "").Trim()
            Dim weightValue As String = txtweight.Text.Replace(" Kg", "").Trim()


            Dim cmd As New MySqlCommand("INSERT INTO `add_new_donor` (`DonorID`,`NIC`, `Name`, `Mobile`, `DateofBirth`, `Gender`, `Date`,`BloodQty`, `BloodGroup`, `Donation_status`, `Age`, `Weight`, `Healthcondition`, `AdminName`,`DoctorName`,`Certificate_issue`) VALUES (@DonorID, @NIC, @Name, @Mobile, @DateofBirth, @Gender, @Date, @BloodQty, @BloodGroup, @Donation_status, @Age, @Weight, @Healthcondition, @AdminName,@DoctorName,@Certificate_issue)", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@DonorID", txtdonorid.Text)
            cmd.Parameters.AddWithValue("@NIC", txtnic.Text)
            cmd.Parameters.AddWithValue("@Name", txtname.Text)
            cmd.Parameters.AddWithValue("@Mobile", txtmobile.Text)
            cmd.Parameters.AddWithValue("@DateofBirth", txtdateofbirth.Text)
            cmd.Parameters.AddWithValue("@Gender", ComboBox1_gender.Text)
            cmd.Parameters.AddWithValue("@Date", DateTime.Now)
            cmd.Parameters.AddWithValue("@BloodQty", txtbloodqty.Text)
            cmd.Parameters.AddWithValue("@BloodGroup", ComboBox2_bloodgroup.Text)
            cmd.Parameters.AddWithValue("@Donation_status", txtstatus.Text)
            cmd.Parameters.AddWithValue("@Age", ageValue)
            cmd.Parameters.AddWithValue("@Weight", weightValue)
            cmd.Parameters.AddWithValue("@Healthcondition", txtmedical.Text)
            cmd.Parameters.AddWithValue("@AdminName", txtadmin.Text)
            cmd.Parameters.AddWithValue("@DoctorName", txtdoctor.Text)
            cmd.Parameters.AddWithValue("@Certificate_issue", txtcertificate.Text)


            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MessageBox.Show("Record Save Success !", "bloodbank", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Else
                MessageBox.Show("Record Save Falied !", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try


    End Sub
    Public Sub DGV_load()
        DataGridView1.Rows.Clear()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM add_new_donor", conn)
            dr = cmd.ExecuteReader()
            While dr.Read()
                DataGridView1.Rows.Add(dr.Item("NewDonorID"), dr.Item("DonorID"), dr.Item("NIC"), dr.Item("Name"), dr.Item("Mobile"), dr.Item("DateofBirth"), dr.Item("Gender"), dr.Item("Date"), dr.Item("BloodQty"), dr.Item("BloodGroup"), dr.Item("Donation_status"), dr.Item("Age"), dr.Item("Weight"), dr.Item("Healthcondition"), dr.Item("AdminName"), dr.Item("DoctorName"), dr.Item("Certificate_issue"))
            End While
            dr.Dispose()

        Catch ex As Exception
            MsgBox("An error occurred: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        edit()
    End Sub

    Public Sub edit()
        Try
            conn.Open()

            ' Strip units from age and weight
            Dim ageValue As String = txtage.Text.Replace(" Years", "").Trim()
            Dim weightValue As String = txtweight.Text.Replace(" Kg", "").Trim()

            Dim cmd As New MySqlCommand("UPDATE `add_new_donor` SET `NIC`=@NIC,`Name`=@Name,`Mobile`=@Mobile,`DateofBirth`=@DateofBirth,`Gender`=@Gender,`Date`=@Date,`BloodQty`=@BloodQty,`BloodGroup`=@BloodGroup,`Donation_status`=@Donation_status,`Age`=@Age,`Weight`=@Weight,`Healthcondition`=@Healthcondition,`AdminName`=@AdminName,`DoctorName`=@DoctorName,`Certificate_issue`=@Certificate_issue WHERE `DonorID`=@DonorID", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@DonorID", txtdonorid.Text)
            cmd.Parameters.AddWithValue("@NIC", txtnic.Text)
            cmd.Parameters.AddWithValue("@Name", txtname.Text)
            cmd.Parameters.AddWithValue("@Mobile", txtmobile.Text)
            cmd.Parameters.AddWithValue("@DateofBirth", txtdateofbirth.Text)
            cmd.Parameters.AddWithValue("@Gender", ComboBox1_gender.Text)
            cmd.Parameters.AddWithValue("@Date", DateTime.Now)
            cmd.Parameters.AddWithValue("@BloodQty", txtbloodqty.Text)
            cmd.Parameters.AddWithValue("@BloodGroup", ComboBox2_bloodgroup.Text)
            cmd.Parameters.AddWithValue("@Donation_status", txtstatus.Text)
            cmd.Parameters.AddWithValue("@Age", ageValue)
            cmd.Parameters.AddWithValue("@Weight", weightValue)
            cmd.Parameters.AddWithValue("@Healthcondition", txtmedical.Text)
            cmd.Parameters.AddWithValue("@AdminName", txtadmin.Text)
            cmd.Parameters.AddWithValue("@DoctorName", txtdoctor.Text)
            cmd.Parameters.AddWithValue("@Certificate_issue", txtcertificate.Text)
            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MessageBox.Show("Record Update Success !", "bloodbank", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Record Update Failed !", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try

        DGV_load()

    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        Delete()
    End Sub
    Public Sub Delete()
        If MsgBox("Are you sure Delete this record", MsgBoxStyle.Question + vbYesNo) = vbYes Then
            Try
                conn.Open()
                Dim cmd As New MySqlCommand("DELETE from `add_new_donor` WHERE `DonorID`=@DonorID", conn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@DonorID", txtdonorid.Text)

                i = cmd.ExecuteNonQuery
                If i > 0 Then
                    MessageBox.Show("Record Delete Success !", "bloodbank", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Record Update Failed !", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                conn.Close()
            End Try

            DGV_load()
        Else
            Return
        End If
    End Sub
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        txtdonorid.Text = DataGridView1.CurrentRow.Cells(1).Value
        txtnic.Text = DataGridView1.CurrentRow.Cells(2).Value
        txtname.Text = DataGridView1.CurrentRow.Cells(3).Value
        txtmobile.Text = DataGridView1.CurrentRow.Cells(4).Value
        txtdateofbirth.Text = DataGridView1.CurrentRow.Cells(5).Value
        ComboBox1_gender.Text = DataGridView1.CurrentRow.Cells(6).Value
        DateTimePicker2_date.Text = DataGridView1.CurrentRow.Cells(7).Value
        txtbloodqty.Text = DataGridView1.CurrentRow.Cells(8).Value
        ComboBox2_bloodgroup.Text = DataGridView1.CurrentRow.Cells(9).Value
        txtstatus.Text = DataGridView1.CurrentRow.Cells(10).Value
        txtage.Text = DataGridView1.CurrentRow.Cells(11).Value
        txtweight.Text = DataGridView1.CurrentRow.Cells(12).Value
        txtmedical.Text = DataGridView1.CurrentRow.Cells(13).Value
        txtadmin.Text = DataGridView1.CurrentRow.Cells(14).Value
        txtdoctor.Text = DataGridView1.CurrentRow.Cells(15).Value
        txtcertificate.Text = DataGridView1.CurrentRow.Cells(16).Value


        btnsave.Enabled = False


    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        txtnic.Text = ""
        txtname.Clear()
        txtmobile.Clear()
        txtdateofbirth.Text = ""
        ComboBox1_gender.Text = ""
        DateTimePicker2_date.Text = Now
        txtbloodqty.Text = ""
        ComboBox2_bloodgroup.Text = ""
        txtstatus.Text = ""
        txtage.Clear()
        txtweight.Clear()
        txtmedical.Clear()
        txtadmin.Text = ""
        txtdoctor.Text = ""
        txtcertificate.Text = ""
        txtdonorid.Clear()

        ComboBox1_gender.SelectedIndex = -1 ' Clear gender field
        ComboBox2_bloodgroup.SelectedIndex = -1 ' Clear blood group field
    End Sub

    Private Sub txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged
        DataGridView1.Rows.Clear()
        Try
            conn.Open()

            ' Refine the query to specifically check for an exact NIC match and partial Name match
            Dim cmd As New MySqlCommand("SELECT * FROM add_new_donor WHERE DonorID like'%" & txtsearch.Text & "%' OR NIC like'%" & txtsearch.Text & "%'OR Name like'%" & txtsearch.Text & "%'", conn)


            dr = cmd.ExecuteReader

            While dr.Read
                DataGridView1.Rows.Add(dr.Item("NewDonorID"), dr.Item("DonorID"), dr.Item("NIC"), dr.Item("Name"), dr.Item("Mobile"), dr.Item("DateofBirth"), dr.Item("Gender"), dr.Item("Date"), dr.Item("BloodQty"), dr.Item("BloodGroup"), dr.Item("Donation_status"), dr.Item("Age"), dr.Item("Weight"), dr.Item("Healthcondition"), dr.Item("AdminName"), dr.Item("DoctorName"), dr.Item("Certificate_issue"))
            End While
            dr.Dispose()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub txtname_leave(sender As Object, e As EventArgs) Handles txtname.Leave
        Dim name As String = txtname.Text.Trim()

        If name = "" Then
            MessageBox.Show("Enter Name.", "REQUIRED", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtname.Focus()
            Exit Sub
        End If

        ' to allow only letters, spaces, and dots in the middle of the name

        Dim pattern As String = "^[A-Za-z]+(?:[ .][A-Za-z]+)*$"

        ' Check if the name matches the pattern

        If Not System.Text.RegularExpressions.Regex.IsMatch(name, pattern) Then
            MessageBox.Show("Enter a valid name.", "Invalid Name", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtname.Focus()
            Exit Sub
        End If
    End Sub

    Private Sub txtmobile_leave(sender As Object, e As EventArgs) Handles txtmobile.Leave
        Dim mobile As String = txtmobile.Text.Trim()

        If mobile = "" Then
            MessageBox.Show("Enter Mobile Number.", "REQUIRED", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtmobile.Focus()
            Exit Sub
        End If

        ' Regular expression pattern to allow only 10 digits

        Dim pattern As String = "^\d{10}$"

        ' Check if the mobile number matches the pattern

        If Not System.Text.RegularExpressions.Regex.IsMatch(mobile, pattern) Then
            MessageBox.Show("Enter a valid 10-digit mobile number.", "Invalid Mobile Number", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtmobile.Focus()
            Exit Sub
        End If
    End Sub

    Private Sub ComboBox1_gender_leave(sender As Object, e As EventArgs) Handles ComboBox1_gender.Leave
        Dim gender As String = ComboBox1_gender.Text.Trim()

        If gender = "" Then
            MessageBox.Show("Select Gender.", "REQUIRED", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ComboBox1_gender.Focus()
            Exit Sub
        End If


    End Sub

    Private Sub DateTimePicker2_date_leave(sender As Object, e As EventArgs) Handles DateTimePicker2_date.Leave
        Dim inputDateString As String = DateTimePicker2_date.Text.Trim()

        If inputDateString = "" Then
            MessageBox.Show("Enter Date.", "REQUIRED", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            DateTimePicker2_date.Focus()
            Exit Sub
        End If

    End Sub

    Private Sub ComboBox2_bloodgroup_leave(sender As Object, e As EventArgs) Handles ComboBox2_bloodgroup.Leave
        Dim bloodgroup As String = ComboBox2_bloodgroup.Text.Trim()

        If bloodgroup = "" Then
            MessageBox.Show("Select Blood Group.", "REQUIRED", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ComboBox2_bloodgroup.Focus()
            Exit Sub
        End If
    End Sub


    Private Sub txtnic_Leave(sender As Object, e As EventArgs) Handles txtnic.Leave
        Dim nic As String = txtnic.Text.Trim()

        If nic = "" Then
            MessageBox.Show("Enter NIC.", "REQUIRED", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtnic.Focus()
            Exit Sub
        End If

        ' Validate NIC format
        If Not IsValidNIC(nic) Then
            MessageBox.Show("Invalid NIC format. Please enter a valid NIC.", "Invalid NIC", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtnic.Focus()
            Exit Sub
        End If

        ' Extract date of birth from NIC
        Dim dateOfBirth As DateTime
        If nic.Length = 10 Then ' Old NIC format (e.g., 123456789V)
            Dim year As String = "19" & nic.Substring(0, 2)
            Dim dayOfYear As Integer = Integer.Parse(nic.Substring(2, 3))
            dateOfBirth = CalculateDateOfBirth(dayOfYear, Integer.Parse(year))
        ElseIf nic.Length = 12 Then ' New NIC format (e.g., 200012345678)
            Dim year As String = nic.Substring(0, 4)
            Dim dayOfYear As Integer = Integer.Parse(nic.Substring(4, 3))
            dateOfBirth = CalculateDateOfBirth(dayOfYear, Integer.Parse(year))
        Else
            MessageBox.Show("Invalid NIC length.", "Invalid NIC", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtnic.Focus()
            Exit Sub
        End If

        txtdateofbirth.Text = dateOfBirth.ToString("dd/MM/yyyy")
    End Sub

    Private Function CalculateDateOfBirth(dayOfYear As Integer, year As Integer) As DateTime
        Dim isFemale As Boolean = False
        If dayOfYear > 500 Then
            dayOfYear -= 500
            isFemale = True
        End If
        Dim dateOfBirth As DateTime = New DateTime(year, 1, 1).AddDays(dayOfYear - 2)
        Return dateOfBirth

    End Function

    Private Function IsValidNIC(nic As String) As Boolean
        ' Old NIC format: 9 digits followed by 'V' or 'v'
        Dim oldNicPattern As String = "^\d{9}[Vv]$"

        ' New NIC format: 12 digits
        Dim newNicPattern As String = "^\d{12}$"

        If Regex.IsMatch(nic, oldNicPattern) OrElse Regex.IsMatch(nic, newNicPattern) Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub txtage_Leave(sender As Object, e As EventArgs) Handles txtage.Leave
        Dim ageText As String = txtage.Text.Trim()

        ' Check if the Age field is empty
        If ageText = "" Then
            MessageBox.Show("Enter Age.", "REQUIRED", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtage.Focus()
            Exit Sub
        End If

        ' Extract the numeric part from the ageText
        Dim numericPart As String = New String(ageText.Where(Function(c) Char.IsDigit(c)).ToArray())
        Dim age As Integer

        ' Convert the numeric part to an integer
        If Integer.TryParse(numericPart, age) Then
            ' Check if the age is within the acceptable range (e.g., 18 to 60)
            If age < 18 Or age > 60 Then
                MessageBox.Show("Enter a valid Age between 18 and 60 years.", "Invalid Age", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtage.Focus()
                Exit Sub
            End If
        Else
            ' If the conversion to integer fails, show an error message
            MessageBox.Show("Enter a valid Age.", "Invalid Age", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtage.Focus()
            Exit Sub
        End If

        ' Append "years" to the age if not already appended
        txtage.Text = age.ToString() & " years"
    End Sub

    Private Sub txtweight_Leave(sender As Object, e As EventArgs) Handles txtweight.Leave

        Dim weight As String = txtweight.Text.Trim()

        If String.IsNullOrEmpty(weight) Then
            MessageBox.Show("Enter Weight.", "REQUIRED", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtweight.Focus()
            Exit Sub
        End If

        ' Regular expression pattern to allow only digits and a dot for decimal values
        Dim pattern As String = "^\d+(\.\d+)?$"

        ' Check if the weight matches the pattern
        If Not Regex.IsMatch(weight, pattern) Then
            MessageBox.Show("Enter a valid weight. Only numeric values are allowed.", "Invalid Weight", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtweight.Focus()
            txtweight.SelectAll() ' Select all text for user convenience
            Exit Sub
        End If

        ' Convert the weight to a numeric value for further validation
        Dim numericWeight As Double
        If Double.TryParse(weight, numericWeight) Then
            ' Check if the weight is above 50
            If numericWeight <= 50 Then
                MessageBox.Show("Weight must be above 50.", "Invalid Weight", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtweight.Focus()
                txtweight.SelectAll() ' Select all text for user convenience
                Exit Sub
            End If
        Else
            MessageBox.Show("Enter a valid weight. Only numeric values are allowed.", "Invalid Weight", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtweight.Focus()
            txtweight.SelectAll() ' Select all text for user convenience
            Exit Sub
        End If

        ' Append "kg" after the weight value
        txtweight.Text = weight & " kg"


    End Sub



    Private Sub txtmedical_Leave(sender As Object, e As EventArgs) Handles txtmedical.Leave
        Dim healthCondition As String = txtmedical.Text.Trim()

        If String.IsNullOrEmpty(healthCondition) Then
            MessageBox.Show("Enter Health Condition.", "REQUIRED", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtmedical.Focus()
            Exit Sub
        End If

        ' Regular expression pattern to allow only alphabetic characters and spaces
        Dim pattern As String = "^[a-zA-Z\s]+$"

        ' Check if the health condition matches the pattern
        If Not Regex.IsMatch(healthCondition, pattern) Then
            MessageBox.Show("Enter a valid health condition. Only alphabetic characters and spaces are allowed.", "Invalid Health Condition", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtmedical.Focus()
            txtmedical.SelectAll() ' Select all text for user convenience
            Exit Sub
        End If
    End Sub



    Private Sub txtdoctor_Leave(sender As Object, e As EventArgs) Handles txtdoctor.Leave
        Dim doctorName As String = txtdoctor.Text.Trim()

        If String.IsNullOrEmpty(doctorName) Then
            MessageBox.Show("Enter Doctor's Name.", "REQUIRED", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtdoctor.Focus()
            Exit Sub
        End If

        ' Regular expression pattern to allow only letters, spaces, and dots
        Dim pattern As String = "^[A-Za-z]+(?:[.'\s][A-Za-z]+)*$"

        ' Check if the Doctor's Name matches the pattern
        If Not Regex.IsMatch(doctorName, pattern) Then
            MessageBox.Show("Enter a valid Doctor's Name. Only letters, spaces, and dots are allowed.", "Invalid Doctor's Name", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtdoctor.Focus()
            Exit Sub
        End If
    End Sub

    Private Sub txtcertificate_Leave(sender As Object, e As EventArgs) Handles txtcertificate.Leave
        Dim certificateIssue As String = txtcertificate.Text.Trim().ToLower()

        If String.IsNullOrEmpty(certificateIssue) Then
            MessageBox.Show("Enter Certificate Issue status.", "REQUIRED", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtcertificate.Focus()
            Exit Sub
        End If

        If certificateIssue <> "yes" AndAlso certificateIssue <> "no" Then
            MessageBox.Show("Enter a valid Certificate Issue status (Yes or No).", "Invalid Certificate Issue", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtcertificate.Focus()
            Exit Sub
        End If
    End Sub

    Private Sub txtbloodqty_Leave(sender As Object, e As EventArgs) Handles txtbloodqty.Leave

        Dim volume As String = txtbloodqty.Text.Trim()

        If String.IsNullOrEmpty(volume) Then
            MessageBox.Show("Enter Blood Quantity.", "REQUIRED", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtbloodqty.Focus()
            Exit Sub
        End If

        ' Check if the input is a valid number
        Dim quantity As Integer
        If Not Integer.TryParse(volume, quantity) OrElse quantity <= 0 Then
            MessageBox.Show("Enter a valid positive number for Blood Quantity.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtbloodqty.Focus()
            txtbloodqty.SelectAll() ' Select all text for user convenience
            Exit Sub
        End If

        ' Append "ml" after the text in the textbox
        txtbloodqty.Text = volume & " ml"
    End Sub


    Private Sub btnshowprint_Click(sender As Object, e As EventArgs) Handles btnshowprint.Click


        ' Get the name entered in the new donor form
        Dim donorName As String = txtname.Text

        ' Get the date entered in the new donor form
        Dim donationDate As Date = DateTimePicker2_date.Value

        ' Create an instance of the CertificateGenerator form
        Dim certForm As New Certificate_generator()

        ' Set the donor name and donation date properties
        certForm.DonorName = donorName
        certForm.DonationDate = donationDate

        ' Optionally, set the label text directly
        certForm.SetDonorName(donorName)
        certForm.SetDonationDate(donationDate)

        ' Show the CertificateGenerator form
        certForm.Show()

    End Sub

    Private Sub btnbloodstock_Click(sender As Object, e As EventArgs) Handles btnbloodstock.Click
        ' Retrieve data from the form's controls
        Dim nic As String = txtnic.Text
        Dim name As String = txtname.Text
        Dim bloodType As String = ComboBox2_bloodgroup.SelectedItem.ToString()
        Dim donorId As String = txtdonorid.Text
        Dim quantity As String = txtbloodqty.Text
        Dim age As String = txtage.Text
        Dim gender As String = ComboBox1_gender.SelectedItem.ToString()

        ' Create an instance of BloodStockForm
        Dim bloodStockForm As New Blood_stock()

        ' Set the data properties
        bloodStockForm.DonorNIC = nic
        bloodStockForm.DonorName = name
        bloodStockForm.DonorBloodType = bloodType
        bloodStockForm.DonorId = donorId
        bloodStockForm.BloodQuantity = quantity
        bloodStockForm.DonorAge = age
        bloodStockForm.DonorGender = gender


        ' Resize the BloodStockForm
        bloodStockForm.Size = New Size(1000, 500) ' Set the desired size her

        ' Show BloodStockForm
        Me.Hide()
        bloodStockForm.Show()
    End Sub


End Class