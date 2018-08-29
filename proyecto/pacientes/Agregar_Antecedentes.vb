Public Class Agregar_Antecedentes
    Dim frmContenedor As New Form
    Private Sub Agregar_Antecedentes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        chbxAlergicos.Checked = Ingresar_Paciente.alergicos
        chbxDiabeticos.Checked = Ingresar_Paciente.diabeticos
        chbxCardiovasculares.Checked = Ingresar_Paciente.cardiovasculares
        chbxFiebreReumatica.Checked = Ingresar_Paciente.fiebre_reumatica
        chbxCoagulacion.Checked = Ingresar_Paciente.coagulacion
        chbxOdontologicos.Checked = Ingresar_Paciente.odontologicos
        chbxFarmacosRecibidos.Checked = Ingresar_Paciente.farmacos_recibidos
        chbxFamiliares.Checked = Ingresar_Paciente.familiares
        chbxTratamientoMedico.Checked = Ingresar_Paciente.tratamiento_medico
        txbObservaciones.Text = Ingresar_Paciente.observaciones
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAtras.Click

        Ingresar_Paciente.alergicos = chbxAlergicos.Checked
        Ingresar_Paciente.diabeticos = chbxDiabeticos.Checked
        Ingresar_Paciente.cardiovasculares = chbxCardiovasculares.Checked
        Ingresar_Paciente.fiebre_reumatica = chbxFiebreReumatica.Checked
        Ingresar_Paciente.coagulacion = chbxCoagulacion.Checked
        Ingresar_Paciente.odontologicos = chbxOdontologicos.Checked
        Ingresar_Paciente.farmacos_recibidos = chbxFarmacosRecibidos.Checked
        Ingresar_Paciente.familiares = chbxFamiliares.Checked
        Ingresar_Paciente.tratamiento_medico = chbxTratamientoMedico.Checked
        Ingresar_Paciente.observaciones = txbObservaciones.Text

        Ingresar_Paciente.Show()
        Me.Dispose()
    End Sub
End Class