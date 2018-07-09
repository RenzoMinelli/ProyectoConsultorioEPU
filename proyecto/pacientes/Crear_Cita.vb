Public Class Crear_Cita



    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Pacientes.Show()
        Me.Dispose()
    End Sub

    Private Sub Crear_Cita_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        actPos()
        Me.Size = New System.Drawing.Size(880, 580)
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Aranceles.Dispose()
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.WindowState = FormWindowState.Minimized
        Menu_Inicio.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click


        Dim fecha As String = DateTimePicker1.Value.ToString("yyyy-MM-dd")
        Dim hora As String = DateTimePicker1.Value.ToString("HH:mm:ss")
        Dim descr = TextBox1.Text
        MsgBox("fecha: " + fecha + " hora:" + hora)
        Try
            Consulta = "INSERT INTO cita (id_p, fecha, hora, realizada, descripcion) values ('" + Str(id_p) + "', '" + fecha + "','" + hora + "', '0','" + descr + "');"
            consultar()
            MsgBox("Registrado")
            Me.Dispose()
            Pacientes.Show()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        

    End Sub


End Class