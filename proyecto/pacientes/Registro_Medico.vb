Public Class Registro_Medico
    Dim a As Integer = 0
    Dim xco, yco As Integer
    Dim xc, yc As Integer

    Private Sub Registro_Medico_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        actPos()
        Consulta = "Select * from registro_medico where id_p = '" + Str(id_p) + "'"
        consultar()
        DataGridView1.DataSource = Tabla
        actBoca()
    End Sub
    Private Sub Panel3_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel159.MouseDown
        a = 1
    End Sub
    Private Sub Panel3_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel159.MouseMove

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
    Private Sub Panel3_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel159.MouseUp
        xf = Menu_Inicio.Location.X
        yf = Menu_Inicio.Location.Y
        a = 0
    End Sub
    Private Sub actBoca()
        Dim zona As String = ""
        For x As Integer = 0 To DataGridView1.RowCount - 1

            If Not IsDBNull(DataGridView1.Rows(x).Cells(2).Value) Then
                Select Case DataGridView1.Rows(x).Cells(2).Value
                    Case "nor-este"
                        zona = "2"
                    Case "nor-oeste"
                        zona = "1"
                    Case "sur-este"
                        zona = "4"
                    Case "sur-oeste"
                        zona = "3"
                End Select

                zona += DataGridView1.Rows(x).Cells(3).Value.ToString

                Select Case zona
                    Case "11"
                        Panel11.BackColor = Color.Red
                    Case "12"
                        Panel12.BackColor = Color.Red
                    Case "24"
                        If DataGridView1.Rows(x).Cells(1).Value = "malo" Then
                            Panel24.BackColor = Color.Red
                        ElseIf DataGridView1.Rows(x).Cells(1).Value = "bueno" Then
                            Panel24.BackColor = Color.Green
                        Else
                            Panel24.BackColor = Color.White
                        End If


                End Select
            End If
        Next
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Dispose()
        Pacientes.Show()
    End Sub
End Class