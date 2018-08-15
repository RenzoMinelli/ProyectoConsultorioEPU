Public Class Agregar_Antecedentes
    Dim frmContenedor As New Form
    Private Sub Agregar_Antecedentes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        chbxAlergicos.Checked = Agregar_Paciente.alergicos
        chbxDiabeticos.Checked = Agregar_Paciente.diabeticos
        chbxCardiovasculares.Checked = Agregar_Paciente.cardiovasculares
        chbxFiebreReumatica.Checked = Agregar_Paciente.fiebre_reumatica
        chbxCoagulacion.Checked = Agregar_Paciente.coagulacion
        chbxOdontologicos.Checked = Agregar_Paciente.odontologicos
        chbxFarmacosRecibidos.Checked = Agregar_Paciente.farmacos_recibidos
        chbxFamiliares.Checked = Agregar_Paciente.familiares
        chbxTratamientoMedico.Checked = Agregar_Paciente.tratamiento_medico
        txbObservaciones.Text = Agregar_Paciente.observaciones
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAtras.Click

        Agregar_Paciente.alergicos = chbxAlergicos.Checked
        Agregar_Paciente.diabeticos = chbxDiabeticos.Checked
        Agregar_Paciente.cardiovasculares = chbxCardiovasculares.Checked
        Agregar_Paciente.fiebre_reumatica = chbxFiebreReumatica.Checked
        Agregar_Paciente.coagulacion = chbxCoagulacion.Checked
        Agregar_Paciente.odontologicos = chbxOdontologicos.Checked
        Agregar_Paciente.farmacos_recibidos = chbxFarmacosRecibidos.Checked
        Agregar_Paciente.familiares = chbxFamiliares.Checked
        Agregar_Paciente.tratamiento_medico = chbxTratamientoMedico.Checked
        Agregar_Paciente.observaciones = txbObservaciones.Text

        Agregar_Paciente.Show()
        Me.Dispose()
    End Sub
End Class