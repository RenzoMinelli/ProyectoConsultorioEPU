Imports System.Data.SqlClient
Imports System.Drawing.Printing

Public Class frmPlanTratamiento
    Dim id_Arancel As Integer
    Dim listaID_R As New List(Of Integer)
    Dim descEsp As String
    Dim dt As DataTable
    Dim MyDataGridViewPrinter As DataGridViewPrinter

    Private Sub PlanTratamiento_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnMover.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
       

        actAranceles()
        actArancelesSelect()
        dgvAranceles.Columns(2).Width = 100
        Consulta = "select concat(upper(left(apellido,1)), lower(substring(apellido from 2))) as 'apellido', concat(upper(left(nombre,1)), lower(substring(nombre from 2))) as 'nombre' from paciente where id_p = '" + id_p.ToString + "';"
        consultar()
        For Each row In Tabla.Rows
            frmPacientes.nombre = row(1)
            frmPacientes.apellido = row(0)
        Next
        frmMenuInicio.lblNombreP.Text = "Paciente Seleccionado: " + frmPacientes.nombre + " " + frmPacientes.apellido
    End Sub

    Private Sub dgvAranceles_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvAranceles.CellClick
        btnMover.Enabled = True
        btnEliminar.Enabled = False
        btnModificarPrecio.Enabled = False
        btnModificarDesc.Enabled = False
        btnMarcar.Enabled = False
    End Sub

    Private Sub dgvAranceles_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgvAranceles.MouseDoubleClick
        btnMover.Visible = True
        btnMover.PerformClick()

    End Sub

    Private Sub dgvArancelesSelect_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvArancelesSelect.CellClick

        id_Arancel = dgvArancelesSelect.CurrentRow.Cells(0).Value
        descEsp = dgvArancelesSelect.CurrentRow.Cells(3).Value

        btnEliminar.Enabled = True
        btnModificarPrecio.Enabled = True
        btnModificarDesc.Enabled = True
        btnMarcar.Enabled = True
        btnMover.Enabled = False
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        MuestraMsgBoxVersatil("¿Desea eliminar el tratamiento " + dgvArancelesSelect.CurrentRow.Cells(1).Value.ToString + "?", 0)
        If respint = 1 Then
            If dgvArancelesSelect.CurrentRow.Cells(4).Value.ToString <> "" Then
                Try

                    Dim id As String = dgvArancelesSelect.CurrentRow.Cells(4).Value.ToString

                    Consulta = "UPDATE paciente set saldo = saldo - " + (dgvArancelesSelect.CurrentRow.Cells(2).Value * 1.22).ToString + " where id_p = '" + id_p.ToString + "';"
                    consultar()

                    Consulta = "DELETE FROM plan_tratamiento where id_pl = '" + id + "';"
                    consultar()

                    dgvArancelesSelect.Rows.RemoveAt(dgvArancelesSelect.CurrentRow.Index)

                    MsgBox("Elemento eliminado", MsgBoxStyle.Information)

                Catch ex As Exception

                    MsgBox("Error al eliminar el tratamiento" + ex.ToString, MsgBoxStyle.Exclamation)
                End Try


            Else


                MsgBox("Elemento eliminado", MsgBoxStyle.Information)
            End If

            If dgvArancelesSelect.RowCount = 0 Then

                btnEliminar.Enabled = False
                btnModificarPrecio.Enabled = False
                btnModificarDesc.Enabled = False
                btnMarcar.Enabled = False
            End If
        Else
            MsgBox("Ningún cambio fue realizado", MsgBoxStyle.Information)
        End If
       
    End Sub

    Private Sub btnModificarPrecio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificarPrecio.Click

        Do
            MuestraMsgBoxVersatil("Ingrese el nuevo costo del Arancel", 2)
            If respint = 2 Then
                MsgBox("Ningún cambio fue realizado", MsgBoxStyle.Information)
                Exit Do
            Else
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
            End If
          

            MsgBox("Debe ingresar solo números", MsgBoxStyle.Exclamation)
        Loop While Not IsNumeric(respString)




    End Sub
   



  
    Private Sub actAranceles()

        Try
            Consulta = "Select id_a, descripcion as 'Descripcion', costo as 'Precio' from aranceles where estado = 1 ;"
            consultar()
            dgvAranceles.DataSource = Tabla

            dgvAranceles.Columns(0).Visible = False
            dgvAranceles.Columns(1).HeaderText = "Descripción"

            dgvAranceles.Columns(2).Width = 100
        Catch ex As Exception
            MsgBox("Error al cargar los aranceles", MsgBoxStyle.Exclamation)
        End Try

    End Sub
    Private Sub actArancelesSelect()
        Try

            Consulta = "select  a.id_a, a.descripcion as 'Descripcion General', a.costo as 'Precio', pl.descripcion as 'Descripcion Especifica', pl.id_pl from plan_tratamiento pl inner join aranceles a on a.id_a = pl.id_a where  id_p = '" + id_p.ToString + "' and terminado = 0"
            consultar()

            dt = DirectCast(Tabla, DataTable)
            dgvArancelesSelect.DataSource = dt


            dgvArancelesSelect.Columns(0).Visible = False
            dgvArancelesSelect.Columns(4).Visible = False


            For indice = 0 To dgvArancelesSelect.RowCount - 1
                listaID_R.Add(dgvArancelesSelect.Rows(indice).Cells(4).Value)
            Next

            dgvArancelesSelect.Columns(1).HeaderText = "Descripción General"
            dgvArancelesSelect.Columns(2).HeaderText = "Precio"
            dgvArancelesSelect.Columns(3).HeaderText = "Descripción Específica"


        Catch ex As Exception
            MsgBox("Error al obtener los aranceles previamente seleccionados", MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub txbBusqueda_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Try
            Consulta = "Select id_a, descripcion as 'Descripcion', costo as 'Precio' from aranceles where estado = 1 and descripcion like '" + txbBusqueda.Text + "%';"
            consultar()
            dgvAranceles.DataSource = Tabla

            If Not IsDBNull(dgvAranceles.Rows(0).Cells(0).Value) Then
                dgvAranceles.Columns(0).Visible = False
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click

        Try
            For x = 0 To dgvArancelesSelect.RowCount - 1

                If listaID_R.Contains(dgvArancelesSelect.Rows(x).Cells(4).Value) Then

                    Consulta = "update plan_tratamiento set descripcion = '" + dgvArancelesSelect.Rows(x).Cells(3).Value + "', precio = '" + dgvArancelesSelect.Rows(x).Cells(2).Value.ToString + "' where id_pl = '" + dgvArancelesSelect.Rows(x).Cells(4).Value.ToString + "';"
                    consultar()

                    listaID_R.Remove(dgvArancelesSelect.Rows(x).Cells(4).Value)
                Else

                    Consulta = "Insert into plan_tratamiento (id_p,id_a, id_c, descripcion, precio,terminado ) values ('" + id_p.ToString + "','" + dgvArancelesSelect.Rows(x).Cells(0).Value.ToString + "','" + frmCitas.idcita.ToString + "', '" + dgvArancelesSelect.Rows(x).Cells(3).Value + "', '" + dgvArancelesSelect.Rows(x).Cells(2).Value.ToString + "','0');"
                    consultar()

                    Consulta = "update paciente set saldo = saldo + '" + (dgvArancelesSelect.Rows(x).Cells(2).Value * 1.22).ToString + "' where id_p = '" + id_p.ToString + "';"
                    consultar()

                End If

            Next


            MsgBox("Guardado con éxito", MsgBoxStyle.Information)
            If ver = 1 Then
                frmPacientes.Show()
                frmPacientes.actTabla(frmPacientes.EstadoPacientes)
                frmPacientes.actPanel()
            Else
                frmMarcarCitaConcluida.actPlan()
                frmMarcarCitaConcluida.Show()
            End If
            Me.Dispose()
           

        Catch ex As Exception

            MsgBox("Error al crear registro de aranceles" + ex.ToString, MsgBoxStyle.Exclamation)

        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificarDesc.Click
        MuestraMsgBoxVersatil("Ingrese la nueva descripcion del Arancel", 2)
        If respint = 1 Then
            dgvArancelesSelect.CurrentRow.Cells(3).Value = respString
        Else
            MsgBox("Ningún cambio fue realizado", MsgBoxStyle.Information)
        End If


    End Sub



    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMarcar.Click
        If dgvArancelesSelect.CurrentRow.Cells(1).Value <> "" Then

            MuestraMsgBoxVersatil("¿Desea marcar como concluido el tratamiento " + dgvArancelesSelect.CurrentRow.Cells(1).Value + "?", 0)
            If respint = 1 Then
                Consulta = "update plan_tratamiento set terminado = '1' where id_pl = '" + dgvArancelesSelect.CurrentRow.Cells(4).Value.ToString + "';"
                consultar()
                actArancelesSelect()

                MsgBox("Actualizado", MsgBoxStyle.Information)
            Else
                MsgBox("Ningún cambio fue realizado", MsgBoxStyle.Information)
            End If
        Else
            MsgBox("Aún no se ha guardado al plan de tratamiento", MsgBoxStyle.Information)
        End If
        
    End Sub
    Private Sub btnPresupuesto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPresupuesto.Click
        Try
            Consulta = "select a.descripcion as 'Descrpcion General', pl.descripcion as 'Descripcion Especifica', precio as 'Precio' from aranceles a inner join plan_tratamiento pl on pl.id_a = a.id_a where id_p = '" + id_p.ToString + "' and terminado = 0 "
            consultar()
            dgvAuxiliar.DataSource = Tabla
            Dim total As Integer = 0
            For x = 0 To dgvAuxiliar.RowCount - 1
                total += dgvAuxiliar.Rows(x).Cells(2).Value
            Next
            dgvDatos.ColumnCount = 3
            For x = 0 To dgvAuxiliar.RowCount - 1
                dgvDatos.Rows.Add(dgvAuxiliar.Rows(x).Cells(0).Value.ToString, dgvAuxiliar.Rows(x).Cells(1).Value.ToString, dgvAuxiliar.Rows(x).Cells(2).Value.ToString)
            Next
            dgvDatos.Rows.Add("SUBTOTAL", "", total.ToString)
            dgvDatos.Rows.Add("IVA", "", (total * 0.22).ToString)
            dgvDatos.Rows.Add("TOTAL", "", (total * 1.22).ToString)

            If SetupThePrinting() Then
                PrintDocument1.Print()
            End If


        Catch ex As Exception
            MsgBox("Error al obtener presupuesto", MsgBoxStyle.Exclamation)
        End Try


    End Sub
    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim more As Boolean = MyDataGridViewPrinter.DrawDataGridView(e.Graphics)
        If more = True Then
            e.HasMorePages = True
        End If
    End Sub



    Private Function SetupThePrinting() As Boolean
        Dim MyPrintDialog As PrintDialog = New PrintDialog()
        MyPrintDialog.AllowCurrentPage = False
        MyPrintDialog.AllowPrintToFile = False
        MyPrintDialog.AllowSelection = False
        MyPrintDialog.AllowSomePages = False
        MyPrintDialog.PrintToFile = False
        MyPrintDialog.ShowHelp = False
        MyPrintDialog.ShowNetwork = False

        If MyPrintDialog.ShowDialog() <> DialogResult.OK Then
            Return False
        End If

        PrintDocument1.DocumentName = "Presupuesto"
        PrintDocument1.PrinterSettings = MyPrintDialog.PrinterSettings
        PrintDocument1.DefaultPageSettings = MyPrintDialog.PrinterSettings.DefaultPageSettings
        PrintDocument1.DefaultPageSettings.Margins = New Margins(40, 40, 40, 40)

        MyDataGridViewPrinter = New DataGridViewPrinter(dgvDatos, PrintDocument1, True, True, "Presupuesto", New Font("Tahoma", 25, FontStyle.Bold, GraphicsUnit.Point), Color.Black, True)

        Return True
    End Function

    Private Sub Button1_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click


        Me.Dispose()

        If ver = 1 Then

            frmPacientes.Show()
            ver = 0
        Else

            frmMarcarCitaConcluida.Show()
        End If
        frmMenuInicio.lblNombreP.Text = ""

    End Sub

  
    Private Sub btnMover_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMover.Click

        Dim id_a As Integer = dgvAranceles.CurrentRow.Cells(0).Value

        Try
            Consulta = "Select id_a, descripcion as 'Descripcion', costo as 'Precio' from aranceles where id_a = '" + id_a.ToString + "';"
            consultar()
            dgvAuxiliar.DataSource = Tabla


            dgvArancelesSelect.Columns(0).HeaderText = "id_a"
            dgvArancelesSelect.Columns(1).HeaderText = "Descripcion"
            dgvArancelesSelect.Columns(2).HeaderText = "Precio"
            dgvArancelesSelect.Columns(3).HeaderText = "Descripcion especifica"
            dgvArancelesSelect.Columns(4).HeaderText = "id_pl"

            dgvArancelesSelect.Columns(0).Visible = False
            dgvArancelesSelect.Columns(4).Visible = False

            MuestraMsgBoxVersatil("Ingrese descripcion especifica para el Arancel", 1)

            dt.Rows.Add(dgvAuxiliar.Rows(0).Cells(0).Value, dgvAuxiliar.Rows(0).Cells(1).Value, dgvAuxiliar.Rows(0).Cells(2).Value, respString, 0)

        Catch ex As Exception
            MsgBox("Error al pasar los aranceles", MsgBoxStyle.Exclamation)
        End Try

    End Sub

    Private Sub txbBusqueda_TextChanged1(ByVal sender As Object, ByVal e As System.EventArgs) Handles txbBusqueda.TextChanged
        Try
            Consulta = "Select id_a, descripcion as 'Descripcion', costo as 'Precio' from aranceles where estado = 1 and descripcion like '" + txbBusqueda.Text + "%';"
            consultar()
            dgvAranceles.DataSource = Tabla
            dgvAranceles.Columns(2).Width = 100
             dgvAranceles.Columns(0).Visible = False
            dgvAranceles.Columns(1).HeaderText = "Descripción"

        Catch ex As Exception
            MsgBox("Error al cargar los aranceles", MsgBoxStyle.Exclamation)
        End Try
    End Sub
End Class