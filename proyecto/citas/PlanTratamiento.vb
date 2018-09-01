Public Class PlanTratamiento
    Dim id_Arancel As Integer

    Private Sub PlanTratamiento_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txbBusqueda.ForeColor = Color.Gray
        txbBusqueda.Text = "Buscar"

       

        actTabla()
    End Sub

    Private Sub dgvAranceles_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgvAranceles.MouseDoubleClick

        Dim id_a As Integer = dgvAranceles.CurrentRow.Cells(0).Value

        Try
            Consulta = "Select id_a, descripcion as 'Descripcion', costo as 'Costo' from aranceles where id_a = '" + id_a.ToString + "';"
            consultar()
            dgvAuxiliar.DataSource = Tabla
            dgvArancelesSelect.ColumnCount = 4
            dgvArancelesSelect.Columns(0).HeaderText = "id_a"
            dgvArancelesSelect.Columns(1).HeaderText = "Descripcion"
            dgvArancelesSelect.Columns(2).HeaderText = "Costo"
            dgvArancelesSelect.Columns(3).HeaderText = "Descripcion especifica"

            dgvArancelesSelect.Columns(0).Visible = False
            MuestraMsgBoxVersatil("Ingrese descripcion especifica para el Arancel", 1)
            dgvArancelesSelect.Rows.Add(dgvAuxiliar.Rows(0).Cells(0).Value, dgvAuxiliar.Rows(0).Cells(1).Value, dgvAuxiliar.Rows(0).Cells(2).Value, respString)


            dgvArancelesSelect.AutoResizeColumn(1, 2)

        Catch ex As Exception
            MsgBox("Error al pasar los aranceles", MsgBoxStyle.Exclamation)
        End Try

    End Sub
    
    Private Sub dgvArancelesSelect_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvArancelesSelect.CellClick

        id_Arancel = dgvArancelesSelect.CurrentRow.Cells(0).Value
        btnEliminar.Visible = True
        btnModificarPrecio.Visible = True
        btnIngresarDesc.Visible = True


    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click

        For x = 0 To dgvArancelesSelect.RowCount - 1

            If dgvArancelesSelect.Rows(x).Cells(0).Value = id_Arancel Then

                dgvArancelesSelect.Rows.RemoveAt(x)

                Exit For

            End If
        Next
        If dgvArancelesSelect.RowCount = 0 Then

            btnEliminar.Visible = False
            btnModificarPrecio.Visible = False

        End If
    End Sub

    Private Sub btnModificarPrecio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificarPrecio.Click


        MuestraMsgBoxVersatil("Ingrese el nuevo costo del Arancel", 1)
        If respString = "" Then
            dgvArancelesSelect.CurrentRow.Cells(2).Value = "0"
        Else
            dgvArancelesSelect.CurrentRow.Cells(2).Value = respString
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
            actTabla()

            'Si la tecla presionada es borrar y todo el texto esta seleccionado
        ElseIf e.KeyCode = Keys.Back And txbBusqueda.SelectedText = txbBusqueda.Text Then

            'Introduzco el texto 'Buscar' al txbBusqueda de color Gris
            txbBusqueda.Text = "Buscar"
            txbBusqueda.ForeColor = Color.Gray
            actTabla()

        End If
    End Sub

    Private Sub txbBusqueda_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txbBusqueda.LostFocus
        If txbBusqueda.Text.Length = 0 Or (txbBusqueda.Text = "Buscar" And txbBusqueda.ForeColor = Color.Gray) Then
            txbBusqueda.ForeColor = Color.Gray
            txbBusqueda.Text = "Buscar"
            actTabla()
        End If
    End Sub
    Private Sub actTabla()

        Try
            Consulta = "Select id_a, descripcion as 'Descripcion', costo as 'Costo' from aranceles where estado = 1"
            consultar()
            dgvAranceles.DataSource = Tabla

            If Not IsDBNull(dgvAranceles.Rows(0).Cells(0).Value) Then
                dgvAranceles.Columns(0).Visible = False
            End If

        Catch ex As Exception
            MsgBox("Error al cargar los aranceles", MsgBoxStyle.Exclamation)
        End Try

    End Sub

    Private Sub txbBusqueda_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txbBusqueda.TextChanged
        Try
            Consulta = "Select id_a, descripcion as 'Descripcion', costo as 'Costo' from aranceles where estado = 1 and descripcion like '" + txbBusqueda.Text + "%';"
            consultar()
            dgvAranceles.DataSource = Tabla

            If Not IsDBNull(dgvAranceles.Rows(0).Cells(0).Value) Then
                dgvAranceles.Columns(0).Visible = False
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        '/////////////////////////////////////////CAMBIAR/////////////////////////////////////////////
        'Hay que cambiar para que vuelva al formulario donde se registra el estado de los dientes '///
        Me.Hide()                                                                                 '///
        CrearCita.Show()                                                                          '///
        '/////////////////////////////////////////////////////////////////////////////////////////////
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIngresarDesc.Click
        MuestraMsgBoxVersatil("Ingrese la nueva descripcion del Arancel", 1)

        dgvArancelesSelect.CurrentRow.Cells(3).Value = respString

    End Sub

   
  
End Class