<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenuInicio
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
        Me.tmrReloj = New System.Windows.Forms.Timer(Me.components)
        Me.pnlBarraSuperior = New System.Windows.Forms.Panel()
        Me.pbMaximizar = New System.Windows.Forms.PictureBox()
        Me.pbCerrar = New System.Windows.Forms.PictureBox()
        Me.pbMinimizar = New System.Windows.Forms.PictureBox()
        Me.lblReloj = New System.Windows.Forms.Label()
        Me.pnlPacientes = New System.Windows.Forms.Panel()
        Me.pbPacientes = New System.Windows.Forms.PictureBox()
        Me.lblPacientes = New System.Windows.Forms.Label()
        Me.pnlCitas = New System.Windows.Forms.Panel()
        Me.pbCitas = New System.Windows.Forms.PictureBox()
        Me.lblCitas = New System.Windows.Forms.Label()
        Me.pnlPacientes2 = New System.Windows.Forms.Panel()
        Me.pnlAranceles2 = New System.Windows.Forms.Panel()
        Me.pnlCitas2 = New System.Windows.Forms.Panel()
        Me.pnlFinanzas2 = New System.Windows.Forms.Panel()
        Me.pnlGraficas2 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.pbConexion = New System.Windows.Forms.PictureBox()
        Me.pnlGraficas = New System.Windows.Forms.Panel()
        Me.pbGraficas = New System.Windows.Forms.PictureBox()
        Me.lblGraficas = New System.Windows.Forms.Label()
        Me.pnlFinanzas = New System.Windows.Forms.Panel()
        Me.pbFinanzas = New System.Windows.Forms.PictureBox()
        Me.lblFinanzas = New System.Windows.Forms.Label()
        Me.pnlAranceles = New System.Windows.Forms.Panel()
        Me.lblAranceles = New System.Windows.Forms.Label()
        Me.pbAranceles = New System.Windows.Forms.PictureBox()
        Me.pnlMenu = New System.Windows.Forms.Panel()
        Me.pnlBarraSuperior.SuspendLayout()
        CType(Me.pbMaximizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbMinimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlPacientes.SuspendLayout()
        CType(Me.pbPacientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlCitas.SuspendLayout()
        CType(Me.pbCitas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel8.SuspendLayout()
        CType(Me.pbConexion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlGraficas.SuspendLayout()
        CType(Me.pbGraficas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlFinanzas.SuspendLayout()
        CType(Me.pbFinanzas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlAranceles.SuspendLayout()
        CType(Me.pbAranceles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'tmrReloj
        '
        Me.tmrReloj.Enabled = True
        '
        'pnlBarraSuperior
        '
        Me.pnlBarraSuperior.BackColor = System.Drawing.Color.RoyalBlue
        Me.pnlBarraSuperior.Controls.Add(Me.pbMaximizar)
        Me.pnlBarraSuperior.Controls.Add(Me.pbCerrar)
        Me.pnlBarraSuperior.Controls.Add(Me.pbMinimizar)
        Me.pnlBarraSuperior.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlBarraSuperior.Location = New System.Drawing.Point(174, 0)
        Me.pnlBarraSuperior.Name = "pnlBarraSuperior"
        Me.pnlBarraSuperior.Size = New System.Drawing.Size(1176, 38)
        Me.pnlBarraSuperior.TabIndex = 7
        '
        'pbMaximizar
        '
        Me.pbMaximizar.Image = Global.WindowsApplication1.My.Resources.Resources.IconoVistaMaximizar
        Me.pbMaximizar.Location = New System.Drawing.Point(1071, 6)
        Me.pbMaximizar.Name = "pbMaximizar"
        Me.pbMaximizar.Size = New System.Drawing.Size(28, 29)
        Me.pbMaximizar.TabIndex = 19
        Me.pbMaximizar.TabStop = False
        '
        'pbCerrar
        '
        Me.pbCerrar.Image = Global.WindowsApplication1.My.Resources.Resources.IconoCerrar2
        Me.pbCerrar.Location = New System.Drawing.Point(1105, 6)
        Me.pbCerrar.Name = "pbCerrar"
        Me.pbCerrar.Size = New System.Drawing.Size(27, 32)
        Me.pbCerrar.TabIndex = 18
        Me.pbCerrar.TabStop = False
        '
        'pbMinimizar
        '
        Me.pbMinimizar.Image = Global.WindowsApplication1.My.Resources.Resources.IconoMinimizar
        Me.pbMinimizar.Location = New System.Drawing.Point(1034, 6)
        Me.pbMinimizar.Name = "pbMinimizar"
        Me.pbMinimizar.Size = New System.Drawing.Size(28, 32)
        Me.pbMinimizar.TabIndex = 17
        Me.pbMinimizar.TabStop = False
        '
        'lblReloj
        '
        Me.lblReloj.AutoSize = True
        Me.lblReloj.BackColor = System.Drawing.Color.Transparent
        Me.lblReloj.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReloj.ForeColor = System.Drawing.Color.White
        Me.lblReloj.Location = New System.Drawing.Point(12, 3)
        Me.lblReloj.Name = "lblReloj"
        Me.lblReloj.Size = New System.Drawing.Size(103, 29)
        Me.lblReloj.TabIndex = 9
        Me.lblReloj.Text = "00:00:00"
        '
        'pnlPacientes
        '
        Me.pnlPacientes.BackColor = System.Drawing.Color.Silver
        Me.pnlPacientes.Controls.Add(Me.pbPacientes)
        Me.pnlPacientes.Controls.Add(Me.lblPacientes)
        Me.pnlPacientes.Location = New System.Drawing.Point(13, 129)
        Me.pnlPacientes.Name = "pnlPacientes"
        Me.pnlPacientes.Size = New System.Drawing.Size(161, 32)
        Me.pnlPacientes.TabIndex = 22
        '
        'pbPacientes
        '
        Me.pbPacientes.Image = Global.WindowsApplication1.My.Resources.Resources.IconoPacientes
        Me.pbPacientes.Location = New System.Drawing.Point(6, 2)
        Me.pbPacientes.Name = "pbPacientes"
        Me.pbPacientes.Size = New System.Drawing.Size(27, 32)
        Me.pbPacientes.TabIndex = 13
        Me.pbPacientes.TabStop = False
        '
        'lblPacientes
        '
        Me.lblPacientes.AutoSize = True
        Me.lblPacientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPacientes.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblPacientes.Location = New System.Drawing.Point(39, 3)
        Me.lblPacientes.Name = "lblPacientes"
        Me.lblPacientes.Size = New System.Drawing.Size(119, 29)
        Me.lblPacientes.TabIndex = 9
        Me.lblPacientes.Text = "Pacientes"
        '
        'pnlCitas
        '
        Me.pnlCitas.BackColor = System.Drawing.Color.Silver
        Me.pnlCitas.Controls.Add(Me.pbCitas)
        Me.pnlCitas.Controls.Add(Me.lblCitas)
        Me.pnlCitas.Location = New System.Drawing.Point(13, 93)
        Me.pnlCitas.Name = "pnlCitas"
        Me.pnlCitas.Size = New System.Drawing.Size(161, 32)
        Me.pnlCitas.TabIndex = 21
        '
        'pbCitas
        '
        Me.pbCitas.Image = Global.WindowsApplication1.My.Resources.Resources.notebook
        Me.pbCitas.Location = New System.Drawing.Point(6, 0)
        Me.pbCitas.Name = "pbCitas"
        Me.pbCitas.Size = New System.Drawing.Size(35, 39)
        Me.pbCitas.TabIndex = 25
        Me.pbCitas.TabStop = False
        '
        'lblCitas
        '
        Me.lblCitas.AutoSize = True
        Me.lblCitas.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCitas.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblCitas.Location = New System.Drawing.Point(39, 3)
        Me.lblCitas.Name = "lblCitas"
        Me.lblCitas.Size = New System.Drawing.Size(67, 29)
        Me.lblCitas.TabIndex = 16
        Me.lblCitas.Text = "Citas"
        '
        'pnlPacientes2
        '
        Me.pnlPacientes2.BackColor = System.Drawing.Color.RoyalBlue
        Me.pnlPacientes2.Location = New System.Drawing.Point(3, 129)
        Me.pnlPacientes2.Name = "pnlPacientes2"
        Me.pnlPacientes2.Size = New System.Drawing.Size(10, 32)
        Me.pnlPacientes2.TabIndex = 6
        '
        'pnlAranceles2
        '
        Me.pnlAranceles2.BackColor = System.Drawing.Color.RoyalBlue
        Me.pnlAranceles2.Location = New System.Drawing.Point(3, 165)
        Me.pnlAranceles2.Name = "pnlAranceles2"
        Me.pnlAranceles2.Size = New System.Drawing.Size(10, 32)
        Me.pnlAranceles2.TabIndex = 7
        '
        'pnlCitas2
        '
        Me.pnlCitas2.BackColor = System.Drawing.Color.RoyalBlue
        Me.pnlCitas2.Location = New System.Drawing.Point(3, 93)
        Me.pnlCitas2.Name = "pnlCitas2"
        Me.pnlCitas2.Size = New System.Drawing.Size(10, 32)
        Me.pnlCitas2.TabIndex = 7
        '
        'pnlFinanzas2
        '
        Me.pnlFinanzas2.BackColor = System.Drawing.Color.RoyalBlue
        Me.pnlFinanzas2.Location = New System.Drawing.Point(3, 201)
        Me.pnlFinanzas2.Name = "pnlFinanzas2"
        Me.pnlFinanzas2.Size = New System.Drawing.Size(10, 32)
        Me.pnlFinanzas2.TabIndex = 8
        '
        'pnlGraficas2
        '
        Me.pnlGraficas2.BackColor = System.Drawing.Color.RoyalBlue
        Me.pnlGraficas2.Location = New System.Drawing.Point(3, 237)
        Me.pnlGraficas2.Name = "pnlGraficas2"
        Me.pnlGraficas2.Size = New System.Drawing.Size(10, 32)
        Me.pnlGraficas2.TabIndex = 9
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel8.Controls.Add(Me.pbConexion)
        Me.Panel8.Controls.Add(Me.lblReloj)
        Me.Panel8.Location = New System.Drawing.Point(0, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(182, 38)
        Me.Panel8.TabIndex = 20
        '
        'pbConexion
        '
        Me.pbConexion.Image = Global.WindowsApplication1.My.Resources.Resources.X
        Me.pbConexion.Location = New System.Drawing.Point(139, 6)
        Me.pbConexion.Name = "pbConexion"
        Me.pbConexion.Size = New System.Drawing.Size(32, 29)
        Me.pbConexion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbConexion.TabIndex = 15
        Me.pbConexion.TabStop = False
        '
        'pnlGraficas
        '
        Me.pnlGraficas.BackColor = System.Drawing.Color.Silver
        Me.pnlGraficas.Controls.Add(Me.pbGraficas)
        Me.pnlGraficas.Controls.Add(Me.lblGraficas)
        Me.pnlGraficas.Location = New System.Drawing.Point(13, 237)
        Me.pnlGraficas.Name = "pnlGraficas"
        Me.pnlGraficas.Size = New System.Drawing.Size(161, 32)
        Me.pnlGraficas.TabIndex = 22
        '
        'pbGraficas
        '
        Me.pbGraficas.Image = Global.WindowsApplication1.My.Resources.Resources.IconoGraficas
        Me.pbGraficas.Location = New System.Drawing.Point(6, 2)
        Me.pbGraficas.Name = "pbGraficas"
        Me.pbGraficas.Size = New System.Drawing.Size(27, 32)
        Me.pbGraficas.TabIndex = 20
        Me.pbGraficas.TabStop = False
        '
        'lblGraficas
        '
        Me.lblGraficas.AutoSize = True
        Me.lblGraficas.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGraficas.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblGraficas.Location = New System.Drawing.Point(39, 1)
        Me.lblGraficas.Name = "lblGraficas"
        Me.lblGraficas.Size = New System.Drawing.Size(101, 29)
        Me.lblGraficas.TabIndex = 20
        Me.lblGraficas.Text = "Gráficas"
        '
        'pnlFinanzas
        '
        Me.pnlFinanzas.BackColor = System.Drawing.Color.Silver
        Me.pnlFinanzas.Controls.Add(Me.pbFinanzas)
        Me.pnlFinanzas.Controls.Add(Me.lblFinanzas)
        Me.pnlFinanzas.Location = New System.Drawing.Point(13, 201)
        Me.pnlFinanzas.Name = "pnlFinanzas"
        Me.pnlFinanzas.Size = New System.Drawing.Size(161, 32)
        Me.pnlFinanzas.TabIndex = 23
        '
        'pbFinanzas
        '
        Me.pbFinanzas.Image = Global.WindowsApplication1.My.Resources.Resources.IconoFinazas
        Me.pbFinanzas.Location = New System.Drawing.Point(7, 2)
        Me.pbFinanzas.Name = "pbFinanzas"
        Me.pbFinanzas.Size = New System.Drawing.Size(27, 32)
        Me.pbFinanzas.TabIndex = 15
        Me.pbFinanzas.TabStop = False
        '
        'lblFinanzas
        '
        Me.lblFinanzas.AutoSize = True
        Me.lblFinanzas.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFinanzas.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblFinanzas.Location = New System.Drawing.Point(39, 2)
        Me.lblFinanzas.Name = "lblFinanzas"
        Me.lblFinanzas.Size = New System.Drawing.Size(109, 29)
        Me.lblFinanzas.TabIndex = 19
        Me.lblFinanzas.Text = "Finanzas"
        '
        'pnlAranceles
        '
        Me.pnlAranceles.BackColor = System.Drawing.Color.Silver
        Me.pnlAranceles.Controls.Add(Me.lblAranceles)
        Me.pnlAranceles.Controls.Add(Me.pbAranceles)
        Me.pnlAranceles.Location = New System.Drawing.Point(13, 165)
        Me.pnlAranceles.Name = "pnlAranceles"
        Me.pnlAranceles.Size = New System.Drawing.Size(163, 32)
        Me.pnlAranceles.TabIndex = 24
        '
        'lblAranceles
        '
        Me.lblAranceles.AutoSize = True
        Me.lblAranceles.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAranceles.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblAranceles.Location = New System.Drawing.Point(39, 3)
        Me.lblAranceles.Name = "lblAranceles"
        Me.lblAranceles.Size = New System.Drawing.Size(120, 29)
        Me.lblAranceles.TabIndex = 9
        Me.lblAranceles.Text = "Aranceles"
        '
        'pbAranceles
        '
        Me.pbAranceles.Image = Global.WindowsApplication1.My.Resources.Resources.IconoAranceles
        Me.pbAranceles.Location = New System.Drawing.Point(6, 3)
        Me.pbAranceles.Name = "pbAranceles"
        Me.pbAranceles.Size = New System.Drawing.Size(27, 32)
        Me.pbAranceles.TabIndex = 14
        Me.pbAranceles.TabStop = False
        '
        'pnlMenu
        '
        Me.pnlMenu.BackColor = System.Drawing.Color.LightGray
        Me.pnlMenu.Controls.Add(Me.pnlAranceles)
        Me.pnlMenu.Controls.Add(Me.pnlFinanzas)
        Me.pnlMenu.Controls.Add(Me.pnlGraficas)
        Me.pnlMenu.Controls.Add(Me.Panel8)
        Me.pnlMenu.Controls.Add(Me.pnlGraficas2)
        Me.pnlMenu.Controls.Add(Me.pnlFinanzas2)
        Me.pnlMenu.Controls.Add(Me.pnlCitas2)
        Me.pnlMenu.Controls.Add(Me.pnlAranceles2)
        Me.pnlMenu.Controls.Add(Me.pnlPacientes2)
        Me.pnlMenu.Controls.Add(Me.pnlCitas)
        Me.pnlMenu.Controls.Add(Me.pnlPacientes)
        Me.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlMenu.Location = New System.Drawing.Point(0, 0)
        Me.pnlMenu.Name = "pnlMenu"
        Me.pnlMenu.Size = New System.Drawing.Size(174, 729)
        Me.pnlMenu.TabIndex = 5
        '
        'frmMenuInicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.Controls.Add(Me.pnlBarraSuperior)
        Me.Controls.Add(Me.pnlMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.IsMdiContainer = True
        Me.Name = "frmMenuInicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu_Inicio"
        Me.pnlBarraSuperior.ResumeLayout(False)
        CType(Me.pbMaximizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbMinimizar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlPacientes.ResumeLayout(False)
        Me.pnlPacientes.PerformLayout()
        CType(Me.pbPacientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlCitas.ResumeLayout(False)
        Me.pnlCitas.PerformLayout()
        CType(Me.pbCitas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        CType(Me.pbConexion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlGraficas.ResumeLayout(False)
        Me.pnlGraficas.PerformLayout()
        CType(Me.pbGraficas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlFinanzas.ResumeLayout(False)
        Me.pnlFinanzas.PerformLayout()
        CType(Me.pbFinanzas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlAranceles.ResumeLayout(False)
        Me.pnlAranceles.PerformLayout()
        CType(Me.pbAranceles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tmrReloj As System.Windows.Forms.Timer
    Friend WithEvents pnlBarraSuperior As System.Windows.Forms.Panel
    Friend WithEvents pbCerrar As System.Windows.Forms.PictureBox
    Friend WithEvents pbMinimizar As System.Windows.Forms.PictureBox
    Friend WithEvents lblReloj As System.Windows.Forms.Label
    Friend WithEvents pnlPacientes As System.Windows.Forms.Panel
    Friend WithEvents pbPacientes As System.Windows.Forms.PictureBox
    Friend WithEvents lblPacientes As System.Windows.Forms.Label
    Friend WithEvents pnlCitas As System.Windows.Forms.Panel
    Friend WithEvents lblCitas As System.Windows.Forms.Label
    Friend WithEvents pnlPacientes2 As System.Windows.Forms.Panel
    Friend WithEvents pnlAranceles2 As System.Windows.Forms.Panel
    Friend WithEvents pnlCitas2 As System.Windows.Forms.Panel
    Friend WithEvents pnlFinanzas2 As System.Windows.Forms.Panel
    Friend WithEvents pnlGraficas2 As System.Windows.Forms.Panel
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents pnlGraficas As System.Windows.Forms.Panel
    Friend WithEvents pnlFinanzas As System.Windows.Forms.Panel
    Friend WithEvents lblFinanzas As System.Windows.Forms.Label
    Friend WithEvents pnlAranceles As System.Windows.Forms.Panel
    Friend WithEvents lblAranceles As System.Windows.Forms.Label
    Friend WithEvents pbAranceles As System.Windows.Forms.PictureBox
    Friend WithEvents pnlMenu As System.Windows.Forms.Panel
    Friend WithEvents lblGraficas As System.Windows.Forms.Label
    Friend WithEvents pbConexion As System.Windows.Forms.PictureBox
    Friend WithEvents pbFinanzas As System.Windows.Forms.PictureBox
    Friend WithEvents pbCitas As System.Windows.Forms.PictureBox
    Friend WithEvents pbGraficas As System.Windows.Forms.PictureBox
    Friend WithEvents pbMaximizar As System.Windows.Forms.PictureBox
End Class
