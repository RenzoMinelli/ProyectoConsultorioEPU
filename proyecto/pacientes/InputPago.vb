Public Class InputPago


    Private Sub InputPago_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label1.Text = "El salgo pendiente del paciente " + nombre + " es de $" + saldo.ToString + vbNewLine + "¿Cuánto depositará?"
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim pago As String = ""
        Do
            pago = TextBox1.Text
            If Not IsNumeric(pago) Then
                If pago = "" Then
                    MsgBox("Acción cancelada", MsgBoxStyle.Information)
                    pago = "cancel"
                Else
                    MsgBox("Ingrese un número", MsgBoxStyle.Exclamation)
                    pago = "g"
                End If

            End If
        Loop While pago = "g"

        If Not pago = "cancel" Then
            If MsgBox("¿Confirma que el paciente " + nombre + " depositó $" + pago + "?", MsgBoxStyle.YesNo) = vbYes Then
                saldo -= pago
                Try
                    Consulta = "update paciente set saldo = '" + saldo.ToString + "' where id_p = '" + id_p.ToString + "';"
                    consultar()

                    Dim fecha As Date = Now.ToShortDateString
                    Dim nfecha = fecha.ToString("yyyy-MM-dd")

                    Consulta = "insert into recibo (fecha, pago, id_p) values ('" + nfecha + "', '" + pago.ToString + "', '" + id_p.ToString + "');"

                    consultar()

                    MsgBox("Información actualizada", MsgBoxStyle.Information)

                    Pacientes.actTabla()
                    Pacientes.actPanel()
                    Me.Dispose()
                    Pacientes.Show()
                Catch ex As Exception
                    MsgBox("Error")
                End Try


            Else
                MsgBox("Acción cancelada", MsgBoxStyle.Information)
            End If
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Dispose()
        Pacientes.Show()
    End Sub
End Class