Public Class frmModificarCita

    Dim anotaciones As String
    Dim duracion As String

    Private Sub frmModificarCita_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Consulta = "select a.descripcion as 'Descripcion General', pl.descripcion as 'Descripcion Especifica' from plan_tratamiento pl inner join aranceles a on pl.id_a = a.id_a where id_p = '" + id_p.ToString + "' and terminado = '0';"
            consultar()
            dgvTratamientos.DataSource = Tabla

            Consulta = "select descripcion, duracion from cita where id_c = '" + frmCitas.idcita.ToString + "'"
            consultar()
            For Each row In Tabla.Rows
                anotaciones = row("descripcion")
                duracion = row("duracion")
                txbAnotaciones.Text = anotaciones
                txbDuracion.Text = duracion
            Next
        Catch ex As Exception

            MsgBox("Error al obtener datos de la cita", MsgBoxStyle.Exclamation)
        End Try

        Try

            Consulta = "Select apellido as 'Apellido', nombre as 'Nombre', fecha as 'Fecha', hora as 'Hora', duracion from cita c inner join paciente p on c.id_p = p.id_p where fecha = '" + frmCitas.fechaCita + "' and id_c <> '" + frmCitas.idcita.ToString + "';"
            consultar()
            dgvCitasEnLaFecha.DataSource = Tabla

        Catch ex As Exception
            MsgBox("Error al obtener las citas")
        End Try

    End Sub

    Private Sub btnRegresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegresar.Click
        Me.Dispose()
        frmCitas.Show()
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        If txbDuracion.Text <> duracion Or txbAnotaciones.Text <> anotaciones Then
            If IsNumeric(txbDuracion.Text) = True Then
                If Val(txbDuracion.Text) >= 1 Then
                    If txbAnotaciones.Text <> "" Then

                        MuestraMsgBoxVersatil("¿Desea gurdar los cambios realizados?", 0)

                        If respint = 1 Then

                            '--------------------------------------Si la duracion ha sido cambiada-----------------------------------------
                            If txbDuracion.Text <> duracion Then

                                Dim ultimaHora As TimeSpan = (Convert.ToDateTime("21:00:00")).TimeOfDay
                                Dim primeraHora As TimeSpan = (Convert.ToDateTime("08:00:00")).TimeOfDay
                                Dim horaCita As TimeSpan = (Convert.ToDateTime(frmCitas.horaCita)).TimeOfDay
                                Dim horaCitaFinal As New TimeSpan
                                Dim HoraAuxFinal As New TimeSpan
                                Dim mediaHora As New TimeSpan(0, 30, 0)
                                Dim HoraAux As New TimeSpan



                                If Val(txbDuracion.Text) > 1 Then

                                    horaCitaFinal = horaCita + mediaHora

                                    If Val(txbDuracion.Text) > 2 Then

                                        For indice = 1 To Val(txbDuracion.Text) - 2
                                            horaCitaFinal += mediaHora
                                        Next

                                    End If


                                Else
                                    horaCitaFinal = horaCita
                                End If





                                If horaCitaFinal < ultimaHora And horaCita > primeraHora Then

                                    Dim control As Integer = 0


                                    For x = 0 To dgvCitasEnLaFecha.RowCount - 1

                                        HoraAux = dgvCitasEnLaFecha.Rows(x).Cells(3).Value


                                        If dgvCitasEnLaFecha.Rows(x).Cells(4).Value > 1 Then

                                            HoraAuxFinal = HoraAux + mediaHora

                                            If dgvCitasEnLaFecha.Rows(x).Cells(4).Value > 2 Then



                                                For indice = 1 To dgvCitasEnLaFecha.Rows(x).Cells(4).Value - 2
                                                    HoraAuxFinal += mediaHora

                                                Next

                                            End If


                                        Else
                                            HoraAuxFinal = HoraAux
                                        End If


                                        If (horaCita <= HoraAuxFinal And horaCita >= HoraAux) Or (horaCitaFinal <= HoraAuxFinal And horaCitaFinal >= HoraAux) Or (horaCita <= HoraAux And horaCitaFinal >= HoraAuxFinal) Then

                                            control = 1

                                        End If


                                    Next

                                    If control = 1 Then
                                        MsgBox("Ya tiene una cita marcada a esa hora", MsgBoxStyle.Information)
                                    Else


                                        Try
                                            Consulta = "update cita set duracion = '" + txbDuracion.Text + "' where id_c = '" + frmCitas.idcita.ToString + "';"
                                            consultar()

                                        Catch ex As Exception
                                            MsgBox("Error al actualizar duración", MsgBoxStyle.Exclamation)
                                        End Try

                                    End If
                                End If
                            End If

                            '-----------------------------------------Si las anotaciones han sido cambiadas--------------------------------------------------

                            Try
                                Consulta = "UPDATE cita set descripcion = '" + txbAnotaciones.Text + "' where id_c = '" + frmCitas.idcita.ToString + "';"
                                consultar()

                            Catch ex As Exception
                                MsgBox("Error al actualizar las anotaciones", MsgBoxStyle.Exclamation)
                            End Try

                            MsgBox("Actualizado satisfactoriamente", MsgBoxStyle.Information)
                            frmCitas.actCitas()
                            Me.Dispose()
                            frmCitas.Show()
                        Else
                            MsgBox("Ningun cambio fue realizado", MsgBoxStyle.Information)
                        End If
                    Else
                        MsgBox("Complete las anotaciones", MsgBoxStyle.Exclamation)
                    End If
                Else
                    MsgBox("La duración debe ser 1 o mayor", MsgBoxStyle.Exclamation)
                End If
            Else
                MsgBox("La duración debe ser un número", MsgBoxStyle.Exclamation)
            End If
        End If


    End Sub
End Class