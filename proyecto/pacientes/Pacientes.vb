Public Class Pacientes

    'EstadoPacientes es una variable utilizada para verificar si se muetran los pacientes activos o inactivos
    Dim EstadoPacientes As Integer = 1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIngresarPaciente.Click

        'Al presionar el boton btnAgregarPaciente, se oculta el formulario actual, se guarda el formulario Agregar_Paciente en el frmContenedor y se muestra
        Me.Hide()
        frmContenedor = Ingresar_Paciente
        frmContenedor.MdiParent = Menu_Inicio
        frmContenedor.Dock = DockStyle.Fill
        frmContenedor.Show()

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Cuando carga el formulario Paciente, se actualiza el dgbPacientes con los pacientes activos
        actTabla(1)

        'Establezco como debe cargar el txbBusqueda
        txbBusqueda.ForeColor = Color.Gray
        txbBusqueda.Text = "Buscar"
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificarDatos.Click

        'Al presionar el boton btnModificarDatos, se oculta el formulario actual, se guarda el formulario Modificar_Paciente en el frmContenedor y se muestra
        Me.Hide()
        frmContenedor = Modificar_Paciente
        frmContenedor.MdiParent = Menu_Inicio
        frmContenedor.Dock = DockStyle.Fill
        frmContenedor.Show()

    End Sub
    Public Sub actTabla(ByVal estado As String)

        'Al iniciarse el método, lo primero que hace es borrar el contenido de las variables
        cedula = ""
        nombre = ""
        id_p = 0
        nac = ""
        enviado = ""
        direccion = ""
        direTra = ""
        telefono = ""
        saldo = 0

        'Luego intenta obtener todos los datos de los pacientes con el estado según le indicamos en la base de datos
        Try
            Consulta = "SELECT * FROM paciente where estado = '" + estado + "';"
            consultar()
            dgbPacientes.DataSource = Tabla

            'Ocultamos todas las columnas que no nos interesa que el usuario visualice
            dgbPacientes.Columns(0).Visible = False
            dgbPacientes.Columns(2).Visible = False
            dgbPacientes.Columns(4).Visible = False
            dgbPacientes.Columns(5).Visible = False
            dgbPacientes.Columns(6).Visible = False
            dgbPacientes.Columns(7).Visible = False
            dgbPacientes.Columns(8).Visible = False
            dgbPacientes.Columns(9).Visible = False

            'Cambiamos los encabezados de las columnas restantes por estetica y practicidad
            dgbPacientes.Columns(1).HeaderText = "Cédula"
            dgbPacientes.Columns(3).HeaderText = "Nombre"

        Catch ex As Exception

            'Si es que se encuentra un error, que se muestre una alerta
            MsgBox("Error al obtener los pacientes", MsgBoxStyle.Exclamation)

        End Try

        'Ocultamos los botones que requieren que un usuario este seleccionado y subrimos la informacion personal con el panel pnlTapa
        pnlTapa.Visible = True
        lblCartel.Visible = True
        btnCambiarEstado.Visible = False
        btnModificarDatos.Visible = False
        btnRegistrarCita.Visible = False
        btnRegistroMedico.Visible = False
        btnRealizarPago.Visible = False

        If estado = 0 Then
            btnIngresarPaciente.Visible = False
        Else
            btnIngresarPaciente.Visible = True
        End If

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCambiarEstado.Click

        'Al precionar el boton btnCambiarEstado, obtenemos la id del paciente previamente seleccionado
        id_p = dgbPacientes.CurrentRow.Cells(0).Value

        'Si el estado del paciente es activo
        If EstadoPacientes = 1 Then

            'Consultar si desea realmente volverlo inactivo
            If MsgBox("¿Seguro que desea volver inactivo al paciente " + dgbPacientes.CurrentRow.Cells(3).Value + " con la cedula " + dgbPacientes.CurrentRow.Cells(1).Value + "?", MsgBoxStyle.YesNo) = vbYes Then

                'Si es así, intentamos actualizar la informacion del paciente en la base de datos cambiando el campo estado
                Try
                    Consulta = "update paciente set estado = 0 where id_p = '" + Str(id_p) + "';"
                    consultar()

                    'Si no hay excepciones, que notifique que el cambio ha sido realizado
                    MsgBox("Actualizado", MsgBoxStyle.Information)

                    'Actualizamos la tabla mostrando solo los pacientes activos
                    actTabla(1)

                Catch ex As Exception

                    'En el caso que de algun error que se muestre un alerta
                    MsgBox("Error al cambiar es estado del paciente", MsgBoxStyle.Exclamation)

                End Try

            Else

                'En el caso de poner que no, que se muestre un aviso de que no se ha modificado nada
                MsgBox("Ningún cambio fue realizado", MsgBoxStyle.Information)

            End If

        Else 'Si el estado del paciente es inactivo

            'Consultamos si desea realmente volverlo activo
            If MsgBox("¿Seguro que desea volver activo al paciente con la cedula " + dgbPacientes.CurrentRow.Cells(1).Value + "?", MsgBoxStyle.YesNo) = vbYes Then

                'Si es así, intentamos actualizar la informacion del paciente en la base de datos cambiando el campo estado
                Try
                    Consulta = "update paciente set estado = 1 where id_p = '" + Str(id_p) + "';"
                    consultar()

                    'Si no hay excepciones, que notifique que el cambio ha sido realizado
                    MsgBox("Actualizado", MsgBoxStyle.Information)

                    'Actualizamos la tabla mostrando solo los pacientes inactivos
                    actTabla(0)

                Catch ex As Exception

                    'En el caso que de algun error que se muestre un alerta
                    MsgBox("Error al cambiar es estado del paciente", MsgBoxStyle.Exclamation)

                End Try

            Else

                'En el caso de poner que no, que se muestre un aviso de que no se ha modificado nada
                MsgBox("Ningún cambio fue realizado", MsgBoxStyle.Information)

            End If

        End If

    End Sub
    Public Sub actPanel()

        'Hacemos invisible el panel y el label 
        pnlTapa.Hide()
        lblCartel.Hide()

        'Hacemos visible los botones
        btnModificarDatos.Show()
        btnCambiarEstado.Show()
        btnRegistrarCita.Show()
        btnMostrarAntecedentes.Show()
        btnRegistroMedico.Show()
        btnRealizarPago.Show()


        'Guardamos en las variables los datos acordes
        id_p = dgbPacientes.CurrentRow.Cells(0).Value
        cedula = dgbPacientes.CurrentRow.Cells(1).Value
        nombre = dgbPacientes.CurrentRow.Cells(3).Value
        nac = dgbPacientes.CurrentRow.Cells(2).Value
        telefono = dgbPacientes.CurrentRow.Cells(4).Value

        If IsDBNull(dgbPacientes.CurrentRow.Cells(5).Value) Then
            enviado = "No definido"
        Else
            enviado = dgbPacientes.CurrentRow.Cells(5).Value
        End If

        direccion = dgbPacientes.CurrentRow.Cells(6).Value

        If IsDBNull(dgbPacientes.CurrentRow.Cells(7).Value) Then
            direTra = "No definido"
        Else
            direTra = dgbPacientes.CurrentRow.Cells(7).Value
        End If

        saldo = dgbPacientes.CurrentRow.Cells(8).Value

        Consulta = "select p.id_p, count(*) from paciente p inner join cita c on p.id_p = c.id_p where c.realizada = 1 and p.id_p = '" + id_p.ToString + "' group by p.id_p;"
        consultar()
        dgbFiltro.DataSource = Tabla

        Dim numCitas As Integer = 0

        If dgbFiltro.RowCount = 1 Then
            numCitas = dgbFiltro.Rows(0).Cells(1).Value
        End If

        If dgbPacientes.CurrentRow.Cells(9).Value = True Then
            lblEstado.Text = "Activo"
            lblEstado.ForeColor = Color.Green
        Else
            lblEstado.Text = "Inactivo"
            lblEstado.ForeColor = Color.Red
        End If




        'Mostramos en Panel
        lblCedula.Text = cedula
        lblNombre.Text = nombre
        lblFechaNacimiento.Text = nac
        lblEnviadoPor.Text = enviado
        lblDireccionParticular.Text = direccion
        lblDireccionTrabajo.Text = direTra
        lblNumeroCitasAtendidas.Text = numCitas
        lblSaldoPendiente.Text = "$" + saldo.ToString
        lblTelefono.Text = telefono

    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistrarCita.Click

        'Al presionar el boton btnRegistrarCita, se oculta el formulario actual, se guarda el formulario Crear_Cita en el frmContenedor y se muestra
        Me.Hide()
        frmContenedor = Crear_Cita
        frmContenedor.MdiParent = Menu_Inicio
        frmContenedor.Dock = DockStyle.Fill
        frmContenedor.Show()

        Crear_Cita.dgbCitasEnLaFecha.ClearSelection()
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txbBusqueda.TextChanged

        'Cuando el contenido de txbBusqueda cambia, guardamos lo ingresado en la variable busqueda
        Dim busqueda As String = txbBusqueda.Text

        'Si el txbBusqueda es igual a 'Buscar' y es de color Gris
        If txbBusqueda.Text = "Buscar" And txbBusqueda.ForeColor = Color.Gray Then

            'Que actualice el dgbPaciente simplemente
            actTabla(EstadoPacientes)

        Else 'Si no

            'Intentamos obtener los pacientes que cumplan con las condición
            Try

                Consulta = "Select * from paciente where estado = '" + EstadoPacientes.ToString + "' and (nombre like '" + busqueda + "%' or cedula like '" + busqueda + "%' );"

                consultar()
                dgbPacientes.DataSource = Tabla

            Catch ex As Exception

                'Si se genera una excepción que se muestre una alerta
                MsgBox("Error al buscar los pacientes", MsgBoxStyle.Exclamation)

            End Try

        End If

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistroMedico.Click

        'Al presionar el boton btnRegistroMedico, se oculta el formulario actual, se guarda el formulario Registro_Medico en el frmContenedor y se muestra
        Me.Hide()
        frmContenedor = Registro_Medico
        frmContenedor.MdiParent = Menu_Inicio
        frmContenedor.Dock = DockStyle.Fill
        frmContenedor.Show()

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMostrarAntecedentes.Click

        'Al presionar el boton btnMostrarAntecedentes, se oculta el formulario actual, se guarda el formulario Antecedentes en el frmContenedor y se muestra
        Me.Hide()
        frmContenedor = Antecedentes
        frmContenedor.MdiParent = Menu_Inicio
        frmContenedor.Dock = DockStyle.Fill
        frmContenedor.Show()

    End Sub

    Private Sub DataGridView1_CellClick1(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgbPacientes.CellClick

        'Cuando un campo del dgvPacientes es seleccionado, el valor de la columna 0 de la fila la cual contiene el campo seleccionado es guardado en id_p
        id_p = dgbPacientes.CurrentRow.Cells(0).Value

        'Luego actualizamos el Panel
        actPanel()

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRealizarPago.Click

        'Al presionar el boton btnRealizarPago, se oculta el formulario actual, se guarda el formulario InputPago en el frmContenedor y se muestra
        frmContenedor = InputPago
        frmContenedor.MdiParent = Menu_Inicio
        frmContenedor.Dock = DockStyle.Fill
        frmContenedor.Show()

    End Sub


    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCambiarPacientes.Click

        'Si el estado de los pacientes que se mostraba antes del click era activo
        If EstadoPacientes = 1 Then

            'Actualizamos la tabla con pacientes inactivos
            actTabla(0)

            'Cambiamos lo que dice el boton btnCambiarPacientes y el boton btnCambiarEstado para que sea acorde
            btnCambiarPacientes.Text = "Mostrar Pacientes Activos"
            btnCambiarEstado.Text = "Volver" + vbNewLine + " Activo"

            'Indicamos que los pacientes mostrados son inactivos
            EstadoPacientes = 0

        Else 'Si el estado de los pacientes que se mostraba antes del click era inactivo

            'Actualizamos la tabla con pacientes activos
            actTabla(1)

            'Cambiamos lo que dice el boton btnCambiarPacientes y el boton btnCambiarEstado para que sea acorde
            btnCambiarEstado.Text = "Volver " + vbNewLine + "Inactivo"
            btnCambiarPacientes.Text = "Mostrar Pacientes Inactivos"

            'Indicamos que los pacientes mostrados son activos
            EstadoPacientes = 1

        End If

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
            actTabla(EstadoPacientes)

            'Si la tecla presionada es borrar y todo el texto esta seleccionado
        ElseIf e.KeyCode = Keys.Back And txbBusqueda.SelectedText = txbBusqueda.Text Then

            'Introduzco el texto 'Buscar' al txbBusqueda de color Gris
            txbBusqueda.Text = "Buscar"
            txbBusqueda.ForeColor = Color.Gray
            actTabla(EstadoPacientes)

        End If
    End Sub

    Private Sub txbBusqueda_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txbBusqueda.LostFocus
        If txbBusqueda.Text.Length = 0 Or (txbBusqueda.Text = "Buscar" And txbBusqueda.ForeColor = Color.Gray) Then
            txbBusqueda.ForeColor = Color.Gray
            txbBusqueda.Text = "Buscar"
            actTabla(EstadoPacientes)
        End If
    End Sub


End Class
