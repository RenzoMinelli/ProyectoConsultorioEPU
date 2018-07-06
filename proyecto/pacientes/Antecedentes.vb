Public Class Antecedentes

    Private Sub Antecedentes2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Consulta = "select * from antecedentes where id_p = '" + Str(id_p) + "';"
        consultar()
        tablita.DataSource = Tabla

        If tablita.Rows(0).Cells(0).Value <> Nothing Then

            Dim alergicos As Boolean = tablita.Rows(0).Cells(1).Value
            Dim diabeticos As Boolean = tablita.Rows(0).Cells(2).Value
            Dim cardiovasculares As Boolean = tablita.Rows(0).Cells(3).Value
            Dim fiebre_reumatica As Boolean = tablita.Rows(0).Cells(4).Value
            Dim coagulacion As Boolean = tablita.Rows(0).Cells(5).Value
            Dim odontologicos As Boolean = tablita.Rows(0).Cells(6).Value
            Dim farmacos_recibidos As Boolean = tablita.Rows(0).Cells(7).Value
            Dim familiares As Boolean = tablita.Rows(0).Cells(8).Value
            Dim tratamiento_medico As Boolean = tablita.Rows(0).Cells(9).Value
            Dim obs As String = tablita.Rows(0).Cells(10).Value

            ListBox1.Items.Add(obs)




            If alergicos = True Then
                PictureBox1.Image = My.Resources.checkmark
            Else
                PictureBox1.Image = My.Resources.X
            End If

            If diabeticos = True Then
                PictureBox2.Image = My.Resources.checkmark
            Else
                PictureBox2.Image = My.Resources.X
            End If

            If cardiovasculares = True Then
                PictureBox3.Image = My.Resources.checkmark
            Else
                PictureBox3.Image = My.Resources.X
            End If

            If fiebre_reumatica = True Then
                PictureBox4.Image = My.Resources.checkmark
            Else
                PictureBox4.Image = My.Resources.X
            End If

            If coagulacion = True Then
                PictureBox5.Image = My.Resources.checkmark
            Else
                PictureBox5.Image = My.Resources.X
            End If

            If odontologicos = True Then
                PictureBox6.Image = My.Resources.checkmark
            Else
                PictureBox6.Image = My.Resources.X
            End If

            If farmacos_recibidos = True Then
                PictureBox7.Image = My.Resources.checkmark
            Else
                PictureBox7.Image = My.Resources.X
            End If

            If familiares = True Then
                PictureBox8.Image = My.Resources.checkmark
            Else
                PictureBox8.Image = My.Resources.X
            End If

            If tratamiento_medico = True Then
                PictureBox9.Image = My.Resources.checkmark
            Else
                PictureBox9.Image = My.Resources.X
            End If

        Else

            MsgBox("Este usuario no tiene " + vbNewLine + "antecedentes registrados", MsgBoxStyle.Exclamation)
            Pacientes.Show()

        End If

        


    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Pacientes.Show()
        Me.Dispose()
    End Sub
End Class