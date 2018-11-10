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
    Dim mausito As Integer = 0
    Dim perspectiva As Integer = 10
    Dim tratamientos As Integer = 0
    Dim bandera As Integer = 0
    Dim tratamiento1 As Integer
    Dim tratamiento2 As Integer
    Dim tratamiento3 As Integer
    Dim tratamiento4 As Integer
    Dim tratamiento5 As Integer
    Dim nomtratamiento1 As String
    Dim nomtratamiento2 As String
    Dim nomtratamiento3 As String
    Dim nomtratamiento4 As String
    Dim nomtratamiento5 As String
    Dim idtratamiento1 As Integer
    Dim idtratamiento2 As Integer
    Dim idtratamiento3 As Integer
    Dim idtratamiento4 As Integer
    Dim idtratamiento5 As Integer


   


    Private Sub graficas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        grafica.Series.Clear()
        grafica.Series.Add("Número de Pacientes")

        dtpAnio.Hide()
        lblAnio.Hide()
        grafica.ChartAreas("Pacientes").Area3DStyle.Enable3D = True

        PnlSubmenu3d.Visible = False
        pnlModo3D.Visible = True
        pnlDatosGrafica.Visible = True

        pnlMenu.Location = New Point(pnlMenu.Location.X, pnlMenu.Location.Y - (pnlMenu.Height + pnlDesplMenu.Height))

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

                Me.grafica.Series("Número de Pacientes").Points.AddY(intervalo1)
                Me.grafica.Series("Número de Pacientes").Points.AddY(intervalo2)
                Me.grafica.Series("Número de Pacientes").Points.AddY(intervalo3)
                Me.grafica.Series("Número de Pacientes").Points.AddY(intervalo4)
                Me.grafica.Series("Número de Pacientes").Points.AddY(intervalo5)
                Me.grafica.Series("Número de Pacientes").Points.AddY(intervalo6)
                Me.grafica.Series("Número de Pacientes").Points.AddY(intervalo7)
                Me.grafica.Series("Número de Pacientes").Points.AddY(intervalo8)
                Me.grafica.Series("Número de Pacientes").Points.AddY(intervalo9)
                Me.grafica.Series("Número de Pacientes").Points.AddY(intervalo10)
                Me.grafica.Series("Número de Pacientes").Points(0).AxisLabel = "0-10"
                Me.grafica.Series("Número de Pacientes").Points(1).AxisLabel = "11-20"
                Me.grafica.Series("Número de Pacientes").Points(2).AxisLabel = "21-30"
                Me.grafica.Series("Número de Pacientes").Points(3).AxisLabel = "31-40"
                Me.grafica.Series("Número de Pacientes").Points(4).AxisLabel = "41-50"
                Me.grafica.Series("Número de Pacientes").Points(5).AxisLabel = "51-60"
                Me.grafica.Series("Número de Pacientes").Points(6).AxisLabel = "61-70"
                Me.grafica.Series("Número de Pacientes").Points(7).AxisLabel = "71-80"
                Me.grafica.Series("Número de Pacientes").Points(8).AxisLabel = "81-90"
                Me.grafica.Series("Número de Pacientes").Points(9).AxisLabel = "90+"

            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If



    End Sub

    Private Sub pbconfig_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbconfig.Click
        TmrMovimiento.Start()
        PnlSubMenuDatosGrafica.Visible = False
        PnlSubmenu3d.Visible = False
        pnlSubMenuCambiarPerspectiva.Visible = False

    End Sub

    Private Sub Lbl3d_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblModo3D.Click

        If grafica.ChartAreas("Pacientes").Area3DStyle.Enable3D = True Then
            pnlPerspectiva.Visible = True
        Else
            pnlPerspectiva.Visible = False
        End If

        If PnlSubmenu3d.Visible = True Then
            PnlSubmenu3d.Visible = False
            pnlSubMenuCambiarPerspectiva.Visible = False
        Else
            PnlSubmenu3d.Visible = True
            PnlSubMenuDatosGrafica.Visible = False
        End If

    End Sub


    Private Sub Movimiento_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TmrMovimiento.Tick

        If extra = 0 Then
            If cont < 27 Then
                pnlMenu.Location = New Point(pnlMenu.Location.X, pnlMenu.Location.Y + 7)
                cont += 1
            Else
                TmrMovimiento.Dispose()
                extra = 1
            End If
        Else
            If cont > 0 Then
                pnlMenu.Location = New Point(pnlMenu.Location.X, pnlMenu.Location.Y - 7)
                cont -= 1
            Else
                TmrMovimiento.Dispose()
                extra = 0
            End If
        End If

    End Sub


    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblEdadPaciente.Click

        dtpAnio.Hide()
        lblAnio.Hide()

        Try

            grafica.Series.Clear()
            grafica.Series.Add("Número de Pacientes")
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



            Me.grafica.Series("Número de Pacientes").Points.AddXY("0-10", intervalo1)
            Me.grafica.Series("Número de Pacientes").Points.AddXY("11-20", intervalo2)
            Me.grafica.Series("Número de Pacientes").Points.AddXY("21-30", intervalo3)
            Me.grafica.Series("Número de Pacientes").Points.AddXY("31-40", intervalo4)
            Me.grafica.Series("Número de Pacientes").Points.AddXY("41-50", intervalo5)
            Me.grafica.Series("Número de Pacientes").Points.AddXY("51-60", intervalo6)
            Me.grafica.Series("Número de Pacientes").Points.AddXY("61-70", intervalo7)
            Me.grafica.Series("Número de Pacientes").Points.AddXY("71-80", intervalo8)
            Me.grafica.Series("Número de Pacientes").Points.AddXY("81-90", intervalo9)
            Me.grafica.Series("Número de Pacientes").Points.AddXY("90+", intervalo10)



        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub LblGrafica_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblDatosGrafica.Click
        If PnlSubMenuDatosGrafica.Visible = True Then
            PnlSubMenuDatosGrafica.Visible = False
        Else
            PnlSubMenuDatosGrafica.Visible = True
            PnlSubmenu3d.Visible = False
            pnlSubMenuCambiarPerspectiva.Visible = False
        End If
    End Sub



    Private Sub pnldesplmenu_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnlDesplMenu.MouseClick
        TmrMovimiento.Start()
        PnlSubMenuDatosGrafica.Visible = False
        PnlSubmenu3d.Visible = False
        pnlSubMenuCambiarPerspectiva.Visible = False


    End Sub

    Private Sub PnlPromedades_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnlEdadPaciente.MouseClick

        dtpAnio.Hide()
        lblAnio.Hide()

        Try

            grafica.Series.Clear()
            grafica.Series.Add("Número de Pacientes")
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



            Me.grafica.Series("Número de Pacientes").Points.AddXY("0-10", intervalo1)
            Me.grafica.Series("Número de Pacientes").Points.AddXY("11-20", intervalo2)
            Me.grafica.Series("Número de Pacientes").Points.AddXY("21-30", intervalo3)
            Me.grafica.Series("Número de Pacientes").Points.AddXY("31-40", intervalo4)
            Me.grafica.Series("Número de Pacientes").Points.AddXY("41-50", intervalo5)
            Me.grafica.Series("Número de Pacientes").Points.AddXY("51-60", intervalo6)
            Me.grafica.Series("Número de Pacientes").Points.AddXY("61-70", intervalo7)
            Me.grafica.Series("Número de Pacientes").Points.AddXY("71-80", intervalo8)
            Me.grafica.Series("Número de Pacientes").Points.AddXY("81-90", intervalo9)
            Me.grafica.Series("Número de Pacientes").Points.AddXY("90+", intervalo10)



        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub PnlPromedades_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles pnlEdadPaciente.MouseEnter
        pnlEdadPaciente.BackColor = Color.MidnightBlue
        PnlTratamientos.BackColor = Color.RoyalBlue

        pnlNumCitas.BackColor = Color.RoyalBlue
    End Sub

    Private Sub frmGraficas_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.MouseEnter
        pnlEdadPaciente.BackColor = Color.RoyalBlue
        pnlActivar3D.BackColor = Color.RoyalBlue
        pnlPerspectiva.BackColor = Color.RoyalBlue
        PnlSubmenu3d.Visible = False
        PnlSubMenuDatosGrafica.Visible = False
    End Sub

    Private Sub PnlMenu_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles pnlMenu.MouseEnter
        pnlEdadPaciente.BackColor = Color.RoyalBlue
        pnlActivar3D.BackColor = Color.RoyalBlue
        pnlPerspectiva.BackColor = Color.RoyalBlue
    End Sub


    Private Sub PnlSubMenuDatos_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles PnlSubMenuDatosGrafica.MouseEnter
        pnlEdadPaciente.BackColor = Color.RoyalBlue
    End Sub

    Private Sub pnlDatosGrafica_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnlDatosGrafica.MouseClick
        If PnlSubMenuDatosGrafica.Visible = True Then
            PnlSubMenuDatosGrafica.Visible = False
        Else
            PnlSubMenuDatosGrafica.Visible = True
            PnlSubmenu3d.Visible = False
            pnlSubMenuCambiarPerspectiva.Visible = False
        End If
    End Sub


    Private Sub PnlGrafica_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles pnlDatosGrafica.MouseEnter
        pnlDatosGrafica.BackColor = Color.MidnightBlue
        pnlEdadPaciente.BackColor = Color.RoyalBlue
        pnlActivar3D.BackColor = Color.RoyalBlue
        pnlPerspectiva.BackColor = Color.RoyalBlue
    End Sub

    Private Sub LblActivar3d_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblActivar3D.Click

        If grafica.ChartAreas("Pacientes").Area3DStyle.Enable3D = False Then
            grafica.ChartAreas("Pacientes").Area3DStyle.Enable3D = True
            pnlPerspectiva.Visible = True
            lblCambiarPerspectiva.Visible = True
        Else
            grafica.ChartAreas("Pacientes").Area3DStyle.Enable3D = False
            pnlPerspectiva.Visible = False
            lblCambiarPerspectiva.Visible = False
            pnlSubMenuCambiarPerspectiva.Visible = False
        End If


    End Sub

    Private Sub Pnlact3d_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnlActivar3D.MouseClick
        If grafica.ChartAreas("Pacientes").Area3DStyle.Enable3D = False Then
            grafica.ChartAreas("Pacientes").Area3DStyle.Enable3D = True
            pnlPerspectiva.Visible = True
            lblCambiarPerspectiva.Visible = True
        Else
            grafica.ChartAreas("Pacientes").Area3DStyle.Enable3D = False
            pnlPerspectiva.Visible = False
            lblCambiarPerspectiva.Visible = False
            pnlSubMenuCambiarPerspectiva.Visible = False
        End If
    End Sub

    Private Sub Pnlact3d_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles pnlActivar3D.MouseEnter
        pnlActivar3D.BackColor = Color.MidnightBlue
        pnlPerspectiva.BackColor = Color.RoyalBlue
    End Sub

    Private Sub LblActivar3d_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblActivar3D.MouseEnter
        pnlActivar3D.BackColor = Color.MidnightBlue
        pnlPerspectiva.BackColor = Color.RoyalBlue
    End Sub

    Private Sub grafica_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles grafica.MouseEnter
        PnlSubmenu3d.Visible = False
        PnlSubMenuDatosGrafica.Visible = False
        pnlSubMenuCambiarPerspectiva.Visible = False
    End Sub

    Private Sub PnlSubmenu3d_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles PnlSubmenu3d.MouseEnter
        pnlActivar3D.BackColor = Color.RoyalBlue

    End Sub

    Private Sub lblCambiarPers_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblCambiarPerspectiva.MouseEnter
        pnlPerspectiva.BackColor = Color.MidnightBlue
        pnlActivar3D.BackColor = Color.RoyalBlue
    End Sub

    Private Sub pnlCambarPerspectiva_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnlPerspectiva.MouseClick
        pnlSubMenuCambiarPerspectiva.Visible = True
    End Sub

    Private Sub pnlCambarPerspectiva_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles pnlPerspectiva.MouseEnter
        pnlPerspectiva.BackColor = Color.MidnightBlue
        pnlActivar3D.BackColor = Color.RoyalBlue
    End Sub


    Private Sub pnldesplmenu_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles pnlDesplMenu.MouseEnter
        PnlSubmenu3d.Visible = False
        pnlSubMenuCambiarPerspectiva.Visible = False
        PnlSubMenuDatosGrafica.Visible = False
    End Sub

    Private Sub PnlTratamientos_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PnlTratamientos.MouseClick
        Dim numero As Integer = 0
        dtpAnio.Hide()
        lblAnio.Hide()
        Try
            Consulta = "select count(*) from plan_tratamiento group by id_a;"
            consultar()

            For Each row In Tabla.Rows
                numero += 1
            Next
        Catch ex As Exception

        End Try


        Select Case numero

            Case 0
                MsgBox("No hay tratamientos realizados", MsgBoxStyle.Information)

            Case 1
                Try
                    grafica.Series.Clear()
                    grafica.Series.Add("Total Tratamientos más usados")

                    Consulta = "select count(*), p.id_a , a.descripcion from plan_tratamiento p left join aranceles a on a.id_a = p.id_a group by p.id_a order by 1 desc;"
                    consultar()
                    DgvTratamientos.DataSource = Tabla


                    tratamiento1 = DgvTratamientos.Rows(0).Cells(0).Value

                    nomtratamiento1 = DgvTratamientos.Rows(0).Cells(2).Value.ToString

                    Me.grafica.Series("Total Tratamientos más usados").Points.AddY(tratamiento1)

                    Me.grafica.Series("Total Tratamientos más usados").Points(0).AxisLabel = nomtratamiento1

                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            Case 2
                Try
                    grafica.Series.Clear()
                    grafica.Series.Add("Total Tratamientos más usados")

                    Consulta = "select count(*), p.id_a , a.descripcion from plan_tratamiento p left join aranceles a on a.id_a = p.id_a group by p.id_a order by 1 desc;"
                    consultar()
                    DgvTratamientos.DataSource = Tabla


                    tratamiento1 = DgvTratamientos.Rows(0).Cells(0).Value
                    tratamiento2 = DgvTratamientos.Rows(1).Cells(0).Value

                    nomtratamiento1 = DgvTratamientos.Rows(0).Cells(2).Value.ToString

                    nomtratamiento2 = DgvTratamientos.Rows(1).Cells(2).Value.ToString


                    Me.grafica.Series("Total Tratamientos más usados").Points.AddY(tratamiento1)
                    Me.grafica.Series("Total Tratamientos más usados").Points.AddY(tratamiento2)

                    Me.grafica.Series("Total Tratamientos más usados").Points(0).AxisLabel = nomtratamiento1
                    Me.grafica.Series("Total Tratamientos más usados").Points(1).AxisLabel = nomtratamiento2




                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            Case 3
                Try
                    grafica.Series.Clear()
                    grafica.Series.Add("Total Tratamientos más usados")

                    Consulta = "select count(*), p.id_a , a.descripcion from plan_tratamiento p left join aranceles a on a.id_a = p.id_a group by p.id_a order by 1 desc;"
                    consultar()
                    DgvTratamientos.DataSource = Tabla

                    tratamiento1 = DgvTratamientos.Rows(0).Cells(0).Value
                    tratamiento2 = DgvTratamientos.Rows(1).Cells(0).Value
                    tratamiento3 = DgvTratamientos.Rows(2).Cells(0).Value

                    nomtratamiento1 = DgvTratamientos.Rows(0).Cells(2).Value.ToString

                    nomtratamiento2 = DgvTratamientos.Rows(1).Cells(2).Value.ToString

                    nomtratamiento3 = DgvTratamientos.Rows(2).Cells(2).Value.ToString


                    Me.grafica.Series("Total Tratamientos más usados").Points.AddY(tratamiento1)
                    Me.grafica.Series("Total Tratamientos más usados").Points.AddY(tratamiento2)
                    Me.grafica.Series("Total Tratamientos más usados").Points.AddY(tratamiento3)

                    Me.grafica.Series("Total Tratamientos más usados").Points(0).AxisLabel = nomtratamiento1
                    Me.grafica.Series("Total Tratamientos más usados").Points(1).AxisLabel = nomtratamiento2
                    Me.grafica.Series("Total Tratamientos más usados").Points(2).AxisLabel = nomtratamiento3




                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            Case 4
                Try
                    grafica.Series.Clear()
                    grafica.Series.Add("Total Tratamientos más usados")

                    Consulta = "select count(*), p.id_a , a.descripcion from plan_tratamiento p left join aranceles a on a.id_a = p.id_a group by p.id_a order by 1 desc;"
                    consultar()
                    DgvTratamientos.DataSource = Tabla

                    tratamiento1 = DgvTratamientos.Rows(0).Cells(0).Value
                    tratamiento2 = DgvTratamientos.Rows(1).Cells(0).Value
                    tratamiento3 = DgvTratamientos.Rows(2).Cells(0).Value
                    tratamiento4 = DgvTratamientos.Rows(3).Cells(0).Value

                    nomtratamiento1 = DgvTratamientos.Rows(0).Cells(2).Value.ToString

                    nomtratamiento2 = DgvTratamientos.Rows(1).Cells(2).Value.ToString

                    nomtratamiento3 = DgvTratamientos.Rows(2).Cells(2).Value.ToString

                    nomtratamiento4 = DgvTratamientos.Rows(3).Cells(2).Value.ToString

                    nomtratamiento5 = DgvTratamientos.Rows(4).Cells(2).Value.ToString

                    Me.grafica.Series("Total Tratamientos más usados").Points.AddY(tratamiento1)
                    Me.grafica.Series("Total Tratamientos más usados").Points.AddY(tratamiento2)
                    Me.grafica.Series("Total Tratamientos más usados").Points.AddY(tratamiento3)
                    Me.grafica.Series("Total Tratamientos más usados").Points.AddY(tratamiento4)

                    Me.grafica.Series("Total Tratamientos más usados").Points(0).AxisLabel = nomtratamiento1
                    Me.grafica.Series("Total Tratamientos más usados").Points(1).AxisLabel = nomtratamiento2
                    Me.grafica.Series("Total Tratamientos más usados").Points(2).AxisLabel = nomtratamiento3
                    Me.grafica.Series("Total Tratamientos más usados").Points(3).AxisLabel = nomtratamiento4



                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try

            Case 5
                Try
                    grafica.Series.Clear()
                    grafica.Series.Add("Total Tratamientos más usados")

                    Consulta = "select count(*), p.id_a , a.descripcion from plan_tratamiento p left join aranceles a on a.id_a = p.id_a group by p.id_a order by 1 desc;"
                    consultar()
                    DgvTratamientos.DataSource = Tabla

                    tratamiento1 = DgvTratamientos.Rows(0).Cells(0).Value
                    tratamiento2 = DgvTratamientos.Rows(1).Cells(0).Value
                    tratamiento3 = DgvTratamientos.Rows(2).Cells(0).Value
                    tratamiento4 = DgvTratamientos.Rows(3).Cells(0).Value
                    tratamiento5 = DgvTratamientos.Rows(4).Cells(0).Value

                    nomtratamiento1 = DgvTratamientos.Rows(0).Cells(2).Value.ToString

                    nomtratamiento2 = DgvTratamientos.Rows(1).Cells(2).Value.ToString

                    nomtratamiento3 = DgvTratamientos.Rows(2).Cells(2).Value.ToString

                    nomtratamiento4 = DgvTratamientos.Rows(3).Cells(2).Value.ToString

                    nomtratamiento5 = DgvTratamientos.Rows(4).Cells(2).Value.ToString

                    Me.grafica.Series("Total Tratamientos más usados").Points.AddY(tratamiento1)
                    Me.grafica.Series("Total Tratamientos más usados").Points.AddY(tratamiento2)
                    Me.grafica.Series("Total Tratamientos más usados").Points.AddY(tratamiento3)
                    Me.grafica.Series("Total Tratamientos más usados").Points.AddY(tratamiento4)
                    Me.grafica.Series("Total Tratamientos más usados").Points.AddY(tratamiento5)
                    Me.grafica.Series("Total Tratamientos más usados").Points(0).AxisLabel = nomtratamiento1
                    Me.grafica.Series("Total Tratamientos más usados").Points(1).AxisLabel = nomtratamiento2
                    Me.grafica.Series("Total Tratamientos más usados").Points(2).AxisLabel = nomtratamiento3
                    Me.grafica.Series("Total Tratamientos más usados").Points(3).AxisLabel = nomtratamiento4
                    Me.grafica.Series("Total Tratamientos más usados").Points(4).AxisLabel = nomtratamiento5



                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
        End Select

    End Sub


    Private Sub PnlTratamientos_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles PnlTratamientos.MouseEnter
        PnlTratamientos.BackColor = Color.MidnightBlue
        pnlEdadPaciente.BackColor = Color.RoyalBlue
        pnlNumCitas.BackColor = Color.RoyalBlue
    End Sub

    Private Sub PnlTratamientos_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PnlTratamientos.MouseLeave
        PnlTratamientos.BackColor = Color.RoyalBlue
    End Sub

    Private Sub Lbltratamientos_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblTratamientos.MouseEnter
        PnlTratamientos.BackColor = Color.MidnightBlue
    End Sub

    Private Sub Lbltratamientos_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblTratamientos.MouseLeave
        PnlTratamientos.BackColor = Color.RoyalBlue
    End Sub

    Private Sub pnlModo3D_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pnlModo3D.Click



        If grafica.ChartAreas("Pacientes").Area3DStyle.Enable3D = True Then
            pnlPerspectiva.Visible = True
        Else
            pnlPerspectiva.Visible = False
        End If
        If PnlSubmenu3d.Visible = True Then
            PnlSubmenu3d.Visible = False
            pnlSubMenuCambiarPerspectiva.Visible = False
        Else
            PnlSubmenu3d.Visible = True
            PnlSubMenuDatosGrafica.Visible = False
        End If
    End Sub

    Private Sub Pnl3d_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pnlModo3D.MouseLeave
        pnlModo3D.BackColor = Color.RoyalBlue
    End Sub


    Private Sub PnlGrafica_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pnlDatosGrafica.MouseLeave
        pnlDatosGrafica.BackColor = Color.RoyalBlue
    End Sub


    Private Sub LblGrafica_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblDatosGrafica.MouseEnter
        pnlDatosGrafica.BackColor = Color.MidnightBlue
        pnlSubMenuCambiarPerspectiva.Visible = False
    End Sub

    Private Sub LblGrafica_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblDatosGrafica.MouseLeave
        pnlDatosGrafica.BackColor = Color.RoyalBlue
    End Sub
    Private Sub Pnl3d_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles pnlModo3D.MouseEnter
        pnlModo3D.BackColor = Color.MidnightBlue
        pnlPerspectiva.BackColor = Color.RoyalBlue
        pnlEdadPaciente.BackColor = Color.RoyalBlue
    End Sub

    Private Sub Lbl3d_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblModo3D.MouseEnter
        pnlModo3D.BackColor = Color.MidnightBlue
    End Sub

    Private Sub Lbl3d_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblModo3D.MouseLeave
        pnlModo3D.BackColor = Color.RoyalBlue
    End Sub


    Private Sub lblCambiarPers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblCambiarPerspectiva.Click
        pnlSubMenuCambiarPerspectiva.Visible = True
    End Sub


    Private Sub PnlOp1_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnl180.MouseClick
        grafica.ChartAreas(0).Area3DStyle.Rotation = 180
    End Sub


    Private Sub PnlOp1_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles pnl180.MouseEnter
        pnl180.BackColor = Color.MidnightBlue
    End Sub

    Private Sub PnlOp1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pnl180.MouseLeave
        pnl180.BackColor = Color.RoyalBlue
    End Sub

    Private Sub Lblop1_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbl180.MouseEnter
        pnl180.BackColor = Color.MidnightBlue
    End Sub

    Private Sub Lblop1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbl180.MouseLeave
        pnl180.BackColor = Color.RoyalBlue
    End Sub

    Private Sub Lblop1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl180.Click
        grafica.ChartAreas(0).Area3DStyle.Rotation = 180

    End Sub

    Private Sub Lbltratamientos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblTratamientos.Click
        dtpAnio.Hide()
        lblAnio.Hide()

        Dim numero As Integer = 0

        Try
            Consulta = "select count(*) from plan_tratamiento group by id_a;"
            consultar()

            For Each row In Tabla.Rows
                numero += 1
            Next
        Catch ex As Exception

        End Try


        Select Case numero

            Case 0
                MsgBox("No hay tratamientos realizados", MsgBoxStyle.Information)

            Case 1
                Try
                    grafica.Series.Clear()
                    grafica.Series.Add("Total Tratamientos más usados")

                    Consulta = "select count(*), p.id_a , a.descripcion from plan_tratamiento p left join aranceles a on a.id_a = p.id_a group by p.id_a order by 1 desc;"
                    consultar()
                    DgvTratamientos.DataSource = Tabla


                    tratamiento1 = DgvTratamientos.Rows(0).Cells(0).Value

                    nomtratamiento1 = DgvTratamientos.Rows(0).Cells(2).Value.ToString

                    Me.grafica.Series("Total Tratamientos más usados").Points.AddY(tratamiento1)

                    Me.grafica.Series("Total Tratamientos más usados").Points(0).AxisLabel = nomtratamiento1

                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            Case 2
                Try
                    grafica.Series.Clear()
                    grafica.Series.Add("Total Tratamientos más usados")

                    Consulta = "select count(*), p.id_a , a.descripcion from plan_tratamiento p left join aranceles a on a.id_a = p.id_a group by p.id_a order by 1 desc;"
                    consultar()
                    DgvTratamientos.DataSource = Tabla


                    tratamiento1 = DgvTratamientos.Rows(0).Cells(0).Value
                    tratamiento2 = DgvTratamientos.Rows(1).Cells(0).Value

                    nomtratamiento1 = DgvTratamientos.Rows(0).Cells(2).Value.ToString

                    nomtratamiento2 = DgvTratamientos.Rows(1).Cells(2).Value.ToString


                    Me.grafica.Series("Total Tratamientos más usados").Points.AddY(tratamiento1)
                    Me.grafica.Series("Total Tratamientos más usados").Points.AddY(tratamiento2)

                    Me.grafica.Series("Total Tratamientos más usados").Points(0).AxisLabel = nomtratamiento1
                    Me.grafica.Series("Total Tratamientos más usados").Points(1).AxisLabel = nomtratamiento2




                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            Case 3
                Try
                    grafica.Series.Clear()
                    grafica.Series.Add("Total Tratamientos más usados")

                    Consulta = "select count(*), p.id_a , a.descripcion from plan_tratamiento p left join aranceles a on a.id_a = p.id_a group by p.id_a order by 1 desc;"
                    consultar()
                    DgvTratamientos.DataSource = Tabla

                    tratamiento1 = DgvTratamientos.Rows(0).Cells(0).Value
                    tratamiento2 = DgvTratamientos.Rows(1).Cells(0).Value
                    tratamiento3 = DgvTratamientos.Rows(2).Cells(0).Value

                    nomtratamiento1 = DgvTratamientos.Rows(0).Cells(2).Value.ToString

                    nomtratamiento2 = DgvTratamientos.Rows(1).Cells(2).Value.ToString

                    nomtratamiento3 = DgvTratamientos.Rows(2).Cells(2).Value.ToString


                    Me.grafica.Series("Total Tratamientos más usados").Points.AddY(tratamiento1)
                    Me.grafica.Series("Total Tratamientos más usados").Points.AddY(tratamiento2)
                    Me.grafica.Series("Total Tratamientos más usados").Points.AddY(tratamiento3)

                    Me.grafica.Series("Total Tratamientos más usados").Points(0).AxisLabel = nomtratamiento1
                    Me.grafica.Series("Total Tratamientos más usados").Points(1).AxisLabel = nomtratamiento2
                    Me.grafica.Series("Total Tratamientos más usados").Points(2).AxisLabel = nomtratamiento3




                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            Case 4
                Try
                    grafica.Series.Clear()
                    grafica.Series.Add("Total Tratamientos más usados")

                    Consulta = "select count(*), p.id_a , a.descripcion from plan_tratamiento p left join aranceles a on a.id_a = p.id_a group by p.id_a order by 1 desc;"
                    consultar()
                    DgvTratamientos.DataSource = Tabla

                    tratamiento1 = DgvTratamientos.Rows(0).Cells(0).Value
                    tratamiento2 = DgvTratamientos.Rows(1).Cells(0).Value
                    tratamiento3 = DgvTratamientos.Rows(2).Cells(0).Value
                    tratamiento4 = DgvTratamientos.Rows(3).Cells(0).Value

                    nomtratamiento1 = DgvTratamientos.Rows(0).Cells(2).Value.ToString

                    nomtratamiento2 = DgvTratamientos.Rows(1).Cells(2).Value.ToString

                    nomtratamiento3 = DgvTratamientos.Rows(2).Cells(2).Value.ToString

                    nomtratamiento4 = DgvTratamientos.Rows(3).Cells(2).Value.ToString

                    Me.grafica.Series("Total Tratamientos más usados").Points.AddY(tratamiento1)
                    Me.grafica.Series("Total Tratamientos más usados").Points.AddY(tratamiento2)
                    Me.grafica.Series("Total Tratamientos más usados").Points.AddY(tratamiento3)
                    Me.grafica.Series("Total Tratamientos más usados").Points.AddY(tratamiento4)

                    Me.grafica.Series("Total Tratamientos más usados").Points(0).AxisLabel = nomtratamiento1
                    Me.grafica.Series("Total Tratamientos más usados").Points(1).AxisLabel = nomtratamiento2
                    Me.grafica.Series("Total Tratamientos más usados").Points(2).AxisLabel = nomtratamiento3
                    Me.grafica.Series("Total Tratamientos más usados").Points(3).AxisLabel = nomtratamiento4



                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try

            Case 5
                Try
                    grafica.Series.Clear()
                    grafica.Series.Add("Total Tratamientos más usados")

                    Consulta = "select count(*), p.id_a , a.descripcion from plan_tratamiento p left join aranceles a on a.id_a = p.id_a group by p.id_a order by 1 desc;"
                    consultar()
                    DgvTratamientos.DataSource = Tabla

                    tratamiento1 = DgvTratamientos.Rows(0).Cells(0).Value
                    tratamiento2 = DgvTratamientos.Rows(1).Cells(0).Value
                    tratamiento3 = DgvTratamientos.Rows(2).Cells(0).Value
                    tratamiento4 = DgvTratamientos.Rows(3).Cells(0).Value
                    tratamiento5 = DgvTratamientos.Rows(4).Cells(0).Value

                    nomtratamiento1 = DgvTratamientos.Rows(0).Cells(2).Value.ToString

                    nomtratamiento2 = DgvTratamientos.Rows(1).Cells(2).Value.ToString

                    nomtratamiento3 = DgvTratamientos.Rows(2).Cells(2).Value.ToString

                    nomtratamiento4 = DgvTratamientos.Rows(3).Cells(2).Value.ToString

                    nomtratamiento5 = DgvTratamientos.Rows(4).Cells(2).Value.ToString

                    Me.grafica.Series("Total Tratamientos más usados").Points.AddY(tratamiento1)
                    Me.grafica.Series("Total Tratamientos más usados").Points.AddY(tratamiento2)
                    Me.grafica.Series("Total Tratamientos más usados").Points.AddY(tratamiento3)
                    Me.grafica.Series("Total Tratamientos más usados").Points.AddY(tratamiento4)
                    Me.grafica.Series("Total Tratamientos más usados").Points.AddY(tratamiento5)
                    Me.grafica.Series("Total Tratamientos más usados").Points(0).AxisLabel = nomtratamiento1
                    Me.grafica.Series("Total Tratamientos más usados").Points(1).AxisLabel = nomtratamiento2
                    Me.grafica.Series("Total Tratamientos más usados").Points(2).AxisLabel = nomtratamiento3
                    Me.grafica.Series("Total Tratamientos más usados").Points(3).AxisLabel = nomtratamiento4
                    Me.grafica.Series("Total Tratamientos más usados").Points(4).AxisLabel = nomtratamiento5



                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
        End Select

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblDespmenu.Click
        TmrMovimiento.Start()
        PnlSubMenuDatosGrafica.Visible = False
        PnlSubmenu3d.Visible = False
        pnlSubMenuCambiarPerspectiva.Visible = False


    End Sub

    Private Sub LblOp2_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lbl140.MouseClick
        grafica.ChartAreas(0).Area3DStyle.Rotation = 140
    End Sub

    Private Sub PnlOp2_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles pnl140.MouseEnter
        pnl140.BackColor = Color.MidnightBlue
    End Sub

    Private Sub PnlOp2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pnl140.MouseLeave
        pnl140.BackColor = Color.RoyalBlue
    End Sub

    Private Sub LblOp2_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbl140.MouseEnter
        pnl140.BackColor = Color.MidnightBlue
    End Sub

    Private Sub LblOp2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbl140.MouseLeave
        pnl140.BackColor = Color.RoyalBlue
    End Sub

    Private Sub LblOp3_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblPredeterminado.MouseClick
        grafica.ChartAreas(0).Area3DStyle.Rotation = 30
    End Sub

    Private Sub PnlOp3_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnlPredeterminado.MouseClick
        grafica.ChartAreas(0).Area3DStyle.Rotation = 10
    End Sub

    Private Sub LblOp3_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblPredeterminado.MouseEnter
        pnlPredeterminado.BackColor = Color.MidnightBlue
    End Sub

    Private Sub LblOp3_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblPredeterminado.MouseLeave
        pnlPredeterminado.BackColor = Color.RoyalBlue
    End Sub

    Private Sub PnlOp3_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles pnlPredeterminado.MouseEnter
        pnlPredeterminado.BackColor = Color.MidnightBlue
    End Sub

    Private Sub PnlOp3_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pnlPredeterminado.MouseLeave
        pnlPredeterminado.BackColor = Color.RoyalBlue
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        grafica.Series.Clear()

    End Sub

   

    Private Sub grafica_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grafica.Click

    End Sub

    Private Sub pbconfig_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles pbconfig.MouseEnter
        PnlSubMenuDatosGrafica.Visible = False
        PnlSubmenu3d.Visible = False
        pnlSubMenuCambiarPerspectiva.Visible = False
    End Sub

    Private Sub PnlTratamientos_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles PnlTratamientos.Paint

    End Sub

    Private Sub pnlNumCitas_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnlNumCitas.MouseClick
        dtpAnio.Show()
        lblAnio.Show()
        dtpAnio.Value = "01/01/2018"
        numCitas()
    End Sub

    Private Sub pnlNumCitas_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles pnlNumCitas.MouseEnter
        PnlTratamientos.BackColor = Color.RoyalBlue
        pnlEdadPaciente.BackColor = Color.RoyalBlue
        pnlNumCitas.BackColor = Color.MidnightBlue
    End Sub

    Private Sub lblNumCitas_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblNumCitas.MouseEnter
        pnlNumCitas.BackColor = Color.MidnightBlue
    End Sub

    Private Sub pnlNumCitas_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pnlNumCitas.MouseLeave
        pnlNumCitas.BackColor = Color.RoyalBlue
    End Sub

    Private Sub lblNumCitas_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblNumCitas.MouseLeave
        pnlNumCitas.BackColor = Color.RoyalBlue
    End Sub

    Private Sub lblNumCitas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblNumCitas.Click

        dtpAnio.Show()
        lblAnio.Show()
        dtpAnio.Value = "01/01/2018"
        numCitas()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpAnio.ValueChanged
        numCitas()
    End Sub

    Private Sub numCitas()
        Dim anio As String = dtpAnio.Text   '  Dim mes As String = ""
        grafica.Series.Clear()
         Try

            Consulta = "select count(*) from cita where month(fecha) = '1' and year(fecha) = '" + anio + "' and atendida = '1';"
            consultar()
            Dim enero As Integer
            For Each row In Tabla.Rows
                enero = Val(row(0))
            Next

            Consulta = "select count(*) from cita where month(fecha) = '2' and year(fecha) = '" + anio + "' and atendida = '1';"
            consultar()
            Dim feb As Integer
            For Each row In Tabla.Rows
                feb = Val(row(0))
            Next

            Consulta = "select count(*) from cita where month(fecha) = '3' and year(fecha) = '" + anio + "' and atendida = '1';"
            consultar()
            Dim mar As Integer
            For Each row In Tabla.Rows
                mar = Val(row(0))
            Next

            Consulta = "select count(*) from cita where month(fecha) = '4' and year(fecha) = '" + anio + "' and atendida = '1';"
            consultar()
            Dim abr As Integer
            For Each row In Tabla.Rows
                abr = Val(row(0))
            Next
            Consulta = "select count(*) from cita where month(fecha) = '5' and year(fecha) = '" + anio + "' and atendida = '1';"
            consultar()
            Dim may As Integer
            For Each row In Tabla.Rows
                may = Val(row(0))
            Next
            Consulta = "select count(*) from cita where month(fecha) = '6' and year(fecha) = '" + anio + "' and atendida = '1';"
            consultar()
            Dim jun As Integer
            For Each row In Tabla.Rows
                jun = Val(row(0))
            Next
            Consulta = "select count(*) from cita where month(fecha) = '7' and year(fecha) = '" + anio + "' and atendida = '1';"
            consultar()
            Dim jul As Integer
            For Each row In Tabla.Rows
                jul = Val(row(0))
            Next
            Consulta = "select count(*) from cita where month(fecha) = '8' and year(fecha) = '" + anio + "' and atendida = '1';"
            consultar()
            Dim ago As Integer
            For Each row In Tabla.Rows
                ago = Val(row(0))
            Next
            Consulta = "select count(*) from cita where month(fecha) = '9' and year(fecha) = '" + anio + "' and atendida = '1';"
            consultar()
            Dim sep As Integer
            For Each row In Tabla.Rows
                sep = Val(row(0))
            Next
            Consulta = "select count(*) from cita where month(fecha) = '10' and year(fecha) = '" + anio + "' and atendida = '1';"
            consultar()
            Dim oct As Integer
            For Each row In Tabla.Rows
                oct = Val(row(0))

            Next
            Consulta = "select count(*) from cita where month(fecha) = '11' and year(fecha) = '" + anio + "' and atendida = '1';"
            consultar()
            Dim nov As Integer
            For Each row In Tabla.Rows
                nov = Val(row(0))
            Next
            Consulta = "select count(*) from cita where month(fecha) = '12' and year(fecha) = '" + anio + "' and atendida = '1';"
            consultar()
            Dim dic As Integer
            For Each row In Tabla.Rows
                dic = Val(row(0))
            Next

            grafica.Series.Add("Número Citas")
            grafica.Series("Número Citas").Points.AddXY("Enero", enero)
            grafica.Series("Número Citas").Points.AddXY("Febrero", feb)
            grafica.Series("Número Citas").Points.AddXY("Marzo", mar)
            grafica.Series("Número Citas").Points.AddXY("Abril", abr)
            grafica.Series("Número Citas").Points.AddXY("Mayo", may)
            grafica.Series("Número Citas").Points.AddXY("Junio", jun)
            grafica.Series("Número Citas").Points.AddXY("Julio", jul)
            grafica.Series("Número Citas").Points.AddXY("Agosto", ago)
            grafica.Series("Número Citas").Points.AddXY("Septiembre", sep)
            grafica.Series("Número Citas").Points.AddXY("Octubre", oct)
            grafica.Series("Número Citas").Points.AddXY("Noviembre", nov)
            grafica.Series("Número Citas").Points.AddXY("Diciembre", dic)
        Catch ex As Exception

            MsgBox("Error al obtener el número de citas", MsgBoxStyle.Exclamation)
        End Try

    End Sub

    

   
    Private Sub lblActivar3D_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblActivar3D.MouseLeave
        pnlActivar3D.BackColor = Color.RoyalBlue
    End Sub

    Private Sub lblEdadPaciente_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblEdadPaciente.MouseEnter
        pnlEdadPaciente.BackColor = Color.MidnightBlue
    End Sub

  
    Private Sub pnlEdadPaciente_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pnlEdadPaciente.MouseLeave
        pnlEdadPaciente.BackColor = Color.RoyalBlue
    End Sub

    Private Sub lblEdadPaciente_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblEdadPaciente.MouseLeave
        pnlEdadPaciente.BackColor = Color.RoyalBlue
    End Sub
End Class