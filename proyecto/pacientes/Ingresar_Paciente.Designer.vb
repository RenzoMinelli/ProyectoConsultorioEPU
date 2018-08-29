<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ingresar_Paciente
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txbNombre = New System.Windows.Forms.TextBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblCedula = New System.Windows.Forms.Label()
        Me.txbCedula = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblEnviadoPor = New System.Windows.Forms.Label()
        Me.txbEnviadoPor = New System.Windows.Forms.TextBox()
        Me.lblDireccionPersonal = New System.Windows.Forms.Label()
        Me.txbDireccionPersonal = New System.Windows.Forms.TextBox()
        Me.lblDireccionTrabajo = New System.Windows.Forms.Label()
        Me.txbDireccionTrabajo = New System.Windows.Forms.TextBox()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAgregarAntecedentes = New System.Windows.Forms.Button()
        Me.lblFechaSeleccionada = New System.Windows.Forms.Label()
        Me.mcFechaNacimiento = New System.Windows.Forms.MonthCalendar()
        Me.dgbPacientesId = New System.Windows.Forms.DataGridView()
        Me.txbTelefono = New System.Windows.Forms.TextBox()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.dgbPacientesCedulas = New System.Windows.Forms.DataGridView()
        Me.lblApellido = New System.Windows.Forms.Label()
        Me.txbApellido = New System.Windows.Forms.TextBox()
        Me.pbErrorCedula = New System.Windows.Forms.PictureBox()
        Me.lblAnuncio = New System.Windows.Forms.Label()
        CType(Me.dgbPacientesId, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgbPacientesCedulas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbErrorCedula, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txbNombre
        '
        Me.txbNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbNombre.Location = New System.Drawing.Point(343, 65)
        Me.txbNombre.Name = "txbNombre"
        Me.txbNombre.Size = New System.Drawing.Size(265, 35)
        Me.txbNombre.TabIndex = 1
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(8, 65)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(101, 29)
        Me.lblNombre.TabIndex = 1
        Me.lblNombre.Text = "Nombre"
        '
        'lblCedula
        '
        Me.lblCedula.AutoSize = True
        Me.lblCedula.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCedula.Location = New System.Drawing.Point(8, 22)
        Me.lblCedula.Name = "lblCedula"
        Me.lblCedula.Size = New System.Drawing.Size(338, 29)
        Me.lblCedula.TabIndex = 2
        Me.lblCedula.Text = "Cédula (sin puntos ni guiones)"
        '
        'txbCedula
        '
        Me.txbCedula.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbCedula.Location = New System.Drawing.Point(343, 22)
        Me.txbCedula.Name = "txbCedula"
        Me.txbCedula.Size = New System.Drawing.Size(265, 35)
        Me.txbCedula.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(706, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(208, 29)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Fecha Nacimiento"
        '
        'lblEnviadoPor
        '
        Me.lblEnviadoPor.AutoSize = True
        Me.lblEnviadoPor.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnviadoPor.Location = New System.Drawing.Point(8, 188)
        Me.lblEnviadoPor.Name = "lblEnviadoPor"
        Me.lblEnviadoPor.Size = New System.Drawing.Size(297, 29)
        Me.lblEnviadoPor.TabIndex = 6
        Me.lblEnviadoPor.Text = "Por quien fue enviado (op)"
        '
        'txbEnviadoPor
        '
        Me.txbEnviadoPor.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbEnviadoPor.Location = New System.Drawing.Point(343, 188)
        Me.txbEnviadoPor.Name = "txbEnviadoPor"
        Me.txbEnviadoPor.Size = New System.Drawing.Size(265, 35)
        Me.txbEnviadoPor.TabIndex = 4
        '
        'lblDireccionPersonal
        '
        Me.lblDireccionPersonal.AutoSize = True
        Me.lblDireccionPersonal.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDireccionPersonal.Location = New System.Drawing.Point(8, 229)
        Me.lblDireccionPersonal.Name = "lblDireccionPersonal"
        Me.lblDireccionPersonal.Size = New System.Drawing.Size(217, 29)
        Me.lblDireccionPersonal.TabIndex = 8
        Me.lblDireccionPersonal.Text = "Direccion Personal"
        '
        'txbDireccionPersonal
        '
        Me.txbDireccionPersonal.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbDireccionPersonal.Location = New System.Drawing.Point(343, 229)
        Me.txbDireccionPersonal.Name = "txbDireccionPersonal"
        Me.txbDireccionPersonal.Size = New System.Drawing.Size(265, 35)
        Me.txbDireccionPersonal.TabIndex = 5
        '
        'lblDireccionTrabajo
        '
        Me.lblDireccionTrabajo.AutoSize = True
        Me.lblDireccionTrabajo.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDireccionTrabajo.Location = New System.Drawing.Point(8, 270)
        Me.lblDireccionTrabajo.Name = "lblDireccionTrabajo"
        Me.lblDireccionTrabajo.Size = New System.Drawing.Size(279, 29)
        Me.lblDireccionTrabajo.TabIndex = 10
        Me.lblDireccionTrabajo.Text = "Direccion de trabajo (op)"
        '
        'txbDireccionTrabajo
        '
        Me.txbDireccionTrabajo.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbDireccionTrabajo.Location = New System.Drawing.Point(343, 270)
        Me.txbDireccionTrabajo.Name = "txbDireccionTrabajo"
        Me.txbDireccionTrabajo.Size = New System.Drawing.Size(265, 35)
        Me.txbDireccionTrabajo.TabIndex = 6
        '
        'btnAgregar
        '
        Me.btnAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.Image = Global.WindowsApplication1.My.Resources.Resources.checkmark
        Me.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAgregar.Location = New System.Drawing.Point(743, 467)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(146, 63)
        Me.btnAgregar.TabIndex = 9
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Image = Global.WindowsApplication1.My.Resources.Resources.X
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(85, 467)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(157, 63)
        Me.btnCancelar.TabIndex = 10
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnAgregarAntecedentes
        '
        Me.btnAgregarAntecedentes.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarAntecedentes.Location = New System.Drawing.Point(12, 366)
        Me.btnAgregarAntecedentes.Name = "btnAgregarAntecedentes"
        Me.btnAgregarAntecedentes.Size = New System.Drawing.Size(596, 50)
        Me.btnAgregarAntecedentes.TabIndex = 8
        Me.btnAgregarAntecedentes.Text = "Agregar Antecedentes"
        Me.btnAgregarAntecedentes.UseVisualStyleBackColor = True
        '
        'lblFechaSeleccionada
        '
        Me.lblFechaSeleccionada.AutoSize = True
        Me.lblFechaSeleccionada.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaSeleccionada.Location = New System.Drawing.Point(660, 299)
        Me.lblFechaSeleccionada.Name = "lblFechaSeleccionada"
        Me.lblFechaSeleccionada.Size = New System.Drawing.Size(211, 25)
        Me.lblFechaSeleccionada.TabIndex = 15
        Me.lblFechaSeleccionada.Text = "Fecha seleccionada:"
        '
        'mcFechaNacimiento
        '
        Me.mcFechaNacimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mcFechaNacimiento.Location = New System.Drawing.Point(687, 116)
        Me.mcFechaNacimiento.MaxSelectionCount = 1
        Me.mcFechaNacimiento.Name = "mcFechaNacimiento"
        Me.mcFechaNacimiento.TabIndex = 7
        '
        'dgbPacientesId
        '
        Me.dgbPacientesId.AllowUserToAddRows = False
        Me.dgbPacientesId.AllowUserToDeleteRows = False
        Me.dgbPacientesId.AllowUserToResizeColumns = False
        Me.dgbPacientesId.AllowUserToResizeRows = False
        Me.dgbPacientesId.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgbPacientesId.Location = New System.Drawing.Point(947, 4)
        Me.dgbPacientesId.Name = "dgbPacientesId"
        Me.dgbPacientesId.ReadOnly = True
        Me.dgbPacientesId.Size = New System.Drawing.Size(35, 33)
        Me.dgbPacientesId.TabIndex = 17
        Me.dgbPacientesId.Visible = False
        '
        'txbTelefono
        '
        Me.txbTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbTelefono.Location = New System.Drawing.Point(343, 147)
        Me.txbTelefono.Name = "txbTelefono"
        Me.txbTelefono.Size = New System.Drawing.Size(265, 35)
        Me.txbTelefono.TabIndex = 3
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefono.Location = New System.Drawing.Point(8, 147)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(110, 29)
        Me.lblTelefono.TabIndex = 18
        Me.lblTelefono.Text = "Teléfono"
        '
        'dgbPacientesCedulas
        '
        Me.dgbPacientesCedulas.AllowUserToAddRows = False
        Me.dgbPacientesCedulas.AllowUserToDeleteRows = False
        Me.dgbPacientesCedulas.AllowUserToResizeColumns = False
        Me.dgbPacientesCedulas.AllowUserToResizeRows = False
        Me.dgbPacientesCedulas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgbPacientesCedulas.Location = New System.Drawing.Point(876, 22)
        Me.dgbPacientesCedulas.Name = "dgbPacientesCedulas"
        Me.dgbPacientesCedulas.ReadOnly = True
        Me.dgbPacientesCedulas.Size = New System.Drawing.Size(13, 15)
        Me.dgbPacientesCedulas.TabIndex = 19
        Me.dgbPacientesCedulas.Visible = False
        '
        'lblApellido
        '
        Me.lblApellido.AutoSize = True
        Me.lblApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellido.Location = New System.Drawing.Point(8, 106)
        Me.lblApellido.Name = "lblApellido"
        Me.lblApellido.Size = New System.Drawing.Size(102, 29)
        Me.lblApellido.TabIndex = 20
        Me.lblApellido.Text = "Apellido"
        '
        'txbApellido
        '
        Me.txbApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbApellido.Location = New System.Drawing.Point(343, 106)
        Me.txbApellido.Name = "txbApellido"
        Me.txbApellido.Size = New System.Drawing.Size(265, 35)
        Me.txbApellido.TabIndex = 2
        '
        'pbErrorCedula
        '
        Me.pbErrorCedula.Location = New System.Drawing.Point(615, 22)
        Me.pbErrorCedula.Name = "pbErrorCedula"
        Me.pbErrorCedula.Size = New System.Drawing.Size(36, 35)
        Me.pbErrorCedula.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbErrorCedula.TabIndex = 22
        Me.pbErrorCedula.TabStop = False
        Me.pbErrorCedula.Visible = False
        '
        'lblAnuncio
        '
        Me.lblAnuncio.AutoSize = True
        Me.lblAnuncio.Location = New System.Drawing.Point(658, 22)
        Me.lblAnuncio.Name = "lblAnuncio"
        Me.lblAnuncio.Size = New System.Drawing.Size(39, 13)
        Me.lblAnuncio.TabIndex = 23
        Me.lblAnuncio.Text = "Label1"
        Me.lblAnuncio.Visible = False
        '
        'Ingresar_Paciente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1040, 607)
        Me.Controls.Add(Me.lblAnuncio)
        Me.Controls.Add(Me.pbErrorCedula)
        Me.Controls.Add(Me.txbApellido)
        Me.Controls.Add(Me.lblApellido)
        Me.Controls.Add(Me.dgbPacientesCedulas)
        Me.Controls.Add(Me.txbTelefono)
        Me.Controls.Add(Me.lblTelefono)
        Me.Controls.Add(Me.dgbPacientesId)
        Me.Controls.Add(Me.mcFechaNacimiento)
        Me.Controls.Add(Me.lblFechaSeleccionada)
        Me.Controls.Add(Me.btnAgregarAntecedentes)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.txbDireccionTrabajo)
        Me.Controls.Add(Me.lblDireccionTrabajo)
        Me.Controls.Add(Me.txbDireccionPersonal)
        Me.Controls.Add(Me.lblDireccionPersonal)
        Me.Controls.Add(Me.txbEnviadoPor)
        Me.Controls.Add(Me.lblEnviadoPor)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txbCedula)
        Me.Controls.Add(Me.lblCedula)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.txbNombre)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Ingresar_Paciente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        CType(Me.dgbPacientesId, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgbPacientesCedulas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbErrorCedula, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txbNombre As System.Windows.Forms.TextBox
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents lblCedula As System.Windows.Forms.Label
    Friend WithEvents txbCedula As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblEnviadoPor As System.Windows.Forms.Label
    Friend WithEvents txbEnviadoPor As System.Windows.Forms.TextBox
    Friend WithEvents lblDireccionPersonal As System.Windows.Forms.Label
    Friend WithEvents txbDireccionPersonal As System.Windows.Forms.TextBox
    Friend WithEvents lblDireccionTrabajo As System.Windows.Forms.Label
    Friend WithEvents txbDireccionTrabajo As System.Windows.Forms.TextBox
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnAgregarAntecedentes As System.Windows.Forms.Button
    Friend WithEvents lblFechaSeleccionada As System.Windows.Forms.Label
    Friend WithEvents mcFechaNacimiento As System.Windows.Forms.MonthCalendar
    Friend WithEvents dgbPacientesId As System.Windows.Forms.DataGridView
    Friend WithEvents txbTelefono As System.Windows.Forms.TextBox
    Friend WithEvents lblTelefono As System.Windows.Forms.Label
    Friend WithEvents dgbPacientesCedulas As System.Windows.Forms.DataGridView
    Friend WithEvents lblApellido As System.Windows.Forms.Label
    Friend WithEvents txbApellido As System.Windows.Forms.TextBox
    Friend WithEvents pbErrorCedula As System.Windows.Forms.PictureBox
    Friend WithEvents lblAnuncio As System.Windows.Forms.Label
End Class
