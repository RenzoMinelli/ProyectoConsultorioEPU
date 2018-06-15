Public Class Modificar_Paciente
    Dim a As Integer = 0
    Dim ver As Integer = -1
    Dim xco, yco As Integer
    Dim xc, yc As Integer
    Dim xf, yf As Integer
    Dim nac2 As String

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim ver As Integer = 0
        Dim ver2 As Integer = 0
        Dim ver3 As Integer = 0
        Dim ver4 As Integer = 0
        Dim ver5 As Integer = 0
        Dim ver6 As Integer = 0

        If TextBox1.Text <> "" And TextBox2.Text <> "" And TextBox4.Text <> "" Then

            If TextBox1.Text <> nombre Then
                ver = 1
                nombre = TextBox1.Text
            End If
            If TextBox2.Text <> cedula Then
                ver2 = 1
                cedula = TextBox2.Text
            End If
            If TextBox3.Text <> enviado Then
                ver3 = 1
                enviado = TextBox3.Text
            End If
            If TextBox4.Text <> direccion Then
                ver4 = 1
                direccion = TextBox4.Text
            End If
            If TextBox5.Text <> direTra Then
                ver5 = 1
                direTra = TextBox5.Text
            End If
            If nac <> nac2 Then
                ver6 = 1
            End If

            nac = MonthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd")
            Try
                If ver = 1 Then
                    Consulta = "UPDATE paciente SET nombre = '" + nombre + "' WHERE id_p = " + Str(id_p) + ";"
                    consultar()
                End If
                If ver2 = 1 Then
                    Consulta = "UPDATE paciente SET cedula = '" + cedula + "' WHERE id_p = " + Str(id_p) + ";"
                    consultar()
                End If
                If ver3 = 1 Then
                    Consulta = "UPDATE paciente SET enviado_por = '" + enviado + "' WHERE id_p = " + Str(id_p) + ";"
                    consultar()
                End If
                If ver4 = 1 Then
                    Consulta = "UPDATE paciente SET direccion_particular = '" + direccion + "' WHERE id_p = " + Str(id_p) + ";"
                    consultar()
                End If
                If ver5 = 1 Then
                    Consulta = "UPDATE paciente SET direccion_trabajo = '" + direTra + "' WHERE id_p = " + Str(id_p) + ";"
                    consultar()
                End If
                If ver6 = 1 Then
                    Consulta = "UPDATE paciente SET fecha_nacimiento = '" + nac + "' WHERE id_p = " + Str(id_p) + ";"
                    consultar()
                End If

                MsgBox("Guardado con Exito")

                Pacientes.Show()
                Pacientes.actTabla()
                Pacientes.actPanel()
                Pacientes.actPos()
                Me.Dispose()

            Catch ex As Exception

                MsgBox("Error")

            End Try
            
        Else

            MsgBox("Complete los campos necesarios")

        End If


    End Sub

    Private Sub MonthCalendar1_DateChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles MonthCalendar1.DateChanged
        nac2 = MonthCalendar1.SelectionRange.Start
        Label7.Text = "Fecha seleccionada " + nac2
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ShowInTaskbar = False
        actPos()
        Me.Size = New System.Drawing.Size(880, 580)

        TextBox1.Text = nombre
        TextBox2.Text = cedula
        TextBox3.Text = enviado
        TextBox4.Text = direccion
        TextBox5.Text = direTra
        MonthCalendar1.SelectionRange.Start = nac
        Label7.Text = "Fecha seleccionada " + nac
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Dispose()
        Pacientes.Show()
        Pacientes.actPos()
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        Aranceles.Dispose()
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        Me.WindowState = FormWindowState.Minimized
        Menu_Inicio.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub Panel3_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel3.MouseDown
        a = 1
        ver = 0
    End Sub
    Private Sub Panel3_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel3.MouseMove

        If a = 1 Then

            xc = Cursor.Position.X
            yc = Cursor.Position.Y

            Dim holax, holay As Integer

            holax = xc - xco
            holay = yc - yco

            Me.Location = New Point(xf + holax, yf + holay)

        End If

        If a = 0 Then

            xco = Cursor.Position.X
            yco = Cursor.Position.Y

        End If
    End Sub
    Private Sub Panel3_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel3.MouseUp
        xf = Me.Location.X
        yf = Me.Location.Y
        a = 0
    End Sub

    Private Sub Form2_LocationChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.LocationChanged
        If Not ver = -1 Then
            Menu_Inicio.Location = New Point(Me.Location.X - 160, Me.Location.Y)
        End If

    End Sub
    Public Sub actPos()
        Me.Location = New Point(Menu_Inicio.Location.X + 160, Menu_Inicio.Location.Y)
        xf = Me.Location.X
        yf = Me.Location.Y
    End Sub
End Class