<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Me.btnfuncionario = New System.Windows.Forms.Button()
        Me.btnodontologo = New System.Windows.Forms.Button()
        Me.lblingrusuario = New System.Windows.Forms.Label()
        Me.btningresar = New System.Windows.Forms.Button()
        Me.dgbcontraseña = New System.Windows.Forms.DataGridView()
        Me.txtcontraseña = New System.Windows.Forms.TextBox()
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.pnlBarra = New System.Windows.Forms.Panel()
        Me.pbCerrar = New System.Windows.Forms.PictureBox()
        Me.pbConexion = New System.Windows.Forms.PictureBox()
        Me.tmrConexion = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dgbcontraseña, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlBarra.SuspendLayout()
        CType(Me.pbCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbConexion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnfuncionario
        '
        Me.btnfuncionario.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold)
        Me.btnfuncionario.Location = New System.Drawing.Point(19, 268)
        Me.btnfuncionario.Name = "btnfuncionario"
        Me.btnfuncionario.Size = New System.Drawing.Size(451, 105)
        Me.btnfuncionario.TabIndex = 2
        Me.btnfuncionario.Text = "Funcionario"
        Me.btnfuncionario.UseVisualStyleBackColor = True
        '
        'btnodontologo
        '
        Me.btnodontologo.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold)
        Me.btnodontologo.Location = New System.Drawing.Point(19, 108)
        Me.btnodontologo.Name = "btnodontologo"
        Me.btnodontologo.Size = New System.Drawing.Size(451, 106)
        Me.btnodontologo.TabIndex = 1
        Me.btnodontologo.Text = "Odontologo"
        Me.btnodontologo.UseVisualStyleBackColor = True
        '
        'lblingrusuario
        '
        Me.lblingrusuario.AutoSize = True
        Me.lblingrusuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblingrusuario.Location = New System.Drawing.Point(14, 6)
        Me.lblingrusuario.Name = "lblingrusuario"
        Me.lblingrusuario.Size = New System.Drawing.Size(279, 29)
        Me.lblingrusuario.TabIndex = 4
        Me.lblingrusuario.Text = "Seleccione un usuario:"
        '
        'btningresar
        '
        Me.btningresar.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btningresar.Location = New System.Drawing.Point(254, 284)
        Me.btningresar.Name = "btningresar"
        Me.btningresar.Size = New System.Drawing.Size(216, 89)
        Me.btningresar.TabIndex = 7
        Me.btningresar.Text = "Ingresar"
        Me.btningresar.UseVisualStyleBackColor = True
        '
        'dgbcontraseña
        '
        Me.dgbcontraseña.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgbcontraseña.Location = New System.Drawing.Point(3, 3)
        Me.dgbcontraseña.Name = "dgbcontraseña"
        Me.dgbcontraseña.Size = New System.Drawing.Size(10, 11)
        Me.dgbcontraseña.TabIndex = 8
        Me.dgbcontraseña.Visible = False
        '
        'txtcontraseña
        '
        Me.txtcontraseña.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcontraseña.Location = New System.Drawing.Point(30, 184)
        Me.txtcontraseña.Name = "txtcontraseña"
        Me.txtcontraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtcontraseña.Size = New System.Drawing.Size(417, 35)
        Me.txtcontraseña.TabIndex = 5
        '
        'btnAtras
        '
        Me.btnAtras.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAtras.Location = New System.Drawing.Point(19, 284)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(216, 89)
        Me.btnAtras.TabIndex = 9
        Me.btnAtras.Text = "Atras"
        Me.btnAtras.UseVisualStyleBackColor = True
        '
        'pnlBarra
        '
        Me.pnlBarra.BackColor = System.Drawing.Color.RoyalBlue
        Me.pnlBarra.Controls.Add(Me.pbCerrar)
        Me.pnlBarra.Controls.Add(Me.lblingrusuario)
        Me.pnlBarra.Controls.Add(Me.dgbcontraseña)
        Me.pnlBarra.Location = New System.Drawing.Point(0, -2)
        Me.pnlBarra.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlBarra.Name = "pnlBarra"
        Me.pnlBarra.Size = New System.Drawing.Size(494, 50)
        Me.pnlBarra.TabIndex = 10
        '
        'pbCerrar
        '
        Me.pbCerrar.Image = Global.WindowsApplication1.My.Resources.Resources.IconoCerrar2
        Me.pbCerrar.Location = New System.Drawing.Point(456, 14)
        Me.pbCerrar.Name = "pbCerrar"
        Me.pbCerrar.Size = New System.Drawing.Size(27, 32)
        Me.pbCerrar.TabIndex = 19
        Me.pbCerrar.TabStop = False
        '
        'pbConexion
        '
        Me.pbConexion.Image = Global.WindowsApplication1.My.Resources.Resources.X
        Me.pbConexion.Location = New System.Drawing.Point(461, 429)
        Me.pbConexion.Name = "pbConexion"
        Me.pbConexion.Size = New System.Drawing.Size(28, 27)
        Me.pbConexion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbConexion.TabIndex = 16
        Me.pbConexion.TabStop = False
        '
        'tmrConexion
        '
        Me.tmrConexion.Enabled = True
        Me.tmrConexion.Interval = 10000
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(283, 436)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(175, 20)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Estado de Conexión:"
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(495, 460)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pbConexion)
        Me.Controls.Add(Me.pnlBarra)
        Me.Controls.Add(Me.btnAtras)
        Me.Controls.Add(Me.btningresar)
        Me.Controls.Add(Me.txtcontraseña)
        Me.Controls.Add(Me.btnfuncionario)
        Me.Controls.Add(Me.btnodontologo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.dgbcontraseña, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlBarra.ResumeLayout(False)
        Me.pnlBarra.PerformLayout()
        CType(Me.pbCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbConexion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnfuncionario As System.Windows.Forms.Button
    Friend WithEvents btnodontologo As System.Windows.Forms.Button
    Friend WithEvents lblingrusuario As System.Windows.Forms.Label
    Friend WithEvents btningresar As System.Windows.Forms.Button
    Friend WithEvents dgbcontraseña As System.Windows.Forms.DataGridView
    Friend WithEvents txtcontraseña As System.Windows.Forms.TextBox
    Friend WithEvents btnAtras As System.Windows.Forms.Button
    Friend WithEvents pnlBarra As System.Windows.Forms.Panel
    Friend WithEvents pbCerrar As System.Windows.Forms.PictureBox
    Friend WithEvents pbConexion As System.Windows.Forms.PictureBox
    Friend WithEvents tmrConexion As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
