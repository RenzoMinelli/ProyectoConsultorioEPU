Public Class frmModificarAntecedentes

    Private Sub Modificar_Antecedentes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        chbxAlergicos.Checked = frmModificarPaciente.alergicos
        chbxDiabeticos.Checked = frmModificarPaciente.diabeticos
        chbxCardiovasculares.Checked = frmModificarPaciente.cardiovasculares
        chbxFiebreReumatica.Checked = frmModificarPaciente.fiebre_reumatica
        chbxCoagulacion.Checked = frmModificarPaciente.coagulacion
        chbxOdontologicos.Checked = frmModificarPaciente.odontologicos
        chbxFarmacosRecibidos.Checked = frmModificarPaciente.farmacos_recibidos
        chbxFamiliares.Checked = frmModificarPaciente.familiares
        chbxTratamientosMedicos.Checked = frmModificarPaciente.tratamiento_medico
        txbObservaciones.Text = frmModificarPaciente.observaciones
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Dispose()
        frmModificarPaciente.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        frmModificarPaciente.alergicos = chbxAlergicos.Checked
        frmModificarPaciente.diabeticos = chbxDiabeticos.Checked
        frmModificarPaciente.cardiovasculares = chbxCardiovasculares.Checked
        frmModificarPaciente.fiebre_reumatica = chbxFiebreReumatica.Checked
        frmModificarPaciente.coagulacion = chbxCoagulacion.Checked
        frmModificarPaciente.odontologicos = chbxOdontologicos.Checked
        frmModificarPaciente.farmacos_recibidos = chbxFarmacosRecibidos.Checked
        frmModificarPaciente.familiares = chbxFamiliares.Checked
        frmModificarPaciente.tratamiento_medico = chbxTratamientosMedicos.Checked
        frmModificarPaciente.observaciones = txbObservaciones.Text
        frmModificarPaciente.cambio = 1
        frmModificarPaciente.Show()
        Me.Dispose()
    End Sub
End Class