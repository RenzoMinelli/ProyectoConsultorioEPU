Public Class frmAranceles
    Public id As Integer
    Dim frmContenedor As New Form

    Private Sub Aranceles_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load

        Try
            Consulta = "select * from aranceles where estado = 1"
            consultar()
            dgvAranceles.DataSource = Tabla
            dgvAranceles.ClearSelection()

            btnEliminar.Hide()
            btnEditar.Hide()

            dgvAranceles.Columns(0).Visible = False

            dgvAranceles.Columns(1).Width = 400
            dgvAranceles.Columns(1).HeaderText = "Descripción"
            dgvAranceles.Columns(2).HeaderText = "Costo"
            dgvAranceles.Columns(2).Width = 350

            dgvAranceles.Columns(3).Visible = False

        Catch ex As Exception
            MsgBox("Error al consultar aranceles en la base de datos", MsgBoxStyle.Exclamation)
        End Try

        Try

            Dim fecha As Date = Now.Date

            Consulta = " select id_a, descripcion,costo from aranceles where id_a in (select id_a from plan_tratamiento p inner join cita c on c.id_c = p.id_c where month(fecha) = '" + fecha.ToString("MM") + "' and year(fecha) = '" + fecha.ToString("yyyy") + "') and estado = '1' ;"
            consultar()
            dgvArancelesUtilizados.DataSource = Tabla
            dgvArancelesUtilizados.Columns(0).Visible = False
            dgvArancelesUtilizados.Columns(1).HeaderText = "Descripción"
            dgvArancelesUtilizados.Columns(2).HeaderText = "Costo"
        Catch ex As Exception
            MsgBox("Error al obtener aranceles utilizados este mes", MsgBoxStyle.Exclamation)
        End Try





    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Try
            Consulta = " update aranceles set estado = 0 where id_a = " + Str(id) + ""
            consultar()
            Consulta = "select * from aranceles where estado = 1"
            consultar()
            dgvAranceles.DataSource = Tabla
            dgvAranceles.ClearSelection()
            dgvArancelesUtilizados.ClearSelection()
            btnEditar.Hide()
            btnEliminar.Hide()
        Catch ex As Exception
            MsgBox("Error al Eliminar Arancel", MsgBoxStyle.Exclamation)
        End Try

    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvAranceles.CellClick
        dgvArancelesUtilizados.ClearSelection()
        btnEliminar.Show()
        btnEditar.Show()
        id = dgvAranceles.Rows(dgvAranceles.CurrentRow.Index).Cells(0).Value
    End Sub


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditar.Click
        ModificarArancel.Show()

    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click

        AgregarArancel.Show()

    End Sub



    Private Sub WaterMarkTextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txbBuscarArancel.TextChanged
        Try

            Dim busqueda As String = txbBuscarArancel.Text
            Consulta = "select * from aranceles where descripcion like '" + busqueda + "%' and estado = 1"
            consultar()
            dgvAranceles.DataSource = Tabla

        Catch ex As Exception
            MsgBox("Error al obtener aranceles", MsgBoxStyle.Exclamation)
        End Try

    End Sub

    Private Sub dgvArancelesUtilizados_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvArancelesUtilizados.CellClick
        id = dgvArancelesUtilizados.CurrentRow.Cells(0).Value
        btnEliminar.Show()
        btnEditar.Show()
        dgvAranceles.ClearSelection()
    End Sub
End Class