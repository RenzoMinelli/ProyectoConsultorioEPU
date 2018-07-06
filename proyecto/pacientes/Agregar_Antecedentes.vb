Public Class Agregar_Antecedentes
    Dim formu As New Form
    Private Sub Agregar_Antecedentes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CheckBox1.Checked = Agregar_Paciente.alergicos
        CheckBox2.Checked = Agregar_Paciente.diabeticos
        CheckBox3.Checked = Agregar_Paciente.cardiovasculares
        CheckBox4.Checked = Agregar_Paciente.fiebre_reumatica
        CheckBox5.Checked = Agregar_Paciente.coagulacion
        CheckBox6.Checked = Agregar_Paciente.odontologicos
        CheckBox7.Checked = Agregar_Paciente.farmacos_recibidos
        CheckBox8.Checked = Agregar_Paciente.familiares
        CheckBox9.Checked = Agregar_Paciente.tratamiento_medico
        TextBox1.Text = Agregar_Paciente.obs
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Agregar_Paciente.alergicos = CheckBox1.Checked
        Agregar_Paciente.diabeticos = CheckBox2.Checked
        Agregar_Paciente.cardiovasculares = CheckBox3.Checked
        Agregar_Paciente.fiebre_reumatica = CheckBox4.Checked
        Agregar_Paciente.coagulacion = CheckBox5.Checked
        Agregar_Paciente.odontologicos = CheckBox6.Checked
        Agregar_Paciente.farmacos_recibidos = CheckBox7.Checked
        Agregar_Paciente.familiares = CheckBox8.Checked
        Agregar_Paciente.tratamiento_medico = CheckBox9.Checked
        Agregar_Paciente.obs = TextBox1.Text

        Agregar_Paciente.Show()
        Me.Dispose()
    End Sub
End Class