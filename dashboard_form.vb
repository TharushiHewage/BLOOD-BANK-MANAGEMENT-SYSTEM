Imports System.Runtime.InteropServices
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button
Imports MySql.Data.MySqlClient

Public Class dashboard_form
    ' Connection string for the database
    Dim conn As New MySqlConnection("server=localhost;port=3306;username=root;password=;database=bloodbank")


    ' Method to get the total blood stock count
    Private Function GetTotalBloodStockCount() As Integer
        Dim totalStock As Integer = 0
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT SUM(Volume) FROM bloodstock", conn)
            totalStock = Convert.ToInt32(cmd.ExecuteScalar())
        Catch ex As Exception
            MessageBox.Show("Error fetching total blood stock count: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
        Return totalStock
    End Function

    ' Method to update the dashboard label
    Private Sub UpdateTotalBloodStockLabel()
        Dim totalStock As Integer = GetTotalBloodStockCount()
        lbltotal_blood.Text = totalStock.ToString()
    End Sub


    ' Method to get the total registered medical officers count
    Private Function GetTotalMedicalOfficersCount() As Integer
        Dim totalMedicalOfficers As Integer = 0
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT COUNT(*) FROM  medicalofficers_registration", conn)
            totalMedicalOfficers = Convert.ToInt32(cmd.ExecuteScalar())
        Catch ex As Exception
            MessageBox.Show("Error fetching total medical officers count: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
        Return totalMedicalOfficers
    End Function

    ' Method to update the dashboard label for medical officers
    Private Sub UpdateTotalMedicalOfficersLabel()
        Dim totalMedicalOfficers As Integer = GetTotalMedicalOfficersCount()
        lbltotal_doctor.Text = totalMedicalOfficers.ToString()
    End Sub


    ' Method to get the total approved requests count
    Private Function GetTotalApprovedRequestsCount() As Integer
        Dim totalApprovedRequests As Integer = 0
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT COUNT(*) FROM bloodrequest WHERE RequestStatus = 'Approved'", conn)
            totalApprovedRequests = Convert.ToInt32(cmd.ExecuteScalar())
        Catch ex As Exception
            MessageBox.Show("Error fetching total approved requests count: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
        Return totalApprovedRequests
    End Function

    ' Method to update the dashboard label for approved requests
    Private Sub UpdateTotalApprovedRequestsLabel()
        Dim totalApprovedRequests As Integer = GetTotalApprovedRequestsCount()
        lblApproved.Text = totalApprovedRequests.ToString()
    End Sub


    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Application.Exit()
    End Sub

    Private Sub ButtonMaximized_Click(sender As Object, e As EventArgs) Handles ButtonMaximized.Click
        If WindowState = FormWindowState.Normal Then
            WindowState = WindowState.Maximized
        Else
            WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub Btnminimize_Click(sender As Object, e As EventArgs) Handles Btnminimize.Click
        WindowState = FormWindowState.Minimized
    End Sub


    Private Sub dashboard_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        ' Load blood stock quantities
        UpdateBloodQuantityLabels()

        lblname.Text = Register_form.txtfirstname.Text

        UpdateTotalMedicalOfficersLabel()
        UpdateTotalBloodStockLabel()
        UpdateTotalApprovedRequestsLabel()
    End Sub

    ' Method to update blood quantity labels
    Public Sub UpdateBloodQuantityLabels()
        ' Initialize blood stock form to access its methods
        Dim bloodStockForm As New Blood_stock()

        ' Update labels with blood quantities
        LabelAPlus.Text = "A+: " & bloodStockForm.GetBloodTypeQuantity("A+").ToString()
        LabelAMinus.Text = "A-: " & bloodStockForm.GetBloodTypeQuantity("A-").ToString()
        LabelBPlus.Text = "B+: " & bloodStockForm.GetBloodTypeQuantity("B+").ToString()
        LabelBMinus.Text = "B-: " & bloodStockForm.GetBloodTypeQuantity("B-").ToString()
        LabelABPlus.Text = "AB+: " & bloodStockForm.GetBloodTypeQuantity("AB+").ToString()
        LabelABMinus.Text = "AB-: " & bloodStockForm.GetBloodTypeQuantity("AB-").ToString()
        LabelOPlus.Text = "O+: " & bloodStockForm.GetBloodTypeQuantity("O+").ToString()
        LabelOMinus.Text = "O-: " & bloodStockForm.GetBloodTypeQuantity("O-").ToString()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Sub switchPanel(ByVal panel As Form)
        PanelDekstop.Controls.Clear()
        panel.TopLevel = False
        panel.FormBorderStyle = FormBorderStyle.None
        panel.Dock = DockStyle.Fill
        PanelDekstop.Controls.Add(panel)
        panel.Show()


    End Sub

    Private Sub Btnbloodrequest_Click(sender As Object, e As EventArgs) Handles Btnbloodrequest.Click
        switchPanel(Blood_Request)
    End Sub

    Private Sub Btndoctor_Click(sender As Object, e As EventArgs) Handles Btndoctor.Click
        switchPanel(Doctor_Registration)
    End Sub

    Private Sub btnaboutus_Click(sender As Object, e As EventArgs) Handles btnaboutus.Click
        switchPanel(About_Us)
    End Sub

    Private Sub Btnbloodstock_Click(sender As Object, e As EventArgs) Handles Btnbloodstock.Click
        switchPanel(Blood_stock)
    End Sub

    Private Sub btncheck1_Click(sender As Object, e As EventArgs) Handles btncheck1.Click
        switchPanel(Add_new_donor)
    End Sub

    Private Sub btncheck2_Click(sender As Object, e As EventArgs) Handles btncheck2.Click
        switchPanel(Donor_registration_rejected)
    End Sub

    Private Sub Btnnew_regis_Click(sender As Object, e As EventArgs) Handles btneligibilityform.Click
        switchPanel(Donation_eligibility_conditions)
    End Sub



End Class