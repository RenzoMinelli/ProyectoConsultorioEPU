Public Class frmIngresoContraseña
    Dim contraseña As String
    Dim repcontraseña As String
    Dim contador As Integer = 0

    Private Sub btnguardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnguardar.Click
        If txtcontraseña.Text <> "" And txtrepcontraseña.Text <> "" Then

            contraseña = txtcontraseña.Text
            repcontraseña = txtrepcontraseña.Text
            txtcontraseña.Text = ""
            txtrepcontraseña.Text = ""

            If contador = 0 And contraseña = repcontraseña Then
                Try
                    Consulta = "update usuarios SET contrasenia = '" + contraseña + "' where usuario = 'odo';"
                    consultar()

                    contador = contador + 1
                    lblhack.Text = "Funcionario"

                Catch ex As Exception
                    MsgBox("Error al guardar contraseña", MsgBoxStyle.Exclamation)
                End Try


            ElseIf contador = 1 And contraseña = repcontraseña Then

                Try
                    Consulta = "update usuarios SET contrasenia = '" + contraseña + "' where usuario = 'fun';"
                    consultar()

                    MsgBox("Contraseñas Registradas", MsgBoxStyle.Information)

                    Me.Dispose()
                    frmLogin.Show()
                Catch ex As Exception
                    MsgBox("Error al guardar contraseña", MsgBoxStyle.Exclamation)
                End Try

            Else
                MsgBox("Vuelva a ingresar, las contraseñas no coinciden", MsgBoxStyle.Exclamation)
            End If
        End If

    End Sub
End Class