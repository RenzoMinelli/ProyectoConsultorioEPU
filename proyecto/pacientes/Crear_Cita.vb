Public Class Crear_Cita

    Dim fecha As String
    Dim hora As String
    Dim descr As String


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Pacientes.Show()
        Me.Dispose()
    End Sub

    Private Sub Crear_Cita_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fecha = DateTimePicker1.Value.ToString("yyyy-MM-dd")
        hora = DateTimePicker1.Value.ToString("HH:mm:ss")

        Consulta = "Select nombre as 'Nombre', fecha as 'Fecha', hora as 'Hora' from cita c inner join paciente p on c.id_p = p.id_p where fecha = '" + fecha + "';"
        consultar()
        DataGridView1.DataSource = Tabla
        

    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Aranceles.Dispose()
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.WindowState = FormWindowState.Minimized
        Menu_Inicio.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        descr = TextBox1.Text
        If descr = "" Then
            MsgBox("Complete las indicaciones", MsgBoxStyle.Exclamation)
        Else

            Dim control As Integer = 0
            Dim hora2 As TimeSpan = (Convert.ToDateTime(hora)).TimeOfDay

            For x = 0 To DataGridView1.RowCount - 1

                Dim HoraAux As TimeSpan = DataGridView1.Rows(x).Cells(2).Value

                Dim HoraAuxFinal As New TimeSpan(0, 40, 0)
                HoraAuxFinal = HoraAux + HoraAuxFinal


                If hora2 <= HoraAuxFinal And hora2 >= HoraAux Then

                    control = 1

                End If


            Next

            If control = 1 Then
                MsgBox("Ya tiene una cita marcada a esa hora", MsgBoxStyle.Information)
            Else
                Try
                    Consulta = "Select nombre as 'Nombre', fecha as 'Fecha', hora as 'Hora' from cita c inner join paciente p on c.id_p = p.id_p where fecha = '" + fecha + "';"
                    consultar()
                    MsgBox("Registrado", MsgBoxStyle.Information)
                    Me.Dispose()
                    Pacientes.Show()
                Catch ex As Exception
                    MsgBox("Error al ingresar la cita")
                End Try

            End If


        End If
        

    End Sub


    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged
        fecha = DateTimePicker1.Value.ToString("yyyy-MM-dd")
        hora = DateTimePicker1.Value.ToString("HH:mm:ss")

        Consulta = "Select nombre as 'Nombre', fecha as 'Fecha', hora as 'Hora' from cita c inner join paciente p on c.id_p = p.id_p where fecha = '" + fecha + "';"
        consultar()
        DataGridView1.DataSource = Tabla
    End Sub
End Class