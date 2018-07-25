﻿Public Class Menu_Inicio
    Dim formu As New Form

    Dim a As Integer = 0
    Dim xco, yco As Integer
    Dim xc, yc As Integer



    Private Sub Menu_Inicio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        xf = Me.Location.X
        yf = Me.Location.Y


        If user = "funcionario" Then

            Panel16.Show()

            formu = Aranceles
            formu.MdiParent = Me
            formu.Dock = DockStyle.Fill
            formu.Show()

            Label2.ForeColor = Color.White

        ElseIf user = "odontologo" Then

            Panel16.Hide()

            formu = Citas
            formu.MdiParent = Me
            formu.Dock = DockStyle.Fill
            formu.Show()

            Label4.ForeColor = Color.White

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

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        formu.Dispose()
        formu = Pacientes
        formu.MdiParent = Me
        formu.Dock = DockStyle.Fill
        formu.Show()
        Label1.ForeColor = Color.White
        Label2.ForeColor = Color.RoyalBlue
        Label3.ForeColor = Color.RoyalBlue
        Label4.ForeColor = Color.RoyalBlue
        Label7.ForeColor = Color.RoyalBlue

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        formu.Dispose()
        formu = Aranceles
        formu.MdiParent = Me
        formu.Dock = DockStyle.Fill
        formu.Show()
        Label1.ForeColor = Color.RoyalBlue
        Label2.ForeColor = Color.White
        Label3.ForeColor = Color.RoyalBlue
        Label7.ForeColor = Color.RoyalBlue
        Label4.ForeColor = Color.RoyalBlue
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click
        formu.Dispose()
        formu = Citas
        formu.MdiParent = Me
        formu.Dock = DockStyle.Fill
        formu.Show()
        Label1.ForeColor = Color.RoyalBlue
        Label2.ForeColor = Color.RoyalBlue
        Label3.ForeColor = Color.RoyalBlue
        Label7.ForeColor = Color.RoyalBlue
        Label4.ForeColor = Color.White
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label3.Text = Date.Now.ToLongTimeString
    End Sub

    Private Sub Panel2_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel2.MouseClick

    End Sub

    Private Sub Panel3_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel2.MouseDown
        a = 1
        Me.Opacity = 0.5
    End Sub
    Private Sub Panel3_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel2.MouseMove

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
    Private Sub Panel3_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel2.MouseUp
        xf = Me.Location.X
        yf = Me.Location.Y
        a = 0
        Me.Opacity = 1
    End Sub

    Private Sub PictureBox4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        Login.Dispose()
    End Sub

    Private Sub PictureBox2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub


   
    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click
        formu.Dispose()
        formu = finanzas
        formu.MdiParent = Me
        formu.Dock = DockStyle.Fill
        formu.Show()

        Label7.ForeColor = Color.White
        Label1.ForeColor = Color.RoyalBlue
        Label2.ForeColor = Color.RoyalBlue
        Label3.ForeColor = Color.RoyalBlue
        Label4.ForeColor = Color.RoyalBlue
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        formu.Dispose()
        formu = Pacientes
        formu.MdiParent = Me
        formu.Dock = DockStyle.Fill
        formu.Show()
        Label1.ForeColor = Color.White
        Label2.ForeColor = Color.RoyalBlue
        Label3.ForeColor = Color.RoyalBlue
        Label4.ForeColor = Color.RoyalBlue
        Label7.ForeColor = Color.RoyalBlue
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
        formu.Dispose()
        formu = Aranceles
        formu.MdiParent = Me
        formu.Dock = DockStyle.Fill
        formu.Show()
        Label1.ForeColor = Color.RoyalBlue
        Label2.ForeColor = Color.White
        Label3.ForeColor = Color.RoyalBlue
        Label7.ForeColor = Color.RoyalBlue
        Label4.ForeColor = Color.RoyalBlue
    End Sub

    
    Private Sub Panel10_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Panel10.Click
        formu.Dispose()
        formu = Pacientes
        formu.MdiParent = Me
        formu.Dock = DockStyle.Fill
        formu.Show()
        Label1.ForeColor = Color.White
        Label2.ForeColor = Color.RoyalBlue
        Label3.ForeColor = Color.RoyalBlue
        Label4.ForeColor = Color.RoyalBlue
        Label7.ForeColor = Color.RoyalBlue
    End Sub

    Private Sub Panel9_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Panel9.Click
        formu.Dispose()
        formu = Citas
        formu.MdiParent = Me
        formu.Dock = DockStyle.Fill
        formu.Show()
        Label1.ForeColor = Color.RoyalBlue
        Label2.ForeColor = Color.RoyalBlue
        Label3.ForeColor = Color.RoyalBlue
        Label7.ForeColor = Color.RoyalBlue
        Label4.ForeColor = Color.White
    End Sub

 
    Private Sub Panel15_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Panel15.Click
        formu.Dispose()
        formu = Aranceles
        formu.MdiParent = Me
        formu.Dock = DockStyle.Fill
        formu.Show()
        Label1.ForeColor = Color.RoyalBlue
        Label2.ForeColor = Color.White
        Label3.ForeColor = Color.RoyalBlue
        Label7.ForeColor = Color.RoyalBlue
        Label4.ForeColor = Color.RoyalBlue
    End Sub

    Private Sub Panel13_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Panel13.Click
        formu.Dispose()
        formu = finanzas
        formu.MdiParent = Me
        formu.Dock = DockStyle.Fill
        formu.Show()

        Label7.ForeColor = Color.White
        Label1.ForeColor = Color.RoyalBlue
        Label2.ForeColor = Color.RoyalBlue
        Label3.ForeColor = Color.RoyalBlue
        Label4.ForeColor = Color.RoyalBlue
    End Sub

   
    Private Sub PictureBox7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox7.Click
        formu.Dispose()
        formu = finanzas
        formu.MdiParent = Me
        formu.Dock = DockStyle.Fill
        formu.Show()
        Label1.ForeColor = Color.RoyalBlue
        Label2.ForeColor = Color.RoyalBlue
        Label3.ForeColor = Color.RoyalBlue
        Label7.ForeColor = Color.White
        Label4.ForeColor = Color.RoyalBlue
    End Sub
End Class