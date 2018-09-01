Public Class ModificarPaciente

    Dim nac2 As String


    '/////////////////////////Antecedentes//////////////////////////
    Public alergicos As Boolean
    Public diabeticos As Boolean
    Public cardiovasculares As Boolean
    Public fiebre_reumatica As Boolean
    Public coagulacion As Boolean
    Public odontologicos As Boolean
    Public farmacos_recibidos As Boolean
    Public familiares As Boolean
    Public tratamiento_medico As Boolean
    Public observaciones As String

    Public cambio As Integer
    '/////////////////////////////////////////////////////////////


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click

        Dim ver As Integer = 0
        Dim ver2 As Integer = 0
        Dim ver3 As Integer = 0
        Dim ver4 As Integer = 0
        Dim ver5 As Integer = 0
        Dim ver6 As Integer = 0
        Dim ver7 As Integer = 0
        Dim ver8 As Integer = 0

        If txbNombre.Text <> "" And txbCedula.Text <> "" And txbDireccionPersonal.Text <> "" Then

            If txbNombre.Text <> Pacientes.nombre Then
                ver = 1
                Pacientes.nombre = txbNombre.Text
            End If
            If txbCedula.Text <> Pacientes.cedula Then
                ver2 = 1
                Pacientes.cedula = txbCedula.Text
            End If
            If txbEnviadoPor.Text <> Pacientes.enviado Then
                ver3 = 1
                Pacientes.enviado = txbEnviadoPor.Text
            End If
            If txbDireccionPersonal.Text <> Pacientes.direccion Then
                ver4 = 1
                Pacientes.direccion = txbDireccionPersonal.Text
            End If
            If txbDireccionTrabajo.Text <> Pacientes.direTra Then
                ver5 = 1
                Pacientes.direTra = txbDireccionTrabajo.Text
            End If
            If Pacientes.nac <> nac2 Then
                ver6 = 1
            End If
            If txbTelefono.Text <> Pacientes.telefono Then
                ver7 = 1
                Pacientes.telefono = txbTelefono.Text

            End If
            If txbApellido.Text <> Pacientes.apellido Then
                ver8 = 1
                Pacientes.apellido = txbApellido.Text
            End If

            Pacientes.nac = mcFechaNacimiento.SelectionRange.Start.ToString("yyyy-MM-dd")

            Try
                If ver = 1 Then
                    Consulta = "UPDATE paciente SET nombre = '" + Pacientes.nombre + "' WHERE id_p = " + Str(id_p) + ";"
                    consultar()
                End If
                If ver2 = 1 Then
                    Consulta = "UPDATE paciente SET cedula = '" + Pacientes.cedula + "' WHERE id_p = " + Str(id_p) + ";"
                    consultar()
                End If
                If ver3 = 1 Then
                    If Pacientes.enviado = "" Then
                        Consulta = "UPDATE paciente SET enviado_por = null WHERE id_p = " + Str(id_p) + ";"
                        consultar()
                    Else
                        Consulta = "UPDATE paciente SET enviado_por = '" + Pacientes.enviado + "' WHERE id_p = " + Str(id_p) + ";"
                        consultar()
                    End If

                End If
                If ver4 = 1 Then
                    Consulta = "UPDATE paciente SET direccion_particular = '" + Pacientes.direccion + "' WHERE id_p = " + Str(id_p) + ";"
                    consultar()
                End If
                If ver5 = 1 Then
                    If Pacientes.direTra = "" Then
                        Consulta = "UPDATE paciente SET direccion_trabajo = null WHERE id_p = " + Str(id_p) + ";"
                        consultar()
                    Else
                        Consulta = "UPDATE paciente SET direccion_trabajo = '" + Pacientes.direTra + "' WHERE id_p = " + Str(id_p) + ";"
                        consultar()
                    End If

                End If
                If ver6 = 1 Then
                    Consulta = "UPDATE paciente SET fecha_nacimiento = '" + Pacientes.nac + "' WHERE id_p = " + Str(id_p) + ";"
                    consultar()
                End If
                If ver7 = 1 Then
                    Consulta = "UPDATE paciente SET telefono = '" + Pacientes.telefono + "' where id_p = '" + id_p.ToString + "';"
                    consultar()
                End If
                If ver8 = 1 Then
                    Consulta = "UPDATE paciente SET apellido = '" + Pacientes.apellido + "' where id_p = '" + id_p.ToString + "';"
                    consultar()
                End If
                If cambio = 1 Then

                    If dgvAntecedentes.Rows(0).Cells(0).Value = Nothing Then
                        Consulta = "INSERT INTO antecedentes VALUES ('" + Str(id_p) + "', '" + alergicos.GetHashCode.ToString + "', '" + diabeticos.GetHashCode.ToString + "', '" + cardiovasculares.GetHashCode.ToString + "', '" + fiebre_reumatica.GetHashCode.ToString + "', '" + coagulacion.GetHashCode.ToString + "', '" + odontologicos.GetHashCode.ToString + "', '" + farmacos_recibidos.GetHashCode.ToString + "', '" + familiares.GetHashCode.ToString + "', '" + tratamiento_medico.GetHashCode.ToString + "', '" + observaciones + "');"
                        consultar()
                    Else

                        Consulta = "UPDATE antecedentes SET alergicos = '" + alergicos.GetHashCode.ToString + "', diabeticos = '" + diabeticos.GetHashCode.ToString + "', cardiovasculares = '" + cardiovasculares.GetHashCode.ToString + "', fiebre_reumatica = '" + fiebre_reumatica.GetHashCode.ToString + "', coagulacion = '" + coagulacion.GetHashCode.ToString + "', odontologicos = '" + odontologicos.GetHashCode.ToString + "', farmacos_recibidos = '" + farmacos_recibidos.GetHashCode.ToString + "', familiares = '" + familiares.GetHashCode.ToString + "', tratamientos_medicos = '" + tratamiento_medico.GetHashCode.ToString + "', observaciones = '" + observaciones + "' WHERE id_p = '" + Str(id_p) + "';"
                        consultar()
                    End If


                End If
                MsgBox("Guardado con Exito")

                Pacientes.Show()
                Pacientes.actTabla(1)
                Pacientes.actPanel()
                Me.Dispose()

            Catch ex As Exception

                MsgBox("Error" + vbNewLine + ex.ToString)

            End Try

        Else

            MsgBox("Complete los campos necesarios")

        End If


    End Sub

    Private Sub MonthCalendar1_DateChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles mcFechaNacimiento.DateChanged
        nac2 = mcFechaNacimiento.SelectionRange.Start
        lblFechaSeleccionada.Text = "Fecha seleccionada " + nac2
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load



        txbApellido.Text = Pacientes.apellido
        txbNombre.Text = Pacientes.nombre
        txbCedula.Text = Pacientes.cedula
        txbEnviadoPor.Text = Pacientes.enviado
        txbDireccionPersonal.Text = Pacientes.direccion
        txbDireccionTrabajo.Text = Pacientes.direTra
        txbTelefono.Text = Pacientes.telefono
        mcFechaNacimiento.SelectionRange.Start = Pacientes.nac
        lblFechaSeleccionada.Text = "Fecha seleccionada " + Pacientes.nac

        'Antecedentes
        Consulta = "SELECT * FROM antecedentes where id_p = '" + Str(id_p) + "';"
        consultar()
        dgvAntecedentes.DataSource = Tabla

        alergicos = dgvAntecedentes.Rows(0).Cells(1).Value
        diabeticos = dgvAntecedentes.Rows(0).Cells(2).Value
        cardiovasculares = dgvAntecedentes.Rows(0).Cells(3).Value
        fiebre_reumatica = dgvAntecedentes.Rows(0).Cells(4).Value
        coagulacion = dgvAntecedentes.Rows(0).Cells(5).Value
        odontologicos = dgvAntecedentes.Rows(0).Cells(6).Value
        farmacos_recibidos = dgvAntecedentes.Rows(0).Cells(7).Value
        familiares = dgvAntecedentes.Rows(0).Cells(8).Value
        tratamiento_medico = dgvAntecedentes.Rows(0).Cells(9).Value
        observaciones = dgvAntecedentes.Rows(0).Cells(10).Value

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Dispose()
        Pacientes.Show()
    End Sub


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificarAntecedentes.Click
        Me.Hide()
        frmContenedor = ModificarAntecedentes
        frmContenedor.MdiParent = Menu_Inicio
        frmContenedor.Dock = DockStyle.Fill
        frmContenedor.Show()
    End Sub
End Class