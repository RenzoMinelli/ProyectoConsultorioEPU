Public Class agregarcitas2
    Dim h As String
    Dim fc As String
    Dim nombre As String
    Dim min As String
    Dim 


    'Mira este video para ver como hacer,  porque funciona pero no esta bien, sale el calendario otra vez en el datetimepicker
    'https://www.youtube.com/watch?v=t8fGIK3PQBM


    Private Sub agregarcitas2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        NumericUpDown1.Value = Now.Hour
        NumericUpDown2.Value = Now.Minute

        Consulta = "Select nombre as 'Nombre',id_p from paciente;"
        consultar()
        DataGridView1.DataSource = Tabla
        DataGridView1.Columns(1).Visible = False

        fc = MonthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd")
        h = NumericUpDown1.Value.ToString + ":" + NumericUpDown2.Value.ToString + ":00"
        id_p = vbNull

    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        id_p = DataGridView1.CurrentRow.Cells(1).Value
        nombre = DataGridView1.CurrentRow.Cells(0).Value
        Label6.Text = nombre
    End Sub

    Private Sub MonthCalendar1_DateChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles MonthCalendar1.DateChanged
        fc = MonthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Consulta = "select fecha from citas"
        consultar()
        If fc = Consulta Then

        End If
        If id_p <> vbNull Then

            Try
                Consulta = "insert into cita (id_p,fecha,hora,realizada,descripcion) values ('" + id_p.ToString + "','" + fc + "','" + h + "', 0,'" + TextBox1.Text + "');"
                consultar()

                MsgBox("Agregado con éxito")

            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        Else
            MsgBox("rellene todos los campos")

        End If


    End Sub
    Private Sub botonsito_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botonsito.Click
        Citas.Show()
        Citas.actualizador()
        Me.Dispose()
    End Sub

    Private Sub NumericUpDown1_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles NumericUpDown1.ValueChanged
        h = NumericUpDown1.Value.ToString + ":" + NumericUpDown2.Value.ToString + ":00"
    End Sub

    Private Sub NumericUpDown2_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles NumericUpDown2.ValueChanged
        h = NumericUpDown1.Value.ToString + ":" + NumericUpDown2.Value.ToString + ":00"
    End Sub
End Class