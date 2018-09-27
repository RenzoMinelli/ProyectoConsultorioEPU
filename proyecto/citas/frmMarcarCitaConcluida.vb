Public Class frmMarcarCitaConcluida
    Dim id_r As Integer
    Private Sub MarcarCitaConcluida_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            
            actPlan()

            Consulta = "select descripcion from cita where id_c = '" + frmCitas.idcita.ToString + "';"
            consultar()
            dgvAuxiliar.DataSource = Tabla

            txbAnotaciones.Text = dgvAuxiliar.Rows(0).Cells(0).Value
        Catch ex As Exception

        End Try
    End Sub
    Private Sub dgvAranceles_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvTratamientos.CellDoubleClick

        MuestraMsgBoxVersatil("¿Desea marcar este tratamiento como concluido?", 0)

        If respint = 0 Then

            MsgBox("Ningún cambio ha sido realizado", MsgBoxStyle.Information)

        Else


        End If

    End Sub

    


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Try

            Consulta = "update cita set atendida = 1 where id_c = '" + frmCitas.idcita.ToString + "';"
            consultar()

            If txbRealizado.Text <> "" Then

                Consulta = "update cita set descripcion = '" + txbRealizado.Text + "' where id_c = '" + frmCitas.idcita.ToString + "';"
                consultar()

            End If

            MsgBox("Guardado con éxito", MsgBoxStyle.Information)
            Me.Dispose()
            frmCitas.Show()

        Catch ex As Exception
            MsgBox("Error al guardar la cita", MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Dispose()
        frmCitas.Show()
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Me.Hide()
        frmContenedor = frmPlanTratamiento
        frmContenedor.MdiParent = frmMenuInicio
        frmContenedor.Dock = DockStyle.Fill
        frmContenedor.Show()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Do

            MuestraMsgBoxVersatil("Ingrese el monto a cobrar", 2)

            If respint = 2 Then
                MsgBox("No se ha cobrado nada", MsgBoxStyle.Information)
                respString = "0"
            Else

                If Not IsNumeric(respString) Then

                    MsgBox("El monto debe ser solo números", MsgBoxStyle.Exclamation)

                End If


            End If

        Loop While IsNumeric(respString) = False

        If respint = 1 Then

            Try

                Consulta = "update paciente set saldo = saldo + '" + respString + "' where id_p = '" + id_p.ToString + "';"
                consultar()

                Consulta = "insert into plan_tratamiento (id_p, id_c, descripcion, precio, terminado) values ('" + id_p.ToString + "', '" + frmCitas.idcita.ToString + "', 'Limpieza', '" + respString + "', 1);"
                consultar()

                MsgBox("Cobrado con éxito", MsgBoxStyle.Information)

            Catch ex As Exception
                MsgBox("Error al cobrar", MsgBoxStyle.Exclamation)
            End Try



        End If

    End Sub
    Public Sub actPlan()

        Try

            Consulta = "select a.descripcion as 'Descripcion General', pl.descripcion as 'Descripcion Especifica' from plan_tratamiento pl inner join aranceles a on pl.id_a = a.id_a where id_p = '" + id_p.ToString + "' and terminado = 0;"
            consultar()
            dgvTratamientos.DataSource = Tabla

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnEstado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEstado.Click
        Me.Hide()
        frmContenedor = pnlfondo
        frmContenedor.MdiParent = frmMenuInicio
        frmContenedor.Dock = DockStyle.Fill
        frmContenedor.Show()
    End Sub
End Class