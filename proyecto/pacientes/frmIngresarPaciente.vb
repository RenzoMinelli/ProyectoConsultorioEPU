Public Class frmIngresarPaciente




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
        frmPacientes.direTra = ""
        frmPacientes.enviado = ""
        Dim ver As Integer = 0
        Dim ver2 As Integer = 0

        If txbNombre.Text <> "" And txbCedula.Text <> "" And txbDireccionPersonal.Text <> "" And txbTelefono.Text <> "" And txbApellido.Text <> "" Then
            If IsNumeric(txbCedula.Text) Then

                Consulta = "select * from paciente where cedula = '" + txbCedula.Text + "';"
                consultar()
                dgvPacientesCedulas.DataSource = Tabla

                If Not dgvPacientesCedulas.RowCount = 0 Then
                    MsgBox("Ya existe usuario con esa cedula", MsgBoxStyle.Exclamation)
                Else
                    If verificarCedula(txbCedula.Text) = True Then
                        If alergicos = False And diabeticos = False And cardiovasculares = False And fiebre_reumatica = False And coagulacion = False And odontologicos = False And farmacos_recibidos = False And familiares = False And tratamiento_medico = False And observaciones = "" Then
                            If MsgBox("No fue ingresado ningún antecedente," + vbNewLine + "¿Desea continuar de todos modos?", MsgBoxStyle.YesNo) = vbYes Then

                                frmPacientes.nombre = txbNombre.Text.ToUpper
                                frmPacientes.apellido = txbApellido.Text.ToUpper
                                frmPacientes.cedula = txbCedula.Text
                                If txbEnviadoPor.Text <> "" Then
                                    ver = 1
                                    frmPacientes.enviado = txbEnviadoPor.Text
                                End If
                                frmPacientes.telefono = txbTelefono.Text
                                frmPacientes.direccion = txbDireccionPersonal.Text.ToUpper

                                If txbDireccionTrabajo.Text <> "" Then
                                    frmPacientes.direTra = txbDireccionTrabajo.Text.ToUpper
                                    ver2 = 1
                                End If

                                frmPacientes.nac = mcFechaNacimiento.SelectionRange.Start.ToString("yyyy-MM-dd")

                                Try
                                    If ver = 0 And ver2 = 0 Then
                                        Consulta = "INSERT INTO paciente (cedula, fecha_nacimiento, nombre, apellido, telefono, direccion_particular) values('" + frmPacientes.cedula + "','" + frmPacientes.nac + "','" + frmPacientes.nombre + "', '" + frmPacientes.apellido + "', '" + frmPacientes.telefono + "','" + frmPacientes.direccion + "');"

                                    ElseIf ver = 0 And ver2 = 1 Then

                                        Consulta = "INSERT INTO paciente (cedula, fecha_nacimiento, nombre, apellido, telefono, direccion_particular, direccion_trabajo) values('" + frmPacientes.cedula + "','" + frmPacientes.nac + "','" + frmPacientes.nombre + "', '" + frmPacientes.apellido + "', '" + frmPacientes.telefono + "','" + frmPacientes.direccion + "','" + frmPacientes.direTra + "');"
                                    ElseIf ver = 1 And ver2 = 0 Then

                                        Consulta = "INSERT INTO paciente (cedula, fecha_nacimiento, nombre, apellido, telefono, enviado_por, direccion_particular) values('" + frmPacientes.cedula + "','" + frmPacientes.nac + "','" + frmPacientes.nombre + "', '" + frmPacientes.apellido + "', '" + frmPacientes.telefono + "','" + frmPacientes.enviado + "','" + frmPacientes.direccion + "');"
                                    ElseIf ver = 1 And ver2 = 1 Then

                                        Consulta = "INSERT INTO paciente (cedula, fecha_nacimiento, nombre, apellido, telefono, enviado_por, direccion_particular, direccion_trabajo) values('" + frmPacientes.cedula + "','" + frmPacientes.nac + "','" + frmPacientes.nombre + "', '" + frmPacientes.apellido + "', '" + frmPacientes.telefono + "','" + frmPacientes.enviado + "','" + frmPacientes.direccion + "','" + frmPacientes.direTra + "');"
                                    End If


                                    consultar()

                                    MsgBox("Agregado con Exito", MsgBoxStyle.Information)

                                    Me.Dispose()
                                    frmPacientes.Show()
                                    frmPacientes.actTabla(1)
                                Catch ex As Exception
                                    MsgBox("Error al ingresar usuario", MsgBoxStyle.Exclamation)
                                End Try


                            End If
                        Else
                            frmPacientes.nombre = txbNombre.Text.ToUpper
                            frmPacientes.cedula = txbCedula.Text
                            frmPacientes.apellido = txbApellido.Text.ToUpper
                            If txbEnviadoPor.Text <> "" Then
                                ver = 1
                                frmPacientes.enviado = txbEnviadoPor.Text.ToUpper
                            End If
                            frmPacientes.telefono = txbTelefono.Text
                            frmPacientes.direccion = txbDireccionPersonal.Text.ToUpper

                            If txbDireccionTrabajo.Text <> "" Then
                                frmPacientes.direTra = txbDireccionTrabajo.Text.ToUpper
                                ver2 = 1
                            End If

                            frmPacientes.nac = mcFechaNacimiento.SelectionRange.Start.ToString("yyyy-MM-dd")


                            Try
                                If ver = 0 And ver2 = 0 Then
                                    Consulta = "INSERT INTO paciente (cedula, fecha_nacimiento, nombre, apellido, telefono, direccion_particular) values('" + frmPacientes.cedula + "','" + frmPacientes.nac + "','" + frmPacientes.nombre + "', '" + frmPacientes.apellido + "', '" + frmPacientes.telefono + "','" + frmPacientes.direccion + "');"

                                ElseIf ver = 0 And ver2 = 1 Then

                                    Consulta = "INSERT INTO paciente (cedula, fecha_nacimiento, nombre, apellido, telefono, direccion_particular, direccion_trabajo) values('" + frmPacientes.cedula + "','" + frmPacientes.nac + "','" + frmPacientes.nombre + "', '" + frmPacientes.apellido + "', '" + frmPacientes.telefono + "','" + frmPacientes.direccion + "','" + frmPacientes.direTra + "');"
                                ElseIf ver = 1 And ver2 = 0 Then

                                    Consulta = "INSERT INTO paciente (cedula, fecha_nacimiento, nombre, apellido, telefono, enviado_por, direccion_particular) values('" + frmPacientes.cedula + "','" + frmPacientes.nac + "','" + frmPacientes.nombre + "', '" + frmPacientes.apellido + "', '" + frmPacientes.telefono + "','" + frmPacientes.enviado + "','" + frmPacientes.direccion + "');"
                                ElseIf ver = 1 And ver2 = 1 Then

                                    Consulta = "INSERT INTO paciente (cedula, fecha_nacimiento, nombre, apellido, telefono, enviado_por, direccion_particular, direccion_trabajo) values('" + frmPacientes.cedula + "','" + frmPacientes.nac + "','" + frmPacientes.nombre + "', '" + frmPacientes.apellido + "', '" + frmPacientes.telefono + "','" + frmPacientes.enviado + "','" + frmPacientes.direccion + "','" + frmPacientes.direTra + "');"
                                End If


                                consultar()




                            Catch ex As Exception
                                MsgBox("Error al ingresar usuario", MsgBoxStyle.Exclamation)
                            End Try

                            Try
                                Consulta = "select id_p from paciente;"
                                consultar()

                                dgvPacientesId.DataSource = Tabla
                                id_p = dgvPacientesId.Rows(dgvPacientesId.RowCount - 1).Cells(0).Value


                                Consulta = "INSERT INTO antecedentes VALUES ('" + Str(id_p) + "','" + alergicos.GetHashCode.ToString + "','" + diabeticos.GetHashCode.ToString + "','" + cardiovasculares.GetHashCode.ToString + "','" + fiebre_reumatica.GetHashCode.ToString + "','" + coagulacion.GetHashCode.ToString + "','" + odontologicos.GetHashCode.ToString + "','" + farmacos_recibidos.GetHashCode.ToString + "','" + familiares.GetHashCode.ToString + "','" + tratamiento_medico.GetHashCode.ToString + "','" + observaciones + "');"
                                consultar()


                                MsgBox("Agregado con Exito", MsgBoxStyle.Information)

                                Me.Dispose()
                                frmPacientes.Show()
                                frmPacientes.actTabla(1)
                            Catch ex As Exception
                                MsgBox("Error al ingresar antecedentes", MsgBoxStyle.Exclamation)
                            End Try

                        End If
                    Else
                        MsgBox("Cédula no válida", MsgBoxStyle.Exclamation)
                    End If
                End If


            Else
                MsgBox("La cédula solo debe contener números", MsgBoxStyle.Exclamation)
                txbCedula.Clear()
            End If


        Else

            MsgBox("Complete los campos necesarios", MsgBoxStyle.Exclamation)

        End If


    End Sub

    Private Sub MonthCalendar1_DateChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles mcFechaNacimiento.DateChanged
        Dim nac As String = mcFechaNacimiento.SelectionRange.Start
        lblFechaSeleccionada.Text = "Fecha seleccionada " + nac
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim nac As String = mcFechaNacimiento.SelectionRange.Start
        lblFechaSeleccionada.Text = "Fecha seleccionada " + nac
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Dispose()
        frmPacientes.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarAntecedentes.Click
        Me.Hide()
        frmContenedor = frmAgregarAntecedentes
        frmContenedor.MdiParent = Menu_Inicio
        frmContenedor.Dock = DockStyle.Fill
        frmContenedor.Show()
    End Sub
    Private Function verificarCedula(ByVal cedula As String)

        If cedula.Length = 8 And IsNumeric(cedula) Then
            Try

                Dim cedulaChar(7) As Char
                Dim suma As Integer
                Dim calculo() As Integer = {2, 9, 8, 7, 6, 3, 4}

                cedulaChar = cedula.ToCharArray()

                For i = 0 To 6
                    Dim num1 As Integer = Val(cedulaChar(i))
                    suma = (num1 * calculo(i)) + suma
                Next

                cedulaChar = cedula.ToCharArray()

                Dim liResto As Integer = 10 - (suma Mod 10)

                If liResto = 10 Then
                    liResto = 0
                End If


                If liResto = Val(cedulaChar(7)) Then
                    Return True
                Else
                    Return False
                End If

            Catch ex As Exception

                Return False

            End Try

        Else

            Return False

        End If

    End Function

    Private Sub txbCedula_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txbCedula.TextChanged
        pbErrorCedula.Visible = True

        If verificarCedula(txbCedula.Text) = False Then

            pbErrorCedula.Image = My.Resources.X

        ElseIf verificarCedula(txbCedula.Text) = True Then
            pbErrorCedula.Image = My.Resources.checkmark
        End If
    End Sub

    Private Sub pbErrorCedula_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles pbErrorCedula.MouseEnter
        'If verificarCedula(txbCedula.Text) = False Then


        '    lblAnuncio.Location = New Point(Cursor.Position.X, Cursor.Position.Y)
        '    lblAnuncio.Visible = True
        '    lblAnuncio.Font = New Font("Microsoft Sans Serif", 18, FontStyle.Bold)
        '    lblAnuncio.Text = "Cédula no válida"


        'End If
    End Sub

    Private Sub btnAgregarEstadoDientes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Hide()
        frmContenedor = IngresarEstadoDientes
        frmContenedor.MdiParent = Menu_Inicio
        frmContenedor.Dock = DockStyle.Fill
        frmContenedor.Show()
    End Sub
End Class