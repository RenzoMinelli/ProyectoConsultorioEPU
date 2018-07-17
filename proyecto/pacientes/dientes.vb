Public Class dientes

    Private Sub dientes_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint
        e.Graphics.DrawEllipse(Pens.Blue, 10, 10, 100, 150)
    End Sub

    Private Sub dientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class