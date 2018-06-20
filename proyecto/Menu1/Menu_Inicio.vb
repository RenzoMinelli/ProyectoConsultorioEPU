Public Class Menu_Inicio
    Dim formu As New Form

    Dim a As Integer = 0
    Dim xco, yco As Integer
    Dim xc, yc As Integer


    Private Sub Menu_Inicio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        actPos()
        formu = Pacientes
        formu.MdiParent = Me
        formu.Dock = DockStyle.Right
        formu.Show()


        veriCon()
        If conex = True Then
            PictureBox5.Show()
            PictureBox6.Hide()
        Else
            PictureBox5.Hide()
            PictureBox6.Show()
        End If
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        formu.Dispose()
        formu = Pacientes
        formu.MdiParent = Me
        formu.Dock = DockStyle.Right
        formu.Show()
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        formu.Dispose()
        formu = Aranceles
        formu.MdiParent = Me
        formu.Dock = DockStyle.Right
        formu.Show()
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click
        formu.Dispose()
        formu = Citas
        formu.MdiParent = Me
        formu.Dock = DockStyle.Right
        formu.Show()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label3.Text = Date.Now.ToLongTimeString
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        Me.Dispose()
    End Sub

    Private Sub Panel2_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel2.Paint
        a = 1
    End Sub

    Private Sub Panel2_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel2.Paint

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

    Private Sub Panel2_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel2.Paint
        xf = Me.Location.X
        yf = Me.Location.Y
        a = 0
    End Sub
End Class