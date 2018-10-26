Public Class frmAranceles
    Public id As Integer
    Dim frmContenedor As New Form

    Private Sub Aranceles_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Size = New System.Drawing.Size(880, 580)
        Try
            Consulta = "select * from aranceles where estado = 1"
            consultar()
            DataGridView1.DataSource = Tabla
            DataGridView1.ClearSelection()

            btnEliminar.Hide()
            btnEditar.Hide()

            DataGridView1.Columns(0).Visible = False




            DataGridView1.Columns(1).Width = 400

            DataGridView1.Columns(2).Width = 350

            DataGridView1.Columns(3).Visible = False

        Catch ex As Exception
            MsgBox("error al consultar aranceles en la base de datos", MsgBoxStyle.Exclamation)
        End Try







    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Try
            Consulta = " update aranceles set estado = 0 where id_a = " + Str(id) + ""
            consultar()
            Consulta = "select * from aranceles where estado = 1"
            consultar()
            DataGridView1.DataSource = Tabla
        Catch ex As Exception
            MsgBox("Error al Eliminar Arancel", MsgBoxStyle.Exclamation)
        End Try

    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        btnEliminar.Show()
        btnEditar.Show()
        id = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(0).Value
    End Sub


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditar.Click
        Modificar_Arancel.Show()

    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        'Me.Hide()
        'frmContenedor = Agregar_Arancel
        'frmContenedor.MdiParent = Menu_Inicio
        'frmContenedor.Dock = DockStyle.Fill
        'frmContenedor.Show()
        Agregar_Arancel.Show()

    End Sub



    Private Sub WaterMarkTextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txbBuscarArancel.TextChanged
        Dim busqueda As String = txbBuscarArancel.Text
        Consulta = "select * from aranceles where descripcion like '" + busqueda + "%'"
        consultar()
        DataGridView1.DataSource = Tabla
    End Sub
End Class