Public Class frmGraficas
    Dim intervalo1 As String
    Dim intervalo2 As String
    Dim intervalo3 As String
    Dim intervalo4 As String
    Dim intervalo5 As String
    Dim intervalo6 As String
    Dim intervalo7 As String
    Dim intervalo8 As String
    Dim intervalo9 As String
    Dim intervalo10 As String
    Dim fc As Date
    Dim menusuito As Integer = 0
    Dim edadespacientes As Integer = 0
    Dim listaResultados() As Integer
    Private Sub graficas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If edadespacientes = 0 Then
            Try
                edadespacientes = 1
                Consulta = "SELECT SUM(IF (TIMESTAMPDIFF(YEAR,fecha_nacimiento,CURDATE()) BETWEEN 1 AND 10, 1, 0)) AS '0-10', SUM(IF (TIMESTAMPDIFF(YEAR,fecha_nacimiento,CURDATE()) BETWEEN 11 AND 20, 1, 0)) AS '11-20', SUM(IF (TIMESTAMPDIFF(YEAR,fecha_nacimiento,CURDATE()) BETWEEN 21 AND 30, 1, 0)) AS '21-30', SUM(IF (TIMESTAMPDIFF(YEAR,fecha_nacimiento,CURDATE()) BETWEEN 31 AND 40, 1, 0)) AS '31-40', SUM(IF (TIMESTAMPDIFF(YEAR,fecha_nacimiento,CURDATE()) BETWEEN 41 AND 50, 1, 0)) AS '41-50', SUM(IF (TIMESTAMPDIFF(YEAR,fecha_nacimiento,CURDATE()) BETWEEN 51 AND 60, 1, 0)) AS '51-60', SUM(IF (TIMESTAMPDIFF(YEAR,fecha_nacimiento,CURDATE()) BETWEEN 61 AND 70, 1, 0)) AS '61-70', SUM(IF (TIMESTAMPDIFF(YEAR,fecha_nacimiento,CURDATE()) BETWEEN 71 AND 80, 1, 0)) AS '71-80',SUM(IF (TIMESTAMPDIFF(YEAR,fecha_nacimiento,CURDATE()) BETWEEN 81 AND 90, 1, 0)) AS '81-90',SUM(IF (TIMESTAMPDIFF(YEAR,fecha_nacimiento,CURDATE()) > 90, 1, 0)) AS '+90' FROM paciente;"

                consultar()
                'dgvInfo.DataSource = Tabla

                grafica.Series("Num pacientes").XValueMember = "0-10"
                grafica.Series("Num pacientes").XValueMember = "11-20"
                grafica.Series("Num pacientes").XValueMember = "21-30"
                grafica.Series("Num pacientes").XValueMember = "31-40"
                grafica.Series("Num pacientes").XValueMember = "41-50"
                grafica.Series("Num pacientes").XValueMember = "51-60"
                grafica.Series("Num pacientes").XValueMember = "61-70"
                grafica.Series("Num pacientes").XValueMember = "71-80"
                grafica.Series("Num pacientes").XValueMember = "81-90"
                grafica.Series("Num pacientes").XValueMember = "+90"
                'grafica.Series("Num pacientes").YValueMembers = "cantidad"
                grafica.DataSource = Tabla

                'intervalo1 = dgvInfo.Rows(0).Cells(0).Value.ToString
                'intervalo2 = dgvInfo.Rows(0).Cells(1).Value.ToString
                'intervalo3 = dgvInfo.Rows(0).Cells(2).Value.ToString
                'intervalo4 = dgvInfo.Rows(0).Cells(3).Value.ToString
                'intervalo5 = dgvInfo.Rows(0).Cells(4).Value.ToString
                'intervalo6 = dgvInfo.Rows(0).Cells(5).Value.ToString
                'intervalo7 = dgvInfo.Rows(0).Cells(6).Value.ToString
                'intervalo8 = dgvInfo.Rows(0).Cells(7).Value.ToString
                'intervalo9 = dgvInfo.Rows(0).Cells(8).Value.ToString
                'intervalo10 = dgvInfo.Rows(0).Cells(9).Value.ToString



                'Me.grafica.Series("Num pacientes").Points.AddXY("0-10", intervalo1)
                'Me.grafica.Series("Num pacientes").Points.AddXY("11-20", intervalo2)
                'Me.grafica.Series("Num pacientes").Points.AddXY("21-30", intervalo3)
                'Me.grafica.Series("Num pacientes").Points.AddXY("31-40", intervalo4)
                'Me.grafica.Series("Num pacientes").Points.AddXY("41-50", intervalo5)
                'Me.grafica.Series("Num pacientes").Points.AddXY("51-60", intervalo6)
                'Me.grafica.Series("Num pacientes").Points.AddXY("61-70", intervalo7)
                'Me.grafica.Series("Num pacientes").Points.AddXY("71-80", intervalo8)
                'Me.grafica.Series("Num pacientes").Points.AddXY("81-90", intervalo9)
                'Me.grafica.Series("Num pacientes").Points.AddXY("+90", intervalo10)



            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub

    Private Sub pbconfig_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbconfig.Click


        If menusuito = 0 Then
            abrirmenu()
        Else
            cerrarmenu()

        End If


    End Sub
    Public Sub abrirmenu()
        menusuito = 1
        Movimiento.Enabled = True


    End Sub
    Public Sub cerrarmenu()
        menusuito = 0
        Movimiento.Enabled = True


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
    End Sub

    Private Sub Lbl3d_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lbl3d.Click
        grafica.ChartAreas("Pacientes").Area3DStyle.Enable3D = True

    End Sub


    Private Sub Movimiento_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Movimiento.Tick


        If menusuito = 0 And PnlMenu.Location.X > 1002 Then
            PnlMenu.Location = New Point(PnlMenu.Location.X + 6, PnlMenu.Location.Y)
            Label1.Text = PnlMenu.Location.X
        ElseIf menusuito = 1 Then
            PnlMenu.Location = New Point(PnlMenu.Location.X - 6, PnlMenu.Location.Y)
        End If


    End Sub

    Private Sub LblTipo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblTipo.Click
        ' grafica.ChartAreas("pacientes").
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        If edadespacientes = 0 Then
            Try
                edadespacientes = 1
                Consulta = "SELECT SUM(IF (TIMESTAMPDIFF(YEAR,fecha_nacimiento,CURDATE()) BETWEEN 1 AND 10, 1, 0)) AS '0-10', SUM(IF (TIMESTAMPDIFF(YEAR,fecha_nacimiento,CURDATE()) BETWEEN 11 AND 20, 1, 0)) AS '11-20', SUM(IF (TIMESTAMPDIFF(YEAR,fecha_nacimiento,CURDATE()) BETWEEN 21 AND 30, 1, 0)) AS '21-30', SUM(IF (TIMESTAMPDIFF(YEAR,fecha_nacimiento,CURDATE()) BETWEEN 31 AND 40, 1, 0)) AS '31-40', SUM(IF (TIMESTAMPDIFF(YEAR,fecha_nacimiento,CURDATE()) BETWEEN 41 AND 50, 1, 0)) AS '41-50', SUM(IF (TIMESTAMPDIFF(YEAR,fecha_nacimiento,CURDATE()) BETWEEN 51 AND 60, 1, 0)) AS '51-60', SUM(IF (TIMESTAMPDIFF(YEAR,fecha_nacimiento,CURDATE()) BETWEEN 61 AND 70, 1, 0)) AS '61-70', SUM(IF (TIMESTAMPDIFF(YEAR,fecha_nacimiento,CURDATE()) BETWEEN 71 AND 80, 1, 0)) AS '71-80',SUM(IF (TIMESTAMPDIFF(YEAR,fecha_nacimiento,CURDATE()) BETWEEN 81 AND 90, 1, 0)) AS '81-90',SUM(IF (TIMESTAMPDIFF(YEAR,fecha_nacimiento,CURDATE()) > 90, 1, 0)) AS '+90' FROM paciente;"

                consultar()


                dgvInfo.DataSource = Tabla

                intervalo1 = dgvInfo.Rows(0).Cells(0).Value.ToString
                intervalo2 = dgvInfo.Rows(0).Cells(1).Value.ToString
                intervalo3 = dgvInfo.Rows(0).Cells(2).Value.ToString
                intervalo4 = dgvInfo.Rows(0).Cells(3).Value.ToString
                intervalo5 = dgvInfo.Rows(0).Cells(4).Value.ToString
                intervalo6 = dgvInfo.Rows(0).Cells(5).Value.ToString
                intervalo7 = dgvInfo.Rows(0).Cells(6).Value.ToString
                intervalo8 = dgvInfo.Rows(0).Cells(7).Value.ToString
                intervalo9 = dgvInfo.Rows(0).Cells(8).Value.ToString
                intervalo10 = dgvInfo.Rows(0).Cells(9).Value.ToString



                Me.grafica.Series("Num pacientes").Points.AddXY("0-10", intervalo1)
                Me.grafica.Series("Num pacientes").Points.AddXY("11-20", intervalo2)
                Me.grafica.Series("Num pacientes").Points.AddXY("21-30", intervalo3)
                Me.grafica.Series("Num pacientes").Points.AddXY("31-40", intervalo4)
                Me.grafica.Series("Num pacientes").Points.AddXY("41-50", intervalo5)
                Me.grafica.Series("Num pacientes").Points.AddXY("51-60", intervalo6)
                Me.grafica.Series("Num pacientes").Points.AddXY("61-70", intervalo7)
                Me.grafica.Series("Num pacientes").Points.AddXY("71-80", intervalo8)
                Me.grafica.Series("Num pacientes").Points.AddXY("81-90", intervalo9)
                Me.grafica.Series("Num pacientes").Points.AddXY("90+", intervalo10)



            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub

    Private Sub grafica_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grafica.Click

    End Sub
End Class