Public Class realizar_pago
    Public id As Integer
    Private Sub realizar_pago_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        actTabla()
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        id = DataGridView1.CurrentRow.Cells(0).Value
        Button1.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        inputboxcasero.Show()
        
       

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Dispose()
        finanzas.Show()
        Consulta = "select fecha as 'Fecha de Pago', pago as 'Cantidad Depositada ($)'  ,cedula as 'Cedula', nombre as 'Nombre' from recibo r inner join paciente p on p.id_p = r.id_p where fecha <= '" + finanzas.fechah.ToString("yyyy-MM-dd") + "' and fecha >= '" + finanzas.fechad.ToString("yyyy-MM-dd") + "';"
        consultar()

        finanzas.DataGridView1.DataSource = Tabla
    End Sub
    Public Sub actTabla()
        Consulta = "select id_p , nombre , cedula , saldo from paciente;"
        consultar()
        DataGridView1.DataSource = Tabla
        DataGridView1.ClearSelection()
        DataGridView1.Columns(0).Visible = False
        Button1.Hide()
        DataGridView1.Columns(0).Width = 300

        DataGridView1.Columns(1).Width = 300

        DataGridView1.Columns(2).Width = 310

        DataGridView1.Columns(3).Width = 310

        DataGridView1.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 15)
    End Sub
End Class