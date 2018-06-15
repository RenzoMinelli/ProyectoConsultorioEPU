Public Class Agregar_Paciente

    Dim a As Integer = 0
    Dim ver As Integer = -1
    Dim xco, yco As Integer
    Dim xc, yc As Integer
    Dim xf, yf As Integer

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        direTra = ""
        enviado = ""
        Dim ver As Integer = 0
        Dim ver2 As Integer = 0
        If TextBox1.Text <> "" And TextBox2.Text <> "" And TextBox4.Text <> "" Then

            nombre = TextBox1.Text
            cedula = TextBox2.Text
            If TextBox3.Text <> "" Then
                ver = 1
                enviado = TextBox3.Text
            End If

            direccion = TextBox4.Text

            If TextBox5.Text <> "" Then
                direTra = TextBox5.Text
                ver2 = 1
            End If

            nac = MonthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd")


            If ver = 0 And ver2 = 0 Then
                Consulta = "INSERT INTO paciente (cedula, fecha_nacimiento, nombre, direccion_particular) values('" + cedula + "','" + nac + "','" + nombre + "','" + direccion + "');"
            ElseIf ver = 0 And ver2 = 1 Then
                Consulta = "INSERT INTO paciente (cedula, fecha_nacimiento, nombre, direccion_particular, direccion_trabajo) values('" + cedula + "','" + nac + "','" + nombre + "','" + direccion + "','" + direTra + "');"
            ElseIf ver = 1 And ver2 = 0 Then
                Consulta = "INSERT INTO paciente (cedula, fecha_nacimiento, nombre, enviado_por, direccion_particular) values('" + cedula + "','" + nac + "','" + nombre + "','" + enviado + "','" + direccion + "');"
            ElseIf ver = 1 And ver2 = 1 Then
                Consulta = "INSERT INTO paciente (cedula, fecha_nacimiento, nombre, enviado_por, direccion_particular, direccion_trabajo) values('" + cedula + "','" + nac + "','" + nombre + "','" + enviado + "','" + direccion + "','" + direTra + "');"
            End If


            consultar()

            MsgBox("Agregado con Exito")

            Me.Dispose()
            Pacientes.Show()
            Pacientes.actTabla()

        Else

            MsgBox("complete los campos necesarios")

        End If


    End Sub

    Private Sub MonthCalendar1_DateChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles MonthCalendar1.DateChanged
        Dim nac As String = MonthCalendar1.SelectionRange.Start
        Label7.Text = "Fecha seleccionada " + nac
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Location = New Point(Menu_Inicio.Location.X + 160, Menu_Inicio.Location.Y)
        xf = Me.Location.X
        yf = Me.Location.Y
        Me.Size = New System.Drawing.Size(880, 580)
        Dim nac As String = MonthCalendar1.SelectionRange.Start
        Label7.Text = "Fecha seleccionada " + nac
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        Pacientes.Show()
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox6.Click
        Aranceles.Dispose()
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        Me.WindowState = FormWindowState.Minimized
        Menu_Inicio.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub Panel1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseMove

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
    Private Sub Panel3_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseUp
        xf = Me.Location.X
        yf = Me.Location.Y
        a = 0
    End Sub

    Private Sub Form2_LocationChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.LocationChanged
        If Not ver = -1 Then
            Menu_Inicio.Location = New Point(Me.Location.X - 160, Me.Location.Y)
        End If

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub
    
End Class