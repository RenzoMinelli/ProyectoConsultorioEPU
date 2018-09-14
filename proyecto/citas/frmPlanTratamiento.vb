Public Class frmPlanTratamiento
    Dim id_Arancel As Integer
    Dim listaID_R As New List(Of Integer)
    Dim descEsp As String
    Dim dt As DataTable

    Private Sub PlanTratamiento_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        txbBusqueda.ForeColor = Color.Gray
        txbBusqueda.Text = "Buscar"

        actAranceles()
        actArancelesSelect()

    End Sub

    Private Sub dgvAranceles_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgvAranceles.MouseDoubleClick

        Dim id_a As Integer = dgvAranceles.CurrentRow.Cells(0).Value

        Try
            Consulta = "Select id_a, descripcion as 'Descripcion', costo as 'Precio' from aranceles where id_a = '" + id_a.ToString + "';"
            consultar()
            dgvAuxiliar.DataSource = Tabla


            dgvArancelesSelect.Columns(0).HeaderText = "id_a"
            dgvArancelesSelect.Columns(1).HeaderText = "Descripcion"
            dgvArancelesSelect.Columns(2).HeaderText = "Precio"
            dgvArancelesSelect.Columns(3).HeaderText = "Descripcion especifica"
            dgvArancelesSelect.Columns(4).HeaderText = "id_pl"

            dgvArancelesSelect.Columns(0).Visible = False
            dgvArancelesSelect.Columns(4).Visible = False

            MuestraMsgBoxVersatil("Ingrese descripcion especifica para el Arancel", 1)

            dt.Rows.Add(dgvAuxiliar.Rows(0).Cells(0).Value, dgvAuxiliar.Rows(0).Cells(1).Value, dgvAuxiliar.Rows(0).Cells(2).Value, respString, 0)

        Catch ex As Exception
            MsgBox("Error al pasar los aranceles", MsgBoxStyle.Exclamation)
        End Try

    End Sub

    Private Sub dgvArancelesSelect_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvArancelesSelect.CellClick

        id_Arancel = dgvArancelesSelect.CurrentRow.Cells(0).Value
        descEsp = dgvArancelesSelect.CurrentRow.Cells(3).Value

        btnEliminar.Visible = True
        btnModificarPrecio.Visible = True
        btnIngresarDesc.Visible = True


    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        descEsp = dgvArancelesSelect.CurrentRow.Cells(3).Value

        For x = 0 To dgvArancelesSelect.RowCount - 1

            If dgvArancelesSelect.Rows(x).Cells(0).Value = id_Arancel And dgvArancelesSelect.Rows(x).Cells(3).Value = descEsp Then

                If dgvArancelesSelect.Rows(x).Cells(4).Value <> 0 Then

                    MsgBox("No puede borrar aranceles previamente ingresados, " + vbNewLine + "solo puede modificar su precio o descripcion", MsgBoxStyle.Exclamation)

                Else
                    dgvArancelesSelect.Rows.RemoveAt(x)
                End If


                Exit For

            End If
        Next
        If dgvArancelesSelect.RowCount = 0 Then

            btnEliminar.Visible = False
            btnModificarPrecio.Visible = False
            btnIngresarDesc.Visible = False

        End If
    End Sub

    Private Sub btnModificarPrecio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificarPrecio.Click

        Do
            MuestraMsgBoxVersatil("Ingrese el nuevo costo del Arancel", 1)
            If respString = "" Or IsNumeric(respString) Then

                If respString = "" Then
                    dgvArancelesSelect.CurrentRow.Cells(2).Value = "0"
                    respString = "0"
                    Exit Do
                Else
                    dgvArancelesSelect.CurrentRow.Cells(2).Value = respString
                    Exit Do
                End If
            End If

            MsgBox("Debe ingresar solo números", MsgBoxStyle.Exclamation)
        Loop While Not IsNumeric(respString)




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
            actAranceles()

            'Si la tecla presionada es borrar y todo el texto esta seleccionado
        ElseIf e.KeyCode = Keys.Back And txbBusqueda.SelectedText = txbBusqueda.Text Then

            'Introduzco el texto 'Buscar' al txbBusqueda de color Gris
            txbBusqueda.Text = "Buscar"
            txbBusqueda.ForeColor = Color.Gray
            actAranceles()

        End If
    End Sub

    Private Sub txbBusqueda_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txbBusqueda.LostFocus

        If txbBusqueda.Text.Length = 0 Or (txbBusqueda.Text = "Buscar" And txbBusqueda.ForeColor = Color.Gray) Then
            txbBusqueda.ForeColor = Color.Gray
            txbBusqueda.Text = "Buscar"
            actAranceles()
        End If

    End Sub
    Private Sub actAranceles()

        Try
            Consulta = "Select id_a, descripcion as 'Descripcion', costo as 'Precio' from aranceles where estado = 1;"
            consultar()
            dgvAranceles.DataSource = Tabla

            If Not IsDBNull(dgvAranceles.Rows(0).Cells(0).Value) Then
                dgvAranceles.Columns(0).Visible = False
            End If

        Catch ex As Exception
            MsgBox("Error al cargar los aranceles", MsgBoxStyle.Exclamation)
        End Try

    End Sub
    Private Sub actArancelesSelect()
        Try

            Consulta = "select  a.id_a, a.descripcion as 'Descripcion General', a.costo as 'Precio', pl.descripcion as 'Descripcion Especifica', pl.id_pl from plan_tratamiento pl inner join aranceles a on a.id_a = pl.id_a where  id_p = '" + id_p.ToString + "';"
            consultar()
            dt = DirectCast(Tabla, DataTable)
            dgvArancelesSelect.DataSource = dt

            If Not IsDBNull(dgvArancelesSelect.Rows(0).Cells(0).Value) Then
                dgvArancelesSelect.Columns(0).Visible = False
            End If

            For indice = 0 To dgvArancelesSelect.RowCount - 1
                listaID_R.Add(dgvArancelesSelect.Rows(indice).Cells(4).Value)
            Next

            dgvArancelesSelect.Columns(4).Visible = False

        Catch ex As Exception
            MsgBox("Error al obtener los aranceles previamente seleccionados", MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub txbBusqueda_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txbBusqueda.TextChanged

        Try
            Consulta = "Select id_a, descripcion as 'Descripcion', costo as 'Precio' from aranceles where estado = 1 and descripcion like '" + txbBusqueda.Text + "%';"
            consultar()
            dgvAranceles.DataSource = Tabla

            If Not IsDBNull(dgvAranceles.Rows(0).Cells(0).Value) Then
                dgvAranceles.Columns(0).Visible = False
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click

        Try
            For x = 0 To dgvArancelesSelect.RowCount - 1

                If listaID_R.Contains(dgvArancelesSelect.Rows(x).Cells(4).Value) Then

                    Consulta = "update plan_tratamiento set descripcion = '" + dgvArancelesSelect.Rows(x).Cells(3).Value + "', set precio = '" + dgvArancelesSelect.Rows(x).Cells(2).Value.ToString + "' where id_pl = '" + dgvArancelesSelect.Rows(x).Cells(4).Value.ToString + "';"
                    consultar()

                    listaID_R.Remove(dgvArancelesSelect.Rows(x).Cells(4).Value)
                Else

                    Consulta = "Insert into plan_tratamiento (id_c, descripcion, precio, id_a) values ('" + frmCitas.idcita.ToString + "', '" + dgvArancelesSelect.Rows(x).Cells(3).Value + "', '" + dgvArancelesSelect.Rows(x).Cells(2).Value.ToString + "','" + dgvArancelesSelect.Rows(x).Cells(0).Value.ToString + "');"
                    consultar()

                End If

            Next
           

            MsgBox("Guardado con éxito", MsgBoxStyle.Information)

            Me.Dispose()
            frmPacientes.Show()

        Catch ex As Exception

            MsgBox("Error al crear registro de aranceles" + ex.ToString, MsgBoxStyle.Exclamation)

        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIngresarDesc.Click
        MuestraMsgBoxVersatil("Ingrese la nueva descripcion del Arancel", 1)

        dgvArancelesSelect.CurrentRow.Cells(3).Value = respString

    End Sub



End Class