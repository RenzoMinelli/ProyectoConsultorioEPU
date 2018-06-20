Public Class Aranceles
    Public id As Integer

    Private Sub Aranceles_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Size = New System.Drawing.Size(880, 580)
        Consulta = "select * from aranceles"
        consultar()
        DataGridView1.DataSource = Tabla
        DataGridView1.ClearSelection()
        Button2.Hide()
        Button3.Hide()
        ' Label2.ForeColor = Color.Gold
        DataGridView1.Columns(0).Visible = False
        '   Me.WindowState = FormWindowState.Maximized

        DataGridView1.Columns(0).Width = 300

        DataGridView1.Columns(1).Width = 300

        DataGridView1.Columns(2).Width = 310

        DataGridView1.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 15)






    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Consulta = " delete from aranceles where id_a = " + Str(id) + ""
        consultar()
        Consulta = "select * from aranceles"
        consultar()
        DataGridView1.DataSource = Tabla
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Button2.Show()
        Button3.Show()
        id = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(0).Value
    End Sub


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Modificar_Arancel.Show()
        Me.Hide()
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        Agregar_Arancel.Show()
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Pacientes.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.WindowState = FormWindowState.Minimized
    End Sub


    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Dispose()
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Hide()
        Citas.Show()
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class