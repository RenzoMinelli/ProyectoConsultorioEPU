Public Class Form1
    Public id As Integer

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Consulta = "select * from aranceles"
        consultar()
        DataGridView1.DataSource = Tabla
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Consulta = " delete from aranceles where id_a = " + Str(id) + ""
        consultar()
        Consulta = "select * from aranceles"
        consultar()
        DataGridView1.DataSource = Tabla
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Button3.Show()
        id = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(0).Value
    End Sub


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub Form1_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        Me.Hide()
        Agregar_Paciente.Show()
    End Sub
End Class