<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIngresoContraseña
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
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.txtcontraseña = New System.Windows.Forms.TextBox()
        Me.txtrepcontraseña = New System.Windows.Forms.TextBox()
        Me.lblcontraseña = New System.Windows.Forms.Label()
        Me.lblrepcontraseña = New System.Windows.Forms.Label()
        Me.lblexplicacion = New System.Windows.Forms.Label()
        Me.lblhack = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pbCerrar = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.pbCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnguardar
        '
        Me.btnguardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnguardar.Location = New System.Drawing.Point(116, 464)
        Me.btnguardar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(565, 66)
        Me.btnguardar.TabIndex = 0
        Me.btnguardar.Text = "Guardar Contraseña"
        Me.btnguardar.UseVisualStyleBackColor = True
        '
        'txtcontraseña
        '
        Me.txtcontraseña.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcontraseña.Location = New System.Drawing.Point(479, 265)
        Me.txtcontraseña.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtcontraseña.Name = "txtcontraseña"
        Me.txtcontraseña.Size = New System.Drawing.Size(201, 41)
        Me.txtcontraseña.TabIndex = 1
        '
        'txtrepcontraseña
        '
        Me.txtrepcontraseña.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtrepcontraseña.Location = New System.Drawing.Point(479, 363)
        Me.txtrepcontraseña.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtrepcontraseña.Name = "txtrepcontraseña"
        Me.txtrepcontraseña.Size = New System.Drawing.Size(201, 41)
        Me.txtrepcontraseña.TabIndex = 2
        '
        'lblcontraseña
        '
        Me.lblcontraseña.AutoSize = True
        Me.lblcontraseña.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcontraseña.Location = New System.Drawing.Point(109, 265)
        Me.lblcontraseña.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblcontraseña.Name = "lblcontraseña"
        Me.lblcontraseña.Size = New System.Drawing.Size(302, 36)
        Me.lblcontraseña.TabIndex = 3
        Me.lblcontraseña.Text = "Ingrese Contraseña:"
        '
        'lblrepcontraseña
        '
        Me.lblrepcontraseña.AutoSize = True
        Me.lblrepcontraseña.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblrepcontraseña.Location = New System.Drawing.Point(109, 363)
        Me.lblrepcontraseña.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblrepcontraseña.Name = "lblrepcontraseña"
        Me.lblrepcontraseña.Size = New System.Drawing.Size(288, 36)
        Me.lblrepcontraseña.TabIndex = 4
        Me.lblrepcontraseña.Text = "Repita Contraseña:"
        '
        'lblexplicacion
        '
        Me.lblexplicacion.AutoSize = True
        Me.lblexplicacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblexplicacion.Location = New System.Drawing.Point(43, 54)
        Me.lblexplicacion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblexplicacion.Name = "lblexplicacion"
        Me.lblexplicacion.Size = New System.Drawing.Size(707, 180)
        Me.lblexplicacion.TabIndex = 5
        Me.lblexplicacion.Text = "                                 saludos" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "A continuacion ingrese la contraseñ" & _
            "a que desea " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "para el "
        '
        'lblhack
        '
        Me.lblhack.AutoSize = True
        Me.lblhack.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lblhack.Location = New System.Drawing.Point(160, 167)
        Me.lblhack.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblhack.Name = "lblhack"
        Me.lblhack.Size = New System.Drawing.Size(181, 36)
        Me.lblhack.TabIndex = 6
        Me.lblhack.Text = "Odontologo"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel1.Controls.Add(Me.pbCerrar)
        Me.Panel1.Location = New System.Drawing.Point(2, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(818, 50)
        Me.Panel1.TabIndex = 7
        '
        'pbCerrar
        '
        Me.pbCerrar.Image = Global.WindowsApplication1.My.Resources.Resources.media_1_
        Me.pbCerrar.Location = New System.Drawing.Point(782, 0)
        Me.pbCerrar.Margin = New System.Windows.Forms.Padding(4)
        Me.pbCerrar.Name = "pbCerrar"
        Me.pbCerrar.Size = New System.Drawing.Size(36, 39)
        Me.pbCerrar.TabIndex = 19
        Me.pbCerrar.TabStop = False
        '
        'frmIngresoContraseña
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(820, 577)
        Me.Controls.Add(Me.lblexplicacion)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblhack)
        Me.Controls.Add(Me.lblrepcontraseña)
        Me.Controls.Add(Me.lblcontraseña)
        Me.Controls.Add(Me.txtrepcontraseña)
        Me.Controls.Add(Me.txtcontraseña)
        Me.Controls.Add(Me.btnguardar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmIngresoContraseña"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ingreso_contraseña"
        Me.Panel1.ResumeLayout(False)
        CType(Me.pbCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnguardar As System.Windows.Forms.Button
    Friend WithEvents txtcontraseña As System.Windows.Forms.TextBox
    Friend WithEvents txtrepcontraseña As System.Windows.Forms.TextBox
    Friend WithEvents lblcontraseña As System.Windows.Forms.Label
    Friend WithEvents lblrepcontraseña As System.Windows.Forms.Label
    Friend WithEvents lblexplicacion As System.Windows.Forms.Label
    Friend WithEvents lblhack As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents pbCerrar As System.Windows.Forms.PictureBox
End Class
