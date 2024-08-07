Imports System.Drawing.Printing

Public Class Report_of_donated_blood_details

    Dim WithEvents PD As New PrintDocument
    Dim PPD As New PrintPreviewDialog

    Public Sub New()
        InitializeComponent()
    End Sub

    ' Function to receive data from the main form
    Public Sub SetReportData(id As String, age As String, collection As String, collectionSite As String, compo As String, expire As String, gender As String, storage As String, tested As String, volume As String, bloodType As String)
        txtID.Text = id
        txtage.Text = age
        txtcollection.Text = collection
        txtcollectionsite.Text = collectionSite
        txtcompo.Text = compo
        txtexpire.Text = expire
        txtgender.Text = gender
        txtstorage.Text = storage
        txttested.Text = tested
        txtvolume.Text = volume
        txtbloodtype.Text = bloodType
    End Sub

    Private Sub btnprint_Click(sender As Object, e As EventArgs) Handles btnprint.Click
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

    Private Function CapturePanel(panel As Panel) As Bitmap
        ' Create a bitmap with the size of the panel
        Dim bitmap As New Bitmap(panel.Width, panel.Height)

        ' Draw the panel content onto the bitmap
        panel.DrawToBitmap(bitmap, New Rectangle(0, 0, panel.Width, panel.Height))

        Return bitmap
    End Function

End Class