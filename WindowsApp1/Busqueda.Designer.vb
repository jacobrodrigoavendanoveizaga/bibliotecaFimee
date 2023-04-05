<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Busqueda
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Busqueda))
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.imagenHuella = New System.Windows.Forms.PictureBox()
        Me.GroupBoxImage = New System.Windows.Forms.GroupBox()
        Me.LabelID1 = New System.Windows.Forms.Label()
        Me.PictureBoxUserImage1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LabelObservations1 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.LabelMail1 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.LabelCu1 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.LabelAddress1 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.LabelCi1 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.LabelCareer1 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.LabelCity = New System.Windows.Forms.Label()
        Me.LabelSurname1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LabelMobile1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ButtonClear = New System.Windows.Forms.Button()
        Me.LabelName1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnPrestar2 = New System.Windows.Forms.Button()
        Me.GroupBox5.SuspendLayout()
        CType(Me.imagenHuella, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxImage.SuspendLayout()
        CType(Me.PictureBoxUserImage1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox5
        '
        Me.GroupBox5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox5.Controls.Add(Me.imagenHuella)
        Me.GroupBox5.Location = New System.Drawing.Point(74, 53)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(148, 149)
        Me.GroupBox5.TabIndex = 29
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Huella"
        '
        'imagenHuella
        '
        Me.imagenHuella.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.imagenHuella.Image = Global.WindowsApp1.My.Resources.Resources.huella_2
        Me.imagenHuella.Location = New System.Drawing.Point(14, 19)
        Me.imagenHuella.Name = "imagenHuella"
        Me.imagenHuella.Size = New System.Drawing.Size(117, 112)
        Me.imagenHuella.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imagenHuella.TabIndex = 0
        Me.imagenHuella.TabStop = False
        '
        'GroupBoxImage
        '
        Me.GroupBoxImage.Controls.Add(Me.LabelID1)
        Me.GroupBoxImage.Controls.Add(Me.PictureBoxUserImage1)
        Me.GroupBoxImage.Location = New System.Drawing.Point(264, 21)
        Me.GroupBoxImage.Name = "GroupBoxImage"
        Me.GroupBoxImage.Size = New System.Drawing.Size(206, 208)
        Me.GroupBoxImage.TabIndex = 30
        Me.GroupBoxImage.TabStop = False
        Me.GroupBoxImage.Text = "Imagen y ID"
        '
        'LabelID1
        '
        Me.LabelID1.AutoSize = True
        Me.LabelID1.Location = New System.Drawing.Point(17, 184)
        Me.LabelID1.Name = "LabelID1"
        Me.LabelID1.Size = New System.Drawing.Size(84, 13)
        Me.LabelID1.TabIndex = 2
        Me.LabelID1.Text = "ID: __________"
        '
        'PictureBoxUserImage1
        '
        Me.PictureBoxUserImage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBoxUserImage1.Location = New System.Drawing.Point(20, 21)
        Me.PictureBoxUserImage1.Name = "PictureBoxUserImage1"
        Me.PictureBoxUserImage1.Size = New System.Drawing.Size(166, 160)
        Me.PictureBoxUserImage1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxUserImage1.TabIndex = 0
        Me.PictureBoxUserImage1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.btnPrestar2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.LabelObservations1)
        Me.GroupBox1.Controls.Add(Me.Label36)
        Me.GroupBox1.Controls.Add(Me.Label34)
        Me.GroupBox1.Controls.Add(Me.LabelMail1)
        Me.GroupBox1.Controls.Add(Me.Label23)
        Me.GroupBox1.Controls.Add(Me.Label24)
        Me.GroupBox1.Controls.Add(Me.LabelCu1)
        Me.GroupBox1.Controls.Add(Me.Label26)
        Me.GroupBox1.Controls.Add(Me.Label27)
        Me.GroupBox1.Controls.Add(Me.LabelAddress1)
        Me.GroupBox1.Controls.Add(Me.Label29)
        Me.GroupBox1.Controls.Add(Me.Label30)
        Me.GroupBox1.Controls.Add(Me.LabelCi1)
        Me.GroupBox1.Controls.Add(Me.Label32)
        Me.GroupBox1.Controls.Add(Me.Label33)
        Me.GroupBox1.Controls.Add(Me.LabelCareer1)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.LabelCity)
        Me.GroupBox1.Controls.Add(Me.LabelSurname1)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.LabelMobile1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.ButtonClear)
        Me.GroupBox1.Controls.Add(Me.LabelName1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 235)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(552, 263)
        Me.GroupBox1.TabIndex = 31
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del usuario"
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(464, 189)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(68, 21)
        Me.Button1.TabIndex = 31
        Me.Button1.Text = "RFID"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'LabelObservations1
        '
        Me.LabelObservations1.AutoSize = True
        Me.LabelObservations1.Location = New System.Drawing.Point(153, 208)
        Me.LabelObservations1.Name = "LabelObservations1"
        Me.LabelObservations1.Size = New System.Drawing.Size(61, 13)
        Me.LabelObservations1.TabIndex = 30
        Me.LabelObservations1.Text = "- - - - - - - - - "
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(130, 208)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(10, 13)
        Me.Label36.TabIndex = 29
        Me.Label36.Text = ":"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(35, 208)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(78, 13)
        Me.Label34.TabIndex = 28
        Me.Label34.Text = "Observaciones"
        '
        'LabelMail1
        '
        Me.LabelMail1.AutoSize = True
        Me.LabelMail1.Location = New System.Drawing.Point(153, 168)
        Me.LabelMail1.Name = "LabelMail1"
        Me.LabelMail1.Size = New System.Drawing.Size(61, 13)
        Me.LabelMail1.TabIndex = 27
        Me.LabelMail1.Text = "- - - - - - - - - "
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(130, 168)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(10, 13)
        Me.Label23.TabIndex = 26
        Me.Label23.Text = ":"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(35, 168)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(93, 13)
        Me.Label24.TabIndex = 25
        Me.Label24.Text = "Correo electrónico"
        '
        'LabelCu1
        '
        Me.LabelCu1.AutoSize = True
        Me.LabelCu1.Location = New System.Drawing.Point(153, 148)
        Me.LabelCu1.Name = "LabelCu1"
        Me.LabelCu1.Size = New System.Drawing.Size(61, 13)
        Me.LabelCu1.TabIndex = 24
        Me.LabelCu1.Text = "- - - - - - - - - "
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(130, 148)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(10, 13)
        Me.Label26.TabIndex = 23
        Me.Label26.Text = ":"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(35, 148)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(49, 13)
        Me.Label27.TabIndex = 22
        Me.Label27.Text = "Carnet U"
        '
        'LabelAddress1
        '
        Me.LabelAddress1.AutoSize = True
        Me.LabelAddress1.Location = New System.Drawing.Point(153, 188)
        Me.LabelAddress1.Name = "LabelAddress1"
        Me.LabelAddress1.Size = New System.Drawing.Size(61, 13)
        Me.LabelAddress1.TabIndex = 21
        Me.LabelAddress1.Text = "- - - - - - - - - "
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(130, 188)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(10, 13)
        Me.Label29.TabIndex = 20
        Me.Label29.Text = ":"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(35, 188)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(49, 13)
        Me.Label30.TabIndex = 19
        Me.Label30.Text = "Domicilio"
        '
        'LabelCi1
        '
        Me.LabelCi1.AutoSize = True
        Me.LabelCi1.Location = New System.Drawing.Point(153, 128)
        Me.LabelCi1.Name = "LabelCi1"
        Me.LabelCi1.Size = New System.Drawing.Size(61, 13)
        Me.LabelCi1.TabIndex = 18
        Me.LabelCi1.Text = "- - - - - - - - - "
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(130, 128)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(10, 13)
        Me.Label32.TabIndex = 17
        Me.Label32.Text = ":"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(36, 128)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(50, 13)
        Me.Label33.TabIndex = 16
        Me.Label33.Text = "Carnet Id"
        '
        'LabelCareer1
        '
        Me.LabelCareer1.AutoSize = True
        Me.LabelCareer1.Location = New System.Drawing.Point(153, 88)
        Me.LabelCareer1.Name = "LabelCareer1"
        Me.LabelCareer1.Size = New System.Drawing.Size(61, 13)
        Me.LabelCareer1.TabIndex = 15
        Me.LabelCareer1.Text = "- - - - - - - - - "
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(130, 88)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(10, 13)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = ":"
        '
        'LabelCity
        '
        Me.LabelCity.AutoSize = True
        Me.LabelCity.Location = New System.Drawing.Point(36, 88)
        Me.LabelCity.Name = "LabelCity"
        Me.LabelCity.Size = New System.Drawing.Size(41, 13)
        Me.LabelCity.TabIndex = 13
        Me.LabelCity.Text = "Carrera"
        '
        'LabelSurname1
        '
        Me.LabelSurname1.AutoSize = True
        Me.LabelSurname1.Location = New System.Drawing.Point(153, 68)
        Me.LabelSurname1.Name = "LabelSurname1"
        Me.LabelSurname1.Size = New System.Drawing.Size(61, 13)
        Me.LabelSurname1.TabIndex = 12
        Me.LabelSurname1.Text = "- - - - - - - - - "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(130, 68)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(10, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = ":"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(36, 68)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Apellidos"
        '
        'LabelMobile1
        '
        Me.LabelMobile1.AutoSize = True
        Me.LabelMobile1.Location = New System.Drawing.Point(153, 108)
        Me.LabelMobile1.Name = "LabelMobile1"
        Me.LabelMobile1.Size = New System.Drawing.Size(61, 13)
        Me.LabelMobile1.TabIndex = 9
        Me.LabelMobile1.Text = "- - - - - - - - - "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(130, 108)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(10, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = ":"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(36, 108)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Nº de celular"
        '
        'ButtonClear
        '
        Me.ButtonClear.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonClear.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ButtonClear.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.ButtonClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.ButtonClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.ButtonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonClear.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonClear.ForeColor = System.Drawing.Color.Black
        Me.ButtonClear.Location = New System.Drawing.Point(464, 226)
        Me.ButtonClear.Name = "ButtonClear"
        Me.ButtonClear.Size = New System.Drawing.Size(68, 21)
        Me.ButtonClear.TabIndex = 6
        Me.ButtonClear.Text = "Limpiar"
        Me.ButtonClear.UseVisualStyleBackColor = False
        '
        'LabelName1
        '
        Me.LabelName1.AutoSize = True
        Me.LabelName1.Location = New System.Drawing.Point(153, 48)
        Me.LabelName1.Name = "LabelName1"
        Me.LabelName1.Size = New System.Drawing.Size(61, 13)
        Me.LabelName1.TabIndex = 5
        Me.LabelName1.Text = "- - - - - - - - - "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(130, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(10, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = ":"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nombre(s)"
        '
        'btnPrestar2
        '
        Me.btnPrestar2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPrestar2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnPrestar2.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnPrestar2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnPrestar2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnPrestar2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrestar2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrestar2.ForeColor = System.Drawing.Color.Black
        Me.btnPrestar2.Location = New System.Drawing.Point(464, 148)
        Me.btnPrestar2.Name = "btnPrestar2"
        Me.btnPrestar2.Size = New System.Drawing.Size(68, 21)
        Me.btnPrestar2.TabIndex = 32
        Me.btnPrestar2.Text = "Prestar"
        Me.btnPrestar2.UseVisualStyleBackColor = False
        '
        'Busqueda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(572, 507)
        Me.Controls.Add(Me.GroupBoxImage)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox5)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Busqueda"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Biblioteca FIMEE"
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.imagenHuella, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxImage.ResumeLayout(False)
        Me.GroupBoxImage.PerformLayout()
        CType(Me.PictureBoxUserImage1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents imagenHuella As PictureBox
    Friend WithEvents GroupBoxImage As GroupBox
    Friend WithEvents LabelID1 As Label
    Friend WithEvents PictureBoxUserImage1 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents LabelObservations1 As Label
    Friend WithEvents Label36 As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents LabelMail1 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents LabelCu1 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents LabelAddress1 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents LabelCi1 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents LabelCareer1 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents LabelCity As Label
    Friend WithEvents LabelSurname1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents LabelMobile1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ButtonClear As Button
    Friend WithEvents LabelName1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnPrestar2 As Button
End Class
