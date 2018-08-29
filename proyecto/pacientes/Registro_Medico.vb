Public Class Registro_Medico
    Dim formu As New Form

    Private Sub Registro_Medico_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Consulta = "Select r.descripcion, zona, nro_diente, a.descripcion, c.fecha,hora , precio from registro_medico r left join aranceles a on a.id_a = r.id_a left join cita c on c.id_c = r.id_c where r.id_p = '" + Str(id_p) + "'"
            consultar()
            DataGridView1.DataSource = Tabla
            DataGridView1.Sort(DataGridView1.Columns(4), System.ComponentModel.ListSortDirection.Ascending)
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

                    Case "arriba-izquierda"
                        zona = "1"
                    Case "arriba-derecha"
                        zona = "2"
                    Case "abajo-derecha"
                        zona = "3"
                    Case "abajo-izquierda"
                        zona = "4"

                End Select

                zona += DataGridView1.Rows(x).Cells(2).Value.ToString

                Select Case zona
                    Case "11"
                        Select Case DataGridView1.Rows(x).Cells(0).Value
                            Case "alerta"
                                pbDiente11.Image = My.Resources.Diente1ArribaIzquierdaRojo
                            Case "precaucion"
                                pbDiente11.Image = My.Resources.Diente1ArribaIzquierdaAmarillo
                            Case "ausente"
<<<<<<< HEAD
                                pbad1.Image = My.Resources._1na
                            Case "normal"
                                pbad1.Image = My.Resources.AD1
=======
                                pbDiente11.Image = My.Resources.Diente1ArribaIzquierdaNegro
                            Case Else
                                pbDiente11.Image = My.Resources.Diente1ArribaIzquierdaBlanco
>>>>>>> e77f751a95043abde57a4e924143f6a68f17a95b
                        End Select
                    Case "12"
                        Select Case DataGridView1.Rows(x).Cells(0).Value
                            Case "alerta"
                                pbDiente12.Image = My.Resources.Diente2ArribaIzquierdaRojo
                            Case "precaucion"
                                pbDiente12.Image = My.Resources.Diente2ArribaIzquierdaAmarillo
                            Case "ausente"
<<<<<<< HEAD
                                pbad2.Image = My.Resources._2na
                            Case "normal"
                                pbad2.Image = My.Resources.AD2
=======
                                pbDiente12.Image = My.Resources.Diente2ArribaIzquierdaNegro
                            Case Else
                                pbDiente11.Image = My.Resources.Diente2ArribaIzquierdaBlanco

>>>>>>> e77f751a95043abde57a4e924143f6a68f17a95b
                        End Select
                    Case "13"
                        Select Case DataGridView1.Rows(x).Cells(0).Value
                            Case "alerta"
                                pbDiente13.Image = My.Resources.Diente3ArribaIzquierdaRojo
                            Case "precaucion"
                                pbDiente13.Image = My.Resources.Diente3ArribaIzquierdaAmarillo
                            Case "ausente"
<<<<<<< HEAD
                                pbad3.Image = My.Resources._3na
                            Case "normal"
                                pbad3.Image = My.Resources.AD3
=======
                                pbDiente13.Image = My.Resources.Diente3ArribaIzquierdaNegro
                            Case Else
                                pbDiente11.Image = My.Resources.Diente3ArribaIzquierdaBlanco
>>>>>>> e77f751a95043abde57a4e924143f6a68f17a95b
                        End Select
                    Case "14"
                        Select Case DataGridView1.Rows(x).Cells(0).Value
                            Case "alerta"
                                pbDiente14.Image = My.Resources.Diente4ArribaIzquierdaRojo
                            Case "precaucion"
                                pbDiente14.Image = My.Resources.Diente4ArribaIzquierdaAmarillo
                            Case "ausente"
<<<<<<< HEAD
                                pbad4.Image = My.Resources._4na
                            Case "normal"
                                pbad4.Image = My.Resources.AD4
=======
                                pbDiente14.Image = My.Resources.Diente4ArribaIzquierdaNegro
                            Case Else
                                pbDiente11.Image = My.Resources.Diente4ArribaIzquierdaBlanco
>>>>>>> e77f751a95043abde57a4e924143f6a68f17a95b
                        End Select
                    Case "15"
                        Select Case DataGridView1.Rows(x).Cells(0).Value
                            Case "alerta"
                                pbDiente15.Image = My.Resources.Diente5ArribaIzquierdaRojo
                            Case "precaucion"
                                pbDiente15.Image = My.Resources.Diente5ArribaIzquierdaAmarillo
                            Case "ausente"
<<<<<<< HEAD
                                pbad5.Image = My.Resources._5na
                            Case "normal"
                                pbad5.Image = My.Resources.AD5
=======
                                pbDiente15.Image = My.Resources.Diente5ArribaIzquierdaNegro
                            Case Else
                                pbDiente11.Image = My.Resources.Diente5ArribaIzquierdaBlanco
>>>>>>> e77f751a95043abde57a4e924143f6a68f17a95b
                        End Select
                    Case "16"
                        Select Case DataGridView1.Rows(x).Cells(0).Value
                            Case "alerta"
                                pbDiente16.Image = My.Resources.Diente6ArribaIzquierdaRojo
                            Case "precaucion"
                                pbDiente16.Image = My.Resources.Diente6ArribaIzquierdaAmarillo
                            Case "ausente"
<<<<<<< HEAD
                                pbad6.Image = My.Resources._6na
                            Case "normal"
                                pbad6.Image = My.Resources.AD6
=======
                                pbDiente16.Image = My.Resources.Diente6ArribaIzquierdaNegro
                            Case Else
                                pbDiente11.Image = My.Resources.Diente6ArribaIzquierdaBlanco
>>>>>>> e77f751a95043abde57a4e924143f6a68f17a95b
                        End Select
                    Case "17"
                        Select Case DataGridView1.Rows(x).Cells(0).Value
                            Case "alerta"
                                pbDiente17.Image = My.Resources.Diente7ArribaIzquierdaRojo
                            Case "precaucion"
                                pbDiente17.Image = My.Resources.Diente7ArribaIzquierdaAmarillo
                            Case "ausente"
<<<<<<< HEAD
                                pbad7.Image = My.Resources._7na
                            Case "normal"
                                pbad7.Image = My.Resources.AD7
=======
                                pbDiente17.Image = My.Resources.Diente7ArribaIzquierdaNegro
                            Case Else
                                pbDiente11.Image = My.Resources.Diente7ArribaIzquierdaBlanco
>>>>>>> e77f751a95043abde57a4e924143f6a68f17a95b
                        End Select
                    Case "18"
                        Select Case DataGridView1.Rows(x).Cells(0).Value
                            Case "alerta"
                                pbDiente18.Image = My.Resources.Diente8ArribaIzquierdaRojo
                            Case "precaucion"
                                pbDiente18.Image = My.Resources.Diente8ArribaIzquierdaAmarillo
                            Case "ausente"
<<<<<<< HEAD
                                pbad8.Image = My.Resources._8na
                            Case "normal"
                                pbad8.Image = My.Resources.AD8
=======
                                pbDiente18.Image = My.Resources.Diente8ArribaIzquierdaNegro
                            Case Else
                                pbDiente11.Image = My.Resources.Diente8ArribaIzquierdaBlanco
>>>>>>> e77f751a95043abde57a4e924143f6a68f17a95b
                        End Select


                        ''arriba izquierda



                    Case "21"

                        Select Case DataGridView1.Rows(x).Cells(0).Value
                            Case "alerta"
                                pbDiente21.Image = My.Resources.Diente1ArribaIzquierdaRojo
                            Case "precaucion"
                                pbDiente21.Image = My.Resources.Diente1ArribaIzquierdaAmarillo
                            Case "ausente"
<<<<<<< HEAD
                                pbai1.Image = My.Resources._1na
                            Case "normal"
                                pbai1.Image = My.Resources.AI1
=======
                                pbDiente21.Image = My.Resources.Diente1ArribaIzquierdaNegro
                            Case Else
                                pbDiente21.Image = My.Resources.Diente1ArribaIzquierdaBlanco
>>>>>>> e77f751a95043abde57a4e924143f6a68f17a95b
                        End Select

                        pbDiente21.Image.RotateFlip(RotateFlipType.Rotate180FlipY)

                    Case "22"
                        Select Case DataGridView1.Rows(x).Cells(0).Value
                            Case "alerta"
                                pbDiente22.Image = My.Resources.Diente2ArribaIzquierdaRojo
                            Case "precaucion"
                                pbDiente22.Image = My.Resources.Diente2ArribaIzquierdaAmarillo
                            Case "ausente"
<<<<<<< HEAD
                                pbai2.Image = My.Resources._2na
                            Case "normal"
                                pbai2.Image = My.Resources.AI2
=======
                                pbDiente22.Image = My.Resources.Diente2ArribaIzquierdaNegro
                            Case Else
                                pbDiente22.Image = My.Resources.Diente2ArribaIzquierdaBlanco
>>>>>>> e77f751a95043abde57a4e924143f6a68f17a95b
                        End Select

                        pbDiente22.Image.RotateFlip(RotateFlipType.Rotate180FlipY)

                    Case "23"

                        Select Case DataGridView1.Rows(x).Cells(0).Value
                            Case "alerta"
                                pbDiente23.Image = My.Resources.Diente3ArribaIzquierdaRojo
                            Case "precaucion"
                                pbDiente23.Image = My.Resources.Diente3ArribaIzquierdaAmarillo
                            Case "ausente"
<<<<<<< HEAD
                                pbai3.Image = My.Resources._3a
                            Case "normal"
                                pbai3.Image = My.Resources.AI3
=======
                                pbDiente23.Image = My.Resources.Diente3ArribaIzquierdaRojo
                            Case Else
                                pbDiente23.Image = My.Resources.Diente3ArribaIzquierdaBlanco
>>>>>>> e77f751a95043abde57a4e924143f6a68f17a95b
                        End Select

                        pbDiente23.Image.RotateFlip(RotateFlipType.Rotate180FlipY)

                    Case "24"
                        Select Case DataGridView1.Rows(x).Cells(0).Value
                            Case "alerta"
                                pbDiente24.Image = My.Resources.Diente4ArribaIzquierdaRojo
                            Case "precaucion"
                                pbDiente24.Image = My.Resources.Diente4ArribaIzquierdaAmarillo
                            Case "ausente"
<<<<<<< HEAD
                                pbai4.Image = My.Resources._4na
                            Case "normal"
                                pbai4.Image = My.Resources.AI4
=======
                                pbDiente24.Image = My.Resources.Diente4ArribaIzquierdaNegro
                            Case Else
                                pbDiente24.Image = My.Resources.Diente4ArribaIzquierdaBlanco
>>>>>>> e77f751a95043abde57a4e924143f6a68f17a95b
                        End Select

                        pbDiente24.Image.RotateFlip(RotateFlipType.Rotate180FlipY)

                    Case "25"

                        Select Case DataGridView1.Rows(x).Cells(0).Value
                            Case "alerta"
                                pbDiente25.Image = My.Resources.Diente5ArribaIzquierdaRojo
                            Case "precaucion"
                                pbDiente25.Image = My.Resources.Diente5ArribaIzquierdaAmarillo
                            Case "ausente"
<<<<<<< HEAD
                                pbai5.Image = My.Resources._5na
                            Case "normal"
                                pbai5.Image = My.Resources.AI5
=======
                                pbDiente25.Image = My.Resources.Diente5ArribaIzquierdaNegro
                            Case Else
                                pbDiente25.Image = My.Resources.Diente5ArribaIzquierdaBlanco
>>>>>>> e77f751a95043abde57a4e924143f6a68f17a95b
                        End Select

                        pbDiente25.Image.RotateFlip(RotateFlipType.Rotate180FlipY)

                    Case "26"

                        Select Case DataGridView1.Rows(x).Cells(0).Value

                            Case "alerta"
                                pbDiente26.Image = My.Resources.Diente6ArribaIzquierdaRojo
                            Case "precaucion"
                                pbDiente26.Image = My.Resources.Diente6ArribaIzquierdaAmarillo
                            Case "ausente"
<<<<<<< HEAD
                                pbai6.Image = My.Resources._6na
                            Case "normal"
                                pbai6.Image = My.Resources.AI6
=======
                                pbDiente26.Image = My.Resources.Diente6ArribaIzquierdaNegro
                            Case Else
                                pbDiente26.Image = My.Resources.Diente6ArribaIzquierdaBlanco
>>>>>>> e77f751a95043abde57a4e924143f6a68f17a95b
                        End Select

                        pbDiente26.Image.RotateFlip(RotateFlipType.Rotate180FlipY)

                    Case "27"

                        Select Case DataGridView1.Rows(x).Cells(0).Value

                            Case "alerta"
                                pbDiente27.Image = My.Resources.Diente7ArribaIzquierdaRojo
                            Case "precaucion"
                                pbDiente27.Image = My.Resources.Diente7ArribaIzquierdaAmarillo
                            Case "ausente"
<<<<<<< HEAD
                                pbai7.Image = My.Resources._7na
                            Case "normal"
                                pbai7.Image = My.Resources.AI7
=======
                                pbDiente27.Image = My.Resources.Diente7ArribaIzquierdaNegro
                            Case Else
                                pbDiente27.Image = My.Resources.Diente7ArribaIzquierdaBlanco

>>>>>>> e77f751a95043abde57a4e924143f6a68f17a95b
                        End Select

                        pbDiente27.Image.RotateFlip(RotateFlipType.Rotate180FlipY)

                    Case "28"
                        Select Case DataGridView1.Rows(x).Cells(0).Value
                            Case "alerta"
                                pbDiente28.Image = My.Resources.Diente8ArribaIzquierdaRojo
                            Case "precaucion"
                                pbDiente28.Image = My.Resources.Diente8ArribaIzquierdaAmarillo
                            Case "ausente"
<<<<<<< HEAD
                                pbai8.Image = My.Resources._8na
                            Case "normal"
                                pbai8.Image = My.Resources.AI8
=======
                                pbDiente28.Image = My.Resources.Diente8ArribaIzquierdaNegro
                            Case Else
                                pbDiente28.Image = My.Resources.Diente8ArribaIzquierdaBlanco
>>>>>>> e77f751a95043abde57a4e924143f6a68f17a95b
                        End Select
                        pbDiente28.Image.RotateFlip(RotateFlipType.Rotate180FlipY)


                        ''abajo derecha

                    Case "31"
                        Select Case DataGridView1.Rows(x).Cells(0).Value
                            Case "alerta"
                                pbDiente31.Image = My.Resources.Diente1AbajoIzquierdaRojo
                            Case "precaucion"
                                pbDiente31.Image = My.Resources.Diente1AbajoIzquierdaAmarillo
                            Case "ausente"
<<<<<<< HEAD
                                pbbi1.Image = My.Resources._1na
                            Case "normal"
                                pbbi1.Image = My.Resources.BI1
=======
                                pbDiente31.Image = My.Resources.Diente1AbajoIzquierdaNegro
                            Case Else
                                pbDiente31.Image = My.Resources.Diente1AbajoIzquierdaBlanco
>>>>>>> e77f751a95043abde57a4e924143f6a68f17a95b
                        End Select

                        pbDiente31.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                    Case "32"
                        Select Case DataGridView1.Rows(x).Cells(0).Value
                            Case "alerta"
                                pbDiente32.Image = My.Resources.Diente2AbajoIzquierdaRojo
                            Case "precaucion"
                                pbDiente32.Image = My.Resources.Diente2AbajoIzquierdaAmarillo
                            Case "ausente"
<<<<<<< HEAD
                                pbbi2.Image = My.Resources._2na
                            Case "normal"
                                pbbi2.Image = My.Resources.BI2
=======
                                pbDiente32.Image = My.Resources.Diente2AbajoIzquierdaNegro
                            Case Else
                                pbDiente32.Image = My.Resources.Diente2AbajoIzquierdaBlanco
>>>>>>> e77f751a95043abde57a4e924143f6a68f17a95b
                        End Select

                        pbDiente32.Image.RotateFlip(RotateFlipType.Rotate180FlipY)

                    Case "33"
                        Select Case DataGridView1.Rows(x).Cells(0).Value
                            Case "alerta"
                                pbDiente33.Image = My.Resources.Diente3AbajoIzquierdaRojo
                            Case "precaucion"
                                pbDiente33.Image = My.Resources.Diente3AbajoIzquierdaAmarillo
                            Case "ausente"
<<<<<<< HEAD
                                pbbi3.Image = My.Resources._3na
                            Case "normal"
                                pbbi3.Image = My.Resources.BI3
=======
                                pbDiente33.Image = My.Resources.Diente3AbajoIzquierdaNegro
                            Case Else
                                pbDiente33.Image = My.Resources.Diente3AbajoIzquierdaBlanco
>>>>>>> e77f751a95043abde57a4e924143f6a68f17a95b
                        End Select

                        pbDiente33.Image.RotateFlip(RotateFlipType.Rotate180FlipY)

                    Case "34"
                        Select Case DataGridView1.Rows(x).Cells(0).Value
                            Case "alerta"
                                pbDiente34.Image = My.Resources.Diente4AbajoIzquierdaRojo
                            Case "precaucion"
                                pbDiente34.Image = My.Resources.Diente4AbajoIzquierdaAmarillo
                            Case "ausente"
<<<<<<< HEAD
                                pbbi4.Image = My.Resources._4na
                            Case "normal"
                                pbbi4.Image = My.Resources.BI4
=======
                                pbDiente34.Image = My.Resources.Diente4AbajoIzquierdaNegro
                            Case Else
                                pbDiente34.Image = My.Resources.Diente4AbajoIzquierdaBlanco
>>>>>>> e77f751a95043abde57a4e924143f6a68f17a95b
                        End Select

                        pbDiente34.Image.RotateFlip(RotateFlipType.Rotate180FlipY)

                    Case "35"
                        Select Case DataGridView1.Rows(x).Cells(0).Value
                            Case "alerta"
                                pbDiente35.Image = My.Resources.Diente5AbajoIzquierdaRojo
                            Case "precaucion"
                                pbDiente35.Image = My.Resources.Diente5AbajoIzquierdaAmarillo
                            Case "ausente"
<<<<<<< HEAD
                                pbbi5.Image = My.Resources._5na
                            Case "normal"
                                pbbi5.Image = My.Resources.BI5
=======
                                pbDiente35.Image = My.Resources.Diente5AbajoIzquierdaNegro
                            Case Else
                                pbDiente35.Image = My.Resources.Diente5AbajoIzquierdaBlanco
>>>>>>> e77f751a95043abde57a4e924143f6a68f17a95b
                        End Select

                        pbDiente35.Image.RotateFlip(RotateFlipType.Rotate180FlipY)

                    Case "36"
                        Select Case DataGridView1.Rows(x).Cells(0).Value
                            Case "alerta"
                                pbDiente36.Image = My.Resources.Diente6AbajoIzquierdaRojo
                            Case "precaucion"
                                pbDiente36.Image = My.Resources.Diente6AbajoIzquierdaAmarillo
                            Case "ausente"
<<<<<<< HEAD
                                pbbi6.Image = My.Resources._6na
                            Case "normal"
                                pbbi6.Image = My.Resources.BI6
=======
                                pbDiente36.Image = My.Resources.Diente6AbajoIzquierdaNegro
                            Case Else
                                pbDiente36.Image = My.Resources.Diente6AbajoIzquierdaBlanco
>>>>>>> e77f751a95043abde57a4e924143f6a68f17a95b
                        End Select

                        pbDiente36.Image.RotateFlip(RotateFlipType.Rotate180FlipY)

                    Case "37"
                        Select Case DataGridView1.Rows(x).Cells(0).Value
                            Case "alerta"
                                pbDiente37.Image = My.Resources.Diente7AbajoIzquierdaRojo
                            Case "precaucion"
                                pbDiente37.Image = My.Resources.Diente7AbajoIzquierdaAmarillo
                            Case "ausente"
<<<<<<< HEAD
                                pbbi7.Image = My.Resources._7na
                            Case "normal"
                                pbbi7.Image = My.Resources.BI7
=======
                                pbDiente37.Image = My.Resources.Diente7AbajoIzquierdaNegro
                            Case Else
                                pbDiente37.Image = My.Resources.Diente7AbajoIzquierdaBlanco
>>>>>>> e77f751a95043abde57a4e924143f6a68f17a95b
                        End Select

                        pbDiente37.Image.RotateFlip(RotateFlipType.Rotate180FlipY)

                    Case "38"
                        Select Case DataGridView1.Rows(x).Cells(0).Value
                            Case "alerta"
                                pbDiente38.Image = My.Resources.Diente8AbajoIzquierdaRojo
                            Case "precaucion"
                                pbDiente38.Image = My.Resources.Diente8AbajoIzquierdaAmarillo
                            Case "ausente"
<<<<<<< HEAD
                                pbbi8.Image = My.Resources._8na
                            Case "normal"
                                pbbi8.Image = My.Resources.BI8
=======
                                pbDiente38.Image = My.Resources.Diente8AbajoIzquierdaNegro
                            Case Else
                                pbDiente38.Image = My.Resources.Diente8AbajoIzquierdaBlanco
>>>>>>> e77f751a95043abde57a4e924143f6a68f17a95b
                        End Select

                        pbDiente38.Image.RotateFlip(RotateFlipType.Rotate180FlipY)

                        ''abajo izquierda


                    Case "41"
                        Select Case DataGridView1.Rows(x).Cells(0).Value
                            Case "alerta"
                                pbDiente41.Image = My.Resources.Diente1AbajoIzquierdaRojo
                            Case "precaucion"
                                pbDiente41.Image = My.Resources.Diente1AbajoIzquierdaAmarillo
                            Case "ausente"
<<<<<<< HEAD
                                pbbd1.Image = My.Resources._1nb
                            Case "normal"
                                pbbd1.Image = My.Resources.BD1
=======
                                pbDiente41.Image = My.Resources.Diente1AbajoIzquierdaNegro
                            Case Else
                                pbDiente41.Image = My.Resources.Diente1AbajoIzquierdaBlanco
>>>>>>> e77f751a95043abde57a4e924143f6a68f17a95b
                        End Select
                    Case "42"
                        Select Case DataGridView1.Rows(x).Cells(0).Value
                            Case "alerta"
                                pbDiente42.Image = My.Resources.Diente2AbajoIzquierdaRojo
                            Case "precaucion"
                                pbDiente42.Image = My.Resources.Diente2AbajoIzquierdaAmarillo
                            Case "ausente"
<<<<<<< HEAD
                                pbbd2.Image = My.Resources._2nb
                            Case "normal"
                                pbbi2.Image = My.Resources.BD2
=======
                                pbDiente42.Image = My.Resources.Diente2AbajoIzquierdaNegro
                            Case Else
                                pbDiente42.Image = My.Resources.Diente2AbajoIzquierdaBlanco
>>>>>>> e77f751a95043abde57a4e924143f6a68f17a95b
                        End Select
                    Case "43"
                        Select Case DataGridView1.Rows(x).Cells(0).Value
                            Case "alerta"
                                pbDiente43.Image = My.Resources.Diente3AbajoIzquierdaRojo
                            Case "precaucion"
                                pbDiente43.Image = My.Resources.Diente3AbajoIzquierdaAmarillo
                            Case "ausente"
<<<<<<< HEAD
                                pbbd3.Image = My.Resources._3nb
                            Case "normal"
                                pbbi3.Image = My.Resources.BD3
=======
                                pbDiente43.Image = My.Resources.Diente3AbajoIzquierdaNegro
                            Case Else
                                pbDiente43.Image = My.Resources.Diente3ArribaIzquierdaBlanco
>>>>>>> e77f751a95043abde57a4e924143f6a68f17a95b
                        End Select
                    Case "44"
                        Select Case DataGridView1.Rows(x).Cells(0).Value
                            Case "alerta"
                                pbDiente44.Image = My.Resources.Diente4AbajoIzquierdaRojo
                            Case "precaucion"
                                pbDiente44.Image = My.Resources.Diente4AbajoIzquierdaAmarillo
                            Case "ausente"
<<<<<<< HEAD
                                pbbd4.Image = My.Resources._4nb
<<<<<<< HEAD
                            Case "normal"
                                pbbi4.Image = My.Resources.BD4
                        End Select
                            Case "45"
                                Select Case DataGridView1.Rows(x).Cells(0).Value
                                    Case "malo"
                                        pbbd5.Image = My.Resources._5b
                                    Case "precaucion"
                                        pbbd5.Image = My.Resources._5ab
                                    Case "ausente"
                                pbbd5.Image = My.Resources._5nb
                            Case "normal"
                                pbbi5.Image = My.Resources.BI5
                        End Select
                            Case "46"
                                Select Case DataGridView1.Rows(x).Cells(0).Value
                                    Case "malo"
                                        pbbd6.Image = My.Resources._6b
                                    Case "precaucion"
                                        pbbd6.Image = My.Resources._6ab
                                    Case "ausente"
                                pbbd6.Image = My.Resources._6nb
                            Case "normal"
                                pbbi6.Image = My.Resources.BI6
                        End Select
                            Case "47"
                                Select Case DataGridView1.Rows(x).Cells(0).Value
                                    Case "malo"
                                        pbbd7.Image = My.Resources._7b
                                    Case "precaucion"
                                        pbbd7.Image = My.Resources._7ab
                                    Case "ausente"
                                pbbd7.Image = My.Resources._7nb
                            Case "normal"
                                pbbi7.Image = My.Resources.BI7
                        End Select
                            Case "48"
                                Select Case DataGridView1.Rows(x).Cells(0).Value
                                    Case "malo"
                                        pbbd8.Image = My.Resources._8b
                                    Case "precaucion"
                                        pbbd8.Image = My.Resources._8ab
                                    Case "ausente"
                                pbbd8.Image = My.Resources._8nb
                            Case "normal"
                                pbbi8.Image = My.Resources.AI8

                        End Select
                        End Select


                        'pb1.Image = My.Resources.AD1

                        ''Dim panel As New Panel
                        ''agsdfasdfasdfasdfsfd
                        'If DataGridView1.Rows(x).Cells(0).Value = "malo" Then
                        '    panel.BackColor = Color.Red
                        'ElseIf DataGridView1.Rows(x).Cells(0).Value = "precaucion" Then
                        '    panel.BackColor = Color.Yellow
                        'Else
                        '    panel.BackColor = Color.White
                        'End If

                        'Select Case zona
                        '    Case "11"
                        '        Panel11.BackColor = panel.BackColor
                        '    Case "12"
                        '        Panel12.BackColor = panel.BackColor
                        '    Case "13"
                        '        Panel13.BackColor = panel.BackColor
                        '    Case "14"
                        '        Panel14.BackColor = panel.BackColor
                        '    Case "15"
                        '        Panel15.BackColor = panel.BackColor
                        '    Case "16"
                        '        Panel16.BackColor = panel.BackColor
                        '    Case "17"
                        '        Panel17.BackColor = panel.BackColor
                        '    Case "18"
                        '        Panel18.BackColor = panel.BackColor
                        '    Case "21"
                        '        Panel21.BackColor = panel.BackColor
                        '    Case "22"
                        '        Panel22.BackColor = panel.BackColor
                        '    Case "23"
                        '        Panel23.BackColor = panel.BackColor
                        '    Case "24"
                        '        Panel24.BackColor = panel.BackColor
                        '    Case "25"
                        '        Panel25.BackColor = panel.BackColor
                        '    Case "26"
                        '        Panel26.BackColor = panel.BackColor
                        '    Case "27"
                        '        Panel27.BackColor = panel.BackColor
                        '    Case "28"
                        '        Panel28.BackColor = panel.BackColor
                        '    Case "31"
                        '        Panel31.BackColor = panel.BackColor
                        '    Case "32"
                        '        Panel32.BackColor = panel.BackColor
                        '    Case "33"
                        '        Panel33.BackColor = panel.BackColor
                        '    Case "34"
                        '        Panel34.BackColor = panel.BackColor
                        '    Case "35"
                        '        Panel35.BackColor = panel.BackColor
                        '    Case "36"
                        '        Panel36.BackColor = panel.BackColor
                        '    Case "37"
                        '        Panel37.BackColor = panel.BackColor
                        '    Case "38"
                        '        Panel38.BackColor = panel.BackColor
                        '    Case "41"
                        '        Panel41.BackColor = panel.BackColor
                        '    Case "42"
                        '        Panel42.BackColor = panel.BackColor
                        '    Case "43"
                        '        Panel43.BackColor = panel.BackColor
                        '    Case "44"
                        '        Panel44.BackColor = panel.BackColor
                        '    Case "45"
                        '        Panel45.BackColor = panel.BackColor
                        '    Case "46"
                        '        Panel46.BackColor = panel.BackColor
                        '    Case "47"
                        '        Panel47.BackColor = panel.BackColor
                        '    Case "48"
                        '        Panel48.BackColor = panel.BackColor

                        'End Select
=======
=======
                                pbDiente44.Image = My.Resources.Diente4AbajoIzquierdaNegro
                            Case Else
                                pbDiente44.Image = My.Resources.Diente4AbajoIzquierdaBlanco
>>>>>>> e77f751a95043abde57a4e924143f6a68f17a95b
                        End Select
                    Case "45"
                        Select Case DataGridView1.Rows(x).Cells(0).Value
                            Case "alerta"
                                pbDiente45.Image = My.Resources.Diente5AbajoIzquierdaRojo
                            Case "precaucion"
                                pbDiente45.Image = My.Resources.Diente5AbajoIzquierdaAmarillo
                            Case "ausente"
                                pbDiente45.Image = My.Resources.Diente5AbajoIzquierdaNegro
                            Case Else
                                pbDiente45.Image = My.Resources.Diente5AbajoIzquierdaBlanco
                        End Select
                    Case "46"
                        Select Case DataGridView1.Rows(x).Cells(0).Value
                            Case "alerta"
                                pbDiente46.Image = My.Resources.Diente6AbajoIzquierdaRojo
                            Case "precaucion"
                                pbDiente46.Image = My.Resources.Diente6AbajoIzquierdaAmarillo
                            Case "ausente"
                                pbDiente46.Image = My.Resources.Diente6AbajoIzquierdaNegro
                            Case Else
                                pbDiente46.Image = My.Resources.Diente6AbajoIzquierdaBlanco
                        End Select
                    Case "47"
                        Select Case DataGridView1.Rows(x).Cells(0).Value
                            Case "alerta"
                                pbDiente47.Image = My.Resources.Diente7AbajoIzquierdaRojo
                            Case "precaucion"
                                pbDiente47.Image = My.Resources.Diente7AbajoIzquierdaAmarillo
                            Case "ausente"
                                pbDiente47.Image = My.Resources.Diente7AbajoIzquierdaNegro
                            Case Else
                                pbDiente47.Image = My.Resources.Diente7AbajoIzquierdaBlanco
                        End Select
                    Case "48"
                        Select Case DataGridView1.Rows(x).Cells(0).Value
                            Case "alerta"
                                pbDiente48.Image = My.Resources.Diente8AbajoIzquierdaRojo
                            Case "precaucion"
                                pbDiente48.Image = My.Resources.Diente8AbajoIzquierdaAmarillo
                            Case "ausente"
                                pbDiente48.Image = My.Resources.Diente8AbajoIzquierdaNegro
                            Case Else
                                pbDiente48.Image = My.Resources.Diente8AbajoIzquierdaBlanco
                        End Select
                End Select

>>>>>>> 085945730d089fcba482d096d6ac6b5422bd0117
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

    Private Sub pbad7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbDiente17.Click


    End Sub

    Private Sub pbad1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbDiente11.Click

    End Sub





End Class





