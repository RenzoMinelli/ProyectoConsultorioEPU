<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmModificarCita
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
        Me.dgvCitasEnLaFecha = New System.Windows.Forms.DataGridView()
        Me.txbDuracion = New System.Windows.Forms.TextBox()
        Me.lblDuracion = New System.Windows.Forms.Label()
        Me.dgvAuxiliar = New System.Windows.Forms.DataGridView()
        Me.btnRegresar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.txbAnotaciones = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvTratamientos = New System.Windows.Forms.DataGridView()
        CType(Me.dgvCitasEnLaFecha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvAuxiliar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvTratamientos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvCitasEnLaFecha
        '
        Me.dgvCitasEnLaFecha.AllowUserToAddRows = False
        Me.dgvCitasEnLaFecha.AllowUserToDeleteRows = False
        Me.dgvCitasEnLaFecha.AllowUserToResizeColumns = False
        Me.dgvCitasEnLaFecha.AllowUserToResizeRows = False
        Me.dgvCitasEnLaFecha.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvCitasEnLaFecha.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvCitasEnLaFecha.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCitasEnLaFecha.Location = New System.Drawing.Point(621, 17)
        Me.dgvCitasEnLaFecha.Name = "dgvCitasEnLaFecha"
        Me.dgvCitasEnLaFecha.ReadOnly = True
        Me.dgvCitasEnLaFecha.RowHeadersVisible = False
        Me.dgvCitasEnLaFecha.Size = New System.Drawing.Size(367, 79)
        Me.dgvCitasEnLaFecha.TabIndex = 48
        '
        'txbDuracion
        '
        Me.txbDuracion.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbDuracion.Location = New System.Drawing.Point(798, 185)
        Me.txbDuracion.Name = "txbDuracion"
        Me.txbDuracion.Size = New System.Drawing.Size(36, 29)
        Me.txbDuracion.TabIndex = 45
        '
        'lblDuracion
        '
        Me.lblDuracion.AutoSize = True
        Me.lblDuracion.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDuracion.Location = New System.Drawing.Point(710, 125)
        Me.lblDuracion.Name = "lblDuracion"
        Me.lblDuracion.Size = New System.Drawing.Size(192, 29)
        Me.lblDuracion.TabIndex = 44
        Me.lblDuracion.Text = "Duracion de cita:"
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
        Me.dgvAuxiliar.Location = New System.Drawing.Point(1007, 17)
        Me.dgvAuxiliar.Name = "dgvAuxiliar"
        Me.dgvAuxiliar.ReadOnly = True
        Me.dgvAuxiliar.RowHeadersVisible = False
        Me.dgvAuxiliar.Size = New System.Drawing.Size(21, 13)
        Me.dgvAuxiliar.TabIndex = 40
        Me.dgvAuxiliar.Visible = False
        '
        'btnRegresar
        '
        Me.btnRegresar.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegresar.Location = New System.Drawing.Point(17, 521)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(231, 79)
        Me.btnRegresar.TabIndex = 39
        Me.btnRegresar.Text = "Regresar"
        Me.btnRegresar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Location = New System.Drawing.Point(789, 520)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(239, 80)
        Me.btnGuardar.TabIndex = 38
        Me.btnGuardar.Text = "Guardar cita"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'txbAnotaciones
        '
        Me.txbAnotaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbAnotaciones.Location = New System.Drawing.Point(12, 317)
        Me.txbAnotaciones.Multiline = True
        Me.txbAnotaciones.Name = "txbAnotaciones"
        Me.txbAnotaciones.Size = New System.Drawing.Size(546, 183)
        Me.txbAnotaciones.TabIndex = 36
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.Label4.Location = New System.Drawing.Point(12, 273)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(151, 29)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Anotaciones:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.Label2.Location = New System.Drawing.Point(7, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(382, 29)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "Tratamientos Activos del Paciente:"
        '
        'dgvTratamientos
        '
        Me.dgvTratamientos.AllowUserToAddRows = False
        Me.dgvTratamientos.AllowUserToDeleteRows = False
        Me.dgvTratamientos.AllowUserToResizeColumns = False
        Me.dgvTratamientos.AllowUserToResizeRows = False
        Me.dgvTratamientos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvTratamientos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvTratamientos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvTratamientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvTratamientos.DefaultCellStyle = DataGridViewCellStyle8
        Me.dgvTratamientos.Location = New System.Drawing.Point(12, 73)
        Me.dgvTratamientos.Name = "dgvTratamientos"
        Me.dgvTratamientos.ReadOnly = True
        Me.dgvTratamientos.RowHeadersVisible = False
        Me.dgvTratamientos.Size = New System.Drawing.Size(546, 183)
        Me.dgvTratamientos.TabIndex = 42
        '
        'frmModificarCita
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1037, 619)
        Me.Controls.Add(Me.dgvCitasEnLaFecha)
        Me.Controls.Add(Me.txbDuracion)
        Me.Controls.Add(Me.lblDuracion)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgvTratamientos)
        Me.Controls.Add(Me.dgvAuxiliar)
        Me.Controls.Add(Me.btnRegresar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.txbAnotaciones)
        Me.Controls.Add(Me.Label4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmModificarCita"
        Me.Text = "frmModificarCita"
        CType(Me.dgvCitasEnLaFecha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvAuxiliar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvTratamientos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvCitasEnLaFecha As System.Windows.Forms.DataGridView
    Friend WithEvents txbDuracion As System.Windows.Forms.TextBox
    Friend WithEvents lblDuracion As System.Windows.Forms.Label
    Friend WithEvents dgvAuxiliar As System.Windows.Forms.DataGridView
    Friend WithEvents btnRegresar As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents txbAnotaciones As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dgvTratamientos As System.Windows.Forms.DataGridView
End Class
