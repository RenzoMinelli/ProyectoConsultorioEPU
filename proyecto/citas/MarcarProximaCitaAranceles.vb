Public Class MarcarProximaCitaAranceles
    Dim id_r As Integer
    Private Sub MarcarCosasCitas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Consulta = "Select r.id_r, r.id_p, a.descripcion as 'Descripcion General',r.precio as 'Precio',r.descripcion as 'Descripcion Especifica', r.id_a from registro_medico r inner join aranceles a on r.id_a = a.id_a where r.id_p = '" + id_p.ToString + "';"
            consultar()
            dgvAranceles.DataSource = Tabla
            dgvAranceles.Columns(0).Visible = False
            dgvAranceles.Columns(1).Visible = False
            dgvAranceles.Columns(5).Visible = False

            dgvAranceles.AutoResizeColumn(2, 4)

        Catch ex As Exception

        End Try


    End Sub

    Private Sub dgvAranceles_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvAranceles.CellClick
        lblDescripcionG.Text = "Precio: " + dgvAranceles.CurrentRow.Cells(2).Value
        lblDescripcionE.Text = "Descripción Específica: " + dgvAranceles.CurrentRow.Cells(4).Value
        lblDescripcionG.Text = "Descripción General: " + dgvAranceles.CurrentRow.Cells(3).Value
    End Sub


    Private Sub dgvAranceles_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvAranceles.CellDoubleClick
        id_r = dgvAranceles.CurrentRow.Cells(0).Value

        Try
            Consulta = "Select r.id_p,  a.descripcion as 'Descripcion General',r.precio as 'Precio',r.descripcion as 'Descripcion Especifica' from registro_medico r inner join aranceles a on r.id_a = a.id_a where id_r = '" + id_r.ToString + "';"
            consultar()

            dgvAuxiliar.DataSource = Tabla

            dgvArancelesSelect.ColumnCount = 4
            dgvArancelesSelect.Columns(0).HeaderText = "ID_P"
            dgvArancelesSelect.Columns(3).HeaderText = "Descripcion Especifica"
            dgvArancelesSelect.Columns(2).HeaderText = "Precio"
            dgvArancelesSelect.Columns(1).HeaderText = "Descripcion General"

            dgvArancelesSelect.Columns(0).Visible = False

            dgvArancelesSelect.Rows.Add(dgvAuxiliar.Rows(0).Cells(0).Value, dgvAuxiliar.Rows(0).Cells(1).Value, dgvAuxiliar.Rows(0).Cells(2).Value, dgvAuxiliar.Rows(0).Cells(3).Value)

            dgvArancelesSelect.AutoResizeColumn(1, 2)
        Catch ex As Exception

            MsgBox("Error al mover arancel", MsgBoxStyle.Exclamation)

        End Try

    End Sub

    Private Sub btnModificarPrecio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificarPrecio.Click
        MuestraMsgBoxVersatil("Ingrese el nuevo costo del Arancel", 1)
        If respString = "" Then
            dgvArancelesSelect.CurrentRow.Cells(2).Value = "0"
        Else
            dgvArancelesSelect.CurrentRow.Cells(2).Value = respString
        End If


    End Sub

    Private Sub btnIngresarDesc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIngresarDesc.Click
        MuestraMsgBoxVersatil("Ingrese la nueva descripcion del Arancel", 1)

        dgvArancelesSelect.CurrentRow.Cells(3).Value = respString
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click

        For x = 0 To dgvArancelesSelect.RowCount - 1

            If dgvArancelesSelect.Rows(x).Cells(0).Value = id_r Then

                dgvArancelesSelect.Rows.RemoveAt(x)

                Exit For

            End If
        Next
        If dgvArancelesSelect.RowCount = 0 Then

            btnEliminar.Visible = False
            btnModificarPrecio.Visible = False

        End If
    End Sub

    Private Sub dgvArancelesSelect_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvArancelesSelect.CellClick
        lblDescripcionG.Text = "Precio: " + dgvArancelesSelect.CurrentRow.Cells(2).Value
        lblDescripcionE.Text = "Descripción Específica: " + dgvArancelesSelect.CurrentRow.Cells(4).Value
        lblDescripcionG.Text = "Descripción General: " + dgvArancelesSelect.CurrentRow.Cells(3).Value

        id_r = dgvArancelesSelect.CurrentRow.Cells(0).Value
        btnEliminar.Visible = True
        btnModificarPrecio.Visible = True
        btnIngresarDesc.Visible = True
    End Sub
End Class