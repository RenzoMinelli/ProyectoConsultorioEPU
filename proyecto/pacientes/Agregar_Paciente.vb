﻿Public Class Agregar_Paciente




    '/////////////////////////Cosas Para Los Antecedentes/////////////////////////////////
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
    '///////////////////////////////////////////////////////////////////////////////////


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        direTra = ""
        enviado = ""
        Dim ver As Integer = 0
        Dim ver2 As Integer = 0

        If txbNombre.Text <> "" And txbCedula.Text <> "" And txbDireccionPersonal.Text <> "" And txbTelefono.Text <> "" Then
            If IsNumeric(txbCedula.Text) Then
                If verificarCedula(txbCedula.Text) = True Then
                    If alergicos = False And diabeticos = False And cardiovasculares = False And fiebre_reumatica = False And coagulacion = False And odontologicos = False And farmacos_recibidos = False And familiares = False And tratamiento_medico = False And observaciones = "" Then
                        If MsgBox("No fue ingresado ningún antecedente," + vbNewLine + "¿Desea continuar de todos modos?", MsgBoxStyle.YesNo) = vbYes Then

                            nombre = txbNombre.Text
                            cedula = txbCedula.Text
                            If txbEnviadoPor.Text <> "" Then
                                ver = 1
                                enviado = txbEnviadoPor.Text
                            End If
                            telefono = txbTelefono.Text
                            direccion = txbDireccionPersonal.Text

                            If txbDireccionTrabajo.Text <> "" Then
                                direTra = txbDireccionTrabajo.Text
                                ver2 = 1
                            End If

                            nac = mcFechaNacimiento.SelectionRange.Start.ToString("yyyy-MM-dd")

                            Try
                                If ver = 0 And ver2 = 0 Then
                                    Consulta = "INSERT INTO paciente (cedula, fecha_nacimiento, nombre, telefono, direccion_particular) values('" + cedula + "','" + nac + "','" + nombre + "', '" + telefono + "','" + direccion + "');"

                                ElseIf ver = 0 And ver2 = 1 Then

                                    Consulta = "INSERT INTO paciente (cedula, fecha_nacimiento, nombre, telefono, direccion_particular, direccion_trabajo) values('" + cedula + "','" + nac + "','" + nombre + "', '" + telefono + "','" + direccion + "','" + direTra + "');"
                                ElseIf ver = 1 And ver2 = 0 Then

                                    Consulta = "INSERT INTO paciente (cedula, fecha_nacimiento, nombre, telefono, enviado_por, direccion_particular) values('" + cedula + "','" + nac + "','" + nombre + "', '" + telefono + "','" + enviado + "','" + direccion + "');"
                                ElseIf ver = 1 And ver2 = 1 Then

                                    Consulta = "INSERT INTO paciente (cedula, fecha_nacimiento, nombre, telefono, enviado_por, direccion_particular, direccion_trabajo) values('" + cedula + "','" + nac + "','" + nombre + "', '" + telefono + "','" + enviado + "','" + direccion + "','" + direTra + "');"
                                End If


                                consultar()

                                MsgBox("Agregado con Exito", MsgBoxStyle.Information)

                                Me.Dispose()
                                Pacientes.Show()
                                Pacientes.actTabla(1)
                            Catch ex As Exception
                                MsgBox("Error al ingresar usuario", MsgBoxStyle.Exclamation)
                            End Try


                        End If
                    Else
                        nombre = txbNombre.Text
                        cedula = txbCedula.Text
                        If txbEnviadoPor.Text <> "" Then
                            ver = 1
                            enviado = txbEnviadoPor.Text
                        End If
                        telefono = txbTelefono.Text
                        direccion = txbDireccionPersonal.Text

                        If txbDireccionTrabajo.Text <> "" Then
                            direTra = txbDireccionTrabajo.Text
                            ver2 = 1
                        End If

                        nac = mcFechaNacimiento.SelectionRange.Start.ToString("yyyy-MM-dd")


                        Try
                            If ver = 0 And ver2 = 0 Then
                                Consulta = "INSERT INTO paciente (cedula, fecha_nacimiento, nombre, telefono, direccion_particular) values('" + cedula + "','" + nac + "','" + nombre + "', '" + telefono + "','" + direccion + "');"

                            ElseIf ver = 0 And ver2 = 1 Then

                                Consulta = "INSERT INTO paciente (cedula, fecha_nacimiento, nombre, telefono, direccion_particular, direccion_trabajo) values('" + cedula + "','" + nac + "','" + nombre + "', '" + telefono + "','" + direccion + "','" + direTra + "');"
                            ElseIf ver = 1 And ver2 = 0 Then

                                Consulta = "INSERT INTO paciente (cedula, fecha_nacimiento, nombre, telefono, enviado_por, direccion_particular) values('" + cedula + "','" + nac + "','" + nombre + "', '" + telefono + "','" + enviado + "','" + direccion + "');"
                            ElseIf ver = 1 And ver2 = 1 Then

                                Consulta = "INSERT INTO paciente (cedula, fecha_nacimiento, nombre, telefono, enviado_por, direccion_particular, direccion_trabajo) values('" + cedula + "','" + nac + "','" + nombre + "', '" + telefono + "','" + enviado + "','" + direccion + "','" + direTra + "');"
                            End If


                            consultar()




                        Catch ex As Exception
                            MsgBox("Error al ingresar usuario", MsgBoxStyle.Exclamation)
                        End Try

                        Consulta = "select id_p from paciente;"
                        consultar()

                        DataGridView1.DataSource = Tabla
                        id_p = DataGridView1.Rows(DataGridView1.RowCount - 1).Cells(0).Value


                        Consulta = "INSERT INTO antecedentes VALUES ('" + Str(id_p) + "','" + alergicos.GetHashCode.ToString + "','" + diabeticos.GetHashCode.ToString + "','" + cardiovasculares.GetHashCode.ToString + "','" + fiebre_reumatica.GetHashCode.ToString + "','" + coagulacion.GetHashCode.ToString + "','" + odontologicos.GetHashCode.ToString + "','" + farmacos_recibidos.GetHashCode.ToString + "','" + familiares.GetHashCode.ToString + "','" + tratamiento_medico.GetHashCode.ToString + "','" + observaciones + "');"
                        consultar()


                        MsgBox("Agregado con Exito", MsgBoxStyle.Information)

                        Me.Dispose()
                        Pacientes.Show()
                        Pacientes.actTabla(1)
                    End If
                Else
                    MsgBox("Cédula no válida", MsgBoxStyle.Exclamation)
                End If

            Else
                MsgBox("La cédula solo debe contener números", MsgBoxStyle.Exclamation)
                txbCedula.Clear()
            End If


        Else

            MsgBox("complete los campos necesarios", MsgBoxStyle.Exclamation)

        End If


    End Sub

    Private Sub MonthCalendar1_DateChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles mcFechaNacimiento.DateChanged
        Dim nac As String = mcFechaNacimiento.SelectionRange.Start
        lblFechaSeleccionada.Text = "Fecha seleccionada " + nac
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        actPos()
        Me.Size = New System.Drawing.Size(880, 580)
        Dim nac As String = mcFechaNacimiento.SelectionRange.Start
        lblFechaSeleccionada.Text = "Fecha seleccionada " + nac
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Dispose()
        Pacientes.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarAntecedentes.Click
        Me.Hide()
        frmContenedor = Agregar_Antecedentes
        frmContenedor.MdiParent = Menu_Inicio
        frmContenedor.Dock = DockStyle.Fill
        frmContenedor.Show()
    End Sub
    Private Function verificarCedula(ByVal cedula As String)
        Try
            Dim num(7) As Char
            Dim suma As Integer
            Dim suma1 As Integer
            Dim calculo() As Integer = {2, 9, 8, 7, 6, 3, 4}

            num = cedula.ToCharArray()

            For i = 0 To 6
                Dim num1 As Integer = Val(num(i))
                suma = (num1 * calculo(i)) + suma
            Next

            num = suma.ToString.ToCharArray

            ReDim Preserve num(1)
            suma1 = Convert.ToInt32(num) + 1
            num = suma1.ToString.ToCharArray
            ReDim Preserve num(2)
            num(2) = "0"

            suma1 = Convert.ToInt32(num)
            suma = suma1 - suma
            num = cedula.ToCharArray()

            If Str(suma) = Val(num(7)) Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try

    End Function

End Class