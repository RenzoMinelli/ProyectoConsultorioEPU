Public Class inputboxcasero

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim monto As String = TextBox1.Text



        Consulta = "update paciente set saldo = saldo- '" & monto & "' where id_p = '" & Str(realizar_pago.id) & "';"
        consultar()

        realizar_pago.actTabla()
        finanzas.actTabla()
        Dim fecha As Date = Now.ToShortDateString
        Dim nfecha = fecha.ToString("yyyy-MM-dd")

        Consulta = "insert into recibo (fecha, pago, id_p) values ('" + nfecha + "', '" + monto + "', '" + Str(realizar_pago.id) + "');"

        consultar()

        Me.Dispose()

    End Sub

    Private Sub inputboxcasero_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class