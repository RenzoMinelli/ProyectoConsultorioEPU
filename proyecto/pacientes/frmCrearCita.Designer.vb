<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCrearCita
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnCrear = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.lblFechaSeleccionada = New System.Windows.Forms.Label()
        Me.dtpFechaSeleccionada = New System.Windows.Forms.DateTimePicker()
        Me.txbAnotaciones = New System.Windows.Forms.TextBox()
        Me.lblAnotaciones = New System.Windows.Forms.Label()
        Me.dgvCitasEnLaFecha = New System.Windows.Forms.DataGridView()
        Me.lblCitasEnLaFceha = New System.Windows.Forms.Label()
        Me.dgvAuxiliar = New System.Windows.Forms.DataGridView()
        CType(Me.dgvCitasEnLaFecha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvAuxiliar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCrear
        '
        Me.btnCrear.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCrear.Image = Global.WindowsApplication1.My.Resources.Resources.checkmark
        Me.btnCrear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCrear.Location = New System.Drawing.Point(864, 492)
        Me.btnCrear.Name = "btnCrear"
        Me.btnCrear.Size = New System.Drawing.Size(138, 62)
        Me.btnCrear.TabIndex = 3
        Me.btnCrear.Text = "Crear"
        Me.btnCrear.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCrear.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Image = Global.WindowsApplication1.My.Resources.Resources.X
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(69, 492)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(154, 62)
        Me.btnCancelar.TabIndex = 4
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'lblFechaSeleccionada
        '
        Me.lblFechaSeleccionada.AutoSize = True
        Me.lblFechaSeleccionada.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaSeleccionada.Location = New System.Drawing.Point(64, 67)
        Me.lblFechaSeleccionada.Name = "lblFechaSeleccionada"
        Me.lblFechaSeleccionada.Size = New System.Drawing.Size(239, 29)
        Me.lblFechaSeleccionada.TabIndex = 13
        Me.lblFechaSeleccionada.Text = "Fecha Seleccionada:"
        '
        'dtpFechaSeleccionada
        '
        Me.dtpFechaSeleccionada.CustomFormat = "dd/MM/yyyy        HH:mm"
        Me.dtpFechaSeleccionada.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaSeleccionada.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFechaSeleccionada.Location = New System.Drawing.Point(68, 103)
        Me.dtpFechaSeleccionada.Name = "dtpFechaSeleccionada"
        Me.dtpFechaSeleccionada.Size = New System.Drawing.Size(271, 35)
        Me.dtpFechaSeleccionada.TabIndex = 15
        '
        'txbAnotaciones
        '
        Me.txbAnotaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbAnotaciones.Location = New System.Drawing.Point(68, 214)
        Me.txbAnotaciones.Multiline = True
        Me.txbAnotaciones.Name = "txbAnotaciones"
        Me.txbAnotaciones.Size = New System.Drawing.Size(403, 102)
        Me.txbAnotaciones.TabIndex = 16
        '
        'lblAnotaciones
        '
        Me.lblAnotaciones.AutoSize = True
        Me.lblAnotaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnotaciones.Location = New System.Drawing.Point(64, 174)
        Me.lblAnotaciones.Name = "lblAnotaciones"
        Me.lblAnotaciones.Size = New System.Drawing.Size(151, 29)
        Me.lblAnotaciones.TabIndex = 17
        Me.lblAnotaciones.Text = "Anotaciones:"
        '
        'dgvCitasEnLaFecha
        '
        Me.dgvCitasEnLaFecha.AllowUserToAddRows = False
        Me.dgvCitasEnLaFecha.AllowUserToDeleteRows = False
        Me.dgvCitasEnLaFecha.AllowUserToResizeColumns = False
        Me.dgvCitasEnLaFecha.AllowUserToResizeRows = False
        Me.dgvCitasEnLaFecha.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvCitasEnLaFecha.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCitasEnLaFecha.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvCitasEnLaFecha.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCitasEnLaFecha.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvCitasEnLaFecha.Location = New System.Drawing.Point(553, 103)
        Me.dgvCitasEnLaFecha.Name = "dgvCitasEnLaFecha"
        Me.dgvCitasEnLaFecha.ReadOnly = True
        Me.dgvCitasEnLaFecha.RowHeadersVisible = False
        Me.dgvCitasEnLaFecha.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCitasEnLaFecha.Size = New System.Drawing.Size(449, 213)
        Me.dgvCitasEnLaFecha.TabIndex = 18
        '
        'lblCitasEnLaFceha
        '
        Me.lblCitasEnLaFceha.AutoSize = True
        Me.lblCitasEnLaFceha.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCitasEnLaFceha.Location = New System.Drawing.Point(548, 67)
        Me.lblCitasEnLaFceha.Name = "lblCitasEnLaFceha"
        Me.lblCitasEnLaFceha.Size = New System.Drawing.Size(286, 29)
        Me.lblCitasEnLaFceha.TabIndex = 19
        Me.lblCitasEnLaFceha.Text = "Citas Agendadas ese día:"
        '
        'dgvAuxiliar
        '
        Me.dgvAuxiliar.AllowUserToAddRows = False
        Me.dgvAuxiliar.AllowUserToDeleteRows = False
        Me.dgvAuxiliar.AllowUserToResizeColumns = False
        Me.dgvAuxiliar.AllowUserToResizeRows = False
        Me.dgvAuxiliar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvAuxiliar.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvAuxiliar.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvAuxiliar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvAuxiliar.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgvAuxiliar.Location = New System.Drawing.Point(938, 12)
        Me.dgvAuxiliar.Name = "dgvAuxiliar"
        Me.dgvAuxiliar.ReadOnly = True
        Me.dgvAuxiliar.RowHeadersVisible = False
        Me.dgvAuxiliar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvAuxiliar.Size = New System.Drawing.Size(22, 21)
        Me.dgvAuxiliar.TabIndex = 21
        Me.dgvAuxiliar.Visible = False
        '
        'frmCrearCita
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1030, 607)
        Me.Controls.Add(Me.dgvAuxiliar)
        Me.Controls.Add(Me.lblCitasEnLaFceha)
        Me.Controls.Add(Me.dgvCitasEnLaFecha)
        Me.Controls.Add(Me.lblAnotaciones)
        Me.Controls.Add(Me.txbAnotaciones)
        Me.Controls.Add(Me.dtpFechaSeleccionada)
        Me.Controls.Add(Me.lblFechaSeleccionada)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnCrear)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmCrearCita"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.dgvCitasEnLaFecha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvAuxiliar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCrear As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents lblFechaSeleccionada As System.Windows.Forms.Label
    Friend WithEvents dtpFechaSeleccionada As System.Windows.Forms.DateTimePicker
    Friend WithEvents txbAnotaciones As System.Windows.Forms.TextBox
    Friend WithEvents lblAnotaciones As System.Windows.Forms.Label
    Friend WithEvents dgvCitasEnLaFecha As System.Windows.Forms.DataGridView
    Friend WithEvents lblCitasEnLaFceha As System.Windows.Forms.Label
    Friend WithEvents dgvAuxiliar As System.Windows.Forms.DataGridView
End Class
