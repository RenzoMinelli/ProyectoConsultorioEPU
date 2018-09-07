Public Class frmInputPago


    Private Sub InputPago_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblDatosPaciente.Text = "El saldo pendiente del paciente " + frmPacientes.nombre + " es de $" + frmPacientes.saldo.ToString + vbNewLine + "¿Cuánto depositará?"
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnContinuar.Click
        Dim pago As String = txbMonto.Text

        If Not IsNumeric(pago) Then

            MsgBox("Ingrese un número", MsgBoxStyle.Exclamation)
        Else
            If MsgBox("¿Confirma que el paciente " + frmPacientes.nombre + " depositó $" + pago + "?", MsgBoxStyle.YesNo) = vbYes Then
                frmPacientes.saldo -= pago
                Try
                    Consulta = "update paciente set saldo = '" + frmPacientes.saldo.ToString + "' where id_p = '" + id_p.ToString + "';"
                    consultar()

                    Dim fecha As Date = Now.ToShortDateString
                    Dim nfecha = fecha.ToString("yyyy-MM-dd")

                    Consulta = "insert into recibo (fecha, pago, id_p) values ('" + nfecha + "', '" + pago.ToString + "', '" + id_p.ToString + "');"

                    consultar()

                    MsgBox("Información actualizada", MsgBoxStyle.Information)

                    frmPacientes.actTabla(1)
                    frmPacientes.actPanel()
                    Me.Dispose()
                    frmPacientes.Show()
                Catch ex As Exception
                    MsgBox("Error")
                End Try
            End If

        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Dispose()
        frmPacientes.Show()
    End Sub
End Class