Public Class Antecedentes

    Private Sub Antecedentes2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Consulta = "select * from antecedentes where id_p = '" + Str(id_p) + "';"
        consultar()
        tablita.DataSource = Tabla
        Dim alergicos As Boolean = tablita.Rows(0).Cells(1).Value
        Dim fiebre_reumatica As Boolean = tablita.Rows(0).Cells(2).Value
        Dim farmacos_recibidos As Boolean = tablita.Rows(0).Cells(3).Value
        Dim diabeticos As Boolean = tablita.Rows(0).Cells(4).Value
        Dim coagulacion As Boolean = tablita.Rows(0).Cells(5).Value
        Dim familiares As Boolean = tablita.Rows(0).Cells(6).Value
        Dim cardiovasculares As Boolean = tablita.Rows(0).Cells(7).Value
        Dim odontologicos As Boolean = tablita.Rows(0).Cells(8).Value
        Dim tratamiento_medico As Boolean = tablita.Rows(0).Cells(9).Value

        DataGridView1.ColumnCount = 2
        DataGridView1.RowCount = 9

        DataGridView1.Rows(0).Cells(0).Value = "alergicos"
        If alergicos = "true" Then
            DataGridView1.Rows(0).Cells(1).Value = GetType(Boolean)
        Else
            DataGridView1.Rows(0).Cells(1).Value = False
        End If
        DataGridView1.Rows(1).Cells(0).Value = "fiebre reumatica"
        DataGridView1.Rows(1).Cells(1).Value = fiebre_reumatica
        DataGridView1.Rows(2).Cells(0).Value = "farmacos recibidos"
        DataGridView1.Rows(2).Cells(1).Value = farmacos_recibidos
        DataGridView1.Rows(3).Cells(0).Value = "diabeticos"
        DataGridView1.Rows(3).Cells(1).Value = diabeticos
        DataGridView1.Rows(4).Cells(0).Value = "coagulacion"
        DataGridView1.Rows(4).Cells(1).Value = coagulacion
        DataGridView1.Rows(5).Cells(0).Value = "familiares"
        DataGridView1.Rows(5).Cells(1).Value = familiares
        DataGridView1.Rows(6).Cells(0).Value = "cardiovasculares"
        DataGridView1.Rows(6).Cells(1).Value = cardiovasculares
        DataGridView1.Rows(7).Cells(0).Value = "odontologicos"
        DataGridView1.Rows(7).Cells(1).Value = odontologicos
        DataGridView1.Rows(8).Cells(0).Value = "tratamiento medico"
        DataGridView1.Rows(8).Cells(1).Value = tratamiento_medico


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