<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Citas
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dgvLunes = New System.Windows.Forms.DataGridView()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.dgvMartes = New System.Windows.Forms.DataGridView()
        Me.dgvMiercoles = New System.Windows.Forms.DataGridView()
        Me.dgvJueves = New System.Windows.Forms.DataGridView()
        Me.dgvViernes = New System.Windows.Forms.DataGridView()
        CType(Me.dgvLunes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvMartes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvMiercoles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvJueves, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvViernes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.CalendarDimensions = New System.Drawing.Size(1, 2)
        Me.MonthCalendar1.Location = New System.Drawing.Point(18, 103)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.Label1.Location = New System.Drawing.Point(14, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(350, 29)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Ingrese el día para ver las citas:"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.Button1.Location = New System.Drawing.Point(601, 506)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(248, 83)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "agregar cita"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'dgvLunes
        '
        Me.dgvLunes.AllowUserToAddRows = False
        Me.dgvLunes.AllowUserToDeleteRows = False
        Me.dgvLunes.AllowUserToOrderColumns = True
        Me.dgvLunes.AllowUserToResizeColumns = False
        Me.dgvLunes.AllowUserToResizeRows = False
        Me.dgvLunes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvLunes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvLunes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvLunes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvLunes.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvLunes.Location = New System.Drawing.Point(257, 103)
        Me.dgvLunes.Name = "dgvLunes"
        Me.dgvLunes.ReadOnly = True
        Me.dgvLunes.RowHeadersVisible = False
        Me.dgvLunes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvLunes.Size = New System.Drawing.Size(134, 311)
        Me.dgvLunes.TabIndex = 4
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.Button2.Location = New System.Drawing.Point(303, 502)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(248, 90)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "marcar cita como concluida"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.Button3.Location = New System.Drawing.Point(50, 486)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(200, 88)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "plan tratamiento (ALPHA)"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'dgvMartes
        '
        Me.dgvMartes.AllowUserToAddRows = False
        Me.dgvMartes.AllowUserToDeleteRows = False
        Me.dgvMartes.AllowUserToOrderColumns = True
        Me.dgvMartes.AllowUserToResizeColumns = False
        Me.dgvMartes.AllowUserToResizeRows = False
        Me.dgvMartes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvMartes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvMartes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvMartes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvMartes.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgvMartes.Location = New System.Drawing.Point(397, 103)
        Me.dgvMartes.Name = "dgvMartes"
        Me.dgvMartes.ReadOnly = True
        Me.dgvMartes.RowHeadersVisible = False
        Me.dgvMartes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvMartes.Size = New System.Drawing.Size(134, 311)
        Me.dgvMartes.TabIndex = 7
        '
        'dgvMiercoles
        '
        Me.dgvMiercoles.AllowUserToAddRows = False
        Me.dgvMiercoles.AllowUserToDeleteRows = False
        Me.dgvMiercoles.AllowUserToOrderColumns = True
        Me.dgvMiercoles.AllowUserToResizeColumns = False
        Me.dgvMiercoles.AllowUserToResizeRows = False
        Me.dgvMiercoles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvMiercoles.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvMiercoles.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvMiercoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvMiercoles.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgvMiercoles.Location = New System.Drawing.Point(537, 103)
        Me.dgvMiercoles.Name = "dgvMiercoles"
        Me.dgvMiercoles.ReadOnly = True
        Me.dgvMiercoles.RowHeadersVisible = False
        Me.dgvMiercoles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvMiercoles.Size = New System.Drawing.Size(134, 311)
        Me.dgvMiercoles.TabIndex = 8
        '
        'dgvJueves
        '
        Me.dgvJueves.AllowUserToAddRows = False
        Me.dgvJueves.AllowUserToDeleteRows = False
        Me.dgvJueves.AllowUserToOrderColumns = True
        Me.dgvJueves.AllowUserToResizeColumns = False
        Me.dgvJueves.AllowUserToResizeRows = False
        Me.dgvJueves.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvJueves.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvJueves.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvJueves.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvJueves.DefaultCellStyle = DataGridViewCellStyle8
        Me.dgvJueves.Location = New System.Drawing.Point(677, 103)
        Me.dgvJueves.Name = "dgvJueves"
        Me.dgvJueves.ReadOnly = True
        Me.dgvJueves.RowHeadersVisible = False
        Me.dgvJueves.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvJueves.Size = New System.Drawing.Size(134, 311)
        Me.dgvJueves.TabIndex = 9
        '
        'dgvViernes
        '
        Me.dgvViernes.AllowUserToAddRows = False
        Me.dgvViernes.AllowUserToDeleteRows = False
        Me.dgvViernes.AllowUserToOrderColumns = True
        Me.dgvViernes.AllowUserToResizeColumns = False
        Me.dgvViernes.AllowUserToResizeRows = False
        Me.dgvViernes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvViernes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvViernes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.dgvViernes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvViernes.DefaultCellStyle = DataGridViewCellStyle10
        Me.dgvViernes.Location = New System.Drawing.Point(817, 103)
        Me.dgvViernes.Name = "dgvViernes"
        Me.dgvViernes.ReadOnly = True
        Me.dgvViernes.RowHeadersVisible = False
        Me.dgvViernes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvViernes.Size = New System.Drawing.Size(134, 311)
        Me.dgvViernes.TabIndex = 10
        '
        'Citas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(976, 635)
        Me.Controls.Add(Me.dgvViernes)
        Me.Controls.Add(Me.dgvJueves)
        Me.Controls.Add(Me.dgvMiercoles)
        Me.Controls.Add(Me.dgvMartes)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.dgvLunes)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Citas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Citas"
        CType(Me.dgvLunes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvMartes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvMiercoles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvJueves, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvViernes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MonthCalendar1 As System.Windows.Forms.MonthCalendar
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents dgvLunes As System.Windows.Forms.DataGridView
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents dgvMartes As System.Windows.Forms.DataGridView
    Friend WithEvents dgvMiercoles As System.Windows.Forms.DataGridView
    Friend WithEvents dgvJueves As System.Windows.Forms.DataGridView
    Friend WithEvents dgvViernes As System.Windows.Forms.DataGridView
End Class
