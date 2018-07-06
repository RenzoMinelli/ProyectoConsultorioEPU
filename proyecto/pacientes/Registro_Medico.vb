Public Class Registro_Medico
    Dim a As Integer = 0
    Dim xco, yco As Integer
    Dim xc, yc As Integer

    Private Sub Registro_Medico_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        actPos()
        Consulta = "Select * from registro_medico where id_p = '" + Str(id_p) + "'"
        consultar()
        DataGridView1.DataSource = Tabla
        actBoca()
    End Sub

    Private Sub actBoca()
        Dim zona As String = ""
        For x As Integer = 0 To DataGridView1.RowCount - 1

            If Not IsDBNull(DataGridView1.Rows(x).Cells(2).Value) Then
                Select Case DataGridView1.Rows(x).Cells(2).Value

                    Case "nor-oeste"
                        zona = "1"
                    Case "nor-este"
                        zona = "2"
                    Case "sur-oeste"
                        zona = "3"
                    Case "sur-este"
                        zona = "4"

                End Select

                zona += DataGridView1.Rows(x).Cells(3).Value.ToString

                Select Case zona
                    Case "11"
                        If DataGridView1.Rows(x).Cells(1).Value = "malo" Then
                            Panel11.BackColor = Color.Red
                        ElseIf DataGridView1.Rows(x).Cells(1).Value = "bueno" Then
                            Panel11.BackColor = Color.Green
                        Else
                            Panel11.BackColor = Color.White
                        End If
                    Case "12"
                        If DataGridView1.Rows(x).Cells(1).Value = "malo" Then
                            Panel12.BackColor = Color.Red
                        ElseIf DataGridView1.Rows(x).Cells(1).Value = "bueno" Then
                            Panel12.BackColor = Color.Green
                        Else
                            Panel12.BackColor = Color.White
                        End If
                    Case "24"

                        If DataGridView1.Rows(x).Cells(1).Value = "malo" Then
                            Panel24.BackColor = Color.Red
                        ElseIf DataGridView1.Rows(x).Cells(1).Value = "bueno" Then
                            Panel24.BackColor = Color.Green
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
End Class