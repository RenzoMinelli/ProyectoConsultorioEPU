Public Class realizar_pago
    Dim id As Integer
    Private Sub realizar_pago_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Consulta = "select id_p , nombre , cedula , saldo from paciente"
        consultar()
        DataGridView1.DataSource = Tabla
        DataGridView1.ClearSelection()
        DataGridView1.Columns(0).Visible = False
        Button1.Hide()
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        id = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(0).Value

        Button1.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim monto As String
        'Dim saldo As String
        monto = InputBox("ingrese")
        
        'Mateo el saldo no se tiene que actulizar a lo que se paga :v tenes que restarle al saldo lo que se paga :vvv
        Consulta = "update paciente set saldo = '" & monto & "' where id_p = '" & Str(id) & ";"
        consultar()

        Consulta = "select id_p , nombre , cedula , saldo from paciente"
        consultar()
        DataGridView1.DataSource = Tabla
        DataGridView1.ClearSelection()
        DataGridView1.Columns(0).Visible = False

    End Sub
End Class