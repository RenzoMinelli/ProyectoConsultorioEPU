﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.btnfuncionario = New System.Windows.Forms.Button()
        Me.btnodontologo = New System.Windows.Forms.Button()
        Me.lblingrusuario = New System.Windows.Forms.Label()
        Me.btningresar = New System.Windows.Forms.Button()
        Me.dgbcontraseña = New System.Windows.Forms.DataGridView()
        Me.txtcontraseña = New System.Windows.Forms.TextBox()
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pbCerrar = New System.Windows.Forms.PictureBox()
        CType(Me.dgbcontraseña, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.pbCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnfuncionario
        '
        Me.btnfuncionario.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold)
        Me.btnfuncionario.Location = New System.Drawing.Point(53, 441)
        Me.btnfuncionario.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnfuncionario.Name = "btnfuncionario"
        Me.btnfuncionario.Size = New System.Drawing.Size(556, 103)
        Me.btnfuncionario.TabIndex = 2
        Me.btnfuncionario.Text = "Funcionario"
        Me.btnfuncionario.UseVisualStyleBackColor = True
        '
        'btnodontologo
        '
        Me.btnodontologo.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold)
        Me.btnodontologo.Location = New System.Drawing.Point(40, 167)
        Me.btnodontologo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnodontologo.Name = "btnodontologo"
        Me.btnodontologo.Size = New System.Drawing.Size(556, 116)
        Me.btnodontologo.TabIndex = 1
        Me.btnodontologo.Text = "Odontologo"
        Me.btnodontologo.UseVisualStyleBackColor = True
        '
        'lblingrusuario
        '
        Me.lblingrusuario.AutoSize = True
        Me.lblingrusuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblingrusuario.Location = New System.Drawing.Point(19, 8)
        Me.lblingrusuario.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblingrusuario.Name = "lblingrusuario"
        Me.lblingrusuario.Size = New System.Drawing.Size(340, 36)
        Me.lblingrusuario.TabIndex = 4
        Me.lblingrusuario.Text = "Seleccione un usuario:"
        '
        'btningresar
        '
        Me.btningresar.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btningresar.Location = New System.Drawing.Point(340, 435)
        Me.btningresar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btningresar.Name = "btningresar"
        Me.btningresar.Size = New System.Drawing.Size(288, 110)
        Me.btningresar.TabIndex = 7
        Me.btningresar.Text = "Ingresar"
        Me.btningresar.UseVisualStyleBackColor = True
        '
        'dgbcontraseña
        '
        Me.dgbcontraseña.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgbcontraseña.Location = New System.Drawing.Point(4, 4)
        Me.dgbcontraseña.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgbcontraseña.Name = "dgbcontraseña"
        Me.dgbcontraseña.Size = New System.Drawing.Size(13, 14)
        Me.dgbcontraseña.TabIndex = 8
        Me.dgbcontraseña.Visible = False
        '
        'txtcontraseña
        '
        Me.txtcontraseña.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcontraseña.Location = New System.Drawing.Point(40, 226)
        Me.txtcontraseña.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtcontraseña.Name = "txtcontraseña"
        Me.txtcontraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtcontraseña.Size = New System.Drawing.Size(555, 41)
        Me.txtcontraseña.TabIndex = 5
        '
        'btnAtras
        '
        Me.btnAtras.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAtras.Location = New System.Drawing.Point(25, 435)
        Me.btnAtras.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(288, 110)
        Me.btnAtras.TabIndex = 9
        Me.btnAtras.Text = "Atras"
        Me.btnAtras.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel1.Controls.Add(Me.pbCerrar)
        Me.Panel1.Controls.Add(Me.lblingrusuario)
        Me.Panel1.Controls.Add(Me.dgbcontraseña)
        Me.Panel1.Location = New System.Drawing.Point(0, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(659, 57)
        Me.Panel1.TabIndex = 10
        '
        'pbCerrar
        '
        Me.pbCerrar.Image = Global.WindowsApplication1.My.Resources.Resources.media_1_
        Me.pbCerrar.Location = New System.Drawing.Point(623, 4)
        Me.pbCerrar.Margin = New System.Windows.Forms.Padding(4)
        Me.pbCerrar.Name = "pbCerrar"
        Me.pbCerrar.Size = New System.Drawing.Size(36, 39)
        Me.pbCerrar.TabIndex = 19
        Me.pbCerrar.TabStop = False
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(660, 649)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnAtras)
        Me.Controls.Add(Me.btningresar)
        Me.Controls.Add(Me.txtcontraseña)
        Me.Controls.Add(Me.btnfuncionario)
        Me.Controls.Add(Me.btnodontologo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.dgbcontraseña, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.pbCerrar, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents pbCerrar As System.Windows.Forms.PictureBox
End Class