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

        If txbNombre.Text <> "" And txbNombre.ForeColor <> Color.Gray And txbCedula.Text <> "" And txbCedula.ForeColor <> Color.Gray And txbDireccionPersonal.Text <> "" And txbDireccionPersonal.ForeColor <> Color.Gray And txbTelefono.Text <> "" And txbTelefono.ForeColor <> Color.Gray And txbApellido.Text <> "" And txbApellido.ForeColor <> Color.Gray Then
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

            End If


        Else

            MsgBox("Complete los campos necesarios", MsgBoxStyle.Exclamation)

        End If


    End Sub

    Private Sub MonthCalendar1_DateChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles mcFechaNacimiento.DateChanged
        Dim nac As String = mcFechaNacimiento.SelectionRange.Start
        lblFechaSeleccionada.Text = "Fecha seleccionada " + nac
        epCedula.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
        epCedula.BlinkRate = 200
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Establezco como debe cargar el txbBusqueda
        txbNombre.ForeColor = Color.Gray
        txbNombre.Text = "Ej: Juan"
        txbApellido.ForeColor = Color.Gray
        txbApellido.Text = "Ej: Perez"
        'Establezco como debe cargar el txbBusqueda
        txbCedula.ForeColor = Color.Gray
        txbCedula.Text = "Ej: 49733746"
        txbTelefono.ForeColor = Color.Gray
        txbTelefono.Text = "Ej: 098123745"
        txbEnviadoPor.Text = "Ej: Un familiar"
        txbEnviadoPor.ForeColor = Color.Gray
        txbDireccionPersonal.Text = "Ej: Brasil 633"
        txbDireccionPersonal.ForeColor = Color.Gray
        txbDireccionTrabajo.Text = "Ej: Varela 2446"
        txbDireccionTrabajo.ForeColor = Color.Gray


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
        frmContenedor.MdiParent = frmMenuInicio
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


        If verificarCedula(txbCedula.Text) = False And txbCedula.ForeColor <> Color.Gray Then


            epCedula.SetError(txbCedula, "No es una cedula válida")

        ElseIf verificarCedula(txbCedula.Text) = True Then

            epCedula.SetError(txbCedula, "")
        End If
    End Sub

    Private Sub btnAgregarEstadoDientes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Hide()
        frmContenedor = pnlfondo
        frmContenedor.MdiParent = frmMenuInicio
        frmContenedor.Dock = DockStyle.Fill
        frmContenedor.Show()
    End Sub

    Private Sub txbTelefono_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txbTelefono.TextChanged
        If IsNumeric(txbTelefono.Text) Or txbTelefono.ForeColor = Color.Gray Then
            epTelefono.SetError(txbTelefono, "")
        Else
            epTelefono.SetError(txbTelefono, "El teléfono solo debe contener números")
        End If
    End Sub
    Private Sub txbNombre_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txbNombre.Click

        'Si el contenido de txbNombre es Buscar y de color gris
        If txbNombre.Text = "Ej: Juan" And txbNombre.ForeColor = Color.Gray Then

            'El cursos se ubique al inicio
            Me.txbNombre.SelectionStart = 0

        End If

    End Sub

    Private Sub txbNombre_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txbNombre.GotFocus

        'Si el contenido de txbNombre es Buscar y de color gris
        If txbNombre.Text = "Ej: Juan" And txbNombre.ForeColor = Color.Gray Then

            'El cursos se ubique al inicio
            txbNombre.SelectionStart = 0

        End If

    End Sub

    Private Sub txbNombre_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txbNombre.KeyDown

        'Si el contenido de txbNombre es Buscar, de color gris y la tecla presionada no es 
        If txbNombre.Text = "Ej: Juan" And txbNombre.ForeColor = Color.Gray And Not e.KeyCode = Keys.Back Then

            'Borrar el contenido del txbNombre y volver el color negro
            txbNombre.Text = ""
            txbNombre.ForeColor = Color.Black


            'Si txbNombre solo tiene una letra y la tecla presionada fue borrar, 
        ElseIf e.KeyCode = Keys.Back And txbNombre.Text.Length = 1 Then

            'Introduzco el texto 'Buscar' al txbNombre de color Gris
            txbNombre.Text = "Ej: Juan"
            txbNombre.ForeColor = Color.Gray


            'Si la tecla presionada es borrar y todo el texto esta seleccionado
        ElseIf e.KeyCode = Keys.Back And txbNombre.SelectedText = txbNombre.Text Then

            'Introduzco el texto 'Buscar' al txbNombre de color Gris
            txbNombre.Text = "Ej: Juan"
            txbNombre.ForeColor = Color.Gray


        End If
    End Sub
    Private Sub txbCedula_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txbCedula.Click

        'Si el contenido de txbNombre es Buscar y de color gris
        If txbCedula.Text = "Ej: 49733746" And txbCedula.ForeColor = Color.Gray Then

            'El cursos se ubique al inicio
            Me.txbCedula.SelectionStart = 0

        End If

    End Sub

    Private Sub txbCedula_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txbCedula.GotFocus

        'Si el contenido de txbNombre es Buscar y de color gris
        If txbCedula.Text = "Ej: 49733746" And txbCedula.ForeColor = Color.Gray Then

            'El cursos se ubique al inicio
            txbCedula.SelectionStart = 0

        End If

    End Sub

    Private Sub txbCedula_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txbCedula.KeyDown

        'Si el contenido de txbNombre es Buscar, de color gris y la tecla presionada no es 
        If txbCedula.Text = "Ej: 49733746" And txbNombre.ForeColor = Color.Gray And Not e.KeyCode = Keys.Back Then

            'Borrar el contenido del txbNombre y volver el color negro
            txbCedula.Text = ""
            txbCedula.ForeColor = Color.Black


            'Si txbNombre solo tiene una letra y la tecla presionada fue borrar, 
        ElseIf e.KeyCode = Keys.Back And txbCedula.Text.Length = 1 Then

            'Introduzco el texto 'Buscar' al txbNombre de color Gris
            txbCedula.Text = "Ej: 49733746"
            txbCedula.ForeColor = Color.Gray


            'Si la tecla presionada es borrar y todo el texto esta seleccionado
        ElseIf e.KeyCode = Keys.Back And txbCedula.SelectedText = txbCedula.Text Then

            'Introduzco el texto 'Buscar' al txbNombre de color Gris
            txbCedula.Text = "Ej: 49733746"
            txbCedula.ForeColor = Color.Gray


        End If
    End Sub
    '-----------------------------------------apellido----------------------------------------------
    Private Sub txbApellido_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txbApellido.Click

        'Si el contenido de txbNombre es Buscar y de color gris
        If txbApellido.Text = "Ej: Perez" And txbApellido.ForeColor = Color.Gray Then

            'El cursos se ubique al inicio
            Me.txbApellido.SelectionStart = 0

        End If

    End Sub

    Private Sub txbApellido_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txbApellido.GotFocus

        'Si el contenido de txbNombre es Buscar y de color gris
        If txbApellido.Text = "Ej: Perez" And txbApellido.ForeColor = Color.Gray Then

            'El cursos se ubique al inicio
            txbApellido.SelectionStart = 0

        End If

    End Sub

    Private Sub txbApellido_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txbApellido.KeyDown

        'Si el contenido de txbNombre es Buscar, de color gris y la tecla presionada no es 
        If txbApellido.Text = "Ej: Perez" And txbNombre.ForeColor = Color.Gray And Not e.KeyCode = Keys.Back Then

            'Borrar el contenido del txbNombre y volver el color negro
            txbApellido.Text = ""
            txbApellido.ForeColor = Color.Black


            'Si txbNombre solo tiene una letra y la tecla presionada fue borrar, 
        ElseIf e.KeyCode = Keys.Back And txbApellido.Text.Length = 1 Then

            'Introduzco el texto 'Buscar' al txbNombre de color Gris
            txbApellido.Text = "Ej: Perez"
            txbApellido.ForeColor = Color.Gray


            'Si la tecla presionada es borrar y todo el texto esta seleccionado
        ElseIf e.KeyCode = Keys.Back And txbApellido.SelectedText = txbApellido.Text Then

            'Introduzco el texto 'Buscar' al txbNombre de color Gris
            txbApellido.Text = "Ej: Perez"
            txbApellido.ForeColor = Color.Gray


        End If
    End Sub
    '-----------------------------------------telefono----------------------------------------------
    Private Sub txbTelefono_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txbTelefono.Click

        'Si el contenido de txbNombre es Buscar y de color gris
        If txbTelefono.Text = "Ej: 098123745" And txbTelefono.ForeColor = Color.Gray Then

            'El cursos se ubique al inicio
            Me.txbTelefono.SelectionStart = 0

        End If

    End Sub

    Private Sub txbTelefono_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txbTelefono.GotFocus

        'Si el contenido de txbNombre es Buscar y de color gris
        If txbTelefono.Text = "Ej: 098123745" And txbTelefono.ForeColor = Color.Gray Then

            'El cursos se ubique al inicio
            txbTelefono.SelectionStart = 0

        End If

    End Sub

    Private Sub txbTelefono_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txbTelefono.KeyDown

        'Si el contenido de txbNombre es Buscar, de color gris y la tecla presionada no es 
        If txbTelefono.Text = "Ej: 098123745" And txbNombre.ForeColor = Color.Gray And Not e.KeyCode = Keys.Back Then

            'Borrar el contenido del txbNombre y volver el color negro
            txbTelefono.Text = ""
            txbTelefono.ForeColor = Color.Black


            'Si txbNombre solo tiene una letra y la tecla presionada fue borrar, 
        ElseIf e.KeyCode = Keys.Back And txbTelefono.Text.Length = 1 Then

            'Introduzco el texto 'Buscar' al txbNombre de color Gris
            txbTelefono.Text = "Ej: 098123745"
            txbTelefono.ForeColor = Color.Gray


            'Si la tecla presionada es borrar y todo el texto esta seleccionado
        ElseIf e.KeyCode = Keys.Back And txbTelefono.SelectedText = txbTelefono.Text Then

            'Introduzco el texto 'Buscar' al txbNombre de color Gris
            txbTelefono.Text = "Ej: 098123745"
            txbTelefono.ForeColor = Color.Gray


        End If
    End Sub
    '-----------------------------------------enviado_por----------------------------------------------
    Private Sub txbEnviadoPor_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txbEnviadoPor.Click

        'Si el contenido de txbNombre es Buscar y de color gris
        If txbEnviadoPor.Text = "Ej: Un familiar" And txbEnviadoPor.ForeColor = Color.Gray Then

            'El cursos se ubique al inicio
            Me.txbEnviadoPor.SelectionStart = 0

        End If

    End Sub

    Private Sub txbEnviadoPor_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txbEnviadoPor.GotFocus

        'Si el contenido de txbNombre es Buscar y de color gris
        If txbEnviadoPor.Text = "Ej: Un familiar" And txbEnviadoPor.ForeColor = Color.Gray Then

            'El cursos se ubique al inicio
            txbEnviadoPor.SelectionStart = 0

        End If

    End Sub

    Private Sub txbEnviadoPor_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txbEnviadoPor.KeyDown

        'Si el contenido de txbNombre es Buscar, de color gris y la tecla presionada no es 
        If txbEnviadoPor.Text = "Ej: Un familiar" And txbNombre.ForeColor = Color.Gray And Not e.KeyCode = Keys.Back Then

            'Borrar el contenido del txbNombre y volver el color negro
            txbEnviadoPor.Text = ""
            txbEnviadoPor.ForeColor = Color.Black


            'Si txbNombre solo tiene una letra y la tecla presionada fue borrar, 
        ElseIf e.KeyCode = Keys.Back And txbEnviadoPor.Text.Length = 1 Then

            'Introduzco el texto 'Buscar' al txbNombre de color Gris
            txbEnviadoPor.Text = "Ej: Un familiar"
            txbEnviadoPor.ForeColor = Color.Gray


            'Si la tecla presionada es borrar y todo el texto esta seleccionado
        ElseIf e.KeyCode = Keys.Back And txbEnviadoPor.SelectedText = txbEnviadoPor.Text Then

            'Introduzco el texto 'Buscar' al txbNombre de color Gris
            txbEnviadoPor.Text = "Ej: Un familiar"
            txbEnviadoPor.ForeColor = Color.Gray


        End If
    End Sub
    '-----------------------------------------direccion_per----------------------------------------------
    Private Sub txbDireccionPersonal_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txbDireccionPersonal.Click

        'Si el contenido de txbNombre es Buscar y de color gris
        If txbDireccionPersonal.Text = "Ej: Brasil 633" And txbDireccionPersonal.ForeColor = Color.Gray Then

            'El cursos se ubique al inicio
            Me.txbDireccionPersonal.SelectionStart = 0

        End If

    End Sub

    Private Sub txbDireccionPersonal_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txbDireccionPersonal.GotFocus

        'Si el contenido de txbNombre es Buscar y de color gris
        If txbDireccionPersonal.Text = "Ej: Brasil 633" And txbDireccionPersonal.ForeColor = Color.Gray Then

            'El cursos se ubique al inicio
            txbDireccionPersonal.SelectionStart = 0

        End If

    End Sub

    Private Sub txbDireccionPersonal_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txbDireccionPersonal.KeyDown

        'Si el contenido de txbNombre es Buscar, de color gris y la tecla presionada no es 
        If txbDireccionPersonal.Text = "Ej: Brasil 633" And txbNombre.ForeColor = Color.Gray And Not e.KeyCode = Keys.Back Then

            'Borrar el contenido del txbNombre y volver el color negro
            txbDireccionPersonal.Text = ""
            txbDireccionPersonal.ForeColor = Color.Black


            'Si txbNombre solo tiene una letra y la tecla presionada fue borrar, 
        ElseIf e.KeyCode = Keys.Back And txbDireccionPersonal.Text.Length = 1 Then

            'Introduzco el texto 'Buscar' al txbNombre de color Gris
            txbDireccionPersonal.Text = "Ej: Brasil 633"
            txbDireccionPersonal.ForeColor = Color.Gray


            'Si la tecla presionada es borrar y todo el texto esta seleccionado
        ElseIf e.KeyCode = Keys.Back And txbDireccionPersonal.SelectedText = txbDireccionPersonal.Text Then

            'Introduzco el texto 'Buscar' al txbNombre de color Gris
            txbDireccionPersonal.Text = "Ej: Brasil 633"
            txbDireccionPersonal.ForeColor = Color.Gray


        End If
    End Sub
    '-----------------------------------------direccion_tra----------------------------------------------
    Private Sub txbDireccionTrabajo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txbDireccionTrabajo.Click

        'Si el contenido de txbNombre es Buscar y de color gris
        If txbDireccionTrabajo.Text = "Ej: Varela 2446" And txbDireccionTrabajo.ForeColor = Color.Gray Then

            'El cursos se ubique al inicio
            Me.txbDireccionTrabajo.SelectionStart = 0

        End If

    End Sub

    Private Sub txbDireccionTrabajo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txbDireccionTrabajo.GotFocus

        'Si el contenido de txbNombre es Buscar y de color gris
        If txbDireccionTrabajo.Text = "Ej: Varela 2446" And txbDireccionTrabajo.ForeColor = Color.Gray Then

            'El cursos se ubique al inicio
            txbDireccionTrabajo.SelectionStart = 0

        End If

    End Sub

    Private Sub txbDireccionTrabajo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txbDireccionTrabajo.KeyDown

        'Si el contenido de txbNombre es Buscar, de color gris y la tecla presionada no es 
        If txbDireccionTrabajo.Text = "Ej: Varela 2446" And txbNombre.ForeColor = Color.Gray And Not e.KeyCode = Keys.Back Then

            'Borrar el contenido del txbNombre y volver el color negro
            txbDireccionTrabajo.Text = ""
            txbDireccionTrabajo.ForeColor = Color.Black


            'Si txbNombre solo tiene una letra y la tecla presionada fue borrar, 
        ElseIf e.KeyCode = Keys.Back And txbDireccionTrabajo.Text.Length = 1 Then

            'Introduzco el texto 'Buscar' al txbNombre de color Gris
            txbDireccionTrabajo.Text = "Ej: Varela 2446"
            txbDireccionTrabajo.ForeColor = Color.Gray


            'Si la tecla presionada es borrar y todo el texto esta seleccionado
        ElseIf e.KeyCode = Keys.Back And txbDireccionTrabajo.SelectedText = txbDireccionTrabajo.Text Then

            'Introduzco el texto 'Buscar' al txbNombre de color Gris
            txbDireccionTrabajo.Text = "Ej: Varela 2446"
            txbDireccionTrabajo.ForeColor = Color.Gray


        End If
    End Sub

 
End Class