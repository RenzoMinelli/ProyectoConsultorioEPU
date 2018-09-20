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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MCFecha = New System.Windows.Forms.MonthCalendar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.LabelDia = New System.Windows.Forms.Label()
        Me.seleccionado = New System.Windows.Forms.Label()
        Me.dgvHora = New System.Windows.Forms.DataGridView()
        Me.dgvConsultaDia = New System.Windows.Forms.DataGridView()
        Me.dgvDatosCita = New System.Windows.Forms.DataGridView()
        CType(Me.dgvHora, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvConsultaDia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvDatosCita, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MCFecha
        '
        Me.MCFecha.Location = New System.Drawing.Point(14, 573)
        Me.MCFecha.Name = "MCFecha"
        Me.MCFecha.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.Label1.Location = New System.Drawing.Point(516, 702)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(219, 58)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Ingrese el día para " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ver las citas:"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.Button1.Location = New System.Drawing.Point(274, 702)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(227, 90)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "agregar cita"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.Button2.Location = New System.Drawing.Point(1166, 77)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(227, 90)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Marcar cita como concluida"
        Me.Button2.UseVisualStyleBackColor = True
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
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvHora.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvHora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvHora.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgvHora.Location = New System.Drawing.Point(14, 12)
        Me.dgvHora.Name = "dgvHora"
        Me.dgvHora.ReadOnly = True
        Me.dgvHora.RowHeadersVisible = False
        Me.dgvHora.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgvHora.Size = New System.Drawing.Size(1140, 661)
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
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvConsultaDia.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvConsultaDia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvConsultaDia.DefaultCellStyle = DataGridViewCellStyle8
        Me.dgvConsultaDia.Location = New System.Drawing.Point(1283, 12)
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
        Me.dgvDatosCita.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvDatosCita.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDatosCita.Location = New System.Drawing.Point(363, 301)
        Me.dgvDatosCita.Name = "dgvDatosCita"
        Me.dgvDatosCita.ReadOnly = True
        Me.dgvDatosCita.RowHeadersVisible = False
        Me.dgvDatosCita.Size = New System.Drawing.Size(312, 212)
        Me.dgvDatosCita.TabIndex = 16
        '
        'frmCitas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1183, 788)
        Me.Controls.Add(Me.dgvDatosCita)
        Me.Controls.Add(Me.dgvConsultaDia)
        Me.Controls.Add(Me.seleccionado)
        Me.Controls.Add(Me.LabelDia)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents LabelDia As System.Windows.Forms.Label
    Friend WithEvents seleccionado As System.Windows.Forms.Label
    Friend WithEvents dgvHora As System.Windows.Forms.DataGridView
    Friend WithEvents dgvConsultaDia As System.Windows.Forms.DataGridView
    Friend WithEvents dgvDatosCita As System.Windows.Forms.DataGridView
End Class
