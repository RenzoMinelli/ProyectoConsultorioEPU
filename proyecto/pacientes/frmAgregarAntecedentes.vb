Public Class frmAgregarAntecedentes
    Dim frmContenedor As New Form
    Private Sub Agregar_Antecedentes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        chbxAlergicos.Checked = frmIngresarPaciente.alergicos
        chbxDiabeticos.Checked = frmIngresarPaciente.diabeticos
        chbxCardiovasculares.Checked = frmIngresarPaciente.cardiovasculares
        chbxFiebreReumatica.Checked = frmIngresarPaciente.fiebre_reumatica
        chbxCoagulacion.Checked = frmIngresarPaciente.coagulacion
        chbxOdontologicos.Checked = frmIngresarPaciente.odontologicos
        chbxFarmacosRecibidos.Checked = frmIngresarPaciente.farmacos_recibidos
        chbxFamiliares.Checked = frmIngresarPaciente.familiares
        chbxTratamientoMedico.Checked = frmIngresarPaciente.tratamiento_medico
        txbObservaciones.Text = frmIngresarPaciente.observaciones
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAtras.Click

        frmIngresarPaciente.alergicos = chbxAlergicos.Checked
        frmIngresarPaciente.diabeticos = chbxDiabeticos.Checked
        frmIngresarPaciente.cardiovasculares = chbxCardiovasculares.Checked
        frmIngresarPaciente.fiebre_reumatica = chbxFiebreReumatica.Checked
        frmIngresarPaciente.coagulacion = chbxCoagulacion.Checked
        frmIngresarPaciente.odontologicos = chbxOdontologicos.Checked
        frmIngresarPaciente.farmacos_recibidos = chbxFarmacosRecibidos.Checked
        frmIngresarPaciente.familiares = chbxFamiliares.Checked
        frmIngresarPaciente.tratamiento_medico = chbxTratamientoMedico.Checked
        frmIngresarPaciente.observaciones = txbObservaciones.Text

        frmIngresarPaciente.Show()
        Me.Dispose()
    End Sub
End Class