Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Tls.Crypto

Public Class Doctor_Registration
    Dim conn As New MySqlConnection("server=localhost;port=3306;username=root;password=;database=bloodbank")
    Dim dr As MySqlDataReader
    Dim i As Integer
    Private Sub Doctor_Registration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGV_load()
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click

        If String.IsNullOrEmpty(txtnic.Text) OrElse
           String.IsNullOrEmpty(txtname.Text) OrElse
           String.IsNullOrEmpty(txtpastex.Text) OrElse
           String.IsNullOrEmpty(txtmobile.Text) OrElse
           String.IsNullOrEmpty(txtemail.Text) OrElse
            String.IsNullOrEmpty(txtduty.Text) OrElse
           String.IsNullOrEmpty(txtadmin.Text) Then


            MessageBox.Show("All the required fields must be filled.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        save()
        DGV_load()

    End Sub

    Public Sub save()
        Try
            conn.Open()


            Dim cmd As New MySqlCommand("INSERT INTO `medicalofficers_registration` (`NIC`, `Name`, `Past_experience`, `Mobile`, `Email`, `AdminName`, `Date`, `Duty`) VALUES (@NIC, @Name, @Past_experience, @Mobile, @Email, @AdminName, @Date, @Duty)", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@NIC", txtnic.Text)
            cmd.Parameters.AddWithValue("@Name", txtname.Text)
            cmd.Parameters.AddWithValue("@Past_experience", txtname.Text)
            cmd.Parameters.AddWithValue("@Mobile", txtmobile.Text)
            cmd.Parameters.AddWithValue("@Email", txtmobile.Text)
            cmd.Parameters.AddWithValue("@AdminName", txtadmin.Text)
            cmd.Parameters.AddWithValue("@Date", DateTime.Now.ToString("yyyy-MM-dd"))
            cmd.Parameters.AddWithValue("@Duty", txtduty.Text)

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
            Dim cmd As New MySqlCommand("SELECT * FROM medicalofficers_registration", conn)
            dr = cmd.ExecuteReader()
            While dr.Read()
                DataGridView1.Rows.Add(dr.Item("ID"), dr.Item("NIC"), dr.Item("Name"), dr.Item("Past_experience"), dr.Item("Mobile"), dr.Item("Email"), dr.Item("AdminName"), dr.Item("Date"), dr.Item("Duty"))
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
            Dim cmd As New MySqlCommand("UPDATE `medicalofficers_registration` SET `Name`=@Name,`Past_experience`=@Past_experience,`Mobile`=@Mobile,`Email`=@Email,`AdminName`=@AdminName,`Date`=@Date,`Duty`=@Duty WHERE `NIC`=@NIC", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@NIC", txtnic.Text)
            cmd.Parameters.AddWithValue("@Name", txtname.Text)
            cmd.Parameters.AddWithValue("@Past_experience", txtname.Text)
            cmd.Parameters.AddWithValue("@Mobile", txtmobile.Text)
            cmd.Parameters.AddWithValue("@Email", txtmobile.Text)
            cmd.Parameters.AddWithValue("@AdminName", txtadmin.Text)
            cmd.Parameters.AddWithValue("@Date", CDate(DateTimePicker2_date.Text))
            cmd.Parameters.AddWithValue("@Duty", txtduty.Text)
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
                Dim cmd As New MySqlCommand("DELETE from `medicalofficers_registration` WHERE `NIC`=@NIC", conn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@NIC", txtnic.Text)

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
        txtnic.Text = DataGridView1.CurrentRow.Cells(1).Value
        txtname.Text = DataGridView1.CurrentRow.Cells(2).Value
        txtpastex.Text = DataGridView1.CurrentRow.Cells(3).Value
        txtmobile.Text = DataGridView1.CurrentRow.Cells(4).Value
        txtemail.Text = DataGridView1.CurrentRow.Cells(5).Value
        txtadmin.Text = DataGridView1.CurrentRow.Cells(6).Value
        DateTimePicker2_date.Text = DataGridView1.CurrentRow.Cells(7).Value
        txtduty.Text = DataGridView1.CurrentRow.Cells(8).Value
        btnsave.Enabled = False

    End Sub

    Private Sub clear()
        txtnic.Text = ""
        txtname.Clear()
        txtpastex.Clear()
        txtmobile.Clear()
        txtduty.Clear()
        txtemail.Text = ""
        txtadmin.Text = ""
        DateTimePicker2_date.Text = Now
    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        clear()
    End Sub

    Private Sub txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged
        DataGridView1.Rows.Clear()
        Try
            conn.Open()

            ' Refine the query to specifically check for an exact NIC match and partial Name match
            Dim cmd As New MySqlCommand("SELECT * FROM medicalofficers_registration WHERE NIC like'%" & txtsearch.Text & "%' OR Name like '%" & txtsearch.Text & "%'", conn)

            dr = cmd.ExecuteReader
            While dr.Read
                DataGridView1.Rows.Add(dr.Item("ID"), dr.Item("NIC"), dr.Item("Name"), dr.Item("Past_experience"), dr.Item("Mobile"), dr.Item("Email"), dr.Item("AdminName"), dr.Item("Date"), dr.Item("Duty"))
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

        Dim pattern As String = "^[A-Za-z]+(?: [.'\s][A-Za-z]+)*$"

        ' Check if the name matches the pattern

        If Not System.Text.RegularExpressions.Regex.IsMatch(name, pattern) Then
            MessageBox.Show("Enter a valid name.", "Invalid Name", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtname.Focus()
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
    End Sub
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

    Private Sub txtemail_Leave(sender As Object, e As EventArgs) Handles txtemail.Leave
        Dim email As String = txtemail.Text.Trim()
        If email = "" Then
            MessageBox.Show("Enter Email Address.", "REQUIRED", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtemail.Focus()
            Exit Sub
        End If

        ' Regular expression pattern for valid email
        Dim emailPattern As String = "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"
        If Not System.Text.RegularExpressions.Regex.IsMatch(email, emailPattern) Then
            MessageBox.Show("Enter a valid email address.", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtemail.Focus()
            Exit Sub
        End If
    End Sub

    Private Sub txtpastex_Leave(sender As Object, e As EventArgs) Handles txtpastex.Leave
        Dim pastExperience As String = txtpastex.Text.Trim()
        If pastExperience = "" Then
            MessageBox.Show("Enter Past Experience.", "REQUIRED", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtpastex.Focus()
            Exit Sub
        End If

        ' Regular expression pattern to allow numbers, spaces, capital and lowercase letters, and commas
        Dim pastExperiencePattern As String = "^[a-zA-Z0-9\s,]+$"
        If Not System.Text.RegularExpressions.Regex.IsMatch(pastExperience, pastExperiencePattern) Then
            MessageBox.Show("Past Experience can only contain letters, numbers, spaces, and commas.", "Invalid Past Experience", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtpastex.Focus()
            Exit Sub
        End If

    End Sub

    Private Sub txtduty_Leave(sender As Object, e As EventArgs) Handles txtduty.Leave
        Dim dutyMedicalOfficerds As String = txtduty.Text.Trim()
        If dutyMedicalOfficerds = "" Then
            MessageBox.Show("Enter Duty of the Medical Officer.", "REQUIRED", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtduty.Focus()
            Exit Sub
        End If

        ' Regular expression pattern to allow numbers, spaces, capital and lowercase letters, and commas
        Dim dutyMedicalOfficerdsPattern As String = "^[a-zA-Z0-9\s,]+$"
        If Not System.Text.RegularExpressions.Regex.IsMatch(dutyMedicalOfficerds, dutyMedicalOfficerdsPattern) Then
            MessageBox.Show("Duty of the Medical Officer can only contain letters, numbers, spaces, and commas.", "Invalid Duty Description", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtduty.Focus()
            Exit Sub
        End If
    End Sub


End Class