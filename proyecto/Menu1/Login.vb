﻿Public Class Login
    Dim contador As Integer = 0
    Dim contraseña As String
    Dim contraseñau As String
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnodontologo.Click
        contador = 1
        Consulta = "select contrasenia from usuarios where usuario = 'odo';"
        consultar()
        dgbcontraseña.DataSource = Tabla
        contraseña = dgbcontraseña.Rows(0).Cells(0).Value
        contraseñau = txtcontraseña.Text
        If contraseña = Nothing Then
            Me.Hide()
            ingreso_contraseña.Show()
            btningresar.Visible = False
            lblcontraseña.Visible = False
            txtcontraseña.Visible = False
            btnfuncionario.Visible = True
            btnodontologo.Visible = True
        Else
            lblingrusuario.Text = "Ingrese Contraseña"
            btningresar.Visible = True
            lblcontraseña.Visible = True
            txtcontraseña.Visible = True
            btnfuncionario.Visible = False
            btnodontologo.Visible = False
        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfuncionario.Click
        contador = 2

        btningresar.Visible = True
        lblcontraseña.Visible = True
        txtcontraseña.Visible = True
        btnfuncionario.Visible = False
        btnodontologo.Visible = False

        Consulta = "select contrasenia from usuarios where usuario = 'fun';"
        consultar()
        dgbcontraseña.DataSource = Tabla
        contraseña = dgbcontraseña.Rows(0).Cells(0).Value
        contraseñau = txtcontraseña.Text
        If contraseña = Nothing Then
            Me.Hide()
            ingreso_contraseña.Show()
            btningresar.Visible = False
            lblcontraseña.Visible = False
            txtcontraseña.Visible = False
            btnfuncionario.Visible = True
            btnodontologo.Visible = True
        Else
            lblingrusuario.Text = "Ingrese Contraseña"
            btningresar.Visible = True
            lblcontraseña.Visible = True
            txtcontraseña.Visible = True
            btnfuncionario.Visible = False
            btnodontologo.Visible = False
        End If

    End Sub

    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btningresar.Visible = False
        lblcontraseña.Visible = False
        txtcontraseña.Visible = False
    End Sub

    Private Sub btningresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btningresar.Click

        contraseñau = txtcontraseña.Text

        If contador = 1 Then

            If contraseñau = contraseña Then
                user = "odontologo"
                pass = "odontologo"
                Me.Hide()
                Menu_Inicio.Show()
            Else
                MsgBox("contraseña incorrecta porfavor reintente")
            End If

        ElseIf contador = 2 Then

            If contraseñau = contraseña Then

                user = "funcionario"
                pass = "funcionario"
                Me.Hide()
                Menu_Inicio.Show()

            Else

                MsgBox("contraseña incorrecta porfavor reintente")

            End If

        End If

    End Sub
End Class




