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
    Dim fechan As Date
    Dim fechaa As Date
    Dim count As Integer
    Dim indice As Integer
    Dim suma As Integer = 0
    Dim diferenciaf As Integer

    Private Sub btnprompacientes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprompacientes.Click
        Consulta = "select fecha_nacimiento from paciente;"
        consultar()
        dgvInfo.DataSource = Tabla
        count = dgvInfo.RowCount
        For indice As Integer = 0 To count - 1

            fechan = dgvInfo.Rows(indice).Cells(0).Value
            Dim days As Long = DateDiff(DateInterval.Year, fechaa, fechan)
            suma = suma + days
        Next
        suma = suma / count
        Label3.Text = suma
    End Sub

    Private Sub graficas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fechaa = DateTime.Now.ToString("yyyy-MM-dd")
    End Sub

    Private Sub btningresos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btningresos.Click
        btningresos.Visible = False

    End Sub
End Class