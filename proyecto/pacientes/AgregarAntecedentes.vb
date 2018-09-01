Public Class AgregarAntecedentes
    Dim frmContenedor As New Form
    Private Sub Agregar_Antecedentes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        chbxAlergicos.Checked = IngresarPaciente.alergicos
        chbxDiabeticos.Checked = IngresarPaciente.diabeticos
        chbxCardiovasculares.Checked = IngresarPaciente.cardiovasculares
        chbxFiebreReumatica.Checked = IngresarPaciente.fiebre_reumatica
        chbxCoagulacion.Checked = IngresarPaciente.coagulacion
        chbxOdontologicos.Checked = IngresarPaciente.odontologicos
        chbxFarmacosRecibidos.Checked = IngresarPaciente.farmacos_recibidos
        chbxFamiliares.Checked = IngresarPaciente.familiares
        chbxTratamientoMedico.Checked = IngresarPaciente.tratamiento_medico
        txbObservaciones.Text = IngresarPaciente.observaciones
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAtras.Click

        IngresarPaciente.alergicos = chbxAlergicos.Checked
        IngresarPaciente.diabeticos = chbxDiabeticos.Checked
        IngresarPaciente.cardiovasculares = chbxCardiovasculares.Checked
        IngresarPaciente.fiebre_reumatica = chbxFiebreReumatica.Checked
        IngresarPaciente.coagulacion = chbxCoagulacion.Checked
        IngresarPaciente.odontologicos = chbxOdontologicos.Checked
        IngresarPaciente.farmacos_recibidos = chbxFarmacosRecibidos.Checked
        IngresarPaciente.familiares = chbxFamiliares.Checked
        IngresarPaciente.tratamiento_medico = chbxTratamientoMedico.Checked
        IngresarPaciente.observaciones = txbObservaciones.Text

        IngresarPaciente.Show()
        Me.Dispose()
    End Sub
End Class