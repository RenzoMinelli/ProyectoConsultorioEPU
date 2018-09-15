﻿Public Class frmAgregarCita

    Dim nombre As String
    Dim min As String
    Dim descr As String
    Dim fecha, hora As String



    Private Sub agregarcitas2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        fecha = dtpFechaSeleccionada.Value.ToString("yyyy-MM-dd")
        hora = dtpFechaSeleccionada.Value.ToString("HH:mm:ss")

        Consulta = "Select apellido as 'Apellido', nombre as 'Nombre', fecha as 'Fecha', hora as 'Hora' from cita c inner join paciente p on c.id_p = p.id_p where fecha = '" + fecha + "';"
        consultar()
        dgvCitasEnLaFecha.DataSource = Tabla
        

        Consulta = "Select nombre as 'Nombre',id_p from paciente;"
        consultar()
        dgvPacientes.DataSource = Tabla
        dgvPacientes.Columns(1).Visible = False

        id_p = vbNull

    End Sub
    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFechaSeleccionada.ValueChanged
        fecha = dtpFechaSeleccionada.Value.ToString("yyyy-MM-dd")
        hora = dtpFechaSeleccionada.Value.ToString("HH:mm:ss")

        Consulta = "Select apellido as 'Apellido', nombre as 'Nombre', fecha as 'Fecha', hora as 'Hora' from cita c inner join paciente p on c.id_p = p.id_p where fecha = '" + fecha + "';"
        consultar()
        dgvCitasEnLaFecha.DataSource = Tabla
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvPacientes.CellClick
        id_p = dgvPacientes.CurrentRow.Cells(1).Value
        nombre = dgvPacientes.CurrentRow.Cells(0).Value
        Label6.Text = nombre
    End Sub

   

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
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
                    Consulta = "Insert into cita (id_p, fecha, hora, atendida, descripcion) values ('" + id_p.ToString + "','" + fecha + "', '" + hora + "', 0, '" + descr + "'); "
                    consultar()


                Catch ex As Exception
                    MsgBox("Error al ingresar la cita")
                End Try

            End If


        End If

       

    End Sub
    Private Sub botonsito_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botonsito.Click
        frmCitas.Show()

        Me.Dispose()
    End Sub

   
End Class