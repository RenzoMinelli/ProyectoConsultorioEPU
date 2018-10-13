Public Class MsgBoxVersatil
    Public respuestaInt As Integer = 0
    Public respuestaString As String
 

    Private Sub MsgBoxVersatil_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Location = New Point(screenWidth / 2 - Me.Width / 2, screenHeight / 2 - Me.Height / 2)
        If lblTexto.Text.Length > 50 Then

            Dim parte1 As String = ""
            Dim parte2 As String = ""

            For x = 50 To lblTexto.Text.Length - 1

                While lblTexto.Text(x) <> " "
                    x += 1
                End While

                parte1 = lblTexto.Text.Substring(0, x)
                parte2 = lblTexto.Text.Substring(x, lblTexto.Text.Length - x)

                lblTexto.Text = parte1 + vbNewLine + parte2

                Exit For

            Next

        End If

    End Sub

    
    Private Sub txbRespuesta_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txbRespuesta.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnSi.PerformClick()
        End If
    End Sub

    Private Sub btnNo_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNo.Click
        respuestaString = txbRespuesta.Text
        respuestaInt = 2
        DialogResult = System.Windows.Forms.DialogResult.OK
    End Sub

    Private Sub btnSi_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSi.Click
        respuestaInt = 1

        respuestaString = txbRespuesta.Text

        DialogResult = System.Windows.Forms.DialogResult.OK
    End Sub

   
End Class