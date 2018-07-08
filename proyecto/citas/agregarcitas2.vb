Public Class agregarcitas2
    Dim h As String
    Dim fc As String

    'Mira este video para ver como hacer,  porque funciona pero no esta bien, sale el calendario otra vez en el datetimepicker
    'https://www.youtube.com/watch?v=t8fGIK3PQBM


    Private Sub agregarcitas2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Consulta = "Select nombre as 'Nombre',id_p from paciente;"
        consultar()
        DataGridView1.DataSource = Tabla
        DataGridView1.Columns(1).Visible = False

        fc = MonthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd")
        h = DateTimePicker1.Value.ToString("hh:mm:ss")
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        id_p = DataGridView1.CurrentRow.Cells(1).Value

    End Sub

    Private Sub MonthCalendar1_DateChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles MonthCalendar1.DateChanged
        fc = MonthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd")
    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        h = DateTimePicker1.Text
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Consulta = "insert into cita (id_p,fecha,hora,realizada,descripcion) values ('" + id_p.ToString + "','" + fc + "','" + h + "', 0,'" + TextBox1.Text + "');"
            consultar()

            MsgBox("Agregado con éxito")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

End Class