Public Class Registro_Medico
    Dim formu As New Form

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
                                pbDiente11.Image = My.Resources.Diente1ArribaIzquierdaNegro
                            Case Else
                                pbDiente11.Image = My.Resources.Diente1ArribaIzquierdaBlanco
                        End Select
                    Case "12"
                        Select Case DataGridView1.Rows(x).Cells(0).Value
                            Case "alerta"
                                pbDiente12.Image = My.Resources.Diente2ArribaIzquierdaRojo
                            Case "precaucion"
                                pbDiente12.Image = My.Resources.Diente2ArribaIzquierdaAmarillo
                            Case "ausente"
                                pbDiente12.Image = My.Resources.Diente2ArribaIzquierdaNegro
                            Case Else
                                pbDiente11.Image = My.Resources.Diente2ArribaIzquierdaBlanco

                        End Select
                    Case "13"
                        Select Case DataGridView1.Rows(x).Cells(0).Value
                            Case "alerta"
                                pbDiente13.Image = My.Resources.Diente3ArribaIzquierdaRojo
                            Case "precaucion"
                                pbDiente13.Image = My.Resources.Diente3ArribaIzquierdaAmarillo
                            Case "ausente"
                                pbDiente13.Image = My.Resources.Diente3ArribaIzquierdaNegro
                            Case Else
                                pbDiente11.Image = My.Resources.Diente3ArribaIzquierdaBlanco
                        End Select
                    Case "14"
                        Select Case DataGridView1.Rows(x).Cells(0).Value
                            Case "alerta"
                                pbDiente14.Image = My.Resources.Diente4ArribaIzquierdaRojo
                            Case "precaucion"
                                pbDiente14.Image = My.Resources.Diente4ArribaIzquierdaAmarillo
                            Case "ausente"
                                pbDiente14.Image = My.Resources.Diente4ArribaIzquierdaNegro
                            Case Else
                                pbDiente11.Image = My.Resources.Diente4ArribaIzquierdaBlanco
                        End Select
                    Case "15"
                        Select Case DataGridView1.Rows(x).Cells(0).Value
                            Case "alerta"
                                pbDiente15.Image = My.Resources.Diente5ArribaIzquierdaRojo
                            Case "precaucion"
                                pbDiente15.Image = My.Resources.Diente5ArribaIzquierdaAmarillo
                            Case "ausente"
                                pbDiente15.Image = My.Resources.Diente5ArribaIzquierdaNegro
                            Case Else
                                pbDiente11.Image = My.Resources.Diente5ArribaIzquierdaBlanco
                        End Select
                    Case "16"
                        Select Case DataGridView1.Rows(x).Cells(0).Value
                            Case "alerta"
                                pbDiente16.Image = My.Resources.Diente6ArribaIzquierdaRojo
                            Case "precaucion"
                                pbDiente16.Image = My.Resources.Diente6ArribaIzquierdaAmarillo
                            Case "ausente"
                                pbDiente16.Image = My.Resources.Diente6ArribaIzquierdaNegro
                            Case Else
                                pbDiente11.Image = My.Resources.Diente6ArribaIzquierdaBlanco
                        End Select
                    Case "17"
                        Select Case DataGridView1.Rows(x).Cells(0).Value
                            Case "alerta"
                                pbDiente17.Image = My.Resources.Diente7ArribaIzquierdaRojo
                            Case "precaucion"
                                pbDiente17.Image = My.Resources.Diente7ArribaIzquierdaAmarillo
                            Case "ausente"
                                pbDiente17.Image = My.Resources.Diente7ArribaIzquierdaNegro
                            Case Else
                                pbDiente11.Image = My.Resources.Diente7ArribaIzquierdaBlanco
                        End Select
                    Case "18"
                        Select Case DataGridView1.Rows(x).Cells(0).Value
                            Case "alerta"
                                pbDiente18.Image = My.Resources.Diente8ArribaIzquierdaRojo
                            Case "precaucion"
                                pbDiente18.Image = My.Resources.Diente8ArribaIzquierdaAmarillo
                            Case "ausente"
                                pbDiente18.Image = My.Resources.Diente8ArribaIzquierdaNegro
                            Case Else
                                pbDiente11.Image = My.Resources.Diente8ArribaIzquierdaBlanco
                        End Select


                        ''arriba izquierda



                    Case "21"

                        Select Case DataGridView1.Rows(x).Cells(0).Value
                            Case "alerta"
                                pbDiente21.Image = My.Resources.Diente1ArribaIzquierdaRojo
                            Case "precaucion"
                                pbDiente21.Image = My.Resources.Diente1ArribaIzquierdaAmarillo
                            Case "ausente"
                                pbDiente21.Image = My.Resources.Diente1ArribaIzquierdaNegro
                            Case Else
                                pbDiente21.Image = My.Resources.Diente1ArribaIzquierdaBlanco
                        End Select

                        pbDiente21.Image.RotateFlip(RotateFlipType.Rotate180FlipY)

                    Case "22"
                        Select Case DataGridView1.Rows(x).Cells(0).Value
                            Case "alerta"
                                pbDiente22.Image = My.Resources.Diente2ArribaIzquierdaRojo
                            Case "precaucion"
                                pbDiente22.Image = My.Resources.Diente2ArribaIzquierdaAmarillo
                            Case "ausente"
                                pbDiente22.Image = My.Resources.Diente2ArribaIzquierdaNegro
                            Case Else
                                pbDiente22.Image = My.Resources.Diente2ArribaIzquierdaBlanco
                        End Select

                        pbDiente22.Image.RotateFlip(RotateFlipType.Rotate180FlipY)

                    Case "23"

                        Select Case DataGridView1.Rows(x).Cells(0).Value
                            Case "alerta"
                                pbDiente23.Image = My.Resources.Diente3ArribaIzquierdaRojo
                            Case "precaucion"
                                pbDiente23.Image = My.Resources.Diente3ArribaIzquierdaAmarillo
                            Case "ausente"
                                pbDiente23.Image = My.Resources.Diente3ArribaIzquierdaRojo
                            Case Else
                                pbDiente23.Image = My.Resources.Diente3ArribaIzquierdaBlanco
                        End Select

                        pbDiente23.Image.RotateFlip(RotateFlipType.Rotate180FlipY)

                    Case "24"
                        Select Case DataGridView1.Rows(x).Cells(0).Value
                            Case "alerta"
                                pbDiente24.Image = My.Resources.Diente4ArribaIzquierdaRojo
                            Case "precaucion"
                                pbDiente24.Image = My.Resources.Diente4ArribaIzquierdaAmarillo
                            Case "ausente"
                                pbDiente24.Image = My.Resources.Diente4ArribaIzquierdaNegro
                            Case Else
                                pbDiente24.Image = My.Resources.Diente4ArribaIzquierdaBlanco
                        End Select

                        pbDiente24.Image.RotateFlip(RotateFlipType.Rotate180FlipY)

                    Case "25"

                        Select Case DataGridView1.Rows(x).Cells(0).Value
                            Case "alerta"
                                pbDiente25.Image = My.Resources.Diente5ArribaIzquierdaRojo
                            Case "precaucion"
                                pbDiente25.Image = My.Resources.Diente5ArribaIzquierdaAmarillo
                            Case "ausente"
                                pbDiente25.Image = My.Resources.Diente5ArribaIzquierdaNegro
                            Case Else
                                pbDiente25.Image = My.Resources.Diente5ArribaIzquierdaBlanco
                        End Select

                        pbDiente25.Image.RotateFlip(RotateFlipType.Rotate180FlipY)

                    Case "26"

                        Select Case DataGridView1.Rows(x).Cells(0).Value

                            Case "alerta"
                                pbDiente26.Image = My.Resources.Diente6ArribaIzquierdaRojo
                            Case "precaucion"
                                pbDiente26.Image = My.Resources.Diente6ArribaIzquierdaAmarillo
                            Case "ausente"
                                pbDiente26.Image = My.Resources.Diente6ArribaIzquierdaNegro
                            Case Else
                                pbDiente26.Image = My.Resources.Diente6ArribaIzquierdaBlanco
                        End Select

                        pbDiente26.Image.RotateFlip(RotateFlipType.Rotate180FlipY)

                    Case "27"

                        Select Case DataGridView1.Rows(x).Cells(0).Value

                            Case "alerta"
                                pbDiente27.Image = My.Resources.Diente7ArribaIzquierdaRojo
                            Case "precaucion"
                                pbDiente27.Image = My.Resources.Diente7ArribaIzquierdaAmarillo
                            Case "ausente"
                                pbDiente27.Image = My.Resources.Diente7ArribaIzquierdaNegro
                            Case Else
                                pbDiente27.Image = My.Resources.Diente7ArribaIzquierdaBlanco

                        End Select

                        pbDiente27.Image.RotateFlip(RotateFlipType.Rotate180FlipY)

                    Case "28"
                        Select Case DataGridView1.Rows(x).Cells(0).Value
                            Case "alerta"
                                pbDiente28.Image = My.Resources.Diente8ArribaIzquierdaRojo
                            Case "precaucion"
                                pbDiente28.Image = My.Resources.Diente8ArribaIzquierdaAmarillo
                            Case "ausente"
                                pbDiente28.Image = My.Resources.Diente8ArribaIzquierdaNegro
                            Case Else
                                pbDiente28.Image = My.Resources.Diente8ArribaIzquierdaBlanco
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
                                pbDiente31.Image = My.Resources.Diente1AbajoIzquierdaNegro
                            Case Else
                                pbDiente31.Image = My.Resources.Diente1AbajoIzquierdaBlanco
                        End Select

                        pbDiente31.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                    Case "32"
                        Select Case DataGridView1.Rows(x).Cells(0).Value
                            Case "alerta"
                                pbDiente32.Image = My.Resources.Diente2AbajoIzquierdaRojo
                            Case "precaucion"
                                pbDiente32.Image = My.Resources.Diente2AbajoIzquierdaAmarillo
                            Case "ausente"
                                pbDiente32.Image = My.Resources.Diente2AbajoIzquierdaNegro
                            Case Else
                                pbDiente32.Image = My.Resources.Diente2AbajoIzquierdaBlanco
                        End Select

                        pbDiente32.Image.RotateFlip(RotateFlipType.Rotate180FlipY)

                    Case "33"
                        Select Case DataGridView1.Rows(x).Cells(0).Value
                            Case "alerta"
                                pbDiente33.Image = My.Resources.Diente3AbajoIzquierdaRojo
                            Case "precaucion"
                                pbDiente33.Image = My.Resources.Diente3AbajoIzquierdaAmarillo
                            Case "ausente"
                                pbDiente33.Image = My.Resources.Diente3AbajoIzquierdaNegro
                            Case Else
                                pbDiente33.Image = My.Resources.Diente3AbajoIzquierdaBlanco
                        End Select

                        pbDiente33.Image.RotateFlip(RotateFlipType.Rotate180FlipY)

                    Case "34"
                        Select Case DataGridView1.Rows(x).Cells(0).Value
                            Case "alerta"
                                pbDiente34.Image = My.Resources.Diente4AbajoIzquierdaRojo
                            Case "precaucion"
                                pbDiente34.Image = My.Resources.Diente4AbajoIzquierdaAmarillo
                            Case "ausente"
                                pbDiente34.Image = My.Resources.Diente4AbajoIzquierdaNegro
                            Case Else
                                pbDiente34.Image = My.Resources.Diente4AbajoIzquierdaBlanco
                        End Select

                        pbDiente34.Image.RotateFlip(RotateFlipType.Rotate180FlipY)

                    Case "35"
                        Select Case DataGridView1.Rows(x).Cells(0).Value
                            Case "alerta"
                                pbDiente35.Image = My.Resources.Diente5AbajoIzquierdaRojo
                            Case "precaucion"
                                pbDiente35.Image = My.Resources.Diente5AbajoIzquierdaAmarillo
                            Case "ausente"
                                pbDiente35.Image = My.Resources.Diente5AbajoIzquierdaNegro
                            Case Else
                                pbDiente35.Image = My.Resources.Diente5AbajoIzquierdaBlanco
                        End Select

                        pbDiente35.Image.RotateFlip(RotateFlipType.Rotate180FlipY)

                    Case "36"
                        Select Case DataGridView1.Rows(x).Cells(0).Value
                            Case "alerta"
                                pbDiente36.Image = My.Resources.Diente6AbajoIzquierdaRojo
                            Case "precaucion"
                                pbDiente36.Image = My.Resources.Diente6AbajoIzquierdaAmarillo
                            Case "ausente"
                                pbDiente36.Image = My.Resources.Diente6AbajoIzquierdaNegro
                            Case Else
                                pbDiente36.Image = My.Resources.Diente6AbajoIzquierdaBlanco
                        End Select

                        pbDiente36.Image.RotateFlip(RotateFlipType.Rotate180FlipY)

                    Case "37"
                        Select Case DataGridView1.Rows(x).Cells(0).Value
                            Case "alerta"
                                pbDiente37.Image = My.Resources.Diente7AbajoIzquierdaRojo
                            Case "precaucion"
                                pbDiente37.Image = My.Resources.Diente7AbajoIzquierdaAmarillo
                            Case "ausente"
                                pbDiente37.Image = My.Resources.Diente7AbajoIzquierdaNegro
                            Case Else
                                pbDiente37.Image = My.Resources.Diente7AbajoIzquierdaBlanco
                        End Select

                        pbDiente37.Image.RotateFlip(RotateFlipType.Rotate180FlipY)

                    Case "38"
                        Select Case DataGridView1.Rows(x).Cells(0).Value
                            Case "alerta"
                                pbDiente38.Image = My.Resources.Diente8AbajoIzquierdaRojo
                            Case "precaucion"
                                pbDiente38.Image = My.Resources.Diente8AbajoIzquierdaAmarillo
                            Case "ausente"
                                pbDiente38.Image = My.Resources.Diente8AbajoIzquierdaNegro
                            Case Else
                                pbDiente38.Image = My.Resources.Diente8AbajoIzquierdaBlanco
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
                                pbDiente41.Image = My.Resources.Diente1AbajoIzquierdaNegro
                            Case Else
                                pbDiente41.Image = My.Resources.Diente1AbajoIzquierdaBlanco
                        End Select
                    Case "42"
                        Select Case DataGridView1.Rows(x).Cells(0).Value
                            Case "alerta"
                                pbDiente42.Image = My.Resources.Diente2AbajoIzquierdaRojo
                            Case "precaucion"
                                pbDiente42.Image = My.Resources.Diente2AbajoIzquierdaAmarillo
                            Case "ausente"
                                pbDiente42.Image = My.Resources.Diente2AbajoIzquierdaNegro
                            Case Else
                                pbDiente42.Image = My.Resources.Diente2AbajoIzquierdaBlanco
                        End Select
                    Case "43"
                        Select Case DataGridView1.Rows(x).Cells(0).Value
                            Case "alerta"
                                pbDiente43.Image = My.Resources.Diente3AbajoIzquierdaRojo
                            Case "precaucion"
                                pbDiente43.Image = My.Resources.Diente3AbajoIzquierdaAmarillo
                            Case "ausente"
                                pbDiente43.Image = My.Resources.Diente3AbajoIzquierdaNegro
                            Case Else
                                pbDiente43.Image = My.Resources.Diente3ArribaIzquierdaBlanco
                        End Select
                    Case "44"
                        Select Case DataGridView1.Rows(x).Cells(0).Value
                            Case "alerta"
                                pbDiente44.Image = My.Resources.Diente4AbajoIzquierdaRojo
                            Case "precaucion"
                                pbDiente44.Image = My.Resources.Diente4AbajoIzquierdaAmarillo
                            Case "ausente"
                                pbDiente44.Image = My.Resources.Diente4AbajoIzquierdaNegro
                            Case Else
                                pbDiente44.Image = My.Resources.Diente4AbajoIzquierdaBlanco
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





