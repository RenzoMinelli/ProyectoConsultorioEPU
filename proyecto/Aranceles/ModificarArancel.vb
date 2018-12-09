Public Class ModificarArancel
    Dim id As Integer = frmAranceles.id
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Consulta = "update aranceles set descripcion = '" + TextBox1.Text + "', costo = '" + TextBox2.Text + "' where id_a = " + Str(id) + " and estado = 1;"
        consultar()
        frmAranceles.Show()
        frmFondoTransparente.Dispose()
        Me.Dispose()

        Consulta = "select * from aranceles where estado = 1"
        consultar()
        frmAranceles.dgvAranceles.DataSource = Tabla
        frmFondoTransparente.Dispose()
        Me.Dispose()
        frmAranceles.Show()
    End Sub

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim descripcion As String = ""
        Dim costo As Integer = 0


        Consulta = "select descripcion from aranceles where id_a = '" + Str(id) + "';"
        consultar()
        DataGridView1.DataSource = Tabla
        descripcion = DataGridView1.Rows(0).Cells(0).Value

        Consulta = "select costo from aranceles where id_a = '" + Str(id) + "';"
        consultar()
        DataGridView1.DataSource = Tabla
        costo = DataGridView1.Rows(0).Cells(0).Value

        Consulta = "select ref from aranceles where id_a = '" + Str(id) + "';"
        consultar()
        DataGridView1.DataSource = Tabla


        TextBox1.Text = descripcion

        TextBox2.Text = costo

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        frmFondoTransparente.Dispose()
        Me.Dispose()
    End Sub


End Class