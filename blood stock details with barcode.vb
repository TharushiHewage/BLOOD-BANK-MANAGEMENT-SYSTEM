Imports MessagingToolkit.Barcode
Imports System.Drawing.Printing
Public Class blood_stock_details_with_barcode

    Dim WithEvents PD As New PrintDocument
    Dim PPD As New PrintPreviewDialog

    Private Function CaptureForm(form As Form) As Bitmap
        'Create a bitmap with the size of the form
        Dim bitmap As New Bitmap(form.Width, form.Height)

        'Draw the form content onto the bitmap
        form.DrawToBitmap(bitmap, New Rectangle(0, 0, form.Width, form.Height))

        Return bitmap

    End Function
    Private Function CapturePanel(panel As Panel) As Bitmap
        ' Create a bitmap with the size of the panel
        Dim bitmap As New Bitmap(panel.Width, panel.Height)

        ' Draw the panel content onto the bitmap
        panel.DrawToBitmap(bitmap, New Rectangle(0, 0, panel.Width, panel.Height))

        Return bitmap
    End Function

    Private Sub btnprint_Click_1(sender As Object, e As EventArgs) Handles btnprint.Click
        ' Capture the panel content as an image
        Dim panelImage As Bitmap = CapturePanel(Panel1_bloodbaginfo)

        ' Assign captured image to print event
        AddHandler PD.PrintPage, Sub(s, args)
                                     ' Calculate the aspect ratio of the panel image
                                     Dim aspectRatio As Single = panelImage.Width / panelImage.Height

                                     ' Calculate the width and height that ensure the image fits within the page bounds
                                     Dim newWidth As Single = args.PageBounds.Width
                                     Dim newHeight As Single = newWidth / aspectRatio

                                     ' If the new height is greater than the page height, adjust to fit the height instead
                                     If newHeight > args.PageBounds.Height Then
                                         newHeight = args.PageBounds.Height
                                         newWidth = newHeight * aspectRatio
                                     End If

                                     ' Center the image within the page bounds
                                     Dim x As Single = args.PageBounds.Left + (args.PageBounds.Width - newWidth) / 2
                                     Dim y As Single = args.PageBounds.Top + (args.PageBounds.Height - newHeight) / 2

                                     ' Draw the scaled image onto the print document
                                     args.Graphics.DrawImage(panelImage, x, y, newWidth, newHeight)
                                 End Sub

        ' Set print preview dialog and show it
        PPD.Document = PD
        PPD.ShowDialog()
    End Sub

    Private Sub btnGenerateBarcode_Click_1(sender As Object, e As EventArgs) Handles btnGenerateBarcode.Click
        Dim Generator As New MessagingToolkit.Barcode.BarcodeEncoder
        Generator.BackColor = Color.White
        Generator.LabelFont = New Font("Arial", 7, FontStyle.Regular)
        Generator.IncludeLabel = True
        Generator.CustomLabel = txtID.Text ' Or any other relevant text
        Try
            PictureBox1.Image = New Bitmap(Generator.Encode(MessagingToolkit.Barcode.BarcodeFormat.Code93, txtID.Text))
        Catch ex As Exception

        End Try


    End Sub


    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        Dim SD As New SaveFileDialog
        SD.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.Desktop
        SD.FileName = txtID.Text
        SD.SupportMultiDottedExtensions = True
        SD.AddExtension = True
        SD.Filter = "PNG File|*.png"
        If SD.ShowDialog() = DialogResult.OK Then
            Try
                PictureBox1.Image.Save(SD.FileName, Imaging.ImageFormat.Png)

            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        PictureBox1.Image = Nothing
        txtID.Clear()
        txtage.Clear()
        txtcollection.Clear()
        txtcollectionsite.Clear()
        txtcompo.Clear()
        txtexpire.Clear()
        txtgender.Clear()
        txtstorage.Clear()
        txttested.Clear()
        txtvolume.Clear()
        txtbloodtype.Text = ""

        txtID.Focus()
    End Sub

    Private Sub btnreport_Click(sender As Object, e As EventArgs) Handles btnreport.Click
        ' Create a new instance of the report form
        Dim reportForm As New Report_of_donated_blood_details

        ' Pass the data from the current form to the report form
        reportForm.SetReportData(txtID.Text, txtage.Text, txtcollection.Text, txtcollectionsite.Text, txtcompo.Text, txtexpire.Text, txtgender.Text, txtstorage.Text, txttested.Text, txtvolume.Text, txtbloodtype.Text)

        ' Show the report form
        reportForm.ShowDialog()
    End Sub
End Class