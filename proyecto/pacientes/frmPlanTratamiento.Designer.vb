<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPlanTratamiento
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
        Me.dgvAranceles = New System.Windows.Forms.DataGridView()
        Me.lblAranceles = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvArancelesSelect = New System.Windows.Forms.DataGridView()
        Me.dgvAuxiliar = New System.Windows.Forms.DataGridView()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnModificarPrecio = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnModificarDesc = New System.Windows.Forms.Button()
        Me.btnMarcar = New System.Windows.Forms.Button()
        Me.btnPresupuesto = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.dgvDatos = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnMover = New System.Windows.Forms.Button()
        Me.txbBusqueda = New WindowsApplication1.WaterMarkTextBox()
        CType(Me.dgvAranceles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvArancelesSelect, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvAuxiliar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvAranceles
        '
        Me.dgvAranceles.AllowUserToAddRows = False
        Me.dgvAranceles.AllowUserToDeleteRows = False
        Me.dgvAranceles.AllowUserToResizeColumns = False
        Me.dgvAranceles.AllowUserToResizeRows = False
        Me.dgvAranceles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvAranceles.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvAranceles.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.dgvAranceles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvAranceles.DefaultCellStyle = DataGridViewCellStyle12
        Me.dgvAranceles.Location = New System.Drawing.Point(29, 135)
        Me.dgvAranceles.Name = "dgvAranceles"
        Me.dgvAranceles.ReadOnly = True
        Me.dgvAranceles.RowHeadersVisible = False
        Me.dgvAranceles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvAranceles.Size = New System.Drawing.Size(478, 269)
        Me.dgvAranceles.TabIndex = 0
        '
        'lblAranceles
        '
        Me.lblAranceles.AutoSize = True
        Me.lblAranceles.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAranceles.Location = New System.Drawing.Point(24, 35)
        Me.lblAranceles.Name = "lblAranceles"
        Me.lblAranceles.Size = New System.Drawing.Size(291, 29)
        Me.lblAranceles.TabIndex = 1
        Me.lblAranceles.Text = "Seleccione los Aranceles:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(629, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(258, 29)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Tratamientos en curso:"
        '
        'dgvArancelesSelect
        '
        Me.dgvArancelesSelect.AllowUserToAddRows = False
        Me.dgvArancelesSelect.AllowUserToDeleteRows = False
        Me.dgvArancelesSelect.AllowUserToResizeColumns = False
        Me.dgvArancelesSelect.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvArancelesSelect.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.dgvArancelesSelect.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle13
        Me.dgvArancelesSelect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvArancelesSelect.DefaultCellStyle = DataGridViewCellStyle14
        Me.dgvArancelesSelect.Location = New System.Drawing.Point(615, 76)
        Me.dgvArancelesSelect.Name = "dgvArancelesSelect"
        Me.dgvArancelesSelect.ReadOnly = True
        Me.dgvArancelesSelect.RowHeadersVisible = False
        Me.dgvArancelesSelect.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvArancelesSelect.Size = New System.Drawing.Size(532, 328)
        Me.dgvArancelesSelect.TabIndex = 3
        '
        'dgvAuxiliar
        '
        Me.dgvAuxiliar.AllowUserToAddRows = False
        Me.dgvAuxiliar.AllowUserToDeleteRows = False
        Me.dgvAuxiliar.AllowUserToResizeColumns = False
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvAuxiliar.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle15
        Me.dgvAuxiliar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvAuxiliar.DefaultCellStyle = DataGridViewCellStyle16
        Me.dgvAuxiliar.Location = New System.Drawing.Point(972, 12)
        Me.dgvAuxiliar.Name = "dgvAuxiliar"
        Me.dgvAuxiliar.ReadOnly = True
        Me.dgvAuxiliar.RowHeadersVisible = False
        Me.dgvAuxiliar.Size = New System.Drawing.Size(20, 19)
        Me.dgvAuxiliar.TabIndex = 4
        Me.dgvAuxiliar.Visible = False
        '
        'btnEliminar
        '
        Me.btnEliminar.Enabled = False
        Me.btnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.Image = Global.WindowsApplication1.My.Resources.Resources.IconoBorrar2
        Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEliminar.Location = New System.Drawing.Point(967, 438)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(159, 92)
        Me.btnEliminar.TabIndex = 5
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnModificarPrecio
        '
        Me.btnModificarPrecio.Enabled = False
        Me.btnModificarPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificarPrecio.Image = Global.WindowsApplication1.My.Resources.Resources.IconoMoneda
        Me.btnModificarPrecio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModificarPrecio.Location = New System.Drawing.Point(807, 438)
        Me.btnModificarPrecio.Name = "btnModificarPrecio"
        Me.btnModificarPrecio.Size = New System.Drawing.Size(159, 92)
        Me.btnModificarPrecio.TabIndex = 6
        Me.btnModificarPrecio.Text = "Modificar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Precio"
        Me.btnModificarPrecio.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnModificarPrecio.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Image = Global.WindowsApplication1.My.Resources.Resources.checkmark
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardar.Location = New System.Drawing.Point(198, 593)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(141, 70)
        Me.btnGuardar.TabIndex = 8
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnModificarDesc
        '
        Me.btnModificarDesc.Enabled = False
        Me.btnModificarDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificarDesc.Image = Global.WindowsApplication1.My.Resources.Resources.IconoEditar
        Me.btnModificarDesc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModificarDesc.Location = New System.Drawing.Point(634, 438)
        Me.btnModificarDesc.Name = "btnModificarDesc"
        Me.btnModificarDesc.Size = New System.Drawing.Size(173, 92)
        Me.btnModificarDesc.TabIndex = 9
        Me.btnModificarDesc.Text = "Modificar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "descripción" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "específica"
        Me.btnModificarDesc.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnModificarDesc.UseVisualStyleBackColor = True
        '
        'btnMarcar
        '
        Me.btnMarcar.Enabled = False
        Me.btnMarcar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMarcar.Image = Global.WindowsApplication1.My.Resources.Resources.IconoMarcarListo
        Me.btnMarcar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMarcar.Location = New System.Drawing.Point(807, 536)
        Me.btnMarcar.Name = "btnMarcar"
        Me.btnMarcar.Size = New System.Drawing.Size(159, 87)
        Me.btnMarcar.TabIndex = 10
        Me.btnMarcar.Text = "Marcar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "como" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "concluido"
        Me.btnMarcar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnMarcar.UseVisualStyleBackColor = True
        '
        'btnPresupuesto
        '
        Me.btnPresupuesto.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPresupuesto.Image = Global.WindowsApplication1.My.Resources.Resources.IconoImprimir
        Me.btnPresupuesto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPresupuesto.Location = New System.Drawing.Point(357, 593)
        Me.btnPresupuesto.Name = "btnPresupuesto"
        Me.btnPresupuesto.Size = New System.Drawing.Size(174, 70)
        Me.btnPresupuesto.TabIndex = 53
        Me.btnPresupuesto.Text = "Imprimir" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Presupuesto"
        Me.btnPresupuesto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPresupuesto.UseVisualStyleBackColor = True
        '
        'PrintDocument1
        '
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle17.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle17
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle18.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle18
        Me.DataGridView1.Location = New System.Drawing.Point(38, 503)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(16, 13)
        Me.DataGridView1.TabIndex = 56
        Me.DataGridView1.Visible = False
        '
        'dgvDatos
        '
        Me.dgvDatos.AllowUserToAddRows = False
        Me.dgvDatos.AllowUserToDeleteRows = False
        Me.dgvDatos.AllowUserToResizeColumns = False
        Me.dgvDatos.AllowUserToResizeRows = False
        Me.dgvDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvDatos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle19.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDatos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle19
        Me.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle20.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvDatos.DefaultCellStyle = DataGridViewCellStyle20
        Me.dgvDatos.Location = New System.Drawing.Point(38, 550)
        Me.dgvDatos.MultiSelect = False
        Me.dgvDatos.Name = "dgvDatos"
        Me.dgvDatos.ReadOnly = True
        Me.dgvDatos.RowHeadersVisible = False
        Me.dgvDatos.Size = New System.Drawing.Size(16, 13)
        Me.dgvDatos.TabIndex = 55
        Me.dgvDatos.Visible = False
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.WindowsApplication1.My.Resources.Resources.X
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(12, 593)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(161, 70)
        Me.Button1.TabIndex = 57
        Me.Button1.Text = "Cancelar"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnMover
        '
        Me.btnMover.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMover.Image = Global.WindowsApplication1.My.Resources.Resources.IconoFlechaIzquierda
        Me.btnMover.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnMover.Location = New System.Drawing.Point(518, 227)
        Me.btnMover.Name = "btnMover"
        Me.btnMover.Size = New System.Drawing.Size(86, 76)
        Me.btnMover.TabIndex = 58
        Me.btnMover.Text = "Mover"
        Me.btnMover.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnMover.UseVisualStyleBackColor = True
        Me.btnMover.Visible = False
        '
        'txbBusqueda
        '
        Me.txbBusqueda.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbBusqueda.Location = New System.Drawing.Point(29, 94)
        Me.txbBusqueda.Name = "txbBusqueda"
        Me.txbBusqueda.Size = New System.Drawing.Size(478, 31)
        Me.txbBusqueda.TabIndex = 59
        Me.txbBusqueda.WaterMarkColor = System.Drawing.Color.Gray
        Me.txbBusqueda.WaterMarkText = "Buscar"
        '
        'frmPlanTratamiento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1179, 684)
        Me.Controls.Add(Me.txbBusqueda)
        Me.Controls.Add(Me.btnMover)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.dgvDatos)
        Me.Controls.Add(Me.btnPresupuesto)
        Me.Controls.Add(Me.btnMarcar)
        Me.Controls.Add(Me.btnModificarDesc)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnModificarPrecio)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.dgvAuxiliar)
        Me.Controls.Add(Me.dgvArancelesSelect)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblAranceles)
        Me.Controls.Add(Me.dgvAranceles)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmPlanTratamiento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PlanTratamiento"
        CType(Me.dgvAranceles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvArancelesSelect, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvAuxiliar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvAranceles As System.Windows.Forms.DataGridView
    Friend WithEvents lblAranceles As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgvArancelesSelect As System.Windows.Forms.DataGridView
    Friend WithEvents dgvAuxiliar As System.Windows.Forms.DataGridView
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnModificarPrecio As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnModificarDesc As System.Windows.Forms.Button
    Friend WithEvents btnMarcar As System.Windows.Forms.Button
    Friend WithEvents btnPresupuesto As System.Windows.Forms.Button
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents dgvDatos As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnMover As System.Windows.Forms.Button
    Friend WithEvents txbBusqueda As WindowsApplication1.WaterMarkTextBox
End Class
