Public Class MsgBoxVersatil
    Public respuesta As Integer = 0
    Private Sub btnSi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSi.Click
        respuesta = 1
        DialogResult = System.Windows.Forms.DialogResult.OK
    End Sub

    Private Sub btnNo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNo.Click
        respuesta = 2
        DialogResult = System.Windows.Forms.DialogResult.OK
    End Sub

    Private Sub MsgBoxVersatil_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If lblTexto.Text.Length > 45 Then

            Dim parte1 As String = ""
            Dim parte2 As String = ""

            For x = 45 To lblTexto.Text.Length - 1

                If lblTexto.Text(x) = " " Then

                    parte1 = lblTexto.Text.Substring(0, x)
                    parte2 = lblTexto.Text.Substring(x, lblTexto.Text.Length - x)

                    lblTexto.Text = parte1 + vbNewLine + parte2

                    Exit For

                End If

            Next




        End If
    End Sub
End Class