Public Class realizar_pago

    Private Sub realizar_pago_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Consulta = "select id_p , nombre , cedula , saldo from paciente"
        consultar()
        DataGridView1.DataSource = Tabla
    End Sub
End Class