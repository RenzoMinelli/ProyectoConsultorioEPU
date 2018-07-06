Public Class Agregar_Arancel

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim nombre As String = TextBox1.Text
        Dim ref As String = ComboBox1.SelectedItem
        Dim costo As String = TextBox2.Text

        Consulta = "insert into aranceles (descripcion, costo, ref) values ('" + nombre + "','" + costo + "','" + ref + "');"
        consultar()

        'actualizo la tabla

        Consulta = "select * from aranceles"
        consultar()
        Aranceles.DataGridView1.DataSource = Tabla
        Me.Dispose()
        Aranceles.Show()

    End Sub


   


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        Aranceles.Show()
    End Sub

End Class