<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGraficas
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
        Me.components = New System.ComponentModel.Container()
        Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend3 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.grafica = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.dgvInfo = New System.Windows.Forms.DataGridView()
        Me.pbconfig = New System.Windows.Forms.PictureBox()
        Me.pnlMenu = New System.Windows.Forms.Panel()
        Me.pnlDatosGrafica = New System.Windows.Forms.Panel()
        Me.lblDatosGrafica = New System.Windows.Forms.Label()
        Me.pnlModo3D = New System.Windows.Forms.Panel()
        Me.lblModo3D = New System.Windows.Forms.Label()
        Me.PnlSubMenuDatosGrafica = New System.Windows.Forms.Panel()
        Me.pnlNumCitas = New System.Windows.Forms.Panel()
        Me.lblNumCitas = New System.Windows.Forms.Label()
        Me.PnlTratamientos = New System.Windows.Forms.Panel()
        Me.lblTratamientos = New System.Windows.Forms.Label()
        Me.pnlEdadPaciente = New System.Windows.Forms.Panel()
        Me.lblEdadPaciente = New System.Windows.Forms.Label()
        Me.TmrMovimiento = New System.Windows.Forms.Timer(Me.components)
        Me.pnlDesplMenu = New System.Windows.Forms.Panel()
        Me.LblDespmenu = New System.Windows.Forms.Label()
        Me.PnlSubmenu3d = New System.Windows.Forms.Panel()
        Me.pnlPerspectiva = New System.Windows.Forms.Panel()
        Me.lblCambiarPerspectiva = New System.Windows.Forms.Label()
        Me.pnlActivar3D = New System.Windows.Forms.Panel()
        Me.lblActivar3D = New System.Windows.Forms.Label()
        Me.pnlCambiarPerspectiva = New System.Windows.Forms.Panel()
        Me.pnlSubMenuCambiarPerspectiva = New System.Windows.Forms.Panel()
        Me.pnlPredeterminado = New System.Windows.Forms.Panel()
        Me.lblPredeterminado = New System.Windows.Forms.Label()
        Me.pnl140 = New System.Windows.Forms.Panel()
        Me.lbl140 = New System.Windows.Forms.Label()
        Me.pnl180 = New System.Windows.Forms.Panel()
        Me.lbl180 = New System.Windows.Forms.Label()
        Me.DgvTratamientos = New System.Windows.Forms.DataGridView()
        Me.dtpAnio = New System.Windows.Forms.DateTimePicker()
        Me.lblAnio = New System.Windows.Forms.Label()
        CType(Me.grafica, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbconfig, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlMenu.SuspendLayout()
        Me.pnlDatosGrafica.SuspendLayout()
        Me.pnlModo3D.SuspendLayout()
        Me.PnlSubMenuDatosGrafica.SuspendLayout()
        Me.pnlNumCitas.SuspendLayout()
        Me.PnlTratamientos.SuspendLayout()
        Me.pnlEdadPaciente.SuspendLayout()
        Me.pnlDesplMenu.SuspendLayout()
        Me.PnlSubmenu3d.SuspendLayout()
        Me.pnlPerspectiva.SuspendLayout()
        Me.pnlActivar3D.SuspendLayout()
        Me.pnlSubMenuCambiarPerspectiva.SuspendLayout()
        Me.pnlPredeterminado.SuspendLayout()
        Me.pnl140.SuspendLayout()
        Me.pnl180.SuspendLayout()
        CType(Me.DgvTratamientos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grafica
        '
        ChartArea3.Name = "Pacientes"
        Me.grafica.ChartAreas.Add(ChartArea3)
        Legend3.Name = "Legend1"
        Me.grafica.Legends.Add(Legend3)
        Me.grafica.Location = New System.Drawing.Point(1, 37)
        Me.grafica.Name = "grafica"
        Series3.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDot
        Series3.ChartArea = "Pacientes"
        Series3.Color = System.Drawing.Color.RoyalBlue
        Series3.Legend = "Legend1"
        Series3.Name = "Número de Pacientes"
        Me.grafica.Series.Add(Series3)
        Me.grafica.Size = New System.Drawing.Size(990, 533)
        Me.grafica.TabIndex = 0
        Me.grafica.Text = "Chart1"
        '
        'dgvInfo
        '
        Me.dgvInfo.AllowUserToAddRows = False
        Me.dgvInfo.AllowUserToDeleteRows = False
        Me.dgvInfo.AllowUserToResizeColumns = False
        Me.dgvInfo.AllowUserToResizeRows = False
        Me.dgvInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvInfo.Location = New System.Drawing.Point(1, 2)
        Me.dgvInfo.Name = "dgvInfo"
        Me.dgvInfo.ReadOnly = True
        Me.dgvInfo.Size = New System.Drawing.Size(8, 8)
        Me.dgvInfo.TabIndex = 6
        Me.dgvInfo.Visible = False
        '
        'pbconfig
        '
        Me.pbconfig.Image = Global.WindowsApplication1.My.Resources.Resources.IconoEditarGraf
        Me.pbconfig.Location = New System.Drawing.Point(3, 2)
        Me.pbconfig.Name = "pbconfig"
        Me.pbconfig.Size = New System.Drawing.Size(25, 28)
        Me.pbconfig.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbconfig.TabIndex = 8
        Me.pbconfig.TabStop = False
        '
        'pnlMenu
        '
        Me.pnlMenu.BackColor = System.Drawing.Color.RoyalBlue
        Me.pnlMenu.Controls.Add(Me.pnlDatosGrafica)
        Me.pnlMenu.Controls.Add(Me.pnlModo3D)
        Me.pnlMenu.Location = New System.Drawing.Point(991, 30)
        Me.pnlMenu.Name = "pnlMenu"
        Me.pnlMenu.Size = New System.Drawing.Size(186, 168)
        Me.pnlMenu.TabIndex = 10
        '
        'pnlDatosGrafica
        '
        Me.pnlDatosGrafica.BackColor = System.Drawing.Color.RoyalBlue
        Me.pnlDatosGrafica.Controls.Add(Me.lblDatosGrafica)
        Me.pnlDatosGrafica.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pnlDatosGrafica.Location = New System.Drawing.Point(0, 98)
        Me.pnlDatosGrafica.Name = "pnlDatosGrafica"
        Me.pnlDatosGrafica.Size = New System.Drawing.Size(186, 36)
        Me.pnlDatosGrafica.TabIndex = 13
        Me.pnlDatosGrafica.Visible = False
        '
        'lblDatosGrafica
        '
        Me.lblDatosGrafica.AutoSize = True
        Me.lblDatosGrafica.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDatosGrafica.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblDatosGrafica.Location = New System.Drawing.Point(27, 7)
        Me.lblDatosGrafica.Name = "lblDatosGrafica"
        Me.lblDatosGrafica.Size = New System.Drawing.Size(133, 24)
        Me.lblDatosGrafica.TabIndex = 0
        Me.lblDatosGrafica.Text = "Datos Gráfica"
        '
        'pnlModo3D
        '
        Me.pnlModo3D.BackColor = System.Drawing.Color.RoyalBlue
        Me.pnlModo3D.Controls.Add(Me.lblModo3D)
        Me.pnlModo3D.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pnlModo3D.Location = New System.Drawing.Point(0, 46)
        Me.pnlModo3D.Name = "pnlModo3D"
        Me.pnlModo3D.Size = New System.Drawing.Size(186, 36)
        Me.pnlModo3D.TabIndex = 11
        Me.pnlModo3D.Visible = False
        '
        'lblModo3D
        '
        Me.lblModo3D.AutoSize = True
        Me.lblModo3D.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModo3D.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblModo3D.Location = New System.Drawing.Point(44, 4)
        Me.lblModo3D.Name = "lblModo3D"
        Me.lblModo3D.Size = New System.Drawing.Size(107, 26)
        Me.lblModo3D.TabIndex = 0
        Me.lblModo3D.Text = "Modo 3D"
        Me.lblModo3D.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PnlSubMenuDatosGrafica
        '
        Me.PnlSubMenuDatosGrafica.BackColor = System.Drawing.Color.RoyalBlue
        Me.PnlSubMenuDatosGrafica.Controls.Add(Me.pnlNumCitas)
        Me.PnlSubMenuDatosGrafica.Controls.Add(Me.PnlTratamientos)
        Me.PnlSubMenuDatosGrafica.Controls.Add(Me.pnlEdadPaciente)
        Me.PnlSubMenuDatosGrafica.Location = New System.Drawing.Point(785, 90)
        Me.PnlSubMenuDatosGrafica.Name = "PnlSubMenuDatosGrafica"
        Me.PnlSubMenuDatosGrafica.Size = New System.Drawing.Size(206, 154)
        Me.PnlSubMenuDatosGrafica.TabIndex = 13
        Me.PnlSubMenuDatosGrafica.Visible = False
        '
        'pnlNumCitas
        '
        Me.pnlNumCitas.Controls.Add(Me.lblNumCitas)
        Me.pnlNumCitas.Location = New System.Drawing.Point(3, 105)
        Me.pnlNumCitas.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlNumCitas.Name = "pnlNumCitas"
        Me.pnlNumCitas.Size = New System.Drawing.Size(201, 45)
        Me.pnlNumCitas.TabIndex = 24
        '
        'lblNumCitas
        '
        Me.lblNumCitas.AutoSize = True
        Me.lblNumCitas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumCitas.Location = New System.Drawing.Point(37, 3)
        Me.lblNumCitas.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNumCitas.Name = "lblNumCitas"
        Me.lblNumCitas.Size = New System.Drawing.Size(125, 40)
        Me.lblNumCitas.TabIndex = 0
        Me.lblNumCitas.Text = "N° de citas" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "durante el año"
        Me.lblNumCitas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PnlTratamientos
        '
        Me.PnlTratamientos.Controls.Add(Me.lblTratamientos)
        Me.PnlTratamientos.Location = New System.Drawing.Point(2, 56)
        Me.PnlTratamientos.Margin = New System.Windows.Forms.Padding(2)
        Me.PnlTratamientos.Name = "PnlTratamientos"
        Me.PnlTratamientos.Size = New System.Drawing.Size(202, 45)
        Me.PnlTratamientos.TabIndex = 23
        '
        'lblTratamientos
        '
        Me.lblTratamientos.AutoSize = True
        Me.lblTratamientos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTratamientos.Location = New System.Drawing.Point(32, 3)
        Me.lblTratamientos.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTratamientos.Name = "lblTratamientos"
        Me.lblTratamientos.Size = New System.Drawing.Size(152, 40)
        Me.lblTratamientos.TabIndex = 0
        Me.lblTratamientos.Text = "Tratamientos Más" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Realizados"
        Me.lblTratamientos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlEdadPaciente
        '
        Me.pnlEdadPaciente.BackColor = System.Drawing.Color.RoyalBlue
        Me.pnlEdadPaciente.Controls.Add(Me.lblEdadPaciente)
        Me.pnlEdadPaciente.Location = New System.Drawing.Point(3, 2)
        Me.pnlEdadPaciente.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlEdadPaciente.Name = "pnlEdadPaciente"
        Me.pnlEdadPaciente.Size = New System.Drawing.Size(201, 50)
        Me.pnlEdadPaciente.TabIndex = 21
        '
        'lblEdadPaciente
        '
        Me.lblEdadPaciente.AutoSize = True
        Me.lblEdadPaciente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEdadPaciente.Location = New System.Drawing.Point(9, 5)
        Me.lblEdadPaciente.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblEdadPaciente.Name = "lblEdadPaciente"
        Me.lblEdadPaciente.Size = New System.Drawing.Size(180, 40)
        Me.lblEdadPaciente.TabIndex = 22
        Me.lblEdadPaciente.Text = "Número de Pacientes" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "por edades"
        Me.lblEdadPaciente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TmrMovimiento
        '
        Me.TmrMovimiento.Interval = 1
        '
        'pnlDesplMenu
        '
        Me.pnlDesplMenu.BackColor = System.Drawing.Color.CornflowerBlue
        Me.pnlDesplMenu.Controls.Add(Me.LblDespmenu)
        Me.pnlDesplMenu.Controls.Add(Me.pbconfig)
        Me.pnlDesplMenu.Location = New System.Drawing.Point(991, -1)
        Me.pnlDesplMenu.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlDesplMenu.Name = "pnlDesplMenu"
        Me.pnlDesplMenu.Size = New System.Drawing.Size(186, 32)
        Me.pnlDesplMenu.TabIndex = 20
        '
        'LblDespmenu
        '
        Me.LblDespmenu.AutoSize = True
        Me.LblDespmenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDespmenu.Location = New System.Drawing.Point(52, 4)
        Me.LblDespmenu.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblDespmenu.Name = "LblDespmenu"
        Me.LblDespmenu.Size = New System.Drawing.Size(100, 24)
        Me.LblDespmenu.TabIndex = 9
        Me.LblDespmenu.Text = "Opciones"
        '
        'PnlSubmenu3d
        '
        Me.PnlSubmenu3d.BackColor = System.Drawing.Color.RoyalBlue
        Me.PnlSubmenu3d.Controls.Add(Me.pnlPerspectiva)
        Me.PnlSubmenu3d.Controls.Add(Me.pnlActivar3D)
        Me.PnlSubmenu3d.Location = New System.Drawing.Point(782, 52)
        Me.PnlSubmenu3d.Name = "PnlSubmenu3d"
        Me.PnlSubmenu3d.Size = New System.Drawing.Size(209, 70)
        Me.PnlSubmenu3d.TabIndex = 22
        Me.PnlSubmenu3d.Visible = False
        '
        'pnlPerspectiva
        '
        Me.pnlPerspectiva.BackColor = System.Drawing.Color.RoyalBlue
        Me.pnlPerspectiva.Controls.Add(Me.lblCambiarPerspectiva)
        Me.pnlPerspectiva.Location = New System.Drawing.Point(3, 36)
        Me.pnlPerspectiva.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlPerspectiva.Name = "pnlPerspectiva"
        Me.pnlPerspectiva.Size = New System.Drawing.Size(204, 32)
        Me.pnlPerspectiva.TabIndex = 22
        '
        'lblCambiarPerspectiva
        '
        Me.lblCambiarPerspectiva.AutoSize = True
        Me.lblCambiarPerspectiva.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.lblCambiarPerspectiva.Location = New System.Drawing.Point(3, 4)
        Me.lblCambiarPerspectiva.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCambiarPerspectiva.Name = "lblCambiarPerspectiva"
        Me.lblCambiarPerspectiva.Size = New System.Drawing.Size(201, 24)
        Me.lblCambiarPerspectiva.TabIndex = 22
        Me.lblCambiarPerspectiva.Text = "Cambiar Perspectiva"
        '
        'pnlActivar3D
        '
        Me.pnlActivar3D.BackColor = System.Drawing.Color.RoyalBlue
        Me.pnlActivar3D.Controls.Add(Me.lblActivar3D)
        Me.pnlActivar3D.Location = New System.Drawing.Point(3, 3)
        Me.pnlActivar3D.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlActivar3D.Name = "pnlActivar3D"
        Me.pnlActivar3D.Size = New System.Drawing.Size(204, 31)
        Me.pnlActivar3D.TabIndex = 21
        '
        'lblActivar3D
        '
        Me.lblActivar3D.AutoSize = True
        Me.lblActivar3D.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.lblActivar3D.Location = New System.Drawing.Point(-1, 4)
        Me.lblActivar3D.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblActivar3D.Name = "lblActivar3D"
        Me.lblActivar3D.Size = New System.Drawing.Size(204, 24)
        Me.lblActivar3D.TabIndex = 22
        Me.lblActivar3D.Text = "Activar/Desactivar 3d"
        '
        'pnlCambiarPerspectiva
        '
        Me.pnlCambiarPerspectiva.BackColor = System.Drawing.Color.RoyalBlue
        Me.pnlCambiarPerspectiva.Location = New System.Drawing.Point(158, 7)
        Me.pnlCambiarPerspectiva.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlCambiarPerspectiva.Name = "pnlCambiarPerspectiva"
        Me.pnlCambiarPerspectiva.Size = New System.Drawing.Size(200, 31)
        Me.pnlCambiarPerspectiva.TabIndex = 23
        '
        'pnlSubMenuCambiarPerspectiva
        '
        Me.pnlSubMenuCambiarPerspectiva.BackColor = System.Drawing.Color.RoyalBlue
        Me.pnlSubMenuCambiarPerspectiva.Controls.Add(Me.pnlPredeterminado)
        Me.pnlSubMenuCambiarPerspectiva.Controls.Add(Me.pnlCambiarPerspectiva)
        Me.pnlSubMenuCambiarPerspectiva.Controls.Add(Me.pnl140)
        Me.pnlSubMenuCambiarPerspectiva.Controls.Add(Me.pnl180)
        Me.pnlSubMenuCambiarPerspectiva.ForeColor = System.Drawing.Color.MediumTurquoise
        Me.pnlSubMenuCambiarPerspectiva.Location = New System.Drawing.Point(623, 52)
        Me.pnlSubMenuCambiarPerspectiva.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlSubMenuCambiarPerspectiva.Name = "pnlSubMenuCambiarPerspectiva"
        Me.pnlSubMenuCambiarPerspectiva.Size = New System.Drawing.Size(159, 110)
        Me.pnlSubMenuCambiarPerspectiva.TabIndex = 23
        Me.pnlSubMenuCambiarPerspectiva.Visible = False
        '
        'pnlPredeterminado
        '
        Me.pnlPredeterminado.Controls.Add(Me.lblPredeterminado)
        Me.pnlPredeterminado.Location = New System.Drawing.Point(2, 74)
        Me.pnlPredeterminado.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlPredeterminado.Name = "pnlPredeterminado"
        Me.pnlPredeterminado.Size = New System.Drawing.Size(155, 34)
        Me.pnlPredeterminado.TabIndex = 3
        '
        'lblPredeterminado
        '
        Me.lblPredeterminado.AutoSize = True
        Me.lblPredeterminado.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPredeterminado.ForeColor = System.Drawing.Color.MintCream
        Me.lblPredeterminado.Location = New System.Drawing.Point(0, 7)
        Me.lblPredeterminado.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPredeterminado.Name = "lblPredeterminado"
        Me.lblPredeterminado.Size = New System.Drawing.Size(159, 24)
        Me.lblPredeterminado.TabIndex = 0
        Me.lblPredeterminado.Text = "Predeterminado"
        '
        'pnl140
        '
        Me.pnl140.Controls.Add(Me.lbl140)
        Me.pnl140.Location = New System.Drawing.Point(2, 36)
        Me.pnl140.Margin = New System.Windows.Forms.Padding(2)
        Me.pnl140.Name = "pnl140"
        Me.pnl140.Size = New System.Drawing.Size(155, 34)
        Me.pnl140.TabIndex = 2
        '
        'lbl140
        '
        Me.lbl140.AutoSize = True
        Me.lbl140.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl140.ForeColor = System.Drawing.Color.MintCream
        Me.lbl140.Location = New System.Drawing.Point(52, 8)
        Me.lbl140.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl140.Name = "lbl140"
        Me.lbl140.Size = New System.Drawing.Size(50, 24)
        Me.lbl140.TabIndex = 0
        Me.lbl140.Text = "140°"
        '
        'pnl180
        '
        Me.pnl180.Controls.Add(Me.lbl180)
        Me.pnl180.Location = New System.Drawing.Point(2, 0)
        Me.pnl180.Margin = New System.Windows.Forms.Padding(2)
        Me.pnl180.Name = "pnl180"
        Me.pnl180.Size = New System.Drawing.Size(155, 31)
        Me.pnl180.TabIndex = 1
        '
        'lbl180
        '
        Me.lbl180.AutoSize = True
        Me.lbl180.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl180.ForeColor = System.Drawing.Color.MintCream
        Me.lbl180.Location = New System.Drawing.Point(52, 5)
        Me.lbl180.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl180.Name = "lbl180"
        Me.lbl180.Size = New System.Drawing.Size(50, 24)
        Me.lbl180.TabIndex = 0
        Me.lbl180.Text = "180°"
        '
        'DgvTratamientos
        '
        Me.DgvTratamientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvTratamientos.Location = New System.Drawing.Point(9, 2)
        Me.DgvTratamientos.Margin = New System.Windows.Forms.Padding(2)
        Me.DgvTratamientos.Name = "DgvTratamientos"
        Me.DgvTratamientos.RowTemplate.Height = 24
        Me.DgvTratamientos.Size = New System.Drawing.Size(8, 8)
        Me.DgvTratamientos.TabIndex = 24
        Me.DgvTratamientos.Visible = False
        '
        'dtpAnio
        '
        Me.dtpAnio.CustomFormat = "yyyy"
        Me.dtpAnio.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpAnio.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpAnio.Location = New System.Drawing.Point(1056, 350)
        Me.dtpAnio.Name = "dtpAnio"
        Me.dtpAnio.Size = New System.Drawing.Size(69, 31)
        Me.dtpAnio.TabIndex = 25
        '
        'lblAnio
        '
        Me.lblAnio.AutoSize = True
        Me.lblAnio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnio.ForeColor = System.Drawing.Color.Black
        Me.lblAnio.Location = New System.Drawing.Point(1036, 307)
        Me.lblAnio.Name = "lblAnio"
        Me.lblAnio.Size = New System.Drawing.Size(107, 40)
        Me.lblAnio.TabIndex = 26
        Me.lblAnio.Text = "Seleccione el" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "año a mostrar"
        Me.lblAnio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmGraficas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1179, 684)
        Me.Controls.Add(Me.lblAnio)
        Me.Controls.Add(Me.dtpAnio)
        Me.Controls.Add(Me.PnlSubMenuDatosGrafica)
        Me.Controls.Add(Me.DgvTratamientos)
        Me.Controls.Add(Me.pnlSubMenuCambiarPerspectiva)
        Me.Controls.Add(Me.PnlSubmenu3d)
        Me.Controls.Add(Me.pnlDesplMenu)
        Me.Controls.Add(Me.pnlMenu)
        Me.Controls.Add(Me.dgvInfo)
        Me.Controls.Add(Me.grafica)
        Me.ForeColor = System.Drawing.SystemColors.Menu
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmGraficas"
        Me.Text = "."
        CType(Me.grafica, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvInfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbconfig, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlMenu.ResumeLayout(False)
        Me.pnlDatosGrafica.ResumeLayout(False)
        Me.pnlDatosGrafica.PerformLayout()
        Me.pnlModo3D.ResumeLayout(False)
        Me.pnlModo3D.PerformLayout()
        Me.PnlSubMenuDatosGrafica.ResumeLayout(False)
        Me.pnlNumCitas.ResumeLayout(False)
        Me.pnlNumCitas.PerformLayout()
        Me.PnlTratamientos.ResumeLayout(False)
        Me.PnlTratamientos.PerformLayout()
        Me.pnlEdadPaciente.ResumeLayout(False)
        Me.pnlEdadPaciente.PerformLayout()
        Me.pnlDesplMenu.ResumeLayout(False)
        Me.pnlDesplMenu.PerformLayout()
        Me.PnlSubmenu3d.ResumeLayout(False)
        Me.pnlPerspectiva.ResumeLayout(False)
        Me.pnlPerspectiva.PerformLayout()
        Me.pnlActivar3D.ResumeLayout(False)
        Me.pnlActivar3D.PerformLayout()
        Me.pnlSubMenuCambiarPerspectiva.ResumeLayout(False)
        Me.pnlPredeterminado.ResumeLayout(False)
        Me.pnlPredeterminado.PerformLayout()
        Me.pnl140.ResumeLayout(False)
        Me.pnl140.PerformLayout()
        Me.pnl180.ResumeLayout(False)
        Me.pnl180.PerformLayout()
        CType(Me.DgvTratamientos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grafica As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents dgvInfo As System.Windows.Forms.DataGridView
    Friend WithEvents pbconfig As System.Windows.Forms.PictureBox
    Friend WithEvents pnlMenu As System.Windows.Forms.Panel
    Friend WithEvents pnlModo3D As System.Windows.Forms.Panel
    Friend WithEvents pnlDatosGrafica As System.Windows.Forms.Panel
    Friend WithEvents lblDatosGrafica As System.Windows.Forms.Label
    Friend WithEvents lblModo3D As System.Windows.Forms.Label
    Friend WithEvents PnlSubMenuDatosGrafica As System.Windows.Forms.Panel
    Friend WithEvents TmrMovimiento As System.Windows.Forms.Timer
    Friend WithEvents pnlDesplMenu As System.Windows.Forms.Panel
    Friend WithEvents pnlEdadPaciente As System.Windows.Forms.Panel
    Friend WithEvents lblEdadPaciente As System.Windows.Forms.Label
    Friend WithEvents PnlSubmenu3d As System.Windows.Forms.Panel
    Friend WithEvents pnlActivar3D As System.Windows.Forms.Panel
    Friend WithEvents lblActivar3D As System.Windows.Forms.Label
    Friend WithEvents pnlCambiarPerspectiva As System.Windows.Forms.Panel
    Friend WithEvents lblCambiarPerspectiva As System.Windows.Forms.Label
    Friend WithEvents PnlTratamientos As System.Windows.Forms.Panel
    Friend WithEvents lblTratamientos As System.Windows.Forms.Label
    Friend WithEvents pnlSubMenuCambiarPerspectiva As System.Windows.Forms.Panel
    Friend WithEvents pnl180 As System.Windows.Forms.Panel
    Friend WithEvents lbl180 As System.Windows.Forms.Label
    Friend WithEvents LblDespmenu As System.Windows.Forms.Label
    Friend WithEvents pnl140 As System.Windows.Forms.Panel
    Friend WithEvents lbl140 As System.Windows.Forms.Label
    Friend WithEvents pnlPredeterminado As System.Windows.Forms.Panel
    Friend WithEvents lblPredeterminado As System.Windows.Forms.Label
    Friend WithEvents DgvTratamientos As System.Windows.Forms.DataGridView
    Friend WithEvents pnlNumCitas As System.Windows.Forms.Panel
    Friend WithEvents lblNumCitas As System.Windows.Forms.Label
    Friend WithEvents dtpAnio As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblAnio As System.Windows.Forms.Label
    Friend WithEvents pnlPerspectiva As System.Windows.Forms.Panel
End Class
