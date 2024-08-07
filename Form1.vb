

Imports MySql.Data.MySqlClient


Public Class Form1


    Dim conn As New MySqlConnection("server=localhost;port=3306;username=root;database=bloodbank")

    Private Sub lblexit1_Click(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub

    Private Sub lblregister_Click(sender As Object, e As EventArgs) Handles lblregister.Click
        Me.Hide()
        Register_form.Show()
    End Sub

    Private Sub lblexit1_Click_1(sender As Object, e As EventArgs) Handles lblexit1.Click
        Me.Close()
    End Sub

    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        ' Check if all required fields are filled
        If Not (String.IsNullOrEmpty(txtusername.Text) OrElse
            String.IsNullOrEmpty(Txtpass.Text)) Then
            Login()
        Else
            MessageBox.Show("Please fill in all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1_login.BackColor = Color.FromArgb(40, 0, 0, 0)
        lblnewuser.BackColor = Color.Transparent
        lblregister.BackColor = Color.Transparent
        Lbladminlogin.BackColor = Color.Transparent
        PictureBox2_adminpic.BackColor = Color.Transparent
        PictureBox3_username.BackColor = Color.Transparent
        PictureBox1_pass.BackColor = Color.Transparent

        lblnewuser.ForeColor = Color.Black
        lblregister.ForeColor = Color.Blue
        Lbladminlogin.ForeColor = Color.Black
        PictureBox2_adminpic.ForeColor = Color.Blue
        PictureBox3_username.ForeColor = Color.Blue
        PictureBox1_pass.ForeColor = Color.Blue

        Panel2_forget.Visible = False ' Hide the forget password panel

    End Sub

    Public Sub Login()
        Try
            conn.Open()
            Dim adapter = New MySqlDataAdapter("SELECT * FROM `bloodbank` WHERE `UserName`=@UserName AND`Password`=@Password", conn)
            With adapter.SelectCommand.Parameters
                .AddWithValue("@UserName", txtusername.Text)
                .AddWithValue("@Password", Txtpass.Text)
            End With

            Dim table = New DataTable()
            adapter.Fill(table)
            If (table.Rows.Count > 0) Then
                MessageBox.Show("Logged in Successfully", "LOGGED", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Hide()
                splash_screen_loading.Show()

            Else
                MessageBox.Show("Incorrect Credentials", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Dispose()
            conn.Close()


        End Try
    End Sub
    Private Sub CheckBox1_viewpass_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1_viewpass.CheckedChanged
        If CheckBox1_viewpass.Checked = False Then
            Txtpass.PasswordChar = "*"
        Else
            Txtpass.PasswordChar = ""
        End If
    End Sub

    Private Sub btnforget_Click(sender As Object, e As EventArgs) Handles btnforget.Click
        ' Show the panel containing the forgot password controls
        Panel2_forget.Visible = True
    End Sub

    Private Sub btnsubmit_Click(sender As Object, e As EventArgs) Handles btnsubmit.Click
        If Panel2_forget.Visible Then
            ' Panel is visible, so this click should submit the answer
            CheckAnswer()
        Else
            ' Panel is not visible, so this click should retrieve the security question
            RetrieveSecurityQuestion()
        End If
    End Sub

    Private Sub RetrieveSecurityQuestion()
        ' Retrieve the email address entered by the user
        Dim email As String = txtanswer.Text

        ' Query the database to check if the email exists
        Dim query As String = "SELECT COUNT(*) FROM bloodbank WHERE Email = @Email"

        Try
            conn.Open()
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@Email", email)
            Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())

            If count > 0 Then
                ' Email exists in the database
                Dim securityQuestionQuery As String = "SELECT SecurityQuestion FROM bloodbank WHERE Email = @Email"
                Dim securityQuestionCmd As New MySqlCommand(securityQuestionQuery, conn)
                securityQuestionCmd.Parameters.AddWithValue("@Email", email)
                Dim securityQuestion As String = Convert.ToString(securityQuestionCmd.ExecuteScalar())

                ' Display the retrieved security question
                lblsecurity.Text = securityQuestion
                Panel2_forget.Visible = True ' Show the panel after retrieving the security question
                txtAnswer.Focus() ' Set focus to the answer textbox
            Else
                ' Email not found in the database
                MessageBox.Show("Email address not found. Please enter a valid email address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred while retrieving the security question. " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub CheckAnswer()
        ' Retrieve the answer entered by the user
        Dim userAnswer As String = txtanswer.Text

        ' Retrieve the expected answer from the database based on the email address
        Dim query As String = "SELECT Email FROM bloodbank WHERE Email = @Email"

        Try
            conn.Open()
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@Email", txtanswer.Text)
            Dim expectedAnswer As String = cmd.ExecuteScalar()?.ToString()

            If userAnswer = expectedAnswer Then
                MessageBox.Show("Correct answer! Proceed with password reset.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ' Code to proceed with password reset goes here
                Me.Hide()
                splash_screen_loading.Show()
            Else
                MessageBox.Show("Incorrect answer. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred while verifying the answer. " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
    End Sub
End Class

