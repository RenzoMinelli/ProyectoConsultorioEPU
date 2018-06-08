Public Class Citas
    Dim cita As String
    Private Sub Citas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

  

    Private Sub PictureBox6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox6.Click
        Me.Dispose()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged
        Dim fecha As String = DateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss")
        Dim ciitas As String
        Dim nombre As String
        Dim descripcion As String
        Dim cedula As String
        Dim id_p As Integer
        Consulta = "select id_p from cita where fecha_hora like " + fecha + ";"
        id_p = Consulta
        Consulta = "select nombre from pacientes where id_p like" + id_p + ";"
        nombre = Consulta
        Consulta = "select descripcion from registro_medico where id_p like" + id_p + ";"
        descripcion = Consulta
        Consulta = "select cedula from paciente where id_p like" + id_p + ";"
        cedula = Consulta
        Label11.Text = +nombre
        Label12.Text = +cedula
        Label9.Text = +descripcion

    End Sub
End Class