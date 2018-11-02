Public Class frmFinanzas
    Dim fecha As Date = Now.Date
    Public fechad As Date
    Public fechah As Date


    Private Sub finanzas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        fechad = DateSerial(Year(fecha), Month(fecha), 1)
        desde.Value = fechad

        fechah = DateSerial(Year(fecha), Month(fecha) + 1, 0)
        hasta.Value = fechah

        'Establezco como debe cargar el txbBusqueda
        txbBusqueda.ForeColor = Color.Gray
        txbBusqueda.Text = "Buscar"

        actTabla("Buscar")

    End Sub


    Private Sub desde_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles desde.ValueChanged
        actTabla(txbBusqueda.Text)
    End Sub

    Private Sub hasta_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles hasta.ValueChanged
        actTabla(txbBusqueda.Text)
    End Sub
    Public Sub actTabla(ByVal nombrePaciente As String)

        If nombrePaciente = "Buscar" Then
            Try
                fechad = desde.Text
                fechah = hasta.Text

                Consulta = "select fecha as 'Fecha de Pago', pago as 'Cantidad Depositada ($)'  ,cedula as 'Cedula',  concat(upper(left(apellido,1)), lower(substring(apellido from 2))) as 'Apellido', concat(upper(left(nombre,1)), lower(substring(nombre from 2))) as 'Nombre' from recibo r inner join paciente p on p.id_p = r.id_p where fecha <= '" + fechah.ToString("yyyy-MM-dd") + "' and fecha >= '" + fechad.ToString("yyyy-MM-dd") + "';"
                consultar()

                dgvPagos.DataSource = Tabla
                dgvPagos.Columns(0).HeaderText = "Fecha de Pago"
                dgvPagos.Columns(1).HeaderText = "Cantidad Depositada ($)"
                dgvPagos.Columns(2).HeaderText = "Cédula"
                dgvPagos.Columns(3).HeaderText = "Apellido"
                dgvPagos.Columns(4).HeaderText = "Nombre"

                Dim suma As Long = 0
                If Not IsDBNull(dgvPagos.Rows(0).Cells(0).Value) Then

                    Label4.Text = ""
                    For x As Integer = 0 To dgvPagos.RowCount - 1

                        suma += dgvPagos.Rows(x).Cells(1).Value

                    Next
                End If

                monto.Text = "$"
                monto.Text += suma.ToString

            Catch ex As Exception

                Label4.Text = "No hay pagos en esas fechas"

            End Try

        Else
            Try


                fechad = desde.Text
                fechah = hasta.Text
                Consulta = "select fecha as 'Fecha de Pago', pago as 'Cantidad Depositada ($)'  ,cedula as 'Cedula',  concat(upper(left(apellido,1)), lower(substring(apellido from 2))) as 'Apellido', concat(upper(left(nombre,1)), lower(substring(nombre from 2))) as 'Nombre' from recibo r inner join paciente p on p.id_p = r.id_p where fecha <= '" + fechah.ToString("yyyy-MM-dd") + "' and fecha >= '" + fechad.ToString("yyyy-MM-dd") + "' and (cedula like '" + txbBusqueda.Text + "%' or nombre like '" + txbBusqueda.Text + "%' or apellido like '" + txbBusqueda.Text + "%');"
                consultar()

                dgvPagos.DataSource = Tabla

                Dim suma As Integer = 0
                If Not IsDBNull(dgvPagos.Rows(0).Cells(0).Value) Then

                    Label4.Text = ""
                    For x As Integer = 0 To dgvPagos.RowCount - 1

                        suma += dgvPagos.Rows(x).Cells(1).Value

                    Next
                End If

                monto.Text = "$"
                monto.Text += suma.ToString
            Catch ex As Exception

                Label4.Text = "No hay pagos en esas fechas"

            End Try
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        frmContenedor = frmRealizarPago
        frmContenedor.MdiParent = frmMenuInicio
        frmContenedor.Dock = DockStyle.Fill
        frmContenedor.Show()


    End Sub

    Private Sub txbBusqueda_Click(ByVal sender As Object, ByVal e As System.EventArgs)

        'Si el contenido de txbBusqueda es Buscar y de color gris
        If txbBusqueda.Text = "Buscar" And txbBusqueda.ForeColor = Color.Gray Then

            'El cursos se ubique al inicio
            Me.txbBusqueda.SelectionStart = 0

        End If

    End Sub

    Private Sub txbBusqueda_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)

        'Si el contenido de txbBusqueda es Buscar y de color gris
        If txbBusqueda.Text = "Buscar" And txbBusqueda.ForeColor = Color.Gray Then

            'El cursos se ubique al inicio
            txbBusqueda.SelectionStart = 0

        End If

    End Sub

    Private Sub txbBusqueda_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

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
            actTabla("Buscar")

            'Si la tecla presionada es borrar y todo el texto esta seleccionado
        ElseIf e.KeyCode = Keys.Back And txbBusqueda.SelectedText = txbBusqueda.Text Then

            'Introduzco el texto 'Buscar' al txbBusqueda de color Gris
            txbBusqueda.Text = "Buscar"
            txbBusqueda.ForeColor = Color.Gray
            actTabla("Buscar")

        End If
    End Sub

    Private Sub txbBusqueda_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        actTabla(txbBusqueda.Text)
    End Sub
End Class