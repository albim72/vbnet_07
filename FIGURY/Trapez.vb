Public Class Trapez : Inherits Figura
    Public h As Double

    Public Sub New(a As Double, b As Double, h As Double)
        MyBase.New(a, b)
        Me.h = h
    End Sub

    Public Overrides Function policzPole() As Double
        Return (a + b) * h / 2
    End Function
End Class
