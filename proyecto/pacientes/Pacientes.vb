Public Class Pacientes

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        Agregar_Paciente.Show()

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Size = New System.Drawing.Size(850, 500)
        actTabla()
        Label20.ForeColor = Color.Gold
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        actPanel()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Modificar_Paciente.Show()
        Me.Hide()
    End Sub
    Public Sub actTabla()
        cedula = ""
        nombre = ""
        id_p = 0
        nac = ""
        enviado = ""
        direccion = ""
        direTra = ""
        saldo = 0
        Consulta = "SELECT * FROM paciente"
        consultar()
        DataGridView1.DataSource = Tabla
        DataGridView1.Columns(0).Visible = False
        DataGridView1.Columns(2).Visible = False
        DataGridView1.Columns(4).Visible = False
        DataGridView1.Columns(5).Visible = False
        DataGridView1.Columns(6).Visible = False
        DataGridView1.Columns(7).Visible = False
        DataGridView1.ClearSelection()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        id_p = DataGridView1.CurrentRow.Cells(0).Value

        If MsgBox("Seguro que dea borrar el paciente con la cedula " + DataGridView1.CurrentRow.Cells(1).Value + "?", MsgBoxStyle.YesNo) = vbYes Then
            Consulta = "delete from paciente where id_p = '" + Str(id_p) + "';"
            consultar()
            MsgBox("Borrado")
            actTabla()
            actPanel()
        Else
            MsgBox("OK")
        End If
    End Sub
    Public Sub actPanel()

        'Hacemos invisible el panel y el label y visible los botones
        Panel2.Hide()
        Label17.Hide()
        Button2.Show()
        Button3.Show()
        Button4.Show()
        Label3.Show()

        'Guardamos en Variables
        id_p = DataGridView1.CurrentRow.Cells(0).Value
        cedula = DataGridView1.CurrentRow.Cells(1).Value
        nombre = DataGridView1.CurrentRow.Cells(3).Value
        nac = DataGridView1.CurrentRow.Cells(2).Value

        If IsDBNull(DataGridView1.CurrentRow.Cells(4).Value) Then
            enviado = "No definido"
        Else
            enviado = DataGridView1.CurrentRow.Cells(4).Value
        End If

        direccion = DataGridView1.CurrentRow.Cells(5).Value

        If IsDBNull(DataGridView1.CurrentRow.Cells(6).Value) Then
            direTra = "No definido"
        Else
            direTra = DataGridView1.CurrentRow.Cells(6).Value
        End If

        saldo = DataGridView1.CurrentRow.Cells(7).Value

        'Mostramos en Panel
        Label4.Text = cedula
        Label5.Text = nombre
        Label6.Text = nac
        Label7.Text = enviado
        Label8.Text = direccion
        Label9.Text = direTra
        Label10.Text = saldo


    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        MsgBox("Crea el formulario de antecedentes")
    End Sub

    Private Sub Label3_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label3.MouseHover
        Label3.Font = New Font("Sans Serif", 8, FontStyle.Underline, GraphicsUnit.Point)
    End Sub

    Private Sub Label3_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label3.MouseLeave
        Label3.Font = New Font("Sans Serif", 8, GraphicsUnit.Point)
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Crear_Cita.Show()
        Me.Hide()
    End Sub

    Private Sub Label17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label17.Click

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label20.Click

    End Sub

    Private Sub Label19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label19.Click
        Aranceles.Show()
        Me.Dispose()
    End Sub


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label18.Text = Date.Now.ToLongTimeString
    End Sub
End Class
