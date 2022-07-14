Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtString.CustomFormat = "yyyy-MM-dd"
        dtString.Format = DateTimePickerFormat.Custom
    End Sub

    Private Sub dtString_ValueChanged(sender As Object, e As EventArgs) Handles dtString.ValueChanged
        Dim data As Date = dtString.Value.ToString
        lbWynik.Text = data
    End Sub
End Class
