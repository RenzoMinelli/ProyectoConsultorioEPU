Public Class frmCrearCita

    Dim fecha As String
    Dim hora As String
    Dim descr As String


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        frmPacientes.Show()
        Me.Dispose()
    End Sub

    Private Sub Crear_Cita_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        Else

            Dim control As Integer = 0
            Dim hora2 As TimeSpan = (Convert.ToDateTime(hora)).TimeOfDay

            For x = 0 To dgvCitasEnLaFecha.RowCount - 1

                Dim HoraAux As TimeSpan = dgvCitasEnLaFecha.Rows(x).Cells(3).Value

                Dim HoraAuxFinal As New TimeSpan(0, 30, 0)
                HoraAuxFinal = HoraAux + HoraAuxFinal


                If hora2 <= HoraAuxFinal And hora2 >= HoraAux Then

                    control = 1

                End If


            Next

            If control = 1 Then
                MsgBox("Ya tiene una cita marcada a esa hora", MsgBoxStyle.Information)
            Else
                Try

                    Consulta = "Insert into cita (id_p, fecha, hora, descripcion, atendida) values ('" + id_p.ToString + "','" + fecha + "', '" + hora + "','" + descr + "', '0'); "
                    consultar()

                    MsgBox("Cita registrada", MsgBoxStyle.Information)

                    Me.Dispose()
                    frmPacientes.Show()

                Catch ex As Exception

                    MsgBox("Error al registar la cita", MsgBoxStyle.Exclamation)

                End Try

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