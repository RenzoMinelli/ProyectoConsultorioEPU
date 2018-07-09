Public Class Registro_Medico
   
    '///////////////////////////////////////////////////////////////////////
    '/ No se por que aparece la fecha con la hora al lado,
    '/ eso está para arreglar.
    '/
    '///////////////////////////////////////////////////////////////////////
    Private Sub Registro_Medico_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Consulta = "Select r.descripcion as 'Descripcion', zona as 'Zona', nro_diente as 'Numero de Diente',a.descripcion as 'Descripcion de Arancel',c.fecha as 'Fecha',hora as 'Hora', precio as 'Precio' from registro_medico r left join aranceles a on a.id_a = r.id_a left join cita c on c.id_c = r.id_c where r.id_p = '" + Str(id_p) + "'"
            consultar()
            DataGridView1.DataSource = Tabla
            actBoca()
            actTabla()
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

                Select Case zona
                    Case "11"
                        If DataGridView1.Rows(x).Cells(0).Value = "malo" Then
                            Panel11.BackColor = Color.Red
                        ElseIf DataGridView1.Rows(x).Cells(0).Value = "precaucion" Then
                            Panel11.BackColor = Color.Yellow
                        Else
                            Panel11.BackColor = Color.White
                        End If
                    Case "12"
                        If DataGridView1.Rows(x).Cells(0).Value = "malo" Then
                            Panel12.BackColor = Color.Red
                        ElseIf DataGridView1.Rows(x).Cells(0).Value = "precaucion" Then
                            Panel12.BackColor = Color.Yellow
                        Else
                            Panel12.BackColor = Color.White
                        End If
                    Case "24"

                        If DataGridView1.Rows(x).Cells(0).Value = "malo" Then
                            Panel24.BackColor = Color.Red
                        ElseIf DataGridView1.Rows(x).Cells(0).Value = "precaucion" Then
                            Panel24.BackColor = Color.Yellow
                        Else
                            Panel24.BackColor = Color.White
                        End If


                End Select
            End If
        Next
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

                DataGridView2.Rows.Add(DataGridView1.Rows(x).Cells(0).Value, DataGridView1.Rows(x).Cells(3).Value, DataGridView1.Rows(x).Cells(4).Value, DataGridView1.Rows(x).Cells(5).Value, DataGridView1.Rows(x).Cells(6).Value)

            End If

        Next

    End Sub
End Class