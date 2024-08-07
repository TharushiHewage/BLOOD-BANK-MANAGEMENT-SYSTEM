Public Class Entrance_page
    Private Sub Entrance_page_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1_entrance.BackColor = Color.FromArgb(20, 0, 0, 0)

        lblwelcometo.BackColor = Color.Transparent
        lbllifeline.BackColor = Color.Transparent
        lblbloodbank.BackColor = Color.Transparent
        lblbegrateful.BackColor = Color.Transparent
        Lblgiveblood.BackColor = Color.Transparent

        lblwelcometo.ForeColor = Color.FromArgb(64, 0, 0)
        lbllifeline.ForeColor = Color.FromArgb(255, 255, 128)
        lblbloodbank.ForeColor = Color.Yellow
        lblbegrateful.ForeColor = Color.FromArgb(255, 255, 128)
        Lblgiveblood.ForeColor = Color.Yellow

    End Sub


    Private Sub btngetstarted_Click(sender As Object, e As EventArgs) Handles btngetstarted.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub lblexit_Click_1(sender As Object, e As EventArgs) Handles lblexit.Click
        Application.Exit()
    End Sub


End Class