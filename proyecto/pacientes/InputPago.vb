Public Class InputPago


    Private Sub InputPago_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblDatosPaciente.Text = "El saldo pendiente del paciente " + Pacientes.nombre + " es de $" + Pacientes.saldo.ToString + vbNewLine + "¿Cuánto depositará?"
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnContinuar.Click
        Dim pago As String = txbMonto.Text

        If Not IsNumeric(pago) Then

            MsgBox("Ingrese un número", MsgBoxStyle.Exclamation)
        Else
            If MsgBox("¿Confirma que el paciente " + Pacientes.nombre + " depositó $" + pago + "?", MsgBoxStyle.YesNo) = vbYes Then
                Pacientes.saldo -= pago
                Try
                    Consulta = "update paciente set saldo = '" + Pacientes.saldo.ToString + "' where id_p = '" + id_p.ToString + "';"
                    consultar()

                    Dim fecha As Date = Now.ToShortDateString
                    Dim nfecha = fecha.ToString("yyyy-MM-dd")

                    Consulta = "insert into recibo (fecha, pago, id_p) values ('" + nfecha + "', '" + pago.ToString + "', '" + id_p.ToString + "');"

                    consultar()

                    MsgBox("Información actualizada", MsgBoxStyle.Information)

                    Pacientes.actTabla(1)
                    Pacientes.actPanel()
                    Me.Dispose()
                    Pacientes.Show()
                Catch ex As Exception
                    MsgBox("Error")
                End Try
            End If

        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Dispose()
        Pacientes.Show()
    End Sub
End Class