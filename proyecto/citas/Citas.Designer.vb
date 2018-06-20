<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Citas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Citas))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.AxCalendar1 = New AxCALENDARLib.AxCalendar()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        CType(Me.AxCalendar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'AxCalendar1
        '
        Me.AxCalendar1.Enabled = True
        Me.AxCalendar1.Location = New System.Drawing.Point(36, 65)
        Me.AxCalendar1.Name = "AxCalendar1"
        Me.AxCalendar1.OcxState = CType(resources.GetObject("AxCalendar1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxCalendar1.Size = New System.Drawing.Size(534, 348)
        Me.AxCalendar1.TabIndex = 34
        '
        'Citas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(889, 635)
        Me.Controls.Add(Me.AxCalendar1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Citas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Citas"
        CType(Me.AxCalendar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents AxCalendar1 As AxCALENDARLib.AxCalendar
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
End Class
