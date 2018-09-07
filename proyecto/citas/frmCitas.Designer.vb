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
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle24 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle25 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle26 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle27 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle28 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle29 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle30 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dgvLunes = New System.Windows.Forms.DataGridView()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.dgvMartes = New System.Windows.Forms.DataGridView()
        Me.dgvMiercoles = New System.Windows.Forms.DataGridView()
        Me.dgvJueves = New System.Windows.Forms.DataGridView()
        Me.dgvViernes = New System.Windows.Forms.DataGridView()
        Me.dgvauxiliar = New System.Windows.Forms.DataGridView()
        CType(Me.dgvLunes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvMartes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvMiercoles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvJueves, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvViernes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvauxiliar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.CalendarDimensions = New System.Drawing.Size(1, 2)
        Me.MonthCalendar1.Location = New System.Drawing.Point(6, 103)
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
        DataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle21.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvLunes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle21
        Me.dgvLunes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle22.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvLunes.DefaultCellStyle = DataGridViewCellStyle22
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
        Me.Button2.Text = "Marcar cita como concluida"
        Me.Button2.UseVisualStyleBackColor = True
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
        DataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle23.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvMartes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle23
        Me.dgvMartes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle24.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle24.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle24.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvMartes.DefaultCellStyle = DataGridViewCellStyle24
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
        DataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle25.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle25.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle25.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle25.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle25.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvMiercoles.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle25
        Me.dgvMiercoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle26.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle26.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle26.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle26.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvMiercoles.DefaultCellStyle = DataGridViewCellStyle26
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
        DataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle27.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle27.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle27.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle27.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle27.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvJueves.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle27
        Me.dgvJueves.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle28.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle28.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle28.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle28.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle28.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvJueves.DefaultCellStyle = DataGridViewCellStyle28
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
        DataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle29.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle29.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle29.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle29.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle29.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvViernes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle29
        Me.dgvViernes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle30.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle30.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle30.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle30.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle30.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvViernes.DefaultCellStyle = DataGridViewCellStyle30
        Me.dgvViernes.Location = New System.Drawing.Point(817, 103)
        Me.dgvViernes.Name = "dgvViernes"
        Me.dgvViernes.ReadOnly = True
        Me.dgvViernes.RowHeadersVisible = False
        Me.dgvViernes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvViernes.Size = New System.Drawing.Size(134, 311)
        Me.dgvViernes.TabIndex = 10
        '
        'dgvauxiliar
        '
        Me.dgvauxiliar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvauxiliar.Location = New System.Drawing.Point(918, 552)
        Me.dgvauxiliar.Name = "dgvauxiliar"
        Me.dgvauxiliar.Size = New System.Drawing.Size(33, 37)
        Me.dgvauxiliar.TabIndex = 11
        '
        'Citas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(976, 635)
        Me.Controls.Add(Me.dgvauxiliar)
        Me.Controls.Add(Me.dgvViernes)
        Me.Controls.Add(Me.dgvJueves)
        Me.Controls.Add(Me.dgvMiercoles)
        Me.Controls.Add(Me.dgvMartes)
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
        CType(Me.dgvauxiliar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MonthCalendar1 As System.Windows.Forms.MonthCalendar
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents dgvLunes As System.Windows.Forms.DataGridView
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents dgvMartes As System.Windows.Forms.DataGridView
    Friend WithEvents dgvMiercoles As System.Windows.Forms.DataGridView
    Friend WithEvents dgvJueves As System.Windows.Forms.DataGridView
    Friend WithEvents dgvViernes As System.Windows.Forms.DataGridView
    Friend WithEvents dgvauxiliar As System.Windows.Forms.DataGridView
End Class
