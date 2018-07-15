Public Class Registro_Medico
   
    
    Private Sub Registro_Medico_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Consulta = "Select r.descripcion, zona, nro_diente, a.descripcion, c.fecha,hora , precio from registro_medico r left join aranceles a on a.id_a = r.id_a left join cita c on c.id_c = r.id_c where r.id_p = '" + Str(id_p) + "'"
            consultar()
            DataGridView1.DataSource = Tabla
            actBoca()
            actTabla()
            actEstado()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
       
    End Sub

    Private Sub actBoca()
        Dim zona As String = ""
        For x As Integer = 0 To DataGridView1.RowCount - 1

            If Not IsDBNull(DataGridView1.Rows(x).Cells(1).Value) Then
                Select Case DataGridView1.Rows(x).Cells(1).Value

                    Case "nor-oeste"
                        zona = "1"
                    Case "nor-este"
                        zona = "2"
                    Case "sur-oeste"
                        zona = "3"
                    Case "sur-este"
                        zona = "4"

                End Select

                zona += DataGridView1.Rows(x).Cells(2).Value.ToString

                Dim panel As New Panel

                If DataGridView1.Rows(x).Cells(0).Value = "malo" Then
                    panel.BackColor = Color.Red
                ElseIf DataGridView1.Rows(x).Cells(0).Value = "precaucion" Then
                    panel.BackColor = Color.Yellow
                Else
                    panel.BackColor = Color.White
                End If

                Select Case zona
                    Case "11"
                        Panel11.BackColor = panel.BackColor
                    Case "12"
                        Panel12.BackColor = panel.BackColor
                    Case "13"
                        Panel13.BackColor = panel.BackColor
                    Case "14"
                        Panel14.BackColor = panel.BackColor
                    Case "15"
                        Panel15.BackColor = panel.BackColor
                    Case "16"
                        Panel16.BackColor = panel.BackColor
                    Case "17"
                        Panel17.BackColor = panel.BackColor
                    Case "18"
                        Panel18.BackColor = panel.BackColor
                    Case "21"
                        Panel21.BackColor = panel.BackColor
                    Case "22"
                        Panel22.BackColor = panel.BackColor
                    Case "23"
                        Panel23.BackColor = panel.BackColor
                    Case "24"
                        Panel24.BackColor = panel.BackColor
                    Case "25"
                        Panel25.BackColor = panel.BackColor
                    Case "26"
                        Panel26.BackColor = panel.BackColor
                    Case "27"
                        Panel27.BackColor = panel.BackColor
                    Case "28"
                        Panel28.BackColor = panel.BackColor
                    Case "31"
                        Panel31.BackColor = panel.BackColor
                    Case "32"
                        Panel32.BackColor = panel.BackColor
                    Case "33"
                        Panel33.BackColor = panel.BackColor
                    Case "34"
                        Panel34.BackColor = panel.BackColor
                    Case "35"
                        Panel35.BackColor = panel.BackColor
                    Case "36"
                        Panel36.BackColor = panel.BackColor
                    Case "37"
                        Panel37.BackColor = panel.BackColor
                    Case "38"
                        Panel38.BackColor = panel.BackColor
                    Case "41"
                        Panel41.BackColor = panel.BackColor
                    Case "42"
                        Panel42.BackColor = panel.BackColor
                    Case "43"
                        Panel43.BackColor = panel.BackColor
                    Case "44"
                        Panel44.BackColor = panel.BackColor
                    Case "45"
                        Panel45.BackColor = panel.BackColor
                    Case "46"
                        Panel46.BackColor = panel.BackColor
                    Case "47"
                        Panel47.BackColor = panel.BackColor
                    Case "48"
                        Panel48.BackColor = panel.BackColor

                End Select
            End If
        Next
    End Sub
    Private Sub actEstado()
        EstadoDiente.Rows.Clear()
        EstadoDiente.ColumnCount = 5

        EstadoDiente.Columns(0).HeaderText = "Descripcion"
        EstadoDiente.Columns(1).HeaderText = "Zona"
        EstadoDiente.Columns(2).HeaderText = "Numero de Diente"
        EstadoDiente.Columns(3).HeaderText = "Fecha"
        EstadoDiente.Columns(4).HeaderText = "Hora"

        For x As Integer = 0 To DataGridView1.RowCount - 1
            If Not IsDBNull(DataGridView1.Rows(x).Cells(1).Value) Then
                Dim fecha As String = DataGridView1.Rows(x).Cells(4).Value
                EstadoDiente.Rows.Add(DataGridView1.Rows(x).Cells(0).Value, DataGridView1.Rows(x).Cells(1).Value, DataGridView1.Rows(x).Cells(2).Value, fecha, DataGridView1.Rows(x).Cells(5).Value)
            End If
        Next
        EstadoDiente.ClearSelection()
        EstadoDiente.AutoResizeColumns()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Dispose()
        Pacientes.Show()
    End Sub

    Private Sub actTabla()
        DataGridView2.Rows.Clear()
        DataGridView2.ColumnCount = 5

        DataGridView2.Columns(0).HeaderText = "Descripcion"
        DataGridView2.Columns(1).HeaderText = "Descripcion de Arancel"
        DataGridView2.Columns(2).HeaderText = "Fecha"
        DataGridView2.Columns(3).HeaderText = "Hora"
        DataGridView2.Columns(4).HeaderText = "Precio"

        For x As Integer = 0 To DataGridView1.RowCount - 1

            If IsDBNull(DataGridView1.Rows(x).Cells(1).Value) Then
                Dim fecha As String = DataGridView1.Rows(x).Cells(4).Value
                DataGridView2.Rows.Add(DataGridView1.Rows(x).Cells(0).Value, DataGridView1.Rows(x).Cells(3).Value, fecha, DataGridView1.Rows(x).Cells(5).Value, DataGridView1.Rows(x).Cells(6).Value)

            End If

        Next
        DataGridView2.ClearSelection()
        DataGridView2.AutoResizeColumns()
    End Sub
End Class