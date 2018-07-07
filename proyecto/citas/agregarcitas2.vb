Public Class agregarcitas2
    Dim h As String
    Dim fc As String

    Private Sub agregarcitas2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Consulta = "Select nombre as 'Nombre',id_p from pacientes;"
        consultar()
        DataGridView1.DataSource = Tabla
        DataGridView1.Columns(1).Visible = False

    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        id_p = DataGridView1.CurrentRow.Cells(1).Value

    End Sub

    Private Sub MonthCalendar1_DateChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles MonthCalendar1.DateChanged
        fc = MonthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd")
    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged
        h = DateTimePicker1.Value
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Consulta = "insert into cita (id_p,fecha_hora,realizada,descripcion) values ('" + id_p.ToString + "','" + fc + h + "',0,'" + TextBox1.Text + "');"
        consultar()
    End Sub

End Class