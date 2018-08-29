<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.btnfuncionario = New System.Windows.Forms.Button()
        Me.btnodontologo = New System.Windows.Forms.Button()
        Me.lblingrusuario = New System.Windows.Forms.Label()
        Me.txtcontraseña = New System.Windows.Forms.TextBox()
        Me.lblcontraseña = New System.Windows.Forms.Label()
        Me.btningresar = New System.Windows.Forms.Button()
        Me.dgbcontraseña = New System.Windows.Forms.DataGridView()
        Me.dgbconfirmar = New System.Windows.Forms.DataGridView()
        CType(Me.dgbcontraseña, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgbconfirmar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(157, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(293, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Seleccione un Usuario:"
        '
        'btnfuncionario
        '
        Me.btnfuncionario.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnfuncionario.Location = New System.Drawing.Point(33, 279)
        Me.btnfuncionario.Name = "btnfuncionario"
        Me.btnfuncionario.Size = New System.Drawing.Size(231, 84)
        Me.btnfuncionario.TabIndex = 2
        Me.btnfuncionario.Text = "Funcionario"
        Me.btnfuncionario.UseVisualStyleBackColor = True
        '
        'btnodontologo
        '
        Me.btnodontologo.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnodontologo.Location = New System.Drawing.Point(33, 168)
        Me.btnodontologo.Name = "btnodontologo"
        Me.btnodontologo.Size = New System.Drawing.Size(231, 79)
        Me.btnodontologo.TabIndex = 1
        Me.btnodontologo.Text = "Odontologo"
        Me.btnodontologo.UseVisualStyleBackColor = True
        '
        'lblingrusuario
        '
        Me.lblingrusuario.AutoSize = True
        Me.lblingrusuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblingrusuario.Location = New System.Drawing.Point(28, 112)
        Me.lblingrusuario.Name = "lblingrusuario"
        Me.lblingrusuario.Size = New System.Drawing.Size(236, 29)
        Me.lblingrusuario.TabIndex = 4
        Me.lblingrusuario.Text = "ingrese un usuario:"
        '
        'txtcontraseña
        '
        Me.txtcontraseña.Location = New System.Drawing.Point(296, 259)
        Me.txtcontraseña.Name = "txtcontraseña"
        Me.txtcontraseña.Size = New System.Drawing.Size(154, 20)
        Me.txtcontraseña.TabIndex = 5
        '
        'lblcontraseña
        '
        Me.lblcontraseña.AutoSize = True
        Me.lblcontraseña.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcontraseña.Location = New System.Drawing.Point(28, 250)
        Me.lblcontraseña.Name = "lblcontraseña"
        Me.lblcontraseña.Size = New System.Drawing.Size(248, 29)
        Me.lblcontraseña.TabIndex = 6
        Me.lblcontraseña.Text = "Ingrese Contraseña:"
        '
        'btningresar
        '
        Me.btningresar.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btningresar.Location = New System.Drawing.Point(33, 498)
        Me.btningresar.Name = "btningresar"
        Me.btningresar.Size = New System.Drawing.Size(434, 89)
        Me.btningresar.TabIndex = 7
        Me.btningresar.Text = "ingresar"
        Me.btningresar.UseVisualStyleBackColor = True
        '
        'dgbcontraseña
        '
        Me.dgbcontraseña.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgbcontraseña.Location = New System.Drawing.Point(552, 12)
        Me.dgbcontraseña.Name = "dgbcontraseña"
        Me.dgbcontraseña.Size = New System.Drawing.Size(10, 11)
        Me.dgbcontraseña.TabIndex = 8
        Me.dgbcontraseña.Visible = False
        '
        'dgbconfirmar
        '
        Me.dgbconfirmar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgbconfirmar.Location = New System.Drawing.Point(552, 29)
        Me.dgbconfirmar.Name = "dgbconfirmar"
        Me.dgbconfirmar.Size = New System.Drawing.Size(10, 10)
        Me.dgbconfirmar.TabIndex = 9
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(574, 638)
        Me.Controls.Add(Me.dgbconfirmar)
        Me.Controls.Add(Me.dgbcontraseña)
        Me.Controls.Add(Me.btningresar)
        Me.Controls.Add(Me.lblcontraseña)
        Me.Controls.Add(Me.txtcontraseña)
        Me.Controls.Add(Me.lblingrusuario)
        Me.Controls.Add(Me.btnfuncionario)
        Me.Controls.Add(Me.btnodontologo)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.dgbcontraseña, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgbconfirmar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents btnfuncionario As System.Windows.Forms.Button
    Friend WithEvents btnodontologo As System.Windows.Forms.Button
    Friend WithEvents lblingrusuario As System.Windows.Forms.Label
    Friend WithEvents txtcontraseña As System.Windows.Forms.TextBox
    Friend WithEvents lblcontraseña As System.Windows.Forms.Label
    Friend WithEvents btningresar As System.Windows.Forms.Button
    Friend WithEvents dgbcontraseña As System.Windows.Forms.DataGridView
    Friend WithEvents dgbconfirmar As System.Windows.Forms.DataGridView
End Class
