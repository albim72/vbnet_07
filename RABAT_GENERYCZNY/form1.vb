Public Class Form1

    Public Function mnozenie(a, b)
        Return a * b
    End Function
    Public Function ObliczRabat(Of R, T)(ByRef kwota As R, ByRef rabat As T)
        Dim wynik As T

        wynik = mnozenie(kwota, rabat)

        Return wynik

    End Function

    Public Function Rabat(kw)
        If kw >= 500 And kw < 1000 Then
            Return ObliczRabat(Of Integer, Double)(kw, 0.05)
        ElseIf kw >= 1000 And kw < 1500 Then
            Return ObliczRabat(Of Integer, Double)(kw, 0.1)
        ElseIf kw >= 1500 And kw < 2000 Then
            Return ObliczRabat(Of Integer, Double)(kw, 0.15)
        ElseIf kw >= 2000 Then
            Return ObliczRabat(Of Integer, Double)(kw, 0.22)
        Else
            Return 0
        End If
    End Function
    Private Sub btnPolicz_Click(sender As Object, e As EventArgs) Handles btnPolicz.Click
        lbWynik.Text = Rabat(CDbl(tbKwota.Text))
    End Sub
End Class
