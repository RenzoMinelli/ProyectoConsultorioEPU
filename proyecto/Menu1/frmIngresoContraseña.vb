Public Class frmIngresoContraseña
    Dim contraseña As String
    Dim repcontraseña As String
    Dim contador As Integer = 0
    Dim mover As Boolean

    Private Sub btnguardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnguardar.Click
        If txtcontraseña.Text <> "" And txtrepcontraseña.Text <> "" Then

            contraseña = txtcontraseña.Text
            repcontraseña = txtrepcontraseña.Text
            txtcontraseña.Text = ""
            txtrepcontraseña.Text = ""

            If contador = 0 And contraseña = repcontraseña Then
                Try
                    Consulta = "update usuarios SET contrasenia = sha2('" + contraseña + "',256) where usuario = 'odo';"
                    consultar()

                    contador = contador + 1
                    lblhack.Text = "Funcionario"

                Catch ex As Exception
                    MsgBox("Error al guardar contraseña", MsgBoxStyle.Exclamation)
                End Try


            ElseIf contador = 1 And contraseña = repcontraseña Then

                Try
                    Consulta = "update usuarios SET contrasenia = sha2('" + contraseña + "',256) where usuario = 'fun';"
                    consultar()

                    MsgBox("Contraseñas Registradas", MsgBoxStyle.Information)

                    Me.Dispose()
                    frmLogin.Show()
                    xf = frmLogin.Location.X
                    yf = frmLogin.Location.Y
                Catch ex As Exception
                    MsgBox("Error al guardar contraseña", MsgBoxStyle.Exclamation)
                End Try

            Else
                MsgBox("Vuelva a ingresar, las contraseñas no coinciden", MsgBoxStyle.Exclamation)
            End If
        End If

    End Sub

    Private Sub pbCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbCerrar.Click
        frmLogin.Dispose()

    End Sub

    Private Sub lblexplicacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblexplicacion.Click

    End Sub

    Private Sub frmIngresoContraseña_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        xf = Me.Location.X
        yf = Me.Location.Y
    End Sub
    Private Sub pnlBarra_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnlBarra.MouseDown
        mover = True

    End Sub


    Private Sub pnlBarra_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnlBarra.MouseMove

        If mover = True Then
            xc = Cursor.Position.X
            yc = Cursor.Position.Y

            Dim holax, holay As Integer

            holax = xc - xco
            holay = yc - yco

            Me.Location = New Point(xf + holax, yf + holay)
        Else
            xco = Cursor.Position.X
            yco = Cursor.Position.Y
        End If


    End Sub

    Private Sub pnlBarra_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnlBarra.MouseUp
        xf = Me.Location.X
        yf = Me.Location.Y
        mover = False
    End Sub
End Class