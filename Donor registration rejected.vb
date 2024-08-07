Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Tls.Crypto

Public Class Donor_registration_rejected
    Dim conn As New MySqlConnection("server=localhost;port=3306;username=root;password=;database=bloodbank")
    Dim dr As MySqlDataReader
    Dim i As Integer

    Private Sub Donor_registration_rejected_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGV_load()
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click

        If String.IsNullOrEmpty(txtnic.Text) OrElse
           String.IsNullOrEmpty(txtname.Text) OrElse
           String.IsNullOrEmpty(txtmobile.Text) OrElse
           String.IsNullOrEmpty(ComboBox1_gender.Text) OrElse
           String.IsNullOrEmpty(ComboBox2_bloodgroup.Text) OrElse
           String.IsNullOrEmpty(txtstatus.Text) OrElse
           String.IsNullOrEmpty(txtmedical.Text) OrElse
           String.IsNullOrEmpty(txtdoctor.Text) Then

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
        Dim newID As String = "R"
        Dim lastID As String = ""

        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT Rejecteddonor_ID FROM donor_register_rejected ORDER BY Rejecteddonor_ID DESC LIMIT 1", conn)
            dr = cmd.ExecuteReader()
            If dr.Read() Then
                lastID = dr("Rejecteddonor_ID").ToString()
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

            Dim cmd As New MySqlCommand("INSERT INTO `donor_register_rejected`(`Rejecteddonor_ID`, `NIC`, `Name`, `Mobile`, `DateofBirth`, `Gender`, `Date`, `BloodGroup`, `Donation_status`, `Healthcondition`, `AdminName`, `DoctorName`) VALUES (@Rejecteddonor_ID,@NIC,@Name,@Mobile,@DateofBirth,@Gender,@Date,@BloodGroup,@Donation_status,@Healthcondition,@AdminName,@DoctorName)", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@Rejecteddonor_ID", txtdonorid.Text)
            cmd.Parameters.AddWithValue("@NIC", txtnic.Text)
            cmd.Parameters.AddWithValue("@Name", txtname.Text)
            cmd.Parameters.AddWithValue("@Mobile", txtmobile.Text)
            cmd.Parameters.AddWithValue("@DateofBirth", txtdateofbirth.Text)
            cmd.Parameters.AddWithValue("@Gender", ComboBox1_gender.Text)
            cmd.Parameters.AddWithValue("@Date", DateTime.Now)
            cmd.Parameters.AddWithValue("@BloodGroup", ComboBox2_bloodgroup.Text)
            cmd.Parameters.AddWithValue("@Donation_status", txtstatus.Text)
            cmd.Parameters.AddWithValue("@Healthcondition", txtmedical.Text)
            cmd.Parameters.AddWithValue("@AdminName", txtadmin.Text)
            cmd.Parameters.AddWithValue("@DoctorName", txtdoctor.Text)

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
        clear()
    End Sub
    Public Sub DGV_load()
        DataGridView1.Rows.Clear()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM donor_register_rejected", conn)
            dr = cmd.ExecuteReader()
            While dr.Read()
                DataGridView1.Rows.Add(dr.Item("Amountof_rejectdonors"), dr.Item("Rejecteddonor_ID"), dr.Item("NIC"), dr.Item("Name"), dr.Item("Mobile"), dr.Item("DateofBirth"), dr.Item("Gender"), dr.Item("Date"), dr.Item("BloodGroup"), dr.Item("Donation_status"), dr.Item("Healthcondition"), dr.Item("AdminName"), dr.Item("DoctorName"))
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
            Dim cmd As New MySqlCommand("UPDATE `donor_register_rejected` SET `NIC`=@NIC, `Name`=@Name, `Mobile`=@Mobile, `DateofBirth`=@DateofBirth, `Gender`=@Gender, `Date`=@Date, `BloodGroup`=@BloodGroup, `Donation_status`=@Donation_status, `Healthcondition`=@Healthcondition, `AdminName`=@AdminName, `DoctorName`=@DoctorName WHERE `Rejecteddonor_ID`=@Rejecteddonor_ID", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@Rejecteddonor_ID", txtdonorid.Text)
            cmd.Parameters.AddWithValue("@NIC", txtnic.Text)
            cmd.Parameters.AddWithValue("@Name", txtname.Text)
            cmd.Parameters.AddWithValue("@Mobile", txtmobile.Text)
            cmd.Parameters.AddWithValue("@DateofBirth", txtdateofbirth.Text)
            cmd.Parameters.AddWithValue("@Gender", ComboBox1_gender.Text)
            cmd.Parameters.AddWithValue("@Date", DateTime.Now)
            cmd.Parameters.AddWithValue("@BloodGroup", ComboBox2_bloodgroup.Text)
            cmd.Parameters.AddWithValue("@Donation_status", txtstatus.Text)
            cmd.Parameters.AddWithValue("@Healthcondition", txtmedical.Text)
            cmd.Parameters.AddWithValue("@AdminName", txtadmin.Text)
            cmd.Parameters.AddWithValue("@DoctorName", txtdoctor.Text)

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
                Dim cmd As New MySqlCommand("DELETE from `donor_register_rejected` WHERE `Rejecteddonor_ID`=@Rejecteddonor_ID", conn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@Rejecteddonor_ID", txtdonorid.Text)

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
        ComboBox2_bloodgroup.Text = DataGridView1.CurrentRow.Cells(8).Value
        txtstatus.Text = DataGridView1.CurrentRow.Cells(9).Value
        txtmedical.Text = DataGridView1.CurrentRow.Cells(10).Value
        txtadmin.Text = DataGridView1.CurrentRow.Cells(11).Value
        txtdoctor.Text = DataGridView1.CurrentRow.Cells(12).Value

        btnsave.Enabled = False

    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        clear()
    End Sub
    Private Sub clear()
        txtnic.Text = ""
        txtname.Clear()
        txtmobile.Clear()
        txtdateofbirth.Text = ""
        ComboBox1_gender.Text = ""
        DateTimePicker2_date.Text = Now
        ComboBox2_bloodgroup.Text = ""
        txtstatus.Text = ""
        txtmedical.Clear()
        txtadmin.Text = ""
        txtdoctor.Text = ""
        txtdonorid.Text = ""

        ComboBox1_gender.SelectedIndex = -1 ' Clear gender field
        ComboBox2_bloodgroup.SelectedIndex = -1 ' Clear blood group field

    End Sub

    Private Sub txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged
        DataGridView1.Rows.Clear()
        Try
            conn.Open()

            ' Refine the query to specifically check for an exact NIC match and partial Name match
            Dim cmd As New MySqlCommand("SELECT * FROM donor_register_rejected WHERE Rejecteddonor_ID like'%" & txtsearch.Text & "%' OR NIC like'%" & txtsearch.Text & "%' OR Name like '%" & txtsearch.Text & "%'", conn)

            dr = cmd.ExecuteReader

            While dr.Read
                DataGridView1.Rows.Add(dr.Item("Amountof_rejectdonors"), dr.Item("Rejecteddonor_ID"), dr.Item("NIC"), dr.Item("Name"), dr.Item("Mobile"), dr.Item("DateofBirth"), dr.Item("Gender"), dr.Item("Date"), dr.Item("BloodGroup"), dr.Item("Donation_status"), dr.Item("Healthcondition"), dr.Item("AdminName"), dr.Item("DoctorName"))
            End While
            dr.Dispose()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
    Private Sub txtname_Leave(sender As Object, e As EventArgs) Handles txtname.Leave
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

    Private Sub txtmobile_Leave(sender As Object, e As EventArgs) Handles txtmobile.Leave
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

    Private Sub ComboBox1_gender_Leave(sender As Object, e As EventArgs) Handles ComboBox1_gender.Leave
        Dim gender As String = ComboBox1_gender.Text.Trim()

        If gender = "" Then
            MessageBox.Show("Select Gender.", "REQUIRED", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ComboBox1_gender.Focus()
            Exit Sub
        End If
    End Sub

    Private Sub DateTimePicker2_date_Leave(sender As Object, e As EventArgs) Handles DateTimePicker2_date.Leave
        Dim inputDateString As String = DateTimePicker2_date.Text.Trim()

        If inputDateString = "" Then
            MessageBox.Show("Enter Date.", "REQUIRED", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            DateTimePicker2_date.Focus()
            Exit Sub
        End If
    End Sub

    Private Sub ComboBox2_bloodgroup_Leave(sender As Object, e As EventArgs) Handles ComboBox2_bloodgroup.Leave
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

    Private Sub txtmedical_Leave(sender As Object, e As EventArgs) Handles txtmedical.Leave
        Dim medical As String = txtmedical.Text.Trim()

        If String.IsNullOrEmpty(medical) Then
            MessageBox.Show("Enter Health Condition.", "REQUIRED", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtmedical.Focus()
            Exit Sub
        End If

        ' Regular expression pattern to disallow digits and non-alphabetic characters
        Dim pattern As String = "^[a-zA-Z\s]+$"
        If Not Regex.IsMatch(medical, pattern) Then
            MessageBox.Show("Please enter a valid health condition without numbers or special characters.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
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


End Class