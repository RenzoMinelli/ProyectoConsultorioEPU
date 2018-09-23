Public Class frmCrearCita

    Dim fecha As String
    Dim hora As String
    Dim descr As String


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        frmPacientes.Show()
        Me.Dispose()
    End Sub

    Private Sub Crear_Cita_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txbDuracion.Text = "1"
        fecha = dtpFechaSeleccionada.Value.ToString("yyyy-MM-dd")
        hora = dtpFechaSeleccionada.Value.ToString("HH:mm:ss")

        Consulta = "Select apellido as 'Apellido', nombre as 'Nombre', fecha as 'Fecha', hora as 'Hora' from cita c inner join paciente p on c.id_p = p.id_p where fecha = '" + fecha + "';"
        consultar()
        dgvCitasEnLaFecha.DataSource = Tabla

        Consulta = "select a.descripcion as 'Descripcion General', pl.descripcion as 'Descripcion Especifica' from plan_tratamiento pl inner join aranceles a on pl.id_a = a.id_a where id_p = '" + id_p.ToString + "' and terminado = '0';"
        consultar()
        dgvTratamientos.DataSource = Tabla
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Aranceles.Dispose()
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.WindowState = FormWindowState.Minimized
        Menu_Inicio.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCrear.Click
        descr = txbAnotaciones.Text
        If descr = "" Then
            MsgBox("Complete las indicaciones", MsgBoxStyle.Exclamation)

        ElseIf txbDuracion.Text = "" Or IsNumeric(txbDuracion.Text) = False Or txbDuracion.Text = "0" Then

            MsgBox("Complete la duaración de la cita", MsgBoxStyle.Exclamation)

        Else

            Dim ultimaHora As TimeSpan = (Convert.ToDateTime("20:30:00")).TimeOfDay
            Dim primeraHora As TimeSpan = (Convert.ToDateTime("08:00:00")).TimeOfDay
            Dim horaCita As TimeSpan = (Convert.ToDateTime(hora)).TimeOfDay
            Dim horaCitaFinal As New TimeSpan
            Dim HoraAuxFinal As New TimeSpan
            Dim mediaHora As New TimeSpan(0, 30, 0)
            Dim HoraAux As New TimeSpan

            Dim duracion As Integer = Val(txbDuracion.Text)

            If duracion = 1 Then

                horaCitaFinal = horaCita + mediaHora

            Else

                horaCitaFinal = horaCita + mediaHora
                For indice = 1 To Val(txbDuracion.Text) - 1
                    horaCitaFinal += mediaHora
                Next

            End If

            If horaCita < ultimaHora And horaCita > primeraHora Then

                Dim control As Integer = 0


                For x = 0 To dgvCitasEnLaFecha.RowCount - 1

                    HoraAux = dgvCitasEnLaFecha.Rows(x).Cells(3).Value

                    HoraAuxFinal = HoraAux + mediaHora

                    If (horaCita <= HoraAuxFinal And horaCita >= HoraAux) Or (horaCitaFinal <= HoraAuxFinal And horaCitaFinal >= HoraAux) Or (horaCita <= HoraAux And horaCitaFinal >= HoraAuxFinal) Then

                        control = 1

                    End If


                Next

                If control = 1 Then
                    MsgBox("Ya tiene una cita marcada a esa hora", MsgBoxStyle.Information)
                Else
                    Try
                        For x = 1 To duracion



                            Consulta = "Insert into cita (id_p, fecha, hora, atendida, descripcion) values ('" + id_p.ToString + "','" + fecha + "', '" + horaCita.ToString + "', 0, '" + descr + "'); "
                            consultar()

                            horaCita += mediaHora
                        Next


                        MsgBox("Ingresado con éxito", MsgBoxStyle.Information)

                        Me.Dispose()
                        frmCitas.actCitas()
                        frmCitas.Show()

                    Catch ex As Exception
                        MsgBox("Error al ingresar la cita" + ex.ToString, MsgBoxStyle.Exclamation)
                    End Try

                End If
            Else

                MsgBox("Los horarios marcados están fuera de los límites", MsgBoxStyle.Exclamation)
            End If



        End If

    End Sub


    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFechaSeleccionada.ValueChanged
        fecha = dtpFechaSeleccionada.Value.ToString("yyyy-MM-dd")
        hora = dtpFechaSeleccionada.Value.ToString("HH:mm:ss")

        Consulta = "Select apellido as 'Apellido', nombre as 'Nombre', fecha as 'Fecha', hora as 'Hora' from cita c inner join paciente p on c.id_p = p.id_p where fecha = '" + fecha + "';"
        consultar()
        dgvCitasEnLaFecha.DataSource = Tabla
    End Sub

    Private Sub dgbCitasEnLaFecha_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvCitasEnLaFecha.CellClick
        dgvCitasEnLaFecha.ClearSelection()
    End Sub

    Private Sub dgbCitasEnLaFecha_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvCitasEnLaFecha.Click
        dgvCitasEnLaFecha.ClearSelection()
    End Sub

    Private Sub dgbCitasEnLaFecha_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgvCitasEnLaFecha.MouseClick
        dgvCitasEnLaFecha.ClearSelection()
    End Sub

    Private Sub dgbCitasEnLaFecha_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgvCitasEnLaFecha.MouseDown
        dgvCitasEnLaFecha.ClearSelection()
    End Sub

    Private Sub dgbCitasEnLaFecha_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvCitasEnLaFecha.MouseEnter
        dgvCitasEnLaFecha.ClearSelection()
    End Sub

   
End Class