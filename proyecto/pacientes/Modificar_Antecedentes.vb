Public Class Modificar_Antecedentes

    Private Sub Modificar_Antecedentes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        chbxAlergicos.Checked = Modificar_Paciente.alergicos
        chbxDiabeticos.Checked = Modificar_Paciente.diabeticos
        chbxCardiovasculares.Checked = Modificar_Paciente.cardiovasculares
        chbxFiebreReumatica.Checked = Modificar_Paciente.fiebre_reumatica
        chbxCoagulacion.Checked = Modificar_Paciente.coagulacion
        chbxOdontologicos.Checked = Modificar_Paciente.odontologicos
        chbxFarmacosRecibidos.Checked = Modificar_Paciente.farmacos_recibidos
        chbxFamiliares.Checked = Modificar_Paciente.familiares
        chbxTratamientosMedicos.Checked = Modificar_Paciente.tratamiento_medico
        txbObservaciones.Text = Modificar_Paciente.observaciones
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Dispose()
        Modificar_Paciente.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Modificar_Paciente.alergicos = chbxAlergicos.Checked
        Modificar_Paciente.diabeticos = chbxDiabeticos.Checked
        Modificar_Paciente.cardiovasculares = chbxCardiovasculares.Checked
        Modificar_Paciente.fiebre_reumatica = chbxFiebreReumatica.Checked
        Modificar_Paciente.coagulacion = chbxCoagulacion.Checked
        Modificar_Paciente.odontologicos = chbxOdontologicos.Checked
        Modificar_Paciente.farmacos_recibidos = chbxFarmacosRecibidos.Checked
        Modificar_Paciente.familiares = chbxFamiliares.Checked
        Modificar_Paciente.tratamiento_medico = chbxTratamientosMedicos.Checked
        Modificar_Paciente.observaciones = txbObservaciones.Text
        Modificar_Paciente.cambio = 1
        Modificar_Paciente.Show()
        Me.Dispose()
    End Sub
End Class