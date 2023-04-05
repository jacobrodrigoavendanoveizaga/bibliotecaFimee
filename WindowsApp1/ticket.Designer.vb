<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ticket
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ticket))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LabelDataTime = New System.Windows.Forms.Label()
        Me.TimerTimeData = New System.Windows.Forms.Timer(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.LabelCity = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.LabelName2 = New System.Windows.Forms.Label()
        Me.LabelSurname2 = New System.Windows.Forms.Label()
        Me.LabelCareer2 = New System.Windows.Forms.Label()
        Me.LabelMobile2 = New System.Windows.Forms.Label()
        Me.LabelCI2 = New System.Windows.Forms.Label()
        Me.LabelCU2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(270, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "BIBLIOTECA DE LA FACULTAD DE INGENIERÍA"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(29, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(243, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "MECÁNICA - ELÉCTRICA - ELECTRÓNICA"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LabelDataTime
        '
        Me.LabelDataTime.AutoSize = True
        Me.LabelDataTime.Location = New System.Drawing.Point(54, 57)
        Me.LabelDataTime.Name = "LabelDataTime"
        Me.LabelDataTime.Size = New System.Drawing.Size(183, 13)
        Me.LabelDataTime.TabIndex = 4
        Me.LabelDataTime.Text = "Hora 00:00:00 Fecha 00  mmm, 0000"
        '
        'TimerTimeData
        '
        Me.TimerTimeData.Enabled = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(71, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 15)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Ticket de pedido de libro"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 70)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 15)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Datos del usuario"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(202, 168)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(10, 13)
        Me.Label26.TabIndex = 35
        Me.Label26.Text = ":"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(158, 168)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(49, 13)
        Me.Label27.TabIndex = 34
        Me.Label27.Text = "Carnet U"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(65, 168)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(10, 13)
        Me.Label32.TabIndex = 33
        Me.Label32.Text = ":"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(12, 168)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(50, 13)
        Me.Label33.TabIndex = 32
        Me.Label33.Text = "Carnet Id"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(65, 128)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(10, 13)
        Me.Label10.TabIndex = 31
        Me.Label10.Text = ":"
        '
        'LabelCity
        '
        Me.LabelCity.AutoSize = True
        Me.LabelCity.Location = New System.Drawing.Point(12, 128)
        Me.LabelCity.Name = "LabelCity"
        Me.LabelCity.Size = New System.Drawing.Size(41, 13)
        Me.LabelCity.TabIndex = 30
        Me.LabelCity.Text = "Carrera"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(65, 108)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(10, 13)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = ":"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 108)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 13)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Apellidos"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(80, 148)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(10, 13)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = ":"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 148)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 13)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Nº de celular"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(65, 88)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(10, 13)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = ":"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(12, 88)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(55, 13)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "Nombre(s)"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(12, 191)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(84, 15)
        Me.Label12.TabIndex = 36
        Me.Label12.Text = "Datos del libro"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(43, 235)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(10, 13)
        Me.Label13.TabIndex = 40
        Me.Label13.Text = ":"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(12, 235)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(35, 13)
        Me.Label14.TabIndex = 39
        Me.Label14.Text = "Título"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(43, 215)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(10, 13)
        Me.Label15.TabIndex = 38
        Me.Label15.Text = ":"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(12, 215)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(32, 13)
        Me.Label16.TabIndex = 37
        Me.Label16.Text = "Autor"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(65, 255)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(157, 13)
        Me.Label18.TabIndex = 42
        Me.Label18.Text = "_________________________"
        '
        'LabelName2
        '
        Me.LabelName2.AutoSize = True
        Me.LabelName2.Location = New System.Drawing.Point(81, 88)
        Me.LabelName2.Name = "LabelName2"
        Me.LabelName2.Size = New System.Drawing.Size(61, 13)
        Me.LabelName2.TabIndex = 43
        Me.LabelName2.Text = "- - - - - - - - - "
        '
        'LabelSurname2
        '
        Me.LabelSurname2.AutoSize = True
        Me.LabelSurname2.Location = New System.Drawing.Point(81, 108)
        Me.LabelSurname2.Name = "LabelSurname2"
        Me.LabelSurname2.Size = New System.Drawing.Size(61, 13)
        Me.LabelSurname2.TabIndex = 44
        Me.LabelSurname2.Text = "- - - - - - - - - "
        '
        'LabelCareer2
        '
        Me.LabelCareer2.AutoSize = True
        Me.LabelCareer2.Location = New System.Drawing.Point(81, 128)
        Me.LabelCareer2.Name = "LabelCareer2"
        Me.LabelCareer2.Size = New System.Drawing.Size(61, 13)
        Me.LabelCareer2.TabIndex = 45
        Me.LabelCareer2.Text = "- - - - - - - - - "
        '
        'LabelMobile2
        '
        Me.LabelMobile2.AutoSize = True
        Me.LabelMobile2.Location = New System.Drawing.Point(98, 148)
        Me.LabelMobile2.Name = "LabelMobile2"
        Me.LabelMobile2.Size = New System.Drawing.Size(61, 13)
        Me.LabelMobile2.TabIndex = 46
        Me.LabelMobile2.Text = "- - - - - - - - - "
        '
        'LabelCI2
        '
        Me.LabelCI2.AutoSize = True
        Me.LabelCI2.Location = New System.Drawing.Point(73, 168)
        Me.LabelCI2.Name = "LabelCI2"
        Me.LabelCI2.Size = New System.Drawing.Size(61, 13)
        Me.LabelCI2.TabIndex = 47
        Me.LabelCI2.Text = "- - - - - - - - - "
        '
        'LabelCU2
        '
        Me.LabelCU2.AutoSize = True
        Me.LabelCU2.Location = New System.Drawing.Point(211, 168)
        Me.LabelCU2.Name = "LabelCU2"
        Me.LabelCU2.Size = New System.Drawing.Size(61, 13)
        Me.LabelCU2.TabIndex = 48
        Me.LabelCU2.Text = "- - - - - - - - - "
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Location = New System.Drawing.Point(51, 215)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(1)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(225, 13)
        Me.TextBox1.TabIndex = 49
        '
        'TextBox2
        '
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Location = New System.Drawing.Point(51, 235)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(0)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(225, 13)
        Me.TextBox2.TabIndex = 50
        '
        'btnImprimir
        '
        Me.btnImprimir.BackColor = System.Drawing.Color.White
        Me.btnImprimir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnImprimir.FlatAppearance.BorderSize = 0
        Me.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImprimir.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnImprimir.Location = New System.Drawing.Point(101, 271)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(75, 23)
        Me.btnImprimir.TabIndex = 51
        Me.btnImprimir.Text = "Firmar"
        Me.btnImprimir.UseVisualStyleBackColor = False
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'ticket
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(286, 328)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.LabelCU2)
        Me.Controls.Add(Me.LabelCI2)
        Me.Controls.Add(Me.LabelMobile2)
        Me.Controls.Add(Me.LabelCareer2)
        Me.Controls.Add(Me.LabelSurname2)
        Me.Controls.Add(Me.LabelName2)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.Label33)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.LabelCity)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LabelDataTime)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ticket"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ticket"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LabelDataTime As Label
    Friend WithEvents TimerTimeData As Timer
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents LabelCity As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents LabelName2 As Label
    Friend WithEvents LabelSurname2 As Label
    Friend WithEvents LabelCareer2 As Label
    Friend WithEvents LabelMobile2 As Label
    Friend WithEvents LabelCI2 As Label
    Friend WithEvents LabelCU2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents btnImprimir As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
End Class
