Public Class Citas
    Dim cita As String
    Private Sub Citas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
<<<<<<< HEAD
        Dim a As Icon
        a = My.Resources.rambocursor
        Me.Cursor = New Cursor(a.Handle)
=======
>>>>>>> 306a2cf62dc24dc95f016a6a25636e3910ecfddf
    End Sub

    Private Sub Label19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Dispose()
        Aranceles.Show()
    End Sub

    Private Sub Label20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Dispose()
        Pacientes.Show()
    End Sub
End Class