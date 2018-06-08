Public Class Aranceles
    Public id As Integer

    Private Sub Aranceles_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        'Me.Size = New System.Drawing.Size(704, 440)
        verificarCon()
        Consulta = "select * from aranceles"
        consultar()
        DataGridView1.DataSource = Tabla
        DataGridView1.ClearSelection()
        Button2.Hide()
        Button3.Hide()
        Label2.ForeColor = Color.Gold
        ''DataGridView1.Columns(0).Visible = False
        'PictureBox5.Hide()
        'PictureBox6.Hide()
        DataGridView1.Columns(0).Visible = False
        '   Me.WindowState = FormWindowState.Maximized

        DataGridView1.Columns(0).Width = 300

        DataGridView1.Columns(1).Width = 300

        DataGridView1.Columns(2).Width = 300
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Consulta = " delete from aranceles where id_a = " + Str(id) + ""
        consultar()
        Consulta = "select * from aranceles"
        consultar()
        DataGridView1.DataSource = Tabla
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Button2.Show()
        Button3.Show()
        id = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(0).Value
    End Sub


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Modificar_Arancel.Show()
        Me.Hide()
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        Agregar_Arancel.Show()
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        Pacientes.Show()
        Me.Hide()
    End Sub


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label3.Text = Date.Now.ToLongTimeString
        Label3.Font = New Font("Microsoft Sans Serif", 15, FontStyle.Bold)

    End Sub
    Private Sub verificarCon()
        veriCon()

        Select Case conex
            Case True
                PictureBox5.Show()
                PictureBox6.Hide()
            Case False
                PictureBox6.Show()
                PictureBox5.Hide()
        End Select

    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub


    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        Me.Dispose()
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click
        Me.Hide()
        Citas.Show()
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class