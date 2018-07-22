Public Class realizar_pago
    Dim id As Integer
    Private Sub realizar_pago_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Consulta = "select id_p , nombre , cedula , saldo from paciente"
        consultar()
        DataGridView1.DataSource = Tabla
        DataGridView1.ClearSelection()
        DataGridView1.Columns(0).Visible = False
        Label2.Text = id
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        id = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(0).Value
    End Sub
End Class