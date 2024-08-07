Imports System.ComponentModel
Imports System.Reflection
Imports Google.Protobuf.WellKnownTypes
Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Asn1.Ocsp

Public Class Blood_Request
    Dim conn As New MySqlConnection("server=localhost;port=3306;username=root;database=bloodbank")
    Dim i As Integer
    Dim dr As MySqlDataReader

    ' Method to reduce blood quantity in stock after request approval
    Public Sub ReduceBloodInStock(bloodType As String, quantityToReduce As Integer)

        Try
            conn.Open()

            Dim cmd As New MySqlCommand("UPDATE bloodstock SET Volume = GREATEST(Volume - @Volume, 0) WHERE BloodType = @BloodType", conn)
            cmd.Parameters.AddWithValue("@Volume", quantityToReduce)
            cmd.Parameters.AddWithValue("@BloodType", bloodType)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Error reducing blood quantity: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try

        ' Update the blood quantity labels
        UpdateBloodQuantityLabels()
    End Sub


    Private Sub Blood_Request_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DGV_load()

        ' Update blood quantity labels when the form loads
        UpdateBloodQuantityLabels()

        ' Initialize ComboBox items
        ComboBox1_component.Items.AddRange(New String() {"Whole Blood", "Red Cells", "Platelets", "Plasma"})
    End Sub

    Public Sub UpdateBloodQuantityLabels()
        ' Initialize blood stock form to access its methods
        Dim bloodStockForm As New Blood_stock()

        lblAPlus.Text = "A+: " & Math.Max(bloodStockForm.GetBloodTypeQuantity("A+"), 0).ToString() & " ml"
        lblAMinus.Text = "A-: " & Math.Max(bloodStockForm.GetBloodTypeQuantity("A-"), 0).ToString() & " ml"
        lblBPlus.Text = "B+: " & Math.Max(bloodStockForm.GetBloodTypeQuantity("B+"), 0).ToString() & " ml"
        lblBMinus.Text = "B-: " & Math.Max(bloodStockForm.GetBloodTypeQuantity("B-"), 0).ToString() & " ml"
        lblABPlus.Text = "AB+: " & Math.Max(bloodStockForm.GetBloodTypeQuantity("AB+"), 0).ToString() & " ml"
        lblABMinus.Text = "AB-: " & Math.Max(bloodStockForm.GetBloodTypeQuantity("AB-"), 0).ToString() & " ml"
        lblOPlus.Text = "O+: " & Math.Max(bloodStockForm.GetBloodTypeQuantity("O+"), 0).ToString() & " ml"
        lblOMinus.Text = "O-: " & Math.Max(bloodStockForm.GetBloodTypeQuantity("O-"), 0).ToString() & " ml"

    End Sub
    Public Sub Save()


        'Check If the quantityValue entered Is valid
        Dim quantityValue As Integer
        If Not Integer.TryParse(txt_quantity.Text.Trim(), quantityValue) Then
            MessageBox.Show("enter a valid quantity of blood. only numeric values are allowed.", "invalid input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txt_quantity.Focus()
            Exit Sub
        End If

        Dim bloodType As String = ComboBox1_selectblood.Text.Trim()
        'Dim quantityValue As Integer = Convert.ToInt32(txt_quantity.Text.Trim())

        '' Get the available quantity of the selected blood type
        Dim availableQuantity As Integer = GetBloodTypeQuantity(bloodType)

        ' Check if the available quantity is sufficient
        If quantityValue <= availableQuantity Then
            ' If the requested quantity is less than or equal to available quantity
            If quantityValue = availableQuantity Then
                ' If the available quantity matches the requested quantity, reduce blood to 0
                ReduceBloodInStock(bloodType, quantityValue)
                txtstatus.Text = "Approved"
                MessageBox.Show("Approved the blood request. Blood stock updated to 0 for " & bloodType, "Request Approved", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                ' If the requested quantity is less than available quantity, reduce the blood stock
                ReduceBloodInStock(bloodType, quantityValue)
                txtstatus.Text = "Approved"
                MessageBox.Show("You have sufficient blood amount (" & bloodType & ") to approve the request.", "Request Approved", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            SaveStatus()
        Else
            ' If the requested quantity is greater than available quantity
            txtstatus.Text = "Rejected"
            MessageBox.Show("You don't have sufficient blood amount (" & bloodType & ") to approve the request, request is rejected.", "Request Rejected", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        Try
            conn.Open()
            Dim cmd As New MySqlCommand("INSERT INTO `bloodrequest`(`Bloodrequest_ID`, `BloodRequest_centername`, `ContactNumber`, `Email`, `RequestBloodGroup`, `Quantity`, `RequestDate`, `Component`, `RequestStatus`) VALUES (@Bloodrequest_ID,@BloodRequest_centername,@ContactNumber,@Email,@RequestBloodGroup,@Quantity,@RequestDate,@Component,@RequestStatus)", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@Bloodrequest_ID", txtid.Text)
            cmd.Parameters.AddWithValue("@BloodRequest_centername", txt_centername.Text)
            cmd.Parameters.AddWithValue("@ContactNumber", txt_contactnumber.Text)
            cmd.Parameters.AddWithValue("@Email", txt_email.Text)
            cmd.Parameters.AddWithValue("@RequestBloodGroup", ComboBox1_selectblood.Text)
            cmd.Parameters.AddWithValue("@Quantity", txt_quantity.Text)
            cmd.Parameters.AddWithValue("@RequestDate", DateTime.Now.ToString("yyyy-MM-dd"))
            cmd.Parameters.AddWithValue("@Component", ComboBox1_component.Text)
            cmd.Parameters.AddWithValue("@RequestStatus", txtstatus.Text)


            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MessageBox.Show("Record Save Success!", "bloodbank", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Record Save Failed!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try

        ComboBox1_component.SelectedIndex = -1
        ComboBox1_selectblood.SelectedIndex = -1 ' Clear select blood field after saving data
        'Save()
        clear() 'clear all fields after saving data
        DGV_load()
    End Sub

    ' Function to get the available quantity of a specific blood type
    Private Function GetBloodTypeQuantity(bloodType As String) As Integer
        Select Case bloodType
            Case "A+"
                Return Integer.Parse(lblAPlus.Text.Split(": ")(1).Replace(" ml", "").Trim())
            Case "A-"
                Return Integer.Parse(lblAMinus.Text.Split(": ")(1).Replace(" ml", "").Trim())
            Case "B+"
                Return Integer.Parse(lblBPlus.Text.Split(": ")(1).Replace(" ml", "").Trim())
            Case "B-"
                Return Integer.Parse(lblBMinus.Text.Split(": ")(1).Replace(" ml", "").Trim())
            Case "AB+"
                Return Integer.Parse(lblABPlus.Text.Split(": ")(1).Replace(" ml", "").Trim())
            Case "AB-"
                Return Integer.Parse(lblABMinus.Text.Split(": ")(1).Replace(" ml", "").Trim())
            Case "O+"
                Return Integer.Parse(lblOPlus.Text.Split(": ")(1).Replace(" ml", "").Trim())
            Case "O-"
                Return Integer.Parse(lblOMinus.Text.Split(": ")(1).Replace(" ml", "").Trim())
            Case Else
                Return 0
        End Select
    End Function

    ' Function to get the quantity of a specific blood type from the database
    Private Function GetBloodTypeQuantityFromDatabase(bloodType As String) As Integer
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT Quantity FROM blood_stock WHERE BloodType = @BloodType", conn)
            cmd.Parameters.AddWithValue("@BloodType", bloodType)
            Return Convert.ToInt32(cmd.ExecuteScalar())
        Catch ex As Exception
            MsgBox(ex.Message)
            Return 0
        Finally
            conn.Close()
        End Try
    End Function

    ' Function to update the blood stock labels after a request is approved
    Private Sub UpdateBloodStock(bloodType As String, newQuantity As Integer)

        ' Ensure newQuantity is not negative
        newQuantity = Math.Max(newQuantity, 0)

        ' Update the labels in the Blood_Request form
        Select Case bloodType
            Case "A+"
                lblAPlus.Text = "A+ : " & newQuantity.ToString() & " ml"
            Case "A-"
                lblAMinus.Text = "A- : " & newQuantity.ToString() & " ml"
            Case "B+"
                lblBPlus.Text = "B+ : " & newQuantity.ToString() & " ml"
            Case "B-"
                lblBMinus.Text = "B- : " & newQuantity.ToString() & " ml"
            Case "AB+"
                lblABPlus.Text = "AB+ : " & newQuantity.ToString() & " ml"
            Case "AB-"
                lblABMinus.Text = "AB- : " & newQuantity.ToString() & " ml"
            Case "O+"
                lblOPlus.Text = "O+ : " & newQuantity.ToString() & " ml"
            Case "O-"
                lblOMinus.Text = "O- : " & newQuantity.ToString() & " ml"
        End Select

        ' Update the labels in the dashboard form
        Dim dashboardForm As dashboard_form = CType(Application.OpenForms("Dashboard"), dashboard_form)
        If dashboardForm IsNot Nothing Then
            Select Case bloodType

                Case "A+"
                    dashboardForm.LabelAPlus.Text = "A+ : " & Math.Max(newQuantity, 0).ToString() & " ml"
                Case "A-"
                    dashboardForm.LabelAMinus.Text = "A- : " & Math.Max(newQuantity, 0).ToString() & " ml"
                Case "B+"
                    dashboardForm.LabelBPlus.Text = "B+ : " & Math.Max(newQuantity, 0).ToString() & " ml"
                Case "B-"
                    dashboardForm.LabelBMinus.Text = "B- : " & Math.Max(newQuantity, 0).ToString() & " ml"
                Case "AB+"
                    dashboardForm.LabelABPlus.Text = "AB+ : " & Math.Max(newQuantity, 0).ToString() & " ml"
                Case "AB-"
                    dashboardForm.LabelABMinus.Text = "AB- : " & Math.Max(newQuantity, 0).ToString() & " ml"
                Case "O+"
                    dashboardForm.LabelOPlus.Text = "O+ : " & Math.Max(newQuantity, 0).ToString() & " ml"
                Case "O-"
                    dashboardForm.LabelOMinus.Text = "O- : " & Math.Max(newQuantity, 0).ToString() & " ml"
            End Select
        End If

    End Sub

    Public Sub DGV_load()
        DataGridView1.Rows.Clear()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM bloodrequest", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                DataGridView1.Rows.Add(dr.Item("Amountofblood_request"), dr.Item("Bloodrequest_ID"), dr.Item("BloodRequest_centername"), dr.Item("ContactNumber"), dr.Item("Email"), dr.Item("RequestBloodGroup"), dr.Item("Quantity"), dr.Item("RequestDate"), dr.Item("Component"), dr.Item("RequestStatus"))
            End While
            dr.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try


    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        clear()
    End Sub

    Private Sub clear()
        txtid.Clear()
        txt_centername.Clear()
        txt_contactnumber.Clear()
        txt_email.Clear()
        ComboBox1_selectblood.Text = ""
        ComboBox1_component.Text = ""
        txt_quantity.Text = ""
        txtstatus.Clear()
        DateTimePicker1_requestdate.Value = Now

        ComboBox1_selectblood.SelectedIndex = -1 'to clear combobox bloodgroup data
        ComboBox1_component.SelectedIndex = -1
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

        txtid.Text = DataGridView1.CurrentRow.Cells(1).Value
        txt_centername.Text = DataGridView1.CurrentRow.Cells(2).Value
        txt_contactnumber.Text = DataGridView1.CurrentRow.Cells(3).Value
        txt_email.Text = DataGridView1.CurrentRow.Cells(4).Value
        ComboBox1_selectblood.Text = DataGridView1.CurrentRow.Cells(5).Value
        txt_quantity.Text = DataGridView1.CurrentRow.Cells(6).Value
        DateTimePicker1_requestdate.Value = DataGridView1.CurrentRow.Cells(7).Value
        ComboBox1_component.Text = DataGridView1.CurrentRow.Cells(8).Value
        txtstatus.Text = DataGridView1.CurrentRow.Cells(9).Value

    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        edit()
    End Sub

    Public Sub edit()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("UPDATE `bloodrequest` SET `BloodRequest_centername`=@BloodRequest_centername,`ContactNumber`=@ContactNumber,`Email`=@Email,`RequestBloodGroup`=@RequestBloodGroup,`Quantity`=@Quantity,`RequestDate`=@RequestDate,`Component`=@Component,`RequestStatus`=@RequestStatus WHERE `Bloodrequest_ID`=@Bloodrequest_ID", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@Bloodrequest_ID", txtid.Text)
            cmd.Parameters.AddWithValue("@BloodRequest_centername", txt_centername.Text)
            cmd.Parameters.AddWithValue("@ContactNumber", txt_contactnumber.Text)
            cmd.Parameters.AddWithValue("@Email", txt_email.Text)
            cmd.Parameters.AddWithValue("@RequestBloodGroup", ComboBox1_selectblood.Text)
            cmd.Parameters.AddWithValue("@Quantity", txt_quantity.Text)
            cmd.Parameters.AddWithValue("@RequestDate", DateTime.Now)
            cmd.Parameters.AddWithValue("@Component", ComboBox1_component.Text)
            cmd.Parameters.AddWithValue("@RequestStatus", txtstatus.Text)

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
                Dim cmd As New MySqlCommand("DELETE FROM `bloodrequest` WHERE `Bloodrequest_ID`=@Bloodrequest_ID", conn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@Bloodrequest_ID", txtid.Text)
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
            clear()
            DGV_load()
        Else
            Return
        End If
    End Sub

    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click
        search()
    End Sub

    Public Sub search()
        DataGridView1.Rows.Clear()
        Try
            conn.Open()
            Dim cmd = New MySqlCommand("SELECT * FROM `bloodrequest` WHERE Bloodrequest_ID like'%" & txtsearch.Text & "%'OR RequestBloodGroup like'%" & txtsearch.Text & "%'OR RequestDate like'%" & txtsearch.Text & "%'OR BloodRequest_centername like'%" & txtsearch.Text & "%'OR RequestStatus like'%" & txtsearch.Text & "%'", conn)
            dr = cmd.ExecuteReader

            While dr.Read
                DataGridView1.Rows.Add(dr.Item("Amountofblood_request"), dr.Item("Bloodrequest_ID"), dr.Item("BloodRequest_centername"), dr.Item("ContactNumber"), dr.Item("Email"), dr.Item("RequestBloodGroup"), dr.Item("Quantity"), dr.Item("RequestDate"), dr.Item("Component"), dr.Item("RequestStatus"))
            End While
            dr.Dispose()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub txt_contactnumber_leave(sender As Object, e As EventArgs) Handles txt_contactnumber.Leave
        Dim contactnumber As String = txt_contactnumber.Text.Trim()

        If contactnumber = "" Then
            MessageBox.Show("Enter Contact Number.", "REQUIRED", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txt_contactnumber.Focus()
            Exit Sub
        End If

        Dim pattern As String = "^\d{10}$"

        ' Check if the mobile number matches the pattern

        If Not System.Text.RegularExpressions.Regex.IsMatch(contactnumber, pattern) Then
            MessageBox.Show("Enter a valid 10-digit mobile number.", "Invalid Mobile Number", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txt_contactnumber.Focus()
            Exit Sub
        End If
    End Sub

    Private Sub txt_email_leave(sender As Object, e As EventArgs) Handles txt_email.Leave
        Dim email As String = txt_email.Text.Trim()

        If email = "" Then
            MessageBox.Show("Enter email.", "REQUIRED", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txt_email.Focus()
            Exit Sub
        End If

        Dim pattern As String = "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"

        ' Check if the email matches the pattern
        If Not System.Text.RegularExpressions.Regex.IsMatch(email, pattern) Then
            MessageBox.Show("Email contains invalid characters & Please use example@domain.com format.", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txt_email.Focus()
            Exit Sub
        End If
    End Sub

    Private Sub txt_quantity_leave(sender As Object, e As EventArgs) Handles txt_quantity.Leave
        Dim volume As String = txt_quantity.Text.Trim()

        If String.IsNullOrEmpty(volume) Then
            MessageBox.Show("Enter Blood Quantity.", "REQUIRED", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txt_quantity.Focus()
            Exit Sub
        End If

        ' Check if the input is a valid number
        Dim quantity As Integer
        If Not Integer.TryParse(volume, quantity) OrElse quantity <= 0 Then
            MessageBox.Show("Enter a valid positive number for Blood Quantity.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_quantity.Focus()
            txt_quantity.SelectAll() ' Select all text for user convenience
            Exit Sub
        End If

    End Sub


    Private Sub ComboBox1_selectblood_leave(sender As Object, e As EventArgs) Handles ComboBox1_selectblood.Leave
        Dim bloodgroup As String = ComboBox1_selectblood.Text.Trim()

        If bloodgroup = "" Then
            MessageBox.Show("Select Blood Group.", "REQUIRED", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ComboBox1_selectblood.Focus()
            Exit Sub
        End If


    End Sub

    Private Sub DateTimePicker1_requestdate_leave(sender As Object, e As EventArgs) Handles DateTimePicker1_requestdate.Leave
        Dim requestDate As String = DateTimePicker1_requestdate.Text.Trim()

        ' Check if the entered date is in the past
        If requestDate < Date.Today Then
            MessageBox.Show("Blood request date cannot be a past date.", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            DateTimePicker1_requestdate.Focus()
            Exit Sub
        End If

    End Sub


    Private Sub txt_centername_Leave(sender As Object, e As EventArgs) Handles txt_centername.Leave
        Dim hospitalName As String = txt_centername.Text.Trim()

        If hospitalName = "" Then
            MessageBox.Show("Enter blood request center's name.", "REQUIRED", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txt_centername.Focus()
            Exit Sub
        End If

        ' Define the regular expression pattern to allow letters, spaces, and dots
        Dim regexPattern As String = "^[A-Za-z .]+$"

        ' Check if the input matches the pattern
        If Not System.Text.RegularExpressions.Regex.IsMatch(hospitalName, regexPattern) Then
            MessageBox.Show("Enter a valid Hospital name. Only letters, spaces, and dots are allowed.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txt_centername.Focus()
            txt_centername.SelectAll() ' Select all text for easy correction
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
    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click


        'Check If all required fields except request date are filled
        If Not (String.IsNullOrEmpty(txt_centername.Text) OrElse
        String.IsNullOrEmpty(txt_contactnumber.Text) OrElse
        String.IsNullOrEmpty(txt_email.Text) OrElse
        String.IsNullOrEmpty(ComboBox1_selectblood.Text) OrElse
        String.IsNullOrEmpty(ComboBox1_component.Text) OrElse
        String.IsNullOrEmpty(txt_quantity.Text)) Then

            ' Generate the Blood Request ID
            Dim newBloodRequestID As String = GenerateBloodRequestID()

            ' Set the txtid textbox with the generated Blood Request ID
            txtid.Text = newBloodRequestID

            Save()
        Else

            MessageBox.Show("Please fill in all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

    End Sub
    Private Sub SaveStatus()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("UPDATE bloodrequest SET RequestStatus = @Status WHERE Bloodrequest_ID = @RequestID", conn)
            cmd.Parameters.AddWithValue("@Status", txtstatus.Text)
            cmd.Parameters.AddWithValue("@RequestID", txtid.Text)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Error updating request status: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
    End Sub


    Private Function GenerateBloodRequestID() As String
        ' Blood Bank Code
        Dim bloodBankCode As String = "AB"

        ' Get the current year and month
        Dim currentYear As String = Date.Now.ToString("yy")
        Dim currentMonth As String = Date.Now.ToString("MM")

        ' Get the number of blood requests made in this month
        Dim requestCount As Integer = DataGridView1.Rows.Count + 1 ' Add 1 for the new request

        ' Format the serial number with leading zeros
        Dim serialNumber As String = requestCount.ToString("00")

        ' Concatenate the parts to form the Blood Request ID without checksum
        Dim requestIdWithoutChecksum As String = bloodBankCode & currentYear & currentMonth & serialNumber

        Return requestIdWithoutChecksum
    End Function



End Class