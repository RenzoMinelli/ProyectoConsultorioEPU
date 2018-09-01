Public Class Aranceles
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
            ' Label2.ForeColor = Color.Gold
            DataGridView1.Columns(0).Visible = False
            '   Me.WindowState = FormWindowState.Maximized

            DataGridView1.Columns(0).Width = 300

            DataGridView1.Columns(1).Width = 300

            DataGridView1.Columns(2).Width = 310

        Catch ex As Exception

        End Try







    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Try
            Consulta = " update aranceles set estado = 0 where id_a = " + Str(id) + ""
            consultar()
            Consulta = "select * from aranceles"
            consultar()
            DataGridView1.DataSource = Tabla
        Catch ex As Exception
            MsgBox("Error al Eliminar Arancel",MsgBoxStyle.Exclamation)
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

  
End Class