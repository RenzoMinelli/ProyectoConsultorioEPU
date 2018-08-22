Public Class finanzas
    Dim fecha As String
    Public fechad As Date
    Public fechah As Date
    Dim frmContenedor As New Form

    Private Sub finanzas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Consulta = "select nombre, cedula from paciente;"
            consultar()
            dgbPacientes.DataSource = Tabla

            For x = 0 To dgbPacientes.RowCount - 1
                ComboBox1.Items.Add(dgbPacientes.Rows(x).Cells(0).Value + " " + dgbPacientes.Rows(x).Cells(1).Value)
            Next
            fecha = Now.ToShortDateString
        Catch ex As Exception
            MsgBox("Error al cargar pacientes", MsgBoxStyle.Exclamation)
        End Try


        fechad = DateSerial(Year(fecha), Month(fecha), 1)
        desde.Value = fechad

        fechah = DateSerial(Year(fecha), Month(fecha) + 1, 0)
        hasta.Value = fechah


        ComboBox1.SelectedItem = "Todos"
        actTabla(ComboBox1.SelectedItem)

    End Sub


    Private Sub desde_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles desde.ValueChanged
        actTabla(ComboBox1.SelectedItem)
    End Sub

    Private Sub hasta_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles hasta.ValueChanged
        actTabla(ComboBox1.SelectedItem)
    End Sub
    Public Sub actTabla(ByVal nombrePaciente As String)

        If nombrePaciente = "Todos" Then
            Try
                fechad = desde.Text
                fechah = hasta.Text
                Consulta = "select fecha as 'Fecha de Pago', pago as 'Cantidad Depositada ($)'  ,cedula as 'Cedula', nombre as 'Nombre' from recibo r inner join paciente p on p.id_p = r.id_p where fecha <= '" + fechah.ToString("yyyy-MM-dd") + "' and fecha >= '" + fechad.ToString("yyyy-MM-dd") + "';"
                consultar()

                dgbPagos.DataSource = Tabla

                Dim suma As Integer = 0
                If Not IsDBNull(dgbPagos.Rows(0).Cells(0).Value) Then

                    Label4.Text = ""
                    For x As Integer = 0 To dgbPagos.RowCount - 1

                        suma += dgbPagos.Rows(x).Cells(1).Value

                    Next
                End If

                monto.Text = "$"
                monto.Text += suma.ToString

            Catch ex As Exception

                Label4.Text = "No hay pagos en esas fechas"

            End Try
        ElseIf nombrePaciente = " " Then
            ComboBox1.SelectedItem = "Todos"
            actTabla("Todos")
        Else
            Try
                Dim cedula As String = nombrePaciente.Substring(nombrePaciente.Length - 8, 8)

                fechad = desde.Text
                fechah = hasta.Text
                Consulta = "select fecha as 'Fecha de Pago', pago as 'Cantidad Depositada ($)'  ,cedula as 'Cedula', nombre as 'Nombre' from recibo r inner join paciente p on p.id_p = r.id_p where fecha <= '" + fechah.ToString("yyyy-MM-dd") + "' and fecha >= '" + fechad.ToString("yyyy-MM-dd") + "' and cedula = '" + cedula + "';"
                consultar()

                dgbPagos.DataSource = Tabla

                Dim suma As Integer = 0
                If Not IsDBNull(dgbPagos.Rows(0).Cells(0).Value) Then

                    Label4.Text = ""
                    For x As Integer = 0 To dgbPagos.RowCount - 1

                        suma += dgbPagos.Rows(x).Cells(1).Value

                    Next
                End If

                monto.Text = "$"
                monto.Text += suma.ToString
            Catch ex As Exception

                Label4.Text = "No hay pagos en esas fechas"

            End Try
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        frmContenedor = realizar_pago
        frmContenedor.MdiParent = Menu_Inicio
        frmContenedor.Dock = DockStyle.Fill
        frmContenedor.Show()


    End Sub

    Private Sub ComboBox1_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedValueChanged
        actTabla(ComboBox1.SelectedItem)

    End Sub
End Class