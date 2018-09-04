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
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvLunes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.dgvLunes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvLunes.DefaultCellStyle = DataGridViewCellStyle12
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
        Me.Button3.Location = New System.Drawing.Point(45, 501)
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
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvMartes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle13
        Me.dgvMartes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvMartes.DefaultCellStyle = DataGridViewCellStyle14
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
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvMiercoles.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle15
        Me.dgvMiercoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvMiercoles.DefaultCellStyle = DataGridViewCellStyle16
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
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle17.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvJueves.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle17
        Me.dgvJueves.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle18.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvJueves.DefaultCellStyle = DataGridViewCellStyle18
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
        DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle19.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvViernes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle19
        Me.dgvViernes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle20.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvViernes.DefaultCellStyle = DataGridViewCellStyle20
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
        CType(Me.dgvauxiliar, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents dgvauxiliar As System.Windows.Forms.DataGridView
End Class
