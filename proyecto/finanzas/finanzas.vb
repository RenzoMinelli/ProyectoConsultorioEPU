Public Class finanzas
    Dim fecha As String
    Dim fechad As Date
    Dim fechah As Date

    Private Sub finanzas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        fecha = Now.ToShortDateString

        fechad = DateSerial(Year(fecha), Month(fecha), 1)

        fechah = DateSerial(Year(fecha), Month(fecha) + 1, 0)

       
        hasta.Text = fechah
        desde.Text = fechad

        
        actTabla()

    End Sub


    Private Sub desde_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles desde.ValueChanged
        actTabla()
    End Sub

    Private Sub hasta_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles hasta.ValueChanged
        actTabla()
    End Sub
    Private Sub actTabla()

        Try
            fechad = desde.Text
            fechah = hasta.Text
            Consulta = "select fecha as 'Fecha de Pago', pago as 'Cantidad Depositada ($)'  ,cedula as 'Cedula', nombre as 'Nombre' from recibo r inner join paciente p on p.id_p = r.id_p where fecha <= '" + fechah.ToString("yyyy-MM-dd") + "' and fecha >= '" + fechad.ToString("yyyy-MM-dd") + "';"
            consultar()

            DataGridView1.DataSource = Tabla

            Dim suma As Integer = 0
            If Not IsDBNull(DataGridView1.Rows(0).Cells(0).Value) Then
                For x As Integer = 0 To DataGridView1.RowCount - 1

                    suma += DataGridView1.Rows(x).Cells(1).Value

                Next
            End If

            monto.Text = "$"
            monto.Text += suma.ToString

        Catch ex As Exception

            Label4.Text = "No hay pagos en esas fechas"

        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click



    End Sub
End Class