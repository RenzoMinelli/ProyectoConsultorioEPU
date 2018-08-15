﻿Public Class Modificar_Paciente

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

        If txbNombre.Text <> "" And txbCedula.Text <> "" And txbDireccionPersonal.Text <> "" Then

            If txbNombre.Text <> nombre Then
                ver = 1
                nombre = txbNombre.Text
            End If
            If txbCedula.Text <> cedula Then
                ver2 = 1
                cedula = txbCedula.Text
            End If
            If txbEnviadoPor.Text <> enviado Then
                ver3 = 1
                enviado = txbEnviadoPor.Text
            End If
            If txbDireccionPersonal.Text <> direccion Then
                ver4 = 1
                direccion = txbDireccionPersonal.Text
            End If
            If txbDireccionTrabajo.Text <> direTra Then
                ver5 = 1
                direTra = txbDireccionTrabajo.Text
            End If
            If nac <> nac2 Then
                ver6 = 1
            End If
            If txbTelefono.Text <> telefono Then
                ver7 = 1
                telefono = txbTelefono.Text

            End If

            nac = mcFechaNacimiento.SelectionRange.Start.ToString("yyyy-MM-dd")
            Try
                If ver = 1 Then
                    Consulta = "UPDATE paciente SET nombre = '" + nombre + "' WHERE id_p = " + Str(id_p) + ";"
                    consultar()
                End If
                If ver2 = 1 Then
                    Consulta = "UPDATE paciente SET cedula = '" + cedula + "' WHERE id_p = " + Str(id_p) + ";"
                    consultar()
                End If
                If ver3 = 1 Then
                    If enviado = "" Then
                        Consulta = "UPDATE paciente SET enviado_por = null WHERE id_p = " + Str(id_p) + ";"
                        consultar()
                    Else
                        Consulta = "UPDATE paciente SET enviado_por = '" + enviado + "' WHERE id_p = " + Str(id_p) + ";"
                        consultar()
                    End If

                End If
                If ver4 = 1 Then
                    Consulta = "UPDATE paciente SET direccion_particular = '" + direccion + "' WHERE id_p = " + Str(id_p) + ";"
                    consultar()
                End If
                If ver5 = 1 Then
                    If direTra = "" Then
                        Consulta = "UPDATE paciente SET direccion_trabajo = null WHERE id_p = " + Str(id_p) + ";"
                        consultar()
                    Else
                        Consulta = "UPDATE paciente SET direccion_trabajo = '" + direTra + "' WHERE id_p = " + Str(id_p) + ";"
                        consultar()
                    End If

                End If
                If ver6 = 1 Then
                    Consulta = "UPDATE paciente SET fecha_nacimiento = '" + nac + "' WHERE id_p = " + Str(id_p) + ";"
                    consultar()
                End If
                If ver7 = 1 Then
                    Consulta = "UPDATE paciente SET telefono = '" + telefono + "' where id_p = '" + id_p.ToString + "';"
                    consultar()
                End If
                If cambio = 1 Then

                    If DataGridView1.Rows(0).Cells(0).Value = Nothing Then
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

        actPos()
        Me.Size = New System.Drawing.Size(880, 580)

        txbNombre.Text = nombre
        txbCedula.Text = cedula
        txbEnviadoPor.Text = enviado
        txbDireccionPersonal.Text = direccion
        txbDireccionTrabajo.Text = direTra
        txbTelefono.Text = telefono
        mcFechaNacimiento.SelectionRange.Start = nac
        lblFechaSeleccionada.Text = "Fecha seleccionada " + nac

        'Antecedentes
        Consulta = "SELECT * FROM antecedentes where id_p = '" + Str(id_p) + "';"
        consultar()
        DataGridView1.DataSource = Tabla

        alergicos = DataGridView1.Rows(0).Cells(1).Value
        diabeticos = DataGridView1.Rows(0).Cells(2).Value
        cardiovasculares = DataGridView1.Rows(0).Cells(3).Value
        fiebre_reumatica = DataGridView1.Rows(0).Cells(4).Value
        coagulacion = DataGridView1.Rows(0).Cells(5).Value
        odontologicos = DataGridView1.Rows(0).Cells(6).Value
        farmacos_recibidos = DataGridView1.Rows(0).Cells(7).Value
        familiares = DataGridView1.Rows(0).Cells(8).Value
        tratamiento_medico = DataGridView1.Rows(0).Cells(9).Value
        observaciones = DataGridView1.Rows(0).Cells(10).Value

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Dispose()
        Pacientes.Show()
    End Sub


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificarAntecedentes.Click
        Me.Hide()
        frmContenedor = Modificar_Antecedentes
        frmContenedor.MdiParent = Menu_Inicio
        frmContenedor.Dock = DockStyle.Fill
        frmContenedor.Show()
    End Sub
End Class