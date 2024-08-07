

Imports System.Text.RegularExpressions
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports MySql.Data.MySqlClient

Public Class Register_form
    Dim conn As New MySqlConnection("server=localhost;port=3306;username=root;database=bloodbank")

    Private Sub Label1_register_Click(sender As Object, e As EventArgs) Handles lblexit.Click
        Application.Exit()
    End Sub



    Private Sub Register_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1_register.BackColor = Color.FromArgb(30, 0, 0, 0)


        lblfirstname.BackColor = Color.Transparent
        lbllastname.BackColor = Color.Transparent
        lblusername.BackColor = Color.Transparent
        lblpass.BackColor = Color.Transparent
        lblconfirmpass.BackColor = Color.Transparent
        lblregiuser.BackColor = Color.Transparent
        lbllogin.BackColor = Color.Transparent
        lblwelcome2.BackColor = Color.Transparent
        lblemail.BackColor = Color.Transparent


        lblemail.ForeColor = Color.Black
        lblwelcome2.ForeColor = Color.Red
        lblfirstname.ForeColor = Color.Black
        lbllastname.ForeColor = Color.Black
        lblusername.ForeColor = Color.Black
        lblpass.ForeColor = Color.Black
        lblconfirmpass.ForeColor = Color.Black
        lblregiuser.ForeColor = Color.Black
        lbllogin.ForeColor = Color.Blue
    End Sub

    Private Sub lbllogin_Click(sender As Object, e As EventArgs) Handles lbllogin.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Public Sub Registeruser()
        Try
            conn.Open()
            Dim cmd = New MySqlCommand("INSERT INTO `bloodbank`(`FirstName`, `LastName`, `UserName`, `Email`, `Password`) VALUES (@FirstName,@LastName,@UserName,@Email,@Password)", conn)
            With cmd.Parameters
                .AddWithValue("@FirstName", txtfirstname.Text)
                .AddWithValue("@LastName", txtlastname.Text)
                .AddWithValue("@UserName", txtusername.Text)
                .AddWithValue("@Email", txtemail.Text)
                .AddWithValue("@Password", txtpass.Text)

                Dim i As Integer
                i = cmd.ExecuteNonQuery
                If i > 0 Then
                    MessageBox.Show("Record Save Success !", "INSERTED", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Record Save Success!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Dispose()
            conn.Close()

        End Try
    End Sub
    Private Sub btnregister_Click(sender As Object, e As EventArgs) Handles btnregister.Click


        ' Check if all required fields are filled
        If Not (String.IsNullOrEmpty(txtfirstname.Text) OrElse
            String.IsNullOrEmpty(txtlastname.Text) OrElse
            String.IsNullOrEmpty(txtemail.Text) OrElse
            String.IsNullOrEmpty(txtpass.Text) OrElse
            String.IsNullOrEmpty(txtusername.Text) OrElse
            String.IsNullOrEmpty(txtconfirmpass.Text)) Then

            ' Check if passwords match
            If txtpass.Text <> txtconfirmpass.Text Then
                MessageBox.Show("Passwords do not match. Please re-enter.", "Password Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtconfirmpass.Focus()
                txtpass.Text = ""
                txtconfirmpass.Text = ""
                Exit Sub
                Return ' Exit the sub to prevent further execution
            End If

            ' Attempt to register user if all conditions are met
            Registeruser()

        Else
            MessageBox.Show("Please fill in all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If




    End Sub

    Public Sub clear()
        txtfirstname.Clear()
        txtlastname.Clear()
        txtusername.Clear()
        txtpass.Clear()
        txtconfirmpass.Clear()
        txtemail.Clear()
    End Sub

    Private Sub txtfirstname_leave(sender As Object, e As EventArgs) Handles txtfirstname.Leave
        Dim firstname As String = txtfirstname.Text.Trim()

        If firstname = "" Then
            MessageBox.Show("Enter first name.", "REQUIRED", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtfirstname.Focus()
            Exit Sub
        End If

        If Not System.Text.RegularExpressions.Regex.IsMatch(firstname, "^[a-zA-Z]+$") Then
            MessageBox.Show("First name should contain only letters.", "REQUIRED", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtfirstname.Focus()
            Exit Sub
        End If
    End Sub

    Private Sub txtlastname_leave(sender As Object, e As EventArgs) Handles txtlastname.Leave
        Dim lastname As String = txtlastname.Text.Trim()

        If lastname = "" Then
            MessageBox.Show("Enter last name.", "REQUIRED", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtfirstname.Focus()
            Exit Sub
        End If

        If Not System.Text.RegularExpressions.Regex.IsMatch(lastname, "^[a-zA-Z]+$") Then
            MessageBox.Show("Last name should contain only letters.", "REQUIRED", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtlastname.Focus()
            Exit Sub
        End If
    End Sub



    Private Sub txtemail_leave(sender As Object, e As EventArgs) Handles txtemail.Leave
        Dim email As String = txtemail.Text.Trim()

        If email = "" Then
            MessageBox.Show("Enter email.", "REQUIRED", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtemail.Focus()
            Exit Sub
        End If

        If Not Regex.IsMatch(email, "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$") Then
            MessageBox.Show("Email contains invalid characters & Please use example@domain.com format.", "Invalid format", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtemail.Focus()
            Exit Sub
        End If
    End Sub

    Private Sub txtusername_leave(sender As Object, e As EventArgs) Handles txtusername.Leave
        Dim username As String = txtusername.Text.Trim()
        Dim validUsername As String = "Admin"

        If username = "" Then
            MessageBox.Show("Enter username.", "REQUIRED", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtusername.Focus()
            Exit Sub
        End If

        If username.ToLower() <> validUsername.ToLower() Then
            MessageBox.Show("Incorrect username.", "Invalid username", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtusername.Focus()
        End If

    End Sub

    Private Sub txtpass_Leave(sender As Object, e As EventArgs) Handles txtpass.Leave
        Dim password As String = txtpass.Text.Trim()
        Dim validPasswordLength As Integer = 8
        Dim validPasswordCharacters As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*()-_+="
        Dim validPasswordDot As Boolean = False ' to check if the password contains "."

        If password = "" Then
            MessageBox.Show("Enter password.", "REQUIRED", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtpass.Focus()
            Exit Sub
        End If

        ' Minimum length of password
        If password.Length <> validPasswordLength Then
            MessageBox.Show("Password must be at least " & validPasswordLength & " characters long.", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtpass.Focus()
            Exit Sub
        End If


        'Allowed characters in password
        For Each c As Char In password
            If Not validPasswordCharacters.Contains(c) Then
                MessageBox.Show("Password contains invalid characters.", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtpass.Focus()
                Exit Sub
            End If

        Next
    End Sub

    Private Sub CheckBox1_viewpass_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1_viewpass.CheckedChanged
        If CheckBox1_viewpass.Checked = True Then
            txtpass.UseSystemPasswordChar = False
        Else
            txtpass.UseSystemPasswordChar = True
        End If
    End Sub


End Class