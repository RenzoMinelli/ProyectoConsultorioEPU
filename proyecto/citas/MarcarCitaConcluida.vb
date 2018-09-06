Public Class MarcarCitaConcluida
    Dim id_r As Integer
    Private Sub MarcarCitaConcluida_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Consulta = "Select r.id_r, r.id_p, a.descripcion as 'Descripcion General',r.precio as 'Precio',r.descripcion as 'Descripcion Especifica', r.id_a from registro_medico r left join aranceles a on r.id_a = a.id_a where r.id_c = '" + Citas.idcita.ToString + "';"
            consultar()
            dgvAranceles.DataSource = Tabla

            dgvAranceles.Columns(0).Visible = False
            dgvAranceles.Columns(1).Visible = False
            dgvAranceles.Columns(5).Visible = False



        Catch ex As Exception
            MsgBox("No hay aranceles marcados", MsgBoxStyle.Exclamation)
        End Try
    End Sub
    Private Sub dgvAranceles_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvAranceles.CellDoubleClick

        id_r = dgvAranceles.CurrentRow.Cells(0).Value
        Dim verificacion As Integer = 0

        For X = 0 To dgvArancelesSelect.RowCount - 1

            If dgvArancelesSelect.Rows(X).Cells(5).Value = id_r Then

                verificacion = 1

            End If
        Next
        If verificacion = 0 Then
            Try
                Consulta = "Select  r.id_p,  a.descripcion as 'Descripcion General',r.precio as 'Precio',r.descripcion as 'Descripcion Especifica',r.id_a, id_r from registro_medico r inner join aranceles a on r.id_a = a.id_a where id_r = '" + id_r.ToString + "';"
                consultar()

                dgvAuxiliar.DataSource = Tabla

                dgvArancelesSelect.ColumnCount = 6
                dgvArancelesSelect.Columns(0).HeaderText = "ID_P"
                dgvArancelesSelect.Columns(3).HeaderText = "Descripcion Especifica"
                dgvArancelesSelect.Columns(2).HeaderText = "Precio"
                dgvArancelesSelect.Columns(1).HeaderText = "Descripcion General"
                dgvArancelesSelect.Columns(4).HeaderText = "ID_A"
                dgvArancelesSelect.Columns(5).HeaderText = "ID_R"

                dgvArancelesSelect.Columns(0).Visible = False
                dgvArancelesSelect.Columns(4).Visible = False
                dgvArancelesSelect.Columns(5).Visible = False

                dgvArancelesSelect.Rows.Add(dgvAuxiliar.Rows(0).Cells(0).Value, dgvAuxiliar.Rows(0).Cells(1).Value, dgvAuxiliar.Rows(0).Cells(2).Value, dgvAuxiliar.Rows(0).Cells(3).Value, dgvAuxiliar.Rows(0).Cells(4).Value, dgvAuxiliar.Rows(0).Cells(5).Value)


            Catch ex As Exception

                MsgBox("Error al mover arancel" + ex.ToString, MsgBoxStyle.Exclamation)

            End Try
        Else
            MsgBox("Este Arancel ya fue marcado como realizado en la cita", MsgBoxStyle.Exclamation)
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

            If dgvArancelesSelect.Rows(x).Cells(0).Value = id_r Then

                dgvArancelesSelect.Rows.RemoveAt(x)

                Exit For

            End If
        Next
        If dgvArancelesSelect.RowCount = 0 Then

            btnEliminar.Visible = False
            btnModificarPrecio.Visible = False

        End If
    End Sub

    Private Sub dgvArancelesSelect_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvArancelesSelect.CellClick

        id_r = dgvArancelesSelect.CurrentRow.Cells(0).Value
        btnEliminar.Visible = True
        btnModificarPrecio.Visible = True
        btnIngresarDesc.Visible = True

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Try
            Dim costo As Integer = 0
            For x = 0 To dgvArancelesSelect.RowCount - 1
                Consulta = "Insert into registro_medico (id_p, descripcion, precio, id_c, id_a) values ('" + dgvArancelesSelect.Rows(x).Cells(0).Value.ToString + "','" + dgvArancelesSelect.Rows(x).Cells(3).Value.ToString + "','" + dgvArancelesSelect.Rows(x).Cells(2).Value.ToString + "','" + Citas.idcita.ToString + "','" + dgvArancelesSelect.Rows(x).Cells(4).Value.ToString + "' );"
                consultar()
                costo += dgvArancelesSelect.Rows(x).Cells(2).Value
            Next

            Try
                Consulta = "update paciente set saldo += '" + costo.ToString + "' where id_p = '" + dgvArancelesSelect.Rows(0).Cells(0).Value.ToString + "';"
                consultar()

                Consulta = "update cita set realizada = 1 where id_c = '" + Citas.idcita.ToString + "';"
                consultar()

                MsgBox("Guardado con éxito", MsgBoxStyle.Information)
                Me.Dispose()
                Citas.Show()
            Catch ex As Exception

                MsgBox("Error al aumentar el saldo del paciente", MsgBoxStyle.Exclamation)

            End Try

        Catch ex As Exception
            MsgBox("Error al registrar los aranceles utilizados", MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Dispose()
        Citas.Show()
    End Sub
End Class