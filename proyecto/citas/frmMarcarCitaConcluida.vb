Public Class frmMarcarCitaConcluida
    Dim id_r As Integer
    Private Sub MarcarCitaConcluida_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            Consulta = "select a.descripcion as 'Descripcion General', pl.descripcion as 'Descripcion Especifica' from plan_tratamiento pl inner join aranceles a on pl.id_a = a.id_a where id_p = '" + id_p.ToString + "';"
            consultar()
            dgvTratamientos.DataSource = Tabla
        Catch ex As Exception

        End Try
    End Sub
    Private Sub dgvAranceles_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvTratamientos.CellDoubleClick

      


    End Sub

    


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Try
            Dim costo As Integer = 0
            ' For x = 0 To dgvAranceles.RowCount - 1
            '  Consulta = "Insert into registro_medico (id_p, descripcion, precio, id_c, id_a) values ('" + dgvAranceles.Rows(x).Cells(0).Value.ToString + "','" + dgvAranceles.Rows(x).Cells(3).Value.ToString + "','" + dgvAranceles.Rows(x).Cells(2).Value.ToString + "','" + frmCitas.idcita.ToString + "','" + dgvAranceles.Rows(x).Cells(4).Value.ToString + "' );"
            'consultar()
            ' costo += dgvAranceles.Rows(x).Cells(2).Value
            ' Next

            Try
                ' Consulta = "select saldo from paciente where id_p = '" + dgvAranceles.Rows(0).Cells(0).Value.ToString + "';"
                ' consultar()

                Dim dgvA As New DataGridView
                dgvA.DataSource = Tabla

                'Consulta = "update paciente set saldo = '" + (dgvA.Rows(0).Cells(0).Value + costo).ToString + "' where id_p = '" + dgvAranceles.Rows(0).Cells(0).Value.ToString + "';"
                consultar()

                Consulta = "update cita set realizada = 1 where id_c = '" + frmCitas.idcita.ToString + "';"
                consultar()

                MsgBox("Guardado con éxito", MsgBoxStyle.Information)
                Me.Dispose()
                frmCitas.Show()
            Catch ex As Exception

                MsgBox("Error al aumentar el saldo del paciente" + ex.ToString, MsgBoxStyle.Exclamation)

            End Try

        Catch ex As Exception
            MsgBox("Error al registrar los aranceles utilizados", MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Dispose()
        frmCitas.Show()
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Me.Hide()
        frmContenedor = frmPlanTratamiento
        frmContenedor.MdiParent = Menu_Inicio
        frmContenedor.Dock = DockStyle.Fill
        frmContenedor.Show()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Do

            MuestraMsgBoxVersatil("Ingrese el monto a cobrar", 2)

            If respint = 2 Then
                MsgBox("No se ha cobrado nada", MsgBoxStyle.Information)
            Else

                If Not IsNumeric(respString) Then

                    MsgBox("El monto debe ser solo números", MsgBoxStyle.Exclamation)

                End If

            
            End If

        Loop While IsNumeric(respString) = False

        If respint = 1 Then


        End If

    End Sub
End Class