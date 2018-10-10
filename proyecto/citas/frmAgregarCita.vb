Public Class frmAgregarCita

    Dim nombre As String
    Dim min As String
    Dim descr As String




    Private Sub agregarcitas2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        txbFechaHora.Text = frmCitas.fechaCita + "   " + frmCitas.horaCita
        txbDuracion.Text = "1"

        id_p = 0

        Try

            Consulta = "Select apellido as 'Apellido', nombre as 'Nombre', fecha as 'Fecha', hora as 'Hora',duracion from cita c inner join paciente p on c.id_p = p.id_p where fecha = '" + frmCitas.fechaCita + "';"
            consultar()
            dgvCitasEnLaFecha.DataSource = Tabla
            dgvCitasEnLaFecha.Columns(4).Visible = False

            Consulta = "Select nombre as 'Nombre',id_p from paciente;"
            consultar()
            dgvPacientes.DataSource = Tabla
            dgvPacientes.Columns(1).Visible = False



        Catch ex As Exception

        End Try


    End Sub
    

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvPacientes.CellClick
        id_p = dgvPacientes.CurrentRow.Cells(1).Value
        nombre = dgvPacientes.CurrentRow.Cells(0).Value


        Try
            Consulta = "select a.descripcion as 'Descripcion General', pl.descripcion as 'Descripcion Especifica' from plan_tratamiento pl inner join aranceles a on pl.id_a = a.id_a where id_p = '" + id_p.ToString + "' and terminado = '0';"
            consultar()
            dgvTratamientos.DataSource = Tabla
        Catch ex As Exception

        End Try
    End Sub

   

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        descr = txbAnotaciones.Text
        If id_p = 0 Then
            MsgBox("No seleccionó ningún paciente", MsgBoxStyle.Exclamation)
        ElseIf descr = "" Then
            MsgBox("Complete las anotaciones", MsgBoxStyle.Exclamation)
        ElseIf txbDuracion.Text = "" Or IsNumeric(txbDuracion.Text) = False Or txbDuracion.Text = "0" Then
            MsgBox("Complete la duaración de la cita", MsgBoxStyle.Exclamation)
        Else

            Dim ultimaHora As TimeSpan = (Convert.ToDateTime("21:00:00")).TimeOfDay
            Dim primeraHora As TimeSpan = (Convert.ToDateTime("08:00:00")).TimeOfDay
            Dim horaCita As TimeSpan = (Convert.ToDateTime(frmCitas.horaCita)).TimeOfDay
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

            If horaCitaFinal <= ultimaHora And horaCita >= primeraHora Then

                Dim control As Integer = 0


                For x = 0 To dgvCitasEnLaFecha.RowCount - 1

                    HoraAux = dgvCitasEnLaFecha.Rows(x).Cells(3).Value

                    HoraAuxFinal = HoraAux

                    For indice = 1 To dgvCitasEnLaFecha.Rows(x).Cells(4).Value

                        HoraAuxFinal += mediaHora
                    Next
                    If (horaCita <= HoraAuxFinal And horaCita >= HoraAux) Or (horaCitaFinal <= HoraAuxFinal And horaCitaFinal >= HoraAux) Or (horaCita <= HoraAux And horaCitaFinal >= HoraAuxFinal) Then

                        control = 1

                    End If


                Next

                If control = 1 Then
                    MsgBox("Ya tiene una cita marcada a esa hora", MsgBoxStyle.Information)
                Else
                    Try




                        Consulta = "Insert into cita (id_p, fecha, hora, atendida, descripcion, duracion) values ('" + id_p.ToString + "','" + frmCitas.fechaCita + "', '" + horaCita.ToString + "', 0, '" + descr + "','" + txbDuracion.Text + "'); "
                        consultar()



                        MsgBox("Ingresado con éxito", MsgBoxStyle.Information)

                        Me.Dispose()
                        frmCitas.actCitas()
                        frmCitas.Show()

                    Catch ex As Exception
                        MsgBox("Error al ingresar la cita", MsgBoxStyle.Exclamation)
                    End Try

                End If
            Else

                MsgBox("Los horarios marcados están fuera de los límites", MsgBoxStyle.Exclamation)
            End If



        End If



    End Sub
    Private Sub botonsito_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegresar.Click
        frmCitas.Show()

        Me.Dispose()
    End Sub

   
End Class