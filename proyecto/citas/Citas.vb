Public Class Citas
    Dim cita As String
    Private Sub Citas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DataGridView1.Hide()
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

  

    Private Sub PictureBox6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox6.Click
        Me.Dispose()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged
        Dim fecha As String = DateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss")
        Dim nombre As String
        Dim descripcion As String
        Dim cedula As String
        Dim id_p As Integer
        Consulta = "select id_p from cita where fecha_hora = " + fecha + ";"
        consultar()
        DataGridView1.DataSource = Tabla
        id_p = DataGridView1.Rows(0).Cells(0).Value
        Consulta = "select nombre from pacientes where id_p = " + id_p + ";"
        consultar()
        DataGridView1.DataSource = Tabla
        nombre = DataGridView1.Rows(0).Cells(0).Value
        Consulta = "select descripcion from registro_medico where id_p = " + id_p + ";"
        consultar()
        DataGridView1.DataSource = Tabla
        descripcion = DataGridView1.Rows(0).Cells(0).Value
        consultar()
        DataGridView1.DataSource = Tabla
        Consulta = "select cedula from paciente where id_p = " + id_p + ";"
        consultar()
        DataGridView1.DataSource = Tabla
        cedula = DataGridView1.Rows(0).Cells(0).Value
        Label11.Text = +nombre
        Label12.Text = +cedula
        Label9.Text = +descripcion

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label18.Text = Date.Now.ToLongTimeString
        Label18.Font = New Font("Microsoft Sans Serif", 15, FontStyle.Bold)
    End Sub

    Private Sub Label19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label19.Click
        Me.Dispose()
        Aranceles.Show()
    End Sub

    Private Sub Label20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label20.Click
        Me.Dispose()
        Pacientes.Show()
    End Sub
End Class