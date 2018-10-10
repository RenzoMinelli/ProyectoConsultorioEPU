

Public Class frmRegistroMedico
    Dim formu As New Form
    Dim i As Integer = 0
    'Create DataGridViewPrinter type variable  

    Private Sub Registro_Medico_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load



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

        pnlDiente32c2.MakeTriangular(TriangleDirection.Up)
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



        actBoca()

        actTabla()

        cbSeleccion.SelectedIndex = 0
        cbTratamientos.SelectedIndex = 1
    End Sub
    
    Private Sub cargar()
        dgvRegistroMedico.DataSource = Nothing

        Dim vista As New DataGridViewImageColumn
        vista.Name = "vista"
        vista.ImageLayout = DataGridViewImageCellLayout.Normal
        dgvRegistroMedico.Columns.Add(vista)

        Dim filas As Integer
        Dim ruta As String

        Try
            Consulta = ("SELECT  nombre, descripcion FROM documentos where id_p = '" + id_p.ToString + "'")
            consultar()

            dgvRegistroMedico.DataSource = Tabla
            dgvRegistroMedico.Columns(1).Visible = False
            filas = dgvRegistroMedico.Rows.Count - 1
            For i As Integer = 0 To filas
                ruta = dgvRegistroMedico.Rows(i).Cells(1).Value.ToString()
                dgvRegistroMedico.Rows(i).Cells(0).Value = System.Drawing.Image.FromFile(rutaGuardadoFotos + "\" + dgvRegistroMedico.Rows(i).Cells(1).Value.ToString())
                dgvRegistroMedico.Rows(i).Height = 10

            Next
            dgvRegistroMedico.Columns(0).Width = 300
        Catch ex As Exception
            MsgBox("Error al obtener las imagenes", MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub actBoca()
        Try

            Consulta = "select * from estado_dientes where id_p = '" + id_p.ToString + "' order by id_e asc;"
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

                End Select


            Next
        Catch ex As Exception
            MsgBox("No hay datos dientes")
        End Try

    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Dispose()
        frmPacientes.Show()
    End Sub

    Private Sub actTabla()
        Try
            Try
                dgvRegistroMedico.Columns.Remove("vista")
            Catch ex As Exception

            End Try
            Consulta = "Select descripcion, fecha, hora, atendida from cita where id_p = '" + Str(id_p) + "' order by fecha desc;"
            consultar()

            dgvRegistroMedico.DataSource = Tabla

            dgvRegistroMedico.Columns(0).HeaderText = "Descripcion"
            dgvRegistroMedico.Columns(1).HeaderText = "Fecha"
            dgvRegistroMedico.Columns(2).HeaderText = "Hora"



        Catch ex As Exception

        End Try

    End Sub



    Private Sub cbSeleccion_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbSeleccion.SelectedIndexChanged

        If cbSeleccion.SelectedIndex = 0 Then
            actTabla()
        ElseIf cbSeleccion.SelectedIndex = 1 Then
            cargar()


        End If
    End Sub


    Private Sub btnMostrarPlaca_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMostrarPlaca.Click

        frmMenuInicio.Hide()
        frmMuestraPlaca.Show()

        'frmMuestraPlaca.PictureBox1.ImageLocation = rutaGuardadoFotos + "\" + dgvRegistroMedico.CurrentRow.Cells(1).Value.ToString()
        'Label5.Text = "" + dgvRegistroMedico.CurrentRow.Cells(2).Value


    End Sub

    Private Sub dgvRegistroMedico_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgvRegistroMedico.MouseClick
        If cbSeleccion.SelectedIndex = 1 Then

            btnMostrarPlaca.Show()
        End If


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

        End If
    End Sub

    Private Sub dgvAuxiliar_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvAuxiliar.CellContentClick

    End Sub
End Class
