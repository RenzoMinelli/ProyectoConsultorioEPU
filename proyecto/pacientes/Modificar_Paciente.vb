Public Class Modificar_Paciente

    Dim nac2 As String

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim ver As Integer = 0
        Dim ver2 As Integer = 0
        Dim ver3 As Integer = 0
        Dim ver4 As Integer = 0
        Dim ver5 As Integer = 0
        Dim ver6 As Integer = 0

        If TextBox1.Text <> "" And TextBox2.Text <> "" And TextBox4.Text <> "" Then

            If TextBox1.Text <> nombre Then
                ver = 1
                nombre = TextBox1.Text
            End If
            If TextBox2.Text <> cedula Then
                ver2 = 1
                cedula = TextBox2.Text
            End If
            If TextBox3.Text <> enviado Then
                ver3 = 1
                enviado = TextBox3.Text
            End If
            If TextBox4.Text <> direccion Then
                ver4 = 1
                direccion = TextBox4.Text
            End If
            If TextBox5.Text <> direTra Then
                ver5 = 1
                direTra = TextBox5.Text
            End If
            If nac <> nac2 Then
                ver6 = 1
            End If

            nac = MonthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd")
            Try
                If ver = 1 Then
                    Consulta = "UPDATE paciente SET nombre = '" + nombre + "' WHERE id_p = " + Str(id_p) + ";"
                    consultar()
                End If
                If ver2 = 1 Then
                    Consulta = "UPDATE paciente SET cedula = '" + cedula + "' WHERE id_p = " + Str(id_p) + ";"
                    consultar()
                End If
                If ver3 = 1 Then
                    Consulta = "UPDATE paciente SET enviado_por = '" + enviado + "' WHERE id_p = " + Str(id_p) + ";"
                    consultar()
                End If
                If ver4 = 1 Then
                    Consulta = "UPDATE paciente SET direccion_particular = '" + direccion + "' WHERE id_p = " + Str(id_p) + ";"
                    consultar()
                End If
                If ver5 = 1 Then
                    Consulta = "UPDATE paciente SET direccion_trabajo = '" + direTra + "' WHERE id_p = " + Str(id_p) + ";"
                    consultar()
                End If
                If ver6 = 1 Then
                    Consulta = "UPDATE paciente SET fecha_nacimiento = '" + nac + "' WHERE id_p = " + Str(id_p) + ";"
                    consultar()
                End If

                MsgBox("Guardado con Exito")

                Pacientes.Show()
                Pacientes.actTabla()
                Pacientes.actPanel()
                Me.Dispose()

            Catch ex As Exception

                MsgBox("Error")

            End Try
            
        Else

            MsgBox("Complete los campos necesarios")

        End If


    End Sub

    Private Sub MonthCalendar1_DateChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles MonthCalendar1.DateChanged
        nac2 = MonthCalendar1.SelectionRange.Start
        Label7.Text = "Fecha seleccionada " + nac2
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Size = New System.Drawing.Size(704, 440)
        TextBox1.Text = nombre
        TextBox2.Text = cedula
        TextBox3.Text = enviado
        TextBox4.Text = direccion
        TextBox5.Text = direTra
        MonthCalendar1.SelectionRange.Start = nac
        Label7.Text = "Fecha seleccionada " + nac
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        Pacientes.Show()
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        Aranceles.Dispose()
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class