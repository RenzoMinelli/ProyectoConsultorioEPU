<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ingreso_contraseña
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
        Me.SuspendLayout()
        '
        'btnguardar
        '
        Me.btnguardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnguardar.Location = New System.Drawing.Point(87, 377)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(424, 54)
        Me.btnguardar.TabIndex = 0
        Me.btnguardar.Text = "Guardar Contraseña"
        Me.btnguardar.UseVisualStyleBackColor = True
        '
        'txtcontraseña
        '
        Me.txtcontraseña.Location = New System.Drawing.Point(359, 224)
        Me.txtcontraseña.Name = "txtcontraseña"
        Me.txtcontraseña.Size = New System.Drawing.Size(152, 20)
        Me.txtcontraseña.TabIndex = 1
        '
        'txtrepcontraseña
        '
        Me.txtrepcontraseña.Location = New System.Drawing.Point(359, 304)
        Me.txtrepcontraseña.Name = "txtrepcontraseña"
        Me.txtrepcontraseña.Size = New System.Drawing.Size(152, 20)
        Me.txtrepcontraseña.TabIndex = 2
        '
        'lblcontraseña
        '
        Me.lblcontraseña.AutoSize = True
        Me.lblcontraseña.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcontraseña.Location = New System.Drawing.Point(82, 215)
        Me.lblcontraseña.Name = "lblcontraseña"
        Me.lblcontraseña.Size = New System.Drawing.Size(248, 29)
        Me.lblcontraseña.TabIndex = 3
        Me.lblcontraseña.Text = "Ingrese Contraseña:"
        '
        'lblrepcontraseña
        '
        Me.lblrepcontraseña.AutoSize = True
        Me.lblrepcontraseña.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblrepcontraseña.Location = New System.Drawing.Point(82, 295)
        Me.lblrepcontraseña.Name = "lblrepcontraseña"
        Me.lblrepcontraseña.Size = New System.Drawing.Size(236, 29)
        Me.lblrepcontraseña.TabIndex = 4
        Me.lblrepcontraseña.Text = "Repita Contraseña:"
        '
        'lblexplicacion
        '
        Me.lblexplicacion.AutoSize = True
        Me.lblexplicacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblexplicacion.Location = New System.Drawing.Point(25, 20)
        Me.lblexplicacion.Name = "lblexplicacion"
        Me.lblexplicacion.Size = New System.Drawing.Size(578, 145)
        Me.lblexplicacion.TabIndex = 5
        Me.lblexplicacion.Text = "                                 saludos" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "A continuacion ingrese la contraseñ" & _
            "a que desea " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "para el Odontologo"
        '
        'ingreso_contraseña
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(615, 664)
        Me.Controls.Add(Me.lblexplicacion)
        Me.Controls.Add(Me.lblrepcontraseña)
        Me.Controls.Add(Me.lblcontraseña)
        Me.Controls.Add(Me.txtrepcontraseña)
        Me.Controls.Add(Me.txtcontraseña)
        Me.Controls.Add(Me.btnguardar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ingreso_contraseña"
        Me.Text = "ingreso_contraseña"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnguardar As System.Windows.Forms.Button
    Friend WithEvents txtcontraseña As System.Windows.Forms.TextBox
    Friend WithEvents txtrepcontraseña As System.Windows.Forms.TextBox
    Friend WithEvents lblcontraseña As System.Windows.Forms.Label
    Friend WithEvents lblrepcontraseña As System.Windows.Forms.Label
    Friend WithEvents lblexplicacion As System.Windows.Forms.Label
End Class
