Public Class frmMarcarProximaCitaAranceles
    Dim id_pl As Integer

    Private Sub MarcarCosasCitas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Consulta = "Select pl.id_pl, c.id_p, a.descripcion as 'Descripcion General',pl.precio as 'Precio',pl.descripcion as 'Descripcion Especifica', pl.id_a from plan_tratamiento pl inner join aranceles a on pl.id_a = a.id_a inner join cita c on c.id_c = pl.id_c where c.id_p = '" + id_p.ToString + "';"
            consultar()
            dgvAranceles.DataSource = Tabla
            dgvAranceles.Columns(0).Visible = False
            dgvAranceles.Columns(1).Visible = False
            dgvAranceles.Columns(5).Visible = False

        Catch ex As Exception

        End Try


    End Sub

    Private Sub dgvAranceles_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvAranceles.CellDoubleClick

        id_pl = dgvAranceles.CurrentRow.Cells(0).Value

        If dgvArancelesSelect.RowCount = 0 Then

            Try
                Consulta = "Select c.id_p,  a.descripcion as 'Descripcion General', pl.precio as 'Precio',pl.descripcion as 'Descripcion Especifica', pl.id_a, pl.id_pl from plan_tratamiento pl inner join aranceles a on pl.id_a = a.id_a inner join cita c on c.id_c = pl.id_c where id_pl = '" + id_pl.ToString + "';"
                consultar()

                dgvAuxiliar.DataSource = Tabla

                dgvArancelesSelect.ColumnCount = 6
                dgvArancelesSelect.Columns(0).HeaderText = "ID_P"
                dgvArancelesSelect.Columns(3).HeaderText = "Descripcion Especifica"
                dgvArancelesSelect.Columns(2).HeaderText = "Precio"
                dgvArancelesSelect.Columns(1).HeaderText = "Descripcion General"
                dgvArancelesSelect.Columns(4).HeaderText = "ID_A"

                dgvArancelesSelect.Columns(0).Visible = False
                dgvArancelesSelect.Columns(4).Visible = False
                dgvArancelesSelect.Columns(5).Visible = False

                dgvArancelesSelect.Rows.Add(dgvAuxiliar.Rows(0).Cells(0).Value, dgvAuxiliar.Rows(0).Cells(1).Value, dgvAuxiliar.Rows(0).Cells(2).Value, dgvAuxiliar.Rows(0).Cells(3).Value, dgvAuxiliar.Rows(0).Cells(4).Value, dgvAuxiliar.Rows(0).Cells(5).Value)


            Catch ex As Exception

                MsgBox("Error al mover arancel", MsgBoxStyle.Exclamation)

            End Try
        Else

            Dim verificacion As Integer = 0

            For x = 0 To dgvArancelesSelect.RowCount - 1



                If dgvArancelesSelect.Rows(x).Cells(5).Value = id_pl Then

                    verificacion = 1

                End If

            Next

            If verificacion = 0 Then


                Try
                    Consulta = "Select c.id_p,  a.descripcion as 'Descripcion General', pl.precio as 'Precio',pl.descripcion as 'Descripcion Especifica', pl.id_a, pl.id_pl from plan_tratamiento pl inner join aranceles a on pl.id_a = a.id_a inner join cita c on c.id_c = pl.id_c where id_pl = '" + id_pl.ToString + "';"
                    consultar()

                    dgvAuxiliar.DataSource = Tabla

                    dgvArancelesSelect.ColumnCount = 6
                    dgvArancelesSelect.Columns(0).HeaderText = "ID_P"
                    dgvArancelesSelect.Columns(3).HeaderText = "Descripcion Especifica"
                    dgvArancelesSelect.Columns(2).HeaderText = "Precio"
                    dgvArancelesSelect.Columns(1).HeaderText = "Descripcion General"
                    dgvArancelesSelect.Columns(4).HeaderText = "ID_A"

                    dgvArancelesSelect.Columns(0).Visible = False
                    dgvArancelesSelect.Columns(4).Visible = False
                    dgvArancelesSelect.Columns(5).Visible = False

                    dgvArancelesSelect.Rows.Add(dgvAuxiliar.Rows(0).Cells(0).Value, dgvAuxiliar.Rows(0).Cells(1).Value, dgvAuxiliar.Rows(0).Cells(2).Value, dgvAuxiliar.Rows(0).Cells(3).Value, dgvAuxiliar.Rows(0).Cells(4).Value, dgvAuxiliar.Rows(0).Cells(5).Value)


                Catch ex As Exception

                    MsgBox("Error al mover arancel", MsgBoxStyle.Exclamation)

                End Try

            Else

                MsgBox("Ese elemento ya fue marcado", MsgBoxStyle.Exclamation)
            End If
        End If
        


        

    End Sub

    Private Sub btnModificarPrecio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificarPrecio.Click
        Do
            MuestraMsgBoxVersatil("Ingrese el nuevo costo del Arancel", 1)
            If respString = "" Or IsNumeric(respString) Then

                If respString = "" Then
                    dgvArancelesSelect.CurrentRow.Cells(2).Value = "0"
                    respString = "0"
                    Exit Do
                Else
                    dgvArancelesSelect.CurrentRow.Cells(2).Value = respString
                    Exit Do
                End If
            End If

            MsgBox("Debe ingresar solo números", MsgBoxStyle.Exclamation)
        Loop While Not IsNumeric(respString)



    End Sub

    Private Sub btnIngresarDesc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIngresarDesc.Click
        MuestraMsgBoxVersatil("Ingrese la nueva descripcion del Arancel", 1)

        dgvArancelesSelect.CurrentRow.Cells(3).Value = respString
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click



        For x = 0 To dgvArancelesSelect.RowCount - 1

            If dgvArancelesSelect.Rows(x).Cells(0).Value = id_pl Then

                dgvArancelesSelect.Rows.RemoveAt(x)

                Exit For

            End If
        Next
        If dgvArancelesSelect.RowCount = 0 Then

            btnEliminar.Visible = False
            btnModificarPrecio.Visible = False
            btnIngresarDesc.Visible = False

        End If
    End Sub

    Private Sub dgvArancelesSelect_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvArancelesSelect.CellClick

        id_pl = dgvArancelesSelect.CurrentRow.Cells(0).Value


        btnEliminar.Visible = True
        btnModificarPrecio.Visible = True
        btnIngresarDesc.Visible = True

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Me.Hide()

    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Dispose()

    End Sub
End Class