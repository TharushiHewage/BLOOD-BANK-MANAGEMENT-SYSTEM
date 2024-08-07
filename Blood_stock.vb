Imports System.ComponentModel.DataAnnotations
Imports System.Linq.Expressions
Imports System.Text.RegularExpressions
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient
Imports Mysqlx.Crud
Imports Org.BouncyCastle.Tls.Crypto

Public Class Blood_stock
    Dim conn As New MySqlConnection("server=localhost;port=3306;username=root;password=;database=bloodbank")
    Dim i As Integer
    Dim dr As MySqlDataReader
    Dim errorProvider As New ErrorProvider()
    Public Property DonorID As String
    Public Property DonorName As String
    Public Property DonorAge As String
    Public Property DonorNIC As String
    Public Property DonorBloodType As String
    Public Property BloodQuantity As String
    Public Property DonorGender As String


    Private Sub Blood_stock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize ComboBox items
        ComboBox1_bloodtype.Items.AddRange(New String() {"A+", "A-", "B+", "B-", "AB+", "AB-", "O+", "O-"})
        ComboBox1_component.Items.AddRange(New String() {"Whole Blood", "Red Cells", "Platelets", "Plasma"})
        ComboBox2_gender.Items.AddRange(New String() {"Male", "Female", "Other"})


        ' Set the data in the controls when the form loads
        txtdonorregistration_id.Text = DonorID
        txtname.Text = DonorName
        txtdonorage.Text = DonorAge
        txtnic.Text = DonorNIC
        ComboBox1_bloodtype.Text = DonorBloodType
        txtvolume.Text = BloodQuantity
        ComboBox2_gender.Text = DonorGender


        ' Load data into DataGridView
        DGV_load()

        ' Update dashboard labels
        UpdateDashboard()
    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click

        If String.IsNullOrEmpty(txtnic.Text) OrElse
            String.IsNullOrEmpty(txtname.Text) OrElse
            String.IsNullOrEmpty(ComboBox1_bloodtype.Text) OrElse
            String.IsNullOrEmpty(ComboBox1_component.Text) OrElse
            String.IsNullOrEmpty(txtvolume.Text) OrElse
            String.IsNullOrEmpty(txtdonorage.Text) OrElse
            String.IsNullOrEmpty(ComboBox2_gender.Text) OrElse
            String.IsNullOrEmpty(txttested.Text) OrElse
            String.IsNullOrEmpty(txtstorage.Text) OrElse
            String.IsNullOrEmpty(txtcollectionsite.Text) Then

            MessageBox.Show("All the required fields must be filled.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Check if the expiration date is past or current date
        If DateTimePicker2.Value.Date <= DateTime.Now.Date Then
            MessageBox.Show("Expiration date must be a future date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If


        ' Generate and display Blood Bag ID
        txtbloodbagid.Text = GenerateBloodBagID()

        save()

        'LoadData()
        DGV_load()

        ' Update dashboard labels
        UpdateDashboard()
    End Sub

    Private Function GenerateBloodBagID() As String
        ' Blood Bank Code
        Dim bloodBankCode As String = "AB"

        ' Get the current year and month
        Dim currentYear As String = Date.Now.ToString("yy")
        Dim currentMonth As String = Date.Now.ToString("MM")

        ' Get the number of donations made in this month
        Dim donationCount As Integer = DataGridView1.Rows.Count + 1 ' Add 1 for the new row

        ' Format the serial number with leading zeros
        Dim serialNumber As String = donationCount.ToString("0000")

        ' Concatenate the parts to form the DIN without checksum
        Dim dinWithoutChecksum As String = bloodBankCode & currentYear & currentMonth & serialNumber

        ' Calculate the checksum
        Dim checksum As Integer = CalculateChecksum(dinWithoutChecksum)

        ' Create the Blood Bag ID with checksum
        Dim bloodBagID As String = dinWithoutChecksum & "-" & checksum.ToString()

        Return bloodBagID
    End Function

    Private Function CalculateChecksum(dinWithoutChecksum As String) As Integer
        Dim sum As Integer = 0
        For Each digit As Char In dinWithoutChecksum
            If Char.IsDigit(digit) Then
                sum += CInt(Char.GetNumericValue(digit))
            End If
        Next
        Return sum Mod 10
    End Function
    Private Sub UpdateDashboard()
        Dim dashboard As New dashboard_form()
        dashboard.LabelAPlus.Text = "A+: " & GetBloodTypeQuantity("A+").ToString() & " ml"
        dashboard.LabelAMinus.Text = "A-: " & GetBloodTypeQuantity("A-").ToString() & " ml"
        dashboard.LabelBPlus.Text = "B+: " & GetBloodTypeQuantity("B+").ToString() & " ml"
        dashboard.LabelBMinus.Text = "B-: " & GetBloodTypeQuantity("B-").ToString() & " ml"
        dashboard.LabelABPlus.Text = "AB+: " & GetBloodTypeQuantity("AB+").ToString() & " ml"
        dashboard.LabelABMinus.Text = "AB-: " & GetBloodTypeQuantity("AB-").ToString() & " ml"
        dashboard.LabelOPlus.Text = "O+: " & GetBloodTypeQuantity("O+").ToString() & " ml"
        dashboard.LabelOMinus.Text = "O-: " & GetBloodTypeQuantity("O-").ToString() & " ml"

        ' Update labels in Blood Request form
        Dim bloodRequestForm As New Blood_Request()
        bloodRequestForm.lblAPlus.Text = dashboard.LabelAPlus.Text
        bloodRequestForm.lblAMinus.Text = dashboard.LabelAMinus.Text
        bloodRequestForm.lblBPlus.Text = dashboard.LabelBPlus.Text
        bloodRequestForm.lblBMinus.Text = dashboard.LabelBMinus.Text
        bloodRequestForm.lblABPlus.Text = dashboard.LabelABPlus.Text
        bloodRequestForm.lblABMinus.Text = dashboard.LabelABMinus.Text
        bloodRequestForm.lblOPlus.Text = dashboard.LabelOPlus.Text
        bloodRequestForm.lblOMinus.Text = dashboard.LabelOMinus.Text

    End Sub



    ' Get the total quantity of blood for a specific blood type
    Public Function GetBloodTypeQuantity(bloodType As String) As Integer
        Dim quantity As Integer = 0
        Try
            conn.Open()
            Dim query As String = "SELECT SUM(Volume) FROM bloodstock WHERE BloodType = @BloodType"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@BloodType", bloodType)
                Dim result = cmd.ExecuteScalar()
                If result IsNot DBNull.Value Then
                    quantity = Convert.ToInt32(result)
                End If
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
        Return quantity
    End Function

    Public Sub save()
        Try
            conn.Open()

            Dim cmd As New MySqlCommand("INSERT INTO `bloodstock` (`NIC`, `Name`, `BloodBag_ID`, `BloodType`, `DonorRegistration_ID`, `Component`, `Volume`, `CollectionDate`, `ExpiryDate`, `DonorAge`, `Gender`, `Tested`, `Storage`, `CollectionSite`) VALUES (@NIC, @Name, @BloodBag_ID, @BloodType, @DonorRegistration_ID, @Component, @Volume, @CollectionDate, @ExpiryDate, @DonorAge, @Gender, @Tested, @Storage, @CollectionSite)", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@NIC", txtnic.Text)
            cmd.Parameters.AddWithValue("@Name", txtname.Text)
            cmd.Parameters.AddWithValue("@BloodBag_ID", txtbloodbagid.Text)
            cmd.Parameters.AddWithValue("@BloodType", ComboBox1_bloodtype.Text)
            cmd.Parameters.AddWithValue("@DonorRegistration_ID", txtdonorregistration_id.Text)
            cmd.Parameters.AddWithValue("@Component", ComboBox1_component.Text)
            cmd.Parameters.AddWithValue("@Volume", txtvolume.Text)
            cmd.Parameters.AddWithValue("@CollectionDate", DateTimePicker1.Value.Date)
            cmd.Parameters.AddWithValue("@ExpiryDate", DateTimePicker2.Value.Date)
            cmd.Parameters.AddWithValue("@DonorAge", txtdonorage.Text)
            cmd.Parameters.AddWithValue("@Gender", ComboBox2_gender.Text)
            cmd.Parameters.AddWithValue("@Tested", txttested.Text)
            cmd.Parameters.AddWithValue("@Storage", txtstorage.Text)
            cmd.Parameters.AddWithValue("@CollectionSite", txtcollectionsite.Text)


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
            Dim cmd As New MySqlCommand("SELECT * FROM bloodstock", conn)
            dr = cmd.ExecuteReader()
            While dr.Read()
                DataGridView1.Rows.Add(dr.Item("ID"), dr.Item("NIC"), dr.Item("Name"), dr.Item("BloodBag_ID"), dr.Item("BloodType"), dr.Item("DonorRegistration_ID"), dr.Item("Component"), dr.Item("Volume"), dr.Item("CollectionDate"), dr.Item("ExpiryDate"), dr.Item("DonorAge"), dr.Item("Gender"), dr.Item("Tested"), dr.Item("Storage"), dr.Item("CollectionSite"))
            End While
            dr.Dispose()

        Catch ex As Exception
            MsgBox("An error occurred: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub


    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        txtnic.Text = DataGridView1.CurrentRow.Cells(1).Value
        txtname.Text = DataGridView1.CurrentRow.Cells(2).Value
        txtbloodbagid.Text = DataGridView1.CurrentRow.Cells(3).Value
        ComboBox1_bloodtype.Text = DataGridView1.CurrentRow.Cells(4).Value
        txtdonorregistration_id.Text = DataGridView1.CurrentRow.Cells(5).Value
        ComboBox1_component.Text = DataGridView1.CurrentRow.Cells(6).Value
        txtvolume.Text = DataGridView1.CurrentRow.Cells(7).Value
        DateTimePicker1.Text = DataGridView1.CurrentRow.Cells(8).Value
        DateTimePicker2.Text = DataGridView1.CurrentRow.Cells(9).Value
        txtdonorage.Text = DataGridView1.CurrentRow.Cells(10).Value
        ComboBox2_gender.Text = DataGridView1.CurrentRow.Cells(11).Value
        txttested.Text = DataGridView1.CurrentRow.Cells(12).Value
        txtstorage.Text = DataGridView1.CurrentRow.Cells(13).Value
        txtcollectionsite.Text = DataGridView1.CurrentRow.Cells(14).Value


        btnsave.Enabled = False


    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        clear()
    End Sub

    Private Sub clear()
        txtnic.Clear()
        txtname.Clear()
        txtbloodbagid.Clear()
        ComboBox1_bloodtype.Text = ""
        txtdonorregistration_id.Clear()
        ComboBox1_component.Text = ""
        txtvolume.Clear()
        DateTimePicker1.Value = DateTime.Now
        DateTimePicker2.Value = DateTime.Now
        txtdonorage.Clear()
        ComboBox2_gender.Text = ""
        txttested.Clear()
        txtstorage.Clear()
        txtcollectionsite.Clear()
        txtdonorregistration_id.Clear()
        txtnic.ReadOnly = False
        btnadd.Enabled = True
    End Sub

    Private Sub txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged
        DataGridView1.Rows.Clear()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM bloodstock WHERE NIC like'%" & txtsearch.Text & "%' OR Name like'%" & txtsearch.Text & "%'OR BloodBag_ID like'%" & txtsearch.Text & "%'OR DonorRegistration_ID like'%" & txtsearch.Text & "%'OR Component like'%" & txtsearch.Text & "%'OR CollectionDate like'%" & txtsearch.Text & "%'", conn)

            dr = cmd.ExecuteReader()
            While dr.Read()
                DataGridView1.Rows.Add(dr.Item("ID"), dr.Item("NIC"), dr.Item("Name"), dr.Item("BloodBag_ID"), dr.Item("BloodType"), dr.Item("DonorRegistration_ID"), dr.Item("Component"), dr.Item("Volume"), dr.Item("CollectionDate"), dr.Item("ExpiryDate"), dr.Item("DonorAge"), dr.Item("Gender"), dr.Item("Tested"), dr.Item("Storage"), dr.Item("CollectionSite"))
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
        DGV_load()
        UpdateDashboard()
    End Sub

    Public Sub edit()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("UPDATE `bloodstock` SET `Name`= @Name, `BloodBag_ID`= @BloodBag_ID, `BloodType`= @BloodType, `DonorRegistration_ID`= @DonorRegistration_ID, `Component`= @Component, `Volume`= @Volume, `CollectionDate`= @CollectionDate, `ExpiryDate`= @ExpiryDate, `DonorAge`= @DonorAge, `Gender`= @Gender, `Tested`= @Tested, `Storage`= @Storage, `CollectionSite`= @CollectionSite WHERE `NIC`= @NIC", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@NIC", txtnic.Text)
            cmd.Parameters.AddWithValue("@Name", txtname.Text)
            cmd.Parameters.AddWithValue("@BloodBag_ID", txtbloodbagid.Text)
            cmd.Parameters.AddWithValue("@BloodType", ComboBox1_bloodtype.Text)
            cmd.Parameters.AddWithValue("@DonorRegistration_ID", txtdonorregistration_id.Text)
            cmd.Parameters.AddWithValue("@Component", ComboBox1_component.Text)
            cmd.Parameters.AddWithValue("@Volume", txtvolume.Text)
            cmd.Parameters.AddWithValue("@CollectionDate", DateTimePicker1.Value)
            cmd.Parameters.AddWithValue("@ExpiryDate", DateTimePicker2.Value)
            cmd.Parameters.AddWithValue("@DonorAge", txtdonorage.Text)
            cmd.Parameters.AddWithValue("@Gender", ComboBox2_gender.Text)
            cmd.Parameters.AddWithValue("@Tested", txttested.Text)
            cmd.Parameters.AddWithValue("@Storage", txtstorage.Text)
            cmd.Parameters.AddWithValue("@CollectionSite", txtcollectionsite.Text)

            i = cmd.ExecuteNonQuery()
            If i > 0 Then
                MessageBox.Show("Record Update Success!", "bloodbank", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Record Update Failed!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
        clear()
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        delete()
        DGV_load()
        UpdateDashboard()
    End Sub

    Public Sub delete()
        If MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.Question + vbYesNo) = vbYes Then
            Try
                conn.Open()
                Dim cmd As New MySqlCommand("DELETE FROM `bloodstock` WHERE `NIC` = @NIC", conn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@NIC", txtnic.Text)

                i = cmd.ExecuteNonQuery()
                If i > 0 Then
                    MessageBox.Show("Record Delete Success!", "bloodbank", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Record Delete Failed!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                conn.Close()
            End Try
            clear()
        Else
            Return
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

    Private Sub txtname_Leave(sender As Object, e As EventArgs) Handles txtname.Leave
        Dim name As String = txtname.Text.Trim()

        If name = "" Then
            MessageBox.Show("Enter Name.", "REQUIRED", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtname.Focus()
            Exit Sub
        End If

        ' Regular expression pattern to allow only letters, spaces, and dots in the middle of the name
        Dim pattern As String = "^[A-Za-z]+(?: [.'\s][A-Za-z]+)*$"

        ' Check if the name matches the pattern
        If Not System.Text.RegularExpressions.Regex.IsMatch(name, pattern) Then
            MessageBox.Show("Enter a valid name.", "Invalid Name", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtname.Focus()
            Exit Sub
        End If
    End Sub

    Private Sub ComboBox1_bloodtype_Leave(sender As Object, e As EventArgs) Handles ComboBox1_bloodtype.Leave
        Dim bloodtype As String = ComboBox1_bloodtype.Text.Trim()

        If bloodtype = "" Then
            MessageBox.Show("Select Blood type.", "REQUIRED", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ComboBox1_bloodtype.Focus()
            Exit Sub
        End If
    End Sub

    Private Sub ComboBox1_component_Leave(sender As Object, e As EventArgs) Handles ComboBox1_component.Leave
        Dim component As String = ComboBox1_component.Text.Trim()

        If component = "" Then
            MessageBox.Show("Select Component.", "REQUIRED", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ComboBox1_component.Focus()
            Exit Sub
        End If
    End Sub

    Private Sub txtvolume_Leave(sender As Object, e As EventArgs) Handles txtvolume.Leave
        Dim volume As String = txtvolume.Text.Trim()

        If String.IsNullOrEmpty(volume) Then
            MessageBox.Show("Enter Blood Quantity.", "REQUIRED", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtvolume.Focus()
            Exit Sub
        End If

        ' Check if the input is a valid number
        Dim quantity As Integer
        If Not Integer.TryParse(volume, quantity) OrElse quantity <= 0 Then
            MessageBox.Show("Enter a valid positive number for Blood Quantity.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtvolume.Focus()
            txtvolume.SelectAll() ' Select all text for user convenience
            Exit Sub
        End If

        ' Append "ml" after the text in the textbox
        txtvolume.Text = volume & " ml"
    End Sub

    Private Sub DateTimePicker1_Leave(sender As Object, e As EventArgs) Handles DateTimePicker1.Leave
        Dim inputDateString As String = DateTimePicker1.Text.Trim()

        If inputDateString = "" Then
            MessageBox.Show("Select Date.", "REQUIRED", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            DateTimePicker1.Focus()
            Exit Sub
        End If

    End Sub

    Private Sub DateTimePicker2_Leave(sender As Object, e As EventArgs) Handles DateTimePicker2.Leave
        ' Get the selected date from the DateTimePicker
        Dim selectedDate As Date = DateTimePicker2.Value

        ' Check if the selected date is in the past
        If selectedDate < DateTime.Today.AddDays(1) Then
            MessageBox.Show("Expiry date cannot be in the past or current date.", "Invalid Expiry Date", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End If
    End Sub

    Private Sub txtdonorage_Leave(sender As Object, e As EventArgs) Handles txtdonorage.Leave
        Dim ageText As String = txtdonorage.Text.Trim()

        ' Check if the Age field is empty
        If ageText = "" Then
            MessageBox.Show("Enter Age.", "REQUIRED", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtdonorage.Focus()
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
                txtdonorage.Focus()
                Exit Sub
            End If
        Else
            ' If the conversion to integer fails, show an error message
            MessageBox.Show("Enter a valid Age.", "Invalid Age", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtdonorage.Focus()
            Exit Sub
        End If

        ' Append "years" to the age if not already appended
        txtdonorage.Text = age.ToString() & " years"
    End Sub

    Private Sub ComboBox2_gender_Leave(sender As Object, e As EventArgs) Handles ComboBox2_gender.Leave
        Dim gender As String = ComboBox2_gender.Text.Trim()

        If gender = "" Then
            MessageBox.Show("Select Gender.", "REQUIRED", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ComboBox2_gender.Focus()
            Exit Sub
        End If

    End Sub

    Private Sub txttested_Leave(sender As Object, e As EventArgs) Handles txttested.Leave
        Dim testResult As String = txttested.Text.Trim().ToLower()

        ' Check if the textbox is empty
        If String.IsNullOrEmpty(testResult) Then
            MessageBox.Show("Enter test result for diseases like HIV, HBV, HCV, and Syphilis.", "Required Field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txttested.Focus()
            Exit Sub
        End If

        ' Validate that the input contains only letters, hyphens, and spaces
        Dim allowedCharsPattern As String = "^[a-zA-Z\- ]+$"
        If Not System.Text.RegularExpressions.Regex.IsMatch(testResult, allowedCharsPattern) Then
            MessageBox.Show("The test result can only contain letters, hyphens, and spaces.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txttested.Focus()
            Exit Sub
        End If
    End Sub

    Private Sub txtstorage_Leave(sender As Object, e As EventArgs) Handles txtstorage.Leave
        Dim storageTemp As String = txtstorage.Text.Trim()

        ' Check if the textbox is empty
        If String.IsNullOrEmpty(storageTemp) Then
            MessageBox.Show("Enter the storage temperature.", "Required Field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtstorage.Focus()
            Exit Sub
        End If

        ' Regular expression pattern to match any characters, spaces, numerical values, and hyphens
        Dim pattern As String = "^[a-zA-Z0-9\s-]+$"

        ' Check if the entered value matches the pattern
        If Not Regex.IsMatch(storageTemp, pattern) Then
            MessageBox.Show("Enter the storage temperature using valid characters.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtstorage.Focus()
            txtstorage.SelectAll() ' Select all text for user convenience
            Exit Sub
        End If

        ' Append "Celsius" to the input
        txtstorage.Text = storageTemp & " Celsius"

    End Sub

    Private Sub txtcollectionsite_Leave(sender As Object, e As EventArgs) Handles txtcollectionsite.Leave
        Dim collectionSite As String = txtcollectionsite.Text.Trim()

        ' Check if the textbox is empty
        If String.IsNullOrEmpty(collectionSite) Then
            MessageBox.Show("Enter the collection site name.", "Required Field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtcollectionsite.Focus()
            Exit Sub
        End If

        ' Regular expression pattern to match a valid collection site name
        Dim pattern As String = "^[a-zA-Z.,\s]+$"

        ' Check if the entered value matches the pattern
        If Not Regex.IsMatch(collectionSite, pattern) Then
            MessageBox.Show("Enter a valid collection site name.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtcollectionsite.Focus()
            txtcollectionsite.SelectAll() ' Select all text for user convenience
            Exit Sub
        End If

    End Sub

    Private Sub txtbloodbagid_Leave(sender As Object, e As EventArgs) Handles txtbloodbagid.Leave
        Dim bloodbagID As String = txtbloodbagid.Text.Trim()

        ' Check if the textbox is empty
        If String.IsNullOrEmpty(bloodbagID) Then
            MessageBox.Show("Enter the collection site name.", "Required Field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtcollectionsite.Focus()
            Exit Sub
        End If


        'Regular Expression pattern To match a valid collection site name (capital And simple alphabetical words, numbers, spaces, And hyphens)
        Dim pattern As String = "^[a-zA-Z0-9\s-]+$"

        ' Check if the entered value matches the pattern
        If Not Regex.IsMatch(bloodbagID, pattern) Then
            MessageBox.Show("Enter a valid collection site name.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtcollectionsite.Focus()
            txtcollectionsite.SelectAll() ' Select all text for user convenience

            Exit Sub
        End If
    End Sub


End Class