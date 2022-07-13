Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListView1.FullRowSelect = True
        ListView1.HideSelection = False

        ListView1.View = View.Details

        Dim h0 As New ColumnHeader
        Dim h1 As New ColumnHeader
        Dim h2 As New ColumnHeader

        h0.Text = "kolumna 0"
        h1.Text = "kolumna 1"
        h2.Text = "kolumna 2"

        ListView1.Columns.Add(h0)
        ListView1.Columns.Add(h1)
        ListView1.Columns.Add(h2)

        For i As Integer = 0 To 10
            With ListView1.Items.Add($"przypadek {i} - 0")
                .SubItems.Add($"przypdek {i} -1")
                .SubItems.Add($"przypdek {i} -2")
                .SubItems.Add($"przypdek {i} -3")

            End With
        Next
    End Sub
End Class
