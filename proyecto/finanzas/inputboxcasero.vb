﻿Public Class inputboxcasero

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim monto As String = TextBox1.Text


        If TextBox1.Text <> "" And IsNumeric(TextBox1.Text) Then

            MuestraMsgBoxVersatil("¿Confirma que el paciente depositó $" + monto + " ?", 0)
            If respint = 2 Then
                MsgBox("Ningún cambio fue realizado", MsgBoxStyle.Information)

            Else
                Consulta = "update paciente set saldo = saldo- '" & monto & "' where id_p = '" & Str(frmRealizarPago.id) & "';"
                consultar()


                Dim fecha As Date = Now.ToShortDateString
                Dim nfecha = fecha.ToString("yyyy-MM-dd")

                Consulta = "insert into recibo (fecha, pago, id_p) values ('" + nfecha + "', '" + monto + "', '" + Str(frmRealizarPago.id) + "');"

                consultar()
                MsgBox("Pago realizado con éxito", MsgBoxStyle.Information)
                frmRealizarPago.actTabla()
                frmFinanzas.actTabla()
                Me.Dispose()
            End If
        Else
            MsgBox("Ingrese un numero por favor", MsgBoxStyle.Exclamation)
            TextBox1.Text = ""
        End If

    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Dispose()
    End Sub
End Class