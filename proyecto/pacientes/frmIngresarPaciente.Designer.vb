<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIngresarPaciente
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
        Me.components = New System.ComponentModel.Container()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblCedula = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblEnviadoPor = New System.Windows.Forms.Label()
        Me.lblDireccionPersonal = New System.Windows.Forms.Label()
        Me.lblDireccionTrabajo = New System.Windows.Forms.Label()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAgregarAntecedentes = New System.Windows.Forms.Button()
        Me.lblFechaSeleccionada = New System.Windows.Forms.Label()
        Me.mcFechaNacimiento = New System.Windows.Forms.MonthCalendar()
        Me.dgvPacientesId = New System.Windows.Forms.DataGridView()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.dgvPacientesCedulas = New System.Windows.Forms.DataGridView()
        Me.lblApellido = New System.Windows.Forms.Label()
        Me.epCedula = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.epTelefono = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.txbCedula = New WindowsApplication1.WaterMarkTextBox()
        Me.txbNombre = New WindowsApplication1.WaterMarkTextBox()
        Me.txbApellido = New WindowsApplication1.WaterMarkTextBox()
        Me.txbTelefono = New WindowsApplication1.WaterMarkTextBox()
        Me.txbEnviadoPor = New WindowsApplication1.WaterMarkTextBox()
        Me.txbDireccionPersonal = New WindowsApplication1.WaterMarkTextBox()
        Me.txbDireccionTrabajo = New WindowsApplication1.WaterMarkTextBox()
        CType(Me.dgvPacientesId, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvPacientesCedulas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.epCedula, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.epTelefono, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(726, 43)
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
        Me.lblEnviadoPor.Size = New System.Drawing.Size(309, 29)
        Me.lblEnviadoPor.TabIndex = 6
        Me.lblEnviadoPor.Text = "Por quién fue enviado (opc)"
        '
        'lblDireccionPersonal
        '
        Me.lblDireccionPersonal.AutoSize = True
        Me.lblDireccionPersonal.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDireccionPersonal.Location = New System.Drawing.Point(8, 229)
        Me.lblDireccionPersonal.Name = "lblDireccionPersonal"
        Me.lblDireccionPersonal.Size = New System.Drawing.Size(217, 29)
        Me.lblDireccionPersonal.TabIndex = 8
        Me.lblDireccionPersonal.Text = "Dirección Personal"
        '
        'lblDireccionTrabajo
        '
        Me.lblDireccionTrabajo.AutoSize = True
        Me.lblDireccionTrabajo.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDireccionTrabajo.Location = New System.Drawing.Point(8, 270)
        Me.lblDireccionTrabajo.Name = "lblDireccionTrabajo"
        Me.lblDireccionTrabajo.Size = New System.Drawing.Size(291, 29)
        Me.lblDireccionTrabajo.TabIndex = 10
        Me.lblDireccionTrabajo.Text = "Dirección de trabajo (opc)"
        '
        'btnAgregar
        '
        Me.btnAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.Image = Global.WindowsApplication1.My.Resources.Resources.checkmark
        Me.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAgregar.Location = New System.Drawing.Point(499, 550)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(146, 63)
        Me.btnAgregar.TabIndex = 10
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Image = Global.WindowsApplication1.My.Resources.Resources.X
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(81, 550)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(157, 63)
        Me.btnCancelar.TabIndex = 11
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnAgregarAntecedentes
        '
        Me.btnAgregarAntecedentes.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarAntecedentes.Location = New System.Drawing.Point(13, 454)
        Me.btnAgregarAntecedentes.Name = "btnAgregarAntecedentes"
        Me.btnAgregarAntecedentes.Size = New System.Drawing.Size(596, 50)
        Me.btnAgregarAntecedentes.TabIndex = 9
        Me.btnAgregarAntecedentes.Text = "Agregar Antecedentes"
        Me.btnAgregarAntecedentes.UseVisualStyleBackColor = True
        '
        'lblFechaSeleccionada
        '
        Me.lblFechaSeleccionada.AutoSize = True
        Me.lblFechaSeleccionada.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaSeleccionada.Location = New System.Drawing.Point(680, 264)
        Me.lblFechaSeleccionada.Name = "lblFechaSeleccionada"
        Me.lblFechaSeleccionada.Size = New System.Drawing.Size(211, 25)
        Me.lblFechaSeleccionada.TabIndex = 15
        Me.lblFechaSeleccionada.Text = "Fecha seleccionada:"
        '
        'mcFechaNacimiento
        '
        Me.mcFechaNacimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mcFechaNacimiento.Location = New System.Drawing.Point(722, 81)
        Me.mcFechaNacimiento.MaxSelectionCount = 1
        Me.mcFechaNacimiento.Name = "mcFechaNacimiento"
        Me.mcFechaNacimiento.TabIndex = 8
        '
        'dgvPacientesId
        '
        Me.dgvPacientesId.AllowUserToAddRows = False
        Me.dgvPacientesId.AllowUserToDeleteRows = False
        Me.dgvPacientesId.AllowUserToResizeColumns = False
        Me.dgvPacientesId.AllowUserToResizeRows = False
        Me.dgvPacientesId.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPacientesId.Location = New System.Drawing.Point(993, 4)
        Me.dgvPacientesId.Name = "dgvPacientesId"
        Me.dgvPacientesId.ReadOnly = True
        Me.dgvPacientesId.Size = New System.Drawing.Size(35, 33)
        Me.dgvPacientesId.TabIndex = 17
        Me.dgvPacientesId.Visible = False
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
        'dgvPacientesCedulas
        '
        Me.dgvPacientesCedulas.AllowUserToAddRows = False
        Me.dgvPacientesCedulas.AllowUserToDeleteRows = False
        Me.dgvPacientesCedulas.AllowUserToResizeColumns = False
        Me.dgvPacientesCedulas.AllowUserToResizeRows = False
        Me.dgvPacientesCedulas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPacientesCedulas.Location = New System.Drawing.Point(974, 12)
        Me.dgvPacientesCedulas.Name = "dgvPacientesCedulas"
        Me.dgvPacientesCedulas.ReadOnly = True
        Me.dgvPacientesCedulas.Size = New System.Drawing.Size(13, 15)
        Me.dgvPacientesCedulas.TabIndex = 19
        Me.dgvPacientesCedulas.Visible = False
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
        'epCedula
        '
        Me.epCedula.ContainerControl = Me
        '
        'epTelefono
        '
        Me.epTelefono.ContainerControl = Me
        '
        'txbCedula
        '
        Me.txbCedula.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbCedula.Location = New System.Drawing.Point(343, 22)
        Me.txbCedula.Name = "txbCedula"
        Me.txbCedula.Size = New System.Drawing.Size(265, 35)
        Me.txbCedula.TabIndex = 1
        Me.txbCedula.WaterMarkColor = System.Drawing.Color.Gray
        Me.txbCedula.WaterMarkText = "Water Mark"
        '
        'txbNombre
        '
        Me.txbNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbNombre.Location = New System.Drawing.Point(344, 65)
        Me.txbNombre.Name = "txbNombre"
        Me.txbNombre.Size = New System.Drawing.Size(265, 35)
        Me.txbNombre.TabIndex = 2
        Me.txbNombre.WaterMarkColor = System.Drawing.Color.Gray
        Me.txbNombre.WaterMarkText = "Water Mark"
        '
        'txbApellido
        '
        Me.txbApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbApellido.Location = New System.Drawing.Point(344, 106)
        Me.txbApellido.Name = "txbApellido"
        Me.txbApellido.Size = New System.Drawing.Size(265, 35)
        Me.txbApellido.TabIndex = 3
        Me.txbApellido.WaterMarkColor = System.Drawing.Color.Gray
        Me.txbApellido.WaterMarkText = "Water Mark"
        '
        'txbTelefono
        '
        Me.txbTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbTelefono.Location = New System.Drawing.Point(344, 147)
        Me.txbTelefono.Name = "txbTelefono"
        Me.txbTelefono.Size = New System.Drawing.Size(265, 35)
        Me.txbTelefono.TabIndex = 4
        Me.txbTelefono.WaterMarkColor = System.Drawing.Color.Gray
        Me.txbTelefono.WaterMarkText = "Water Mark"
        '
        'txbEnviadoPor
        '
        Me.txbEnviadoPor.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbEnviadoPor.Location = New System.Drawing.Point(344, 188)
        Me.txbEnviadoPor.Name = "txbEnviadoPor"
        Me.txbEnviadoPor.Size = New System.Drawing.Size(265, 35)
        Me.txbEnviadoPor.TabIndex = 5
        Me.txbEnviadoPor.WaterMarkColor = System.Drawing.Color.Gray
        Me.txbEnviadoPor.WaterMarkText = "Water Mark"
        '
        'txbDireccionPersonal
        '
        Me.txbDireccionPersonal.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbDireccionPersonal.Location = New System.Drawing.Point(344, 229)
        Me.txbDireccionPersonal.Name = "txbDireccionPersonal"
        Me.txbDireccionPersonal.Size = New System.Drawing.Size(265, 35)
        Me.txbDireccionPersonal.TabIndex = 6
        Me.txbDireccionPersonal.WaterMarkColor = System.Drawing.Color.Gray
        Me.txbDireccionPersonal.WaterMarkText = "Water Mark"
        '
        'txbDireccionTrabajo
        '
        Me.txbDireccionTrabajo.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbDireccionTrabajo.Location = New System.Drawing.Point(344, 270)
        Me.txbDireccionTrabajo.Name = "txbDireccionTrabajo"
        Me.txbDireccionTrabajo.Size = New System.Drawing.Size(265, 35)
        Me.txbDireccionTrabajo.TabIndex = 7
        Me.txbDireccionTrabajo.WaterMarkColor = System.Drawing.Color.Gray
        Me.txbDireccionTrabajo.WaterMarkText = "Water Mark"
        '
        'frmIngresarPaciente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1179, 684)
        Me.Controls.Add(Me.txbDireccionTrabajo)
        Me.Controls.Add(Me.txbDireccionPersonal)
        Me.Controls.Add(Me.txbEnviadoPor)
        Me.Controls.Add(Me.txbTelefono)
        Me.Controls.Add(Me.txbApellido)
        Me.Controls.Add(Me.txbNombre)
        Me.Controls.Add(Me.txbCedula)
        Me.Controls.Add(Me.lblApellido)
        Me.Controls.Add(Me.dgvPacientesCedulas)
        Me.Controls.Add(Me.lblTelefono)
        Me.Controls.Add(Me.dgvPacientesId)
        Me.Controls.Add(Me.mcFechaNacimiento)
        Me.Controls.Add(Me.lblFechaSeleccionada)
        Me.Controls.Add(Me.btnAgregarAntecedentes)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.lblDireccionTrabajo)
        Me.Controls.Add(Me.lblDireccionPersonal)
        Me.Controls.Add(Me.lblEnviadoPor)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblCedula)
        Me.Controls.Add(Me.lblNombre)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmIngresarPaciente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        CType(Me.dgvPacientesId, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvPacientesCedulas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.epCedula, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.epTelefono, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents lblCedula As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblEnviadoPor As System.Windows.Forms.Label
    Friend WithEvents lblDireccionPersonal As System.Windows.Forms.Label
    Friend WithEvents lblDireccionTrabajo As System.Windows.Forms.Label
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnAgregarAntecedentes As System.Windows.Forms.Button
    Friend WithEvents lblFechaSeleccionada As System.Windows.Forms.Label
    Friend WithEvents mcFechaNacimiento As System.Windows.Forms.MonthCalendar
    Friend WithEvents dgvPacientesId As System.Windows.Forms.DataGridView
    Friend WithEvents lblTelefono As System.Windows.Forms.Label
    Friend WithEvents dgvPacientesCedulas As System.Windows.Forms.DataGridView
    Friend WithEvents lblApellido As System.Windows.Forms.Label
    Friend WithEvents epCedula As System.Windows.Forms.ErrorProvider
    Friend WithEvents epTelefono As System.Windows.Forms.ErrorProvider
    Friend WithEvents txbCedula As WindowsApplication1.WaterMarkTextBox
    Friend WithEvents txbDireccionTrabajo As WindowsApplication1.WaterMarkTextBox
    Friend WithEvents txbDireccionPersonal As WindowsApplication1.WaterMarkTextBox
    Friend WithEvents txbEnviadoPor As WindowsApplication1.WaterMarkTextBox
    Friend WithEvents txbTelefono As WindowsApplication1.WaterMarkTextBox
    Friend WithEvents txbApellido As WindowsApplication1.WaterMarkTextBox
    Friend WithEvents txbNombre As WindowsApplication1.WaterMarkTextBox
End Class
