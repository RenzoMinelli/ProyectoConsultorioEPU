Public Class frmLogin
    Dim contador As Integer = 0
    Dim contraseña As String
    Dim contraseñau As String

    Dim mover As Boolean
    

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnodontologo.Click
        contador = 1
        Try
            Consulta = "select contrasenia from usuarios where usuario = 'odo';"
            consultar()
            dgbcontraseña.DataSource = Tabla

            contraseña = dgbcontraseña.Rows(0).Cells(0).Value

        Catch ex As Exception
            contraseña = ""
        End Try

        If contraseña = Nothing Then
            Me.Hide()
            frmIngresoContraseña.Show()
            btningresar.Visible = False

            txtcontraseña.Visible = False
            btnfuncionario.Visible = True
            btnodontologo.Visible = True
        Else
            lblingrusuario.Text = "Ingrese Contraseña"
            btningresar.Visible = True
            btnAtras.Visible = True
            txtcontraseña.Visible = True
            btnfuncionario.Visible = False
            btnodontologo.Visible = False
        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfuncionario.Click
        contador = 2

        btningresar.Visible = True
        btnAtras.Visible = True

        txtcontraseña.Visible = True
        btnfuncionario.Visible = False
        btnodontologo.Visible = False
        Try
            Consulta = "select contrasenia from usuarios where usuario = 'fun';"
            consultar()
            dgbcontraseña.DataSource = Tabla
            contraseña = dgbcontraseña.Rows(0).Cells(0).Value

        Catch ex As Exception
            contraseña = ""
        End Try

        If contraseña = Nothing Then
            Me.Hide()
            frmIngresoContraseña.Show()
            btningresar.Visible = False

            txtcontraseña.Visible = False
            btnfuncionario.Visible = True
            btnodontologo.Visible = True
        Else
            lblingrusuario.Text = "Ingrese Contraseña"
            btningresar.Visible = True

            txtcontraseña.Visible = True
            btnfuncionario.Visible = False
            btnodontologo.Visible = False
        End If

    End Sub

    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Consulta = "select * from paciente"
        consultar()

        If conex = False Then

            MsgBox("No hay conexión a la base de datos", MsgBoxStyle.Exclamation)
            pbConexion.Image = My.Resources.letterx_87521
        Else
            pbConexion.Image = My.Resources.IconoConexion

        End If

        btningresar.Visible = False
        btnAtras.Visible = False
        txtcontraseña.Visible = False

        xf = Me.Location.X
        yf = Me.Location.Y

    End Sub

    Private Sub btningresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btningresar.Click
      


        If contador = 1 Then

            Consulta = "select contrasenia from usuarios where contrasenia = sha2('" + txtcontraseña.Text + "', 256) and usuario = 'odo';"
            consultar()
            Dim verifi As Integer = 0
            For Each row In Tabla.Rows
                If Not IsDBNull(row("contrasenia")) Then
                    verifi = 1
                End If
            Next

            If verifi = 1 Then
                user = "odontologo"
                pass = "odontologo"
                cambiarUsuario(user, pass)
                Me.Hide()
                frmMenuInicio.Show()
            Else
                MsgBox("contraseña incorrecta porfavor reintente", MsgBoxStyle.Exclamation)
                txtcontraseña.Clear()
            End If

        ElseIf contador = 2 Then


            Consulta = "select contrasenia from usuarios where contrasenia = sha2('" + txtcontraseña.Text + "', 256) and usuario = 'fun';"
            consultar()
            Dim verifi As Integer = 0
            For Each row In Tabla.Rows
                If Not IsDBNull(row("contrasenia")) Then
                    verifi = 1
                End If
            Next

            If verifi = 1 Then
                user = "funcionario"
                pass = "funcionario"
                cambiarUsuario(user, pass)
                Me.Hide()
                frmMenuInicio.Show()

            Else

                MsgBox("contraseña incorrecta porfavor reintente", MsgBoxStyle.Exclamation)

            End If

        End If

    End Sub

    Private Sub txtcontraseña_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtcontraseña.KeyDown
        If e.KeyCode = Keys.Enter Then
            btningresar.PerformClick()
        End If
    End Sub

    Private Sub btnAtras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAtras.Click
        btningresar.Visible = False
        btnAtras.Visible = False
        txtcontraseña.Visible = False
        btnfuncionario.Visible = True
        btnodontologo.Visible = True
        txtcontraseña.Clear()
    End Sub

    Private Sub pbCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbCerrar.Click
        Me.Dispose()
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

    Private Sub lblingrusuario_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblingrusuario.MouseDown
        mover = True
    End Sub

    Private Sub lblingrusuario_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblingrusuario.MouseMove
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

    Private Sub lblingrusuario_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblingrusuario.MouseUp
        xf = Me.Location.X
        yf = Me.Location.Y
        mover = False
    End Sub
End Class




