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
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.grafica = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.btnprompacientes = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btningresos = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgbinfo = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.grafica, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgbinfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grafica
        '
        ChartArea2.Name = "ChartArea1"
        Me.grafica.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.grafica.Legends.Add(Legend2)
        Me.grafica.Location = New System.Drawing.Point(12, 100)
        Me.grafica.Name = "grafica"
        Series2.ChartArea = "ChartArea1"
        Series2.Legend = "Legend1"
        Series2.Name = "Series1"
        Me.grafica.Series.Add(Series2)
        Me.grafica.Size = New System.Drawing.Size(753, 414)
        Me.grafica.TabIndex = 0
        Me.grafica.Text = "Chart1"
        '
        'btnprompacientes
        '
        Me.btnprompacientes.Location = New System.Drawing.Point(255, 12)
        Me.btnprompacientes.Name = "btnprompacientes"
        Me.btnprompacientes.Size = New System.Drawing.Size(115, 35)
        Me.btnprompacientes.TabIndex = 2
        Me.btnprompacientes.Text = "promedio edades pacientes"
        Me.btnprompacientes.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(41, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(188, 36)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "seleccione informacion " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "para visualizar?"
        '
        'btningresos
        '
        Me.btningresos.Location = New System.Drawing.Point(389, 12)
        Me.btningresos.Name = "btningresos"
        Me.btningresos.Size = New System.Drawing.Size(114, 35)
        Me.btningresos.TabIndex = 4
        Me.btningresos.Text = "ingresos"
        Me.btningresos.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(12, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(497, 18)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "los datos mostrados son los promedios de edades de pacientes:"
        '
        'dgbinfo
        '
        Me.dgbinfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgbinfo.Location = New System.Drawing.Point(0, 1)
        Me.dgbinfo.Name = "dgbinfo"
        Me.dgbinfo.Size = New System.Drawing.Size(10, 10)
        Me.dgbinfo.TabIndex = 6
        Me.dgbinfo.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(623, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Label3"
        '
        'graficas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(796, 526)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dgbinfo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btningresos)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnprompacientes)
        Me.Controls.Add(Me.grafica)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "graficas"
        Me.Text = "."
        CType(Me.grafica, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgbinfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grafica As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents btnprompacientes As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btningresos As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dgbinfo As System.Windows.Forms.DataGridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
