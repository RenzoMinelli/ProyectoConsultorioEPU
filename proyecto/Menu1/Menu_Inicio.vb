Public Class Menu_Inicio


    Dim a As Integer = 0
    Dim xco, yco As Integer
    Dim xc, yc As Integer

    Dim con As Integer = 0

    Dim screenWidth As Integer = Screen.PrimaryScreen.Bounds.Width
    Dim screenHeight As Integer = Screen.PrimaryScreen.Bounds.Height





    Private Sub Menu_Inicio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


       
        Me.PerformAutoScale()

        Me.WindowState = FormWindowState.Maximized
        pbMaximizar.Image = My.Resources.img_509774_1_
        pbMinimizar.Location = New Point(pnlBarraSuperior.Width - 110, pbMinimizar.Location.Y)
        pbCerrar.Location = New Point(pnlBarraSuperior.Width - 50, pbCerrar.Location.Y)
        pbMaximizar.Location = New Point(pnlBarraSuperior.Width - 80, pbMaximizar.Location.Y)

        con = 1



        xf = Me.Location.X
        yf = Me.Location.Y


        If user = "funcionario" Then

            lblCitas.Hide()
            lblPacientes.Hide()
            pbCitas.Hide()
            pbPacientes.Hide()
            pnlCitas.Hide()
            pnlPacientes.Hide()
            pnlPacientes2.Hide()
            pnlCitas2.Hide()

            frmContenedor = Aranceles
            frmContenedor.MdiParent = Me
            frmContenedor.Dock = DockStyle.Fill
            frmContenedor.Show()

            Label2.ForeColor = Color.White

        ElseIf user = "odontologo" Or user = "root" Then



            frmContenedor = Citas
            frmContenedor.MdiParent = Me
            frmContenedor.Dock = DockStyle.Fill
            frmContenedor.Show()

            lblCitas.ForeColor = Color.White

        End If

        veriCon()
        If conex = True Then
            PictureBox5.Show()
            PictureBox6.Hide()
        Else
            PictureBox5.Hide()
            PictureBox6.Show()
        End If


    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblPacientes.Click
        Me.ActiveMdiChild.Dispose()
        frmContenedor = Pacientes
        frmContenedor.MdiParent = Me
        frmContenedor.Dock = DockStyle.Fill
        frmContenedor.Show()
        lblPacientes.ForeColor = Color.White
        Label2.ForeColor = Color.RoyalBlue
        Label3.ForeColor = Color.RoyalBlue
        lblCitas.ForeColor = Color.RoyalBlue
        Label7.ForeColor = Color.RoyalBlue
        Pacientes.dgbPacientes.ClearSelection()

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        Me.ActiveMdiChild.Dispose()
        frmContenedor = Aranceles
        frmContenedor.MdiParent = Me
        frmContenedor.Dock = DockStyle.Fill
        frmContenedor.Show()
        lblPacientes.ForeColor = Color.RoyalBlue
        Label2.ForeColor = Color.White
        Label3.ForeColor = Color.RoyalBlue
        Label7.ForeColor = Color.RoyalBlue
        lblCitas.ForeColor = Color.RoyalBlue
        Aranceles.DataGridView1.ClearSelection()
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblCitas.Click
        Me.ActiveMdiChild.Dispose()
        frmContenedor = Citas
        frmContenedor.MdiParent = Me
        frmContenedor.Dock = DockStyle.Fill
        frmContenedor.Show()
        lblPacientes.ForeColor = Color.RoyalBlue
        Label2.ForeColor = Color.RoyalBlue
        Label3.ForeColor = Color.RoyalBlue
        Label7.ForeColor = Color.RoyalBlue
        lblCitas.ForeColor = Color.White
        Citas.DataGridView1.ClearSelection()

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label3.Text = Date.Now.ToLongTimeString
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
        Login.Dispose()
    End Sub

    Private Sub PictureBox2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub



    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click
        Me.ActiveMdiChild.Dispose()
        frmContenedor = finanzas
        frmContenedor.MdiParent = Me
        frmContenedor.Dock = DockStyle.Fill
        frmContenedor.Show()

        Label7.ForeColor = Color.White
        lblPacientes.ForeColor = Color.RoyalBlue
        Label2.ForeColor = Color.RoyalBlue
        Label3.ForeColor = Color.RoyalBlue
        lblCitas.ForeColor = Color.RoyalBlue

    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbPacientes.Click
        Me.ActiveMdiChild.Dispose()
        frmContenedor = Pacientes
        frmContenedor.MdiParent = Me
        frmContenedor.Dock = DockStyle.Fill
        frmContenedor.Show()
        lblPacientes.ForeColor = Color.White
        Label2.ForeColor = Color.RoyalBlue
        Label3.ForeColor = Color.RoyalBlue
        lblCitas.ForeColor = Color.RoyalBlue
        Label7.ForeColor = Color.RoyalBlue
        Pacientes.dgbPacientes.ClearSelection()
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

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Me.ActiveMdiChild.Dispose()
        frmContenedor = Aranceles
        frmContenedor.MdiParent = Me
        frmContenedor.Dock = DockStyle.Fill
        frmContenedor.Show()
        lblPacientes.ForeColor = Color.RoyalBlue
        Label2.ForeColor = Color.White
        Label3.ForeColor = Color.RoyalBlue
        Label7.ForeColor = Color.RoyalBlue
        lblCitas.ForeColor = Color.RoyalBlue
    End Sub


    Private Sub Panel10_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pnlPacientes.Click
        Me.ActiveMdiChild.Dispose()
        frmContenedor = Pacientes
        frmContenedor.MdiParent = Me
        frmContenedor.Dock = DockStyle.Fill
        frmContenedor.Show()
        lblPacientes.ForeColor = Color.White
        Label2.ForeColor = Color.RoyalBlue
        Label3.ForeColor = Color.RoyalBlue
        lblCitas.ForeColor = Color.RoyalBlue
        Label7.ForeColor = Color.RoyalBlue
    End Sub

    Private Sub Panel9_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pnlCitas.Click
        Me.ActiveMdiChild.Dispose()
        frmContenedor = Citas
        frmContenedor.MdiParent = Me
        frmContenedor.Dock = DockStyle.Fill
        frmContenedor.Show()
        lblPacientes.ForeColor = Color.RoyalBlue
        Label2.ForeColor = Color.RoyalBlue
        Label3.ForeColor = Color.RoyalBlue
        Label7.ForeColor = Color.RoyalBlue
        lblCitas.ForeColor = Color.White
    End Sub


    Private Sub Panel15_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Panel15.Click
        Me.ActiveMdiChild.Dispose()
        frmContenedor = Aranceles
        frmContenedor.MdiParent = Me
        frmContenedor.Dock = DockStyle.Fill
        frmContenedor.Show()
        lblPacientes.ForeColor = Color.RoyalBlue
        Label2.ForeColor = Color.White
        Label3.ForeColor = Color.RoyalBlue
        Label7.ForeColor = Color.RoyalBlue
        lblCitas.ForeColor = Color.RoyalBlue
    End Sub

    Private Sub Panel13_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Panel13.Click
        Me.ActiveMdiChild.Dispose()
        frmContenedor = finanzas
        frmContenedor.MdiParent = Me
        frmContenedor.Dock = DockStyle.Fill
        frmContenedor.Show()

        Label7.ForeColor = Color.White
        lblPacientes.ForeColor = Color.RoyalBlue
        Label2.ForeColor = Color.RoyalBlue
        Label3.ForeColor = Color.RoyalBlue
        lblCitas.ForeColor = Color.RoyalBlue
    End Sub


    Private Sub PictureBox7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox7.Click
        Me.ActiveMdiChild.Dispose()
        frmContenedor = finanzas
        frmContenedor.MdiParent = Me
        frmContenedor.Dock = DockStyle.Fill
        frmContenedor.Show()
        lblPacientes.ForeColor = Color.RoyalBlue
        Label2.ForeColor = Color.RoyalBlue
        Label3.ForeColor = Color.RoyalBlue
        Label7.ForeColor = Color.White
        lblCitas.ForeColor = Color.RoyalBlue
    End Sub

    Private Sub PictureBox9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbMaximizar.Click
        If con = 1 Then

            Me.Width = 1400
            Me.Height = 700

            Me.WindowState = FormWindowState.Normal
            pbMaximizar.Image = My.Resources.maximize_window_1_
            pbMinimizar.Location = New Point(pnlBarraSuperior.Width - 110, pbMinimizar.Location.Y)
            pbCerrar.Location = New Point(pnlBarraSuperior.Width - 50, pbCerrar.Location.Y)
            pbMaximizar.Location = New Point(pnlBarraSuperior.Width - 80, pbMaximizar.Location.Y)
            con = 0

            Me.Location = New Point((screenWidth / 2) - (Me.Width / 2), (screenHeight / 2) - (Me.Height / 2))

        Else
            Me.WindowState = FormWindowState.Maximized
            pbMaximizar.Image = My.Resources.img_509774_1_
            pbMinimizar.Location = New Point(pnlBarraSuperior.Width - 110, pbMinimizar.Location.Y)
            pbCerrar.Location = New Point(pnlBarraSuperior.Width - 50, pbCerrar.Location.Y)
            pbMaximizar.Location = New Point(pnlBarraSuperior.Width - 80, pbMaximizar.Location.Y)
            con = 1


        End If
        actPos()
    End Sub

    Private Sub PictureBox8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbCitas.Click
        Me.ActiveMdiChild.Dispose()
        frmContenedor = Citas
        frmContenedor.MdiParent = Me
        frmContenedor.Dock = DockStyle.Fill
        frmContenedor.Show()
        lblPacientes.ForeColor = Color.RoyalBlue
        Label2.ForeColor = Color.RoyalBlue
        Label3.ForeColor = Color.RoyalBlue
        Label7.ForeColor = Color.RoyalBlue
        lblCitas.ForeColor = Color.White
        Citas.DataGridView1.ClearSelection()
    End Sub

End Class