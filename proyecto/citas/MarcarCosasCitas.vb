Public Class MarcarCosasCitas

    Private Sub MarcarCosasCitas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Consulta = "Select r.id_r, r.id_p, r.descripcion as 'Descripcion Especifica',r.precio as 'Precio',a.descripcion as 'Descripcion General' from registro_medico r inner join aranceles a on r.id_a = a.id_a where r.id_c = '" + Citas.idcita.ToString + "';"
            consultar()
            dgvAranceles.DataSource = Tabla
            dgvAranceles.Columns(0).Visible = False
            dgvAranceles.Columns(1).Visible = False
            dgvAranceles.AutoResizeColumn(2, 4)

        Catch ex As Exception

        End Try
       

    End Sub

    
    Private Sub dgvAranceles_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvAranceles.CellDoubleClick

    End Sub
End Class