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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txbCedula = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txbEnviadoPor = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txbDireccionPersonal = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txbDireccionTrabajo = New System.Windows.Forms.TextBox()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAgregarAntecedentes = New System.Windows.Forms.Button()
        Me.lblFechaSeleccionada = New System.Windows.Forms.Label()
        Me.mcFechaNacimiento = New System.Windows.Forms.MonthCalendar()
        Me.dgbPacientesId = New System.Windows.Forms.DataGridView()
        Me.txbTelefono = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dgbPacientesCedulas = New System.Windows.Forms.DataGridView()
        CType(Me.dgbPacientesId, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgbPacientesCedulas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txbNombre
        '
        Me.txbNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbNombre.Location = New System.Drawing.Point(249, 62)
        Me.txbNombre.Name = "txbNombre"
        Me.txbNombre.Size = New System.Drawing.Size(227, 29)
        Me.txbNombre.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(165, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nombre Completo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 24)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Cédula"
        '
        'txbCedula
        '
        Me.txbCedula.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbCedula.Location = New System.Drawing.Point(249, 106)
        Me.txbCedula.Name = "txbCedula"
        Me.txbCedula.Size = New System.Drawing.Size(227, 29)
        Me.txbCedula.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(725, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(164, 24)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Fecha Nacimiento"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 216)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(234, 24)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Por quien fue enviado (op)"
        '
        'txbEnviadoPor
        '
        Me.txbEnviadoPor.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbEnviadoPor.Location = New System.Drawing.Point(249, 213)
        Me.txbEnviadoPor.Name = "txbEnviadoPor"
        Me.txbEnviadoPor.Size = New System.Drawing.Size(227, 29)
        Me.txbEnviadoPor.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 264)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(169, 24)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Direccion Personal"
        '
        'txbDireccionPersonal
        '
        Me.txbDireccionPersonal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbDireccionPersonal.Location = New System.Drawing.Point(249, 264)
        Me.txbDireccionPersonal.Name = "txbDireccionPersonal"
        Me.txbDireccionPersonal.Size = New System.Drawing.Size(227, 29)
        Me.txbDireccionPersonal.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 302)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(217, 24)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Direccion de trabajo (op)"
        '
        'txbDireccionTrabajo
        '
        Me.txbDireccionTrabajo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbDireccionTrabajo.Location = New System.Drawing.Point(249, 302)
        Me.txbDireccionTrabajo.Name = "txbDireccionTrabajo"
        Me.txbDireccionTrabajo.Size = New System.Drawing.Size(227, 29)
        Me.txbDireccionTrabajo.TabIndex = 5
        '
        'btnAgregar
        '
        Me.btnAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.Image = Global.WindowsApplication1.My.Resources.Resources.checkmark
        Me.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAgregar.Location = New System.Drawing.Point(672, 467)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(128, 54)
        Me.btnAgregar.TabIndex = 8
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Image = Global.WindowsApplication1.My.Resources.Resources.X
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(85, 467)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(144, 54)
        Me.btnCancelar.TabIndex = 9
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnAgregarAntecedentes
        '
        Me.btnAgregarAntecedentes.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarAntecedentes.Location = New System.Drawing.Point(16, 344)
        Me.btnAgregarAntecedentes.Name = "btnAgregarAntecedentes"
        Me.btnAgregarAntecedentes.Size = New System.Drawing.Size(460, 42)
        Me.btnAgregarAntecedentes.TabIndex = 7
        Me.btnAgregarAntecedentes.Text = "Agregar Antecedentes"
        Me.btnAgregarAntecedentes.UseVisualStyleBackColor = True
        '
        'lblFechaSeleccionada
        '
        Me.lblFechaSeleccionada.AutoSize = True
        Me.lblFechaSeleccionada.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaSeleccionada.Location = New System.Drawing.Point(669, 289)
        Me.lblFechaSeleccionada.Name = "lblFechaSeleccionada"
        Me.lblFechaSeleccionada.Size = New System.Drawing.Size(186, 24)
        Me.lblFechaSeleccionada.TabIndex = 15
        Me.lblFechaSeleccionada.Text = "Fecha seleccionada:"
        '
        'mcFechaNacimiento
        '
        Me.mcFechaNacimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mcFechaNacimiento.Location = New System.Drawing.Point(672, 118)
        Me.mcFechaNacimiento.MaxSelectionCount = 1
        Me.mcFechaNacimiento.Name = "mcFechaNacimiento"
        Me.mcFechaNacimiento.TabIndex = 6
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
        Me.txbTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbTelefono.Location = New System.Drawing.Point(249, 160)
        Me.txbTelefono.Name = "txbTelefono"
        Me.txbTelefono.Size = New System.Drawing.Size(227, 29)
        Me.txbTelefono.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 160)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(85, 24)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Teléfono"
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
        'Ingresar_Paciente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1040, 607)
        Me.Controls.Add(Me.dgbPacientesCedulas)
        Me.Controls.Add(Me.txbTelefono)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.dgbPacientesId)
        Me.Controls.Add(Me.mcFechaNacimiento)
        Me.Controls.Add(Me.lblFechaSeleccionada)
        Me.Controls.Add(Me.btnAgregarAntecedentes)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.txbDireccionTrabajo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txbDireccionPersonal)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txbEnviadoPor)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txbCedula)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txbNombre)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Ingresar_Paciente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        CType(Me.dgbPacientesId, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgbPacientesCedulas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txbNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txbCedula As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txbEnviadoPor As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txbDireccionPersonal As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txbDireccionTrabajo As System.Windows.Forms.TextBox
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnAgregarAntecedentes As System.Windows.Forms.Button
    Friend WithEvents lblFechaSeleccionada As System.Windows.Forms.Label
    Friend WithEvents mcFechaNacimiento As System.Windows.Forms.MonthCalendar
    Friend WithEvents dgbPacientesId As System.Windows.Forms.DataGridView
    Friend WithEvents txbTelefono As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents dgbPacientesCedulas As System.Windows.Forms.DataGridView
End Class
