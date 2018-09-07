<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class graficas
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.grafica = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.btngraficar = New System.Windows.Forms.Button()
        Me.btnprompacientes = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btningresos = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.grafica, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grafica
        '
        ChartArea1.Name = "ChartArea1"
        Me.grafica.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.grafica.Legends.Add(Legend1)
        Me.grafica.Location = New System.Drawing.Point(12, 100)
        Me.grafica.Name = "grafica"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.grafica.Series.Add(Series1)
        Me.grafica.Size = New System.Drawing.Size(575, 402)
        Me.grafica.TabIndex = 0
        Me.grafica.Text = "Chart1"
        '
        'btngraficar
        '
        Me.btngraficar.Location = New System.Drawing.Point(599, 459)
        Me.btngraficar.Name = "btngraficar"
        Me.btngraficar.Size = New System.Drawing.Size(166, 55)
        Me.btngraficar.TabIndex = 1
        Me.btngraficar.Text = "Graficar"
        Me.btngraficar.UseVisualStyleBackColor = True
        '
        'btnprompacientes
        '
        Me.btnprompacientes.Location = New System.Drawing.Point(599, 340)
        Me.btnprompacientes.Name = "btnprompacientes"
        Me.btnprompacientes.Size = New System.Drawing.Size(127, 35)
        Me.btnprompacientes.TabIndex = 2
        Me.btnprompacientes.Text = "promedio edades pacientes"
        Me.btnprompacientes.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(596, 277)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(188, 36)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "seleccione informacion " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "para visualizar?"
        '
        'btningresos
        '
        Me.btningresos.Location = New System.Drawing.Point(599, 391)
        Me.btningresos.Name = "btningresos"
        Me.btningresos.Size = New System.Drawing.Size(127, 35)
        Me.btningresos.TabIndex = 4
        Me.btningresos.Text = "ingresos"
        Me.btningresos.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(743, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(41, 40)
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'graficas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(796, 526)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btningresos)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnprompacientes)
        Me.Controls.Add(Me.btngraficar)
        Me.Controls.Add(Me.grafica)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "graficas"
        Me.Text = "."
        CType(Me.grafica, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grafica As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents btngraficar As System.Windows.Forms.Button
    Friend WithEvents btnprompacientes As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btningresos As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
