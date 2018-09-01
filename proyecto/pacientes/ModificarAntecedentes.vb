Public Class ModificarAntecedentes

    Private Sub Modificar_Antecedentes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        chbxAlergicos.Checked = ModificarPaciente.alergicos
        chbxDiabeticos.Checked = ModificarPaciente.diabeticos
        chbxCardiovasculares.Checked = ModificarPaciente.cardiovasculares
        chbxFiebreReumatica.Checked = ModificarPaciente.fiebre_reumatica
        chbxCoagulacion.Checked = ModificarPaciente.coagulacion
        chbxOdontologicos.Checked = ModificarPaciente.odontologicos
        chbxFarmacosRecibidos.Checked = ModificarPaciente.farmacos_recibidos
        chbxFamiliares.Checked = ModificarPaciente.familiares
        chbxTratamientosMedicos.Checked = ModificarPaciente.tratamiento_medico
        txbObservaciones.Text = ModificarPaciente.observaciones
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Dispose()
        ModificarPaciente.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        ModificarPaciente.alergicos = chbxAlergicos.Checked
        ModificarPaciente.diabeticos = chbxDiabeticos.Checked
        ModificarPaciente.cardiovasculares = chbxCardiovasculares.Checked
        ModificarPaciente.fiebre_reumatica = chbxFiebreReumatica.Checked
        ModificarPaciente.coagulacion = chbxCoagulacion.Checked
        ModificarPaciente.odontologicos = chbxOdontologicos.Checked
        ModificarPaciente.farmacos_recibidos = chbxFarmacosRecibidos.Checked
        ModificarPaciente.familiares = chbxFamiliares.Checked
        ModificarPaciente.tratamiento_medico = chbxTratamientosMedicos.Checked
        ModificarPaciente.observaciones = txbObservaciones.Text
        ModificarPaciente.cambio = 1
        ModificarPaciente.Show()
        Me.Dispose()
    End Sub
End Class