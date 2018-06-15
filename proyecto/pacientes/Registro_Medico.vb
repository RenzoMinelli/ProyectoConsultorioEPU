Public Class Registro_Medico
    Dim a As Integer = 0
    Dim ver As Integer = -1
    Dim xco, yco As Integer
    Dim xc, yc As Integer
    Dim xf, yf As Integer

    Private Sub Registro_Medico_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        actPos()
    End Sub
    Private Sub Panel3_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel35.MouseDown
        a = 1
        ver = 0
    End Sub
    Private Sub Panel3_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel35.MouseMove

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
    Private Sub Panel3_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel35.MouseUp
        xf = Me.Location.X
        yf = Me.Location.Y
        a = 0
    End Sub

    Private Sub Form2_LocationChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.LocationChanged
        If Not ver = -1 Then
            Menu_Inicio.Location = New Point(Me.Location.X - 160, Me.Location.Y)
        End If

    End Sub

    Public Sub actPos()
        Me.Location = New Point(Menu_Inicio.Location.X + 160, Menu_Inicio.Location.Y)
        xf = Me.Location.X
        yf = Me.Location.Y
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Dispose()
        Pacientes.Show()
        Pacientes.actPos()
    End Sub
End Class