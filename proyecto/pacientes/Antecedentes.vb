Public Class Antecedentes

    Private Sub Antecedentes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Consulta = "select * from antecedentes where id_p = '" + Str(id_p) + "';"
        consultar()
        tablita.DataSource = Tabla
    End Sub

    Private Sub CheckedListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckedListBox1.SelectedIndexChanged

    End Sub

End Class