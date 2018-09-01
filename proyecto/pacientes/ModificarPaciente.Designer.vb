<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModificarPaciente
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
        Me.lblFechaNacimiento = New System.Windows.Forms.Label()
        Me.lblEnviadoPor = New System.Windows.Forms.Label()
        Me.txbEnviadoPor = New System.Windows.Forms.TextBox()
        Me.lblDireccionPersonal = New System.Windows.Forms.Label()
        Me.txbDireccionPersonal = New System.Windows.Forms.TextBox()
        Me.lblDireccionTrabajo = New System.Windows.Forms.Label()
        Me.txbDireccionTrabajo = New System.Windows.Forms.TextBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnModificarAntecedentes = New System.Windows.Forms.Button()
        Me.lblFechaSeleccionada = New System.Windows.Forms.Label()
        Me.mcFechaNacimiento = New System.Windows.Forms.MonthCalendar()
        Me.dgvAntecedentes = New System.Windows.Forms.DataGridView()
        Me.txbTelefono = New System.Windows.Forms.TextBox()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.lblApellido = New System.Windows.Forms.Label()
        Me.txbApellido = New System.Windows.Forms.TextBox()
        CType(Me.dgvAntecedentes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txbNombre
        '
        Me.txbNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbNombre.Location = New System.Drawing.Point(325, 91)
        Me.txbNombre.Name = "txbNombre"
        Me.txbNombre.Size = New System.Drawing.Size(234, 35)
        Me.txbNombre.TabIndex = 0
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(26, 91)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(101, 29)
        Me.lblNombre.TabIndex = 1
        Me.lblNombre.Text = "Nombre"
        '
        'lblCedula
        '
        Me.lblCedula.AutoSize = True
        Me.lblCedula.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCedula.Location = New System.Drawing.Point(26, 47)
        Me.lblCedula.Name = "lblCedula"
        Me.lblCedula.Size = New System.Drawing.Size(90, 29)
        Me.lblCedula.TabIndex = 2
        Me.lblCedula.Text = "Cédula"
        '
        'txbCedula
        '
        Me.txbCedula.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbCedula.Location = New System.Drawing.Point(325, 47)
        Me.txbCedula.Name = "txbCedula"
        Me.txbCedula.Size = New System.Drawing.Size(234, 35)
        Me.txbCedula.TabIndex = 1
        '
        'lblFechaNacimiento
        '
        Me.lblFechaNacimiento.AutoSize = True
        Me.lblFechaNacimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaNacimiento.Location = New System.Drawing.Point(706, 81)
        Me.lblFechaNacimiento.Name = "lblFechaNacimiento"
        Me.lblFechaNacimiento.Size = New System.Drawing.Size(208, 29)
        Me.lblFechaNacimiento.TabIndex = 4
        Me.lblFechaNacimiento.Text = "Fecha Nacimiento"
        '
        'lblEnviadoPor
        '
        Me.lblEnviadoPor.AutoSize = True
        Me.lblEnviadoPor.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnviadoPor.Location = New System.Drawing.Point(26, 237)
        Me.lblEnviadoPor.Name = "lblEnviadoPor"
        Me.lblEnviadoPor.Size = New System.Drawing.Size(297, 29)
        Me.lblEnviadoPor.TabIndex = 6
        Me.lblEnviadoPor.Text = "Por quién fue enviado (op)"
        '
        'txbEnviadoPor
        '
        Me.txbEnviadoPor.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbEnviadoPor.Location = New System.Drawing.Point(325, 234)
        Me.txbEnviadoPor.Name = "txbEnviadoPor"
        Me.txbEnviadoPor.Size = New System.Drawing.Size(234, 35)
        Me.txbEnviadoPor.TabIndex = 3
        '
        'lblDireccionPersonal
        '
        Me.lblDireccionPersonal.AutoSize = True
        Me.lblDireccionPersonal.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDireccionPersonal.Location = New System.Drawing.Point(26, 283)
        Me.lblDireccionPersonal.Name = "lblDireccionPersonal"
        Me.lblDireccionPersonal.Size = New System.Drawing.Size(217, 29)
        Me.lblDireccionPersonal.TabIndex = 8
        Me.lblDireccionPersonal.Text = "Dirección Personal"
        '
        'txbDireccionPersonal
        '
        Me.txbDireccionPersonal.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbDireccionPersonal.Location = New System.Drawing.Point(325, 283)
        Me.txbDireccionPersonal.Name = "txbDireccionPersonal"
        Me.txbDireccionPersonal.Size = New System.Drawing.Size(234, 35)
        Me.txbDireccionPersonal.TabIndex = 4
        '
        'lblDireccionTrabajo
        '
        Me.lblDireccionTrabajo.AutoSize = True
        Me.lblDireccionTrabajo.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDireccionTrabajo.Location = New System.Drawing.Point(26, 326)
        Me.lblDireccionTrabajo.Name = "lblDireccionTrabajo"
        Me.lblDireccionTrabajo.Size = New System.Drawing.Size(279, 29)
        Me.lblDireccionTrabajo.TabIndex = 10
        Me.lblDireccionTrabajo.Text = "Dirección de trabajo (op)"
        '
        'txbDireccionTrabajo
        '
        Me.txbDireccionTrabajo.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbDireccionTrabajo.Location = New System.Drawing.Point(325, 321)
        Me.txbDireccionTrabajo.Name = "txbDireccionTrabajo"
        Me.txbDireccionTrabajo.Size = New System.Drawing.Size(234, 35)
        Me.txbDireccionTrabajo.TabIndex = 5
        '
        'btnGuardar
        '
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Image = Global.WindowsApplication1.My.Resources.Resources.checkmark
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardar.Location = New System.Drawing.Point(743, 479)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(149, 60)
        Me.btnGuardar.TabIndex = 8
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Image = Global.WindowsApplication1.My.Resources.Resources.X
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(147, 479)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(148, 60)
        Me.btnCancelar.TabIndex = 9
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnModificarAntecedentes
        '
        Me.btnModificarAntecedentes.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificarAntecedentes.Location = New System.Drawing.Point(39, 371)
        Me.btnModificarAntecedentes.Name = "btnModificarAntecedentes"
        Me.btnModificarAntecedentes.Size = New System.Drawing.Size(520, 53)
        Me.btnModificarAntecedentes.TabIndex = 7
        Me.btnModificarAntecedentes.Text = "Modificar Antecedentes"
        Me.btnModificarAntecedentes.UseVisualStyleBackColor = True
        '
        'lblFechaSeleccionada
        '
        Me.lblFechaSeleccionada.AutoSize = True
        Me.lblFechaSeleccionada.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaSeleccionada.Location = New System.Drawing.Point(621, 290)
        Me.lblFechaSeleccionada.Name = "lblFechaSeleccionada"
        Me.lblFechaSeleccionada.Size = New System.Drawing.Size(235, 29)
        Me.lblFechaSeleccionada.TabIndex = 15
        Me.lblFechaSeleccionada.Text = "Fecha seleccionada:"
        '
        'mcFechaNacimiento
        '
        Me.mcFechaNacimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mcFechaNacimiento.Location = New System.Drawing.Point(682, 119)
        Me.mcFechaNacimiento.MaxSelectionCount = 1
        Me.mcFechaNacimiento.Name = "mcFechaNacimiento"
        Me.mcFechaNacimiento.TabIndex = 6
        '
        'dgvAntecedentes
        '
        Me.dgvAntecedentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAntecedentes.Location = New System.Drawing.Point(999, 12)
        Me.dgvAntecedentes.Name = "dgvAntecedentes"
        Me.dgvAntecedentes.Size = New System.Drawing.Size(29, 34)
        Me.dgvAntecedentes.TabIndex = 17
        Me.dgvAntecedentes.Visible = False
        '
        'txbTelefono
        '
        Me.txbTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbTelefono.Location = New System.Drawing.Point(325, 184)
        Me.txbTelefono.Name = "txbTelefono"
        Me.txbTelefono.Size = New System.Drawing.Size(234, 35)
        Me.txbTelefono.TabIndex = 2
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefono.Location = New System.Drawing.Point(26, 184)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(110, 29)
        Me.lblTelefono.TabIndex = 20
        Me.lblTelefono.Text = "Teléfono"
        '
        'lblApellido
        '
        Me.lblApellido.AutoSize = True
        Me.lblApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellido.Location = New System.Drawing.Point(26, 138)
        Me.lblApellido.Name = "lblApellido"
        Me.lblApellido.Size = New System.Drawing.Size(102, 29)
        Me.lblApellido.TabIndex = 22
        Me.lblApellido.Text = "Apellido"
        '
        'txbApellido
        '
        Me.txbApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbApellido.Location = New System.Drawing.Point(325, 138)
        Me.txbApellido.Name = "txbApellido"
        Me.txbApellido.Size = New System.Drawing.Size(234, 35)
        Me.txbApellido.TabIndex = 21
        '
        'ModificarPaciente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1040, 607)
        Me.Controls.Add(Me.lblApellido)
        Me.Controls.Add(Me.txbApellido)
        Me.Controls.Add(Me.txbTelefono)
        Me.Controls.Add(Me.lblTelefono)
        Me.Controls.Add(Me.dgvAntecedentes)
        Me.Controls.Add(Me.mcFechaNacimiento)
        Me.Controls.Add(Me.lblFechaSeleccionada)
        Me.Controls.Add(Me.btnModificarAntecedentes)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.txbDireccionTrabajo)
        Me.Controls.Add(Me.lblDireccionTrabajo)
        Me.Controls.Add(Me.txbDireccionPersonal)
        Me.Controls.Add(Me.lblDireccionPersonal)
        Me.Controls.Add(Me.txbEnviadoPor)
        Me.Controls.Add(Me.lblEnviadoPor)
        Me.Controls.Add(Me.lblFechaNacimiento)
        Me.Controls.Add(Me.txbCedula)
        Me.Controls.Add(Me.lblCedula)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.txbNombre)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ModificarPaciente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        CType(Me.dgvAntecedentes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txbNombre As System.Windows.Forms.TextBox
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents lblCedula As System.Windows.Forms.Label
    Friend WithEvents txbCedula As System.Windows.Forms.TextBox
    Friend WithEvents lblFechaNacimiento As System.Windows.Forms.Label
    Friend WithEvents lblEnviadoPor As System.Windows.Forms.Label
    Friend WithEvents txbEnviadoPor As System.Windows.Forms.TextBox
    Friend WithEvents lblDireccionPersonal As System.Windows.Forms.Label
    Friend WithEvents txbDireccionPersonal As System.Windows.Forms.TextBox
    Friend WithEvents lblDireccionTrabajo As System.Windows.Forms.Label
    Friend WithEvents txbDireccionTrabajo As System.Windows.Forms.TextBox
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnModificarAntecedentes As System.Windows.Forms.Button
    Friend WithEvents lblFechaSeleccionada As System.Windows.Forms.Label
    Friend WithEvents mcFechaNacimiento As System.Windows.Forms.MonthCalendar
    Friend WithEvents dgvAntecedentes As System.Windows.Forms.DataGridView
    Friend WithEvents txbTelefono As System.Windows.Forms.TextBox
    Friend WithEvents lblTelefono As System.Windows.Forms.Label
    Friend WithEvents lblApellido As System.Windows.Forms.Label
    Friend WithEvents txbApellido As System.Windows.Forms.TextBox
End Class
