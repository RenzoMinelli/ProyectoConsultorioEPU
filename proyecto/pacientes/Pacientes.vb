Public Class Pacientes
    '--------------------------------------------------------------------------------------------
    '- Renzo no te olvides que hay que agregar una forma de visualizar las citas para cada paciente
    '- Y una forma de marcar como realizada la cita anteriormente creada
    '-
    '-
    '--------------------------------------------------------------------------------------------

    Dim a As Integer = 0
    Dim xco, yco As Integer
    Dim xc, yc As Integer
    Dim formu As New Form



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        formu = Agregar_Paciente
        formu.MdiParent = Menu_Inicio
        formu.Dock = DockStyle.Right
        formu.Show()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        actPos()
        Me.Size = New System.Drawing.Size(880, 580)
        actTabla()

    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        actPanel()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        formu = Modificar_Paciente
        formu.MdiParent = Menu_Inicio
        formu.Dock = DockStyle.Right
        formu.Show()
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
        Button5.Show()

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
        'MsgBox("Crea el formulario de antecedentes")
        Me.Hide()
        Antecedentes.Show()

    End Sub

    Private Sub Label3_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label3.MouseHover
        Label3.Font = New Font("Sans Serif", 8, FontStyle.Underline, GraphicsUnit.Point)
    End Sub

    Private Sub Label3_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label3.MouseLeave
        Label3.Font = New Font("Sans Serif", 8, GraphicsUnit.Point)
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Hide()
        formu = Crear_Cita
        formu.MdiParent = Menu_Inicio
        formu.Dock = DockStyle.Right
        formu.Show()
    End Sub

    Private Sub Label19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Aranceles.Show()
        Me.Dispose()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox6.Click
        Menu_Inicio.Dispose()
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        Me.WindowState = FormWindowState.Minimized
        Menu_Inicio.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Dim a As String = TextBox1.Text
        Consulta = "Select * from paciente where nombre like '" + a + "%' or cedula like '" + a + "%';"
        consultar()
        DataGridView1.DataSource = Tabla
    End Sub

    Private Sub Label23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Dispose()
        Citas.Show()
    End Sub
    Private Sub Panel3_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel3.MouseDown
        a = 1
    End Sub
    Private Sub Panel3_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel3.MouseMove

        If a = 1 Then

            xc = Cursor.Position.X
            yc = Cursor.Position.Y

            Dim holax, holay As Integer

            holax = xc - xco
            holay = yc - yco

            Menu_Inicio.Location = New Point(xf + holax, yf + holay)

        End If

        If a = 0 Then

            xco = Cursor.Position.X
            yco = Cursor.Position.Y

        End If
    End Sub
    Private Sub Panel3_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel3.MouseUp
        xf = Menu_Inicio.Location.X
        yf = Menu_Inicio.Location.Y
        a = 0
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Hide()
        formu = Registro_Medico
        formu.MdiParent = Menu_Inicio
        formu.Dock = DockStyle.Right
        formu.Show()
    End Sub

End Class
