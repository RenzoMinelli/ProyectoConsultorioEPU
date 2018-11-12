Public Class frmMenuInicio


    Dim a As Integer = 0

    Dim con As Integer = 0


    Private Sub Menu_Inicio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load





        Me.WindowState = FormWindowState.Maximized
        pbMaximizar.Image = My.Resources.IconoVistaNormal
        pbMinimizar.Location = New Point(pnlBarraSuperior.Width - 110, pbMinimizar.Location.Y)
        pbCerrar.Location = New Point(pnlBarraSuperior.Width - 50, pbCerrar.Location.Y)
        pbMaximizar.Location = New Point(pnlBarraSuperior.Width - 80, pbMaximizar.Location.Y)
        con = 1

        xf = Me.Location.X
        yf = Me.Location.Y


        If user = "funcionario" Then


            lblPacientes.Enabled = False
            pbPacientes.Enabled = False
            pnlPacientes.Enabled = False
            pnlPacientes2.Enabled = False


            frmContenedor = frmAranceles
            frmContenedor.MdiParent = Me
            frmContenedor.Dock = DockStyle.Fill
            frmContenedor.Show()

            lblAranceles.ForeColor = Color.White

        ElseIf user = "odontologo" Or user = "root" Then



            frmContenedor = frmCitas
            frmContenedor.MdiParent = Me
            frmContenedor.Dock = DockStyle.Fill
            frmContenedor.Show()

            lblCitas.ForeColor = Color.White

        End If

        Consulta = "select * from cita"
        consultar()

        If conex = False Then

            pbConexion.Image = My.Resources.X


        Else
            pbConexion.Image = My.Resources.IconoConexion

        End If


    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblPacientes.Click
        Me.ActiveMdiChild.Dispose()
        frmContenedor = frmPacientes
        frmContenedor.MdiParent = Me
        frmContenedor.Dock = DockStyle.Fill
        frmContenedor.Show()
        lblPacientes.ForeColor = Color.White
        lblAranceles.ForeColor = Color.RoyalBlue
        lblCitas.ForeColor = Color.RoyalBlue
        lblFinanzas.ForeColor = Color.RoyalBlue
        lblGraficas.ForeColor = Color.RoyalBlue
        frmPacientes.dgvPacientes.ClearSelection()

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblAranceles.Click
        Me.ActiveMdiChild.Dispose()
        frmContenedor = frmAranceles
        frmContenedor.MdiParent = Me
        frmContenedor.Dock = DockStyle.Fill
        frmContenedor.Show()
        lblAranceles.ForeColor = Color.White
        lblGraficas.ForeColor = Color.RoyalBlue
        lblPacientes.ForeColor = Color.RoyalBlue
        lblFinanzas.ForeColor = Color.RoyalBlue
        lblCitas.ForeColor = Color.RoyalBlue
        frmAranceles.dgvAranceles.ClearSelection()
        frmAranceles.dgvArancelesUtilizados.ClearSelection()
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblCitas.Click
        Me.ActiveMdiChild.Dispose()
        frmContenedor = frmCitas
        frmContenedor.MdiParent = Me
        frmContenedor.Dock = DockStyle.Fill
        frmContenedor.Show()
        lblPacientes.ForeColor = Color.RoyalBlue
        lblAranceles.ForeColor = Color.RoyalBlue
        lblFinanzas.ForeColor = Color.RoyalBlue
        lblCitas.ForeColor = Color.White
        lblGraficas.ForeColor = Color.RoyalBlue


    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrReloj.Tick
        lblReloj.Text = Date.Now.ToString("hh:mm:ss")
    End Sub

    Private Sub Panel2_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnlBarraSuperior.MouseClick

    End Sub

    Private Sub Panel3_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnlBarraSuperior.MouseDown

        If con = 0 Then
            a = 1
            Me.Opacity = 0.5
        End If

    End Sub
    Private Sub Panel3_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnlBarraSuperior.MouseMove

        If a = 1 And con = 0 Then

            xc = Cursor.Position.X
            yc = Cursor.Position.Y

            Dim holax, holay As Integer

            holax = xc - xco
            holay = yc - yco

            Me.Location = New Point(xf + holax, yf + holay)

        End If

        If a = 0 Then

            xco = Cursor.Position.X
            yco = Cursor.Position.Y

        End If
    End Sub
    Private Sub Panel3_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnlBarraSuperior.MouseUp
        If con = 0 Then
            xf = Me.Location.X
            yf = Me.Location.Y
            a = 0
            Me.Opacity = 1
        End If

    End Sub

    Private Sub PictureBox4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbCerrar.Click
        frmLogin.Dispose()
    End Sub

    Private Sub PictureBox2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub



    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblFinanzas.Click
        Me.ActiveMdiChild.Dispose()
        frmContenedor = frmFinanzas
        frmContenedor.MdiParent = Me
        frmContenedor.Dock = DockStyle.Fill
        frmContenedor.Show()
        lblFinanzas.ForeColor = Color.White
        lblPacientes.ForeColor = Color.RoyalBlue
        lblAranceles.ForeColor = Color.RoyalBlue
        lblGraficas.ForeColor = Color.RoyalBlue
        lblCitas.ForeColor = Color.RoyalBlue

    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbPacientes.Click
        Me.ActiveMdiChild.Dispose()
        frmContenedor = frmPacientes
        frmContenedor.MdiParent = Me
        frmContenedor.Dock = DockStyle.Fill
        frmContenedor.Show()
        lblPacientes.ForeColor = Color.White
        lblAranceles.ForeColor = Color.RoyalBlue
        lblCitas.ForeColor = Color.RoyalBlue
        lblFinanzas.ForeColor = Color.RoyalBlue
        lblGraficas.ForeColor = Color.RoyalBlue
        frmPacientes.dgvPacientes.ClearSelection()
    End Sub

    Private Sub Panel8_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel8.MouseDown
        a = 1
        Me.Opacity = 0.5
    End Sub

    Private Sub Panel8_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel8.MouseMove
        If a = 1 Then

            xc = Cursor.Position.X
            yc = Cursor.Position.Y

            Dim holax, holay As Integer

            holax = xc - xco
            holay = yc - yco

            Me.Location = New Point(xf + holax, yf + holay)

        End If

        If a = 0 Then

            xco = Cursor.Position.X
            yco = Cursor.Position.Y

        End If
    End Sub

    Private Sub Panel8_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel8.MouseUp
        xf = Me.Location.X
        yf = Me.Location.Y
        a = 0
        Me.Opacity = 1
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblReloj.Click

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbAranceles.Click
        Me.ActiveMdiChild.Dispose()
        frmContenedor = frmAranceles
        frmContenedor.MdiParent = Me
        frmContenedor.Dock = DockStyle.Fill
        frmContenedor.Show()
        lblAranceles.ForeColor = Color.White
        lblGraficas.ForeColor = Color.RoyalBlue
        lblPacientes.ForeColor = Color.RoyalBlue
        lblFinanzas.ForeColor = Color.RoyalBlue
        lblCitas.ForeColor = Color.RoyalBlue
        frmAranceles.dgvAranceles.ClearSelection()
        frmAranceles.dgvArancelesUtilizados.ClearSelection()
    End Sub


    Private Sub Panel10_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pnlPacientes.Click
        Me.ActiveMdiChild.Dispose()
        frmContenedor = frmPacientes
        frmContenedor.MdiParent = Me
        frmContenedor.Dock = DockStyle.Fill
        frmContenedor.Show()
        lblPacientes.ForeColor = Color.White
        lblAranceles.ForeColor = Color.RoyalBlue
        lblCitas.ForeColor = Color.RoyalBlue
        lblFinanzas.ForeColor = Color.RoyalBlue
        lblGraficas.ForeColor = Color.RoyalBlue
        frmPacientes.dgvPacientes.ClearSelection()
    End Sub

    Private Sub Panel9_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pnlCitas.Click
        Me.ActiveMdiChild.Dispose()
        frmContenedor = frmCitas
        frmContenedor.MdiParent = Me
        frmContenedor.Dock = DockStyle.Fill
        frmContenedor.Show()
        lblPacientes.ForeColor = Color.RoyalBlue
        lblAranceles.ForeColor = Color.RoyalBlue
        lblFinanzas.ForeColor = Color.RoyalBlue
        lblCitas.ForeColor = Color.White
        lblGraficas.ForeColor = Color.RoyalBlue
    End Sub


    Private Sub Panel15_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pnlAranceles.Click
        Me.ActiveMdiChild.Dispose()
        frmContenedor = frmAranceles
        frmContenedor.MdiParent = Me
        frmContenedor.Dock = DockStyle.Fill
        frmContenedor.Show()
        lblAranceles.ForeColor = Color.White
        lblGraficas.ForeColor = Color.RoyalBlue
        lblPacientes.ForeColor = Color.RoyalBlue
        lblFinanzas.ForeColor = Color.RoyalBlue
        lblCitas.ForeColor = Color.RoyalBlue
        frmAranceles.dgvAranceles.ClearSelection()
        frmAranceles.dgvArancelesUtilizados.ClearSelection()
    End Sub

    Private Sub Panel13_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pnlFinanzas.Click
        Me.ActiveMdiChild.Dispose()
        frmContenedor = frmFinanzas
        frmContenedor.MdiParent = Me
        frmContenedor.Dock = DockStyle.Fill
        frmContenedor.Show()
        lblFinanzas.ForeColor = Color.White
        lblPacientes.ForeColor = Color.RoyalBlue
        lblAranceles.ForeColor = Color.RoyalBlue
        lblGraficas.ForeColor = Color.RoyalBlue
        lblCitas.ForeColor = Color.RoyalBlue
    End Sub


    Private Sub PictureBox7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbFinanzas.Click
        Me.ActiveMdiChild.Dispose()
        frmContenedor = frmFinanzas
        frmContenedor.MdiParent = Me
        frmContenedor.Dock = DockStyle.Fill
        frmContenedor.Show()
        lblFinanzas.ForeColor = Color.White
        lblPacientes.ForeColor = Color.RoyalBlue
        lblAranceles.ForeColor = Color.RoyalBlue
        lblGraficas.ForeColor = Color.RoyalBlue
        lblCitas.ForeColor = Color.RoyalBlue

    End Sub

    Private Sub PictureBox9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbMaximizar.Click
        If con = 1 Then

            Me.Width = 1350
            Me.Height = 729

            Me.WindowState = FormWindowState.Normal
            pbMaximizar.Image = My.Resources.IconoVistaMaximizar
            pbMinimizar.Location = New Point(pnlBarraSuperior.Width - 110, pbMinimizar.Location.Y)
            pbCerrar.Location = New Point(pnlBarraSuperior.Width - 50, pbCerrar.Location.Y)
            pbMaximizar.Location = New Point(pnlBarraSuperior.Width - 80, pbMaximizar.Location.Y)
            con = 0

            Me.Location = New Point((screenWidth / 2) - (Me.Width / 2), (screenHeight / 2) - (Me.Height / 2))

        Else
            Me.WindowState = FormWindowState.Maximized
            pbMaximizar.Image = My.Resources.IconoVistaNormal
            pbMinimizar.Location = New Point(pnlBarraSuperior.Width - 110, pbMinimizar.Location.Y)
            pbCerrar.Location = New Point(pnlBarraSuperior.Width - 50, pbCerrar.Location.Y)
            pbMaximizar.Location = New Point(pnlBarraSuperior.Width - 80, pbMaximizar.Location.Y)
            con = 1


        End If

        xf = Me.Location.X
        yf = Me.Location.Y
    End Sub

    Private Sub PictureBox8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbCitas.Click
        Me.ActiveMdiChild.Dispose()
        frmContenedor = frmCitas
        frmContenedor.MdiParent = Me
        frmContenedor.Dock = DockStyle.Fill
        frmContenedor.Show()
        lblPacientes.ForeColor = Color.RoyalBlue
        lblAranceles.ForeColor = Color.RoyalBlue
        lblFinanzas.ForeColor = Color.RoyalBlue
        lblCitas.ForeColor = Color.White
        lblGraficas.ForeColor = Color.RoyalBlue
    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblGraficas.Click
        Me.ActiveMdiChild.Dispose()
        frmContenedor = frmGraficas
        frmContenedor.MdiParent = Me
        frmContenedor.Dock = DockStyle.Fill
        frmContenedor.Show()
        lblPacientes.ForeColor = Color.RoyalBlue
        lblAranceles.ForeColor = Color.RoyalBlue
        lblGraficas.ForeColor = Color.White
        lblFinanzas.ForeColor = Color.RoyalBlue
        lblCitas.ForeColor = Color.RoyalBlue
        frmAranceles.dgvAranceles.ClearSelection()
        frmAranceles.dgvArancelesUtilizados.ClearSelection()
    End Sub
    Private Sub pbGraficas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbGraficas.Click
        Me.ActiveMdiChild.Dispose()
        frmContenedor = frmGraficas
        frmContenedor.MdiParent = Me
        frmContenedor.Dock = DockStyle.Fill
        frmContenedor.Show()
        lblPacientes.ForeColor = Color.RoyalBlue
        lblAranceles.ForeColor = Color.RoyalBlue
        lblGraficas.ForeColor = Color.White
        lblFinanzas.ForeColor = Color.RoyalBlue
        lblCitas.ForeColor = Color.RoyalBlue
        frmAranceles.dgvAranceles.ClearSelection()
        frmAranceles.dgvArancelesUtilizados.ClearSelection()
    End Sub

    Private Sub pnlGraficas_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pnlGraficas.Click
        Me.ActiveMdiChild.Dispose()
        frmContenedor = frmGraficas
        frmContenedor.MdiParent = Me
        frmContenedor.Dock = DockStyle.Fill
        frmContenedor.Show()
        lblPacientes.ForeColor = Color.RoyalBlue
        lblAranceles.ForeColor = Color.RoyalBlue
        lblGraficas.ForeColor = Color.White
        lblFinanzas.ForeColor = Color.RoyalBlue
        lblCitas.ForeColor = Color.RoyalBlue
        frmAranceles.dgvAranceles.ClearSelection()
        frmAranceles.dgvArancelesUtilizados.ClearSelection()
    End Sub
End Class