Public Class Citas
    Dim cita As String
    Private Sub Citas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim a As Icon
        a = My.Resources.rambocursor
        Me.Cursor = New Cursor(a.Handle)

        MsgBox(Str(AxCalendar1.Day))

    End Sub

    Private Sub Label19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Dispose()
        Aranceles.Show()
    End Sub

    Private Sub Label20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Dispose()
        Pacientes.Show()
    End Sub

    Private Sub AxCalendar1_OnDayClick(ByVal sender As System.Object, ByVal e As AxCALENDARLib._DCalendarEvents_OnDayClickEvent) Handles AxCalendar1.OnDayClick
        MsgBox(Str(AxCalendar1.Day))
    End Sub

    Private Sub SaveFileDialog3_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)

    End Sub
End Class