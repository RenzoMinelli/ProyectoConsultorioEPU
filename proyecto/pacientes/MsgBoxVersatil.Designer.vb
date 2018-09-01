<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MsgBoxVersatil
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
        Me.lblTexto = New System.Windows.Forms.Label()
        Me.btnSi = New System.Windows.Forms.Button()
        Me.btnNo = New System.Windows.Forms.Button()
        Me.txbRespuesta = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblTexto
        '
        Me.lblTexto.AutoSize = True
        Me.lblTexto.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTexto.Location = New System.Drawing.Point(29, 38)
        Me.lblTexto.Name = "lblTexto"
        Me.lblTexto.Size = New System.Drawing.Size(185, 29)
        Me.lblTexto.TabIndex = 0
        Me.lblTexto.Text = "Texto a cambiar"
        '
        'btnSi
        '
        Me.btnSi.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSi.Location = New System.Drawing.Point(23, 222)
        Me.btnSi.Name = "btnSi"
        Me.btnSi.Size = New System.Drawing.Size(111, 52)
        Me.btnSi.TabIndex = 1
        Me.btnSi.Text = "Sí"
        Me.btnSi.UseVisualStyleBackColor = True
        '
        'btnNo
        '
        Me.btnNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNo.Location = New System.Drawing.Point(500, 222)
        Me.btnNo.Name = "btnNo"
        Me.btnNo.Size = New System.Drawing.Size(111, 52)
        Me.btnNo.TabIndex = 2
        Me.btnNo.Text = "No"
        Me.btnNo.UseVisualStyleBackColor = True
        '
        'txbRespuesta
        '
        Me.txbRespuesta.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbRespuesta.Location = New System.Drawing.Point(119, 154)
        Me.txbRespuesta.Name = "txbRespuesta"
        Me.txbRespuesta.Size = New System.Drawing.Size(372, 35)
        Me.txbRespuesta.TabIndex = 0
        Me.txbRespuesta.WordWrap = False
        '
        'MsgBoxVersatil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(650, 299)
        Me.Controls.Add(Me.txbRespuesta)
        Me.Controls.Add(Me.btnNo)
        Me.Controls.Add(Me.btnSi)
        Me.Controls.Add(Me.lblTexto)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MsgBoxVersatil"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "MsgVersatil"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTexto As System.Windows.Forms.Label
    Friend WithEvents btnSi As System.Windows.Forms.Button
    Friend WithEvents btnNo As System.Windows.Forms.Button
    Friend WithEvents txbRespuesta As System.Windows.Forms.TextBox
End Class
