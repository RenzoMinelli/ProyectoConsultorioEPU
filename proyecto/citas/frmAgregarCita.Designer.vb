<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAgregarCita
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvPacientes = New System.Windows.Forms.DataGridView()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txbAnotaciones = New System.Windows.Forms.TextBox()
        Me.btnRegresar = New System.Windows.Forms.Button()
        Me.dgvAuxiliar = New System.Windows.Forms.DataGridView()
        Me.lblCitasEnLaFceha = New System.Windows.Forms.Label()
        Me.dgvCitasEnLaFecha = New System.Windows.Forms.DataGridView()
        Me.lblFechaSeleccionada = New System.Windows.Forms.Label()
        Me.dgvTratamientos = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblDuracion = New System.Windows.Forms.Label()
        Me.txbDuracion = New System.Windows.Forms.TextBox()
        Me.txbFechaHora = New System.Windows.Forms.TextBox()
        CType(Me.dgvPacientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvAuxiliar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvCitasEnLaFecha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvTratamientos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.Label1.Location = New System.Drawing.Point(12, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(272, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Seleccione un Paciente:"
        '
        'dgvPacientes
        '
        Me.dgvPacientes.AllowUserToAddRows = False
        Me.dgvPacientes.AllowUserToDeleteRows = False
        Me.dgvPacientes.AllowUserToResizeColumns = False
        Me.dgvPacientes.AllowUserToResizeRows = False
        Me.dgvPacientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvPacientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPacientes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvPacientes.DefaultCellStyle = DataGridViewCellStyle8
        Me.dgvPacientes.Location = New System.Drawing.Point(12, 98)
        Me.dgvPacientes.Name = "dgvPacientes"
        Me.dgvPacientes.ReadOnly = True
        Me.dgvPacientes.RowHeadersVisible = False
        Me.dgvPacientes.Size = New System.Drawing.Size(413, 150)
        Me.dgvPacientes.TabIndex = 7
        '
        'btnGuardar
        '
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Location = New System.Drawing.Point(789, 515)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(239, 80)
        Me.btnGuardar.TabIndex = 8
        Me.btnGuardar.Text = "Guardar cita"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.Label4.Location = New System.Drawing.Point(466, 260)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(151, 29)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Anotaciones:"
        '
        'txbAnotaciones
        '
        Me.txbAnotaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbAnotaciones.Location = New System.Drawing.Point(470, 304)
        Me.txbAnotaciones.Multiline = True
        Me.txbAnotaciones.Name = "txbAnotaciones"
        Me.txbAnotaciones.Size = New System.Drawing.Size(546, 183)
        Me.txbAnotaciones.TabIndex = 4
        '
        'btnRegresar
        '
        Me.btnRegresar.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegresar.Location = New System.Drawing.Point(33, 516)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(231, 79)
        Me.btnRegresar.TabIndex = 13
        Me.btnRegresar.Text = "Regresar"
        Me.btnRegresar.UseVisualStyleBackColor = True
        '
        'dgvAuxiliar
        '
        Me.dgvAuxiliar.AllowUserToAddRows = False
        Me.dgvAuxiliar.AllowUserToDeleteRows = False
        Me.dgvAuxiliar.AllowUserToResizeColumns = False
        Me.dgvAuxiliar.AllowUserToResizeRows = False
        Me.dgvAuxiliar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvAuxiliar.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvAuxiliar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAuxiliar.Location = New System.Drawing.Point(1007, 12)
        Me.dgvAuxiliar.Name = "dgvAuxiliar"
        Me.dgvAuxiliar.ReadOnly = True
        Me.dgvAuxiliar.RowHeadersVisible = False
        Me.dgvAuxiliar.Size = New System.Drawing.Size(21, 13)
        Me.dgvAuxiliar.TabIndex = 22
        Me.dgvAuxiliar.Visible = False
        '
        'lblCitasEnLaFceha
        '
        Me.lblCitasEnLaFceha.AutoSize = True
        Me.lblCitasEnLaFceha.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCitasEnLaFceha.Location = New System.Drawing.Point(466, 66)
        Me.lblCitasEnLaFceha.Name = "lblCitasEnLaFceha"
        Me.lblCitasEnLaFceha.Size = New System.Drawing.Size(286, 29)
        Me.lblCitasEnLaFceha.TabIndex = 26
        Me.lblCitasEnLaFceha.Text = "Citas Agendadas ese día:"
        '
        'dgvCitasEnLaFecha
        '
        Me.dgvCitasEnLaFecha.AllowUserToAddRows = False
        Me.dgvCitasEnLaFecha.AllowUserToDeleteRows = False
        Me.dgvCitasEnLaFecha.AllowUserToResizeColumns = False
        Me.dgvCitasEnLaFecha.AllowUserToResizeRows = False
        Me.dgvCitasEnLaFecha.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvCitasEnLaFecha.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCitasEnLaFecha.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.dgvCitasEnLaFecha.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCitasEnLaFecha.DefaultCellStyle = DataGridViewCellStyle10
        Me.dgvCitasEnLaFecha.Location = New System.Drawing.Point(470, 98)
        Me.dgvCitasEnLaFecha.Name = "dgvCitasEnLaFecha"
        Me.dgvCitasEnLaFecha.ReadOnly = True
        Me.dgvCitasEnLaFecha.RowHeadersVisible = False
        Me.dgvCitasEnLaFecha.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCitasEnLaFecha.Size = New System.Drawing.Size(545, 150)
        Me.dgvCitasEnLaFecha.TabIndex = 25
        '
        'lblFechaSeleccionada
        '
        Me.lblFechaSeleccionada.AutoSize = True
        Me.lblFechaSeleccionada.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaSeleccionada.Location = New System.Drawing.Point(7, 12)
        Me.lblFechaSeleccionada.Name = "lblFechaSeleccionada"
        Me.lblFechaSeleccionada.Size = New System.Drawing.Size(239, 29)
        Me.lblFechaSeleccionada.TabIndex = 23
        Me.lblFechaSeleccionada.Text = "Fecha Seleccionada:"
        '
        'dgvTratamientos
        '
        Me.dgvTratamientos.AllowUserToAddRows = False
        Me.dgvTratamientos.AllowUserToDeleteRows = False
        Me.dgvTratamientos.AllowUserToResizeColumns = False
        Me.dgvTratamientos.AllowUserToResizeRows = False
        Me.dgvTratamientos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvTratamientos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvTratamientos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.dgvTratamientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvTratamientos.DefaultCellStyle = DataGridViewCellStyle12
        Me.dgvTratamientos.Location = New System.Drawing.Point(12, 304)
        Me.dgvTratamientos.Name = "dgvTratamientos"
        Me.dgvTratamientos.ReadOnly = True
        Me.dgvTratamientos.RowHeadersVisible = False
        Me.dgvTratamientos.Size = New System.Drawing.Size(413, 183)
        Me.dgvTratamientos.TabIndex = 27
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.Label2.Location = New System.Drawing.Point(7, 260)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(382, 29)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Tratamientos Activos del Paciente:"
        '
        'lblDuracion
        '
        Me.lblDuracion.AutoSize = True
        Me.lblDuracion.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDuracion.Location = New System.Drawing.Point(539, 17)
        Me.lblDuracion.Name = "lblDuracion"
        Me.lblDuracion.Size = New System.Drawing.Size(192, 29)
        Me.lblDuracion.TabIndex = 29
        Me.lblDuracion.Text = "Duracion de cita:"
        '
        'txbDuracion
        '
        Me.txbDuracion.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbDuracion.Location = New System.Drawing.Point(737, 18)
        Me.txbDuracion.Name = "txbDuracion"
        Me.txbDuracion.Size = New System.Drawing.Size(36, 29)
        Me.txbDuracion.TabIndex = 30
        '
        'txbFechaHora
        '
        Me.txbFechaHora.Enabled = False
        Me.txbFechaHora.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbFechaHora.Location = New System.Drawing.Point(252, 18)
        Me.txbFechaHora.Name = "txbFechaHora"
        Me.txbFechaHora.Size = New System.Drawing.Size(173, 29)
        Me.txbFechaHora.TabIndex = 31
        '
        'frmAgregarCita
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1040, 607)
        Me.Controls.Add(Me.txbFechaHora)
        Me.Controls.Add(Me.txbDuracion)
        Me.Controls.Add(Me.lblDuracion)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgvTratamientos)
        Me.Controls.Add(Me.lblCitasEnLaFceha)
        Me.Controls.Add(Me.dgvCitasEnLaFecha)
        Me.Controls.Add(Me.lblFechaSeleccionada)
        Me.Controls.Add(Me.dgvAuxiliar)
        Me.Controls.Add(Me.btnRegresar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.dgvPacientes)
        Me.Controls.Add(Me.txbAnotaciones)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmAgregarCita"
        Me.Text = "agregarcitas2"
        CType(Me.dgvPacientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvAuxiliar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvCitasEnLaFecha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvTratamientos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgvPacientes As System.Windows.Forms.DataGridView
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txbAnotaciones As System.Windows.Forms.TextBox
    Friend WithEvents btnRegresar As System.Windows.Forms.Button
    Friend WithEvents dgvAuxiliar As System.Windows.Forms.DataGridView
    Friend WithEvents lblCitasEnLaFceha As System.Windows.Forms.Label
    Friend WithEvents dgvCitasEnLaFecha As System.Windows.Forms.DataGridView
    Friend WithEvents lblFechaSeleccionada As System.Windows.Forms.Label
    Friend WithEvents dgvTratamientos As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblDuracion As System.Windows.Forms.Label
    Friend WithEvents txbDuracion As System.Windows.Forms.TextBox
    Friend WithEvents txbFechaHora As System.Windows.Forms.TextBox
End Class
