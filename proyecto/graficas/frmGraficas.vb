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
    Dim cont As Integer
    Dim extra As Integer
    Dim contador3d As Integer
    Dim perspectiva As Integer = 10
    Private Sub graficas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PnlSubmenu3d.Visible = False
        Pnl3d.Visible = True
        PnlTipo.Visible = True
        PnlGrafica.Visible = True
        PnlMenu.Location = New Point(PnlMenu.Location.X, PnlMenu.Location.Y - 464)
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



                Me.grafica.Series("Num pacientes").Points.AddY(intervalo1)

                Me.grafica.Series("Num pacientes").Points.AddY(intervalo2)
                Me.grafica.Series("Num pacientes").Points.AddY(intervalo3)
                Me.grafica.Series("Num pacientes").Points.AddY(intervalo4)
                Me.grafica.Series("Num pacientes").Points.AddY(intervalo5)
                Me.grafica.Series("Num pacientes").Points.AddY(intervalo6)
                Me.grafica.Series("Num pacientes").Points.AddY(intervalo7)
                Me.grafica.Series("Num pacientes").Points.AddY(intervalo8)
                Me.grafica.Series("Num pacientes").Points.AddY(intervalo9)
                Me.grafica.Series("Num pacientes").Points.AddY(intervalo10)
                Me.grafica.Series("Num pacientes").Points(0).AxisLabel = "0 a 10"
                Me.grafica.Series("Num pacientes").Points(1).AxisLabel = "11 a 20"
                Me.grafica.Series("Num pacientes").Points(2).AxisLabel = "21 a 30"
                Me.grafica.Series("Num pacientes").Points(3).AxisLabel = "31 a 40"
                Me.grafica.Series("Num pacientes").Points(4).AxisLabel = "41 a 50"
                Me.grafica.Series("Num pacientes").Points(5).AxisLabel = "51 a 60"
                Me.grafica.Series("Num pacientes").Points(6).AxisLabel = "61 a 70"
                Me.grafica.Series("Num pacientes").Points(7).AxisLabel = "71 a 80"
                Me.grafica.Series("Num pacientes").Points(8).AxisLabel = "81 a 90"
                Me.grafica.Series("Num pacientes").Points(9).AxisLabel = "Mayores de 90"



            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub

    Private Sub pbconfig_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbconfig.Click
        Movimiento.Start()

    End Sub

    Private Sub Lbl3d_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lbl3d.Click
        If PnlSubmenu3d.Visible = True Then
            PnlSubmenu3d.Visible = False
        Else
            PnlSubmenu3d.Visible = True
            PnlSubMenuDatos.Visible = False
        End If

    End Sub


    Private Sub Movimiento_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Movimiento.Tick
        PnlSubmenu3d.Visible = False
        PnlSubMenuDatos.Visible = False
        If extra = 0 Then
            If cont < 73 Then
                PnlMenu.Location = New Point(PnlMenu.Location.X, PnlMenu.Location.Y + 6)
                cont += 1
            Else
                Movimiento.Dispose()
                extra = 1
            End If
        Else
            If cont > 0 Then
                PnlMenu.Location = New Point(PnlMenu.Location.X, PnlMenu.Location.Y - 6)
                cont -= 1
            Else
                Movimiento.Dispose()
                extra = 0
            End If
        End If

    End Sub

    Private Sub LblTipo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblTipo.Click


    End Sub


    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
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

    Private Sub LblGrafica_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblGrafica.Click
        If PnlSubMenuDatos.Visible = True Then
            PnlSubMenuDatos.Visible = False
        Else
            PnlSubMenuDatos.Visible = True
            PnlSubmenu3d.Visible = False

        End If
    End Sub



    Private Sub pnldesplmenu_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnldesplmenu.MouseClick
        Movimiento.Start()
        PnlSubMenuDatos.Visible = False
        PnlSubmenu3d.Visible = False
        PnlPromedades.BackColor = Color.MidnightBlue

    End Sub

    Private Sub PnlPromedades_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles PnlPromedades.MouseEnter
        PnlPromedades.BackColor = Color.RoyalBlue
    End Sub

    Private Sub frmGraficas_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.MouseEnter
        PnlPromedades.BackColor = Color.MidnightBlue
        Pnlact3d.BackColor = Color.MidnightBlue
        pnlCambarPerspectiva.BackColor = Color.MidnightBlue
        PnlSubmenu3d.Visible = False
        PnlSubMenuDatos.Visible = False
    End Sub

    Private Sub PnlMenu_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles PnlMenu.MouseEnter
        PnlPromedades.BackColor = Color.MidnightBlue
        Pnlact3d.BackColor = Color.MidnightBlue
        pnlCambarPerspectiva.BackColor = Color.MidnightBlue
    End Sub


    Private Sub PnlSubMenuDatos_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles PnlSubMenuDatos.MouseEnter
        PnlPromedades.BackColor = Color.MidnightBlue
    End Sub


    Private Sub PnlGrafica_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles PnlGrafica.MouseEnter
        PnlPromedades.BackColor = Color.MidnightBlue
        Pnlact3d.BackColor = Color.MidnightBlue
        pnlCambarPerspectiva.BackColor = Color.MidnightBlue
    End Sub

    Private Sub LblActivar3d_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblActivar3d.Click
        If grafica.ChartAreas("Pacientes").Area3DStyle.Enable3D = False Then
            grafica.ChartAreas("Pacientes").Area3DStyle.Enable3D = True
        Else
            grafica.ChartAreas("Pacientes").Area3DStyle.Enable3D = False
        End If


    End Sub

    Private Sub Pnlact3d_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Pnlact3d.MouseEnter
        Pnlact3d.BackColor = Color.RoyalBlue
        pnlCambarPerspectiva.BackColor = Color.MidnightBlue
    End Sub

    Private Sub LblActivar3d_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles LblActivar3d.MouseEnter
        Pnlact3d.BackColor = Color.RoyalBlue
        pnlCambarPerspectiva.BackColor = Color.MidnightBlue
    End Sub

    Private Sub Pnl3d_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Pnl3d.MouseEnter
        Pnlact3d.BackColor = Color.MidnightBlue
    End Sub




    Private Sub grafica_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles grafica.MouseEnter
        PnlSubmenu3d.Visible = False
        PnlSubMenuDatos.Visible = False
    End Sub

    Private Sub PnlSubmenu3d_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles PnlSubmenu3d.MouseEnter
        Pnlact3d.BackColor = Color.MidnightBlue
    End Sub

    Private Sub lblCambiarPers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblCambiarPers.Click
        If perspectiva > 180 Then

            perspectiva = 0

        End If
        'grafica.ChartAreas("Paciente").Area3DStyle.Rotation += 10
        perspectiva += 10

    End Sub

   
    Private Sub lblCambiarPers_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblCambiarPers.MouseEnter
        pnlCambarPerspectiva.BackColor = Color.RoyalBlue
        Pnlact3d.BackColor = Color.MidnightBlue
    End Sub

    Private Sub pnlCambarPerspectiva_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles pnlCambarPerspectiva.MouseEnter
        pnlCambarPerspectiva.BackColor = Color.RoyalBlue
        Pnlact3d.BackColor = Color.MidnightBlue
    End Sub

  
End Class