Public Class Pacientes
    '--------------------------------------------------------------------------------------------
    '- Renzo no te olvides que hay que agregar una forma de visualizar las citas para cada paciente



    Dim formu As New Form



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        formu = Agregar_Paciente
        formu.MdiParent = Menu_Inicio
        formu.Dock = DockStyle.Fill
        formu.Show()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        actPos()
        actTabla()

    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        actPanel()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        formu = Modificar_Paciente
        formu.MdiParent = Menu_Inicio
        formu.Dock = DockStyle.Fill
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
        telefono = ""
        saldo = 0


        Try
            Consulta = "SELECT * FROM paciente"
            consultar()

            DataGridView1.DataSource = Tabla
            DataGridView1.Columns(0).Visible = False
            DataGridView1.Columns(2).Visible = False
            DataGridView1.Columns(4).Visible = False
            DataGridView1.Columns(5).Visible = False
            DataGridView1.Columns(6).Visible = False
            DataGridView1.Columns(7).Visible = False
            DataGridView1.Columns(8).Visible = False
            DataGridView1.Columns(1).HeaderText = "Cédula"
            DataGridView1.Columns(3).HeaderText = "Nombre"
            DataGridView1.ClearSelection()
        Catch ex As Exception
            Button1.Hide()
        End Try

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        id_p = DataGridView1.CurrentRow.Cells(0).Value

        If MsgBox("Seguro que desea borrar el paciente con la cedula " + DataGridView1.CurrentRow.Cells(1).Value + "?", MsgBoxStyle.YesNo) = vbYes Then
            Try
                Consulta = "delete from paciente where id_p = '" + Str(id_p) + "';"
                consultar()
                MsgBox("Borrado")
                actTabla()
                actPanel()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try

        Else
            MsgBox("Paciente Conservado")
        End If
    End Sub
    Public Sub actPanel()

        'Hacemos invisible el panel y el label y visible los botones
        Panel2.Hide()
        Label17.Hide()
        Button2.Show()
        Button3.Show()
        Button4.Show()
        Button6.Show()
        Button5.Show()
        Button7.Show()


        'Guardamos en Variables
        id_p = DataGridView1.CurrentRow.Cells(0).Value
        cedula = DataGridView1.CurrentRow.Cells(1).Value
        nombre = DataGridView1.CurrentRow.Cells(3).Value
        nac = DataGridView1.CurrentRow.Cells(2).Value
        telefono = DataGridView1.CurrentRow.Cells(4).Value

        If IsDBNull(DataGridView1.CurrentRow.Cells(5).Value) Then
            enviado = "No definido"
        Else
            enviado = DataGridView1.CurrentRow.Cells(5).Value
        End If

        direccion = DataGridView1.CurrentRow.Cells(6).Value

        If IsDBNull(DataGridView1.CurrentRow.Cells(7).Value) Then
            direTra = "No definido"
        Else
            direTra = DataGridView1.CurrentRow.Cells(7).Value
        End If

        saldo = DataGridView1.CurrentRow.Cells(8).Value

        Consulta = "select p.id_p, count(*) from paciente p inner join cita c on p.id_p = c.id_p where c.realizada = 1 and p.id_p = '" + id_p.ToString + "' group by p.id_p;"
        consultar()
        DataGridView2.DataSource = Tabla

        Dim numCitas As Integer = 0

        If DataGridView2.RowCount = 1 Then
            numCitas = DataGridView2.Rows(0).Cells(1).Value
        End If





        'Mostramos en Panel
        Label4.Text = cedula
        Label5.Text = nombre
        Label6.Text = nac
        Label7.Text = enviado
        Label8.Text = direccion
        Label9.Text = direTra
        Label10.Text = numCitas
        Label3.Text = "$" + saldo.ToString
        Label19.Text = telefono

    End Sub

  

    

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Hide()
        formu = Crear_Cita
        formu.MdiParent = Menu_Inicio
        formu.Dock = DockStyle.Fill
        formu.Show()
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Dim a As String = TextBox1.Text
        Try
            Consulta = "Select * from paciente where nombre like '" + a + "%' or cedula like '" + a + "%';"
            consultar()
            DataGridView1.DataSource = Tabla
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        
    End Sub

    Private Sub Label23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Dispose()
        Citas.Show()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Hide()
        formu = Registro_Medico
        formu.MdiParent = Menu_Inicio
        formu.Dock = DockStyle.Fill
        formu.Show()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Me.Hide()
        formu = Antecedentes
        formu.MdiParent = Menu_Inicio
        formu.Dock = DockStyle.Fill
        formu.Show()
    End Sub

    Private Sub Label3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Hide()
        formu = Antecedentes
        formu.MdiParent = Menu_Inicio
        formu.Dock = DockStyle.Fill
        formu.Show()
    End Sub

    Private Sub DataGridView1_CellClick1(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        id_p = DataGridView1.CurrentRow.Cells(0).Value
        actPanel()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Dim pago As String = "g"
        Do
            pago = InputBox("El salgo pendiente del paciente " + nombre + " es de $" + saldo.ToString + vbNewLine + "¿Cuánto depositará?", "PAGO")
            If Not IsNumeric(pago) Then
                If pago = "" Then
                    MsgBox("Acción cancelada", MsgBoxStyle.Information)
                    pago = "cancel"
                Else
                    MsgBox("Ingrese un número", MsgBoxStyle.Exclamation)
                    pago = "g"
                End If
               
            End If
        Loop While pago = "g"

        If Not pago = "cancel" Then
            If MsgBox("¿Confirma que el paciente " + nombre + " depositó $" + pago + "?", MsgBoxStyle.YesNo) = vbYes Then
                saldo -= pago
                Try
                    Consulta = "update paciente set saldo = '" + saldo.ToString + "' where id_p = '" + id_p.ToString + "';"
                    consultar()

                    Dim fecha As Date = Now.ToShortDateString
                    Dim nfecha = fecha.ToString("yyyy-MM-dd")

                    Consulta = "insert into recibo (fecha, pago, id_p) values ('" + nfecha + "', '" + pago.ToString + "', '" + id_p.ToString + "');"
                    MsgBox(nfecha + " " + pago.ToString + " " + id_p.ToString)
                    consultar()

                    MsgBox("Información actualizada", MsgBoxStyle.Information)

                    actTabla()
                    actPanel()
                Catch ex As Exception
                    MsgBox("Error")
                End Try


            Else
                MsgBox("Acción cancelada", MsgBoxStyle.Information)
            End If
        End If



    End Sub


End Class
