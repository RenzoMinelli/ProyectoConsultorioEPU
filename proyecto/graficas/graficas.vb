Public Class graficas
    Dim x1 As Integer
    Dim x2 As Integer
    Dim x3 As Integer
    Dim x4 As Integer
    Dim x5 As Integer
    Dim y1 As String
    Dim y2 As String
    Dim y3 As String
    Dim y4 As String
    Dim y5 As String
    Dim fechan As Integer
    Dim fechaa As String

    Private Sub btnprompacientes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprompacientes.Click
        Consulta = "select Fecha_nacimiento from pacientes;"
        consultar()
        dgbinfo.DataSource = Tabla
        fechan = dgbinfo.Rows(0).Cells(0).Value
        fechaa = DateTime.Now.ToString
        Label3.Text = fechaa
    End Sub
End Class