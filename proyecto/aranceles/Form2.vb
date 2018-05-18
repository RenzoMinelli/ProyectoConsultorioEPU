Public Class Form2

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim nombre As String = TextBox1.Text
        Dim ref As String = ComboBox1.SelectedItem
        Dim costo As String = TextBox2.Text

        Consulta = "insert into aranceles (descripcion, costo, ref) values ('" + nombre + "','" + costo + "','" + ref + "');"
        consultar()

        'actualizo la tabla

        Consulta = "select * from aranceles"
        consultar()
        Form1.DataGridView1.DataSource = Tabla
        Me.Dispose()
        Form1.Show()
    End Sub

   
    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class