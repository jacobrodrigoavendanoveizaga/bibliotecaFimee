Imports System.Text
Imports System.IO
Imports System.Drawing.Printing


Public Class ticket
    Public Property Printer As Object

    'Public labelNameT_Form1 As String
    'Public labelSurnameT_Form1 As String
    'Public labelCareerT_Form1 As String
    'Public labelMobileT_Form1 As String
    'Public labelCiT_Form1 As String
    'Public labelCuT_Form1 As String

    Private Sub TimerTimeDate_Tick(sender As Object, e As EventArgs) Handles TimerTimeData.Tick
        LabelDataTime.Text = "Hora " & DateTime.Now.ToString("HH:mm:ss") & "  Fecha " & DateTime.Now.ToString("dd MMM, yyyy")
        LabelDataTime.Text = "Hora " & DateTime.Now.ToString("HH:mm:ss") & "  Fecha " & DateTime.Now.ToString("dd MMM, yyyy")
    End Sub

    Private Sub ticket_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'LabelName2.Text = labelNameT_Form1
        'LabelSurname2.Text = labelSurnameT_Form1

        'LabelName2.Text = LabelName

    End Sub

    Public Sub MostrarLabels(ByVal LabelName As String, ByVal LabelSurname As String, ByVal LabelCareer As String, ByVal LabelMobile As String, ByVal LabelCi As String, ByVal LabelCu As String)
        LabelName2.Text = LabelName
        LabelSurname2.Text = LabelSurname
        LabelCareer2.Text = LabelCareer
        LabelMobile2.Text = LabelMobile
        LabelCI2.Text = LabelCi
        LabelCU2.Text = LabelCu
    End Sub

    Public Sub MostrarLabels2(ByVal LabelName1 As String, ByVal LabelSurname1 As String, ByVal LabelCareer1 As String, ByVal LabelMobile1 As String, ByVal LabelCi1 As String, ByVal LabelCu1 As String)
        LabelName2.Text = LabelName1
        LabelSurname2.Text = LabelSurname1
        LabelCareer2.Text = LabelCareer1
        LabelMobile2.Text = LabelMobile1
        LabelCI2.Text = LabelCi1
        LabelCU2.Text = LabelCu1
    End Sub

    'Dim g, mg As Graphics
    'Dim bmp As Bitmap

    'Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage
    '    e.Graphics.DrawImage(bmp, 0, 0)
    'End Sub

    'Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
    '    g = CreateGraphics()
    '    bmp = New Bitmap(Size.Width, Size.Height, g)
    '    mg = Graphics.FromImage(bmp)
    '    mg.CopyFromScreen(Location.X, Location.Y, 0, 0, Size)
    '    PrintPreviewDialog1.ShowDialog()
    'End Sub
    '---------------------------------------------------------------------------------------------------------------------------------------------
    'Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
    '    ' Crear un objeto PrintDocument
    '    Dim printDoc As New Printing.PrintDocument()

    '    ' Establecer el evento PrintPage para imprimir el contenido del formulario
    '    AddHandler printDoc.PrintPage, AddressOf PrintPageHandler

    '    ' Imprimir el documento
    '    printDoc.Print()
    'End Sub

    'Private Sub PrintPageHandler(ByVal sender As Object, ByVal e As Printing.PrintPageEventArgs)
    '    ' Capturar una imagen del contenido del formulario
    '    Dim bitmap As New Bitmap(Me.Width, Me.Height)
    '    Me.DrawToBitmap(bitmap, New Rectangle(7, 10, Me.Width, Me.Height))

    '    ' Imprimir la imagen en la página
    '    e.Graphics.DrawImage(bitmap, -3, -8)
    'End Sub


End Class