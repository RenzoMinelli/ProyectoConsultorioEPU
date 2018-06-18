Public Class Crear_Cita

    Dim a As Integer = 0
    Dim xco, yco As Integer
    Dim xc, yc As Integer

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Pacientes.Show()
        Me.Dispose()
    End Sub

    Private Sub Crear_Cita_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        actPos()
        Me.Size = New System.Drawing.Size(880, 580)
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox6.Click
        Aranceles.Dispose()
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        Me.WindowState = FormWindowState.Minimized
        Menu_Inicio.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click


        Dim fecha As String = DateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss")
        Consulta = "INSERT INTO cita (id_p, fecha_hora, realizada) values ('" + Str(id_p) + "', '" + fecha + "', '0');"
        consultar()
        MsgBox("Registrado")
        Me.Dispose()
        Pacientes.Show()

    End Sub
    Private Sub Panel3_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseDown
        a = 1
    End Sub
    Private Sub Panel3_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseMove

        If a = 1 Then

            xc = Cursor.Position.X
            yc = Cursor.Position.Y

            Dim holax, holay As Integer

            holax = xc - xco
            holay = yc - yco

            Menu_Inicio.Location = New Point(xf + holax, yf + holay)

        End If

        If a = 0 Then

            xco = Cursor.Position.X
            yco = Cursor.Position.Y

        End If
    End Sub
    Private Sub Panel3_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseUp
        xf = Menu_Inicio.Location.X
        yf = Menu_Inicio.Location.Y
        a = 0
    End Sub

End Class