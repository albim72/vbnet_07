Public Class Trojkat : Inherits Figura

    Public Sub New(a As Double, b As Double)
        MyBase.New(a, b)
    End Sub

    Public Overrides Function policzPole() As Double
        Return a * b / 2
    End Function
End Class
