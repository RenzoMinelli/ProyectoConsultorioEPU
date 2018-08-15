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

                    Case "arriba-derecha"
                        zona = "1"
                    Case "arriba-izquierda"
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
                            Case "malo"
                                pbad1.Image = My.Resources._1a
                            Case "precaucion"
                                pbad1.Image = My.Resources._1aa
                            Case "ausente"
                                pbad1.Image = My.Resources._1na
                        End Select
                    Case "12"
                        Select Case DataGridView1.Rows(x).Cells(0).Value
                            Case "malo"
                                pbad2.Image = My.Resources._2a
                            Case "precaucion"
                                pbad2.Image = My.Resources._2aa
                            Case "ausente"
                                pbad2.Image = My.Resources._2na
                        End Select
                    Case "13"
                        Select Case DataGridView1.Rows(x).Cells(0).Value
                            Case "malo"
                                pbad3.Image = My.Resources._3a
                            Case "precaucion"
                                pbad3.Image = My.Resources._3aa
                            Case "ausente"
                                pbad3.Image = My.Resources._3na
                        End Select
                    Case "14"
                        Select Case DataGridView1.Rows(x).Cells(0).Value
                            Case "malo"
                                pbad4.Image = My.Resources._4a
                            Case "precaucion"
                                pbad4.Image = My.Resources._4aa
                            Case "ausente"
                                pbad4.Image = My.Resources._4na
                        End Select
                    Case "15"
                        Select Case DataGridView1.Rows(x).Cells(0).Value
                            Case "malo"
                                pbad5.Image = My.Resources._5a
                            Case "precaucion"
                                pbad5.Image = My.Resources._5aa
                            Case "ausente"
                                pbad5.Image = My.Resources._5na
                        End Select
                    Case "16"
                        Select Case DataGridView1.Rows(x).Cells(0).Value
                            Case "malo"
                                pbad6.Image = My.Resources._6a
                            Case "precaucion"
                                pbad6.Image = My.Resources._6aa
                            Case "ausente"
                                pbad6.Image = My.Resources._6na
                        End Select
                    Case "17"
                        Select Case DataGridView1.Rows(x).Cells(0).Value
                            Case "malo"
                                pbad7.Image = My.Resources._7a
                            Case "precaucion"
                                pbad7.Image = My.Resources._7aa
                            Case "ausente"
                                pbad7.Image = My.Resources._7na
                        End Select
                    Case "18"
                        Select Case DataGridView1.Rows(x).Cells(0).Value
                            Case "malo"
                                pbad8.Image = My.Resources._8a
                            Case "precaucion"
                                pbad8.Image = My.Resources._8aa
                            Case "ausente"
                                pbad8.Image = My.Resources._8na
                        End Select


                        ''arriba izquierda



                    Case "21"
                        Select Case DataGridView1.Rows(x).Cells(0).Value
                            Case "malo"
                                pbai1.Image = My.Resources._1a
                            Case "precaucion"
                                pbai1.Image = My.Resources._1aa
                            Case "ausente"
                                pbai1.Image = My.Resources._1na
                        End Select
                    Case "22"
                        Select Case DataGridView1.Rows(x).Cells(0).Value
                            Case "malo"
                                pbai2.Image = My.Resources._2a
                            Case "precaucion"
                                pbai2.Image = My.Resources._2aa
                            Case "ausente"
                                pbai2.Image = My.Resources._2na
                        End Select
                    Case "23"
                        Select Case DataGridView1.Rows(x).Cells(0).Value
                            Case "malo"
                                pbai3.Image = My.Resources._3a
                            Case "precaucion"
                                pbai3.Image = My.Resources._3aa
                            Case "ausente"
                                pbai3.Image = My.Resources._3a
                        End Select
                    Case "24"
                        Select Case DataGridView1.Rows(x).Cells(0).Value
                            Case "malo"
                                pbai4.Image = My.Resources._4a
                            Case "precaucion"
                                pbai4.Image = My.Resources._4aa
                            Case "ausente"
                                pbai4.Image = My.Resources._4na
                        End Select
                    Case "25"
                        Select Case DataGridView1.Rows(x).Cells(0).Value
                            Case "malo"
                                pbai5.Image = My.Resources._5a
                            Case "precaucion"
                                pbai5.Image = My.Resources._5aa
                            Case "ausente"
                                pbai5.Image = My.Resources._5na
                        End Select
                    Case "26"
                        Select Case DataGridView1.Rows(x).Cells(0).Value
                            Case "malo"
                                pbai6.Image = My.Resources._6a
                            Case "precaucion"
                                pbai6.Image = My.Resources._6aa
                            Case "ausente"
                                pbai6.Image = My.Resources._6na
                        End Select
                    Case "27"
                        Select Case DataGridView1.Rows(x).Cells(0).Value
                            Case "malo"
                                pbai7.Image = My.Resources._7a
                            Case "precaucion"
                                pbai7.Image = My.Resources._7aa
                            Case "ausente"
                                pbai7.Image = My.Resources._7na
                        End Select
                    Case "28"
                        Select Case DataGridView1.Rows(x).Cells(0).Value
                            Case "malo"
                                pbai8.Image = My.Resources._8a
                            Case "precaucion"
                                pbai8.Image = My.Resources._8aa
                            Case "ausente"
                                pbai8.Image = My.Resources._8na
                        End Select



                        ''abajo derecha

                    Case "31"
                        Select Case DataGridView1.Rows(x).Cells(0).Value
                            Case "malo"
                                pbbi1.Image = My.Resources._1b
                            Case "precaucion"
                                pbbi1.Image = My.Resources._1ab
                            Case "ausente"
                                pbbi1.Image = My.Resources._1na
                        End Select

                    Case "32"
                        Select Case DataGridView1.Rows(x).Cells(0).Value
                            Case "malo"
                                pbbi2.Image = My.Resources._2b
                            Case "precaucion"
                                pbbi2.Image = My.Resources._2ab
                            Case "ausente"
                                pbbi2.Image = My.Resources._2na
                        End Select
                    Case "33"
                        Select Case DataGridView1.Rows(x).Cells(0).Value
                            Case "malo"
                                pbbi3.Image = My.Resources._3b
                            Case "precaucion"
                                pbbi3.Image = My.Resources._3ab
                            Case "ausente"
                                pbbi3.Image = My.Resources._3na
                        End Select
                    Case "34"
                        Select Case DataGridView1.Rows(x).Cells(0).Value
                            Case "malo"
                                pbbi4.Image = My.Resources._4b
                            Case "precaucion"
                                pbbi4.Image = My.Resources._4ab
                            Case "ausente"
                                pbbi4.Image = My.Resources._4na
                        End Select
                    Case "35"
                        Select Case DataGridView1.Rows(x).Cells(0).Value
                            Case "malo"
                                pbbi5.Image = My.Resources._5b
                            Case "precaucion"
                                pbbi5.Image = My.Resources._5ab
                            Case "ausente"
                                pbbi5.Image = My.Resources._5na
                        End Select
                    Case "36"
                        Select Case DataGridView1.Rows(x).Cells(0).Value
                            Case "malo"
                                pbbi6.Image = My.Resources._6b
                            Case "precaucion"
                                pbbi6.Image = My.Resources._6ab
                            Case "ausente"
                                pbbi6.Image = My.Resources._6na
                        End Select
                    Case "37"
                        Select Case DataGridView1.Rows(x).Cells(0).Value
                            Case "malo"
                                pbbi7.Image = My.Resources._7b
                            Case "precaucion"
                                pbbi7.Image = My.Resources._7ab
                            Case "ausente"
                                pbbi7.Image = My.Resources._7na
                        End Select
                    Case "38"
                        Select Case DataGridView1.Rows(x).Cells(0).Value
                            Case "malo"
                                pbbi8.Image = My.Resources._8b
                            Case "precaucion"
                                pbbi8.Image = My.Resources._8ab
                            Case "ausente"
                                pbbi8.Image = My.Resources._8na
                        End Select

                        ''abajo izquierda


                    Case "41"
                        Select Case DataGridView1.Rows(x).Cells(0).Value
                            Case "malo"
                                pbbd1.Image = My.Resources._1b
                            Case "precaucion"
                                pbbd1.Image = My.Resources._1ab
                            Case "ausente"
                                pbbd1.Image = My.Resources._1nb
                        End Select
                    Case "42"
                        Select Case DataGridView1.Rows(x).Cells(0).Value
                            Case "malo"
                                pbbd2.Image = My.Resources._2b
                            Case "precaucion"
                                pbbd2.Image = My.Resources._2ab
                            Case "ausente"
                                pbbd2.Image = My.Resources._2nb
                        End Select
                    Case "43"
                        Select Case DataGridView1.Rows(x).Cells(0).Value
                            Case "malo"
                                pbbd3.Image = My.Resources._3b
                            Case "precaucion"
                                pbbd3.Image = My.Resources._3ab
                            Case "ausente"
                                pbbd3.Image = My.Resources._3nb
                        End Select
                    Case "44"
                        Select Case DataGridView1.Rows(x).Cells(0).Value
                            Case "malo"
                                pbbd4.Image = My.Resources._4b
                            Case "precaucion"
                                pbbd4.Image = My.Resources._4ab
                            Case "ausente"
                                pbbd4.Image = My.Resources._4nb
                        End Select
                    Case "45"
                        Select Case DataGridView1.Rows(x).Cells(0).Value
                            Case "malo"
                                pbbd5.Image = My.Resources._5b
                            Case "precaucion"
                                pbbd5.Image = My.Resources._5ab
                            Case "ausente"
                                pbbd5.Image = My.Resources._5nb
                        End Select
                    Case "46"
                        Select Case DataGridView1.Rows(x).Cells(0).Value
                            Case "malo"
                                pbbd6.Image = My.Resources._6b
                            Case "precaucion"
                                pbbd6.Image = My.Resources._6ab
                            Case "ausente"
                                pbbd6.Image = My.Resources._6nb
                        End Select
                    Case "47"
                        Select Case DataGridView1.Rows(x).Cells(0).Value
                            Case "malo"
                                pbbd7.Image = My.Resources._7b
                            Case "precaucion"
                                pbbd7.Image = My.Resources._7ab
                            Case "ausente"
                                pbbd7.Image = My.Resources._7nb
                        End Select
                    Case "48"
                        Select Case DataGridView1.Rows(x).Cells(0).Value
                            Case "malo"
                                pbbd8.Image = My.Resources._8b
                            Case "precaucion"
                                pbbd8.Image = My.Resources._8ab
                            Case "ausente"
                                pbbd8.Image = My.Resources._8nb
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



    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbbd8.Click

    End Sub

    Private Sub Label17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub pbad6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbad6.Click

    End Sub

    Private Sub pbbd1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbbd1.Click

    End Sub

    Private Sub pbad1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbad1.Click

    End Sub

    Private Sub pbad7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbad7.Click

    End Sub

    Private Sub pbbi6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbbi6.Click

    End Sub

    Private Sub pbbi7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbbi7.Click

    End Sub

    Private Sub pbbi8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbbi8.Click

    End Sub

    Private Sub pbbd6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbbd6.Click

    End Sub
End Class