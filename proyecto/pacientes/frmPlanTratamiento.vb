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
        txbBusqueda.ForeColor = Color.Gray
        txbBusqueda.Text = "Buscar"

        actAranceles()
        actArancelesSelect()

    End Sub

    Private Sub dgvAranceles_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvAranceles.CellClick
        btnMover.Visible = True
        btnEliminar.Visible = False
        btnModificarPrecio.Visible = False
        btnModificarDesc.Visible = False
        btnMarcar.Visible = False
    End Sub

    Private Sub dgvAranceles_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgvAranceles.MouseDoubleClick
        btnMover.Visible = True
        btnMover.PerformClick()

    End Sub

    Private Sub dgvArancelesSelect_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvArancelesSelect.CellClick

        id_Arancel = dgvArancelesSelect.CurrentRow.Cells(0).Value
        descEsp = dgvArancelesSelect.CurrentRow.Cells(3).Value

        btnEliminar.Visible = True
        btnModificarPrecio.Visible = True
        btnModificarDesc.Visible = True
        btnMarcar.Visible = True
        btnMover.Visible = False
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
       

        If dgvArancelesSelect.CurrentRow.Cells(4).Value.ToString <> "" Then
            Try

                Dim id As String = dgvArancelesSelect.CurrentRow.Cells(4).Value.ToString

                Consulta = "DELETE FROM plan_tratamiento where id_pl = '" + id + "';"
                consultar()

                actArancelesSelect()

                Consulta = "UPDATE paciente set saldo = saldo - " + (dgvArancelesSelect.CurrentRow.Cells(2).Value * 1.22).ToString + " where id_p = '" + id_p.ToString + "';"
                consultar()

                MsgBox("Elemento eliminado", MsgBoxStyle.Information)

            Catch ex As Exception

                MsgBox("Error al eliminar el tratamiento", MsgBoxStyle.Exclamation)
            End Try


        Else

            dgvArancelesSelect.Rows.RemoveAt(dgvArancelesSelect.CurrentRow.Index)
            MsgBox("Elemento eliminado", MsgBoxStyle.Information)
        End If

        If dgvArancelesSelect.RowCount = 0 Then

            btnEliminar.Visible = False
            btnModificarPrecio.Visible = False
            btnModificarDesc.Visible = False
            btnMarcar.Visible = False
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
    Private Sub txbBusqueda_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txbBusqueda.Click

        'Si el contenido de txbBusqueda es Buscar y de color gris
        If txbBusqueda.Text = "Buscar" And txbBusqueda.ForeColor = Color.Gray Then

            'El cursos se ubique al inicio
            Me.txbBusqueda.SelectionStart = 0

        End If

    End Sub

    Private Sub txbBusqueda_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txbBusqueda.GotFocus

        'Si el contenido de txbBusqueda es Buscar y de color gris
        If txbBusqueda.Text = "Buscar" And txbBusqueda.ForeColor = Color.Gray Then

            'El cursos se ubique al inicio
            txbBusqueda.SelectionStart = 0

        End If

    End Sub

    Private Sub txbBusqueda_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txbBusqueda.KeyDown

        'Si el contenido de txbBusqueda es Buscar, de color gris y la tecla presionada no es 
        If txbBusqueda.Text = "Buscar" And txbBusqueda.ForeColor = Color.Gray And Not e.KeyCode = Keys.Back Then

            'Borrar el contenido del txbBusqueda y volver el color negro
            txbBusqueda.Text = ""
            txbBusqueda.ForeColor = Color.Black


            'Si txbBusqueda solo tiene una letra y la tecla presionada fue borrar, 
        ElseIf e.KeyCode = Keys.Back And txbBusqueda.Text.Length = 1 Then

            'Introduzco el texto 'Buscar' al txbBusqueda de color Gris
            txbBusqueda.Text = "Buscar"
            txbBusqueda.ForeColor = Color.Gray
            actAranceles()

            'Si la tecla presionada es borrar y todo el texto esta seleccionado
        ElseIf e.KeyCode = Keys.Back And txbBusqueda.SelectedText = txbBusqueda.Text Then

            'Introduzco el texto 'Buscar' al txbBusqueda de color Gris
            txbBusqueda.Text = "Buscar"
            txbBusqueda.ForeColor = Color.Gray
            actAranceles()

        End If
    End Sub

    Private Sub txbBusqueda_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txbBusqueda.LostFocus

        If txbBusqueda.Text.Length = 0 Or (txbBusqueda.Text = "Buscar" And txbBusqueda.ForeColor = Color.Gray) Then
            txbBusqueda.ForeColor = Color.Gray
            txbBusqueda.Text = "Buscar"
            actAranceles()
        End If

    End Sub
    Private Sub actAranceles()

        Try
            Consulta = "Select id_a, descripcion as 'Descripcion', costo as 'Precio' from aranceles where estado = 1;"
            consultar()
            dgvAranceles.DataSource = Tabla

            If Not IsDBNull(dgvAranceles.Rows(0).Cells(0).Value) Then
                dgvAranceles.Columns(0).Visible = False
            End If

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


        Catch ex As Exception
            MsgBox("Error al obtener los aranceles previamente seleccionados", MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub txbBusqueda_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txbBusqueda.TextChanged

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

                    Consulta = "update plan_tratamiento set descripcion = '" + dgvArancelesSelect.Rows(x).Cells(3).Value + "', set precio = '" + dgvArancelesSelect.Rows(x).Cells(2).Value.ToString + "' where id_pl = '" + dgvArancelesSelect.Rows(x).Cells(4).Value.ToString + "';"
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

            Me.Dispose()
            frmMarcarCitaConcluida.actPlan()
            frmMarcarCitaConcluida.Show()

        Catch ex As Exception

            MsgBox("Error al crear registro de aranceles" + ex.ToString, MsgBoxStyle.Exclamation)

        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificarDesc.Click
        MuestraMsgBoxVersatil("Ingrese la nueva descripcion del Arancel", 1)

        dgvArancelesSelect.CurrentRow.Cells(3).Value = respString

    End Sub



    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMarcar.Click
        If dgvArancelesSelect.CurrentRow.Cells(1).Value <> "" Then

            MuestraMsgBoxVersatil("¿Desea marcar como concluido el tratamiento sobre " + dgvArancelesSelect.CurrentRow.Cells(3).Value + "?", 0)
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
End Class