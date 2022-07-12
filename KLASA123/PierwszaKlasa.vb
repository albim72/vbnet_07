Public Class PierwszaKlasa

    Public a As Integer
    Public b As Integer

    Public Sub New(a As Integer, b As Integer)
        Me.a = a
        Me.b = b
    End Sub

    Public Function printAB() As String
        Console.WriteLine($"a = {a}, b = {b}")
    End Function
End Class
