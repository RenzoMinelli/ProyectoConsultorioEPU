<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInputPago
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
        Me.lblDatosPaciente = New System.Windows.Forms.Label()
        Me.txbMonto = New System.Windows.Forms.TextBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnContinuar = New System.Windows.Forms.Button()
        Me.lblIngreseMonto = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblDatosPaciente
        '
        Me.lblDatosPaciente.AutoSize = True
        Me.lblDatosPaciente.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDatosPaciente.Location = New System.Drawing.Point(173, 68)
        Me.lblDatosPaciente.Name = "lblDatosPaciente"
        Me.lblDatosPaciente.Size = New System.Drawing.Size(195, 29)
        Me.lblDatosPaciente.TabIndex = 0
        Me.lblDatosPaciente.Text = "lblDatosPaciente"
        '
        'txbMonto
        '
        Me.txbMonto.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbMonto.Location = New System.Drawing.Point(430, 194)
        Me.txbMonto.Name = "txbMonto"
        Me.txbMonto.Size = New System.Drawing.Size(311, 35)
        Me.txbMonto.TabIndex = 1
        '
        'btnCancelar
        '
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Location = New System.Drawing.Point(178, 411)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(118, 62)
        Me.btnCancelar.TabIndex = 2
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnContinuar
        '
        Me.btnContinuar.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnContinuar.Location = New System.Drawing.Point(686, 411)
        Me.btnContinuar.Name = "btnContinuar"
        Me.btnContinuar.Size = New System.Drawing.Size(133, 62)
        Me.btnContinuar.TabIndex = 3
        Me.btnContinuar.Text = "Continuar"
        Me.btnContinuar.UseVisualStyleBackColor = True
        '
        'lblIngreseMonto
        '
        Me.lblIngreseMonto.AutoSize = True
        Me.lblIngreseMonto.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIngreseMonto.Location = New System.Drawing.Point(173, 197)
        Me.lblIngreseMonto.Name = "lblIngreseMonto"
        Me.lblIngreseMonto.Size = New System.Drawing.Size(251, 29)
        Me.lblIngreseMonto.TabIndex = 4
        Me.lblIngreseMonto.Text = "Ingrese el Monto en $:"
        '
        'frmInputPago
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1179, 684)
        Me.Controls.Add(Me.lblIngreseMonto)
        Me.Controls.Add(Me.btnContinuar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.txbMonto)
        Me.Controls.Add(Me.lblDatosPaciente)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmInputPago"
        Me.Text = "InputPago"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblDatosPaciente As System.Windows.Forms.Label
    Friend WithEvents txbMonto As System.Windows.Forms.TextBox
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnContinuar As System.Windows.Forms.Button
    Friend WithEvents lblIngreseMonto As System.Windows.Forms.Label
End Class
