Public Class frmCitas

   
    Public idcita As Integer

    Public fechita, dia, FCalendario As String
    Dim DiaSeleccionado As System.DateTime

   


    Private Sub Citas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        LabelDia.Hide()
        seleccionado.Hide()

        dgvHora.ColumnCount = 7

        dgvHora.Rows.Add("8:00", "", "", "", "", "", "")
        dgvHora.Rows.Add("8:30", "", "", "", "", "", "")
        dgvHora.Rows.Add("9:00", "", "", "", "", "", "")
        dgvHora.Rows.Add("9:30", "", "", "", "", "", "")
        dgvHora.Rows.Add("10:00", "", "", "", "", "", "")
        dgvHora.Rows.Add("10:00", "", "", "", "", "", "")
        dgvHora.Rows.Add("10:30", "", "", "", "", "", "")
        dgvHora.Rows.Add("11:00", "", "", "", "", "", "")
        dgvHora.Rows.Add("11:30", "", "", "", "", "", "")
        dgvHora.Rows.Add("12:00", "", "", "", "", "", "")
        dgvHora.Rows.Add("12:30", "", "", "", "", "", "")
        dgvHora.Rows.Add("13:00", "", "", "", "", "", "")
        dgvHora.Rows.Add("13:30", "", "", "", "", "", "")
        dgvHora.Rows.Add("14:30", "", "", "", "", "", "")
        dgvHora.Rows.Add("15:00", "", "", "", "", "", "")
        dgvHora.Rows.Add("15:30", "", "", "", "", "", "")
        dgvHora.Rows.Add("16:00", "", "", "", "", "", "")
        dgvHora.Rows.Add("16:30", "", "", "", "", "", "")
        dgvHora.Rows.Add("17:00", "", "", "", "", "", "")
        dgvHora.Rows.Add("17:30", "", "", "", "", "", "")
        dgvHora.Rows.Add("18:00", "", "", "", "", "", "")
        dgvHora.Rows.Add("18:30", "", "", "", "", "", "")
        dgvHora.Rows.Add("19:00", "", "", "", "", "", "")
        dgvHora.Rows.Add("19:30", "", "", "", "", "", "")
        dgvHora.Rows.Add("20:00", "", "", "", "", "", "")


        Try
            DiaSeleccionado = MCFecha.SelectionRange.Start
            FCalendario = Weekday(DiaSeleccionado)




            LabelDia.Text = ("" + dia)
            seleccionado.Text = ("" + DiaSeleccionado)



            ''En un case se muestran los datos de la semana seleccionada por el usuario
            Select Case FCalendario

                Case "2"

                    Consulta = "select hora , p.nombre from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.ToString("yyyy-MM-dd") + "';"
                    consultar()


                    dgvConsultaDia.DataSource = Tabla


                    If Not dgvConsultaDia.RowCount = 0 Then



                        Dim hora As TimeSpan
                        Dim nombre As String

                        For indice = 0 To dgvConsultaDia.RowCount - 1


                            hora = dgvConsultaDia.Rows(indice).Cells(0).Value
                            nombre = dgvConsultaDia.Rows(indice).Cells(1).Value

                            For IndHoras = 0 To 24


                                Dim posicion As TimeSpan

                                posicion = TimeSpan.Parse(dgvHora.Rows(IndHoras).Cells(0).Value)

                                If hora < posicion Then


                                    dgvHora.Rows(IndHoras - 1).Cells(1).Value = nombre
                                    Exit For
                                End If

                            Next
                        Next

                    End If

                    Consulta = "select hora , p.nombre from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.AddDays(1).ToString("yyyy-MM-dd") + "';"
                    consultar()


                    dgvConsultaDia.DataSource = Tabla


                    If Not dgvConsultaDia.RowCount = 0 Then

                        Dim hora As TimeSpan
                        Dim nombre As String

                        For indice = 0 To dgvConsultaDia.RowCount - 1


                            hora = dgvConsultaDia.Rows(indice).Cells(0).Value
                            nombre = dgvConsultaDia.Rows(indice).Cells(1).Value

                            For IndHoras = 0 To 24


                                Dim posicion As TimeSpan

                                posicion = TimeSpan.Parse(dgvHora.Rows(IndHoras).Cells(0).Value)

                                If hora < posicion Then


                                    dgvHora.Rows(IndHoras - 1).Cells(2).Value = nombre
                                    Exit For
                                End If

                            Next
                        Next

                    End If

                    Consulta = "select hora , p.nombre from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.AddDays(2).ToString("yyyy-MM-dd") + "';"
                    consultar()


                    dgvConsultaDia.DataSource = Tabla


                    If Not dgvConsultaDia.RowCount = 0 Then

                        Dim hora As TimeSpan
                        Dim nombre As String

                        For indice = 0 To dgvConsultaDia.RowCount - 1


                            hora = dgvConsultaDia.Rows(indice).Cells(0).Value
                            nombre = dgvConsultaDia.Rows(indice).Cells(1).Value

                            For IndHoras = 0 To 24


                                Dim posicion As TimeSpan

                                posicion = TimeSpan.Parse(dgvHora.Rows(IndHoras).Cells(0).Value)

                                If hora < posicion Then


                                    dgvHora.Rows(IndHoras - 1).Cells(3).Value = nombre
                                    Exit For
                                End If

                            Next
                        Next

                    End If

                    Consulta = "select hora , p.nombre from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.AddDays(3).ToString("yyyy-MM-dd") + "';"
                    consultar()


                    dgvConsultaDia.DataSource = Tabla


                    If Not dgvConsultaDia.RowCount = 0 Then

                        Dim hora As TimeSpan
                        Dim nombre As String

                        For indice = 0 To dgvConsultaDia.RowCount - 1


                            hora = dgvConsultaDia.Rows(indice).Cells(0).Value
                            nombre = dgvConsultaDia.Rows(indice).Cells(1).Value

                            For IndHoras = 0 To 24


                                Dim posicion As TimeSpan

                                posicion = TimeSpan.Parse(dgvHora.Rows(IndHoras).Cells(0).Value)

                                If hora < posicion Then


                                    dgvHora.Rows(IndHoras - 1).Cells(4).Value = nombre
                                    Exit For
                                End If

                            Next
                        Next

                    End If


                    Consulta = "select hora , p.nombre from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.AddDays(4).ToString("yyyy-MM-dd") + "';"
                    consultar()


                    dgvConsultaDia.DataSource = Tabla


                    If Not dgvConsultaDia.RowCount = 0 Then

                        Dim hora As TimeSpan
                        Dim nombre As String

                        For indice = 0 To dgvConsultaDia.RowCount - 1


                            hora = dgvConsultaDia.Rows(indice).Cells(0).Value
                            nombre = dgvConsultaDia.Rows(indice).Cells(1).Value

                            For IndHoras = 0 To 24


                                Dim posicion As TimeSpan

                                posicion = TimeSpan.Parse(dgvHora.Rows(IndHoras).Cells(0).Value)

                                If hora < posicion Then


                                    dgvHora.Rows(IndHoras - 1).Cells(5).Value = nombre
                                    Exit For
                                End If

                            Next
                        Next

                    End If

                    Consulta = "select hora , p.nombre from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.AddDays(5).ToString("yyyy-MM-dd") + "';"
                    consultar()


                    dgvConsultaDia.DataSource = Tabla


                    If Not dgvConsultaDia.RowCount = 0 Then

                        Dim hora As TimeSpan
                        Dim nombre As String

                        For indice = 0 To dgvConsultaDia.RowCount - 1


                            hora = dgvConsultaDia.Rows(indice).Cells(0).Value
                            nombre = dgvConsultaDia.Rows(indice).Cells(1).Value

                            For IndHoras = 0 To 24


                                Dim posicion As TimeSpan

                                posicion = TimeSpan.Parse(dgvHora.Rows(IndHoras).Cells(0).Value)

                                If hora < posicion Then


                                    dgvHora.Rows(IndHoras - 1).Cells(6).Value = nombre
                                    Exit For
                                End If

                            Next
                        Next

                    End If



                Case "3"




                    Consulta = "select hora , p.nombre from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.AddDays(-1).ToString("yyyy-MM-dd") + "';"
                    consultar()


                    dgvConsultaDia.DataSource = Tabla


                    If Not dgvConsultaDia.RowCount = 0 Then



                        Dim hora As TimeSpan
                        Dim nombre As String

                        For indice = 0 To dgvConsultaDia.RowCount - 1


                            hora = dgvConsultaDia.Rows(indice).Cells(0).Value
                            nombre = dgvConsultaDia.Rows(indice).Cells(1).Value

                            For IndHoras = 0 To 24


                                Dim posicion As TimeSpan

                                posicion = TimeSpan.Parse(dgvHora.Rows(IndHoras).Cells(0).Value)

                                If hora < posicion Then


                                    dgvHora.Rows(IndHoras - 1).Cells(1).Value = nombre
                                    Exit For
                                End If

                            Next
                        Next

                    End If

                    Consulta = "select hora , p.nombre from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.ToString("yyyy-MM-dd") + "';"
                    consultar()


                    dgvConsultaDia.DataSource = Tabla


                    If Not dgvConsultaDia.RowCount = 0 Then



                        Dim hora As TimeSpan
                        Dim nombre As String

                        For indice = 0 To dgvConsultaDia.RowCount - 1


                            hora = dgvConsultaDia.Rows(indice).Cells(0).Value
                            nombre = dgvConsultaDia.Rows(indice).Cells(1).Value

                            For IndHoras = 0 To 24


                                Dim posicion As TimeSpan

                                posicion = TimeSpan.Parse(dgvHora.Rows(IndHoras).Cells(0).Value)

                                If hora < posicion Then


                                    dgvHora.Rows(IndHoras - 1).Cells(2).Value = nombre
                                    Exit For
                                End If

                            Next
                        Next

                    End If

                    Consulta = "select hora , p.nombre from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.AddDays(1).ToString("yyyy-MM-dd") + "';"
                    consultar()


                    dgvConsultaDia.DataSource = Tabla


                    If Not dgvConsultaDia.RowCount = 0 Then



                        Dim hora As TimeSpan
                        Dim nombre As String

                        For indice = 0 To dgvConsultaDia.RowCount - 1


                            hora = dgvConsultaDia.Rows(indice).Cells(0).Value
                            nombre = dgvConsultaDia.Rows(indice).Cells(1).Value

                            For IndHoras = 0 To 24


                                Dim posicion As TimeSpan

                                posicion = TimeSpan.Parse(dgvHora.Rows(IndHoras).Cells(0).Value)

                                If hora < posicion Then


                                    dgvHora.Rows(IndHoras - 1).Cells(3).Value = nombre
                                    Exit For
                                End If

                            Next
                        Next

                    End If

                    Consulta = "select hora , p.nombre from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.AddDays(3).ToString("yyyy-MM-dd") + "';"
                    consultar()


                    dgvConsultaDia.DataSource = Tabla


                    If Not dgvConsultaDia.RowCount = 0 Then



                        Dim hora As TimeSpan
                        Dim nombre As String

                        For indice = 0 To dgvConsultaDia.RowCount - 1


                            hora = dgvConsultaDia.Rows(indice).Cells(0).Value
                            nombre = dgvConsultaDia.Rows(indice).Cells(1).Value

                            For IndHoras = 0 To 24


                                Dim posicion As TimeSpan

                                posicion = TimeSpan.Parse(dgvHora.Rows(IndHoras).Cells(0).Value)

                                If hora < posicion Then


                                    dgvHora.Rows(IndHoras - 1).Cells(4).Value = nombre
                                    Exit For
                                End If

                            Next
                        Next

                    End If

                    Consulta = "select hora , p.nombre from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.AddDays(4).ToString("yyyy-MM-dd") + "';"
                    consultar()


                    dgvConsultaDia.DataSource = Tabla


                    If Not dgvConsultaDia.RowCount = 0 Then



                        Dim hora As TimeSpan
                        Dim nombre As String

                        For indice = 0 To dgvConsultaDia.RowCount - 1


                            hora = dgvConsultaDia.Rows(indice).Cells(0).Value
                            nombre = dgvConsultaDia.Rows(indice).Cells(1).Value

                            For IndHoras = 0 To 24


                                Dim posicion As TimeSpan

                                posicion = TimeSpan.Parse(dgvHora.Rows(IndHoras).Cells(0).Value)

                                If hora < posicion Then


                                    dgvHora.Rows(IndHoras - 1).Cells(5).Value = nombre
                                    Exit For
                                End If

                            Next
                        Next

                    End If


                    Consulta = "select hora , p.nombre from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.AddDays(5).ToString("yyyy-MM-dd") + "';"
                    consultar()


                    dgvConsultaDia.DataSource = Tabla


                    If Not dgvConsultaDia.RowCount = 0 Then



                        Dim hora As TimeSpan
                        Dim nombre As String

                        For indice = 0 To dgvConsultaDia.RowCount - 1


                            hora = dgvConsultaDia.Rows(indice).Cells(0).Value
                            nombre = dgvConsultaDia.Rows(indice).Cells(1).Value

                            For IndHoras = 0 To 24


                                Dim posicion As TimeSpan

                                posicion = TimeSpan.Parse(dgvHora.Rows(IndHoras).Cells(0).Value)

                                If hora < posicion Then


                                    dgvHora.Rows(IndHoras - 1).Cells(6).Value = nombre
                                    Exit For
                                End If

                            Next
                        Next

                    End If



                Case "4"


                    Consulta = "select hora , p.nombre from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.AddDays(-2).ToString("yyyy-MM-dd") + "';"
                    consultar()


                    dgvConsultaDia.DataSource = Tabla


                    If Not dgvConsultaDia.RowCount = 0 Then



                        Dim hora As TimeSpan
                        Dim nombre As String

                        For indice = 0 To dgvConsultaDia.RowCount - 1


                            hora = dgvConsultaDia.Rows(indice).Cells(0).Value
                            nombre = dgvConsultaDia.Rows(indice).Cells(1).Value

                            For IndHoras = 0 To 24


                                Dim posicion As TimeSpan

                                posicion = TimeSpan.Parse(dgvHora.Rows(IndHoras).Cells(0).Value)

                                If hora < posicion Then


                                    dgvHora.Rows(IndHoras - 1).Cells(1).Value = nombre
                                    Exit For
                                End If

                            Next
                        Next

                    End If


                    Consulta = "select hora , p.nombre from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.AddDays(-1).ToString("yyyy-MM-dd") + "';"
                    consultar()


                    dgvConsultaDia.DataSource = Tabla


                    If Not dgvConsultaDia.RowCount = 0 Then



                        Dim hora As TimeSpan
                        Dim nombre As String

                        For indice = 0 To dgvConsultaDia.RowCount - 1


                            hora = dgvConsultaDia.Rows(indice).Cells(0).Value
                            nombre = dgvConsultaDia.Rows(indice).Cells(1).Value

                            For IndHoras = 0 To 24


                                Dim posicion As TimeSpan

                                posicion = TimeSpan.Parse(dgvHora.Rows(IndHoras).Cells(0).Value)

                                If hora < posicion Then


                                    dgvHora.Rows(IndHoras - 1).Cells(2).Value = nombre
                                    Exit For
                                End If

                            Next
                        Next

                    End If



                    Consulta = "select hora , p.nombre from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.ToString("yyyy-MM-dd") + "';"
                    consultar()


                    dgvConsultaDia.DataSource = Tabla


                    If Not dgvConsultaDia.RowCount = 0 Then



                        Dim hora As TimeSpan
                        Dim nombre As String

                        For indice = 0 To dgvConsultaDia.RowCount - 1


                            hora = dgvConsultaDia.Rows(indice).Cells(0).Value
                            nombre = dgvConsultaDia.Rows(indice).Cells(1).Value

                            For IndHoras = 0 To 24


                                Dim posicion As TimeSpan

                                posicion = TimeSpan.Parse(dgvHora.Rows(IndHoras).Cells(0).Value)

                                If hora < posicion Then


                                    dgvHora.Rows(IndHoras - 1).Cells(3).Value = nombre
                                    Exit For
                                End If

                            Next
                        Next

                    End If



                    Consulta = "select hora , p.nombre from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.AddDays(1).ToString("yyyy-MM-dd") + "';"
                    consultar()


                    dgvConsultaDia.DataSource = Tabla


                    If Not dgvConsultaDia.RowCount = 0 Then



                        Dim hora As TimeSpan
                        Dim nombre As String

                        For indice = 0 To dgvConsultaDia.RowCount - 1


                            hora = dgvConsultaDia.Rows(indice).Cells(0).Value
                            nombre = dgvConsultaDia.Rows(indice).Cells(1).Value

                            For IndHoras = 0 To 24


                                Dim posicion As TimeSpan

                                posicion = TimeSpan.Parse(dgvHora.Rows(IndHoras).Cells(0).Value)

                                If hora < posicion Then


                                    dgvHora.Rows(IndHoras - 1).Cells(4).Value = nombre
                                    Exit For
                                End If

                            Next
                        Next

                    End If



                    Consulta = "select hora , p.nombre from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.AddDays(2).ToString("yyyy-MM-dd") + "';"
                    consultar()


                    dgvConsultaDia.DataSource = Tabla


                    If Not dgvConsultaDia.RowCount = 0 Then



                        Dim hora As TimeSpan
                        Dim nombre As String

                        For indice = 0 To dgvConsultaDia.RowCount - 1


                            hora = dgvConsultaDia.Rows(indice).Cells(0).Value
                            nombre = dgvConsultaDia.Rows(indice).Cells(1).Value

                            For IndHoras = 0 To 24


                                Dim posicion As TimeSpan

                                posicion = TimeSpan.Parse(dgvHora.Rows(IndHoras).Cells(0).Value)

                                If hora < posicion Then


                                    dgvHora.Rows(IndHoras - 1).Cells(5).Value = nombre
                                    Exit For
                                End If

                            Next
                        Next

                    End If



                    Consulta = "select hora , p.nombre from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.AddDays(3).ToString("yyyy-MM-dd") + "';"
                    consultar()


                    dgvConsultaDia.DataSource = Tabla


                    If Not dgvConsultaDia.RowCount = 0 Then



                        Dim hora As TimeSpan
                        Dim nombre As String

                        For indice = 0 To dgvConsultaDia.RowCount - 1


                            hora = dgvConsultaDia.Rows(indice).Cells(0).Value
                            nombre = dgvConsultaDia.Rows(indice).Cells(1).Value

                            For IndHoras = 0 To 24


                                Dim posicion As TimeSpan

                                posicion = TimeSpan.Parse(dgvHora.Rows(IndHoras).Cells(0).Value)

                                If hora < posicion Then


                                    dgvHora.Rows(IndHoras - 1).Cells(6).Value = nombre
                                    Exit For
                                End If

                            Next
                        Next

                    End If
                Case "5"

                    Consulta = "select hora , p.nombre from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.AddDays(-3).ToString("yyyy-MM-dd") + "';"
                    consultar()


                    dgvConsultaDia.DataSource = Tabla


                    If Not dgvConsultaDia.RowCount = 0 Then



                        Dim hora As TimeSpan
                        Dim nombre As String

                        For indice = 0 To dgvConsultaDia.RowCount - 1


                            hora = dgvConsultaDia.Rows(indice).Cells(0).Value
                            nombre = dgvConsultaDia.Rows(indice).Cells(1).Value

                            For IndHoras = 0 To 24


                                Dim posicion As TimeSpan

                                posicion = TimeSpan.Parse(dgvHora.Rows(IndHoras).Cells(0).Value)

                                If hora < posicion Then


                                    dgvHora.Rows(IndHoras - 1).Cells(1).Value = nombre
                                    Exit For
                                End If

                            Next
                        Next

                    End If

                    Consulta = "select hora , p.nombre from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.AddDays(-2).ToString("yyyy-MM-dd") + "';"
                    consultar()


                    dgvConsultaDia.DataSource = Tabla


                    If Not dgvConsultaDia.RowCount = 0 Then



                        Dim hora As TimeSpan
                        Dim nombre As String

                        For indice = 0 To dgvConsultaDia.RowCount - 1


                            hora = dgvConsultaDia.Rows(indice).Cells(0).Value
                            nombre = dgvConsultaDia.Rows(indice).Cells(1).Value

                            For IndHoras = 0 To 24


                                Dim posicion As TimeSpan

                                posicion = TimeSpan.Parse(dgvHora.Rows(IndHoras).Cells(0).Value)

                                If hora < posicion Then


                                    dgvHora.Rows(IndHoras - 1).Cells(2).Value = nombre
                                    Exit For
                                End If

                            Next
                        Next

                    End If


                    Consulta = "select hora , p.nombre from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.AddDays(-1).ToString("yyyy-MM-dd") + "';"
                    consultar()


                    dgvConsultaDia.DataSource = Tabla


                    If Not dgvConsultaDia.RowCount = 0 Then



                        Dim hora As TimeSpan
                        Dim nombre As String

                        For indice = 0 To dgvConsultaDia.RowCount - 1


                            hora = dgvConsultaDia.Rows(indice).Cells(0).Value
                            nombre = dgvConsultaDia.Rows(indice).Cells(1).Value

                            For IndHoras = 0 To 24


                                Dim posicion As TimeSpan

                                posicion = TimeSpan.Parse(dgvHora.Rows(IndHoras).Cells(0).Value)

                                If hora < posicion Then


                                    dgvHora.Rows(IndHoras - 1).Cells(3).Value = nombre
                                    Exit For
                                End If

                            Next
                        Next

                    End If


                    Consulta = "select hora , p.nombre from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.ToString("yyyy-MM-dd") + "';"
                    consultar()


                    dgvConsultaDia.DataSource = Tabla


                    If Not dgvConsultaDia.RowCount = 0 Then



                        Dim hora As TimeSpan
                        Dim nombre As String

                        For indice = 0 To dgvConsultaDia.RowCount - 1


                            hora = dgvConsultaDia.Rows(indice).Cells(0).Value
                            nombre = dgvConsultaDia.Rows(indice).Cells(1).Value

                            For IndHoras = 0 To 24


                                Dim posicion As TimeSpan

                                posicion = TimeSpan.Parse(dgvHora.Rows(IndHoras).Cells(0).Value)

                                If hora < posicion Then


                                    dgvHora.Rows(IndHoras - 1).Cells(4).Value = nombre
                                    Exit For
                                End If

                            Next
                        Next

                    End If


                    Consulta = "select hora , p.nombre from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.AddDays(1).ToString("yyyy-MM-dd") + "';"
                    consultar()


                    dgvConsultaDia.DataSource = Tabla


                    If Not dgvConsultaDia.RowCount = 0 Then



                        Dim hora As TimeSpan
                        Dim nombre As String

                        For indice = 0 To dgvConsultaDia.RowCount - 1


                            hora = dgvConsultaDia.Rows(indice).Cells(0).Value
                            nombre = dgvConsultaDia.Rows(indice).Cells(1).Value

                            For IndHoras = 0 To 24


                                Dim posicion As TimeSpan

                                posicion = TimeSpan.Parse(dgvHora.Rows(IndHoras).Cells(0).Value)

                                If hora < posicion Then


                                    dgvHora.Rows(IndHoras - 1).Cells(5).Value = nombre
                                    Exit For
                                End If

                            Next
                        Next

                    End If


                    Consulta = "select hora , p.nombre from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.AddDays(2).ToString("yyyy-MM-dd") + "';"
                    consultar()


                    dgvConsultaDia.DataSource = Tabla


                    If Not dgvConsultaDia.RowCount = 0 Then



                        Dim hora As TimeSpan
                        Dim nombre As String

                        For indice = 0 To dgvConsultaDia.RowCount - 1


                            hora = dgvConsultaDia.Rows(indice).Cells(0).Value
                            nombre = dgvConsultaDia.Rows(indice).Cells(1).Value

                            For IndHoras = 0 To 24


                                Dim posicion As TimeSpan

                                posicion = TimeSpan.Parse(dgvHora.Rows(IndHoras).Cells(0).Value)

                                If hora < posicion Then


                                    dgvHora.Rows(IndHoras - 1).Cells(6).Value = nombre
                                    Exit For
                                End If

                            Next
                        Next

                    End If
                Case "6"

                    Consulta = "select hora , p.nombre from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.AddDays(-4).ToString("yyyy-MM-dd") + "';"
                    consultar()


                    dgvConsultaDia.DataSource = Tabla


                    If Not dgvConsultaDia.RowCount = 0 Then



                        Dim hora As TimeSpan
                        Dim nombre As String

                        For indice = 0 To dgvConsultaDia.RowCount - 1


                            hora = dgvConsultaDia.Rows(indice).Cells(0).Value
                            nombre = dgvConsultaDia.Rows(indice).Cells(1).Value

                            For IndHoras = 0 To 24


                                Dim posicion As TimeSpan

                                posicion = TimeSpan.Parse(dgvHora.Rows(IndHoras).Cells(0).Value)

                                If hora < posicion Then


                                    dgvHora.Rows(IndHoras - 1).Cells(1).Value = nombre
                                    Exit For
                                End If

                            Next
                        Next

                    End If


                    Consulta = "select hora , p.nombre from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.AddDays(-3).ToString("yyyy-MM-dd") + "';"
                    consultar()


                    dgvConsultaDia.DataSource = Tabla


                    If Not dgvConsultaDia.RowCount = 0 Then



                        Dim hora As TimeSpan
                        Dim nombre As String

                        For indice = 0 To dgvConsultaDia.RowCount - 1


                            hora = dgvConsultaDia.Rows(indice).Cells(0).Value
                            nombre = dgvConsultaDia.Rows(indice).Cells(1).Value

                            For IndHoras = 0 To 24


                                Dim posicion As TimeSpan

                                posicion = TimeSpan.Parse(dgvHora.Rows(IndHoras).Cells(0).Value)

                                If hora < posicion Then


                                    dgvHora.Rows(IndHoras - 1).Cells(2).Value = nombre
                                    Exit For
                                End If

                            Next
                        Next

                    End If


                    Consulta = "select hora , p.nombre from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.AddDays(-2).ToString("yyyy-MM-dd") + "';"
                    consultar()


                    dgvConsultaDia.DataSource = Tabla


                    If Not dgvConsultaDia.RowCount = 0 Then



                        Dim hora As TimeSpan
                        Dim nombre As String

                        For indice = 0 To dgvConsultaDia.RowCount - 1


                            hora = dgvConsultaDia.Rows(indice).Cells(0).Value
                            nombre = dgvConsultaDia.Rows(indice).Cells(1).Value

                            For IndHoras = 0 To 24


                                Dim posicion As TimeSpan

                                posicion = TimeSpan.Parse(dgvHora.Rows(IndHoras).Cells(0).Value)

                                If hora < posicion Then


                                    dgvHora.Rows(IndHoras - 1).Cells(3).Value = nombre
                                    Exit For
                                End If

                            Next
                        Next

                    End If

                    Consulta = "select hora , p.nombre from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.AddDays(-1).ToString("yyyy-MM-dd") + "';"
                    consultar()


                    dgvConsultaDia.DataSource = Tabla


                    If Not dgvConsultaDia.RowCount = 0 Then



                        Dim hora As TimeSpan
                        Dim nombre As String

                        For indice = 0 To dgvConsultaDia.RowCount - 1


                            hora = dgvConsultaDia.Rows(indice).Cells(0).Value
                            nombre = dgvConsultaDia.Rows(indice).Cells(1).Value

                            For IndHoras = 0 To 24


                                Dim posicion As TimeSpan

                                posicion = TimeSpan.Parse(dgvHora.Rows(IndHoras).Cells(0).Value)

                                If hora < posicion Then


                                    dgvHora.Rows(IndHoras - 1).Cells(4).Value = nombre
                                    Exit For
                                End If

                            Next
                        Next

                    End If

                    Consulta = "select hora , p.nombre from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.ToString("yyyy-MM-dd") + "';"
                    consultar()


                    dgvConsultaDia.DataSource = Tabla


                    If Not dgvConsultaDia.RowCount = 0 Then



                        Dim hora As TimeSpan
                        Dim nombre As String

                        For indice = 0 To dgvConsultaDia.RowCount - 1


                            hora = dgvConsultaDia.Rows(indice).Cells(0).Value
                            nombre = dgvConsultaDia.Rows(indice).Cells(1).Value

                            For IndHoras = 0 To 24


                                Dim posicion As TimeSpan

                                posicion = TimeSpan.Parse(dgvHora.Rows(IndHoras).Cells(0).Value)

                                If hora < posicion Then


                                    dgvHora.Rows(IndHoras - 1).Cells(5).Value = nombre
                                    Exit For
                                End If

                            Next
                        Next

                    End If

                    Consulta = "select hora , p.nombre from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.AddDays(1).ToString("yyyy-MM-dd") + "';"
                    consultar()


                    dgvConsultaDia.DataSource = Tabla


                    If Not dgvConsultaDia.RowCount = 0 Then



                        Dim hora As TimeSpan
                        Dim nombre As String

                        For indice = 0 To dgvConsultaDia.RowCount - 1


                            hora = dgvConsultaDia.Rows(indice).Cells(0).Value
                            nombre = dgvConsultaDia.Rows(indice).Cells(1).Value

                            For IndHoras = 0 To 24


                                Dim posicion As TimeSpan

                                posicion = TimeSpan.Parse(dgvHora.Rows(IndHoras).Cells(0).Value)

                                If hora < posicion Then


                                    dgvHora.Rows(IndHoras - 1).Cells(6).Value = nombre
                                    Exit For
                                End If

                            Next
                        Next

                    End If
                Case "7"

                    Consulta = "select hora , p.nombre from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.AddDays(-5).ToString("yyyy-MM-dd") + "';"
                    consultar()


                    dgvConsultaDia.DataSource = Tabla


                    If Not dgvConsultaDia.RowCount = 0 Then



                        Dim hora As TimeSpan
                        Dim nombre As String

                        For indice = 0 To dgvConsultaDia.RowCount - 1


                            hora = dgvConsultaDia.Rows(indice).Cells(0).Value
                            nombre = dgvConsultaDia.Rows(indice).Cells(1).Value

                            For IndHoras = 0 To 24


                                Dim posicion As TimeSpan

                                posicion = TimeSpan.Parse(dgvHora.Rows(IndHoras).Cells(0).Value)

                                If hora < posicion Then


                                    dgvHora.Rows(IndHoras - 1).Cells(1).Value = nombre
                                    Exit For
                                End If

                            Next
                        Next

                    End If

                    Consulta = "select hora , p.nombre from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.AddDays(-4).ToString("yyyy-MM-dd") + "';"
                    consultar()


                    dgvConsultaDia.DataSource = Tabla


                    If Not dgvConsultaDia.RowCount = 0 Then



                        Dim hora As TimeSpan
                        Dim nombre As String

                        For indice = 0 To dgvConsultaDia.RowCount - 1


                            hora = dgvConsultaDia.Rows(indice).Cells(0).Value
                            nombre = dgvConsultaDia.Rows(indice).Cells(1).Value

                            For IndHoras = 0 To 24


                                Dim posicion As TimeSpan

                                posicion = TimeSpan.Parse(dgvHora.Rows(IndHoras).Cells(0).Value)

                                If hora < posicion Then


                                    dgvHora.Rows(IndHoras - 1).Cells(2).Value = nombre
                                    Exit For
                                End If

                            Next
                        Next

                    End If

                    Consulta = "select hora , p.nombre from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.AddDays(-3).ToString("yyyy-MM-dd") + "';"
                    consultar()


                    dgvConsultaDia.DataSource = Tabla


                    If Not dgvConsultaDia.RowCount = 0 Then



                        Dim hora As TimeSpan
                        Dim nombre As String

                        For indice = 0 To dgvConsultaDia.RowCount - 1


                            hora = dgvConsultaDia.Rows(indice).Cells(0).Value
                            nombre = dgvConsultaDia.Rows(indice).Cells(1).Value

                            For IndHoras = 0 To 24


                                Dim posicion As TimeSpan

                                posicion = TimeSpan.Parse(dgvHora.Rows(IndHoras).Cells(0).Value)

                                If hora < posicion Then


                                    dgvHora.Rows(IndHoras - 1).Cells(3).Value = nombre
                                    Exit For
                                End If

                            Next
                        Next

                    End If


                    Consulta = "select hora , p.nombre from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.AddDays(-2).ToString("yyyy-MM-dd") + "';"
                    consultar()


                    dgvConsultaDia.DataSource = Tabla


                    If Not dgvConsultaDia.RowCount = 0 Then



                        Dim hora As TimeSpan
                        Dim nombre As String

                        For indice = 0 To dgvConsultaDia.RowCount - 1


                            hora = dgvConsultaDia.Rows(indice).Cells(0).Value
                            nombre = dgvConsultaDia.Rows(indice).Cells(1).Value

                            For IndHoras = 0 To 24


                                Dim posicion As TimeSpan

                                posicion = TimeSpan.Parse(dgvHora.Rows(IndHoras).Cells(0).Value)

                                If hora < posicion Then


                                    dgvHora.Rows(IndHoras - 1).Cells(4).Value = nombre
                                    Exit For
                                End If

                            Next
                        Next

                    End If


                    Consulta = "select hora , p.nombre from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.AddDays(-1).ToString("yyyy-MM-dd") + "';"
                    consultar()


                    dgvConsultaDia.DataSource = Tabla


                    If Not dgvConsultaDia.RowCount = 0 Then



                        Dim hora As TimeSpan
                        Dim nombre As String

                        For indice = 0 To dgvConsultaDia.RowCount - 1


                            hora = dgvConsultaDia.Rows(indice).Cells(0).Value
                            nombre = dgvConsultaDia.Rows(indice).Cells(1).Value

                            For IndHoras = 0 To 24


                                Dim posicion As TimeSpan

                                posicion = TimeSpan.Parse(dgvHora.Rows(IndHoras).Cells(0).Value)

                                If hora < posicion Then


                                    dgvHora.Rows(IndHoras - 1).Cells(5).Value = nombre
                                    Exit For
                                End If

                            Next
                        Next

                    End If

                    Consulta = "select hora , p.nombre from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.ToString("yyyy-MM-dd") + "';"
                    consultar()


                    dgvConsultaDia.DataSource = Tabla


                    If Not dgvConsultaDia.RowCount = 0 Then



                        Dim hora As TimeSpan
                        Dim nombre As String

                        For indice = 0 To dgvConsultaDia.RowCount - 1


                            hora = dgvConsultaDia.Rows(indice).Cells(0).Value
                            nombre = dgvConsultaDia.Rows(indice).Cells(1).Value

                            For IndHoras = 0 To 24


                                Dim posicion As TimeSpan

                                posicion = TimeSpan.Parse(dgvHora.Rows(IndHoras).Cells(0).Value)

                                If hora < posicion Then


                                    dgvHora.Rows(IndHoras - 1).Cells(6).Value = nombre
                                    Exit For
                                End If

                            Next
                        Next

                    End If
            End Select





        Catch ex As Exception
            MsgBox("Error al cargar citas", MsgBoxStyle.Exclamation)
        End Try





        Button2.Visible = False
    End Sub

    Private Sub Label19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Dispose()
        Aranceles.Show()
    End Sub

    Private Sub Label20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Dispose()
        frmPacientes.Show()
    End Sub

    Private Sub SaveFileDialog3_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)

    End Sub

    Private Sub MonthCalendar1_DateChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles MCFecha.DateChanged
        For x = 0 To dgvHora.RowCount - 1
            dgvHora.Rows(x).Cells(1).Value = ""
            dgvHora.Rows(x).Cells(2).Value = ""
            dgvHora.Rows(x).Cells(3).Value = ""
            dgvHora.Rows(x).Cells(4).Value = ""
            dgvHora.Rows(x).Cells(5).Value = ""
            dgvHora.Rows(x).Cells(6).Value = ""
        Next

        Try
            DiaSeleccionado = MCFecha.SelectionRange.Start
            FCalendario = Weekday(DiaSeleccionado)



            LabelDia.Text = ("" + dia)
            seleccionado.Text = ("" + DiaSeleccionado)



            ''En un case se muestran los datos de la semana seleccionada por el usuario
            Select Case FCalendario

                Case "2"

                    Consulta = "select hora , p.nombre from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.ToString("yyyy-MM-dd") + "';"
                    consultar()


                    dgvConsultaDia.DataSource = Tabla


                    If Not dgvConsultaDia.RowCount = 0 Then



                        Dim hora As TimeSpan
                        Dim nombre As String

                        For indice = 0 To dgvConsultaDia.RowCount - 1


                            hora = dgvConsultaDia.Rows(indice).Cells(0).Value
                            nombre = dgvConsultaDia.Rows(indice).Cells(1).Value

                            For IndHoras = 0 To 24


                                Dim posicion As TimeSpan

                                posicion = TimeSpan.Parse(dgvHora.Rows(IndHoras).Cells(0).Value)

                                If hora < posicion Then


                                    dgvHora.Rows(IndHoras - 1).Cells(1).Value = nombre
                                    Exit For
                                End If

                            Next
                        Next

                    End If

                    Consulta = "select hora , p.nombre from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.AddDays(1).ToString("yyyy-MM-dd") + "';"
                    consultar()


                    dgvConsultaDia.DataSource = Tabla


                    If Not dgvConsultaDia.RowCount = 0 Then

                        Dim hora As TimeSpan
                        Dim nombre As String

                        For indice = 0 To dgvConsultaDia.RowCount - 1


                            hora = dgvConsultaDia.Rows(indice).Cells(0).Value
                            nombre = dgvConsultaDia.Rows(indice).Cells(1).Value

                            For IndHoras = 0 To 24


                                Dim posicion As TimeSpan

                                posicion = TimeSpan.Parse(dgvHora.Rows(IndHoras).Cells(0).Value)

                                If hora < posicion Then


                                    dgvHora.Rows(IndHoras - 1).Cells(2).Value = nombre
                                    Exit For
                                End If

                            Next
                        Next

                    End If

                    Consulta = "select hora , p.nombre from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.AddDays(2).ToString("yyyy-MM-dd") + "';"
                    consultar()


                    dgvConsultaDia.DataSource = Tabla


                    If Not dgvConsultaDia.RowCount = 0 Then

                        Dim hora As TimeSpan
                        Dim nombre As String

                        For indice = 0 To dgvConsultaDia.RowCount - 1


                            hora = dgvConsultaDia.Rows(indice).Cells(0).Value
                            nombre = dgvConsultaDia.Rows(indice).Cells(1).Value

                            For IndHoras = 0 To 24


                                Dim posicion As TimeSpan

                                posicion = TimeSpan.Parse(dgvHora.Rows(IndHoras).Cells(0).Value)

                                If hora < posicion Then


                                    dgvHora.Rows(IndHoras - 1).Cells(3).Value = nombre
                                    Exit For
                                End If

                            Next
                        Next

                    End If

                    Consulta = "select hora , p.nombre from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.AddDays(3).ToString("yyyy-MM-dd") + "';"
                    consultar()


                    dgvConsultaDia.DataSource = Tabla


                    If Not dgvConsultaDia.RowCount = 0 Then

                        Dim hora As TimeSpan
                        Dim nombre As String

                        For indice = 0 To dgvConsultaDia.RowCount - 1


                            hora = dgvConsultaDia.Rows(indice).Cells(0).Value
                            nombre = dgvConsultaDia.Rows(indice).Cells(1).Value

                            For IndHoras = 0 To 24


                                Dim posicion As TimeSpan

                                posicion = TimeSpan.Parse(dgvHora.Rows(IndHoras).Cells(0).Value)

                                If hora < posicion Then


                                    dgvHora.Rows(IndHoras - 1).Cells(4).Value = nombre
                                    Exit For
                                End If

                            Next
                        Next

                    End If


                    Consulta = "select hora , p.nombre from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.AddDays(4).ToString("yyyy-MM-dd") + "';"
                    consultar()


                    dgvConsultaDia.DataSource = Tabla


                    If Not dgvConsultaDia.RowCount = 0 Then

                        Dim hora As TimeSpan
                        Dim nombre As String

                        For indice = 0 To dgvConsultaDia.RowCount - 1


                            hora = dgvConsultaDia.Rows(indice).Cells(0).Value
                            nombre = dgvConsultaDia.Rows(indice).Cells(1).Value

                            For IndHoras = 0 To 24


                                Dim posicion As TimeSpan

                                posicion = TimeSpan.Parse(dgvHora.Rows(IndHoras).Cells(0).Value)

                                If hora < posicion Then


                                    dgvHora.Rows(IndHoras - 1).Cells(5).Value = nombre
                                    Exit For
                                End If

                            Next
                        Next

                    End If

                    Consulta = "select hora , p.nombre from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.AddDays(5).ToString("yyyy-MM-dd") + "';"
                    consultar()


                    dgvConsultaDia.DataSource = Tabla


                    If Not dgvConsultaDia.RowCount = 0 Then

                        Dim hora As TimeSpan
                        Dim nombre As String

                        For indice = 0 To dgvConsultaDia.RowCount - 1


                            hora = dgvConsultaDia.Rows(indice).Cells(0).Value
                            nombre = dgvConsultaDia.Rows(indice).Cells(1).Value

                            For IndHoras = 0 To 24


                                Dim posicion As TimeSpan

                                posicion = TimeSpan.Parse(dgvHora.Rows(IndHoras).Cells(0).Value)

                                If hora < posicion Then


                                    dgvHora.Rows(IndHoras - 1).Cells(6).Value = nombre
                                    Exit For
                                End If

                            Next
                        Next

                    End If



                Case "3"




                    Consulta = "select hora , p.nombre from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.AddDays(-1).ToString("yyyy-MM-dd") + "';"
                    consultar()


                    dgvConsultaDia.DataSource = Tabla


                    If Not dgvConsultaDia.RowCount = 0 Then



                        Dim hora As TimeSpan
                        Dim nombre As String

                        For indice = 0 To dgvConsultaDia.RowCount - 1


                            hora = dgvConsultaDia.Rows(indice).Cells(0).Value
                            nombre = dgvConsultaDia.Rows(indice).Cells(1).Value

                            For IndHoras = 0 To 24


                                Dim posicion As TimeSpan

                                posicion = TimeSpan.Parse(dgvHora.Rows(IndHoras).Cells(0).Value)

                                If hora < posicion Then


                                    dgvHora.Rows(IndHoras - 1).Cells(1).Value = nombre
                                    Exit For
                                End If

                            Next
                        Next

                    End If

                    Consulta = "select hora , p.nombre from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.ToString("yyyy-MM-dd") + "';"
                    consultar()


                    dgvConsultaDia.DataSource = Tabla


                    If Not dgvConsultaDia.RowCount = 0 Then



                        Dim hora As TimeSpan
                        Dim nombre As String

                        For indice = 0 To dgvConsultaDia.RowCount - 1


                            hora = dgvConsultaDia.Rows(indice).Cells(0).Value
                            nombre = dgvConsultaDia.Rows(indice).Cells(1).Value

                            For IndHoras = 0 To 24


                                Dim posicion As TimeSpan

                                posicion = TimeSpan.Parse(dgvHora.Rows(IndHoras).Cells(0).Value)

                                If hora < posicion Then


                                    dgvHora.Rows(IndHoras - 1).Cells(2).Value = nombre
                                    Exit For
                                End If

                            Next
                        Next

                    End If

                    Consulta = "select hora , p.nombre from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.AddDays(1).ToString("yyyy-MM-dd") + "';"
                    consultar()


                    dgvConsultaDia.DataSource = Tabla


                    If Not dgvConsultaDia.RowCount = 0 Then



                        Dim hora As TimeSpan
                        Dim nombre As String

                        For indice = 0 To dgvConsultaDia.RowCount - 1


                            hora = dgvConsultaDia.Rows(indice).Cells(0).Value
                            nombre = dgvConsultaDia.Rows(indice).Cells(1).Value

                            For IndHoras = 0 To 24


                                Dim posicion As TimeSpan

                                posicion = TimeSpan.Parse(dgvHora.Rows(IndHoras).Cells(0).Value)

                                If hora < posicion Then


                                    dgvHora.Rows(IndHoras - 1).Cells(3).Value = nombre
                                    Exit For
                                End If

                            Next
                        Next

                    End If

                    Consulta = "select hora , p.nombre from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.AddDays(2).ToString("yyyy-MM-dd") + "';"
                    consultar()


                    dgvConsultaDia.DataSource = Tabla


                    If Not dgvConsultaDia.RowCount = 0 Then



                        Dim hora As TimeSpan
                        Dim nombre As String

                        For indice = 0 To dgvConsultaDia.RowCount - 1


                            hora = dgvConsultaDia.Rows(indice).Cells(0).Value
                            nombre = dgvConsultaDia.Rows(indice).Cells(1).Value

                            For IndHoras = 0 To 24


                                Dim posicion As TimeSpan

                                posicion = TimeSpan.Parse(dgvHora.Rows(IndHoras).Cells(0).Value)

                                If hora < posicion Then


                                    dgvHora.Rows(IndHoras - 1).Cells(4).Value = nombre
                                    Exit For
                                End If

                            Next
                        Next

                    End If

                    Consulta = "select hora , p.nombre from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.AddDays(3).ToString("yyyy-MM-dd") + "';"
                    consultar()


                    dgvConsultaDia.DataSource = Tabla


                    If Not dgvConsultaDia.RowCount = 0 Then



                        Dim hora As TimeSpan
                        Dim nombre As String

                        For indice = 0 To dgvConsultaDia.RowCount - 1


                            hora = dgvConsultaDia.Rows(indice).Cells(0).Value
                            nombre = dgvConsultaDia.Rows(indice).Cells(1).Value

                            For IndHoras = 0 To 24


                                Dim posicion As TimeSpan

                                posicion = TimeSpan.Parse(dgvHora.Rows(IndHoras).Cells(0).Value)

                                If hora < posicion Then


                                    dgvHora.Rows(IndHoras - 1).Cells(5).Value = nombre
                                    Exit For
                                End If

                            Next
                        Next

                    End If


                    Consulta = "select hora , p.nombre from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.AddDays(4).ToString("yyyy-MM-dd") + "';"
                    consultar()


                    dgvConsultaDia.DataSource = Tabla


                    If Not dgvConsultaDia.RowCount = 0 Then



                        Dim hora As TimeSpan
                        Dim nombre As String

                        For indice = 0 To dgvConsultaDia.RowCount - 1


                            hora = dgvConsultaDia.Rows(indice).Cells(0).Value
                            nombre = dgvConsultaDia.Rows(indice).Cells(1).Value

                            For IndHoras = 0 To 24


                                Dim posicion As TimeSpan

                                posicion = TimeSpan.Parse(dgvHora.Rows(IndHoras).Cells(0).Value)

                                If hora < posicion Then


                                    dgvHora.Rows(IndHoras - 1).Cells(6).Value = nombre
                                    Exit For
                                End If

                            Next
                        Next

                    End If



                Case "4"


                    Consulta = "select hora , p.nombre from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.AddDays(-2).ToString("yyyy-MM-dd") + "';"
                    consultar()


                    dgvConsultaDia.DataSource = Tabla


                    If Not dgvConsultaDia.RowCount = 0 Then



                        Dim hora As TimeSpan
                        Dim nombre As String

                        For indice = 0 To dgvConsultaDia.RowCount - 1


                            hora = dgvConsultaDia.Rows(indice).Cells(0).Value
                            nombre = dgvConsultaDia.Rows(indice).Cells(1).Value

                            For IndHoras = 0 To 24


                                Dim posicion As TimeSpan

                                posicion = TimeSpan.Parse(dgvHora.Rows(IndHoras).Cells(0).Value)

                                If hora < posicion Then


                                    dgvHora.Rows(IndHoras - 1).Cells(1).Value = nombre
                                    Exit For
                                End If

                            Next
                        Next

                    End If


                    Consulta = "select hora , p.nombre from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.AddDays(-1).ToString("yyyy-MM-dd") + "';"
                    consultar()


                    dgvConsultaDia.DataSource = Tabla


                    If Not dgvConsultaDia.RowCount = 0 Then



                        Dim hora As TimeSpan
                        Dim nombre As String

                        For indice = 0 To dgvConsultaDia.RowCount - 1


                            hora = dgvConsultaDia.Rows(indice).Cells(0).Value
                            nombre = dgvConsultaDia.Rows(indice).Cells(1).Value

                            For IndHoras = 0 To 24


                                Dim posicion As TimeSpan

                                posicion = TimeSpan.Parse(dgvHora.Rows(IndHoras).Cells(0).Value)

                                If hora < posicion Then


                                    dgvHora.Rows(IndHoras - 1).Cells(2).Value = nombre
                                    Exit For
                                End If

                            Next
                        Next

                    End If



                    Consulta = "select hora , p.nombre from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.ToString("yyyy-MM-dd") + "';"
                    consultar()


                    dgvConsultaDia.DataSource = Tabla


                    If Not dgvConsultaDia.RowCount = 0 Then



                        Dim hora As TimeSpan
                        Dim nombre As String

                        For indice = 0 To dgvConsultaDia.RowCount - 1


                            hora = dgvConsultaDia.Rows(indice).Cells(0).Value
                            nombre = dgvConsultaDia.Rows(indice).Cells(1).Value

                            For IndHoras = 0 To 24


                                Dim posicion As TimeSpan

                                posicion = TimeSpan.Parse(dgvHora.Rows(IndHoras).Cells(0).Value)

                                If hora < posicion Then


                                    dgvHora.Rows(IndHoras - 1).Cells(3).Value = nombre
                                    Exit For
                                End If

                            Next
                        Next

                    End If



                    Consulta = "select hora , p.nombre from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.AddDays(1).ToString("yyyy-MM-dd") + "';"
                    consultar()


                    dgvConsultaDia.DataSource = Tabla


                    If Not dgvConsultaDia.RowCount = 0 Then



                        Dim hora As TimeSpan
                        Dim nombre As String

                        For indice = 0 To dgvConsultaDia.RowCount - 1


                            hora = dgvConsultaDia.Rows(indice).Cells(0).Value
                            nombre = dgvConsultaDia.Rows(indice).Cells(1).Value

                            For IndHoras = 0 To 24


                                Dim posicion As TimeSpan

                                posicion = TimeSpan.Parse(dgvHora.Rows(IndHoras).Cells(0).Value)

                                If hora < posicion Then


                                    dgvHora.Rows(IndHoras - 1).Cells(4).Value = nombre
                                    Exit For
                                End If

                            Next
                        Next

                    End If



                    Consulta = "select hora , p.nombre from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.AddDays(2).ToString("yyyy-MM-dd") + "';"
                    consultar()


                    dgvConsultaDia.DataSource = Tabla


                    If Not dgvConsultaDia.RowCount = 0 Then



                        Dim hora As TimeSpan
                        Dim nombre As String

                        For indice = 0 To dgvConsultaDia.RowCount - 1


                            hora = dgvConsultaDia.Rows(indice).Cells(0).Value
                            nombre = dgvConsultaDia.Rows(indice).Cells(1).Value

                            For IndHoras = 0 To 24


                                Dim posicion As TimeSpan

                                posicion = TimeSpan.Parse(dgvHora.Rows(IndHoras).Cells(0).Value)

                                If hora < posicion Then


                                    dgvHora.Rows(IndHoras - 1).Cells(5).Value = nombre
                                    Exit For
                                End If

                            Next
                        Next

                    End If



                    Consulta = "select hora , p.nombre from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.AddDays(3).ToString("yyyy-MM-dd") + "';"
                    consultar()


                    dgvConsultaDia.DataSource = Tabla


                    If Not dgvConsultaDia.RowCount = 0 Then



                        Dim hora As TimeSpan
                        Dim nombre As String

                        For indice = 0 To dgvConsultaDia.RowCount - 1


                            hora = dgvConsultaDia.Rows(indice).Cells(0).Value
                            nombre = dgvConsultaDia.Rows(indice).Cells(1).Value

                            For IndHoras = 0 To 24


                                Dim posicion As TimeSpan

                                posicion = TimeSpan.Parse(dgvHora.Rows(IndHoras).Cells(0).Value)

                                If hora < posicion Then


                                    dgvHora.Rows(IndHoras - 1).Cells(6).Value = nombre
                                    Exit For
                                End If

                            Next
                        Next

                    End If
                Case "5"

                    Consulta = "select hora , p.nombre from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.AddDays(-3).ToString("yyyy-MM-dd") + "';"
                    consultar()


                    dgvConsultaDia.DataSource = Tabla


                    If Not dgvConsultaDia.RowCount = 0 Then



                        Dim hora As TimeSpan
                        Dim nombre As String

                        For indice = 0 To dgvConsultaDia.RowCount - 1


                            hora = dgvConsultaDia.Rows(indice).Cells(0).Value
                            nombre = dgvConsultaDia.Rows(indice).Cells(1).Value

                            For IndHoras = 0 To 24


                                Dim posicion As TimeSpan

                                posicion = TimeSpan.Parse(dgvHora.Rows(IndHoras).Cells(0).Value)

                                If hora < posicion Then


                                    dgvHora.Rows(IndHoras - 1).Cells(1).Value = nombre
                                    Exit For
                                End If

                            Next
                        Next

                    End If

                    Consulta = "select hora , p.nombre from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.AddDays(-2).ToString("yyyy-MM-dd") + "';"
                    consultar()


                    dgvConsultaDia.DataSource = Tabla


                    If Not dgvConsultaDia.RowCount = 0 Then



                        Dim hora As TimeSpan
                        Dim nombre As String

                        For indice = 0 To dgvConsultaDia.RowCount - 1


                            hora = dgvConsultaDia.Rows(indice).Cells(0).Value
                            nombre = dgvConsultaDia.Rows(indice).Cells(1).Value

                            For IndHoras = 0 To 24


                                Dim posicion As TimeSpan

                                posicion = TimeSpan.Parse(dgvHora.Rows(IndHoras).Cells(0).Value)

                                If hora < posicion Then


                                    dgvHora.Rows(IndHoras - 1).Cells(2).Value = nombre
                                    Exit For
                                End If

                            Next
                        Next

                    End If


                    Consulta = "select hora , p.nombre from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.AddDays(-1).ToString("yyyy-MM-dd") + "';"
                    consultar()


                    dgvConsultaDia.DataSource = Tabla


                    If Not dgvConsultaDia.RowCount = 0 Then



                        Dim hora As TimeSpan
                        Dim nombre As String

                        For indice = 0 To dgvConsultaDia.RowCount - 1


                            hora = dgvConsultaDia.Rows(indice).Cells(0).Value
                            nombre = dgvConsultaDia.Rows(indice).Cells(1).Value

                            For IndHoras = 0 To 24


                                Dim posicion As TimeSpan

                                posicion = TimeSpan.Parse(dgvHora.Rows(IndHoras).Cells(0).Value)

                                If hora < posicion Then


                                    dgvHora.Rows(IndHoras - 1).Cells(3).Value = nombre
                                    Exit For
                                End If

                            Next
                        Next

                    End If


                    Consulta = "select hora , p.nombre from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.ToString("yyyy-MM-dd") + "';"
                    consultar()


                    dgvConsultaDia.DataSource = Tabla


                    If Not dgvConsultaDia.RowCount = 0 Then



                        Dim hora As TimeSpan
                        Dim nombre As String

                        For indice = 0 To dgvConsultaDia.RowCount - 1


                            hora = dgvConsultaDia.Rows(indice).Cells(0).Value
                            nombre = dgvConsultaDia.Rows(indice).Cells(1).Value

                            For IndHoras = 0 To 24


                                Dim posicion As TimeSpan

                                posicion = TimeSpan.Parse(dgvHora.Rows(IndHoras).Cells(0).Value)

                                If hora < posicion Then


                                    dgvHora.Rows(IndHoras - 1).Cells(4).Value = nombre
                                    Exit For
                                End If

                            Next
                        Next

                    End If


                    Consulta = "select hora , p.nombre from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.AddDays(1).ToString("yyyy-MM-dd") + "';"
                    consultar()


                    dgvConsultaDia.DataSource = Tabla


                    If Not dgvConsultaDia.RowCount = 0 Then



                        Dim hora As TimeSpan
                        Dim nombre As String

                        For indice = 0 To dgvConsultaDia.RowCount - 1


                            hora = dgvConsultaDia.Rows(indice).Cells(0).Value
                            nombre = dgvConsultaDia.Rows(indice).Cells(1).Value

                            For IndHoras = 0 To 24


                                Dim posicion As TimeSpan

                                posicion = TimeSpan.Parse(dgvHora.Rows(IndHoras).Cells(0).Value)

                                If hora < posicion Then


                                    dgvHora.Rows(IndHoras - 1).Cells(5).Value = nombre
                                    Exit For
                                End If

                            Next
                        Next

                    End If


                    Consulta = "select hora , p.nombre from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.AddDays(2).ToString("yyyy-MM-dd") + "';"
                    consultar()


                    dgvConsultaDia.DataSource = Tabla


                    If Not dgvConsultaDia.RowCount = 0 Then



                        Dim hora As TimeSpan
                        Dim nombre As String

                        For indice = 0 To dgvConsultaDia.RowCount - 1


                            hora = dgvConsultaDia.Rows(indice).Cells(0).Value
                            nombre = dgvConsultaDia.Rows(indice).Cells(1).Value

                            For IndHoras = 0 To 24


                                Dim posicion As TimeSpan

                                posicion = TimeSpan.Parse(dgvHora.Rows(IndHoras).Cells(0).Value)

                                If hora < posicion Then


                                    dgvHora.Rows(IndHoras - 1).Cells(6).Value = nombre
                                    Exit For
                                End If

                            Next
                        Next

                    End If
                Case "6"

                    Consulta = "select hora , p.nombre from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.AddDays(-4).ToString("yyyy-MM-dd") + "';"
                    consultar()


                    dgvConsultaDia.DataSource = Tabla


                    If Not dgvConsultaDia.RowCount = 0 Then



                        Dim hora As TimeSpan
                        Dim nombre As String

                        For indice = 0 To dgvConsultaDia.RowCount - 1


                            hora = dgvConsultaDia.Rows(indice).Cells(0).Value
                            nombre = dgvConsultaDia.Rows(indice).Cells(1).Value

                            For IndHoras = 0 To 24


                                Dim posicion As TimeSpan

                                posicion = TimeSpan.Parse(dgvHora.Rows(IndHoras).Cells(0).Value)

                                If hora < posicion Then


                                    dgvHora.Rows(IndHoras - 1).Cells(1).Value = nombre
                                    Exit For
                                End If

                            Next
                        Next

                    End If


                    Consulta = "select hora , p.nombre from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.AddDays(-3).ToString("yyyy-MM-dd") + "';"
                    consultar()


                    dgvConsultaDia.DataSource = Tabla


                    If Not dgvConsultaDia.RowCount = 0 Then



                        Dim hora As TimeSpan
                        Dim nombre As String

                        For indice = 0 To dgvConsultaDia.RowCount - 1


                            hora = dgvConsultaDia.Rows(indice).Cells(0).Value
                            nombre = dgvConsultaDia.Rows(indice).Cells(1).Value

                            For IndHoras = 0 To 24


                                Dim posicion As TimeSpan

                                posicion = TimeSpan.Parse(dgvHora.Rows(IndHoras).Cells(0).Value)

                                If hora < posicion Then


                                    dgvHora.Rows(IndHoras - 1).Cells(2).Value = nombre
                                    Exit For
                                End If

                            Next
                        Next

                    End If


                    Consulta = "select hora , p.nombre from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.AddDays(-2).ToString("yyyy-MM-dd") + "';"
                    consultar()


                    dgvConsultaDia.DataSource = Tabla


                    If Not dgvConsultaDia.RowCount = 0 Then



                        Dim hora As TimeSpan
                        Dim nombre As String

                        For indice = 0 To dgvConsultaDia.RowCount - 1


                            hora = dgvConsultaDia.Rows(indice).Cells(0).Value
                            nombre = dgvConsultaDia.Rows(indice).Cells(1).Value

                            For IndHoras = 0 To 24


                                Dim posicion As TimeSpan

                                posicion = TimeSpan.Parse(dgvHora.Rows(IndHoras).Cells(0).Value)

                                If hora < posicion Then


                                    dgvHora.Rows(IndHoras - 1).Cells(3).Value = nombre
                                    Exit For
                                End If

                            Next
                        Next

                    End If

                    Consulta = "select hora , p.nombre from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.AddDays(-1).ToString("yyyy-MM-dd") + "';"
                    consultar()


                    dgvConsultaDia.DataSource = Tabla


                    If Not dgvConsultaDia.RowCount = 0 Then



                        Dim hora As TimeSpan
                        Dim nombre As String

                        For indice = 0 To dgvConsultaDia.RowCount - 1


                            hora = dgvConsultaDia.Rows(indice).Cells(0).Value
                            nombre = dgvConsultaDia.Rows(indice).Cells(1).Value

                            For IndHoras = 0 To 24


                                Dim posicion As TimeSpan

                                posicion = TimeSpan.Parse(dgvHora.Rows(IndHoras).Cells(0).Value)

                                If hora < posicion Then


                                    dgvHora.Rows(IndHoras - 1).Cells(4).Value = nombre
                                    Exit For
                                End If

                            Next
                        Next

                    End If

                    Consulta = "select hora , p.nombre from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.ToString("yyyy-MM-dd") + "';"
                    consultar()


                    dgvConsultaDia.DataSource = Tabla


                    If Not dgvConsultaDia.RowCount = 0 Then



                        Dim hora As TimeSpan
                        Dim nombre As String

                        For indice = 0 To dgvConsultaDia.RowCount - 1


                            hora = dgvConsultaDia.Rows(indice).Cells(0).Value
                            nombre = dgvConsultaDia.Rows(indice).Cells(1).Value

                            For IndHoras = 0 To 24


                                Dim posicion As TimeSpan

                                posicion = TimeSpan.Parse(dgvHora.Rows(IndHoras).Cells(0).Value)

                                If hora < posicion Then


                                    dgvHora.Rows(IndHoras - 1).Cells(5).Value = nombre
                                    Exit For
                                End If

                            Next
                        Next

                    End If

                    Consulta = "select hora , p.nombre from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.AddDays(1).ToString("yyyy-MM-dd") + "';"
                    consultar()


                    dgvConsultaDia.DataSource = Tabla


                    If Not dgvConsultaDia.RowCount = 0 Then



                        Dim hora As TimeSpan
                        Dim nombre As String

                        For indice = 0 To dgvConsultaDia.RowCount - 1


                            hora = dgvConsultaDia.Rows(indice).Cells(0).Value
                            nombre = dgvConsultaDia.Rows(indice).Cells(1).Value

                            For IndHoras = 0 To 24


                                Dim posicion As TimeSpan

                                posicion = TimeSpan.Parse(dgvHora.Rows(IndHoras).Cells(0).Value)

                                If hora < posicion Then


                                    dgvHora.Rows(IndHoras - 1).Cells(6).Value = nombre
                                    Exit For
                                End If

                            Next
                        Next

                    End If
                Case "7"

                    Consulta = "select hora , p.nombre from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.AddDays(-5).ToString("yyyy-MM-dd") + "';"
                    consultar()


                    dgvConsultaDia.DataSource = Tabla


                    If Not dgvConsultaDia.RowCount = 0 Then



                        Dim hora As TimeSpan
                        Dim nombre As String

                        For indice = 0 To dgvConsultaDia.RowCount - 1


                            hora = dgvConsultaDia.Rows(indice).Cells(0).Value
                            nombre = dgvConsultaDia.Rows(indice).Cells(1).Value

                            For IndHoras = 0 To 24


                                Dim posicion As TimeSpan

                                posicion = TimeSpan.Parse(dgvHora.Rows(IndHoras).Cells(0).Value)

                                If hora < posicion Then


                                    dgvHora.Rows(IndHoras - 1).Cells(1).Value = nombre
                                    Exit For
                                End If

                            Next
                        Next

                    End If

                    Consulta = "select hora , p.nombre from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.AddDays(-4).ToString("yyyy-MM-dd") + "';"
                    consultar()


                    dgvConsultaDia.DataSource = Tabla


                    If Not dgvConsultaDia.RowCount = 0 Then



                        Dim hora As TimeSpan
                        Dim nombre As String

                        For indice = 0 To dgvConsultaDia.RowCount - 1


                            hora = dgvConsultaDia.Rows(indice).Cells(0).Value
                            nombre = dgvConsultaDia.Rows(indice).Cells(1).Value

                            For IndHoras = 0 To 24


                                Dim posicion As TimeSpan

                                posicion = TimeSpan.Parse(dgvHora.Rows(IndHoras).Cells(0).Value)

                                If hora < posicion Then


                                    dgvHora.Rows(IndHoras - 1).Cells(2).Value = nombre
                                    Exit For
                                End If

                            Next
                        Next

                    End If

                    Consulta = "select hora , p.nombre from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.AddDays(-3).ToString("yyyy-MM-dd") + "';"
                    consultar()


                    dgvConsultaDia.DataSource = Tabla


                    If Not dgvConsultaDia.RowCount = 0 Then



                        Dim hora As TimeSpan
                        Dim nombre As String

                        For indice = 0 To dgvConsultaDia.RowCount - 1


                            hora = dgvConsultaDia.Rows(indice).Cells(0).Value
                            nombre = dgvConsultaDia.Rows(indice).Cells(1).Value

                            For IndHoras = 0 To 24


                                Dim posicion As TimeSpan

                                posicion = TimeSpan.Parse(dgvHora.Rows(IndHoras).Cells(0).Value)

                                If hora < posicion Then


                                    dgvHora.Rows(IndHoras - 1).Cells(3).Value = nombre
                                    Exit For
                                End If

                            Next
                        Next

                    End If


                    Consulta = "select hora , p.nombre from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.AddDays(-2).ToString("yyyy-MM-dd") + "';"
                    consultar()


                    dgvConsultaDia.DataSource = Tabla


                    If Not dgvConsultaDia.RowCount = 0 Then



                        Dim hora As TimeSpan
                        Dim nombre As String

                        For indice = 0 To dgvConsultaDia.RowCount - 1


                            hora = dgvConsultaDia.Rows(indice).Cells(0).Value
                            nombre = dgvConsultaDia.Rows(indice).Cells(1).Value

                            For IndHoras = 0 To 24


                                Dim posicion As TimeSpan

                                posicion = TimeSpan.Parse(dgvHora.Rows(IndHoras).Cells(0).Value)

                                If hora < posicion Then


                                    dgvHora.Rows(IndHoras - 1).Cells(4).Value = nombre
                                    Exit For
                                End If

                            Next
                        Next

                    End If


                    Consulta = "select hora , p.nombre from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.AddDays(-1).ToString("yyyy-MM-dd") + "';"
                    consultar()


                    dgvConsultaDia.DataSource = Tabla


                    If Not dgvConsultaDia.RowCount = 0 Then



                        Dim hora As TimeSpan
                        Dim nombre As String

                        For indice = 0 To dgvConsultaDia.RowCount - 1


                            hora = dgvConsultaDia.Rows(indice).Cells(0).Value
                            nombre = dgvConsultaDia.Rows(indice).Cells(1).Value

                            For IndHoras = 0 To 24


                                Dim posicion As TimeSpan

                                posicion = TimeSpan.Parse(dgvHora.Rows(IndHoras).Cells(0).Value)

                                If hora < posicion Then


                                    dgvHora.Rows(IndHoras - 1).Cells(5).Value = nombre
                                    Exit For
                                End If

                            Next
                        Next

                    End If

                    Consulta = "select hora , p.nombre from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.ToString("yyyy-MM-dd") + "';"
                    consultar()


                    dgvConsultaDia.DataSource = Tabla


                    If Not dgvConsultaDia.RowCount = 0 Then



                        Dim hora As TimeSpan
                        Dim nombre As String

                        For indice = 0 To dgvConsultaDia.RowCount - 1


                            hora = dgvConsultaDia.Rows(indice).Cells(0).Value
                            nombre = dgvConsultaDia.Rows(indice).Cells(1).Value

                            For IndHoras = 0 To 24


                                Dim posicion As TimeSpan

                                posicion = TimeSpan.Parse(dgvHora.Rows(IndHoras).Cells(0).Value)

                                If hora < posicion Then


                                    dgvHora.Rows(IndHoras - 1).Cells(6).Value = nombre
                                    Exit For
                                End If

                            Next
                        Next

                    End If
            End Select





        Catch ex As Exception
            MsgBox("Error al cargar citas", MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        frmContenedor = frmAgregarCita
        frmContenedor.MdiParent = Menu_Inicio
        frmContenedor.Dock = DockStyle.Fill
        frmContenedor.Show()
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Me.Hide()
        frmContenedor = frmMarcarCitaConcluida
        frmContenedor.MdiParent = Menu_Inicio
        frmContenedor.Dock = DockStyle.Fill
        frmContenedor.Show()

    End Sub


    Private Sub DataGridView1_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs)
        Button2.Visible = True
        'Aca le asigno el valor a idPaciente y de idCita cuando se hace click en la tabla
        'idcita = dgvLunes.CurrentRow.Cells(3).Value
        'Mira que id_p es una variable global que se usa en todo el programa, no es necesario crear otra xd
        'id_p = dgvLunes.CurrentRow.Cells(4).Value
    End Sub

  



    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub


    Private Sub dgvHora_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvHora.CellClick

        DiaSeleccionado = MCFecha.SelectionRange.Start
        FCalendario = Weekday(DiaSeleccionado)

        Select Case dgvHora.CurrentCell.ColumnIndex

            Case 1

                Select Case FCalendario

                    Case "1"
                        Consulta = "select hora , p.nombre from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.ToString("yyyy-MM-dd") + "';"
                        consultar()
                        dgvConsultaDia.DataSource = Tabla
                    Case "2"
                        Consulta = "select hora , p.nombre from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.AddDays(-1).ToString("yyyy-MM-dd") + "';"
                        consultar()
                        dgvConsultaDia.DataSource = Tabla
                    Case "3"
                        Consulta = "select hora , p.nombre from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.AddDays(-2).ToString("yyyy-MM-dd") + "';"
                        consultar()
                        dgvConsultaDia.DataSource = Tabla
                    Case "4"
                        Consulta = "select hora , p.nombre from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.AddDays(-3).ToString("yyyy-MM-dd") + "';"
                        consultar()
                        dgvConsultaDia.DataSource = Tabla
                    Case "5"
                        Consulta = "select hora , p.nombre from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.AddDays(-4).ToString("yyyy-MM-dd") + "';"
                        consultar()
                        dgvConsultaDia.DataSource = Tabla
                    Case "6"
                        Consulta = "select hora , p.nombre from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.AddDays(-5).ToString("yyyy-MM-dd") + "';"
                        consultar()
                        dgvConsultaDia.DataSource = Tabla
                End Select

            Case 2
                Select Case FCalendario

                    Case "1"
                        Consulta = "select hora , p.nombre from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.AddDays(1).ToString("yyyy-MM-dd") + "';"
                        consultar()
                        dgvConsultaDia.DataSource = Tabla
                    Case "2"
                        Consulta = "select hora , p.nombre from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.ToString("yyyy-MM-dd") + "';"
                        consultar()
                        dgvConsultaDia.DataSource = Tabla
                    Case "3"
                        Consulta = "select hora , p.nombre from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.AddDays(-1).ToString("yyyy-MM-dd") + "';"
                        consultar()
                        dgvConsultaDia.DataSource = Tabla
                    Case "4"
                        Consulta = "select hora , p.nombre from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.AddDays(-2).ToString("yyyy-MM-dd") + "';"
                        consultar()
                        dgvConsultaDia.DataSource = Tabla
                    Case "5"
                        Consulta = "select hora , p.nombre from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.AddDays(-3).ToString("yyyy-MM-dd") + "';"
                        consultar()
                        dgvConsultaDia.DataSource = Tabla
                    Case "6"
                        Consulta = "select hora , p.nombre from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.AddDays(-4).ToString("yyyy-MM-dd") + "';"
                        consultar()
                        dgvConsultaDia.DataSource = Tabla
                End Select

            Case 3
                Select Case FCalendario

                    Case "1"
                        Consulta = "select hora , p.nombre from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.AddDays(-2).ToString("yyyy-MM-dd") + "';"
                        consultar()
                        dgvConsultaDia.DataSource = Tabla
                    Case "2"
                        Consulta = "select hora , p.nombre from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.AddDays(-1).ToString("yyyy-MM-dd") + "';"
                        consultar()
                        dgvConsultaDia.DataSource = Tabla
                    Case "3"
                        Consulta = "select hora , p.nombre from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.ToString("yyyy-MM-dd") + "';"
                        consultar()
                        dgvConsultaDia.DataSource = Tabla
                    Case "4"
                        Consulta = "select hora , p.nombre from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.AddDays(1).ToString("yyyy-MM-dd") + "';"
                        consultar()
                        dgvConsultaDia.DataSource = Tabla
                    Case "5"
                        Consulta = "select hora , p.nombre from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.AddDays(2).ToString("yyyy-MM-dd") + "';"
                        consultar()
                        dgvConsultaDia.DataSource = Tabla
                    Case "6"
                        Consulta = "select hora , p.nombre from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.AddDays(3).ToString("yyyy-MM-dd") + "';"
                        consultar()
                        dgvConsultaDia.DataSource = Tabla
                End Select
            Case 4
                Select Case FCalendario

                    Case "1"
                        Consulta = "select hora , p.nombre from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.AddDays(-3).ToString("yyyy-MM-dd") + "';"
                        consultar()
                        dgvConsultaDia.DataSource = Tabla
                    Case "2"
                        Consulta = "select hora , p.nombre from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.AddDays(-2).ToString("yyyy-MM-dd") + "';"
                        consultar()
                        dgvConsultaDia.DataSource = Tabla
                    Case "3"
                        Consulta = "select hora , p.nombre from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.AddDays(-1).ToString("yyyy-MM-dd") + "';"
                        consultar()
                        dgvConsultaDia.DataSource = Tabla
                    Case "4"
                        Consulta = "select hora , p.nombre from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.ToString("yyyy-MM-dd") + "';"
                        consultar()
                        dgvConsultaDia.DataSource = Tabla
                    Case "5"
                        Consulta = "select hora , p.nombre from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.AddDays(1).ToString("yyyy-MM-dd") + "';"
                        consultar()
                        dgvConsultaDia.DataSource = Tabla
                    Case "6"
                        Consulta = "select hora , p.nombre from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.AddDays(2).ToString("yyyy-MM-dd") + "';"
                        consultar()
                        dgvConsultaDia.DataSource = Tabla
                End Select
            Case 5
                Select Case FCalendario

                    Case "1"
                        Consulta = "select hora , p.nombre from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.AddDays(-4).ToString("yyyy-MM-dd") + "';"
                        consultar()
                        dgvConsultaDia.DataSource = Tabla
                    Case "2"
                        Consulta = "select hora , p.nombre from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.AddDays(-3).ToString("yyyy-MM-dd") + "';"
                        consultar()
                        dgvConsultaDia.DataSource = Tabla
                    Case "3"
                        Consulta = "select hora , p.nombre from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.AddDays(-2).ToString("yyyy-MM-dd") + "';"
                        consultar()
                        dgvConsultaDia.DataSource = Tabla
                    Case "4"
                        Consulta = "select hora , p.nombre from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.AddDays(-1).ToString("yyyy-MM-dd") + "';"
                        consultar()
                        dgvConsultaDia.DataSource = Tabla
                    Case "5"
                        Consulta = "select hora , p.nombre from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.ToString("yyyy-MM-dd") + "';"
                        consultar()
                        dgvConsultaDia.DataSource = Tabla
                    Case "6"
                        Consulta = "select hora , p.nombre from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.AddDays(1).ToString("yyyy-MM-dd") + "';"
                        consultar()
                        dgvConsultaDia.DataSource = Tabla
                End Select
            Case 6
                Select Case FCalendario

                    Case "1"
                        Consulta = "select hora , p.nombre from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.AddDays(-5).ToString("yyyy-MM-dd") + "';"
                        consultar()
                        dgvConsultaDia.DataSource = Tabla
                    Case "2"
                        Consulta = "select hora , p.nombre from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.AddDays(-4).ToString("yyyy-MM-dd") + "';"
                        consultar()
                        dgvConsultaDia.DataSource = Tabla
                    Case "3"
                        Consulta = "select hora , p.nombre from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.AddDays(-3).ToString("yyyy-MM-dd") + "';"
                        consultar()
                        dgvConsultaDia.DataSource = Tabla
                    Case "4"
                        Consulta = "select hora , p.nombre from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.AddDays(-2).ToString("yyyy-MM-dd") + "';"
                        consultar()
                        dgvConsultaDia.DataSource = Tabla
                    Case "5"
                        Consulta = "select hora , p.nombre from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.AddDays(-1).ToString("yyyy-MM-dd") + "';"
                        consultar()
                        dgvConsultaDia.DataSource = Tabla
                    Case "6"
                        Consulta = "select hora , p.nombre from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.ToString("yyyy-MM-dd") + "';"
                        consultar()
                        dgvConsultaDia.DataSource = Tabla
                End Select


        End Select


    End Sub
End Class
