Public Class splash_screen_loading
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Static progress As Integer = 0

        If progress < 100 Then
            progress += 4 ' You can adjust this value to change the speed of loading

            If progress <= 10 Then
                Lblloading.Text = "Entering...."
            ElseIf progress <= 30 Then
                Lblloading.Text = "Loading...."
            ElseIf progress <= 55 Then
                Lblloading.Text = "Loading...."
            ElseIf progress <= 70 Then
                Lblloading.Text = "Waiting...."
            ElseIf progress <= 100 Then
                Lblloading.Text = "Welcome...."
            End If

            ProgressBar1_splash.Value = progress
            Lblloading.Text &= " " & progress & "%"
        Else
            Me.Hide()
            dashboard_form.Show()
            Timer1.Enabled = False
            Timer1.Stop()
        End If
    End Sub



    Private Sub splash_screen_loading_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = 100 ' You can adjust this value to change the speed of loading
        Timer1.Enabled = True
        Timer1.Start()
    End Sub


End Class