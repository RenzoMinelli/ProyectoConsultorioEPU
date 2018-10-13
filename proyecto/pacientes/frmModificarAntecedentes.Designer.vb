<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmModificarAntecedentes
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
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.txbObservaciones = New System.Windows.Forms.TextBox()
        Me.lblObservaciones = New System.Windows.Forms.Label()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.chbxAlergicos = New System.Windows.Forms.CheckBox()
        Me.chbxDiabeticos = New System.Windows.Forms.CheckBox()
        Me.chbxCardiovasculares = New System.Windows.Forms.CheckBox()
        Me.chbxFiebreReumatica = New System.Windows.Forms.CheckBox()
        Me.chbxCoagulacion = New System.Windows.Forms.CheckBox()
        Me.chbxOdontologicos = New System.Windows.Forms.CheckBox()
        Me.chbxFarmacosRecibidos = New System.Windows.Forms.CheckBox()
        Me.chbxFamiliares = New System.Windows.Forms.CheckBox()
        Me.chbxTratamientosMedicos = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'btnCancelar
        '
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Image = Global.WindowsApplication1.My.Resources.Resources.X
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(412, 462)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(148, 62)
        Me.btnCancelar.TabIndex = 23
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'txbObservaciones
        '
        Me.txbObservaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbObservaciones.Location = New System.Drawing.Point(384, 115)
        Me.txbObservaciones.Multiline = True
        Me.txbObservaciones.Name = "txbObservaciones"
        Me.txbObservaciones.Size = New System.Drawing.Size(580, 172)
        Me.txbObservaciones.TabIndex = 22
        '
        'lblObservaciones
        '
        Me.lblObservaciones.AutoSize = True
        Me.lblObservaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblObservaciones.Location = New System.Drawing.Point(380, 77)
        Me.lblObservaciones.Name = "lblObservaciones"
        Me.lblObservaciones.Size = New System.Drawing.Size(181, 29)
        Me.lblObservaciones.TabIndex = 21
        Me.lblObservaciones.Text = "Observaciones:"
        '
        'btnGuardar
        '
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Image = Global.WindowsApplication1.My.Resources.Resources.checkmark
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardar.Location = New System.Drawing.Point(795, 462)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(139, 62)
        Me.btnGuardar.TabIndex = 24
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'chbxAlergicos
        '
        Me.chbxAlergicos.AutoSize = True
        Me.chbxAlergicos.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbxAlergicos.Location = New System.Drawing.Point(77, 73)
        Me.chbxAlergicos.Name = "chbxAlergicos"
        Me.chbxAlergicos.Size = New System.Drawing.Size(133, 33)
        Me.chbxAlergicos.TabIndex = 12
        Me.chbxAlergicos.Text = "Alérgicos"
        Me.chbxAlergicos.UseVisualStyleBackColor = True
        '
        'chbxDiabeticos
        '
        Me.chbxDiabeticos.AutoSize = True
        Me.chbxDiabeticos.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbxDiabeticos.Location = New System.Drawing.Point(77, 124)
        Me.chbxDiabeticos.Name = "chbxDiabeticos"
        Me.chbxDiabeticos.Size = New System.Drawing.Size(146, 33)
        Me.chbxDiabeticos.TabIndex = 13
        Me.chbxDiabeticos.Text = "Diabéticos"
        Me.chbxDiabeticos.UseVisualStyleBackColor = True
        '
        'chbxCardiovasculares
        '
        Me.chbxCardiovasculares.AutoSize = True
        Me.chbxCardiovasculares.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbxCardiovasculares.Location = New System.Drawing.Point(77, 175)
        Me.chbxCardiovasculares.Name = "chbxCardiovasculares"
        Me.chbxCardiovasculares.Size = New System.Drawing.Size(218, 33)
        Me.chbxCardiovasculares.TabIndex = 14
        Me.chbxCardiovasculares.Text = "Cardiovasculares"
        Me.chbxCardiovasculares.UseVisualStyleBackColor = True
        '
        'chbxFiebreReumatica
        '
        Me.chbxFiebreReumatica.AutoSize = True
        Me.chbxFiebreReumatica.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbxFiebreReumatica.Location = New System.Drawing.Point(77, 226)
        Me.chbxFiebreReumatica.Name = "chbxFiebreReumatica"
        Me.chbxFiebreReumatica.Size = New System.Drawing.Size(223, 33)
        Me.chbxFiebreReumatica.TabIndex = 15
        Me.chbxFiebreReumatica.Text = "Fiebre Reumática"
        Me.chbxFiebreReumatica.UseVisualStyleBackColor = True
        '
        'chbxCoagulacion
        '
        Me.chbxCoagulacion.AutoSize = True
        Me.chbxCoagulacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbxCoagulacion.Location = New System.Drawing.Point(77, 278)
        Me.chbxCoagulacion.Name = "chbxCoagulacion"
        Me.chbxCoagulacion.Size = New System.Drawing.Size(167, 33)
        Me.chbxCoagulacion.TabIndex = 16
        Me.chbxCoagulacion.Text = "Coagulación"
        Me.chbxCoagulacion.UseVisualStyleBackColor = True
        '
        'chbxOdontologicos
        '
        Me.chbxOdontologicos.AutoSize = True
        Me.chbxOdontologicos.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbxOdontologicos.Location = New System.Drawing.Point(77, 329)
        Me.chbxOdontologicos.Name = "chbxOdontologicos"
        Me.chbxOdontologicos.Size = New System.Drawing.Size(190, 33)
        Me.chbxOdontologicos.TabIndex = 17
        Me.chbxOdontologicos.Text = "Odontológicos"
        Me.chbxOdontologicos.UseVisualStyleBackColor = True
        '
        'chbxFarmacosRecibidos
        '
        Me.chbxFarmacosRecibidos.AutoSize = True
        Me.chbxFarmacosRecibidos.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbxFarmacosRecibidos.Location = New System.Drawing.Point(77, 376)
        Me.chbxFarmacosRecibidos.Name = "chbxFarmacosRecibidos"
        Me.chbxFarmacosRecibidos.Size = New System.Drawing.Size(254, 33)
        Me.chbxFarmacosRecibidos.TabIndex = 18
        Me.chbxFarmacosRecibidos.Text = "Fármacos Recibidos"
        Me.chbxFarmacosRecibidos.UseVisualStyleBackColor = True
        '
        'chbxFamiliares
        '
        Me.chbxFamiliares.AutoSize = True
        Me.chbxFamiliares.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbxFamiliares.Location = New System.Drawing.Point(77, 429)
        Me.chbxFamiliares.Name = "chbxFamiliares"
        Me.chbxFamiliares.Size = New System.Drawing.Size(145, 33)
        Me.chbxFamiliares.TabIndex = 19
        Me.chbxFamiliares.Text = "Familiares"
        Me.chbxFamiliares.UseVisualStyleBackColor = True
        '
        'chbxTratamientosMedicos
        '
        Me.chbxTratamientosMedicos.AutoSize = True
        Me.chbxTratamientosMedicos.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbxTratamientosMedicos.Location = New System.Drawing.Point(77, 480)
        Me.chbxTratamientosMedicos.Name = "chbxTratamientosMedicos"
        Me.chbxTratamientosMedicos.Size = New System.Drawing.Size(271, 33)
        Me.chbxTratamientosMedicos.TabIndex = 20
        Me.chbxTratamientosMedicos.Text = "Tratamientos Médicos"
        Me.chbxTratamientosMedicos.UseVisualStyleBackColor = True
        '
        'frmModificarAntecedentes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1179, 684)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.txbObservaciones)
        Me.Controls.Add(Me.lblObservaciones)
        Me.Controls.Add(Me.chbxTratamientosMedicos)
        Me.Controls.Add(Me.chbxFamiliares)
        Me.Controls.Add(Me.chbxFarmacosRecibidos)
        Me.Controls.Add(Me.chbxOdontologicos)
        Me.Controls.Add(Me.chbxCoagulacion)
        Me.Controls.Add(Me.chbxFiebreReumatica)
        Me.Controls.Add(Me.chbxCardiovasculares)
        Me.Controls.Add(Me.chbxDiabeticos)
        Me.Controls.Add(Me.chbxAlergicos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmModificarAntecedentes"
        Me.Text = "Modificar_Antecedentes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents txbObservaciones As System.Windows.Forms.TextBox
    Friend WithEvents lblObservaciones As System.Windows.Forms.Label
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents chbxAlergicos As System.Windows.Forms.CheckBox
    Friend WithEvents chbxDiabeticos As System.Windows.Forms.CheckBox
    Friend WithEvents chbxCardiovasculares As System.Windows.Forms.CheckBox
    Friend WithEvents chbxFiebreReumatica As System.Windows.Forms.CheckBox
    Friend WithEvents chbxCoagulacion As System.Windows.Forms.CheckBox
    Friend WithEvents chbxOdontologicos As System.Windows.Forms.CheckBox
    Friend WithEvents chbxFarmacosRecibidos As System.Windows.Forms.CheckBox
    Friend WithEvents chbxFamiliares As System.Windows.Forms.CheckBox
    Friend WithEvents chbxTratamientosMedicos As System.Windows.Forms.CheckBox
End Class
