Public Class Citas
    'Dim a As Icon
    ' a = My.Resources.rambocursor
    'Me.Cursor = New Cursor(a.Handle)
    Public idcita As Integer
    Public fechita As String

    Dim cita As String

    Dim fecha As String



    Private Sub Citas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Button2.Visible = False
        actualizador()

    End Sub

    Private Sub Label19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Dispose()
        Aranceles.Show()
    End Sub

    Private Sub Label20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Dispose()
        Pacientes.Show()
    End Sub

    Private Sub SaveFileDialog3_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)

    End Sub

    Private Sub MonthCalendar1_DateChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles MonthCalendar1.DateChanged
        actualizador()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        frmContenedor = Agregar_Cita
        frmContenedor.MdiParent = Menu_Inicio
        frmContenedor.Dock = DockStyle.Fill
        frmContenedor.Show()
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        fechita = fecha
        Me.Hide()
        frmContenedor = marcar_cita
        frmContenedor.MdiParent = Menu_Inicio
        frmContenedor.Dock = DockStyle.Fill
        frmContenedor.Show()

    End Sub


    Private Sub DataGridView1_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        Button2.Visible = True
        'Aca le asigno el valor a idPaciente y de idCita cuando se hace click en la tabla
        idcita = DataGridView1.CurrentRow.Cells(3).Value
        'Mira que id_p es una variable global que se usa en todo el programa, no es necesario crear otra xd
        id_p = DataGridView1.CurrentRow.Cells(4).Value
    End Sub

    Public Sub actualizador()
        fecha = MonthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd")
        Try
            'Agregue 2 columnas, id_c y id_p para poder acceder a la id de estas al hacer click en la tabla
            Consulta = "select date_format(hora, '%H:%i') as 'Hora', nombre as 'Nombre', descripcion as 'Descripcion', id_c, p.id_p from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + fecha + "';"
            consultar()
            DataGridView1.DataSource = Tabla
            'Oculto las columnas que tienen el id de cita y de paciente
            DataGridView1.Columns(3).Visible = False
            DataGridView1.Columns(4).Visible = False
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub


End Class
