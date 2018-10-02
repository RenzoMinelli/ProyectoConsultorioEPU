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
        Me.PnlTipo = New System.Windows.Forms.Panel()
        Me.LblTipo = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Movimiento = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.grafica, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbconfig, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlMenu.SuspendLayout()
        Me.PnlGrafica.SuspendLayout()
        Me.Pnl3d.SuspendLayout()
        Me.PnlTipo.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.SuspendLayout()
        '
        'grafica
        '
        ChartArea1.Name = "Pacientes"
        Me.grafica.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.grafica.Legends.Add(Legend1)
        Me.grafica.Location = New System.Drawing.Point(1, 70)
        Me.grafica.Name = "grafica"
        Series1.ChartArea = "Pacientes"
        Series1.Legend = "Legend1"
        Series1.Name = "Num pacientes"
        Me.grafica.Series.Add(Series1)
        Me.grafica.Size = New System.Drawing.Size(694, 500)
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
        Me.dgvInfo.Location = New System.Drawing.Point(12, 12)
        Me.dgvInfo.Name = "dgvInfo"
        Me.dgvInfo.ReadOnly = True
        Me.dgvInfo.Size = New System.Drawing.Size(21, 19)
        Me.dgvInfo.TabIndex = 6
        Me.dgvInfo.Visible = False
        '
        'pbconfig
        '
        Me.pbconfig.Image = Global.WindowsApplication1.My.Resources.Resources.ruedita
        Me.pbconfig.Location = New System.Drawing.Point(1150, 1)
        Me.pbconfig.Name = "pbconfig"
        Me.pbconfig.Size = New System.Drawing.Size(38, 40)
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
        Me.PnlMenu.Location = New System.Drawing.Point(1250, 42)
        Me.PnlMenu.Name = "PnlMenu"
        Me.PnlMenu.Size = New System.Drawing.Size(186, 345)
        Me.PnlMenu.TabIndex = 10
        '
        'PnlGrafica
        '
        Me.PnlGrafica.BackColor = System.Drawing.Color.RoyalBlue
        Me.PnlGrafica.Controls.Add(Me.LblGrafica)
        Me.PnlGrafica.ForeColor = System.Drawing.SystemColors.ControlText
        Me.PnlGrafica.Location = New System.Drawing.Point(0, 151)
        Me.PnlGrafica.Name = "PnlGrafica"
        Me.PnlGrafica.Size = New System.Drawing.Size(186, 36)
        Me.PnlGrafica.TabIndex = 13
        Me.PnlGrafica.Visible = False
        '
        'LblGrafica
        '
        Me.LblGrafica.AutoSize = True
        Me.LblGrafica.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblGrafica.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.LblGrafica.Location = New System.Drawing.Point(27, 7)
        Me.LblGrafica.Name = "LblGrafica"
        Me.LblGrafica.Size = New System.Drawing.Size(133, 24)
        Me.LblGrafica.TabIndex = 0
        Me.LblGrafica.Text = "Datos Grafica"
        '
        'Pnl3d
        '
        Me.Pnl3d.BackColor = System.Drawing.Color.RoyalBlue
        Me.Pnl3d.Controls.Add(Me.Lbl3d)
        Me.Pnl3d.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Pnl3d.Location = New System.Drawing.Point(0, 46)
        Me.Pnl3d.Name = "Pnl3d"
        Me.Pnl3d.Size = New System.Drawing.Size(186, 36)
        Me.Pnl3d.TabIndex = 11
        Me.Pnl3d.Visible = False
        '
        'Lbl3d
        '
        Me.Lbl3d.AutoSize = True
        Me.Lbl3d.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl3d.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.Lbl3d.Location = New System.Drawing.Point(25, 5)
        Me.Lbl3d.Name = "Lbl3d"
        Me.Lbl3d.Size = New System.Drawing.Size(118, 29)
        Me.Lbl3d.TabIndex = 0
        Me.Lbl3d.Text = "Modo 3D"
        '
        'PnlTipo
        '
        Me.PnlTipo.BackColor = System.Drawing.Color.RoyalBlue
        Me.PnlTipo.Controls.Add(Me.LblTipo)
        Me.PnlTipo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.PnlTipo.Location = New System.Drawing.Point(0, 97)
        Me.PnlTipo.Name = "PnlTipo"
        Me.PnlTipo.Size = New System.Drawing.Size(186, 36)
        Me.PnlTipo.TabIndex = 12
        Me.PnlTipo.Visible = False
        '
        'LblTipo
        '
        Me.LblTipo.AutoSize = True
        Me.LblTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTipo.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.LblTipo.Location = New System.Drawing.Point(20, 6)
        Me.LblTipo.Name = "LblTipo"
        Me.LblTipo.Size = New System.Drawing.Size(155, 24)
        Me.LblTipo.TabIndex = 1
        Me.LblTipo.Text = "Tipo De Grafica"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel4.Controls.Add(Me.Panel8)
        Me.Panel4.Controls.Add(Me.Panel7)
        Me.Panel4.Controls.Add(Me.Panel5)
        Me.Panel4.Location = New System.Drawing.Point(738, 70)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(201, 299)
        Me.Panel4.TabIndex = 13
        Me.Panel4.Visible = False
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.MidnightBlue
        Me.Panel8.Location = New System.Drawing.Point(0, 210)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(201, 36)
        Me.Panel8.TabIndex = 16
        Me.Panel8.Visible = False
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.MidnightBlue
        Me.Panel7.Location = New System.Drawing.Point(0, 158)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(201, 36)
        Me.Panel7.TabIndex = 16
        Me.Panel7.Visible = False
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.MidnightBlue
        Me.Panel5.Location = New System.Drawing.Point(0, 53)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(201, 36)
        Me.Panel5.TabIndex = 14
        Me.Panel5.Visible = False
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.MidnightBlue
        Me.Panel6.Location = New System.Drawing.Point(738, 175)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(201, 36)
        Me.Panel6.TabIndex = 15
        Me.Panel6.Visible = False
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.MidnightBlue
        Me.Panel9.Location = New System.Drawing.Point(738, 333)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(201, 36)
        Me.Panel9.TabIndex = 16
        Me.Panel9.Visible = False
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.MidnightBlue
        Me.Panel10.Controls.Add(Me.Label3)
        Me.Panel10.Location = New System.Drawing.Point(738, 70)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(201, 36)
        Me.Panel10.TabIndex = 17
        Me.Panel10.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.Label3.Location = New System.Drawing.Point(17, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(178, 24)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Edades Pacientes"
        Me.Label3.Visible = False
        '
        'Movimiento
        '
        Me.Movimiento.Interval = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(362, 17)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(546, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Label1"
        '
        'frmGraficas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1479, 607)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.pbconfig)
        Me.Controls.Add(Me.Panel10)
        Me.Controls.Add(Me.Panel9)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.PnlMenu)
        Me.Controls.Add(Me.dgvInfo)
        Me.Controls.Add(Me.grafica)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
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
        Me.Panel4.ResumeLayout(False)
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
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
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Movimiento As System.Windows.Forms.Timer
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
