Imports System.Drawing.Printing
Imports System.Drawing
Public Class Eligible_form
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

    Private Sub btnprint_Click(sender As Object, e As EventArgs) Handles btnprint.Click
        ' Capture the panel content as an image
        Dim panelImage As Bitmap = CapturePanel(Panel1_donordetails)

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


End Class