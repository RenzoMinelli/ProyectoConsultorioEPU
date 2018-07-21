Public Class finanzas
   

    Private Sub finanzas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim fecha As String = Now.ToShortDateString
        Dim fechad As Date = DateSerial(Year(fecha), Month(fecha), 1)
        Dim fechah As Date = DateSerial(Year(fecha), Month(fecha) + 1, 0)
        desde.Value = fechad
        hasta.Value = fechah
        Try
           
            Consulta = "select pago from recibo where fecha <= '" + fechah.ToString("yyyy-MM-dd") + "' and fecha >= '" + fechad.ToString("yyyy-MM-dd") + "';"
            consultar()

            DataGridView1.DataSource = Tabla

            Dim suma As Integer = 0
            If Not IsDBNull(DataGridView1.Rows(0).Cells(0).Value) Then
                For x As Integer = 0 To DataGridView1.RowCount - 1

                    suma += DataGridView1.Rows(x).Cells(0).Value

                Next
            End If

            monto.Text = "$"
            monto.Text += suma.ToString

        Catch ex As Exception

            MsgBox("Error en la obtencion de los pagos")

        End Try
       
    End Sub


    Private Sub desde_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles desde.ValueChanged
        Dim fecha As String = Now.ToShortDateString
        Dim fechad As Date = DateSerial(Year(fecha), Month(fecha), 1)
        Dim fechah As Date = DateSerial(Year(fecha), Month(fecha) + 1, 0)
        Try
            fechad = desde.Text
            fechah = hasta.Text
            Consulta = "select pago from recibo where fecha <= '" + fechah.ToString("yyyy-MM-dd") + "' and fecha >= '" + fechad.ToString("yyyy-MM-dd") + "';"
            consultar()

            DataGridView1.DataSource = Tabla

            Dim suma As Integer = 0
            If Not IsDBNull(DataGridView1.Rows(0).Cells(0).Value) Then
                For x As Integer = 0 To DataGridView1.RowCount - 1

                    suma += DataGridView1.Rows(x).Cells(0).Value

                Next
            End If

            monto.Text = "$"
            monto.Text += suma.ToString

        Catch ex As Exception

            MsgBox("Error en la obtencion de los pagos")

        End Try
    End Sub

    Private Sub hasta_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles hasta.ValueChanged
        Dim fecha As String = Now.ToShortDateString
        Dim fechad As Date = DateSerial(Year(fecha), Month(fecha), 1)
        Dim fechah As Date = DateSerial(Year(fecha), Month(fecha) + 1, 0)
        Try
            fechad = desde.Text
            fechah = hasta.Text
            Consulta = "select pago from recibo where fecha <= '" + fechah.ToString("yyyy-MM-dd") + "' and fecha >= '" + fechad.ToString("yyyy-MM-dd") + "';"
            consultar()

            DataGridView1.DataSource = Tabla

            Dim suma As Integer = 0
            If Not IsDBNull(DataGridView1.Rows(0).Cells(0).Value) Then
                For x As Integer = 0 To DataGridView1.RowCount - 1

                    suma += DataGridView1.Rows(x).Cells(0).Value

                Next
            End If

            monto.Text = "$"
            monto.Text += suma.ToString

        Catch ex As Exception

            MsgBox("Error en la obtencion de los pagos")

        End Try
    End Sub
End Class