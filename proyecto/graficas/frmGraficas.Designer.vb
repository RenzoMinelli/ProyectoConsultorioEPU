﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.PnlTipo = New System.Windows.Forms.Panel()
        Me.LblTipo = New System.Windows.Forms.Label()
        Me.PnlSubMenuDatos = New System.Windows.Forms.Panel()
        Me.PnlPromedades = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Movimiento = New System.Windows.Forms.Timer(Me.components)
        Me.pnldesplmenu = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PnlSubmenu3d = New System.Windows.Forms.Panel()
        Me.Pnlact3d = New System.Windows.Forms.Panel()
        Me.LblActivar3d = New System.Windows.Forms.Label()
        CType(Me.grafica, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbconfig, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlMenu.SuspendLayout()
        Me.PnlGrafica.SuspendLayout()
        Me.Pnl3d.SuspendLayout()
        Me.PnlTipo.SuspendLayout()
        Me.PnlSubMenuDatos.SuspendLayout()
        Me.PnlPromedades.SuspendLayout()
        Me.pnldesplmenu.SuspendLayout()
        Me.PnlSubmenu3d.SuspendLayout()
        Me.Pnlact3d.SuspendLayout()
        Me.SuspendLayout()
        '
        'grafica
        '
        ChartArea1.Name = "Pacientes"
        Me.grafica.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.grafica.Legends.Add(Legend1)
        Me.grafica.Location = New System.Drawing.Point(1, 45)
        Me.grafica.Margin = New System.Windows.Forms.Padding(4)
        Me.grafica.Name = "grafica"
        Series1.ChartArea = "Pacientes"
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
        Me.dgvInfo.Location = New System.Drawing.Point(1, -2)
        Me.dgvInfo.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvInfo.Name = "dgvInfo"
        Me.dgvInfo.ReadOnly = True
        Me.dgvInfo.Size = New System.Drawing.Size(10, 10)
        Me.dgvInfo.TabIndex = 6
        Me.dgvInfo.Visible = False
        '
        'pbconfig
        '
        Me.pbconfig.Image = Global.WindowsApplication1.My.Resources.Resources.ruedita
        Me.pbconfig.Location = New System.Drawing.Point(201, 0)
        Me.pbconfig.Margin = New System.Windows.Forms.Padding(4)
        Me.pbconfig.Name = "pbconfig"
        Me.pbconfig.Size = New System.Drawing.Size(43, 40)
        Me.pbconfig.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbconfig.TabIndex = 8
        Me.pbconfig.TabStop = False
        '
        'PnlMenu
        '
        Me.PnlMenu.BackColor = System.Drawing.Color.MidnightBlue
        Me.PnlMenu.Controls.Add(Me.PnlGrafica)
        Me.PnlMenu.Controls.Add(Me.Pnl3d)
        Me.PnlMenu.Controls.Add(Me.PnlTipo)
        Me.PnlMenu.Location = New System.Drawing.Point(1337, 46)
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
        Me.PnlGrafica.Location = New System.Drawing.Point(0, 186)
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
        Me.LblGrafica.ForeColor = System.Drawing.SystemColors.Menu
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
        Me.Lbl3d.ForeColor = System.Drawing.SystemColors.Menu
        Me.Lbl3d.Location = New System.Drawing.Point(48, 8)
        Me.Lbl3d.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbl3d.Name = "Lbl3d"
        Me.Lbl3d.Size = New System.Drawing.Size(136, 32)
        Me.Lbl3d.TabIndex = 0
        Me.Lbl3d.Text = "Modo 3D"
        '
        'PnlTipo
        '
        Me.PnlTipo.BackColor = System.Drawing.Color.RoyalBlue
        Me.PnlTipo.Controls.Add(Me.LblTipo)
        Me.PnlTipo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.PnlTipo.Location = New System.Drawing.Point(0, 119)
        Me.PnlTipo.Margin = New System.Windows.Forms.Padding(4)
        Me.PnlTipo.Name = "PnlTipo"
        Me.PnlTipo.Size = New System.Drawing.Size(248, 44)
        Me.PnlTipo.TabIndex = 12
        Me.PnlTipo.Visible = False
        '
        'LblTipo
        '
        Me.LblTipo.AutoSize = True
        Me.LblTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTipo.ForeColor = System.Drawing.SystemColors.Menu
        Me.LblTipo.Location = New System.Drawing.Point(27, 7)
        Me.LblTipo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblTipo.Name = "LblTipo"
        Me.LblTipo.Size = New System.Drawing.Size(197, 29)
        Me.LblTipo.TabIndex = 1
        Me.LblTipo.Text = "Tipo De Grafica"
        '
        'PnlSubMenuDatos
        '
        Me.PnlSubMenuDatos.BackColor = System.Drawing.Color.MidnightBlue
        Me.PnlSubMenuDatos.Controls.Add(Me.PnlPromedades)
        Me.PnlSubMenuDatos.Location = New System.Drawing.Point(1069, 200)
        Me.PnlSubMenuDatos.Margin = New System.Windows.Forms.Padding(4)
        Me.PnlSubMenuDatos.Name = "PnlSubMenuDatos"
        Me.PnlSubMenuDatos.Size = New System.Drawing.Size(268, 136)
        Me.PnlSubMenuDatos.TabIndex = 13
        Me.PnlSubMenuDatos.Visible = False
        '
        'PnlPromedades
        '
        Me.PnlPromedades.BackColor = System.Drawing.Color.MidnightBlue
        Me.PnlPromedades.Controls.Add(Me.Label1)
        Me.PnlPromedades.Location = New System.Drawing.Point(0, 0)
        Me.PnlPromedades.Name = "PnlPromedades"
        Me.PnlPromedades.Size = New System.Drawing.Size(268, 38)
        Me.PnlPromedades.TabIndex = 21
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(14, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(224, 29)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Edades Pacientes"
        '
        'Movimiento
        '
        Me.Movimiento.Interval = 15
        '
        'pnldesplmenu
        '
        Me.pnldesplmenu.BackColor = System.Drawing.Color.DarkBlue
        Me.pnldesplmenu.Controls.Add(Me.pbconfig)
        Me.pnldesplmenu.Location = New System.Drawing.Point(1337, -2)
        Me.pnldesplmenu.Name = "pnldesplmenu"
        Me.pnldesplmenu.Size = New System.Drawing.Size(248, 40)
        Me.pnldesplmenu.TabIndex = 20
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label2.Location = New System.Drawing.Point(51, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(840, 32)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "la infomracion mostrada es ""Promedio edades de pacientes"":"
        '
        'PnlSubmenu3d
        '
        Me.PnlSubmenu3d.BackColor = System.Drawing.Color.MidnightBlue
        Me.PnlSubmenu3d.Controls.Add(Me.Pnlact3d)
        Me.PnlSubmenu3d.Location = New System.Drawing.Point(1069, 70)
        Me.PnlSubmenu3d.Margin = New System.Windows.Forms.Padding(4)
        Me.PnlSubmenu3d.Name = "PnlSubmenu3d"
        Me.PnlSubmenu3d.Size = New System.Drawing.Size(268, 136)
        Me.PnlSubmenu3d.TabIndex = 22
        Me.PnlSubmenu3d.Visible = False
        '
        'Pnlact3d
        '
        Me.Pnlact3d.BackColor = System.Drawing.Color.MidnightBlue
        Me.Pnlact3d.Controls.Add(Me.LblActivar3d)
        Me.Pnlact3d.Location = New System.Drawing.Point(0, 0)
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
        'frmGraficas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1848, 747)
        Me.Controls.Add(Me.PnlSubmenu3d)
        Me.Controls.Add(Me.Label2)
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
        Me.PnlTipo.ResumeLayout(False)
        Me.PnlTipo.PerformLayout()
        Me.PnlSubMenuDatos.ResumeLayout(False)
        Me.PnlPromedades.ResumeLayout(False)
        Me.PnlPromedades.PerformLayout()
        Me.pnldesplmenu.ResumeLayout(False)
        Me.PnlSubmenu3d.ResumeLayout(False)
        Me.Pnlact3d.ResumeLayout(False)
        Me.Pnlact3d.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grafica As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents dgvInfo As System.Windows.Forms.DataGridView
    Friend WithEvents pbconfig As System.Windows.Forms.PictureBox
    Friend WithEvents PnlMenu As System.Windows.Forms.Panel
    Friend WithEvents PnlTipo As System.Windows.Forms.Panel
    Friend WithEvents Pnl3d As System.Windows.Forms.Panel
    Friend WithEvents PnlGrafica As System.Windows.Forms.Panel
    Friend WithEvents LblGrafica As System.Windows.Forms.Label
    Friend WithEvents Lbl3d As System.Windows.Forms.Label
    Friend WithEvents LblTipo As System.Windows.Forms.Label
    Friend WithEvents PnlSubMenuDatos As System.Windows.Forms.Panel
    Friend WithEvents Movimiento As System.Windows.Forms.Timer
    Friend WithEvents pnldesplmenu As System.Windows.Forms.Panel
    Friend WithEvents PnlPromedades As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PnlSubmenu3d As System.Windows.Forms.Panel
    Friend WithEvents Pnlact3d As System.Windows.Forms.Panel
    Friend WithEvents LblActivar3d As System.Windows.Forms.Label
End Class