Imports MySql.Data.MySqlClient
Imports DPFP
Imports DPFP.Capture
Imports System.Text
Imports System.IO
Imports System.Runtime.InteropServices

Public Class Form1

    Implements DPFP.Capture.EventHandler

    'server=localhost; user=yout_database_user; password=your_database_password; database=your_database_name
    Dim Connection As New MySqlConnection("server=localhost; port=3306; user=root; password=root; database=fimeeerfid")
    Dim MySQLCMD As New MySqlCommand
    Dim MySQLDA As New MySqlDataAdapter
    Dim DT As New DataTable
    Dim Table_Name As String = "fimeeerfidone" 'name the table
    Dim Data As Integer

    Dim LoadImagesStr As Boolean = False
    Dim IDRam As String
    Dim IMG_FileNameInput As String
    Dim StatusInput As String = "Save"
    Dim SqlCmdSearchstr As String

    Public Shared StrSerialIn As String
    Dim GetID As Boolean = False
    Dim ViewUserData As Boolean = False

    Private Captura As DPFP.Capture.Capture
    Private Enroller As DPFP.Processing.Enrollment
    Private Delegate Sub _delegadoMuestra(ByVal text As String)
    'Private Delegate Sub _delegadoControles()
    Private template As DPFP.Template

    Dim DATOS As IDataObject
    Dim IMAGEN As Image
    Dim CARPETA As String
    Dim FECHA As String = DateTime.Now.ToShortDateString().Replace("/", "_") + "_" + DateTime.Now.ToLongTimeString().Replace(":", "_")
    Dim DIRECTORIO As String = "C:\Users\pikachu\Pictures" ' AQUI COLOCA LA RUTA A TU ESCRITORIO
    Dim DESTINO As String
    Dim CONTADOR As Integer = 1
    Dim CARPETAS_DIARIAS As String
    Public Const WM_CAP As Short = &H400S
    Public Const WM_CAP_DLG_VIDEOFORMAT As Integer = WM_CAP + 41
    Public Const WM_CAP_DRIVER_CONNECT As Integer = WM_CAP + 10
    Public Const WM_CAP_DRIVER_DISCONNECT As Integer = WM_CAP + 11
    Public Const WM_CAP_EDIT_COPY As Integer = WM_CAP + 30
    Public Const WM_CAP_SEQUENCE As Integer = WM_CAP + 62
    Public Const WM_CAP_FILE_SAVEAS As Integer = WM_CAP + 23
    Public Const WM_CAP_SET_PREVIEW As Integer = WM_CAP + 50
    Public Const WM_CAP_SET_PREVIEWRATE As Integer = WM_CAP + 52
    Public Const WM_CAP_SET_SCALE As Integer = WM_CAP + 53
    Public Const WS_CHILD As Integer = &H40000000
    Public Const WS_VISIBLE As Integer = &H10000000
    Public Const SWP_NOMOVE As Short = &H2S
    Public Const SWP_NOSIZE As Short = 1
    Public Const SWP_NOZORDER As Short = &H4S
    Public Const HWND_BOTTOM As Short = 1
    Public Const WM_CAP_STOP As Integer = WM_CAP + 68

    Public iDevice As Integer = 0 ' Current device ID
    Public hHwnd As Integer ' Handle to preview window

    Public Declare Function SendMessage Lib "user32" Alias "SendMessageA" _
        (ByVal hwnd As Integer, ByVal wMsg As Integer, ByVal wParam As Integer,
        <MarshalAs(UnmanagedType.AsAny)> ByVal lParam As Object) As Integer

    Public Declare Function SetWindowPos Lib "user32" Alias "SetWindowPos" (ByVal hwnd As Integer,
        ByVal hWndInsertAfter As Integer, ByVal x As Integer, ByVal y As Integer,
        ByVal cx As Integer, ByVal cy As Integer, ByVal wFlags As Integer) As Integer

    Public Declare Function DestroyWindow Lib "user32" (ByVal hndw As Integer) As Boolean

    Public Declare Function capCreateCaptureWindowA Lib "avicap32.dll" _
        (ByVal lpszWindowName As String, ByVal dwStyle As Integer,
        ByVal x As Integer, ByVal y As Integer, ByVal nWidth As Integer,
        ByVal nHeight As Short, ByVal hWndParent As Integer,
        ByVal nID As Integer) As Integer

    Public Declare Function capGetDriverDescriptionA Lib "avicap32.dll" (ByVal wDriver As Short,
        ByVal lpszName As String, ByVal cbName As Integer, ByVal lpszVer As String,
        ByVal cbVer As Integer) As Boolean

    Public sRuta As String

    Public labelNameT As String
    Public labelSurnameT As String
    Public labelCareerT As String
    Public labelMobileT As String
    Public labelCiT As String
    Public labelCuT As String




    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        PanelConnection.Visible = True
        PanelUserData.Visible = False
        PanelRegistrationandEditUserData.Visible = False
        ComboBoxBaudRate.SelectedIndex = 3

        Init()
        iniciarCaptura()
    End Sub

    Private Sub ShowData()
        Try
            Connection.Open()
        Catch ex As Exception
            MessageBox.Show("Error de conexión !!!" & vbCrLf & "Compruebe que el servidor este listo !!!", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End Try

        Try
            If LoadImagesStr = False Then
                MySQLCMD.CommandType = CommandType.Text
                MySQLCMD.CommandText = "SELECT Nombre, ID, Apellidos, Carrera, Celular, CarnetId, CarnetU, Correo, Domicilio, Observaciones FROM " & Table_Name & " ORDER BY Nombre"
                MySQLDA = New MySqlDataAdapter(MySQLCMD.CommandText, Connection)
                DT = New DataTable
                Data = MySQLDA.Fill(DT)
                If Data > 0 Then
                    DataGridView1.DataSource = Nothing
                    DataGridView1.DataSource = DT
                    DataGridView1.Columns(2).DefaultCellStyle.Format = "c"
                    DataGridView1.DefaultCellStyle.ForeColor = Color.Black
                    DataGridView1.ClearSelection()
                Else
                    DataGridView1.DataSource = DT
                End If
            Else
                MySQLCMD.CommandType = CommandType.Text
                MySQLCMD.CommandText = "SELECT Images FROM " & Table_Name & " WHERE ID LIKE '" & IDRam & "'"
                MySQLDA = New MySqlDataAdapter(MySQLCMD.CommandText, Connection)
                DT = New DataTable
                Data = MySQLDA.Fill(DT)
                If Data > 0 Then
                    Dim ImgArray() As Byte = DT.Rows(0).Item("Images")
                    Dim lmgStr As New System.IO.MemoryStream(ImgArray)
                    PictureBoxImagePreview.Image = Image.FromStream(lmgStr)
                    PictureBoxImagePreview.SizeMode = PictureBoxSizeMode.Zoom
                    lmgStr.Close()
                End If
                LoadImagesStr = False
            End If
        Catch ex As Exception
            MsgBox("Error al cargar la base de datos !!!" & vbCr & ex.Message, MsgBoxStyle.Critical, "Mensaje de Error")
            Connection.Close()
            Return
        End Try

        DT = Nothing
        Connection.Close()
    End Sub

    Private Sub ShowDataUser()
        Try
            Connection.Open()
        Catch ex As Exception
            MessageBox.Show("Error de conexión !!!" & vbCrLf & "Compruebe que el servidor este listo !!!", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End Try

        Try
            MySQLCMD.CommandType = CommandType.Text
            MySQLCMD.CommandText = "SELECT * FROM " & Table_Name & " WHERE ID LIKE '" & LabelID.Text.Substring(5, LabelID.Text.Length - 5) & "'"
            MySQLDA = New MySqlDataAdapter(MySQLCMD.CommandText, Connection)
            DT = New DataTable
            Data = MySQLDA.Fill(DT)
            If Data > 0 Then
                Dim ImgArray() As Byte = DT.Rows(0).Item("Images")
                Dim lmgStr As New System.IO.MemoryStream(ImgArray)
                PictureBoxUserImage.Image = Image.FromStream(lmgStr)
                lmgStr.Close()

                LabelID.Text = "ID : " & DT.Rows(0).Item("ID")
                LabelName.Text = DT.Rows(0).Item("Nombre")
                LabelSurname.Text = DT.Rows(0).Item("Apellidos")
                LabelCareer.Text = DT.Rows(0).Item("Carrera")
                LabelMobile.Text = DT.Rows(0).Item("Celular")
                LabelCi.Text = DT.Rows(0).Item("CarnetId")
                LabelCu.Text = DT.Rows(0).Item("CarnetU")
                LabelMail.Text = DT.Rows(0).Item("Correo")
                LabelAddress.Text = DT.Rows(0).Item("Domicilio")
                LabelObservations.Text = DT.Rows(0).Item("Observaciones")
            Else
                MsgBox("ID no encontrado !!!" & vbCr & "Por favor, registre su identificación.", MsgBoxStyle.Information, "Mensaje de Información")
            End If
        Catch ex As Exception
            MsgBox("Error al cargar la base de datos !!!" & vbCr & ex.Message, MsgBoxStyle.Critical, "Mensaje de Error")
            Connection.Close()
            Return
        End Try

        DT = Nothing
        Connection.Close()
    End Sub

    Private Sub ClearInputUpdateData()
        TextBoxName.Text = ""
        LabelGetID.Text = "________"
        TextBoxSurname.Text = ""
        TextBoxCareer.Text = ""
        TextBoxMobile.Text = ""
        TextBoxCi.Text = ""
        TextBoxCu.Text = ""
        TextBoxMail.Text = ""
        TextBoxAddress.Text = ""
        TextBoxObservations.Text = ""
        PictureBoxImageInput.Image = My.Resources.userimage2
        imagenHuella.Image = My.Resources.huella_2
        Enroller.Clear()
        pararCaptura()
        iniciarCaptura()
        vecesDedo.ResetText()
    End Sub

    Private Sub ButtonConnection_Click(sender As Object, e As EventArgs) Handles ButtonConnection.Click
        PictureBoxSelect.Top = ButtonConnection.Top
        PanelUserData.Visible = False
        PanelRegistrationandEditUserData.Visible = False
        PanelConnection.Visible = True
    End Sub

    Private Sub ButtonUserData_Click(sender As Object, e As EventArgs) Handles ButtonUserData.Click
        If TimerSerialIn.Enabled = False Then
            MsgBox("Error al abrir los datos de usuario !!!" & vbCr & "Haga clic en el menú Conexión y, a continuación, haga clic en el botón Conectar.", MsgBoxStyle.Information, "Información")
            Return
        Else
            StrSerialIn = ""
            ViewUserData = True
            PictureBoxSelect.Top = ButtonUserData.Top
            PanelRegistrationandEditUserData.Visible = False
            PanelConnection.Visible = False
            PanelUserData.Visible = True
        End If
    End Sub

    Private Sub ButtonRegistration_Click(sender As Object, e As EventArgs) Handles ButtonRegistration.Click
        StrSerialIn = ""
        ViewUserData = False
        PictureBoxSelect.Top = ButtonRegistration.Top
        PanelConnection.Visible = False
        PanelUserData.Visible = False
        PanelRegistrationandEditUserData.Visible = True
        ShowData()
    End Sub

    Private Sub PanelConnection_Paint(sender As Object, e As PaintEventArgs) Handles PanelConnection.Paint
        e.Graphics.DrawRectangle(New Pen(Color.LightGray, 2), PanelConnection.ClientRectangle)
    End Sub

    Private Sub PanelConnection_Resize(sender As Object, e As EventArgs) Handles PanelConnection.Resize
        PanelConnection.Invalidate()
    End Sub

    Private Sub PanelUserData_Paint(sender As Object, e As PaintEventArgs) Handles PanelUserData.Paint
        e.Graphics.DrawRectangle(New Pen(Color.LightGray, 2), PanelUserData.ClientRectangle)
    End Sub

    Private Sub PanelUserData_Resize(sender As Object, e As EventArgs) Handles PanelUserData.Resize
        PanelUserData.Invalidate()
    End Sub

    Private Sub PanelRegistrationandEditUserData_Paint(sender As Object, e As PaintEventArgs) Handles PanelRegistrationandEditUserData.Paint
        e.Graphics.DrawRectangle(New Pen(Color.LightGray, 2), PanelRegistrationandEditUserData.ClientRectangle)
    End Sub

    Private Sub PanelRegistrationandEditUserData_Resize(sender As Object, e As EventArgs) Handles PanelRegistrationandEditUserData.Resize
        PanelRegistrationandEditUserData.Invalidate()
    End Sub

    Private Sub ButtonScanPort_Click(sender As Object, e As EventArgs) Handles ButtonScanPort.Click
        ComboBoxPort.Items.Clear()
        Dim myPort As Array
        Dim i As Integer
        myPort = IO.Ports.SerialPort.GetPortNames()
        ComboBoxPort.Items.AddRange(myPort)
        i = ComboBoxPort.Items.Count
        i = i - i
        Try
            ComboBoxPort.SelectedIndex = i
        Catch ex As Exception
            MsgBox("Puerto Com no detectado", MsgBoxStyle.Critical, "Mensaje de error")
            ComboBoxPort.Text = ""
            ComboBoxPort.Items.Clear()
            Return
        End Try
        ComboBoxPort.DroppedDown = True
    End Sub

    Private Sub ButtonScanPort_MouseHover(sender As Object, e As EventArgs) Handles ButtonScanPort.MouseHover
        ButtonScanPort.ForeColor = Color.White
    End Sub

    Private Sub ButtonScanPort_MouseLeave(sender As Object, e As EventArgs) Handles ButtonScanPort.MouseLeave
        ButtonScanPort.ForeColor = Color.FromArgb(0, 0, 0)
    End Sub

    Private Sub ButtonConnect_Click(sender As Object, e As EventArgs) Handles ButtonConnect.Click
        If ButtonConnect.Text = "Conectar" Then
            SerialPort1.BaudRate = ComboBoxBaudRate.SelectedItem
            SerialPort1.PortName = ComboBoxPort.SelectedItem
            Try
                SerialPort1.Open()
                TimerSerialIn.Start()
                ButtonConnect.Text = "Desconectar"
                PictureBoxStatusConnect.Image = My.Resources.green
            Catch ex As Exception
                MsgBox("Error al conectarse !!!" & vbCr & "Lector de tarjetas no detectado.", MsgBoxStyle.Critical, "Mensaje de Error")
                PictureBoxStatusConnect.Image = My.Resources.red
            End Try
        ElseIf ButtonConnect.Text = "Desconectar" Then
            PictureBoxStatusConnect.Image = My.Resources.red
            ButtonConnect.Text = "Conectar"
            LabelConectionStatus.Text = "Estado de Conexión : Desconectado"
            TimerSerialIn.Stop()
            SerialPort1.Close()
        End If
    End Sub

    Private Sub ButtonConnect_MouseHover(sender As Object, e As EventArgs) Handles ButtonConnect.MouseHover
        ButtonConnect.ForeColor = Color.White
    End Sub

    Private Sub ButtonConnect_MouseLeave(sender As Object, e As EventArgs) Handles ButtonConnect.MouseLeave
        ButtonConnect.ForeColor = Color.FromArgb(0, 0, 0)
    End Sub

    Private Sub ButtonClear_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click
        LabelID.Text = "ID : ________"
        LabelName.Text = "- - - - - - - - - - "
        LabelSurname.Text = "- - - - - - - - - - "
        LabelCareer.Text = "- - - - - - - - - - "
        LabelMobile.Text = "- - - - - - - - - - "
        LabelCi.Text = "- - - - - - - - - - "
        LabelCu.Text = "- - - - - - - - - - "
        LabelMail.Text = "- - - - - - - - - - "
        LabelAddress.Text = "- - - - - - - - - - "
        LabelObservations.Text = "- - - - - - - - - - "
        PictureBoxUserImage.Image = Nothing
    End Sub

    Private Sub ButtonClear_MouseHover(sender As Object, e As EventArgs) Handles ButtonClear.MouseHover
        ButtonClear.ForeColor = Color.White
    End Sub

    Private Sub ButtonClear_MouseLeave(sender As Object, e As EventArgs) Handles ButtonClear.MouseLeave
        ButtonClear.ForeColor = Color.FromArgb(0, 0, 0)
    End Sub

    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click
        Dim mstream As New System.IO.MemoryStream()
        Dim arrImage() As Byte

        If TextBoxName.Text = "" Then
            MessageBox.Show("El campo de nombre no puede estar vacío !!!", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If TextBoxSurname.Text = "" Then
            MessageBox.Show("El campo de apellido no puede estar vacío !!!", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If TextBoxCareer.Text = "" Then
            MessageBox.Show("El campo de carrera no puede estar vacío !!!", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If TextBoxMobile.Text = "" Then
            MessageBox.Show("El campo de Nº de celular no puede estar vacío!!!", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If TextBoxCi.Text = "" Then
            MessageBox.Show("El campo de carnet de identidad no puede estar vacío !!!", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If TextBoxCu.Text = "" Then
            MessageBox.Show("El campo de carnet universitario no puede estar vacío !!!", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If TextBoxMail.Text = "" Then
            MessageBox.Show("El campo de correo electrónico no puede estar vacío !!!", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If TextBoxCareer.Text = "" Then
            MessageBox.Show("El campo de carrera no puede estar vacío !!!", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If TextBoxObservations.Text = "" Then
            MessageBox.Show("El campo de observaciones no puede estar vació !!!", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If StatusInput = "Save" Then
            If IMG_FileNameInput <> "" Then
                PictureBoxImageInput.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
                arrImage = mstream.GetBuffer()
            Else
                MessageBox.Show("La imagen no ha sido seleccionada !!!", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            Try
                Connection.Open()
            Catch ex As Exception
                MessageBox.Show("Coneción fallida !!!" & vbCrLf & "Compruebe que el servidor está listo !!!", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End Try

            Try
                MySQLCMD = New MySqlCommand
                With MySQLCMD
                    .CommandText = "INSERT INTO " & Table_Name & " (Nombre, ID, Apellidos, Carrera, Celular, Carnetid, Carnetu, Correo, Domicilio, Observaciones, Images, huella) VALUES (@nombre, @ID, @apellidos, @carrera, @celular, @carnetid, @carnetu, @correo, @domicilio, @observaciones, @images, @huella)"
                    .Connection = Connection
                    .Parameters.AddWithValue("@nombre", TextBoxName.Text)
                    .Parameters.AddWithValue("@id", LabelGetID.Text)
                    .Parameters.AddWithValue("@apellidos", TextBoxSurname.Text)
                    .Parameters.AddWithValue("@carrera", TextBoxCareer.Text)
                    .Parameters.AddWithValue("@celular", TextBoxMobile.Text)
                    .Parameters.AddWithValue("@carnetid", TextBoxCi.Text)
                    .Parameters.AddWithValue("@carnetu", TextBoxCu.Text)
                    .Parameters.AddWithValue("@correo", TextBoxMail.Text)
                    .Parameters.AddWithValue("@domicilio", TextBoxAddress.Text)
                    .Parameters.AddWithValue("@observaciones", TextBoxObservations.Text)
                    .Parameters.AddWithValue("@images", arrImage)
                    Using fm As New MemoryStream(template.Bytes)
                        .Parameters.AddWithValue("@huella", fm.ToArray())
                    End Using
                    .ExecuteNonQuery()
                End With
                MsgBox("Datos guardados exitosamente", MsgBoxStyle.Information, "Información")
                IMG_FileNameInput = ""
                ClearInputUpdateData()
            Catch ex As Exception
                MsgBox("No se pudieron guardar los datos !!!" & vbCr & ex.Message, MsgBoxStyle.Critical, "Mensaje de error")
                Connection.Close()
                Return
            End Try
            Connection.Close()

        Else

            If IMG_FileNameInput <> "" Then
                PictureBoxImageInput.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
                arrImage = mstream.GetBuffer()

                Try
                    Connection.Open()
                Catch ex As Exception
                    MessageBox.Show("Error de conexión !!!" & vbCrLf & "Compruebe que el servidor está listo !!!", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End Try

                Try
                    MySQLCMD = New MySqlCommand
                    With MySQLCMD
                        .CommandText = "UPDATE " & Table_Name & " SET  Nombre=@nombre,ID=@id,Apellidos=@apellidos,Carrera=@carrera,Celular=@celular,Carnetid=@carnetid,Carnetu=@carnetu,Correo=@correo,Observaciones=@observaciones,Images=@images, huella=@huella WHERE ID=@id "
                        .Connection = Connection
                        .Parameters.AddWithValue("@nombre", TextBoxName.Text)
                        .Parameters.AddWithValue("@id", LabelGetID.Text)
                        .Parameters.AddWithValue("@apellidos", TextBoxSurname.Text)
                        .Parameters.AddWithValue("@carrera", TextBoxCareer.Text)
                        .Parameters.AddWithValue("@celular", TextBoxMobile.Text)
                        .Parameters.AddWithValue("@carnetid", TextBoxCi.Text)
                        .Parameters.AddWithValue("@carnetu", TextBoxCu.Text)
                        .Parameters.AddWithValue("@correo", TextBoxMail.Text)
                        .Parameters.AddWithValue("@domicilio", TextBoxAddress.Text)
                        .Parameters.AddWithValue("@observaciones", TextBoxObservations.Text)
                        .Parameters.AddWithValue("@images", arrImage)
                        Using fm As New MemoryStream(template.Bytes)
                            .Parameters.AddWithValue("@huella", fm.ToArray())
                        End Using
                        .ExecuteNonQuery()
                    End With
                    MsgBox("Datos guardados satisfactoriamente", MsgBoxStyle.Information, "Información")
                    IMG_FileNameInput = ""
                    ButtonSave.Text = "Save"
                    ClearInputUpdateData()
                Catch ex As Exception
                    MsgBox("No se pudieron actualizar los datos !!!" & vbCr & ex.Message, MsgBoxStyle.Critical, "Mensaje de Error")
                    Connection.Close()
                    Return
                End Try
                Connection.Close()

            Else

                Try
                    Connection.Open()
                Catch ex As Exception
                    MessageBox.Show("Error de conexión !!!" & vbCrLf & "Compruebe que el servidor está listo !!!", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End Try

                Try
                    MySQLCMD = New MySqlCommand
                    With MySQLCMD
                        .CommandText = "UPDATE " & Table_Name & " SET  Nombre=@nombre,ID=@id,Apellidos=@apellidos,Carrera=@carrera,Celular=@celular,Carnetid=@carnetid,Carnetu=@carnetu,Correo=@correo,Domicilio=@domicilio,Observaciones=@observaciones WHERE ID=@id "
                        .Connection = Connection
                        .Parameters.AddWithValue("@nombre", TextBoxName.Text)
                        .Parameters.AddWithValue("@id", LabelGetID.Text)
                        .Parameters.AddWithValue("@apellidos", TextBoxSurname.Text)
                        .Parameters.AddWithValue("@carrera", TextBoxCareer.Text)
                        .Parameters.AddWithValue("@celular", TextBoxMobile.Text)
                        .Parameters.AddWithValue("@carnetid", TextBoxCi.Text)
                        .Parameters.AddWithValue("@carnetu", TextBoxCu.Text)
                        .Parameters.AddWithValue("@correo", TextBoxMail.Text)
                        .Parameters.AddWithValue("@domicilio", TextBoxAddress.Text)
                        .Parameters.AddWithValue("@observaciones", TextBoxObservations.Text)
                        .ExecuteNonQuery()
                    End With
                    MsgBox("Datos actualizados satisfactoriamente", MsgBoxStyle.Information, "Información")
                    ButtonSave.Text = "Save"
                    ClearInputUpdateData()
                Catch ex As Exception
                    MsgBox("No se pudieron actualizar los datos !!!" & vbCr & ex.Message, MsgBoxStyle.Critical, "Mensaje de Error")
                    Connection.Close()
                    Return
                End Try
                Connection.Close()
            End If
            StatusInput = "Save"
        End If
        PictureBoxImagePreview.Image = Nothing
        ShowData()
    End Sub

    Private Sub ButtonSave_MouseHover(sender As Object, e As EventArgs) Handles ButtonSave.MouseHover
        ButtonSave.ForeColor = Color.White
    End Sub

    Private Sub ButtonSave_MouseLeave(sender As Object, e As EventArgs) Handles ButtonSave.MouseLeave
        ButtonSave.ForeColor = Color.FromArgb(0, 0, 0)
    End Sub

    Private Sub ButtonClearForm_Click(sender As Object, e As EventArgs) Handles ButtonClearForm.Click
        ClearInputUpdateData()
    End Sub

    Private Sub ButtonClearForm_MouseHover(sender As Object, e As EventArgs) Handles ButtonClearForm.MouseHover
        ButtonClearForm.ForeColor = Color.White
    End Sub

    Private Sub ButtonClearForm_MouseLeave(sender As Object, e As EventArgs) Handles ButtonClearForm.MouseLeave
        ButtonClearForm.ForeColor = Color.FromArgb(0, 0, 0)
    End Sub

    Private Sub ButtonScanID_Click(sender As Object, e As EventArgs) Handles ButtonScanID.Click
        If TimerSerialIn.Enabled = True Then
            PanelReadingTagProcess.Visible = True
            GetID = True
            ButtonScanID.Enabled = False
        Else
            MsgBox("Error al abrir los datos de usuario !!!" & vbCr & "Haga clic en el menú Conexión y, a continuación, haga clic en el botón Conectar.", MsgBoxStyle.Critical, "Mensaje de Error")
        End If
    End Sub

    Private Sub ButtonScanID_MouseHover(sender As Object, e As EventArgs) Handles ButtonScanID.MouseHover
        ButtonScanID.ForeColor = Color.White
    End Sub

    Private Sub ButtonScanID_MouseLeave(sender As Object, e As EventArgs) Handles ButtonScanID.MouseLeave
        ButtonScanID.ForeColor = Color.FromArgb(0, 0, 0)
    End Sub

    'CODIGO DE CAPTURA CON LA CAMARA WEB

    Public Sub OpenPreviewWindowCliente()

        hHwnd = capCreateCaptureWindowA(iDevice, WS_VISIBLE Or WS_CHILD, 0, 0, 600, ' Open Preview window in picturebox
           480, Me.PictureBoxImageInput.Handle.ToInt32, 0)

        SendMessage(hHwnd, WM_CAP_DRIVER_CONNECT, iDevice, 0) ' Connect to device
        If SendMessage(hHwnd, WM_CAP_DRIVER_CONNECT, iDevice, 0) Then
            SendMessage(hHwnd, WM_CAP_SET_SCALE, True, 0) 'Set the preview scale
            SendMessage(hHwnd, WM_CAP_SET_PREVIEWRATE, 66, 0) 'Set the preview rate in milliseconds
            SendMessage(hHwnd, WM_CAP_SET_PREVIEW, True, 0) 'Start previewing the image from the camera
            SetWindowPos(hHwnd, HWND_BOTTOM, 0, 0, Me.PictureBoxImageInput.Width, Me.PictureBoxImageInput.Height, ' Resize window to fit in picturebox
                    SWP_NOMOVE Or SWP_NOZORDER)

        Else

            DestroyWindow(hHwnd) ' Error connecting to device close window

        End If
    End Sub

    Public Sub CapturarCliente()
        SendMessage(hHwnd, WM_CAP_EDIT_COPY, 0, 0) ' Copy image to clipboard
        DATOS = Clipboard.GetDataObject() ' Get image from clipboard and convert it to a bitmap

        IMAGEN = CType(DATOS.GetData(GetType(System.Drawing.Bitmap)), Image)
        Me.PictureBoxImageInput.Image = IMAGEN
        'GUARDAR.Visible = True
    End Sub



    Private Sub PictureBoxImageInput_Click(sender As Object, e As EventArgs) Handles PictureBoxImageInput.Click
        Me.OpenPreviewWindowCliente()
        PictureBoxImageInput.Enabled = False
    End Sub


    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.CapturarCliente()
        Me.ClosePreviewWindow()

        Try
            Dim sFD As New SaveFileDialog
            sFD.Title = "Guardar Imagen"
            sFD.Filter = "Imagenes|*.jpg;*.gif;*.png;*.bmp"
            If sFD.ShowDialog = Windows.Forms.DialogResult.OK Then
                Me.PictureBoxImageInput.Image.Save(System.IO.Path.GetFullPath(sFD.FileName))
            End If
        Catch ex As Exception
            MessageBox.Show(Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        PictureBoxImageInput.Enabled = True
        If (OpenFileDialog1.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            IMG_FileNameInput = OpenFileDialog1.FileName
            PictureBoxImageInput.ImageLocation = IMG_FileNameInput
        End If
    End Sub



    'Private Sub cmdcamara_Click(sender As Object, e As EventArgs) Handles cmdcamara.Click

    'End Sub

    Public Sub ClosePreviewWindow()

        SendMessage(hHwnd, WM_CAP_DRIVER_DISCONNECT, 0, 0) ' Disconnect from device
        DestroyWindow(hHwnd) ' close window
    End Sub


    Private Sub CheckBoxByName_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxByName.CheckedChanged
        If CheckBoxByName.Checked = True Then
            CheckBoxByID.Checked = False
        End If
        If CheckBoxByName.Checked = False Then
            CheckBoxByID.Checked = True
        End If
    End Sub

    Private Sub CheckBoxByID_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxByID.CheckedChanged
        If CheckBoxByID.Checked = True Then
            CheckBoxByName.Checked = False
        End If
        If CheckBoxByID.Checked = False Then
            CheckBoxByName.Checked = True
        End If
    End Sub

    Private Sub TextBoxSearch_TextChanged(sender As Object, e As EventArgs) Handles TextBoxSearch.TextChanged
        If CheckBoxByID.Checked = True Then
            If TextBoxSearch.Text = Nothing Then
                SqlCmdSearchstr = "SELECT Nombre, ID, Apellidos, Carrera, Celular, Carnetid, Carnetu, Correo, Domicilio, Observaciones " & Table_Name & " ORDER BY Name"
            Else
                SqlCmdSearchstr = "SELECT Nombre, ID, Apellidos, Carrera, Celular, Carnetid, Carnetu, Correo, Domicilio, Observaciones  " & Table_Name & " WHERE ID LIKE'" & TextBoxSearch.Text & "%'"
            End If
        End If
        If CheckBoxByName.Checked = True Then
            If TextBoxSearch.Text = Nothing Then
                SqlCmdSearchstr = "SELECT Nombre, ID, Apellidos, Carrera, Celular, Carnetid, Carnetu, Correo, Domicilio, Observaciones FROM " & Table_Name & " ORDER BY Name"
            Else
                SqlCmdSearchstr = "SELECT Nombre, ID, Apellidos, Carrera, Celular, Carnetid, Carnetu, Correo, Domicilio, Observaciones FROM " & Table_Name & " WHERE Name LIKE'" & TextBoxSearch.Text & "%'"
            End If
        End If

        Try
            Connection.Open()
        Catch ex As Exception
            MessageBox.Show("Error de conexión!!!" & vbCrLf & "Compruebe que el servidor está listo !!!", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End Try

        Try
            MySQLDA = New MySqlDataAdapter(SqlCmdSearchstr, Connection)
            DT = New DataTable
            Data = MySQLDA.Fill(DT)
            If Data > 0 Then
                DataGridView1.DataSource = Nothing
                DataGridView1.DataSource = DT
                DataGridView1.DefaultCellStyle.ForeColor = Color.Black
                DataGridView1.ClearSelection()
            Else
                DataGridView1.DataSource = DT
            End If
        Catch ex As Exception
            MsgBox("Error al buscar" & vbCr & ex.Message, MsgBoxStyle.Critical, "Mensaje de Error")
            Connection.Close()
        End Try
        Connection.Close()
    End Sub

    Private Sub DataGridView1_CellMouseDown(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseDown
        Try
            If AllCellsSelected(DataGridView1) = False Then
                If e.Button = MouseButtons.Left Then
                    DataGridView1.CurrentCell = DataGridView1(e.ColumnIndex, e.RowIndex)
                    Dim i As Integer
                    With DataGridView1
                        If e.RowIndex >= 0 Then
                            i = .CurrentRow.Index
                            LoadImagesStr = True
                            IDRam = .Rows(i).Cells("ID").Value.ToString
                            ShowData()
                        End If
                    End With
                End If
            End If
        Catch ex As Exception
            Return
        End Try
    End Sub

    Private Function AllCellsSelected(dgv As DataGridView) As Boolean
        AllCellsSelected = (DataGridView1.SelectedCells.Count = (DataGridView1.RowCount * DataGridView1.Columns.GetColumnCount(DataGridViewElementStates.Visible)))
    End Function

    Private Sub TimerTimeDate_Tick(sender As Object, e As EventArgs) Handles TimerTimeData.Tick
        LabelDataTime.Text = "Hora " & DateTime.Now.ToString("HH:mm:ss") & "  Fecha " & DateTime.Now.ToString("dd MMM, yyyy")
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        If DataGridView1.RowCount = 0 Then
            MsgBox("No se puede eliminar, los datos de la tabla están vacíos", MsgBoxStyle.Critical, "Mensaje de Error")
            Return
        End If

        If DataGridView1.SelectedRows.Count = 0 Then
            MsgBox("No se puede eliminar, seleccione los datos de tabla que desea eliminar", MsgBoxStyle.Critical, "Mensaje de Error")
            Return
        End If

        If MsgBox("Eliminar registro?", MsgBoxStyle.Question + MsgBoxStyle.OkCancel, "Confirmación") = MsgBoxResult.Cancel Then Return

        Try
            Connection.Open()
        Catch ex As Exception
            MessageBox.Show("Error de conexión !!!" & vbCrLf & "Compruebe que el servidor está listo !!!", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End Try

        Try
            If AllCellsSelected(DataGridView1) = True Then
                MySQLCMD.CommandType = CommandType.Text
                MySQLCMD.CommandText = "DELETE FROM " & Table_Name
                MySQLCMD.Connection = Connection
                MySQLCMD.ExecuteNonQuery()
            End If

            For Each row As DataGridViewRow In DataGridView1.SelectedRows
                If row.Selected = True Then
                    MySQLCMD.CommandType = CommandType.Text
                    MySQLCMD.CommandText = "DELETE FROM " & Table_Name & " WHERE ID='" & row.DataBoundItem(1).ToString & "'"
                    MySQLCMD.Connection = Connection
                    MySQLCMD.ExecuteNonQuery()
                End If
            Next
        Catch ex As Exception
            MsgBox("Error al eliminar" & vbCr & ex.Message, MsgBoxStyle.Critical, "Mensaje de Error")
            Connection.Close()
        End Try
        PictureBoxImagePreview.Image = Nothing
        Connection.Close()
        ShowData()
    End Sub

    Private Sub SelectAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectAllToolStripMenuItem.Click
        DataGridView1.SelectAll()
    End Sub

    Private Sub ClearSelectionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearSelectionToolStripMenuItem.Click
        DataGridView1.ClearSelection()
        PictureBoxImagePreview.Image = Nothing
    End Sub

    Private Sub RefreshToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        ShowData()
    End Sub

    Private Sub TimerSerialIn_Tick(sender As Object, e As EventArgs) Handles TimerSerialIn.Tick
        Try
            StrSerialIn = SerialPort1.ReadExisting
            LabelConectionStatus.Text = "Estado de Conexión : Conectado"
            If StrSerialIn <> "" Then
                If GetID = True Then
                    LabelGetID.Text = StrSerialIn
                    GetID = False
                    If LabelGetID.Text <> "________" Then
                        PanelReadingTagProcess.Visible = False
                        IDCheck()
                    End If
                End If
                If ViewUserData = True Then
                    ViewData()
                End If
            End If
        Catch ex As Exception
            TimerSerialIn.Stop()
            SerialPort1.Close()
            LabelConectionStatus.Text = "Estado de Conexión : Desconectado"
            PictureBoxStatusConnect.Image = My.Resources.red
            MsgBox("Error al conectarse !!!" & vbCr & "Lector de etiquetas Rfid no detectado.", MsgBoxStyle.Critical, "Mensaje de Error")
            ButtonConnect_Click(sender, e)
            Return
        End Try

        If PictureBoxStatusConnect.Visible = True Then
            PictureBoxStatusConnect.Visible = False
        ElseIf PictureBoxStatusConnect.Visible = False Then
            PictureBoxStatusConnect.Visible = True
        End If
    End Sub

    Private Sub IDCheck()
        Try
            Connection.Open()
        Catch ex As Exception
            MessageBox.Show("Error de conexión !!!" & vbCrLf & "Compruebe que el servidor está listo !!!", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End Try

        Try
            MySQLCMD.CommandType = CommandType.Text
            MySQLCMD.CommandText = "SELECT * FROM " & Table_Name & " WHERE ID LIKE '" & LabelGetID.Text & "'"
            MySQLDA = New MySqlDataAdapter(MySQLCMD.CommandText, Connection)
            DT = New DataTable
            Data = MySQLDA.Fill(DT)
            If Data > 0 Then
                If MsgBox("ID registered !" & vbCr & "¿Desea editar los datos? ?", MsgBoxStyle.Question + MsgBoxStyle.OkCancel, "Confirmación") = MsgBoxResult.Cancel Then
                    DT = Nothing
                    Connection.Close()
                    ButtonScanID.Enabled = True
                    GetID = False
                    LabelGetID.Text = "________"
                    Return
                Else
                    Dim ImgArray() As Byte = DT.Rows(0).Item("Images")
                    Dim lmgStr As New System.IO.MemoryStream(ImgArray)
                    PictureBoxImageInput.Image = Image.FromStream(lmgStr)
                    PictureBoxImageInput.SizeMode = PictureBoxSizeMode.Zoom

                    TextBoxName.Text = DT.Rows(0).Item("Nombre")
                    TextBoxSurname.Text = DT.Rows(0).Item("Apellidos")
                    TextBoxCareer.Text = DT.Rows(0).Item("Carrera")
                    TextBoxMobile.Text = DT.Rows(0).Item("Celular")
                    TextBoxCi.Text = DT.Rows(0).Item("CarnetId")
                    TextBoxCu.Text = DT.Rows(0).Item("CarnetU")
                    TextBoxMail.Text = DT.Rows(0).Item("Correo")
                    TextBoxAddress.Text = DT.Rows(0).Item("Domicilio")
                    TextBoxObservations.Text = DT.Rows(0).Item("Observaciones")
                    StatusInput = "Update"
                End If
            End If
        Catch ex As Exception
            MsgBox("Error al cargar la base de datos !!!" & vbCr & ex.Message, MsgBoxStyle.Critical, "Mensaje de Error")
            Connection.Close()
            Return
        End Try

        DT = Nothing
        Connection.Close()

        ButtonScanID.Enabled = True
        GetID = False
    End Sub

    Private Sub ViewData()
        LabelID.Text = "ID : " & StrSerialIn
        If LabelID.Text = "ID : ________" Then
            ViewData()
        Else
            ShowDataUser()
        End If
    End Sub

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        GroupBoxImage.Location = New Point((PanelUserData.Width / 2) - (GroupBoxImage.Width / 2), GroupBoxImage.Top)
        PanelReadingTagProcess.Location = New Point((PanelRegistrationandEditUserData.Width / 2) - (PanelReadingTagProcess.Width / 2), 106)
    End Sub

    Private Sub ButtonCloseReadingTag_Click(sender As Object, e As EventArgs) Handles ButtonCloseReadingTag.Click
        PanelReadingTagProcess.Visible = False
        ButtonScanID.Enabled = True
    End Sub

    'CODIGO DEL LECTOR DE HUELLAS



    Private Sub mostrarVeces(ByVal texto As String)
        If (vecesDedo.InvokeRequired) Then
            Dim deleg As New _delegadoMuestra(AddressOf mostrarVeces)
            Me.Invoke(deleg, New Object() {texto})
        Else
            vecesDedo.Text = texto
        End If
    End Sub

    Protected Overridable Sub Init()
        Try
            Captura = New Capture()
            If Not Captura Is Nothing Then
                Captura.EventHandler = Me
                Enroller = New DPFP.Processing.Enrollment()
                Dim text As New StringBuilder()
                text.AppendFormat("Necesitas pasar el dedo {0} veces", Enroller.FeaturesNeeded)
                vecesDedo.Text = text.ToString()
            Else
                MessageBox.Show("No se puede instanciar la captura")
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
                MessageBox.Show("No se pudo iniciar la captura")
            End Try
        End If
    End Sub

    Protected Sub pararCaptura()
        If Not Captura Is Nothing Then
            Try
                Captura.StopCapture()
            Catch ex As Exception
                MessageBox.Show("No se puede detener la captura")
            End Try
        End If
    End Sub

    Private Sub Form1_FormClosed(sebder As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        pararCaptura()
    End Sub


    Public Sub OnComplete(Capture As Object, ReaderSerialNumber As String, Sample As Sample) Implements EventHandler.OnComplete
        ponerImagen(ConvertirSampleaMapadeBits(Sample))
        Procesar(Sample)
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

    Protected Function ConvertirSampleaMapadeBits(ByVal Sample As DPFP.Sample) As Bitmap
        Dim convertidor As New DPFP.Capture.SampleConversion()
        Dim mapaBits As Bitmap = Nothing
        convertidor.ConvertToPicture(Sample, mapaBits)
        Return mapaBits
    End Function

    Private Sub ponerImagen(ByVal bmp)
        imagenHuella.Image = bmp
    End Sub

    Protected Function extraerCaracteristicas(ByVal Sample As DPFP.Sample, ByVal Purpose As DPFP.Processing.DataPurpose) As DPFP.FeatureSet
        Dim Extractor As New DPFP.Processing.FeatureExtraction
        Dim alimentacion As DPFP.Capture.CaptureFeedback = DPFP.Capture.CaptureFeedback.None
        Dim Caracteristicas As New DPFP.FeatureSet()
        Extractor.CreateFeatureSet(Sample, Purpose, alimentacion, Caracteristicas)
        If (alimentacion = DPFP.Capture.CaptureFeedback.Good) Then
            Return Caracteristicas
        Else
            Return Nothing
        End If

    End Function

    Protected Sub Procesar(ByVal Sample As DPFP.Sample)
        Dim caracteristicas As DPFP.FeatureSet = extraerCaracteristicas(Sample, DPFP.Processing.DataPurpose.Enrollment)
        If (Not caracteristicas Is Nothing) Then
            Try
                Enroller.AddFeatures(caracteristicas)
            Finally
                Dim text As New StringBuilder()
                text.AppendFormat("Necesitas pasar el dedo {0} veces", Enroller.FeaturesNeeded)
                mostrarVeces(text.ToString())
                Select Case Enroller.TemplateStatus
                    Case DPFP.Processing.Enrollment.Status.Ready
                        template = Enroller.Template
                        pararCaptura()
                    Case DPFP.Processing.Enrollment.Status.Failed
                        Enroller.Clear()
                        pararCaptura()
                        iniciarCaptura()
                End Select
            End Try
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        pararCaptura()
        Me.Hide()
        Dim ventanaBuscar As New Busqueda()
        ventanaBuscar.ShowDialog()
    End Sub

    Private Sub Form1_Leave(sender As Object, e As EventArgs) Handles MyBase.Leave
        pararCaptura()
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        Dim ruta As String
        Dim StrExport As String = ""

        For Each c As DataGridViewColumn In DataGridView1.Columns
            StrExport &= """" & c.HeaderText & ""","
        Next
        StrExport = StrExport.Substring(0, StrExport.Length - 1)
        StrExport &= Environment.NewLine
        'Dim columnas As Integer = DataGridView1.ColumnCount
        'Dim filas As Integer = DataGridView1.RowCount
        'Dim total As Integer = columnas * filas

        For Each r As DataGridViewRow In DataGridView1.Rows
            For Each c As DataGridViewCell In r.Cells
                If Not c.Value Is Nothing Then
                    StrExport &= """" & c.Value.ToString & ""","
                Else
                    StrExport &= """" & "" & ""","
                End If

            Next
            StrExport = StrExport.Substring(0, StrExport.Length - 1)
            StrExport &= Environment.NewLine
        Next

        Dim SaveFileDialog As SaveFileDialog = New SaveFileDialog
        SaveFileDialog.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
        SaveFileDialog.Filter = "Archivos CSV (*.CSV)|* .CSV"
        SaveFileDialog.FilterIndex = 2
        If SaveFileDialog.ShowDialog = DialogResult.OK Then
            ruta = SaveFileDialog.FileName
            MsgBox("exportado Correctamente", MsgBoxStyle.Information)
            Dim tw As IO.TextWriter = New IO.StreamWriter(ruta)
            tw.Write(StrExport)
            tw.Close()
        Else
            Return
        End If
    End Sub

    Private Sub btnPrestar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrestar.Click
        Dim ticket As New ticket()
        ticket.MostrarLabels(LabelName.Text, LabelSurname.Text, LabelCareer.Text, LabelMobile.Text, LabelCi.Text, LabelCu.Text)
        ticket.ShowDialog()

    End Sub




















    'Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBoxCu.TextChanged

    'End Sub

    'Private Sub ButtonFoto_Click(sender As Object, e As EventArgs)
    '    Timer1.Enabled = True
    '    Form2.Visible = True
    'End Sub

    'Private Sub ButtonFoto_Click_1(sender As Object, e As EventArgs) Handles ButtonFoto.Click
    '    Timer1.Enabled = True
    '    Form2.Visible = True
    'End Sub

    'Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
    '    If TimerSerialIn.Enabled = True Then
    '        Form3.Visible = True

    '        PictureBox3.Enabled = False
    '    Else
    '        MsgBox("Failed to open User Data !!!" & vbCr & "Click the Connection menu then click the Connect button.", MsgBoxStyle.Critical, "Error Message")
    '    End If
    'End Sub
    ' ESTO ES UN COMENTARIO DE PRUEBA

End Class
