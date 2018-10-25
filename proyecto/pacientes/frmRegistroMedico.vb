

Public Class frmRegistroMedico
    Dim formu As New Form
    Dim i As Integer = 0
    'Create DataGridViewPrinter type variable  

    Private Sub Registro_Medico_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        dgvEstadoDiente.Hide()

        PnlDiente18c1.MakeTriangular(TriangleDirection.Down)
        PnlDiente18c3.MakeTriangular(TriangleDirection.Up)
        PnlDiente18c2.MakeTriangular(TriangleDirection.Left)
        PnlDiente18c4.MakeTriangular(TriangleDirection.Right)


        PnlDiente17c1.MakeTriangular(TriangleDirection.Down)
        PnlDiente17c3.MakeTriangular(TriangleDirection.Up)
        PnlDiente17c4.MakeTriangular(TriangleDirection.Right)
        PnlDiente17c2.MakeTriangular(TriangleDirection.Left)


        PnlDiente16c1.MakeTriangular(TriangleDirection.Down)
        PnlDiente16c3.MakeTriangular(TriangleDirection.Up)
        PnlDiente16c4.MakeTriangular(TriangleDirection.Right)
        PnlDiente16c2.MakeTriangular(TriangleDirection.Left)


        PnlDiente15c1.MakeTriangular(TriangleDirection.Down)
        PnlDiente15c3.MakeTriangular(TriangleDirection.Up)
        PnlDiente15c4.MakeTriangular(TriangleDirection.Right)
        PnlDiente15c2.MakeTriangular(TriangleDirection.Left)

        PnlDiente14c1.MakeTriangular(TriangleDirection.Down)
        PnlDiente14c3.MakeTriangular(TriangleDirection.Up)
        PnlDiente14c4.MakeTriangular(TriangleDirection.Right)
        PnlDiente14c2.MakeTriangular(TriangleDirection.Left)

        PnlDiente13c1.MakeTriangular(TriangleDirection.Down)
        PnlDiente13c3.MakeTriangular(TriangleDirection.Up)
        PnlDiente13c4.MakeTriangular(TriangleDirection.Right)
        PnlDiente13c2.MakeTriangular(TriangleDirection.Left)

        PnlDiente12c3.MakeTriangular(TriangleDirection.Up)
        PnlDiente12c4.MakeTriangular(TriangleDirection.Right)
        PnlDiente12c2.MakeTriangular(TriangleDirection.Left)
        PnlDiente12c1.MakeTriangular(TriangleDirection.Down)

        PnlDiente11c4.MakeTriangular(TriangleDirection.Right)
        PnlDiente11c3.MakeTriangular(TriangleDirection.Up)
        PnlDiente11c2.MakeTriangular(TriangleDirection.Left)
        PnlDiente11c1.MakeTriangular(TriangleDirection.Down)

        '--------------------------------------------------------
        PnlDiente28c1.MakeTriangular(TriangleDirection.Down)
        PnlDiente28c3.MakeTriangular(TriangleDirection.Up)
        PnlDiente28c2.MakeTriangular(TriangleDirection.Left)
        PnlDiente28c4.MakeTriangular(TriangleDirection.Right)


        PnlDiente27c1.MakeTriangular(TriangleDirection.Down)
        PnlDiente27c3.MakeTriangular(TriangleDirection.Up)
        PnlDiente27c4.MakeTriangular(TriangleDirection.Right)
        PnlDiente27c2.MakeTriangular(TriangleDirection.Left)


        PnlDiente26c1.MakeTriangular(TriangleDirection.Down)
        PnlDiente26c3.MakeTriangular(TriangleDirection.Up)
        PnlDiente26c4.MakeTriangular(TriangleDirection.Right)
        PnlDiente26c2.MakeTriangular(TriangleDirection.Left)


        PnlDiente25c1.MakeTriangular(TriangleDirection.Down)
        PnlDiente25c3.MakeTriangular(TriangleDirection.Up)
        PnlDiente25c4.MakeTriangular(TriangleDirection.Right)
        PnlDiente25c2.MakeTriangular(TriangleDirection.Left)

        PnlDiente24c1.MakeTriangular(TriangleDirection.Down)
        PnlDiente24c3.MakeTriangular(TriangleDirection.Up)
        PnlDiente24c4.MakeTriangular(TriangleDirection.Right)
        PnlDiente24c2.MakeTriangular(TriangleDirection.Left)

        PnlDiente23c1.MakeTriangular(TriangleDirection.Down)
        PnlDiente23c3.MakeTriangular(TriangleDirection.Up)
        PnlDiente23c4.MakeTriangular(TriangleDirection.Right)
        PnlDiente23c2.MakeTriangular(TriangleDirection.Left)

        PnlDiente22c3.MakeTriangular(TriangleDirection.Up)
        PnlDiente22c4.MakeTriangular(TriangleDirection.Right)
        PnlDiente22c2.MakeTriangular(TriangleDirection.Left)
        PnlDiente22c1.MakeTriangular(TriangleDirection.Down)

        PnlDiente21c4.MakeTriangular(TriangleDirection.Right)
        PnlDiente21c3.MakeTriangular(TriangleDirection.Up)
        PnlDiente21c2.MakeTriangular(TriangleDirection.Left)
        PnlDiente21c1.MakeTriangular(TriangleDirection.Down)

        '---------------------------------------------------------------------------
        pnlDiente38c1.MakeTriangular(TriangleDirection.Down)
        pnlDiente38c3.MakeTriangular(TriangleDirection.Up)
        pnlDiente38c2.MakeTriangular(TriangleDirection.Left)
        pnlDiente38c4.MakeTriangular(TriangleDirection.Right)


        pnlDiente37c1.MakeTriangular(TriangleDirection.Down)
        pnlDiente37c3.MakeTriangular(TriangleDirection.Up)
        pnlDiente37c4.MakeTriangular(TriangleDirection.Right)
        pnlDiente37c2.MakeTriangular(TriangleDirection.Left)


        pnlDiente36c1.MakeTriangular(TriangleDirection.Down)
        pnlDiente36c3.MakeTriangular(TriangleDirection.Up)
        pnlDiente36c4.MakeTriangular(TriangleDirection.Right)
        pnlDiente36c2.MakeTriangular(TriangleDirection.Left)


        pnlDiente35c1.MakeTriangular(TriangleDirection.Down)
        pnlDiente35c3.MakeTriangular(TriangleDirection.Up)
        pnlDiente35c4.MakeTriangular(TriangleDirection.Right)
        pnlDiente35c2.MakeTriangular(TriangleDirection.Left)

        pnlDiente34c1.MakeTriangular(TriangleDirection.Down)
        pnlDiente34c3.MakeTriangular(TriangleDirection.Up)
        pnlDiente34c4.MakeTriangular(TriangleDirection.Right)
        pnlDiente34c2.MakeTriangular(TriangleDirection.Left)

        pnlDiente33c1.MakeTriangular(TriangleDirection.Down)
        pnlDiente33c3.MakeTriangular(TriangleDirection.Up)
        pnlDiente33c4.MakeTriangular(TriangleDirection.Right)
        pnlDiente33c2.MakeTriangular(TriangleDirection.Left)

        pnlDiente32c3.MakeTriangular(TriangleDirection.Up)
        pnlDiente32c4.MakeTriangular(TriangleDirection.Right)
        pnlDiente32c2.MakeTriangular(TriangleDirection.Left)
        pnlDiente32c1.MakeTriangular(TriangleDirection.Down)

        pnlDiente31c4.MakeTriangular(TriangleDirection.Right)
        pnlDiente31c3.MakeTriangular(TriangleDirection.Up)
        pnlDiente31c2.MakeTriangular(TriangleDirection.Left)
        pnlDiente31c1.MakeTriangular(TriangleDirection.Down)
        '-----------------------------------------------------------------------
        PnlDiente48c1.MakeTriangular(TriangleDirection.Down)
        PnlDiente48c3.MakeTriangular(TriangleDirection.Up)
        PnlDiente48c2.MakeTriangular(TriangleDirection.Left)
        PnlDiente48c4.MakeTriangular(TriangleDirection.Right)


        PnlDiente47c1.MakeTriangular(TriangleDirection.Down)
        PnlDiente47c3.MakeTriangular(TriangleDirection.Up)
        PnlDiente47c4.MakeTriangular(TriangleDirection.Right)
        PnlDiente47c2.MakeTriangular(TriangleDirection.Left)


        PnlDiente46c1.MakeTriangular(TriangleDirection.Down)
        PnlDiente46c3.MakeTriangular(TriangleDirection.Up)
        PnlDiente46c4.MakeTriangular(TriangleDirection.Right)
        PnlDiente46c2.MakeTriangular(TriangleDirection.Left)


        PnlDiente45c1.MakeTriangular(TriangleDirection.Down)
        PnlDiente45c3.MakeTriangular(TriangleDirection.Up)
        PnlDiente45c4.MakeTriangular(TriangleDirection.Right)
        PnlDiente45c2.MakeTriangular(TriangleDirection.Left)

        PnlDiente44c1.MakeTriangular(TriangleDirection.Down)
        PnlDiente44c3.MakeTriangular(TriangleDirection.Up)
        PnlDiente44c4.MakeTriangular(TriangleDirection.Right)
        PnlDiente44c2.MakeTriangular(TriangleDirection.Left)

        PnlDiente43c1.MakeTriangular(TriangleDirection.Down)
        PnlDiente43c3.MakeTriangular(TriangleDirection.Up)
        PnlDiente43c4.MakeTriangular(TriangleDirection.Right)
        PnlDiente43c2.MakeTriangular(TriangleDirection.Left)

        PnlDiente42c3.MakeTriangular(TriangleDirection.Up)
        PnlDiente42c4.MakeTriangular(TriangleDirection.Right)
        PnlDiente42c2.MakeTriangular(TriangleDirection.Left)
        PnlDiente42c1.MakeTriangular(TriangleDirection.Down)

        PnlDiente41c4.MakeTriangular(TriangleDirection.Right)
        PnlDiente41c3.MakeTriangular(TriangleDirection.Up)
        PnlDiente41c2.MakeTriangular(TriangleDirection.Left)
        PnlDiente41c1.MakeTriangular(TriangleDirection.Down)

        '=========================================================================================
        PnlDiente2_18c1.MakeTriangular(TriangleDirection.Down)
        PnlDiente2_18c3.MakeTriangular(TriangleDirection.Up)
        PnlDiente2_18c2.MakeTriangular(TriangleDirection.Left)
        PnlDiente2_18c4.MakeTriangular(TriangleDirection.Right)


        PnlDiente2_17c1.MakeTriangular(TriangleDirection.Down)
        PnlDiente2_17c3.MakeTriangular(TriangleDirection.Up)
        PnlDiente2_17c4.MakeTriangular(TriangleDirection.Right)
        PnlDiente2_17c2.MakeTriangular(TriangleDirection.Left)


        PnlDiente2_16c1.MakeTriangular(TriangleDirection.Down)
        PnlDiente2_16c3.MakeTriangular(TriangleDirection.Up)
        PnlDiente2_16c4.MakeTriangular(TriangleDirection.Right)
        PnlDiente2_16c2.MakeTriangular(TriangleDirection.Left)


        PnlDiente2_15c1.MakeTriangular(TriangleDirection.Down)
        PnlDiente2_15c3.MakeTriangular(TriangleDirection.Up)
        PnlDiente2_15c4.MakeTriangular(TriangleDirection.Right)
        PnlDiente2_15c2.MakeTriangular(TriangleDirection.Left)

        PnlDiente2_14c1.MakeTriangular(TriangleDirection.Down)
        PnlDiente2_14c3.MakeTriangular(TriangleDirection.Up)
        PnlDiente2_14c4.MakeTriangular(TriangleDirection.Right)
        PnlDiente2_14c2.MakeTriangular(TriangleDirection.Left)

        PnlDiente2_13c1.MakeTriangular(TriangleDirection.Down)
        PnlDiente2_13c3.MakeTriangular(TriangleDirection.Up)
        PnlDiente2_13c4.MakeTriangular(TriangleDirection.Right)
        PnlDiente2_13c2.MakeTriangular(TriangleDirection.Left)

        PnlDiente2_12c3.MakeTriangular(TriangleDirection.Up)
        PnlDiente2_12c4.MakeTriangular(TriangleDirection.Right)
        PnlDiente2_12c2.MakeTriangular(TriangleDirection.Left)
        PnlDiente2_12c1.MakeTriangular(TriangleDirection.Down)

        PnlDiente2_11c4.MakeTriangular(TriangleDirection.Right)
        PnlDiente2_11c3.MakeTriangular(TriangleDirection.Up)
        PnlDiente2_11c2.MakeTriangular(TriangleDirection.Left)
        PnlDiente2_11c1.MakeTriangular(TriangleDirection.Down)

        '--------------------------------------------------------
        PnlDiente2_28c1.MakeTriangular(TriangleDirection.Down)
        PnlDiente2_28c3.MakeTriangular(TriangleDirection.Up)
        PnlDiente2_28c2.MakeTriangular(TriangleDirection.Left)
        PnlDiente2_28c4.MakeTriangular(TriangleDirection.Right)


        PnlDiente2_27c1.MakeTriangular(TriangleDirection.Down)
        PnlDiente2_27c3.MakeTriangular(TriangleDirection.Up)
        PnlDiente2_27c4.MakeTriangular(TriangleDirection.Right)
        PnlDiente2_27c2.MakeTriangular(TriangleDirection.Left)


        PnlDiente2_26c1.MakeTriangular(TriangleDirection.Down)
        PnlDiente2_26c3.MakeTriangular(TriangleDirection.Up)
        PnlDiente2_26c4.MakeTriangular(TriangleDirection.Right)
        PnlDiente2_26c2.MakeTriangular(TriangleDirection.Left)


        PnlDiente2_25c1.MakeTriangular(TriangleDirection.Down)
        PnlDiente2_25c3.MakeTriangular(TriangleDirection.Up)
        PnlDiente2_25c4.MakeTriangular(TriangleDirection.Right)
        PnlDiente2_25c2.MakeTriangular(TriangleDirection.Left)

        PnlDiente2_24c1.MakeTriangular(TriangleDirection.Down)
        PnlDiente2_24c3.MakeTriangular(TriangleDirection.Up)
        PnlDiente2_24c4.MakeTriangular(TriangleDirection.Right)
        PnlDiente2_24c2.MakeTriangular(TriangleDirection.Left)

        PnlDiente2_23c1.MakeTriangular(TriangleDirection.Down)
        PnlDiente2_23c3.MakeTriangular(TriangleDirection.Up)
        PnlDiente2_23c4.MakeTriangular(TriangleDirection.Right)
        PnlDiente2_23c2.MakeTriangular(TriangleDirection.Left)

        PnlDiente2_22c3.MakeTriangular(TriangleDirection.Up)
        PnlDiente2_22c4.MakeTriangular(TriangleDirection.Right)
        PnlDiente2_22c2.MakeTriangular(TriangleDirection.Left)
        PnlDiente2_22c1.MakeTriangular(TriangleDirection.Down)

        PnlDiente2_21c4.MakeTriangular(TriangleDirection.Right)
        PnlDiente2_21c3.MakeTriangular(TriangleDirection.Up)
        PnlDiente2_21c2.MakeTriangular(TriangleDirection.Left)
        PnlDiente2_21c1.MakeTriangular(TriangleDirection.Down)

        '---------------------------------------------------------------------------
        PnlDiente2_38c1.MakeTriangular(TriangleDirection.Down)
        PnlDiente2_38c3.MakeTriangular(TriangleDirection.Up)
        PnlDiente2_38c2.MakeTriangular(TriangleDirection.Left)
        PnlDiente2_38c4.MakeTriangular(TriangleDirection.Right)


        PnlDiente2_37c1.MakeTriangular(TriangleDirection.Down)
        PnlDiente2_37c3.MakeTriangular(TriangleDirection.Up)
        PnlDiente2_37c4.MakeTriangular(TriangleDirection.Right)
        PnlDiente2_37c2.MakeTriangular(TriangleDirection.Left)


        PnlDiente2_36c1.MakeTriangular(TriangleDirection.Down)
        PnlDiente2_36c3.MakeTriangular(TriangleDirection.Up)
        PnlDiente2_36c4.MakeTriangular(TriangleDirection.Right)
        PnlDiente2_36c2.MakeTriangular(TriangleDirection.Left)


        PnlDiente2_35c1.MakeTriangular(TriangleDirection.Down)
        PnlDiente2_35c3.MakeTriangular(TriangleDirection.Up)
        PnlDiente2_35c4.MakeTriangular(TriangleDirection.Right)
        PnlDiente2_35c2.MakeTriangular(TriangleDirection.Left)

        PnlDiente2_34c1.MakeTriangular(TriangleDirection.Down)
        PnlDiente2_34c3.MakeTriangular(TriangleDirection.Up)
        PnlDiente2_34c4.MakeTriangular(TriangleDirection.Right)
        PnlDiente2_34c2.MakeTriangular(TriangleDirection.Left)

        PnlDiente2_33c1.MakeTriangular(TriangleDirection.Down)
        PnlDiente2_33c3.MakeTriangular(TriangleDirection.Up)
        PnlDiente2_33c4.MakeTriangular(TriangleDirection.Right)
        PnlDiente2_33c2.MakeTriangular(TriangleDirection.Left)

        pnlDiente2_32c3.MakeTriangular(TriangleDirection.Up)
        PnlDiente2_32c4.MakeTriangular(TriangleDirection.Right)
        PnlDiente2_32c2.MakeTriangular(TriangleDirection.Left)
        PnlDiente2_32c1.MakeTriangular(TriangleDirection.Down)

        PnlDiente2_31c4.MakeTriangular(TriangleDirection.Right)
        PnlDiente2_31c3.MakeTriangular(TriangleDirection.Up)
        PnlDiente2_31c2.MakeTriangular(TriangleDirection.Left)
        PnlDiente2_31c1.MakeTriangular(TriangleDirection.Down)
        '-----------------------------------------------------------------------
        PnlDiente2_48c1.MakeTriangular(TriangleDirection.Down)
        PnlDiente2_48c3.MakeTriangular(TriangleDirection.Up)
        PnlDiente2_48c2.MakeTriangular(TriangleDirection.Left)
        PnlDiente2_48c4.MakeTriangular(TriangleDirection.Right)


        PnlDiente2_47c1.MakeTriangular(TriangleDirection.Down)
        PnlDiente2_47c3.MakeTriangular(TriangleDirection.Up)
        PnlDiente2_47c4.MakeTriangular(TriangleDirection.Right)
        PnlDiente2_47c2.MakeTriangular(TriangleDirection.Left)


        PnlDiente2_46c1.MakeTriangular(TriangleDirection.Down)
        PnlDiente2_46c3.MakeTriangular(TriangleDirection.Up)
        PnlDiente2_46c4.MakeTriangular(TriangleDirection.Right)
        PnlDiente2_46c2.MakeTriangular(TriangleDirection.Left)


        PnlDiente2_45c1.MakeTriangular(TriangleDirection.Down)
        PnlDiente2_45c3.MakeTriangular(TriangleDirection.Up)
        PnlDiente2_45c4.MakeTriangular(TriangleDirection.Right)
        PnlDiente2_45c2.MakeTriangular(TriangleDirection.Left)

        PnlDiente2_44c1.MakeTriangular(TriangleDirection.Down)
        PnlDiente2_44c3.MakeTriangular(TriangleDirection.Up)
        PnlDiente2_44c4.MakeTriangular(TriangleDirection.Right)
        PnlDiente2_44c2.MakeTriangular(TriangleDirection.Left)

        PnlDiente2_43c1.MakeTriangular(TriangleDirection.Down)
        PnlDiente2_43c3.MakeTriangular(TriangleDirection.Up)
        PnlDiente2_43c4.MakeTriangular(TriangleDirection.Right)
        PnlDiente2_43c2.MakeTriangular(TriangleDirection.Left)

        PnlDiente2_42c3.MakeTriangular(TriangleDirection.Up)
        PnlDiente2_42c4.MakeTriangular(TriangleDirection.Right)
        PnlDiente2_42c2.MakeTriangular(TriangleDirection.Left)
        PnlDiente2_42c1.MakeTriangular(TriangleDirection.Down)

        PnlDiente2_41c4.MakeTriangular(TriangleDirection.Right)
        PnlDiente2_41c3.MakeTriangular(TriangleDirection.Up)
        PnlDiente2_41c2.MakeTriangular(TriangleDirection.Left)
        PnlDiente2_41c1.MakeTriangular(TriangleDirection.Down)



        odontograma1()
        odontograma2()

        cbTratamientos.SelectedIndex = 0
    End Sub

    
    Private Sub odontograma2()
        Try
            cambiarUsuario("root", "")
            Consulta = "select * from estado_dientes where id_p = '" + id_p.ToString + "'   order by fecha asc;"
            consultar()
            dgvEstadoDiente.DataSource = Tabla

            
            Dim zona As String = ""


            For x As Integer = 0 To dgvEstadoDiente.RowCount - 1


                Select Case dgvEstadoDiente.Rows(x).Cells(3).Value

                    Case "arriba-izquierda"
                        zona = "1"
                    Case "arriba-derecha"
                        zona = "2"
                    Case "abajo-derecha"
                        zona = "3"
                    Case "abajo-izquierda"
                        zona = "4"

                End Select

                zona += dgvEstadoDiente.Rows(x).Cells(4).Value.ToString

                zona += dgvEstadoDiente.Rows(x).Cells(5).Value.ToString



                Select Case zona
                    Case "111"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente2_11c1.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente2_11c1.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente2_11c1.BackColor = Color.Black
                            Case Else
                                PnlDiente2_11c1.BackColor = Color.White
                        End Select
                    Case "112"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente2_11c2.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente2_11c2.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente2_11c2.BackColor = Color.Black
                            Case Else
                                PnlDiente2_11c2.BackColor = Color.White

                        End Select
                    Case "113"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente2_11c3.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente2_11c3.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente2_11c3.BackColor = Color.Black
                            Case Else
                                PnlDiente2_11c3.BackColor = Color.White
                        End Select

                    Case "114"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente2_11c4.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente2_11c4.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente2_11c4.BackColor = Color.Black
                            Case Else
                                PnlDiente2_11c4.BackColor = Color.White
                        End Select

                    Case "121"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente2_12c1.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente2_12c1.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente2_12c1.BackColor = Color.Black
                            Case Else
                                PnlDiente2_12c1.BackColor = Color.White
                        End Select

                    Case "122"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente2_12c2.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente2_12c2.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente2_12c2.BackColor = Color.Black
                            Case Else
                                PnlDiente2_12c2.BackColor = Color.White
                        End Select


                    Case "123"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente2_12c3.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente2_12c3.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente2_12c3.BackColor = Color.Black
                            Case Else
                                PnlDiente2_12c3.BackColor = Color.White
                        End Select

                    Case "124"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente2_12c4.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente2_12c4.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente2_12c4.BackColor = Color.Black
                            Case Else
                                PnlDiente2_12c4.BackColor = Color.White
                        End Select


                    Case "131"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente2_13c1.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente2_13c1.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente2_13c1.BackColor = Color.Black
                            Case Else
                                PnlDiente2_13c1.BackColor = Color.White
                        End Select

                    Case "132"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente2_13c2.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente2_13c2.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente2_13c2.BackColor = Color.Black
                            Case Else
                                PnlDiente2_13c2.BackColor = Color.White
                        End Select

                    Case "133"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente2_13c3.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente2_13c3.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente2_13c3.BackColor = Color.Black
                            Case Else
                                PnlDiente2_13c3.BackColor = Color.White
                        End Select

                    Case "134"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente2_13c4.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente2_13c4.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente2_13c4.BackColor = Color.Black
                            Case Else
                                PnlDiente2_13c4.BackColor = Color.White
                        End Select

                    Case "141"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente2_14c1.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente2_14c1.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente2_14c1.BackColor = Color.Black
                            Case Else
                                PnlDiente2_14c1.BackColor = Color.White
                        End Select

                    Case "142"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente2_14c2.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente2_14c2.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente2_14c2.BackColor = Color.Black
                            Case Else
                                PnlDiente2_14c2.BackColor = Color.White
                        End Select

                    Case "143"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente2_14c3.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente2_14c3.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente2_14c3.BackColor = Color.Black
                            Case Else
                                PnlDiente2_14c3.BackColor = Color.White
                        End Select

                    Case "144"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente2_14c4.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente2_14c4.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente2_14c4.BackColor = Color.Black
                            Case Else
                                PnlDiente2_14c4.BackColor = Color.White
                        End Select

                    Case "151"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente2_15c1.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente2_15c1.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente2_15c1.BackColor = Color.Black
                            Case Else
                                PnlDiente2_15c1.BackColor = Color.White
                        End Select


                    Case "152"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente2_15c2.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente2_15c2.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente2_15c2.BackColor = Color.Black
                            Case Else
                                PnlDiente2_15c2.BackColor = Color.White
                        End Select

                    Case "153"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente2_15c3.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente2_15c3.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente2_15c3.BackColor = Color.Black
                            Case Else
                                PnlDiente2_15c3.BackColor = Color.White
                        End Select

                    Case "154"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente2_15c4.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente2_15c4.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente2_15c4.BackColor = Color.Black
                            Case Else
                                PnlDiente2_15c4.BackColor = Color.White
                        End Select

                    Case "161"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente2_16c1.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente2_16c1.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente2_16c1.BackColor = Color.Black
                            Case Else
                                PnlDiente2_16c1.BackColor = Color.White
                        End Select

                    Case "162"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente2_16c2.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente2_16c2.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente2_16c2.BackColor = Color.Black
                            Case Else
                                PnlDiente2_16c2.BackColor = Color.White
                        End Select

                    Case "163"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente2_16c3.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente2_16c3.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente2_16c3.BackColor = Color.Black
                            Case Else
                                PnlDiente2_16c3.BackColor = Color.White
                        End Select

                    Case "164"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente2_16c4.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente2_16c4.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente2_16c4.BackColor = Color.Black
                            Case Else
                                PnlDiente2_16c4.BackColor = Color.White
                        End Select

                    Case "171"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente2_17c1.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente2_17c1.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente2_17c1.BackColor = Color.Black
                            Case Else
                                PnlDiente2_17c1.BackColor = Color.White
                        End Select


                    Case "172"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente2_17c2.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente2_17c2.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente2_17c2.BackColor = Color.Black
                            Case Else
                                PnlDiente2_17c2.BackColor = Color.White
                        End Select


                    Case "173"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente2_17c3.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente2_17c3.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente2_17c3.BackColor = Color.Black
                            Case Else
                                PnlDiente2_17c3.BackColor = Color.White
                        End Select

                    Case "174"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente2_17c4.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente2_17c4.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente2_17c4.BackColor = Color.Black
                            Case Else
                                PnlDiente2_17c4.BackColor = Color.White
                        End Select

                    Case "181"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente2_18c1.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente2_18c1.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente2_18c1.BackColor = Color.Black
                            Case Else
                                PnlDiente2_18c1.BackColor = Color.White
                        End Select

                    Case "182"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente2_18c2.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente2_18c2.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente2_18c2.BackColor = Color.Black
                            Case Else
                                PnlDiente2_18c2.BackColor = Color.White
                        End Select


                    Case "183"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente2_18c3.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente2_18c3.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente2_18c3.BackColor = Color.Black
                            Case Else
                                PnlDiente2_18c3.BackColor = Color.White
                        End Select

                    Case "184"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente2_18c4.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente2_18c4.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente2_18c4.BackColor = Color.Black
                            Case Else
                                PnlDiente2_18c4.BackColor = Color.White
                        End Select
                End Select
                '////////////////////////////////////////////////////
                Select Case zona
                    Case "211"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente2_21c1.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente2_21c1.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente2_21c1.BackColor = Color.Black
                            Case Else
                                PnlDiente2_21c1.BackColor = Color.White
                        End Select
                    Case "212"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente2_21c2.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente2_21c2.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente2_21c2.BackColor = Color.Black
                            Case Else
                                PnlDiente2_21c2.BackColor = Color.White

                        End Select
                    Case "213"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente2_21c3.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente2_21c3.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente2_21c3.BackColor = Color.Black
                            Case Else
                                PnlDiente2_21c3.BackColor = Color.White
                        End Select

                    Case "214"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente2_21c4.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente2_21c4.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente2_21c4.BackColor = Color.Black
                            Case Else
                                PnlDiente2_21c4.BackColor = Color.White
                        End Select

                    Case "221"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente2_22c1.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente2_22c1.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente2_22c1.BackColor = Color.Black
                            Case Else
                                PnlDiente2_22c1.BackColor = Color.White
                        End Select

                    Case "222"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente2_22c2.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente2_22c2.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente2_22c2.BackColor = Color.Black
                            Case Else
                                PnlDiente2_22c2.BackColor = Color.White
                        End Select


                    Case "223"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente2_22c3.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente2_22c3.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente2_22c3.BackColor = Color.Black
                            Case Else
                                PnlDiente2_22c3.BackColor = Color.White
                        End Select

                    Case "224"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente2_22c4.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente2_22c4.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente2_22c4.BackColor = Color.Black
                            Case Else
                                PnlDiente2_22c4.BackColor = Color.White
                        End Select


                    Case "231"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente2_23c1.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente2_23c1.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente2_23c1.BackColor = Color.Black
                            Case Else
                                PnlDiente2_23c1.BackColor = Color.White
                        End Select

                    Case "232"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente2_23c2.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente2_23c2.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente2_23c2.BackColor = Color.Black
                            Case Else
                                PnlDiente2_23c2.BackColor = Color.White
                        End Select

                    Case "233"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente2_23c3.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente2_23c3.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente2_23c3.BackColor = Color.Black
                            Case Else
                                PnlDiente2_23c3.BackColor = Color.White
                        End Select

                    Case "234"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente2_23c4.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente2_23c4.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente2_23c4.BackColor = Color.Black
                            Case Else
                                PnlDiente2_23c4.BackColor = Color.White
                        End Select

                    Case "241"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente2_24c1.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente2_24c1.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente2_24c1.BackColor = Color.Black
                            Case Else
                                PnlDiente2_24c1.BackColor = Color.White
                        End Select

                    Case "242"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente2_24c2.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente2_24c2.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente2_24c2.BackColor = Color.Black
                            Case Else
                                PnlDiente2_24c2.BackColor = Color.White
                        End Select

                    Case "243"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente2_24c3.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente2_24c3.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente2_24c3.BackColor = Color.Black
                            Case Else
                                PnlDiente2_24c3.BackColor = Color.White
                        End Select

                    Case "244"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente2_24c4.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente2_24c4.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente2_24c4.BackColor = Color.Black
                            Case Else
                                PnlDiente2_24c4.BackColor = Color.White
                        End Select

                    Case "251"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente2_25c1.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente2_25c1.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente2_25c1.BackColor = Color.Black
                            Case Else
                                PnlDiente2_25c1.BackColor = Color.White
                        End Select


                    Case "252"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente2_25c2.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente2_25c2.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente2_25c2.BackColor = Color.Black
                            Case Else
                                PnlDiente2_25c2.BackColor = Color.White
                        End Select

                    Case "253"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente2_25c3.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente2_25c3.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente2_25c3.BackColor = Color.Black
                            Case Else
                                PnlDiente2_25c3.BackColor = Color.White
                        End Select

                    Case "254"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente2_25c4.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente2_25c4.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente2_25c4.BackColor = Color.Black
                            Case Else
                                PnlDiente2_25c4.BackColor = Color.White
                        End Select

                    Case "261"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente2_26c1.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente2_26c1.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente2_26c1.BackColor = Color.Black
                            Case Else
                                PnlDiente2_26c1.BackColor = Color.White
                        End Select

                    Case "262"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente2_26c2.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente2_26c2.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente2_26c2.BackColor = Color.Black
                            Case Else
                                PnlDiente2_26c2.BackColor = Color.White
                        End Select

                    Case "263"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente2_26c3.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente2_26c3.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente2_26c3.BackColor = Color.Black
                            Case Else
                                PnlDiente2_26c3.BackColor = Color.White
                        End Select

                    Case "264"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente2_26c4.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente2_26c4.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente2_26c4.BackColor = Color.Black
                            Case Else
                                PnlDiente2_26c4.BackColor = Color.White
                        End Select

                    Case "271"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente2_27c1.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente2_27c1.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente2_27c1.BackColor = Color.Black
                            Case Else
                                PnlDiente2_27c1.BackColor = Color.White
                        End Select


                    Case "272"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente2_27c2.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente2_27c2.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente2_27c2.BackColor = Color.Black
                            Case Else
                                PnlDiente2_27c2.BackColor = Color.White
                        End Select


                    Case "273"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente2_27c3.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente2_27c3.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente2_27c3.BackColor = Color.Black
                            Case Else
                                PnlDiente2_27c3.BackColor = Color.White
                        End Select

                    Case "274"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente2_27c4.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente2_27c4.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente2_27c4.BackColor = Color.Black
                            Case Else
                                PnlDiente2_27c4.BackColor = Color.White
                        End Select

                    Case "281"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente2_28c1.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente2_28c1.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente2_28c1.BackColor = Color.Black
                            Case Else
                                PnlDiente2_28c1.BackColor = Color.White
                        End Select

                    Case "282"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente2_28c2.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente2_28c2.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente2_28c2.BackColor = Color.Black
                            Case Else
                                PnlDiente2_28c2.BackColor = Color.White
                        End Select


                    Case "283"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente2_28c3.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente2_28c3.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente2_28c3.BackColor = Color.Black
                            Case Else
                                PnlDiente2_28c3.BackColor = Color.White
                        End Select

                    Case "284"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente2_28c4.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente2_28c4.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente2_28c4.BackColor = Color.Black
                            Case Else
                                PnlDiente2_28c4.BackColor = Color.White
                        End Select
                End Select

                '/////////////////////////////////////////////////////////////
                Select Case zona
                    Case "311"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                pnlDiente2_31c1.BackColor = Color.Red
                            Case "precaucion"
                                pnlDiente2_31c1.BackColor = Color.Yellow
                            Case "ausente"
                                pnlDiente2_31c1.BackColor = Color.Black
                            Case Else
                                pnlDiente2_31c1.BackColor = Color.White
                        End Select
                    Case "312"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                pnlDiente2_31c2.BackColor = Color.Red
                            Case "precaucion"
                                pnlDiente2_31c2.BackColor = Color.Yellow
                            Case "ausente"
                                pnlDiente2_31c2.BackColor = Color.Black
                            Case Else
                                pnlDiente2_31c2.BackColor = Color.White

                        End Select
                    Case "313"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                pnlDiente2_31c3.BackColor = Color.Red
                            Case "precaucion"
                                pnlDiente2_31c3.BackColor = Color.Yellow
                            Case "ausente"
                                pnlDiente2_31c3.BackColor = Color.Black
                            Case Else
                                pnlDiente2_31c3.BackColor = Color.White
                        End Select

                    Case "314"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                pnlDiente2_31c4.BackColor = Color.Red
                            Case "precaucion"
                                pnlDiente2_31c4.BackColor = Color.Yellow
                            Case "ausente"
                                pnlDiente2_31c4.BackColor = Color.Black
                            Case Else
                                pnlDiente2_31c4.BackColor = Color.White
                        End Select

                    Case "321"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                pnlDiente2_32c1.BackColor = Color.Red
                            Case "precaucion"
                                pnlDiente2_32c1.BackColor = Color.Yellow
                            Case "ausente"
                                pnlDiente2_32c1.BackColor = Color.Black
                            Case Else
                                pnlDiente2_32c1.BackColor = Color.White
                        End Select

                    Case "322"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                pnlDiente2_32c2.BackColor = Color.Red
                            Case "precaucion"
                                pnlDiente2_32c2.BackColor = Color.Yellow
                            Case "ausente"
                                pnlDiente2_32c2.BackColor = Color.Black
                            Case Else
                                pnlDiente2_32c2.BackColor = Color.White
                        End Select


                    Case "323"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                pnlDiente2_32c3.BackColor = Color.Red
                            Case "precaucion"
                                pnlDiente2_32c3.BackColor = Color.Yellow
                            Case "ausente"
                                pnlDiente2_32c3.BackColor = Color.Black
                            Case Else
                                pnlDiente2_32c3.BackColor = Color.White
                        End Select

                    Case "324"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                pnlDiente2_32c4.BackColor = Color.Red
                            Case "precaucion"
                                pnlDiente2_32c4.BackColor = Color.Yellow
                            Case "ausente"
                                pnlDiente2_32c4.BackColor = Color.Black
                            Case Else
                                pnlDiente2_32c4.BackColor = Color.White
                        End Select


                    Case "331"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                pnlDiente2_33c1.BackColor = Color.Red
                            Case "precaucion"
                                pnlDiente2_33c1.BackColor = Color.Yellow
                            Case "ausente"
                                pnlDiente2_33c1.BackColor = Color.Black
                            Case Else
                                pnlDiente2_33c1.BackColor = Color.White
                        End Select

                    Case "332"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                pnlDiente2_33c2.BackColor = Color.Red
                            Case "precaucion"
                                pnlDiente2_33c2.BackColor = Color.Yellow
                            Case "ausente"
                                pnlDiente2_33c2.BackColor = Color.Black
                            Case Else
                                pnlDiente2_33c2.BackColor = Color.White
                        End Select

                    Case "333"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                pnlDiente2_33c3.BackColor = Color.Red
                            Case "precaucion"
                                pnlDiente2_33c3.BackColor = Color.Yellow
                            Case "ausente"
                                pnlDiente2_33c3.BackColor = Color.Black
                            Case Else
                                pnlDiente2_33c3.BackColor = Color.White
                        End Select

                    Case "334"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                pnlDiente2_33c4.BackColor = Color.Red
                            Case "precaucion"
                                pnlDiente2_33c4.BackColor = Color.Yellow
                            Case "ausente"
                                pnlDiente2_33c4.BackColor = Color.Black
                            Case Else
                                pnlDiente2_33c4.BackColor = Color.White
                        End Select

                    Case "341"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                pnlDiente2_34c1.BackColor = Color.Red
                            Case "precaucion"
                                pnlDiente2_34c1.BackColor = Color.Yellow
                            Case "ausente"
                                pnlDiente2_34c1.BackColor = Color.Black
                            Case Else
                                pnlDiente2_34c1.BackColor = Color.White
                        End Select

                    Case "342"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                pnlDiente2_34c2.BackColor = Color.Red
                            Case "precaucion"
                                pnlDiente2_34c2.BackColor = Color.Yellow
                            Case "ausente"
                                pnlDiente2_34c2.BackColor = Color.Black
                            Case Else
                                pnlDiente2_34c2.BackColor = Color.White
                        End Select

                    Case "343"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                pnlDiente2_34c3.BackColor = Color.Red
                            Case "precaucion"
                                pnlDiente2_34c3.BackColor = Color.Yellow
                            Case "ausente"
                                pnlDiente2_34c3.BackColor = Color.Black
                            Case Else
                                pnlDiente2_34c3.BackColor = Color.White
                        End Select

                    Case "344"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                pnlDiente2_34c4.BackColor = Color.Red
                            Case "precaucion"
                                pnlDiente2_34c4.BackColor = Color.Yellow
                            Case "ausente"
                                pnlDiente2_34c4.BackColor = Color.Black
                            Case Else
                                pnlDiente2_34c4.BackColor = Color.White
                        End Select

                    Case "351"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                pnlDiente2_35c1.BackColor = Color.Red
                            Case "precaucion"
                                pnlDiente2_35c1.BackColor = Color.Yellow
                            Case "ausente"
                                pnlDiente2_35c1.BackColor = Color.Black
                            Case Else
                                pnlDiente2_35c1.BackColor = Color.White
                        End Select


                    Case "352"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                pnlDiente2_35c2.BackColor = Color.Red
                            Case "precaucion"
                                pnlDiente2_35c2.BackColor = Color.Yellow
                            Case "ausente"
                                pnlDiente2_35c2.BackColor = Color.Black
                            Case Else
                                pnlDiente2_35c2.BackColor = Color.White
                        End Select

                    Case "353"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                pnlDiente2_35c3.BackColor = Color.Red
                            Case "precaucion"
                                pnlDiente2_35c3.BackColor = Color.Yellow
                            Case "ausente"
                                pnlDiente2_35c3.BackColor = Color.Black
                            Case Else
                                pnlDiente2_35c3.BackColor = Color.White
                        End Select

                    Case "354"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                pnlDiente2_35c4.BackColor = Color.Red
                            Case "precaucion"
                                pnlDiente2_35c4.BackColor = Color.Yellow
                            Case "ausente"
                                pnlDiente2_35c4.BackColor = Color.Black
                            Case Else
                                pnlDiente2_35c4.BackColor = Color.White
                        End Select

                    Case "361"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                pnlDiente2_36c1.BackColor = Color.Red
                            Case "precaucion"
                                pnlDiente2_36c1.BackColor = Color.Yellow
                            Case "ausente"
                                pnlDiente2_36c1.BackColor = Color.Black
                            Case Else
                                pnlDiente2_36c1.BackColor = Color.White
                        End Select

                    Case "362"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                pnlDiente2_36c2.BackColor = Color.Red
                            Case "precaucion"
                                pnlDiente2_36c2.BackColor = Color.Yellow
                            Case "ausente"
                                pnlDiente2_36c2.BackColor = Color.Black
                            Case Else
                                pnlDiente2_36c2.BackColor = Color.White
                        End Select

                    Case "363"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                pnlDiente2_36c3.BackColor = Color.Red
                            Case "precaucion"
                                pnlDiente2_36c3.BackColor = Color.Yellow
                            Case "ausente"
                                pnlDiente2_36c3.BackColor = Color.Black
                            Case Else
                                pnlDiente2_36c3.BackColor = Color.White
                        End Select

                    Case "364"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                pnlDiente2_36c4.BackColor = Color.Red
                            Case "precaucion"
                                pnlDiente2_36c4.BackColor = Color.Yellow
                            Case "ausente"
                                pnlDiente2_36c4.BackColor = Color.Black
                            Case Else
                                pnlDiente2_36c4.BackColor = Color.White
                        End Select

                    Case "371"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                pnlDiente2_37c1.BackColor = Color.Red
                            Case "precaucion"
                                pnlDiente2_37c1.BackColor = Color.Yellow
                            Case "ausente"
                                pnlDiente2_37c1.BackColor = Color.Black
                            Case Else
                                pnlDiente2_37c1.BackColor = Color.White
                        End Select


                    Case "372"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                pnlDiente2_37c2.BackColor = Color.Red
                            Case "precaucion"
                                pnlDiente2_37c2.BackColor = Color.Yellow
                            Case "ausente"
                                pnlDiente2_37c2.BackColor = Color.Black
                            Case Else
                                pnlDiente2_37c2.BackColor = Color.White
                        End Select


                    Case "373"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                pnlDiente2_37c3.BackColor = Color.Red
                            Case "precaucion"
                                pnlDiente2_37c3.BackColor = Color.Yellow
                            Case "ausente"
                                pnlDiente2_37c3.BackColor = Color.Black
                            Case Else
                                pnlDiente2_37c3.BackColor = Color.White
                        End Select

                    Case "374"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                pnlDiente2_37c4.BackColor = Color.Red
                            Case "precaucion"
                                pnlDiente2_37c4.BackColor = Color.Yellow
                            Case "ausente"
                                pnlDiente2_37c4.BackColor = Color.Black
                            Case Else
                                pnlDiente2_37c4.BackColor = Color.White
                        End Select

                    Case "381"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                pnlDiente2_38c1.BackColor = Color.Red
                            Case "precaucion"
                                pnlDiente2_38c1.BackColor = Color.Yellow
                            Case "ausente"
                                pnlDiente2_38c1.BackColor = Color.Black
                            Case Else
                                pnlDiente2_38c1.BackColor = Color.White
                        End Select

                    Case "382"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                pnlDiente2_38c2.BackColor = Color.Red
                            Case "precaucion"
                                pnlDiente2_38c2.BackColor = Color.Yellow
                            Case "ausente"
                                pnlDiente2_38c2.BackColor = Color.Black
                            Case Else
                                pnlDiente2_38c2.BackColor = Color.White
                        End Select


                    Case "383"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                pnlDiente2_38c3.BackColor = Color.Red
                            Case "precaucion"
                                pnlDiente2_38c3.BackColor = Color.Yellow
                            Case "ausente"
                                pnlDiente2_38c3.BackColor = Color.Black
                            Case Else
                                pnlDiente2_38c3.BackColor = Color.White
                        End Select

                    Case "384"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                pnlDiente2_38c4.BackColor = Color.Red
                            Case "precaucion"
                                pnlDiente2_38c4.BackColor = Color.Yellow
                            Case "ausente"
                                pnlDiente2_38c4.BackColor = Color.Black
                            Case Else
                                pnlDiente2_38c4.BackColor = Color.White
                        End Select
                End Select
                '/////////////////////////////////////////////////////////////////////

                Select Case zona
                    Case "411"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente2_41c1.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente2_41c1.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente2_41c1.BackColor = Color.Black
                            Case Else
                                PnlDiente2_41c1.BackColor = Color.White
                        End Select
                    Case "412"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente2_41c2.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente2_41c2.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente2_41c2.BackColor = Color.Black
                            Case Else
                                PnlDiente2_41c2.BackColor = Color.White

                        End Select
                    Case "413"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente2_41c3.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente2_41c3.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente2_41c3.BackColor = Color.Black
                            Case Else
                                PnlDiente2_41c3.BackColor = Color.White
                        End Select

                    Case "414"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente2_41c4.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente2_41c4.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente2_41c4.BackColor = Color.Black
                            Case Else
                                PnlDiente2_41c4.BackColor = Color.White
                        End Select

                    Case "421"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente2_42c1.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente2_42c1.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente2_42c1.BackColor = Color.Black
                            Case Else
                                PnlDiente2_42c1.BackColor = Color.White
                        End Select

                    Case "422"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente2_42c2.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente2_42c2.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente2_42c2.BackColor = Color.Black
                            Case Else
                                PnlDiente2_42c2.BackColor = Color.White
                        End Select


                    Case "423"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente2_42c3.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente2_42c3.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente2_42c3.BackColor = Color.Black
                            Case Else
                                PnlDiente2_42c3.BackColor = Color.White
                        End Select

                    Case "424"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente2_42c4.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente2_42c4.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente2_42c4.BackColor = Color.Black
                            Case Else
                                PnlDiente2_42c4.BackColor = Color.White
                        End Select


                    Case "431"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente2_43c1.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente2_43c1.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente2_43c1.BackColor = Color.Black
                            Case Else
                                PnlDiente2_43c1.BackColor = Color.White
                        End Select

                    Case "432"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente2_43c2.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente2_43c2.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente2_43c2.BackColor = Color.Black
                            Case Else
                                PnlDiente2_43c2.BackColor = Color.White
                        End Select

                    Case "433"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente2_43c3.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente2_43c3.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente2_43c3.BackColor = Color.Black
                            Case Else
                                PnlDiente2_43c3.BackColor = Color.White
                        End Select

                    Case "434"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente2_43c4.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente2_43c4.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente2_43c4.BackColor = Color.Black
                            Case Else
                                PnlDiente2_43c4.BackColor = Color.White
                        End Select

                    Case "441"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente2_44c1.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente2_44c1.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente2_44c1.BackColor = Color.Black
                            Case Else
                                PnlDiente2_44c1.BackColor = Color.White
                        End Select

                    Case "442"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente2_44c2.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente2_44c2.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente2_44c2.BackColor = Color.Black
                            Case Else
                                PnlDiente2_44c2.BackColor = Color.White
                        End Select

                    Case "443"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente2_44c3.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente2_44c3.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente2_44c3.BackColor = Color.Black
                            Case Else
                                PnlDiente2_44c3.BackColor = Color.White
                        End Select

                    Case "444"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente2_44c4.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente2_44c4.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente2_44c4.BackColor = Color.Black
                            Case Else
                                PnlDiente2_44c4.BackColor = Color.White
                        End Select

                    Case "451"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente2_45c1.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente2_45c1.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente2_45c1.BackColor = Color.Black
                            Case Else
                                PnlDiente2_45c1.BackColor = Color.White
                        End Select


                    Case "452"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente2_45c2.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente2_45c2.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente2_45c2.BackColor = Color.Black
                            Case Else
                                PnlDiente2_45c2.BackColor = Color.White
                        End Select

                    Case "453"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente2_45c3.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente2_45c3.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente2_45c3.BackColor = Color.Black
                            Case Else
                                PnlDiente2_45c3.BackColor = Color.White
                        End Select

                    Case "454"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente2_45c4.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente2_45c4.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente2_45c4.BackColor = Color.Black
                            Case Else
                                PnlDiente2_45c4.BackColor = Color.White
                        End Select

                    Case "461"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente2_46c1.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente2_46c1.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente2_46c1.BackColor = Color.Black
                            Case Else
                                PnlDiente2_46c1.BackColor = Color.White
                        End Select

                    Case "462"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente2_46c2.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente2_46c2.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente2_46c2.BackColor = Color.Black
                            Case Else
                                PnlDiente2_46c2.BackColor = Color.White
                        End Select

                    Case "463"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente2_46c3.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente2_46c3.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente2_46c3.BackColor = Color.Black
                            Case Else
                                PnlDiente2_46c3.BackColor = Color.White
                        End Select

                    Case "464"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente2_46c4.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente2_46c4.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente2_46c4.BackColor = Color.Black
                            Case Else
                                PnlDiente2_46c4.BackColor = Color.White
                        End Select

                    Case "471"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente2_47c1.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente2_47c1.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente2_47c1.BackColor = Color.Black
                            Case Else
                                PnlDiente2_47c1.BackColor = Color.White
                        End Select


                    Case "472"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente2_47c2.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente2_47c2.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente2_47c2.BackColor = Color.Black
                            Case Else
                                PnlDiente2_47c2.BackColor = Color.White
                        End Select


                    Case "473"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente2_47c3.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente2_47c3.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente2_47c3.BackColor = Color.Black
                            Case Else
                                PnlDiente2_47c3.BackColor = Color.White
                        End Select

                    Case "474"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente2_47c4.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente2_47c4.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente2_47c4.BackColor = Color.Black
                            Case Else
                                PnlDiente2_47c4.BackColor = Color.White
                        End Select

                    Case "481"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente2_48c1.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente2_48c1.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente2_48c1.BackColor = Color.Black
                            Case Else
                                PnlDiente2_48c1.BackColor = Color.White
                        End Select

                    Case "482"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente2_48c2.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente2_48c2.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente2_48c2.BackColor = Color.Black
                            Case Else
                                PnlDiente2_48c2.BackColor = Color.White
                        End Select


                    Case "483"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente2_48c3.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente2_48c3.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente2_48c3.BackColor = Color.Black
                            Case Else
                                PnlDiente2_48c3.BackColor = Color.White
                        End Select

                    Case "484"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente2_48c4.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente2_48c4.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente2_48c4.BackColor = Color.Black
                            Case Else
                                PnlDiente2_48c4.BackColor = Color.White
                        End Select

                End Select


            Next
        Catch ex As Exception
            MsgBox("No hay datos dientes" + ex.ToString, MsgBoxStyle.Exclamation)
        End Try

    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Dispose()
        frmPacientes.Show()
    End Sub

    Private Sub actTabla()
        

    End Sub


    Private Sub cbTratamientos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbTratamientos.SelectedIndexChanged
        If cbTratamientos.SelectedIndex = 0 Then
            Try
                Consulta = "select a.descripcion as 'Descrpcion General', pl.descripcion as 'Descripcion Especifica', precio as 'Precio' from aranceles a inner join plan_tratamiento pl on pl.id_a = a.id_a where id_p = '" + id_p.ToString + "' and terminado = 0 "
                consultar()
                dgvTratamientos.DataSource = Tabla
            Catch ex As Exception
                MsgBox("Error al obtener el presupuesto", MsgBoxStyle.Exclamation)
            End Try
        ElseIf cbTratamientos.SelectedIndex = 1 Then

            Try
                Consulta = "select a.descripcion as 'Descripcion General', pl.descripcion as 'Descripcion Especifica', terminado as 'Terminado' from plan_tratamiento pl inner join aranceles a on pl.id_a = a.id_a inner join cita c on pl.id_c = c.id_c where pl.id_p = '" + id_p.ToString + "' order by fecha desc;"
                consultar()
                dgvTratamientos.DataSource = Tabla
            Catch ex As Exception
                MsgBox("Error al obtener registro", MsgBoxStyle.Exclamation)
            End Try
        ElseIf cbTratamientos.SelectedIndex = 2 Then

            Try

                Consulta = "Select descripcion, fecha, hora, atendida from cita where id_p = '" + Str(id_p) + "' order by fecha desc;"
                consultar()

                dgvTratamientos.DataSource = Tabla

                dgvTratamientos.Columns(0).HeaderText = "Descripcion"
                dgvTratamientos.Columns(1).HeaderText = "Fecha"
                dgvTratamientos.Columns(2).HeaderText = "Hora"
                dgvTratamientos.Columns(3).HeaderText = "Atendida"

                dgvTratamientos.Columns(1).Width = 70
                dgvTratamientos.Columns(2).Width = 70
                dgvTratamientos.Columns(3).Width = 120

            Catch ex As Exception

            End Try
        End If
    End Sub



    Private Sub odontograma1()
        Try


            Consulta = "select * from estado_dientes where id_p = '" + id_p.ToString + "'  and fecha = ( select min(fecha) from estado_dientes where id_p ='" + id_p.ToString + "' );"

            consultar()
            dgvEstadoDiente.DataSource = Tabla

            Dim zona As String = ""


            For x As Integer = 0 To dgvEstadoDiente.RowCount - 1


                Select Case dgvEstadoDiente.Rows(x).Cells(3).Value

                    Case "arriba-izquierda"
                        zona = "1"
                    Case "arriba-derecha"
                        zona = "2"
                    Case "abajo-derecha"
                        zona = "3"
                    Case "abajo-izquierda"
                        zona = "4"

                End Select

                zona += dgvEstadoDiente.Rows(x).Cells(4).Value.ToString

                zona += dgvEstadoDiente.Rows(x).Cells(5).Value.ToString



                Select Case zona
                    Case "111"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente11c1.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente11c1.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente11c1.BackColor = Color.Black
                            Case Else
                                PnlDiente11c1.BackColor = Color.White
                        End Select
                    Case "112"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente11c2.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente11c2.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente11c2.BackColor = Color.Black
                            Case Else
                                PnlDiente11c2.BackColor = Color.White

                        End Select
                    Case "113"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente11c3.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente11c3.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente11c3.BackColor = Color.Black
                            Case Else
                                PnlDiente11c3.BackColor = Color.White
                        End Select

                    Case "114"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente11c4.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente11c4.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente11c4.BackColor = Color.Black
                            Case Else
                                PnlDiente11c4.BackColor = Color.White
                        End Select

                    Case "121"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente12c1.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente12c1.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente12c1.BackColor = Color.Black
                            Case Else
                                PnlDiente12c1.BackColor = Color.White
                        End Select

                    Case "122"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente12c2.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente12c2.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente12c2.BackColor = Color.Black
                            Case Else
                                PnlDiente12c2.BackColor = Color.White
                        End Select


                    Case "123"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente12c3.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente12c3.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente12c3.BackColor = Color.Black
                            Case Else
                                PnlDiente12c3.BackColor = Color.White
                        End Select

                    Case "124"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente12c4.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente12c4.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente12c4.BackColor = Color.Black
                            Case Else
                                PnlDiente12c4.BackColor = Color.White
                        End Select


                    Case "131"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente13c1.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente13c1.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente13c1.BackColor = Color.Black
                            Case Else
                                PnlDiente13c1.BackColor = Color.White
                        End Select

                    Case "132"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente13c2.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente13c2.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente13c2.BackColor = Color.Black
                            Case Else
                                PnlDiente13c2.BackColor = Color.White
                        End Select

                    Case "133"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente13c3.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente13c3.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente13c3.BackColor = Color.Black
                            Case Else
                                PnlDiente13c3.BackColor = Color.White
                        End Select

                    Case "134"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente13c4.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente13c4.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente13c4.BackColor = Color.Black
                            Case Else
                                PnlDiente13c4.BackColor = Color.White
                        End Select

                    Case "141"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente14c1.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente14c1.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente14c1.BackColor = Color.Black
                            Case Else
                                PnlDiente14c1.BackColor = Color.White
                        End Select

                    Case "142"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente14c2.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente14c2.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente14c2.BackColor = Color.Black
                            Case Else
                                PnlDiente14c2.BackColor = Color.White
                        End Select

                    Case "143"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente14c3.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente14c3.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente14c3.BackColor = Color.Black
                            Case Else
                                PnlDiente14c3.BackColor = Color.White
                        End Select

                    Case "144"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente14c4.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente14c4.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente14c4.BackColor = Color.Black
                            Case Else
                                PnlDiente14c4.BackColor = Color.White
                        End Select

                    Case "151"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente15c1.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente15c1.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente15c1.BackColor = Color.Black
                            Case Else
                                PnlDiente15c1.BackColor = Color.White
                        End Select


                    Case "152"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente15c2.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente15c2.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente15c2.BackColor = Color.Black
                            Case Else
                                PnlDiente15c2.BackColor = Color.White
                        End Select

                    Case "153"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente15c3.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente15c3.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente15c3.BackColor = Color.Black
                            Case Else
                                PnlDiente15c3.BackColor = Color.White
                        End Select

                    Case "154"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente15c4.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente15c4.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente15c4.BackColor = Color.Black
                            Case Else
                                PnlDiente15c4.BackColor = Color.White
                        End Select

                    Case "161"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente16c1.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente16c1.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente16c1.BackColor = Color.Black
                            Case Else
                                PnlDiente16c1.BackColor = Color.White
                        End Select

                    Case "162"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente16c2.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente16c2.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente16c2.BackColor = Color.Black
                            Case Else
                                PnlDiente16c2.BackColor = Color.White
                        End Select

                    Case "163"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente16c3.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente16c3.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente16c3.BackColor = Color.Black
                            Case Else
                                PnlDiente16c3.BackColor = Color.White
                        End Select

                    Case "164"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente16c4.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente16c4.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente16c4.BackColor = Color.Black
                            Case Else
                                PnlDiente16c4.BackColor = Color.White
                        End Select

                    Case "171"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente17c1.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente17c1.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente17c1.BackColor = Color.Black
                            Case Else
                                PnlDiente17c1.BackColor = Color.White
                        End Select


                    Case "172"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente17c2.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente17c2.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente17c2.BackColor = Color.Black
                            Case Else
                                PnlDiente17c2.BackColor = Color.White
                        End Select


                    Case "173"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente17c3.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente17c3.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente17c3.BackColor = Color.Black
                            Case Else
                                PnlDiente17c3.BackColor = Color.White
                        End Select

                    Case "174"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente17c4.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente17c4.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente17c4.BackColor = Color.Black
                            Case Else
                                PnlDiente17c4.BackColor = Color.White
                        End Select

                    Case "181"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente18c1.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente18c1.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente18c1.BackColor = Color.Black
                            Case Else
                                PnlDiente18c1.BackColor = Color.White
                        End Select

                    Case "182"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente18c2.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente18c2.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente18c2.BackColor = Color.Black
                            Case Else
                                PnlDiente18c2.BackColor = Color.White
                        End Select


                    Case "183"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente18c3.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente18c3.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente18c3.BackColor = Color.Black
                            Case Else
                                PnlDiente18c3.BackColor = Color.White
                        End Select

                    Case "184"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente18c4.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente18c4.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente18c4.BackColor = Color.Black
                            Case Else
                                PnlDiente18c4.BackColor = Color.White
                        End Select
                End Select
                '////////////////////////////////////////////////////
                Select Case zona
                    Case "211"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente21c1.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente21c1.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente21c1.BackColor = Color.Black
                            Case Else
                                PnlDiente21c1.BackColor = Color.White
                        End Select
                    Case "212"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente21c2.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente21c2.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente21c2.BackColor = Color.Black
                            Case Else
                                PnlDiente21c2.BackColor = Color.White

                        End Select
                    Case "213"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente21c3.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente21c3.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente21c3.BackColor = Color.Black
                            Case Else
                                PnlDiente21c3.BackColor = Color.White
                        End Select

                    Case "214"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente21c4.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente21c4.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente21c4.BackColor = Color.Black
                            Case Else
                                PnlDiente21c4.BackColor = Color.White
                        End Select

                    Case "221"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente22c1.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente22c1.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente22c1.BackColor = Color.Black
                            Case Else
                                PnlDiente22c1.BackColor = Color.White
                        End Select

                    Case "222"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente22c2.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente22c2.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente22c2.BackColor = Color.Black
                            Case Else
                                PnlDiente22c2.BackColor = Color.White
                        End Select


                    Case "223"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente22c3.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente22c3.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente22c3.BackColor = Color.Black
                            Case Else
                                PnlDiente22c3.BackColor = Color.White
                        End Select

                    Case "224"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente22c4.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente22c4.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente22c4.BackColor = Color.Black
                            Case Else
                                PnlDiente22c4.BackColor = Color.White
                        End Select


                    Case "231"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente23c1.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente23c1.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente23c1.BackColor = Color.Black
                            Case Else
                                PnlDiente23c1.BackColor = Color.White
                        End Select

                    Case "232"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente23c2.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente23c2.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente23c2.BackColor = Color.Black
                            Case Else
                                PnlDiente23c2.BackColor = Color.White
                        End Select

                    Case "233"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente23c3.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente23c3.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente23c3.BackColor = Color.Black
                            Case Else
                                PnlDiente23c3.BackColor = Color.White
                        End Select

                    Case "234"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente23c4.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente23c4.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente23c4.BackColor = Color.Black
                            Case Else
                                PnlDiente23c4.BackColor = Color.White
                        End Select

                    Case "241"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente24c1.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente24c1.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente24c1.BackColor = Color.Black
                            Case Else
                                PnlDiente24c1.BackColor = Color.White
                        End Select

                    Case "242"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente24c2.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente24c2.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente24c2.BackColor = Color.Black
                            Case Else
                                PnlDiente24c2.BackColor = Color.White
                        End Select

                    Case "243"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente24c3.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente24c3.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente24c3.BackColor = Color.Black
                            Case Else
                                PnlDiente24c3.BackColor = Color.White
                        End Select

                    Case "244"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente24c4.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente24c4.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente24c4.BackColor = Color.Black
                            Case Else
                                PnlDiente24c4.BackColor = Color.White
                        End Select

                    Case "251"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente25c1.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente25c1.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente25c1.BackColor = Color.Black
                            Case Else
                                PnlDiente25c1.BackColor = Color.White
                        End Select


                    Case "252"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente25c2.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente25c2.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente25c2.BackColor = Color.Black
                            Case Else
                                PnlDiente25c2.BackColor = Color.White
                        End Select

                    Case "253"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente25c3.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente25c3.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente25c3.BackColor = Color.Black
                            Case Else
                                PnlDiente25c3.BackColor = Color.White
                        End Select

                    Case "254"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente25c4.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente25c4.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente25c4.BackColor = Color.Black
                            Case Else
                                PnlDiente25c4.BackColor = Color.White
                        End Select

                    Case "261"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente26c1.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente26c1.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente26c1.BackColor = Color.Black
                            Case Else
                                PnlDiente26c1.BackColor = Color.White
                        End Select

                    Case "262"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente26c2.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente26c2.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente26c2.BackColor = Color.Black
                            Case Else
                                PnlDiente26c2.BackColor = Color.White
                        End Select

                    Case "263"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente26c3.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente26c3.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente26c3.BackColor = Color.Black
                            Case Else
                                PnlDiente26c3.BackColor = Color.White
                        End Select

                    Case "264"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente26c4.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente26c4.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente26c4.BackColor = Color.Black
                            Case Else
                                PnlDiente26c4.BackColor = Color.White
                        End Select

                    Case "271"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente27c1.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente27c1.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente27c1.BackColor = Color.Black
                            Case Else
                                PnlDiente27c1.BackColor = Color.White
                        End Select


                    Case "272"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente27c2.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente27c2.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente27c2.BackColor = Color.Black
                            Case Else
                                PnlDiente27c2.BackColor = Color.White
                        End Select


                    Case "273"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente27c3.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente27c3.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente27c3.BackColor = Color.Black
                            Case Else
                                PnlDiente27c3.BackColor = Color.White
                        End Select

                    Case "274"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente27c4.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente27c4.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente27c4.BackColor = Color.Black
                            Case Else
                                PnlDiente27c4.BackColor = Color.White
                        End Select

                    Case "281"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente28c1.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente28c1.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente28c1.BackColor = Color.Black
                            Case Else
                                PnlDiente28c1.BackColor = Color.White
                        End Select

                    Case "282"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente28c2.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente28c2.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente28c2.BackColor = Color.Black
                            Case Else
                                PnlDiente28c2.BackColor = Color.White
                        End Select


                    Case "283"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente28c3.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente28c3.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente28c3.BackColor = Color.Black
                            Case Else
                                PnlDiente28c3.BackColor = Color.White
                        End Select

                    Case "284"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente28c4.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente28c4.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente28c4.BackColor = Color.Black
                            Case Else
                                PnlDiente28c4.BackColor = Color.White
                        End Select
                End Select

                '/////////////////////////////////////////////////////////////
                Select Case zona
                    Case "311"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                pnlDiente31c1.BackColor = Color.Red
                            Case "precaucion"
                                pnlDiente31c1.BackColor = Color.Yellow
                            Case "ausente"
                                pnlDiente31c1.BackColor = Color.Black
                            Case Else
                                pnlDiente31c1.BackColor = Color.White
                        End Select
                    Case "312"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                pnlDiente31c2.BackColor = Color.Red
                            Case "precaucion"
                                pnlDiente31c2.BackColor = Color.Yellow
                            Case "ausente"
                                pnlDiente31c2.BackColor = Color.Black
                            Case Else
                                pnlDiente31c2.BackColor = Color.White

                        End Select
                    Case "313"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                pnlDiente31c3.BackColor = Color.Red
                            Case "precaucion"
                                pnlDiente31c3.BackColor = Color.Yellow
                            Case "ausente"
                                pnlDiente31c3.BackColor = Color.Black
                            Case Else
                                pnlDiente31c3.BackColor = Color.White
                        End Select

                    Case "314"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                pnlDiente31c4.BackColor = Color.Red
                            Case "precaucion"
                                pnlDiente31c4.BackColor = Color.Yellow
                            Case "ausente"
                                pnlDiente31c4.BackColor = Color.Black
                            Case Else
                                pnlDiente31c4.BackColor = Color.White
                        End Select

                    Case "321"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                pnlDiente32c1.BackColor = Color.Red
                            Case "precaucion"
                                pnlDiente32c1.BackColor = Color.Yellow
                            Case "ausente"
                                pnlDiente32c1.BackColor = Color.Black
                            Case Else
                                pnlDiente32c1.BackColor = Color.White
                        End Select

                    Case "322"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                pnlDiente32c2.BackColor = Color.Red
                            Case "precaucion"
                                pnlDiente32c2.BackColor = Color.Yellow
                            Case "ausente"
                                pnlDiente32c2.BackColor = Color.Black
                            Case Else
                                pnlDiente32c2.BackColor = Color.White
                        End Select


                    Case "323"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                pnlDiente32c3.BackColor = Color.Red
                            Case "precaucion"
                                pnlDiente32c3.BackColor = Color.Yellow
                            Case "ausente"
                                pnlDiente32c3.BackColor = Color.Black
                            Case Else
                                pnlDiente32c3.BackColor = Color.White
                        End Select

                    Case "324"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                pnlDiente32c4.BackColor = Color.Red
                            Case "precaucion"
                                pnlDiente32c4.BackColor = Color.Yellow
                            Case "ausente"
                                pnlDiente32c4.BackColor = Color.Black
                            Case Else
                                pnlDiente32c4.BackColor = Color.White
                        End Select


                    Case "331"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                pnlDiente33c1.BackColor = Color.Red
                            Case "precaucion"
                                pnlDiente33c1.BackColor = Color.Yellow
                            Case "ausente"
                                pnlDiente33c1.BackColor = Color.Black
                            Case Else
                                pnlDiente33c1.BackColor = Color.White
                        End Select

                    Case "332"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                pnlDiente33c2.BackColor = Color.Red
                            Case "precaucion"
                                pnlDiente33c2.BackColor = Color.Yellow
                            Case "ausente"
                                pnlDiente33c2.BackColor = Color.Black
                            Case Else
                                pnlDiente33c2.BackColor = Color.White
                        End Select

                    Case "333"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                pnlDiente33c3.BackColor = Color.Red
                            Case "precaucion"
                                pnlDiente33c3.BackColor = Color.Yellow
                            Case "ausente"
                                pnlDiente33c3.BackColor = Color.Black
                            Case Else
                                pnlDiente33c3.BackColor = Color.White
                        End Select

                    Case "334"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                pnlDiente33c4.BackColor = Color.Red
                            Case "precaucion"
                                pnlDiente33c4.BackColor = Color.Yellow
                            Case "ausente"
                                pnlDiente33c4.BackColor = Color.Black
                            Case Else
                                pnlDiente33c4.BackColor = Color.White
                        End Select

                    Case "341"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                pnlDiente34c1.BackColor = Color.Red
                            Case "precaucion"
                                pnlDiente34c1.BackColor = Color.Yellow
                            Case "ausente"
                                pnlDiente34c1.BackColor = Color.Black
                            Case Else
                                pnlDiente34c1.BackColor = Color.White
                        End Select

                    Case "342"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                pnlDiente34c2.BackColor = Color.Red
                            Case "precaucion"
                                pnlDiente34c2.BackColor = Color.Yellow
                            Case "ausente"
                                pnlDiente34c2.BackColor = Color.Black
                            Case Else
                                pnlDiente34c2.BackColor = Color.White
                        End Select

                    Case "343"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                pnlDiente34c3.BackColor = Color.Red
                            Case "precaucion"
                                pnlDiente34c3.BackColor = Color.Yellow
                            Case "ausente"
                                pnlDiente34c3.BackColor = Color.Black
                            Case Else
                                pnlDiente34c3.BackColor = Color.White
                        End Select

                    Case "344"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                pnlDiente34c4.BackColor = Color.Red
                            Case "precaucion"
                                pnlDiente34c4.BackColor = Color.Yellow
                            Case "ausente"
                                pnlDiente34c4.BackColor = Color.Black
                            Case Else
                                pnlDiente34c4.BackColor = Color.White
                        End Select

                    Case "351"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                pnlDiente35c1.BackColor = Color.Red
                            Case "precaucion"
                                pnlDiente35c1.BackColor = Color.Yellow
                            Case "ausente"
                                pnlDiente35c1.BackColor = Color.Black
                            Case Else
                                pnlDiente35c1.BackColor = Color.White
                        End Select


                    Case "352"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                pnlDiente35c2.BackColor = Color.Red
                            Case "precaucion"
                                pnlDiente35c2.BackColor = Color.Yellow
                            Case "ausente"
                                pnlDiente35c2.BackColor = Color.Black
                            Case Else
                                pnlDiente35c2.BackColor = Color.White
                        End Select

                    Case "353"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                pnlDiente35c3.BackColor = Color.Red
                            Case "precaucion"
                                pnlDiente35c3.BackColor = Color.Yellow
                            Case "ausente"
                                pnlDiente35c3.BackColor = Color.Black
                            Case Else
                                pnlDiente35c3.BackColor = Color.White
                        End Select

                    Case "354"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                pnlDiente35c4.BackColor = Color.Red
                            Case "precaucion"
                                pnlDiente35c4.BackColor = Color.Yellow
                            Case "ausente"
                                pnlDiente35c4.BackColor = Color.Black
                            Case Else
                                pnlDiente35c4.BackColor = Color.White
                        End Select

                    Case "361"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                pnlDiente36c1.BackColor = Color.Red
                            Case "precaucion"
                                pnlDiente36c1.BackColor = Color.Yellow
                            Case "ausente"
                                pnlDiente36c1.BackColor = Color.Black
                            Case Else
                                pnlDiente36c1.BackColor = Color.White
                        End Select

                    Case "362"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                pnlDiente36c2.BackColor = Color.Red
                            Case "precaucion"
                                pnlDiente36c2.BackColor = Color.Yellow
                            Case "ausente"
                                pnlDiente36c2.BackColor = Color.Black
                            Case Else
                                pnlDiente36c2.BackColor = Color.White
                        End Select

                    Case "363"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                pnlDiente36c3.BackColor = Color.Red
                            Case "precaucion"
                                pnlDiente36c3.BackColor = Color.Yellow
                            Case "ausente"
                                pnlDiente36c3.BackColor = Color.Black
                            Case Else
                                pnlDiente36c3.BackColor = Color.White
                        End Select

                    Case "364"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                pnlDiente36c4.BackColor = Color.Red
                            Case "precaucion"
                                pnlDiente36c4.BackColor = Color.Yellow
                            Case "ausente"
                                pnlDiente36c4.BackColor = Color.Black
                            Case Else
                                pnlDiente36c4.BackColor = Color.White
                        End Select

                    Case "371"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                pnlDiente37c1.BackColor = Color.Red
                            Case "precaucion"
                                pnlDiente37c1.BackColor = Color.Yellow
                            Case "ausente"
                                pnlDiente37c1.BackColor = Color.Black
                            Case Else
                                pnlDiente37c1.BackColor = Color.White
                        End Select


                    Case "372"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                pnlDiente37c2.BackColor = Color.Red
                            Case "precaucion"
                                pnlDiente37c2.BackColor = Color.Yellow
                            Case "ausente"
                                pnlDiente37c2.BackColor = Color.Black
                            Case Else
                                pnlDiente37c2.BackColor = Color.White
                        End Select


                    Case "373"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                pnlDiente37c3.BackColor = Color.Red
                            Case "precaucion"
                                pnlDiente37c3.BackColor = Color.Yellow
                            Case "ausente"
                                pnlDiente37c3.BackColor = Color.Black
                            Case Else
                                pnlDiente37c3.BackColor = Color.White
                        End Select

                    Case "374"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                pnlDiente37c4.BackColor = Color.Red
                            Case "precaucion"
                                pnlDiente37c4.BackColor = Color.Yellow
                            Case "ausente"
                                pnlDiente37c4.BackColor = Color.Black
                            Case Else
                                pnlDiente37c4.BackColor = Color.White
                        End Select

                    Case "381"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                pnlDiente38c1.BackColor = Color.Red
                            Case "precaucion"
                                pnlDiente38c1.BackColor = Color.Yellow
                            Case "ausente"
                                pnlDiente38c1.BackColor = Color.Black
                            Case Else
                                pnlDiente38c1.BackColor = Color.White
                        End Select

                    Case "382"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                pnlDiente38c2.BackColor = Color.Red
                            Case "precaucion"
                                pnlDiente38c2.BackColor = Color.Yellow
                            Case "ausente"
                                pnlDiente38c2.BackColor = Color.Black
                            Case Else
                                pnlDiente38c2.BackColor = Color.White
                        End Select


                    Case "383"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                pnlDiente38c3.BackColor = Color.Red
                            Case "precaucion"
                                pnlDiente38c3.BackColor = Color.Yellow
                            Case "ausente"
                                pnlDiente38c3.BackColor = Color.Black
                            Case Else
                                pnlDiente38c3.BackColor = Color.White
                        End Select

                    Case "384"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                pnlDiente38c4.BackColor = Color.Red
                            Case "precaucion"
                                pnlDiente38c4.BackColor = Color.Yellow
                            Case "ausente"
                                pnlDiente38c4.BackColor = Color.Black
                            Case Else
                                pnlDiente38c4.BackColor = Color.White
                        End Select
                End Select
                '/////////////////////////////////////////////////////////////////////

                Select Case zona
                    Case "411"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente41c1.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente41c1.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente41c1.BackColor = Color.Black
                            Case Else
                                PnlDiente41c1.BackColor = Color.White
                        End Select
                    Case "412"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente41c2.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente41c2.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente41c2.BackColor = Color.Black
                            Case Else
                                PnlDiente41c2.BackColor = Color.White

                        End Select
                    Case "413"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente41c3.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente41c3.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente41c3.BackColor = Color.Black
                            Case Else
                                PnlDiente41c3.BackColor = Color.White
                        End Select

                    Case "414"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente41c4.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente41c4.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente41c4.BackColor = Color.Black
                            Case Else
                                PnlDiente41c4.BackColor = Color.White
                        End Select

                    Case "421"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente42c1.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente42c1.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente42c1.BackColor = Color.Black
                            Case Else
                                PnlDiente42c1.BackColor = Color.White
                        End Select

                    Case "422"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente42c2.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente42c2.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente42c2.BackColor = Color.Black
                            Case Else
                                PnlDiente42c2.BackColor = Color.White
                        End Select


                    Case "423"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente42c3.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente42c3.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente42c3.BackColor = Color.Black
                            Case Else
                                PnlDiente42c3.BackColor = Color.White
                        End Select

                    Case "424"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente42c4.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente42c4.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente42c4.BackColor = Color.Black
                            Case Else
                                PnlDiente42c4.BackColor = Color.White
                        End Select


                    Case "431"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente43c1.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente43c1.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente43c1.BackColor = Color.Black
                            Case Else
                                PnlDiente43c1.BackColor = Color.White
                        End Select

                    Case "432"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente43c2.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente43c2.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente43c2.BackColor = Color.Black
                            Case Else
                                PnlDiente43c2.BackColor = Color.White
                        End Select

                    Case "433"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente43c3.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente43c3.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente43c3.BackColor = Color.Black
                            Case Else
                                PnlDiente43c3.BackColor = Color.White
                        End Select

                    Case "434"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente43c4.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente43c4.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente43c4.BackColor = Color.Black
                            Case Else
                                PnlDiente43c4.BackColor = Color.White
                        End Select

                    Case "441"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente44c1.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente44c1.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente44c1.BackColor = Color.Black
                            Case Else
                                PnlDiente44c1.BackColor = Color.White
                        End Select

                    Case "442"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente44c2.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente44c2.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente44c2.BackColor = Color.Black
                            Case Else
                                PnlDiente44c2.BackColor = Color.White
                        End Select

                    Case "443"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente44c3.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente44c3.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente44c3.BackColor = Color.Black
                            Case Else
                                PnlDiente44c3.BackColor = Color.White
                        End Select

                    Case "444"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente44c4.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente44c4.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente44c4.BackColor = Color.Black
                            Case Else
                                PnlDiente44c4.BackColor = Color.White
                        End Select

                    Case "451"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente45c1.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente45c1.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente45c1.BackColor = Color.Black
                            Case Else
                                PnlDiente45c1.BackColor = Color.White
                        End Select


                    Case "452"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente45c2.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente45c2.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente45c2.BackColor = Color.Black
                            Case Else
                                PnlDiente45c2.BackColor = Color.White
                        End Select

                    Case "453"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente45c3.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente45c3.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente45c3.BackColor = Color.Black
                            Case Else
                                PnlDiente45c3.BackColor = Color.White
                        End Select

                    Case "454"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente45c4.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente45c4.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente45c4.BackColor = Color.Black
                            Case Else
                                PnlDiente45c4.BackColor = Color.White
                        End Select

                    Case "461"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente46c1.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente46c1.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente46c1.BackColor = Color.Black
                            Case Else
                                PnlDiente46c1.BackColor = Color.White
                        End Select

                    Case "462"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente46c2.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente46c2.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente46c2.BackColor = Color.Black
                            Case Else
                                PnlDiente46c2.BackColor = Color.White
                        End Select

                    Case "463"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente46c3.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente46c3.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente46c3.BackColor = Color.Black
                            Case Else
                                PnlDiente46c3.BackColor = Color.White
                        End Select

                    Case "464"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente46c4.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente46c4.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente46c4.BackColor = Color.Black
                            Case Else
                                PnlDiente46c4.BackColor = Color.White
                        End Select

                    Case "471"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente47c1.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente47c1.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente47c1.BackColor = Color.Black
                            Case Else
                                PnlDiente47c1.BackColor = Color.White
                        End Select


                    Case "472"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente47c2.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente47c2.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente47c2.BackColor = Color.Black
                            Case Else
                                PnlDiente47c2.BackColor = Color.White
                        End Select


                    Case "473"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente47c3.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente47c3.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente47c3.BackColor = Color.Black
                            Case Else
                                PnlDiente47c3.BackColor = Color.White
                        End Select

                    Case "474"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente47c4.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente47c4.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente47c4.BackColor = Color.Black
                            Case Else
                                PnlDiente47c4.BackColor = Color.White
                        End Select

                    Case "481"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente48c1.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente48c1.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente48c1.BackColor = Color.Black
                            Case Else
                                PnlDiente48c1.BackColor = Color.White
                        End Select

                    Case "482"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente48c2.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente48c2.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente48c2.BackColor = Color.Black
                            Case Else
                                PnlDiente48c2.BackColor = Color.White
                        End Select


                    Case "483"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente48c3.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente48c3.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente48c3.BackColor = Color.Black
                            Case Else
                                PnlDiente48c3.BackColor = Color.White
                        End Select

                    Case "484"
                        Select Case dgvEstadoDiente.Rows(x).Cells(2).Value
                            Case "alerta"
                                PnlDiente48c4.BackColor = Color.Red
                            Case "precaucion"
                                PnlDiente48c4.BackColor = Color.Yellow
                            Case "ausente"
                                PnlDiente48c4.BackColor = Color.Black
                            Case Else
                                PnlDiente48c4.BackColor = Color.White
                        End Select

                End Select


            Next
        Catch ex As Exception
            MsgBox("No hay datos dientes")
        End Try

    End Sub


   
End Class
