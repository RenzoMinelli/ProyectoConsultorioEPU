Public Class Antecedentes

    Private Sub Antecedentes2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Consulta = "select * from antecedentes where id_p = '" + Str(id_p) + "';"
        consultar()
        tablita.DataSource = Tabla

        If tablita.Rows(0).Cells(1).Value = True Then
            CheckBox1.Checked = True
        Else
            CheckBox1.Checked = False
        End If

        If tablita.Rows(0).Cells(2).Value = True Then
            CheckBox2.Checked = True
        Else
            CheckBox2.Checked = False
        End If

        If tablita.Rows(0).Cells(3).Value = True Then
            CheckBox3.Checked = True
        Else
            CheckBox3.Checked = False
        End If

        If tablita.Rows(0).Cells(4).Value = True Then
            CheckBox4.Checked = True
        Else
            CheckBox4.Checked = False
        End If

        If tablita.Rows(0).Cells(5).Value = True Then
            CheckBox5.Checked = True
        Else
            CheckBox5.Checked = False
        End If

        If tablita.Rows(0).Cells(6).Value = True Then
            CheckBox6.Checked = True
        Else
            CheckBox6.Checked = False
        End If

        If tablita.Rows(0).Cells(7).Value = True Then
            CheckBox7.Checked = True
        Else
            CheckBox7.Checked = False
        End If

        If tablita.Rows(0).Cells(8).Value = True Then
            CheckBox8.Checked = True
        Else
            CheckBox8.Checked = False
        End If

        If tablita.Rows(0).Cells(9).Value = True Then
            CheckBox9.Checked = True
        Else
            CheckBox9.Checked = False
        End If
    End Sub
End Class