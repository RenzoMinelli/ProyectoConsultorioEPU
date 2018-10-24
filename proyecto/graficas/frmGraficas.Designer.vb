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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.grafica = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.dgvInfo = New System.Windows.Forms.DataGridView()
        Me.pbconfig = New System.Windows.Forms.PictureBox()
        Me.PnlMenu = New System.Windows.Forms.Panel()
        Me.PnlGrafica = New System.Windows.Forms.Panel()
        Me.LblGrafica = New System.Windows.Forms.Label()
        Me.Pnl3d = New System.Windows.Forms.Panel()
        Me.Lbl3d = New System.Windows.Forms.Label()
        Me.PnlSubMenuDatos = New System.Windows.Forms.Panel()
        Me.PnlTratamientos = New System.Windows.Forms.Panel()
        Me.Lbltratamientos = New System.Windows.Forms.Label()
        Me.PnlPromedades = New System.Windows.Forms.Panel()
        Me.lblEdadPaciente = New System.Windows.Forms.Label()
        Me.TmrMovimiento = New System.Windows.Forms.Timer(Me.components)
        Me.pnldesplmenu = New System.Windows.Forms.Panel()
        Me.LblDespmenu = New System.Windows.Forms.Label()
        Me.Lbltitulo = New System.Windows.Forms.Label()
        Me.PnlSubmenu3d = New System.Windows.Forms.Panel()
        Me.pnlCambarPerspectiva = New System.Windows.Forms.Panel()
        Me.lblCambiarPers = New System.Windows.Forms.Label()
        Me.Pnlact3d = New System.Windows.Forms.Panel()
        Me.LblActivar3d = New System.Windows.Forms.Label()
        Me.PnlOpPers = New System.Windows.Forms.Panel()
        Me.PnlOp3 = New System.Windows.Forms.Panel()
        Me.LblOp3 = New System.Windows.Forms.Label()
        Me.PnlOp2 = New System.Windows.Forms.Panel()
        Me.LblOp2 = New System.Windows.Forms.Label()
        Me.PnlOp1 = New System.Windows.Forms.Panel()
        Me.Lblop1 = New System.Windows.Forms.Label()
        Me.DgvTratamientos = New System.Windows.Forms.DataGridView()
        CType(Me.grafica, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbconfig, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlMenu.SuspendLayout()
        Me.PnlGrafica.SuspendLayout()
        Me.Pnl3d.SuspendLayout()
        Me.PnlSubMenuDatos.SuspendLayout()
        Me.PnlTratamientos.SuspendLayout()
        Me.PnlPromedades.SuspendLayout()
        Me.pnldesplmenu.SuspendLayout()
        Me.PnlSubmenu3d.SuspendLayout()
        Me.pnlCambarPerspectiva.SuspendLayout()
        Me.Pnlact3d.SuspendLayout()
        Me.PnlOpPers.SuspendLayout()
        Me.PnlOp3.SuspendLayout()
        Me.PnlOp2.SuspendLayout()
        Me.PnlOp1.SuspendLayout()
        CType(Me.DgvTratamientos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grafica
        '
        ChartArea1.Name = "Pacientes"
        Me.grafica.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.grafica.Legends.Add(Legend1)
        Me.grafica.Location = New System.Drawing.Point(1, 46)
        Me.grafica.Margin = New System.Windows.Forms.Padding(4)
        Me.grafica.Name = "grafica"
        Series1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDot
        Series1.ChartArea = "Pacientes"
        Series1.Color = System.Drawing.Color.MidnightBlue
        Series1.Legend = "Legend1"
        Series1.Name = "Num pacientes"
        Me.grafica.Series.Add(Series1)
        Me.grafica.Size = New System.Drawing.Size(1336, 656)
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
        Me.dgvInfo.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvInfo.Name = "dgvInfo"
        Me.dgvInfo.ReadOnly = True
        Me.dgvInfo.Size = New System.Drawing.Size(11, 10)
        Me.dgvInfo.TabIndex = 6
        Me.dgvInfo.Visible = False
        '
        'pbconfig
        '
        Me.pbconfig.Image = Global.WindowsApplication1.My.Resources.Resources.ruedita
        Me.pbconfig.Location = New System.Drawing.Point(4, 0)
        Me.pbconfig.Margin = New System.Windows.Forms.Padding(4)
        Me.pbconfig.Name = "pbconfig"
        Me.pbconfig.Size = New System.Drawing.Size(43, 39)
        Me.pbconfig.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbconfig.TabIndex = 8
        Me.pbconfig.TabStop = False
        '
        'PnlMenu
        '
        Me.PnlMenu.BackColor = System.Drawing.Color.RoyalBlue
        Me.PnlMenu.Controls.Add(Me.PnlGrafica)
        Me.PnlMenu.Controls.Add(Me.Pnl3d)
        Me.PnlMenu.Location = New System.Drawing.Point(1300, 46)
        Me.PnlMenu.Margin = New System.Windows.Forms.Padding(4)
        Me.PnlMenu.Name = "PnlMenu"
        Me.PnlMenu.Size = New System.Drawing.Size(248, 425)
        Me.PnlMenu.TabIndex = 10
        '
        'PnlGrafica
        '
        Me.PnlGrafica.BackColor = System.Drawing.Color.RoyalBlue
        Me.PnlGrafica.Controls.Add(Me.LblGrafica)
        Me.PnlGrafica.ForeColor = System.Drawing.SystemColors.ControlText
        Me.PnlGrafica.Location = New System.Drawing.Point(0, 120)
        Me.PnlGrafica.Margin = New System.Windows.Forms.Padding(4)
        Me.PnlGrafica.Name = "PnlGrafica"
        Me.PnlGrafica.Size = New System.Drawing.Size(248, 44)
        Me.PnlGrafica.TabIndex = 13
        Me.PnlGrafica.Visible = False
        '
        'LblGrafica
        '
        Me.LblGrafica.AutoSize = True
        Me.LblGrafica.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblGrafica.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LblGrafica.Location = New System.Drawing.Point(36, 9)
        Me.LblGrafica.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblGrafica.Name = "LblGrafica"
        Me.LblGrafica.Size = New System.Drawing.Size(170, 29)
        Me.LblGrafica.TabIndex = 0
        Me.LblGrafica.Text = "Datos Grafica"
        '
        'Pnl3d
        '
        Me.Pnl3d.BackColor = System.Drawing.Color.RoyalBlue
        Me.Pnl3d.Controls.Add(Me.Lbl3d)
        Me.Pnl3d.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Pnl3d.Location = New System.Drawing.Point(0, 57)
        Me.Pnl3d.Margin = New System.Windows.Forms.Padding(4)
        Me.Pnl3d.Name = "Pnl3d"
        Me.Pnl3d.Size = New System.Drawing.Size(248, 44)
        Me.Pnl3d.TabIndex = 11
        Me.Pnl3d.Visible = False
        '
        'Lbl3d
        '
        Me.Lbl3d.AutoSize = True
        Me.Lbl3d.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl3d.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Lbl3d.Location = New System.Drawing.Point(4, 6)
        Me.Lbl3d.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbl3d.Name = "Lbl3d"
        Me.Lbl3d.Size = New System.Drawing.Size(240, 32)
        Me.Lbl3d.TabIndex = 0
        Me.Lbl3d.Text = "     Modo 3D        "
        '
        'PnlSubMenuDatos
        '
        Me.PnlSubMenuDatos.BackColor = System.Drawing.Color.RoyalBlue
        Me.PnlSubMenuDatos.Controls.Add(Me.PnlTratamientos)
        Me.PnlSubMenuDatos.Controls.Add(Me.PnlPromedades)
        Me.PnlSubMenuDatos.Location = New System.Drawing.Point(1025, 133)
        Me.PnlSubMenuDatos.Margin = New System.Windows.Forms.Padding(4)
        Me.PnlSubMenuDatos.Name = "PnlSubMenuDatos"
        Me.PnlSubMenuDatos.Size = New System.Drawing.Size(275, 135)
        Me.PnlSubMenuDatos.TabIndex = 13
        Me.PnlSubMenuDatos.Visible = False
        '
        'PnlTratamientos
        '
        Me.PnlTratamientos.Controls.Add(Me.Lbltratamientos)
        Me.PnlTratamientos.Location = New System.Drawing.Point(0, 44)
        Me.PnlTratamientos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PnlTratamientos.Name = "PnlTratamientos"
        Me.PnlTratamientos.Size = New System.Drawing.Size(268, 41)
        Me.PnlTratamientos.TabIndex = 23
        '
        'Lbltratamientos
        '
        Me.Lbltratamientos.AutoSize = True
        Me.Lbltratamientos.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbltratamientos.Location = New System.Drawing.Point(5, 12)
        Me.Lbltratamientos.Name = "Lbltratamientos"
        Me.Lbltratamientos.Size = New System.Drawing.Size(259, 20)
        Me.Lbltratamientos.TabIndex = 0
        Me.Lbltratamientos.Text = "Tratamientos Mas Realizados"
        '
        'PnlPromedades
        '
        Me.PnlPromedades.BackColor = System.Drawing.Color.RoyalBlue
        Me.PnlPromedades.Controls.Add(Me.lblEdadPaciente)
        Me.PnlPromedades.Location = New System.Drawing.Point(0, 0)
        Me.PnlPromedades.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PnlPromedades.Name = "PnlPromedades"
        Me.PnlPromedades.Size = New System.Drawing.Size(268, 38)
        Me.PnlPromedades.TabIndex = 21
        '
        'lblEdadPaciente
        '
        Me.lblEdadPaciente.AutoSize = True
        Me.lblEdadPaciente.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.lblEdadPaciente.Location = New System.Drawing.Point(13, 2)
        Me.lblEdadPaciente.Name = "lblEdadPaciente"
        Me.lblEdadPaciente.Size = New System.Drawing.Size(224, 29)
        Me.lblEdadPaciente.TabIndex = 22
        Me.lblEdadPaciente.Text = "Edades Pacientes"
        '
        'TmrMovimiento
        '
        Me.TmrMovimiento.Interval = 1
        '
        'pnldesplmenu
        '
        Me.pnldesplmenu.BackColor = System.Drawing.Color.CornflowerBlue
        Me.pnldesplmenu.Controls.Add(Me.LblDespmenu)
        Me.pnldesplmenu.Controls.Add(Me.pbconfig)
        Me.pnldesplmenu.Location = New System.Drawing.Point(1300, -2)
        Me.pnldesplmenu.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnldesplmenu.Name = "pnldesplmenu"
        Me.pnldesplmenu.Size = New System.Drawing.Size(248, 39)
        Me.pnldesplmenu.TabIndex = 20
        '
        'LblDespmenu
        '
        Me.LblDespmenu.AutoSize = True
        Me.LblDespmenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDespmenu.Location = New System.Drawing.Point(69, 5)
        Me.LblDespmenu.Name = "LblDespmenu"
        Me.LblDespmenu.Size = New System.Drawing.Size(125, 29)
        Me.LblDespmenu.TabIndex = 9
        Me.LblDespmenu.Text = "Opciones"
        '
        'Lbltitulo
        '
        Me.Lbltitulo.AutoSize = True
        Me.Lbltitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbltitulo.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Lbltitulo.Location = New System.Drawing.Point(51, 9)
        Me.Lbltitulo.Name = "Lbltitulo"
        Me.Lbltitulo.Size = New System.Drawing.Size(830, 32)
        Me.Lbltitulo.TabIndex = 21
        Me.Lbltitulo.Text = "la informacion mostrada es 'Promedio edades de pacientes':"
        '
        'PnlSubmenu3d
        '
        Me.PnlSubmenu3d.BackColor = System.Drawing.Color.RoyalBlue
        Me.PnlSubmenu3d.Controls.Add(Me.pnlCambarPerspectiva)
        Me.PnlSubmenu3d.Controls.Add(Me.Pnlact3d)
        Me.PnlSubmenu3d.Location = New System.Drawing.Point(1021, 70)
        Me.PnlSubmenu3d.Margin = New System.Windows.Forms.Padding(4)
        Me.PnlSubmenu3d.Name = "PnlSubmenu3d"
        Me.PnlSubmenu3d.Size = New System.Drawing.Size(279, 135)
        Me.PnlSubmenu3d.TabIndex = 22
        Me.PnlSubmenu3d.Visible = False
        '
        'pnlCambarPerspectiva
        '
        Me.pnlCambarPerspectiva.BackColor = System.Drawing.Color.RoyalBlue
        Me.pnlCambarPerspectiva.Controls.Add(Me.lblCambiarPers)
        Me.pnlCambarPerspectiva.Location = New System.Drawing.Point(0, 39)
        Me.pnlCambarPerspectiva.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnlCambarPerspectiva.Name = "pnlCambarPerspectiva"
        Me.pnlCambarPerspectiva.Size = New System.Drawing.Size(271, 38)
        Me.pnlCambarPerspectiva.TabIndex = 23
        '
        'lblCambiarPers
        '
        Me.lblCambiarPers.AutoSize = True
        Me.lblCambiarPers.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.lblCambiarPers.Location = New System.Drawing.Point(3, 0)
        Me.lblCambiarPers.Name = "lblCambiarPers"
        Me.lblCambiarPers.Size = New System.Drawing.Size(255, 29)
        Me.lblCambiarPers.TabIndex = 22
        Me.lblCambiarPers.Text = "Cambiar Perspectiva"
        '
        'Pnlact3d
        '
        Me.Pnlact3d.BackColor = System.Drawing.Color.RoyalBlue
        Me.Pnlact3d.Controls.Add(Me.LblActivar3d)
        Me.Pnlact3d.Location = New System.Drawing.Point(0, 0)
        Me.Pnlact3d.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Pnlact3d.Name = "Pnlact3d"
        Me.Pnlact3d.Size = New System.Drawing.Size(268, 38)
        Me.Pnlact3d.TabIndex = 21
        '
        'LblActivar3d
        '
        Me.LblActivar3d.AutoSize = True
        Me.LblActivar3d.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.LblActivar3d.Location = New System.Drawing.Point(3, 0)
        Me.LblActivar3d.Name = "LblActivar3d"
        Me.LblActivar3d.Size = New System.Drawing.Size(257, 29)
        Me.LblActivar3d.TabIndex = 22
        Me.LblActivar3d.Text = "Activar/Desactivar 3d"
        '
        'PnlOpPers
        '
        Me.PnlOpPers.BackColor = System.Drawing.Color.RoyalBlue
        Me.PnlOpPers.Controls.Add(Me.PnlOp3)
        Me.PnlOpPers.Controls.Add(Me.PnlOp2)
        Me.PnlOpPers.Controls.Add(Me.PnlOp1)
        Me.PnlOpPers.ForeColor = System.Drawing.Color.MediumTurquoise
        Me.PnlOpPers.Location = New System.Drawing.Point(820, 103)
        Me.PnlOpPers.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PnlOpPers.Name = "PnlOpPers"
        Me.PnlOpPers.Size = New System.Drawing.Size(212, 135)
        Me.PnlOpPers.TabIndex = 23
        Me.PnlOpPers.Visible = False
        '
        'PnlOp3
        '
        Me.PnlOp3.Controls.Add(Me.LblOp3)
        Me.PnlOp3.Location = New System.Drawing.Point(0, 91)
        Me.PnlOp3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PnlOp3.Name = "PnlOp3"
        Me.PnlOp3.Size = New System.Drawing.Size(209, 44)
        Me.PnlOp3.TabIndex = 3
        '
        'LblOp3
        '
        Me.LblOp3.AutoSize = True
        Me.LblOp3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblOp3.ForeColor = System.Drawing.Color.MintCream
        Me.LblOp3.Location = New System.Drawing.Point(5, 9)
        Me.LblOp3.Name = "LblOp3"
        Me.LblOp3.Size = New System.Drawing.Size(201, 29)
        Me.LblOp3.TabIndex = 0
        Me.LblOp3.Text = "Predeterminado"
        '
        'PnlOp2
        '
        Me.PnlOp2.Controls.Add(Me.LblOp2)
        Me.PnlOp2.Location = New System.Drawing.Point(0, 44)
        Me.PnlOp2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PnlOp2.Name = "PnlOp2"
        Me.PnlOp2.Size = New System.Drawing.Size(212, 44)
        Me.PnlOp2.TabIndex = 2
        '
        'LblOp2
        '
        Me.LblOp2.AutoSize = True
        Me.LblOp2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblOp2.ForeColor = System.Drawing.Color.MintCream
        Me.LblOp2.Location = New System.Drawing.Point(69, 10)
        Me.LblOp2.Name = "LblOp2"
        Me.LblOp2.Size = New System.Drawing.Size(64, 29)
        Me.LblOp2.TabIndex = 0
        Me.LblOp2.Text = "140°"
        '
        'PnlOp1
        '
        Me.PnlOp1.Controls.Add(Me.Lblop1)
        Me.PnlOp1.Location = New System.Drawing.Point(0, 0)
        Me.PnlOp1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PnlOp1.Name = "PnlOp1"
        Me.PnlOp1.Size = New System.Drawing.Size(209, 38)
        Me.PnlOp1.TabIndex = 1
        '
        'Lblop1
        '
        Me.Lblop1.AutoSize = True
        Me.Lblop1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblop1.ForeColor = System.Drawing.Color.MintCream
        Me.Lblop1.Location = New System.Drawing.Point(69, 6)
        Me.Lblop1.Name = "Lblop1"
        Me.Lblop1.Size = New System.Drawing.Size(64, 29)
        Me.Lblop1.TabIndex = 0
        Me.Lblop1.Text = "180°"
        '
        'DgvTratamientos
        '
        Me.DgvTratamientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvTratamientos.Location = New System.Drawing.Point(12, 2)
        Me.DgvTratamientos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DgvTratamientos.Name = "DgvTratamientos"
        Me.DgvTratamientos.RowTemplate.Height = 24
        Me.DgvTratamientos.Size = New System.Drawing.Size(11, 10)
        Me.DgvTratamientos.TabIndex = 24
        Me.DgvTratamientos.Visible = False
        '
        'frmGraficas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1387, 747)
        Me.Controls.Add(Me.DgvTratamientos)
        Me.Controls.Add(Me.PnlOpPers)
        Me.Controls.Add(Me.PnlSubmenu3d)
        Me.Controls.Add(Me.Lbltitulo)
        Me.Controls.Add(Me.pnldesplmenu)
        Me.Controls.Add(Me.PnlSubMenuDatos)
        Me.Controls.Add(Me.PnlMenu)
        Me.Controls.Add(Me.dgvInfo)
        Me.Controls.Add(Me.grafica)
        Me.ForeColor = System.Drawing.SystemColors.Menu
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmGraficas"
        Me.Text = "."
        CType(Me.grafica, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvInfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbconfig, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlMenu.ResumeLayout(False)
        Me.PnlGrafica.ResumeLayout(False)
        Me.PnlGrafica.PerformLayout()
        Me.Pnl3d.ResumeLayout(False)
        Me.Pnl3d.PerformLayout()
        Me.PnlSubMenuDatos.ResumeLayout(False)
        Me.PnlTratamientos.ResumeLayout(False)
        Me.PnlTratamientos.PerformLayout()
        Me.PnlPromedades.ResumeLayout(False)
        Me.PnlPromedades.PerformLayout()
        Me.pnldesplmenu.ResumeLayout(False)
        Me.pnldesplmenu.PerformLayout()
        Me.PnlSubmenu3d.ResumeLayout(False)
        Me.pnlCambarPerspectiva.ResumeLayout(False)
        Me.pnlCambarPerspectiva.PerformLayout()
        Me.Pnlact3d.ResumeLayout(False)
        Me.Pnlact3d.PerformLayout()
        Me.PnlOpPers.ResumeLayout(False)
        Me.PnlOp3.ResumeLayout(False)
        Me.PnlOp3.PerformLayout()
        Me.PnlOp2.ResumeLayout(False)
        Me.PnlOp2.PerformLayout()
        Me.PnlOp1.ResumeLayout(False)
        Me.PnlOp1.PerformLayout()
        CType(Me.DgvTratamientos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grafica As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents dgvInfo As System.Windows.Forms.DataGridView
    Friend WithEvents pbconfig As System.Windows.Forms.PictureBox
    Friend WithEvents PnlMenu As System.Windows.Forms.Panel
    Friend WithEvents Pnl3d As System.Windows.Forms.Panel
    Friend WithEvents PnlGrafica As System.Windows.Forms.Panel
    Friend WithEvents LblGrafica As System.Windows.Forms.Label
    Friend WithEvents Lbl3d As System.Windows.Forms.Label
    Friend WithEvents PnlSubMenuDatos As System.Windows.Forms.Panel
    Friend WithEvents TmrMovimiento As System.Windows.Forms.Timer
    Friend WithEvents pnldesplmenu As System.Windows.Forms.Panel
    Friend WithEvents PnlPromedades As System.Windows.Forms.Panel
    Friend WithEvents lblEdadPaciente As System.Windows.Forms.Label
    Friend WithEvents Lbltitulo As System.Windows.Forms.Label
    Friend WithEvents PnlSubmenu3d As System.Windows.Forms.Panel
    Friend WithEvents Pnlact3d As System.Windows.Forms.Panel
    Friend WithEvents LblActivar3d As System.Windows.Forms.Label
    Friend WithEvents pnlCambarPerspectiva As System.Windows.Forms.Panel
    Friend WithEvents lblCambiarPers As System.Windows.Forms.Label
    Friend WithEvents PnlTratamientos As System.Windows.Forms.Panel
    Friend WithEvents Lbltratamientos As System.Windows.Forms.Label
    Friend WithEvents PnlOpPers As System.Windows.Forms.Panel
    Friend WithEvents PnlOp1 As System.Windows.Forms.Panel
    Friend WithEvents Lblop1 As System.Windows.Forms.Label
    Friend WithEvents LblDespmenu As System.Windows.Forms.Label
    Friend WithEvents PnlOp2 As System.Windows.Forms.Panel
    Friend WithEvents LblOp2 As System.Windows.Forms.Label
    Friend WithEvents PnlOp3 As System.Windows.Forms.Panel
    Friend WithEvents LblOp3 As System.Windows.Forms.Label
    Friend WithEvents DgvTratamientos As System.Windows.Forms.DataGridView
End Class
