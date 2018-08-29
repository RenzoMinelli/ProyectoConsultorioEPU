Public Class ingreso_contraseña
    Dim contraseña As String
    Dim repcontraseña As String
    Dim contador As Integer = 0

    Private Sub btnguardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnguardar.Click
        If contador = 0 Then
            contador = contador + 1
        End If

        contraseña = txtcontraseña.Text
        repcontraseña = txtrepcontraseña.Text
        txtcontraseña.Text = ""
        txtrepcontraseña.Text = ""
        If contador = 1 And contraseña = repcontraseña Then
            Consulta = "update usuarios SET contraseña =" + contraseña + "where usuario = 'odontologo'"
            consultar()
            contador = contador + 1
        ElseIf contador = 2 And contraseña = repcontraseña Then
            Consulta = "update usuarios SET contraseña =" + contraseña + "where usuario = 'funcionario'"
            consultar()
            btnguardar.Text = "Finalizar"
            contador = contador + 1
        ElseIf contador = 3 Then
            Me.Hide()
            Login.Show()
        Else
            MsgBox("vuelva a ingresar, las contraseñas no coinciden")
        End If


    End Sub
End Class