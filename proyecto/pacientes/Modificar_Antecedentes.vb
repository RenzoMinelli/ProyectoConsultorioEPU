Public Class Modificar_Antecedentes

    Private Sub Modificar_Antecedentes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CheckBox1.Checked = Modificar_Paciente.alergicos
        CheckBox2.Checked = Modificar_Paciente.diabeticos
        CheckBox3.Checked = Modificar_Paciente.cardiovasculares
        CheckBox4.Checked = Modificar_Paciente.fiebre_reumatica
        CheckBox5.Checked = Modificar_Paciente.coagulacion
        CheckBox6.Checked = Modificar_Paciente.odontologicos
        CheckBox7.Checked = Modificar_Paciente.farmacos_recibidos
        CheckBox8.Checked = Modificar_Paciente.familiares
        CheckBox9.Checked = Modificar_Paciente.tratamiento_medico
        TextBox1.Text = Modificar_Paciente.obs
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Dispose()
        Modificar_Paciente.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Modificar_Paciente.alergicos = CheckBox1.Checked
        Modificar_Paciente.diabeticos = CheckBox2.Checked
        Modificar_Paciente.cardiovasculares = CheckBox3.Checked
        Modificar_Paciente.fiebre_reumatica = CheckBox4.Checked
        Modificar_Paciente.coagulacion = CheckBox5.Checked
        Modificar_Paciente.odontologicos = CheckBox6.Checked
        Modificar_Paciente.farmacos_recibidos = CheckBox7.Checked
        Modificar_Paciente.familiares = CheckBox8.Checked
        Modificar_Paciente.tratamiento_medico = CheckBox9.Checked
        Modificar_Paciente.obs = TextBox1.Text
        Modificar_Paciente.cambio = 1
        Modificar_Paciente.Show()
        Me.Dispose()
    End Sub
End Class