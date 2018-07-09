Public Class Agregar_Paciente


    Dim formu As New Form

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
    Public obs As String
    '///////////////////////////////////////////////////////////////////////////////////


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        direTra = ""
        enviado = ""
        Dim ver As Integer = 0
        Dim ver2 As Integer = 0
        If TextBox1.Text <> "" And TextBox2.Text <> "" And TextBox4.Text <> "" Then
            If alergicos = False And diabeticos = False And cardiovasculares = False And fiebre_reumatica = False And coagulacion = False And odontologicos = False And farmacos_recibidos = False And familiares = False And tratamiento_medico = False And obs = "" Then
                If MsgBox("No fue ingresado ningún antecedente," + vbNewLine + "¿Desea continuar de todos modos?", MsgBoxStyle.YesNo) = vbYes Then

                    nombre = TextBox1.Text
                    cedula = TextBox2.Text
                    If TextBox3.Text <> "" Then
                        ver = 1
                        enviado = TextBox3.Text
                    End If

                    direccion = TextBox4.Text

                    If TextBox5.Text <> "" Then
                        direTra = TextBox5.Text
                        ver2 = 1
                    End If

                    nac = MonthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd")


                    If ver = 0 And ver2 = 0 Then
                        Consulta = "INSERT INTO paciente (cedula, fecha_nacimiento, nombre, direccion_particular) values('" + cedula + "','" + nac + "','" + nombre + "','" + direccion + "');"
                    ElseIf ver = 0 And ver2 = 1 Then
                        Consulta = "INSERT INTO paciente (cedula, fecha_nacimiento, nombre, direccion_particular, direccion_trabajo) values('" + cedula + "','" + nac + "','" + nombre + "','" + direccion + "','" + direTra + "');"
                    ElseIf ver = 1 And ver2 = 0 Then
                        Consulta = "INSERT INTO paciente (cedula, fecha_nacimiento, nombre, enviado_por, direccion_particular) values('" + cedula + "','" + nac + "','" + nombre + "','" + enviado + "','" + direccion + "');"
                    ElseIf ver = 1 And ver2 = 1 Then
                        Consulta = "INSERT INTO paciente (cedula, fecha_nacimiento, nombre, enviado_por, direccion_particular, direccion_trabajo) values('" + cedula + "','" + nac + "','" + nombre + "','" + enviado + "','" + direccion + "','" + direTra + "');"
                    End If


                    consultar()

                    MsgBox("Agregado con Exito")

                    Me.Dispose()
                    Pacientes.Show()
                    Pacientes.actTabla()

                End If
            Else
                nombre = TextBox1.Text
                cedula = TextBox2.Text
                If TextBox3.Text <> "" Then
                    ver = 1
                    enviado = TextBox3.Text
                End If

                direccion = TextBox4.Text

                If TextBox5.Text <> "" Then
                    direTra = TextBox5.Text
                    ver2 = 1
                End If

                nac = MonthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd")


                If ver = 0 And ver2 = 0 Then
                    Consulta = "INSERT INTO paciente (cedula, fecha_nacimiento, nombre, direccion_particular) values('" + cedula + "','" + nac + "','" + nombre + "','" + direccion + "');"
                ElseIf ver = 0 And ver2 = 1 Then
                    Consulta = "INSERT INTO paciente (cedula, fecha_nacimiento, nombre, direccion_particular, direccion_trabajo) values('" + cedula + "','" + nac + "','" + nombre + "','" + direccion + "','" + direTra + "');"
                ElseIf ver = 1 And ver2 = 0 Then
                    Consulta = "INSERT INTO paciente (cedula, fecha_nacimiento, nombre, enviado_por, direccion_particular) values('" + cedula + "','" + nac + "','" + nombre + "','" + enviado + "','" + direccion + "');"
                ElseIf ver = 1 And ver2 = 1 Then
                    Consulta = "INSERT INTO paciente (cedula, fecha_nacimiento, nombre, enviado_por, direccion_particular, direccion_trabajo) values('" + cedula + "','" + nac + "','" + nombre + "','" + enviado + "','" + direccion + "','" + direTra + "');"
                End If


                consultar()

                Consulta = "select id_p from paciente;"
                consultar()

                DataGridView1.DataSource = Tabla
                id_p = DataGridView1.Rows(DataGridView1.RowCount - 1).Cells(0).Value

               
                Consulta = "INSERT INTO antecedentes VALUES ('" + Str(id_p) + "','" + alergicos.GetHashCode.ToString + "','" + diabeticos.GetHashCode.ToString + "','" + cardiovasculares.GetHashCode.ToString + "','" + fiebre_reumatica.GetHashCode.ToString + "','" + coagulacion.GetHashCode.ToString + "','" + odontologicos.GetHashCode.ToString + "','" + farmacos_recibidos.GetHashCode.ToString + "','" + familiares.GetHashCode.ToString + "','" + tratamiento_medico.GetHashCode.ToString + "','" + obs + "');"
                consultar()


                MsgBox("Agregado con Exito")

                Me.Dispose()
                Pacientes.Show()
                Pacientes.actTabla()
            End If
            
        Else

            MsgBox("complete los campos necesarios")

        End If


    End Sub

    Private Sub MonthCalendar1_DateChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles MonthCalendar1.DateChanged
        Dim nac As String = MonthCalendar1.SelectionRange.Start
        Label7.Text = "Fecha seleccionada " + nac
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        actPos()
        Me.Size = New System.Drawing.Size(880, 580)
        Dim nac As String = MonthCalendar1.SelectionRange.Start
        Label7.Text = "Fecha seleccionada " + nac
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Dispose()
        Pacientes.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Hide()
        formu = Agregar_Antecedentes
        formu.MdiParent = Menu_Inicio
        formu.Dock = DockStyle.Fill
        formu.Show()
    End Sub
End Class