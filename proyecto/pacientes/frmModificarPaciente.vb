Public Class frmModificarPaciente

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

            If txbNombre.Text <> frmPacientes.nombre Then
                ver = 1
                frmPacientes.nombre = txbNombre.Text
            End If
            If txbCedula.Text <> frmPacientes.cedula Then
                ver2 = 1
                frmPacientes.cedula = txbCedula.Text
            End If
            If txbEnviadoPor.Text <> frmPacientes.enviado Then
                ver3 = 1
                frmPacientes.enviado = txbEnviadoPor.Text
            End If
            If txbDireccionPersonal.Text <> frmPacientes.direccion Then
                ver4 = 1
                frmPacientes.direccion = txbDireccionPersonal.Text
            End If
            If txbDireccionTrabajo.Text <> frmPacientes.direTra Then
                ver5 = 1
                frmPacientes.direTra = txbDireccionTrabajo.Text
            End If
            If frmPacientes.nac <> nac2 Then
                ver6 = 1
            End If
            If txbTelefono.Text <> frmPacientes.telefono Then
                ver7 = 1
                frmPacientes.telefono = txbTelefono.Text

            End If
            If txbApellido.Text <> frmPacientes.apellido Then
                ver8 = 1
                frmPacientes.apellido = txbApellido.Text
            End If

            frmPacientes.nac = mcFechaNacimiento.SelectionRange.Start.ToString("yyyy-MM-dd")

            Try
                If ver = 1 Then
                    Consulta = "UPDATE paciente SET nombre = '" + frmPacientes.nombre + "' WHERE id_p = " + Str(id_p) + ";"
                    consultar()
                End If
                If ver2 = 1 Then
                    Consulta = "UPDATE paciente SET cedula = '" + frmPacientes.cedula + "' WHERE id_p = " + Str(id_p) + ";"
                    consultar()
                End If
                If ver3 = 1 Then
                    If frmPacientes.enviado = "" Then
                        Consulta = "UPDATE paciente SET enviado_por = null WHERE id_p = " + Str(id_p) + ";"
                        consultar()
                    Else
                        Consulta = "UPDATE paciente SET enviado_por = '" + frmPacientes.enviado + "' WHERE id_p = " + Str(id_p) + ";"
                        consultar()
                    End If

                End If
                If ver4 = 1 Then
                    Consulta = "UPDATE paciente SET direccion_particular = '" + frmPacientes.direccion + "' WHERE id_p = " + Str(id_p) + ";"
                    consultar()
                End If
                If ver5 = 1 Then
                    If frmPacientes.direTra = "" Then
                        Consulta = "UPDATE paciente SET direccion_trabajo = null WHERE id_p = " + Str(id_p) + ";"
                        consultar()
                    Else
                        Consulta = "UPDATE paciente SET direccion_trabajo = '" + frmPacientes.direTra + "' WHERE id_p = " + Str(id_p) + ";"
                        consultar()
                    End If

                End If
                If ver6 = 1 Then
                    Consulta = "UPDATE paciente SET fecha_nacimiento = '" + frmPacientes.nac + "' WHERE id_p = " + Str(id_p) + ";"
                    consultar()
                End If
                If ver7 = 1 Then
                    Consulta = "UPDATE paciente SET telefono = '" + frmPacientes.telefono + "' where id_p = '" + id_p.ToString + "';"
                    consultar()
                End If
                If ver8 = 1 Then
                    Consulta = "UPDATE paciente SET apellido = '" + frmPacientes.apellido + "' where id_p = '" + id_p.ToString + "';"
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
                MsgBox("Guardado con éxito", MsgBoxStyle.Information)

                frmPacientes.Show()
                frmPacientes.actTabla(1)
                frmPacientes.actPanel()
                Me.Dispose()

            Catch ex As Exception

                MsgBox("Error" + vbNewLine + ex.ToString)

            End Try

        Else

            MsgBox("Complete los campos necesarios", MsgBoxStyle.Exclamation)

        End If


    End Sub

    Private Sub MonthCalendar1_DateChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles mcFechaNacimiento.DateChanged
        nac2 = mcFechaNacimiento.SelectionRange.Start
        lblFechaSeleccionada.Text = "Fecha seleccionada " + nac2
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load



        txbApellido.Text = frmPacientes.apellido
        txbNombre.Text = frmPacientes.nombre
        txbCedula.Text = frmPacientes.cedula
        txbEnviadoPor.Text = frmPacientes.enviado
        txbDireccionPersonal.Text = frmPacientes.direccion
        txbDireccionTrabajo.Text = frmPacientes.direTra
        txbTelefono.Text = frmPacientes.telefono
        mcFechaNacimiento.SelectionRange.Start = frmPacientes.nac
        lblFechaSeleccionada.Text = "Fecha seleccionada " + frmPacientes.nac

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
        frmPacientes.Show()
    End Sub


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificarAntecedentes.Click
        Me.Hide()
        frmContenedor = frmModificarAntecedentes
        frmContenedor.MdiParent = frmMenuInicio
        frmContenedor.Dock = DockStyle.Fill
        frmContenedor.Show()
    End Sub
End Class