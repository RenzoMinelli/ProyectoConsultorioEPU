<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCitas
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
        Me.MCFecha = New System.Windows.Forms.MonthCalendar()
        Me.btnAgregarCita = New System.Windows.Forms.Button()
        Me.btnMarcarCita = New System.Windows.Forms.Button()
        Me.LabelDia = New System.Windows.Forms.Label()
        Me.seleccionado = New System.Windows.Forms.Label()
        Me.dgvHora = New System.Windows.Forms.DataGridView()
        Me.dgvConsultaDia = New System.Windows.Forms.DataGridView()
        Me.dgvDatosCita = New System.Windows.Forms.DataGridView()
        Me.btnCambiarCita = New System.Windows.Forms.Button()
        CType(Me.dgvHora, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvConsultaDia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvDatosCita, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MCFecha
        '
        Me.MCFecha.Location = New System.Drawing.Point(12, 504)
        Me.MCFecha.Name = "MCFecha"
        Me.MCFecha.TabIndex = 0
        '
        'btnAgregarCita
        '
        Me.btnAgregarCita.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.btnAgregarCita.Location = New System.Drawing.Point(12, 390)
        Me.btnAgregarCita.Name = "btnAgregarCita"
        Me.btnAgregarCita.Size = New System.Drawing.Size(248, 90)
        Me.btnAgregarCita.TabIndex = 2
        Me.btnAgregarCita.Text = "Agregar cita"
        Me.btnAgregarCita.UseVisualStyleBackColor = True
        Me.btnAgregarCita.Visible = False
        '
        'btnMarcarCita
        '
        Me.btnMarcarCita.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.btnMarcarCita.Location = New System.Drawing.Point(12, 12)
        Me.btnMarcarCita.Name = "btnMarcarCita"
        Me.btnMarcarCita.Size = New System.Drawing.Size(248, 90)
        Me.btnMarcarCita.TabIndex = 5
        Me.btnMarcarCita.Text = "Marcar cita como concluida"
        Me.btnMarcarCita.UseVisualStyleBackColor = True
        '
        'LabelDia
        '
        Me.LabelDia.AutoSize = True
        Me.LabelDia.Location = New System.Drawing.Point(1411, 543)
        Me.LabelDia.Name = "LabelDia"
        Me.LabelDia.Size = New System.Drawing.Size(45, 13)
        Me.LabelDia.TabIndex = 11
        Me.LabelDia.Text = "labelDia"
        '
        'seleccionado
        '
        Me.seleccionado.AutoSize = True
        Me.seleccionado.Location = New System.Drawing.Point(1411, 510)
        Me.seleccionado.Name = "seleccionado"
        Me.seleccionado.Size = New System.Drawing.Size(88, 13)
        Me.seleccionado.TabIndex = 12
        Me.seleccionado.Text = "DiaSeleccionado"
        '
        'dgvHora
        '
        Me.dgvHora.AllowUserToAddRows = False
        Me.dgvHora.AllowUserToDeleteRows = False
        Me.dgvHora.AllowUserToOrderColumns = True
        Me.dgvHora.AllowUserToResizeColumns = False
        Me.dgvHora.AllowUserToResizeRows = False
        Me.dgvHora.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvHora.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvHora.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvHora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvHora.DefaultCellStyle = DataGridViewCellStyle8
        Me.dgvHora.Location = New System.Drawing.Point(272, 12)
        Me.dgvHora.Name = "dgvHora"
        Me.dgvHora.ReadOnly = True
        Me.dgvHora.RowHeadersVisible = False
        Me.dgvHora.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgvHora.Size = New System.Drawing.Size(894, 654)
        Me.dgvHora.TabIndex = 13
        '
        'dgvConsultaDia
        '
        Me.dgvConsultaDia.AllowUserToAddRows = False
        Me.dgvConsultaDia.AllowUserToDeleteRows = False
        Me.dgvConsultaDia.AllowUserToOrderColumns = True
        Me.dgvConsultaDia.AllowUserToResizeColumns = False
        Me.dgvConsultaDia.AllowUserToResizeRows = False
        Me.dgvConsultaDia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvConsultaDia.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvConsultaDia.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.dgvConsultaDia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvConsultaDia.DefaultCellStyle = DataGridViewCellStyle10
        Me.dgvConsultaDia.Location = New System.Drawing.Point(40, 696)
        Me.dgvConsultaDia.Name = "dgvConsultaDia"
        Me.dgvConsultaDia.ReadOnly = True
        Me.dgvConsultaDia.RowHeadersVisible = False
        Me.dgvConsultaDia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvConsultaDia.Size = New System.Drawing.Size(25, 22)
        Me.dgvConsultaDia.TabIndex = 15
        Me.dgvConsultaDia.Visible = False
        '
        'dgvDatosCita
        '
        Me.dgvDatosCita.AllowUserToAddRows = False
        Me.dgvDatosCita.AllowUserToDeleteRows = False
        Me.dgvDatosCita.AllowUserToOrderColumns = True
        Me.dgvDatosCita.AllowUserToResizeColumns = False
        Me.dgvDatosCita.AllowUserToResizeRows = False
        Me.dgvDatosCita.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvDatosCita.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDatosCita.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.dgvDatosCita.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvDatosCita.DefaultCellStyle = DataGridViewCellStyle12
        Me.dgvDatosCita.Location = New System.Drawing.Point(71, 696)
        Me.dgvDatosCita.Name = "dgvDatosCita"
        Me.dgvDatosCita.ReadOnly = True
        Me.dgvDatosCita.RowHeadersVisible = False
        Me.dgvDatosCita.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDatosCita.Size = New System.Drawing.Size(10, 23)
        Me.dgvDatosCita.TabIndex = 16
        '
        'btnCambiarCita
        '
        Me.btnCambiarCita.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.btnCambiarCita.Location = New System.Drawing.Point(12, 127)
        Me.btnCambiarCita.Name = "btnCambiarCita"
        Me.btnCambiarCita.Size = New System.Drawing.Size(248, 90)
        Me.btnCambiarCita.TabIndex = 17
        Me.btnCambiarCita.Text = "Cambiar Fecha u Hora de Cita"
        Me.btnCambiarCita.UseVisualStyleBackColor = True
        '
        'frmCitas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1386, 788)
        Me.Controls.Add(Me.btnCambiarCita)
        Me.Controls.Add(Me.dgvDatosCita)
        Me.Controls.Add(Me.dgvConsultaDia)
        Me.Controls.Add(Me.seleccionado)
        Me.Controls.Add(Me.LabelDia)
        Me.Controls.Add(Me.btnMarcarCita)
        Me.Controls.Add(Me.btnAgregarCita)
        Me.Controls.Add(Me.MCFecha)
        Me.Controls.Add(Me.dgvHora)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmCitas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Citas"
        CType(Me.dgvHora, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvConsultaDia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvDatosCita, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MCFecha As System.Windows.Forms.MonthCalendar
    Friend WithEvents btnAgregarCita As System.Windows.Forms.Button
    Friend WithEvents btnMarcarCita As System.Windows.Forms.Button
    Friend WithEvents LabelDia As System.Windows.Forms.Label
    Friend WithEvents seleccionado As System.Windows.Forms.Label
    Friend WithEvents dgvHora As System.Windows.Forms.DataGridView
    Friend WithEvents dgvConsultaDia As System.Windows.Forms.DataGridView
    Friend WithEvents dgvDatosCita As System.Windows.Forms.DataGridView
    Friend WithEvents btnCambiarCita As System.Windows.Forms.Button
End Class
