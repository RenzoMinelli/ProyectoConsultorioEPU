﻿Public Class inputboxcasero

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim monto As String = TextBox1.Text


        If TextBox1.Text <> "" And IsNumeric(TextBox1.Text) Then


            Consulta = "update paciente set saldo = saldo- '" & monto & "' where id_p = '" & Str(frmRealizarPago.id) & "';"
            consultar()

            frmRealizarPago.actTabla()
            frmFinanzas.actTabla()
            Dim fecha As Date = Now.ToShortDateString
            Dim nfecha = fecha.ToString("yyyy-MM-dd")

            Consulta = "insert into recibo (fecha, pago, id_p) values ('" + nfecha + "', '" + monto + "', '" + Str(frmRealizarPago.id) + "');"

            consultar()

            Me.Dispose()

        Else
            MsgBox("Ingrese un numero por favor", MsgBoxStyle.Exclamation)
            TextBox1.Text = ""
        End If

    End Sub



    Private Sub inputboxcasero_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class