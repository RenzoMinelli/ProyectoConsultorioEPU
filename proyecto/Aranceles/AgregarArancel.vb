Public Class AgregarArancel

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim nombre As String = TextBox1.Text

        Dim costo As String = TextBox2.Text
        Try
            Consulta = "insert into aranceles (descripcion, costo,estado) values ('" + nombre + "','" + costo + "',1);"
            consultar()

            'actualizo la tabla

            Consulta = "select * from aranceles where estado = 1"
            consultar()
            frmAranceles.dgvAranceles.DataSource = Tabla
            Me.Dispose()
            frmAranceles.Show()
        Catch ex As Exception
            MsgBox("Error al agregar un arancel", MsgBoxStyle.Exclamation)
        End Try


    End Sub





    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        frmAranceles.Show()
    End Sub


    Private Sub Agregar_Arancel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class