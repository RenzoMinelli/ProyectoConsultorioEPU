Public Class frmGraficas
    Dim intervalo1 As Integer
    Dim intervalo2 As Integer
    Dim intervalo3 As Integer
    Dim intervalo4 As Integer
    Dim intervalo5 As Integer
    Dim intervalo6 As Integer
    Dim intervalo7 As Integer
    Dim intervalo8 As Integer
    Dim intervalo9 As Integer
    Dim intervalo10 As Integer
    Dim fc As Date
    Private Sub graficas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Consulta = "SELECT count(*), TIMESTAMPDIFF(YEAR,fecha_nacimiento,CURDATE()) from paciente group by 2;"
            consultar()
            dgvInfo.DataSource = Tabla

            For cuentaceldas = 0 To dgvInfo.RowCount - 1
                Dim edad As Integer = dgvInfo.Rows(cuentaceldas).Cells(1).Value
                If edad >= 0 And edad <= 10 Then

                    If intervalo1 = 0 Then
                        intervalo1 = dgvInfo.Rows(0).Cells(0).Value

                    Else
                        intervalo1 = intervalo1 + dgvInfo.Rows(cuentaceldas).Cells(0).Value
                    End If
                ElseIf edad > 10 And edad <= 20 Then
                    If intervalo2 = 0 Then
                        intervalo2 = dgvInfo.Rows(0).Cells(0).Value

                    Else
                        intervalo2 = intervalo2 + dgvInfo.Rows(cuentaceldas).Cells(0).Value
                    End If
                ElseIf edad > 20 And edad <= 30 Then
                    If intervalo3 = 0 Then
                        intervalo3 = dgvInfo.Rows(0).Cells(0).Value

                    Else
                        intervalo3 = intervalo3 + dgvInfo.Rows(cuentaceldas).Cells(0).Value
                    End If
                ElseIf edad > 30 And edad <= 40 Then
                    If intervalo4 = 0 Then
                        intervalo4 = dgvInfo.Rows(0).Cells(0).Value

                    Else
                        intervalo4 = intervalo4 + dgvInfo.Rows(cuentaceldas).Cells(0).Value
                    End If
                ElseIf edad > 40 And edad <= 50 Then
                    If intervalo5 = 0 Then
                        intervalo5 = dgvInfo.Rows(0).Cells(0).Value

                    Else
                        intervalo5 = intervalo5 + dgvInfo.Rows(cuentaceldas).Cells(0).Value
                    End If
                    If edad > 50 And edad <= 60 Then
                        If intervalo6 = 0 Then
                            intervalo6 = dgvInfo.Rows(0).Cells(0).Value

                        Else
                            intervalo6 = intervalo6 + dgvInfo.Rows(cuentaceldas).Cells(0).Value
                        End If
                    ElseIf edad > 60 And edad <= 70 Then
                        If intervalo7 = 0 Then
                            intervalo7 = dgvInfo.Rows(0).Cells(0).Value

                        Else
                            intervalo7 = intervalo7 + dgvInfo.Rows(cuentaceldas).Cells(0).Value
                        End If
                    ElseIf edad > 70 And edad <= 80 Then
                        If intervalo8 = 0 Then
                            intervalo8 = dgvInfo.Rows(0).Cells(0).Value

                        Else
                            intervalo8 = intervalo8 + dgvInfo.Rows(cuentaceldas).Cells(0).Value
                        End If
                    ElseIf edad > 80 And edad <= 90 Then
                        If intervalo9 = 0 Then
                            intervalo9 = dgvInfo.Rows(0).Cells(0).Value

                        Else
                            intervalo9 = intervalo9 + dgvInfo.Rows(cuentaceldas).Cells(0).Value
                        End If
                    ElseIf edad > 90 Then
                        If intervalo10 = 0 Then
                            intervalo10 = dgvInfo.Rows(0).Cells(0).Value

                        Else
                            intervalo10 = intervalo10 + dgvInfo.Rows(cuentaceldas).Cells(0).Value
                        End If
                    End If
                End If

            Next
            'grafica.Series.Clear()
            'grafica.ChartAreas.Clear()

            'grafica.Series.Add("Num pacientes")
            'grafica.ChartAreas.Add("Num pacientes")


            Me.grafica.Series("Num pacientes").Points.AddXY("0-10", intervalo1)
            Me.grafica.Series("Num pacientes").Points.AddXY("10-20", intervalo2)
            Me.grafica.Series("Num pacientes").Points.AddXY("20-30", intervalo3)
            Me.grafica.Series("Num pacientes").Points.AddXY("30-40", intervalo4)
            Me.grafica.Series("Num pacientes").Points.AddXY("40-50", intervalo5)
            Me.grafica.Series("Num pacientes").Points.AddXY("50-60", intervalo6)
            Me.grafica.Series("Num pacientes").Points.AddXY("60-70", intervalo7)
            Me.grafica.Series("Num pacientes").Points.AddXY("70-80", intervalo8)
            Me.grafica.Series("Num pacientes").Points.AddXY("80-90", intervalo9)
            Me.grafica.Series("Num pacientes").Points.AddXY("+90", intervalo10)



        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub
End Class