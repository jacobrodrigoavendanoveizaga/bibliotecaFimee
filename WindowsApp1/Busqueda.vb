﻿Imports System.IO
Imports DPFP
Imports DPFP.Capture
Imports MySql.Data.MySqlClient

Public Class Busqueda
    Implements DPFP.Capture.EventHandler
    Private template As DPFP.Template
    Private Captura As DPFP.Capture.Capture
    Private verificador As DPFP.Verification.Verification

    Protected Overridable Sub Init()
        Try
            Captura = New Capture()
            If Not Captura Is Nothing Then
                Captura.EventHandler = Me
                verificador = New Verification.Verification()
                template = New Template()
            Else
                MessageBox.Show("No se pudo instanciar la captura")
            End If
        Catch ex As Exception
            MessageBox.Show("No se pudo inicializar la captura")
        End Try
    End Sub

    Protected Sub iniciarCaptura()
        If Not Captura Is Nothing Then
            Try
                Captura.StartCapture()
            Catch ex As Exception
                MessageBox.Show("No se pudo iniciar la captura" + ex.Message)
            End Try
        End If
    End Sub

    Protected Sub pararCaptura()
        If Not Captura Is Nothing Then
            Try
                Captura.StopCapture()
            Catch ex As Exception
                MessageBox.Show("No se pudo detener la captura")
            End Try
        End If
    End Sub

    Private Sub ponerImagen(ByVal bmp)
        imagenHuella.Image = bmp 'metodo para rellenar la parte interna del recuadro para que aparesca la huella
    End Sub

    Protected Function ConvertirSampleaMapadeBits(ByVal Sample As DPFP.Sample) As Bitmap
        Dim convertidor As New DPFP.Capture.SampleConversion() 'Es una variable de tipo conversor de un dpfp.sample
        Dim mapaBits As Bitmap = Nothing
        convertidor.ConvertToPicture(Sample, mapaBits)
        Return mapaBits
    End Function

    Protected Function extraerCaracteristicas(ByVal Sample As DPFP.Sample, ByVal Purpose As DPFP.Processing.DataPurpose) As DPFP.FeatureSet 'va a extraer las caracteristicas de la huella para poder asignar a una variable para guardarla y cuando pongan el dedo comparara las caractiristicas
        Dim extractor As New DPFP.Processing.FeatureExtraction() 'va analizar si la huella esta bien puesta si no abra una retroalimentacion para poder verla
        Dim alimentacion As DPFP.Capture.CaptureFeedback = DPFP.Capture.CaptureFeedback.None
        Dim caracteristicas As New DPFP.FeatureSet()
        extractor.CreateFeatureSet(Sample, Purpose, alimentacion, caracteristicas)
        If (alimentacion = DPFP.Capture.CaptureFeedback.Good) Then
            Return caracteristicas
        Else
            Return Nothing
        End If
    End Function

    Public Sub OnComplete(Capture As Object, ReaderSerialNumber As String, Sample As Sample) Implements EventHandler.OnComplete
        ponerImagen(ConvertirSampleaMapadeBits(Sample))
        Dim caracteristicas As DPFP.FeatureSet = extraerCaracteristicas(Sample, DPFP.Processing.DataPurpose.Verification)
        If Not caracteristicas Is Nothing Then
            Dim result As New DPFP.Verification.Verification.Result()
            Dim builderconex As New MySqlConnectionStringBuilder()
            builderconex.Server = "localhost"
            builderconex.UserID = "root"
            builderconex.Password = "root"
            builderconex.Database = "fimee"
            Dim conexion As New MySqlConnection(builderconex.ToString())
            conexion.Open()
            Dim cmd As New MySqlCommand()
            cmd = conexion.CreateCommand
            cmd.CommandText = "SELECT * FROM usuarios"
            Dim read As MySqlDataReader
            read = cmd.ExecuteReader()
            Dim verificado As Boolean = False
            Dim nombre As String = ""
            While read.Read()
                Dim memoria As New MemoryStream(CType(read("huella"), Byte()))
                template.DeSerialize(memoria.ToArray)
                verificador.Verify(caracteristicas, template, result)
                If (result.Verified) Then
                    nombre = read("Nombre")
                    verificado = True
                    Exit While
                End If
            End While
            If (verificado) Then
                MessageBox.Show(nombre)
            Else
                MessageBox.Show("no se encontro ningun registro")
            End If
            read.Dispose()
            cmd.Dispose()
            conexion.Close()
            conexion.Dispose()
        End If
    End Sub

    Public Sub OnFingerGone(Capture As Object, ReaderSerialNumber As String) Implements EventHandler.OnFingerGone

    End Sub

    Public Sub OnFingerTouch(Capture As Object, ReaderSerialNumber As String) Implements EventHandler.OnFingerTouch

    End Sub

    Public Sub OnReaderConnect(Capture As Object, ReaderSerialNumber As String) Implements EventHandler.OnReaderConnect

    End Sub

    Public Sub OnReaderDisconnect(Capture As Object, ReaderSerialNumber As String) Implements EventHandler.OnReaderDisconnect

    End Sub

    Public Sub OnSampleQuality(Capture As Object, ReaderSerialNumber As String, CaptureFeedback As CaptureFeedback) Implements EventHandler.OnSampleQuality

    End Sub

    Private Sub Busqueda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Init()
        iniciarCaptura()
    End Sub

    Private Sub Busqueda_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        pararCaptura()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form1.Show()
    End Sub

End Class