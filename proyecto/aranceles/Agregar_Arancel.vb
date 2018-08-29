Public Class Agregar_Arancel

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim nombre As String = TextBox1.Text

        Dim costo As String = TextBox2.Text
        Try
            Consulta = "insert into aranceles (descripcion, costo,estado) values ('" + nombre + "','" + costo + "',1);"
            consultar()

            'actualizo la tabla

            Consulta = "select * from aranceles"
            consultar()
            Aranceles.DataGridView1.DataSource = Tabla
            Me.Dispose()
            Aranceles.Show()
        Catch ex As Exception
            MsgBox("Error al agregar un arancel", MsgBoxStyle.Exclamation)
        End Try


    End Sub


   


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        Aranceles.Show()
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub

    Private Sub Agregar_Arancel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class