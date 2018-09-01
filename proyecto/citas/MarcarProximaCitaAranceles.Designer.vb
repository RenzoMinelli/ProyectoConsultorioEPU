<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MarcarProximaCitaAranceles
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
        Me.dgvAranceles = New System.Windows.Forms.DataGridView()
        Me.lblAranceles = New System.Windows.Forms.Label()
        Me.dgvArancelesSelect = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvAuxiliar = New System.Windows.Forms.DataGridView()
        Me.btnIngresarDesc = New System.Windows.Forms.Button()
        Me.btnModificarPrecio = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        CType(Me.dgvAranceles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvArancelesSelect, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvAuxiliar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvAranceles
        '
        Me.dgvAranceles.AllowUserToAddRows = False
        Me.dgvAranceles.AllowUserToDeleteRows = False
        Me.dgvAranceles.AllowUserToResizeColumns = False
        Me.dgvAranceles.AllowUserToResizeRows = False
        Me.dgvAranceles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvAranceles.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvAranceles.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvAranceles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvAranceles.DefaultCellStyle = DataGridViewCellStyle8
        Me.dgvAranceles.Location = New System.Drawing.Point(12, 54)
        Me.dgvAranceles.Name = "dgvAranceles"
        Me.dgvAranceles.ReadOnly = True
        Me.dgvAranceles.RowHeadersVisible = False
        Me.dgvAranceles.Size = New System.Drawing.Size(515, 235)
        Me.dgvAranceles.TabIndex = 0
        '
        'lblAranceles
        '
        Me.lblAranceles.AutoSize = True
        Me.lblAranceles.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAranceles.Location = New System.Drawing.Point(12, 22)
        Me.lblAranceles.Name = "lblAranceles"
        Me.lblAranceles.Size = New System.Drawing.Size(377, 29)
        Me.lblAranceles.TabIndex = 1
        Me.lblAranceles.Text = "Aranceles previamente marcados:"
        '
        'dgvArancelesSelect
        '
        Me.dgvArancelesSelect.AllowUserToAddRows = False
        Me.dgvArancelesSelect.AllowUserToDeleteRows = False
        Me.dgvArancelesSelect.AllowUserToResizeColumns = False
        Me.dgvArancelesSelect.AllowUserToResizeRows = False
        Me.dgvArancelesSelect.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvArancelesSelect.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvArancelesSelect.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.dgvArancelesSelect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvArancelesSelect.DefaultCellStyle = DataGridViewCellStyle10
        Me.dgvArancelesSelect.Location = New System.Drawing.Point(552, 54)
        Me.dgvArancelesSelect.Name = "dgvArancelesSelect"
        Me.dgvArancelesSelect.ReadOnly = True
        Me.dgvArancelesSelect.RowHeadersVisible = False
        Me.dgvArancelesSelect.Size = New System.Drawing.Size(479, 235)
        Me.dgvArancelesSelect.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(547, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(344, 29)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Aranceles realizados en la cita:"
        '
        'dgvAuxiliar
        '
        Me.dgvAuxiliar.AllowUserToAddRows = False
        Me.dgvAuxiliar.AllowUserToDeleteRows = False
        Me.dgvAuxiliar.AllowUserToResizeColumns = False
        Me.dgvAuxiliar.AllowUserToResizeRows = False
        Me.dgvAuxiliar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvAuxiliar.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvAuxiliar.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.dgvAuxiliar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvAuxiliar.DefaultCellStyle = DataGridViewCellStyle12
        Me.dgvAuxiliar.Location = New System.Drawing.Point(1013, 22)
        Me.dgvAuxiliar.Name = "dgvAuxiliar"
        Me.dgvAuxiliar.ReadOnly = True
        Me.dgvAuxiliar.RowHeadersVisible = False
        Me.dgvAuxiliar.Size = New System.Drawing.Size(18, 23)
        Me.dgvAuxiliar.TabIndex = 4
        Me.dgvAuxiliar.Visible = False
        '
        'btnIngresarDesc
        '
        Me.btnIngresarDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIngresarDesc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnIngresarDesc.Location = New System.Drawing.Point(700, 311)
        Me.btnIngresarDesc.Name = "btnIngresarDesc"
        Me.btnIngresarDesc.Size = New System.Drawing.Size(166, 84)
        Me.btnIngresarDesc.TabIndex = 12
        Me.btnIngresarDesc.Text = "Ingresar descripción específica"
        Me.btnIngresarDesc.UseVisualStyleBackColor = True
        Me.btnIngresarDesc.Visible = False
        '
        'btnModificarPrecio
        '
        Me.btnModificarPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificarPrecio.Image = Global.WindowsApplication1.My.Resources.Resources.fac159a300a5cd5efbd3c544cb37d3b0_1_
        Me.btnModificarPrecio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModificarPrecio.Location = New System.Drawing.Point(872, 311)
        Me.btnModificarPrecio.Name = "btnModificarPrecio"
        Me.btnModificarPrecio.Size = New System.Drawing.Size(159, 84)
        Me.btnModificarPrecio.TabIndex = 11
        Me.btnModificarPrecio.Text = "Modificar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Precio"
        Me.btnModificarPrecio.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnModificarPrecio.UseVisualStyleBackColor = True
        Me.btnModificarPrecio.Visible = False
        '
        'btnEliminar
        '
        Me.btnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.Image = Global.WindowsApplication1.My.Resources.Resources.delete
        Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEliminar.Location = New System.Drawing.Point(550, 312)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(130, 84)
        Me.btnEliminar.TabIndex = 10
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEliminar.UseVisualStyleBackColor = True
        Me.btnEliminar.Visible = False
        '
        'btnGuardar
        '
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardar.Location = New System.Drawing.Point(454, 469)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(166, 84)
        Me.btnGuardar.TabIndex = 13
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'MarcarProximaCitaAranceles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1146, 624)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnIngresarDesc)
        Me.Controls.Add(Me.btnModificarPrecio)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.dgvAuxiliar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvArancelesSelect)
        Me.Controls.Add(Me.lblAranceles)
        Me.Controls.Add(Me.dgvAranceles)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MarcarProximaCitaAranceles"
        Me.Text = "MarcarCosasCitas"
        CType(Me.dgvAranceles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvArancelesSelect, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvAuxiliar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvAranceles As System.Windows.Forms.DataGridView
    Friend WithEvents lblAranceles As System.Windows.Forms.Label
    Friend WithEvents dgvArancelesSelect As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgvAuxiliar As System.Windows.Forms.DataGridView
    Friend WithEvents btnIngresarDesc As System.Windows.Forms.Button
    Friend WithEvents btnModificarPrecio As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
End Class
