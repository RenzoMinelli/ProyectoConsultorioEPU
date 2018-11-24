Public Class frmRealizarPago
    Public id As Integer
    Private Sub realizar_pago_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        actTabla()
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        id = DataGridView1.CurrentRow.Cells(0).Value
        Button1.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        inputboxcasero.Show()



    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Dispose()
        frmFinanzas.Show()
        frmFinanzas.actTabla()
    End Sub
    Public Sub actTabla()
        Try
            Consulta = "select id_p , concat(upper(left(apellido,1)), lower(substring(apellido from 2))) as 'apellido', concat(upper(left(nombre,1)), lower(substring(nombre from 2))) as 'nombre' , cedula , saldo from paciente where nombre like '" + txbBuscar.Text + "%' or apellido like '" + txbBuscar.Text + "%' or cedula like '" + txbBuscar.Text + "%';"
            consultar()
            DataGridView1.DataSource = Tabla
            DataGridView1.ClearSelection()

            DataGridView1.Columns(0).Visible = False
            DataGridView1.Columns(1).HeaderText = "Apellido"
            DataGridView1.Columns(2).HeaderText = "Nombre"
            DataGridView1.Columns(3).HeaderText = "Cédula"
            DataGridView1.Columns(4).HeaderText = "Saldo"
            Button1.Hide()
            DataGridView1.Columns(0).Width = 300

            DataGridView1.Columns(1).Width = 300

            DataGridView1.Columns(2).Width = 310

            DataGridView1.Columns(3).Width = 310

            DataGridView1.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 15)
        Catch ex As Exception
            MsgBox("Error al cargar los pacientes", MsgBoxStyle.Exclamation)
        End Try
       
    End Sub


    Private Sub txbBuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txbBuscar.TextChanged
        actTabla()
    End Sub
End Class