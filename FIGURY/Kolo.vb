Public Class Kolo : Inherits Figura

    Public Sub New(a As Double)
        MyBase.New(a)
    End Sub

    Public Overrides Function policzPole() As Double
        Return Math.PI * a ^ 2
    End Function
    'zbuduj klasę Kolo dziedziczącą Figurę, policz pole koła
    'Math.PI*a^2



End Class
