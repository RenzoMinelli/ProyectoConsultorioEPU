<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu_Inicio
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
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
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
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.pnlCitas2 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.lblGraficas = New System.Windows.Forms.Label()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.lblFinanzas = New System.Windows.Forms.Label()
        Me.Panel15 = New System.Windows.Forms.Panel()
        Me.lblAranceles = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
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
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel12.SuspendLayout()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel13.SuspendLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel15.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
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
        Me.pnlBarraSuperior.Size = New System.Drawing.Size(1164, 38)
        Me.pnlBarraSuperior.TabIndex = 7
        '
        'pbMaximizar
        '
        Me.pbMaximizar.Image = Global.WindowsApplication1.My.Resources.Resources.maximize_window_1_
        Me.pbMaximizar.Location = New System.Drawing.Point(1071, 6)
        Me.pbMaximizar.Name = "pbMaximizar"
        Me.pbMaximizar.Size = New System.Drawing.Size(28, 29)
        Me.pbMaximizar.TabIndex = 19
        Me.pbMaximizar.TabStop = False
        '
        'pbCerrar
        '
        Me.pbCerrar.Image = Global.WindowsApplication1.My.Resources.Resources.media_1_
        Me.pbCerrar.Location = New System.Drawing.Point(1105, 6)
        Me.pbCerrar.Name = "pbCerrar"
        Me.pbCerrar.Size = New System.Drawing.Size(27, 32)
        Me.pbCerrar.TabIndex = 18
        Me.pbCerrar.TabStop = False
        '
        'pbMinimizar
        '
        Me.pbMinimizar.Image = Global.WindowsApplication1.My.Resources.Resources.minimize_window
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
        Me.pbPacientes.Image = Global.WindowsApplication1.My.Resources.Resources._25437
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
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel4.Location = New System.Drawing.Point(3, 165)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(10, 32)
        Me.Panel4.TabIndex = 7
        '
        'pnlCitas2
        '
        Me.pnlCitas2.BackColor = System.Drawing.Color.RoyalBlue
        Me.pnlCitas2.Location = New System.Drawing.Point(3, 93)
        Me.pnlCitas2.Name = "pnlCitas2"
        Me.pnlCitas2.Size = New System.Drawing.Size(10, 32)
        Me.pnlCitas2.TabIndex = 7
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel6.Location = New System.Drawing.Point(3, 201)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(10, 32)
        Me.Panel6.TabIndex = 8
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel7.Location = New System.Drawing.Point(3, 237)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(10, 32)
        Me.Panel7.TabIndex = 9
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel8.Controls.Add(Me.PictureBox6)
        Me.Panel8.Controls.Add(Me.lblReloj)
        Me.Panel8.Location = New System.Drawing.Point(0, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(182, 38)
        Me.Panel8.TabIndex = 20
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = Global.WindowsApplication1.My.Resources.Resources.letterx_87521
        Me.PictureBox6.Location = New System.Drawing.Point(128, 5)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(25, 29)
        Me.PictureBox6.TabIndex = 15
        Me.PictureBox6.TabStop = False
        '
        'Panel12
        '
        Me.Panel12.BackColor = System.Drawing.Color.Silver
        Me.Panel12.Controls.Add(Me.PictureBox10)
        Me.Panel12.Controls.Add(Me.lblGraficas)
        Me.Panel12.Location = New System.Drawing.Point(13, 237)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(161, 32)
        Me.Panel12.TabIndex = 22
        '
        'PictureBox10
        '
        Me.PictureBox10.Image = Global.WindowsApplication1.My.Resources.Resources._20803
        Me.PictureBox10.Location = New System.Drawing.Point(6, 2)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(27, 32)
        Me.PictureBox10.TabIndex = 20
        Me.PictureBox10.TabStop = False
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
        'Panel13
        '
        Me.Panel13.BackColor = System.Drawing.Color.Silver
        Me.Panel13.Controls.Add(Me.PictureBox7)
        Me.Panel13.Controls.Add(Me.lblFinanzas)
        Me.Panel13.Location = New System.Drawing.Point(13, 201)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(161, 32)
        Me.Panel13.TabIndex = 23
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = Global.WindowsApplication1.My.Resources.Resources._64979
        Me.PictureBox7.Location = New System.Drawing.Point(7, 2)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(27, 32)
        Me.PictureBox7.TabIndex = 15
        Me.PictureBox7.TabStop = False
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
        'Panel15
        '
        Me.Panel15.BackColor = System.Drawing.Color.Silver
        Me.Panel15.Controls.Add(Me.lblAranceles)
        Me.Panel15.Controls.Add(Me.PictureBox1)
        Me.Panel15.Location = New System.Drawing.Point(13, 165)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New System.Drawing.Size(163, 32)
        Me.Panel15.TabIndex = 24
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
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.money_bag
        Me.PictureBox1.Location = New System.Drawing.Point(6, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(27, 32)
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'pnlMenu
        '
        Me.pnlMenu.BackColor = System.Drawing.Color.LightGray
        Me.pnlMenu.Controls.Add(Me.Panel15)
        Me.pnlMenu.Controls.Add(Me.Panel13)
        Me.pnlMenu.Controls.Add(Me.Panel12)
        Me.pnlMenu.Controls.Add(Me.Panel8)
        Me.pnlMenu.Controls.Add(Me.Panel7)
        Me.pnlMenu.Controls.Add(Me.Panel6)
        Me.pnlMenu.Controls.Add(Me.pnlCitas2)
        Me.pnlMenu.Controls.Add(Me.Panel4)
        Me.pnlMenu.Controls.Add(Me.pnlPacientes2)
        Me.pnlMenu.Controls.Add(Me.pnlCitas)
        Me.pnlMenu.Controls.Add(Me.pnlPacientes)
        Me.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlMenu.Location = New System.Drawing.Point(0, 0)
        Me.pnlMenu.Name = "pnlMenu"
        Me.pnlMenu.Size = New System.Drawing.Size(174, 919)
        Me.pnlMenu.TabIndex = 5
        '
        'Menu_Inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(1338, 919)
        Me.Controls.Add(Me.pnlBarraSuperior)
        Me.Controls.Add(Me.pnlMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.IsMdiContainer = True
        Me.Name = "Menu_Inicio"
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
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel12.ResumeLayout(False)
        Me.Panel12.PerformLayout()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel13.ResumeLayout(False)
        Me.Panel13.PerformLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel15.ResumeLayout(False)
        Me.Panel15.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
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
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents pnlCitas2 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents Panel12 As System.Windows.Forms.Panel
    Friend WithEvents Panel13 As System.Windows.Forms.Panel
    Friend WithEvents lblFinanzas As System.Windows.Forms.Label
    Friend WithEvents Panel15 As System.Windows.Forms.Panel
    Friend WithEvents lblAranceles As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents pnlMenu As System.Windows.Forms.Panel
    Friend WithEvents lblGraficas As System.Windows.Forms.Label
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox7 As System.Windows.Forms.PictureBox
    Friend WithEvents pbCitas As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox10 As System.Windows.Forms.PictureBox
    Friend WithEvents pbMaximizar As System.Windows.Forms.PictureBox
End Class
