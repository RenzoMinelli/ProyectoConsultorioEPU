Public Class inputboxcasero
    Dim id As Integer = realizar_pago.DataGridView1.Rows(realizar_pago.DataGridView1.CurrentRow.Index).Cells(0).Value
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim monto As String = TextBox1.Text



        Consulta = "update paciente set saldo = '" & monto & "' where id_p = '" & Str(id) & ";"
        consultar()

        Consulta = "select id_p , nombre , cedula , saldo from paciente"
        consultar()
        realizar_pago.DataGridView1.DataSource = Tabla
        realizar_pago.DataGridView1.ClearSelection()
        realizar_pago.DataGridView1.Columns(0).Visible = False

    End Sub
End Class