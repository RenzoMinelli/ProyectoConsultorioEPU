Public Class Menu_Inicio
    Dim formu As New Form



    Private Sub Menu_Inicio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        actPos()
        formu = Pacientes
        formu.MdiParent = Me
        formu.Dock = DockStyle.Right
        formu.Show()
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        formu.Dispose()
        formu = Pacientes
        formu.MdiParent = Me
        formu.Dock = DockStyle.Right
        formu.Show()
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        formu.Dispose()
        formu = Aranceles
        formu.MdiParent = Me
        formu.Dock = DockStyle.Right
        formu.Show()
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click
        formu.Dispose()
        formu = Citas
        formu.MdiParent = Me
        formu.Dock = DockStyle.Right
        formu.Show()
    End Sub

End Class