Public Class Login
    Dim contador As Integer = 0
    Dim contraseña As String
    Dim contraseñau As String
    Dim confirmador As Integer
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnodontologo.Click
        contador = contador + 1
        btningresar.Visible = True
        lblcontraseña.Visible = True
        txtcontraseña.Visible = True
        btnfuncionario.Visible = False
        btnodontologo.Visible = False
        Consulta = "select contraseña from usuarios where usuario = 'odontologo';"
        consultar()
        dgbcontraseña.DataSource = Tabla
        contraseña = dgbcontraseña.Rows(dgbcontraseña.CurrentRow.Index).Cells(0).Value
        contraseñau = txtcontraseña.Text
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfuncionario.Click
        contador = contador + 2
        btningresar.Visible = True
        lblcontraseña.Visible = True
        txtcontraseña.Visible = True
        btnfuncionario.Visible = False
        btnodontologo.Visible = False
        Consulta = "select contraseña from usuarios where usuario = 'funcionario';"
        consultar()
        dgbcontraseña.DataSource = Tabla
        contraseña = dgbcontraseña.Rows(dgbcontraseña.CurrentRow.Index).Cells(0).Value
        contraseñau = txtcontraseña.Text


    End Sub

    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btningresar.Visible = False
        lblcontraseña.Visible = False
        txtcontraseña.Visible = False
        Consulta = "select count (contraseña) where contraseña =''"
        consultar()
        dgbconfirmar.DataSource = Tabla
        confirmador = dgbconfirmar.Rows(dgbcontraseña.CurrentRow.Index).Cells(0).Value

        If IsDBNull(dgbcontraseña.Rows(0).Cells(0).Value) Then

        End If

        If confirmador = 0 Then
            Me.Hide()
            ingreso_contraseña.Show()
        End If
    End Sub

    Private Sub btningresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btningresar.Click
        If contador = 1 Then
            If contraseñau = contraseña Then
                user = "odontologo"
                pass = "odontologo"
                Me.Hide()
                Menu_Inicio.Show()
            Else
                MsgBox("contraseña incorrecta porfavor reintente")
                btningresar.Visible = False
                lblcontraseña.Visible = False
                txtcontraseña.Visible = False
                btnfuncionario.Visible = True
                btnodontologo.Visible = True
            End If
        ElseIf contador = 2 Then
            user = "funcionario"
            pass = "funcionario"
            Me.Hide()
            Menu_Inicio.Show()

        End If

    End Sub
End Class




