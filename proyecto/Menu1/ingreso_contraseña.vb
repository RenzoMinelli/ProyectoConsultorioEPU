Public Class ingreso_contraseña
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
                Consulta = "update usuarios SET contrasenia = '" + contraseña + "' where usuario = 'odo';"
                consultar()
                contador = contador + 1
                lblhack.Text = "Funcionario"
            ElseIf contador = 1 And contraseña = repcontraseña Then
                Consulta = "update usuarios SET contrasenia = '" + contraseña + "' where usuario = 'fun';"
                consultar()
                MsgBox("Contraseñas Registradas")
                Me.Dispose()
                Login.Show()
            Else
                MsgBox("vuelva a ingresar, las contraseñas no coinciden")
            End If
        End If

    End Sub
End Class