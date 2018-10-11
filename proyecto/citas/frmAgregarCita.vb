﻿Public Class frmAgregarCita

    Dim nombre As String
    Dim min As String
    Dim descr As String




    Private Sub agregarcitas2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        txbFechaHora.Text = frmCitas.fechaCita + "   " + frmCitas.horaCita
        txbDuracion.Text = "1"

        'Establezco como debe cargar el txbBusqueda
        txbBusqueda.ForeColor = Color.Gray
        txbBusqueda.Text = "Buscar"

        id_p = 0

        Try

            Consulta = "Select nombre as 'Nombre', apellido as 'Apellido', cedula as 'Cedula' ,id_p from paciente;"
            consultar()
            dgvPacientes.DataSource = Tabla
            dgvPacientes.Columns(3).Visible = False



        Catch ex As Exception

        End Try

        Try

           

            Consulta = "Select apellido as 'Apellido', nombre as 'Nombre', fecha as 'Fecha', hora as 'Hora', duracion from cita c inner join paciente p on c.id_p = p.id_p where fecha = '" + frmCitas.fechaCita + "';"
            consultar()
            dgvCitasEnLaFecha.DataSource = Tabla


        Catch ex As Exception

        End Try


    End Sub
    

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvPacientes.CellClick
        id_p = dgvPacientes.CurrentRow.Cells(3).Value
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

            If horaCitaFinal < ultimaHora And horaCita > primeraHora Then

                Dim control As Integer = 0


                For x = 0 To dgvCitasEnLaFecha.RowCount - 1

                    HoraAux = dgvCitasEnLaFecha.Rows(x).Cells(3).Value

                    HoraAuxFinal = HoraAux

                    For indice = 1 To dgvCitasEnLaFecha.Rows(x).Cells(4).Value

                        HoraAuxFinal += mediaHora
                    Next
                    MsgBox("horaAux: " + HoraAux.ToString + " HoraAuxFinal: " + HoraAuxFinal.ToString + " HoraCita " + horaCita.ToString + " horaCitaFinal " + horaCitaFinal.ToString)

                    'Tengo que arreglar esto !!!!!!!!!!!!!!
                    If (horaCita < HoraAuxFinal And horaCita > HoraAux) Or (horaCitaFinal < HoraAuxFinal And horaCitaFinal > HoraAux) Or (horaCita < HoraAux And horaCitaFinal > HoraAuxFinal) Then

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

    Private Sub txbBusqueda_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txbBusqueda.Click

        'Si el contenido de txbBusqueda es Buscar y de color gris
        If txbBusqueda.Text = "Buscar" And txbBusqueda.ForeColor = Color.Gray Then

            'El cursos se ubique al inicio
            Me.txbBusqueda.SelectionStart = 0

        End If

    End Sub

    Private Sub txbBusqueda_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txbBusqueda.GotFocus

        'Si el contenido de txbBusqueda es Buscar y de color gris
        If txbBusqueda.Text = "Buscar" And txbBusqueda.ForeColor = Color.Gray Then

            'El cursos se ubique al inicio
            txbBusqueda.SelectionStart = 0

        End If

    End Sub

    Private Sub txbBusqueda_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txbBusqueda.KeyDown

        'Si el contenido de txbBusqueda es Buscar, de color gris y la tecla presionada no es 
        If txbBusqueda.Text = "Buscar" And txbBusqueda.ForeColor = Color.Gray And Not e.KeyCode = Keys.Back Then

            'Borrar el contenido del txbBusqueda y volver el color negro
            txbBusqueda.Text = ""
            txbBusqueda.ForeColor = Color.Black


            'Si txbBusqueda solo tiene una letra y la tecla presionada fue borrar, 
        ElseIf e.KeyCode = Keys.Back And txbBusqueda.Text.Length = 1 Then

            'Introduzco el texto 'Buscar' al txbBusqueda de color Gris
            txbBusqueda.Text = "Buscar"
            txbBusqueda.ForeColor = Color.Gray
            actTabla()


            'Si la tecla presionada es borrar y todo el texto esta seleccionado
        ElseIf e.KeyCode = Keys.Back And txbBusqueda.SelectedText = txbBusqueda.Text Then

            'Introduzco el texto 'Buscar' al txbBusqueda de color Gris
            txbBusqueda.Text = "Buscar"
            txbBusqueda.ForeColor = Color.Gray
            actTabla()

        End If
    End Sub
    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txbBusqueda.TextChanged

        'Cuando el contenido de txbBusqueda cambia, guardamos lo ingresado en la variable busqueda
        Dim busqueda As String = txbBusqueda.Text

        'Si el txbBusqueda es igual a 'Buscar' y es de color Gris
        If txbBusqueda.Text = "Buscar" And txbBusqueda.ForeColor = Color.Gray Then

            'Que actualice el dgbPaciente simplemente
            actTabla()

        Else 'Si no

            'Intentamos obtener los pacientes que cumplan con las condición
            Try

                Consulta = "Select nombre as 'Nombre', apellido as 'Apellido', cedula as 'Cedula' ,id_p from paciente where cedula like '%" + txbBusqueda.Text + "%' or nombre like '%" + txbBusqueda.Text + "%' or apellido like '%" + txbBusqueda.Text + "%';"
                consultar()
                dgvPacientes.DataSource = Tabla

            Catch ex As Exception

                'Si se genera una excepción que se muestre una alerta
                MsgBox("Error al buscar los pacientes", MsgBoxStyle.Exclamation)

            End Try

        End If

    End Sub
    Private Sub actTabla()
        Try

            Consulta = "Select nombre as 'Nombre', apellido as 'Apellido', cedula as 'Cedula' ,id_p from paciente;"
            consultar()
            dgvPacientes.DataSource = Tabla
            dgvPacientes.Columns(3).Visible = False

        Catch ex As Exception

            MsgBox("Error al buscar los pacientes", MsgBoxStyle.Exclamation)

        End Try
    End Sub
End Class