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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvPacientes = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txbAnotaciones = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.botonsito = New System.Windows.Forms.Button()
        Me.dgvAuxiliar = New System.Windows.Forms.DataGridView()
        Me.lblCitasEnLaFceha = New System.Windows.Forms.Label()
        Me.dgvCitasEnLaFecha = New System.Windows.Forms.DataGridView()
        Me.dtpFechaSeleccionada = New System.Windows.Forms.DateTimePicker()
        Me.lblFechaSeleccionada = New System.Windows.Forms.Label()
        CType(Me.dgvPacientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvAuxiliar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvCitasEnLaFecha, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.Label1.Location = New System.Drawing.Point(28, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Paciente:"
        '
        'dgvPacientes
        '
        Me.dgvPacientes.AllowUserToAddRows = False
        Me.dgvPacientes.AllowUserToDeleteRows = False
        Me.dgvPacientes.AllowUserToResizeColumns = False
        Me.dgvPacientes.AllowUserToResizeRows = False
        Me.dgvPacientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvPacientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPacientes.Location = New System.Drawing.Point(33, 59)
        Me.dgvPacientes.Name = "dgvPacientes"
        Me.dgvPacientes.ReadOnly = True
        Me.dgvPacientes.RowHeadersVisible = False
        Me.dgvPacientes.Size = New System.Drawing.Size(326, 191)
        Me.dgvPacientes.TabIndex = 7
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Modern No. 20", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(777, 487)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(239, 80)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Guardar cita"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.Label4.Location = New System.Drawing.Point(374, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(151, 29)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Anotaciones:"
        '
        'txbAnotaciones
        '
        Me.txbAnotaciones.Location = New System.Drawing.Point(379, 67)
        Me.txbAnotaciones.Multiline = True
        Me.txbAnotaciones.Name = "txbAnotaciones"
        Me.txbAnotaciones.Size = New System.Drawing.Size(281, 358)
        Me.txbAnotaciones.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(29, 264)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(235, 25)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Paciente seleccionado:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(29, 302)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(298, 25)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "ningun paciente seleccionado"
        '
        'botonsito
        '
        Me.botonsito.Font = New System.Drawing.Font("Modern No. 20", 18.0!, System.Drawing.FontStyle.Bold)
        Me.botonsito.Location = New System.Drawing.Point(33, 487)
        Me.botonsito.Name = "botonsito"
        Me.botonsito.Size = New System.Drawing.Size(231, 79)
        Me.botonsito.TabIndex = 13
        Me.botonsito.Text = "Regresar"
        Me.botonsito.UseVisualStyleBackColor = True
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
        Me.lblCitasEnLaFceha.Location = New System.Drawing.Point(687, 130)
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
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCitasEnLaFecha.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvCitasEnLaFecha.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCitasEnLaFecha.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgvCitasEnLaFecha.Location = New System.Drawing.Point(692, 177)
        Me.dgvCitasEnLaFecha.Name = "dgvCitasEnLaFecha"
        Me.dgvCitasEnLaFecha.ReadOnly = True
        Me.dgvCitasEnLaFecha.RowHeadersVisible = False
        Me.dgvCitasEnLaFecha.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCitasEnLaFecha.Size = New System.Drawing.Size(336, 248)
        Me.dgvCitasEnLaFecha.TabIndex = 25
        '
        'dtpFechaSeleccionada
        '
        Me.dtpFechaSeleccionada.CustomFormat = "dd/MM/yyyy        HH:mm"
        Me.dtpFechaSeleccionada.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaSeleccionada.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFechaSeleccionada.Location = New System.Drawing.Point(692, 77)
        Me.dtpFechaSeleccionada.Name = "dtpFechaSeleccionada"
        Me.dtpFechaSeleccionada.Size = New System.Drawing.Size(271, 35)
        Me.dtpFechaSeleccionada.TabIndex = 24
        '
        'lblFechaSeleccionada
        '
        Me.lblFechaSeleccionada.AutoSize = True
        Me.lblFechaSeleccionada.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaSeleccionada.Location = New System.Drawing.Point(687, 30)
        Me.lblFechaSeleccionada.Name = "lblFechaSeleccionada"
        Me.lblFechaSeleccionada.Size = New System.Drawing.Size(239, 29)
        Me.lblFechaSeleccionada.TabIndex = 23
        Me.lblFechaSeleccionada.Text = "Fecha Seleccionada:"
        '
        'frmAgregarCita
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1040, 607)
        Me.Controls.Add(Me.lblCitasEnLaFceha)
        Me.Controls.Add(Me.dgvCitasEnLaFecha)
        Me.Controls.Add(Me.dtpFechaSeleccionada)
        Me.Controls.Add(Me.lblFechaSeleccionada)
        Me.Controls.Add(Me.dgvAuxiliar)
        Me.Controls.Add(Me.botonsito)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button1)
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
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgvPacientes As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txbAnotaciones As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents botonsito As System.Windows.Forms.Button
    Friend WithEvents dgvAuxiliar As System.Windows.Forms.DataGridView
    Friend WithEvents lblCitasEnLaFceha As System.Windows.Forms.Label
    Friend WithEvents dgvCitasEnLaFecha As System.Windows.Forms.DataGridView
    Friend WithEvents dtpFechaSeleccionada As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFechaSeleccionada As System.Windows.Forms.Label
End Class
