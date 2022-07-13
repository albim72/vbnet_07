Public MustInherit Class Figura

    Public a As Double
    Public b As Double

    Protected Sub New(a As Double)
        Me.a = a
    End Sub
    
    Protected Sub New(a As Double, b As Double)
        Me.a = a
        Me.b = b
    End Sub

    Public Sub Info(msg)
        Console.WriteLine(msg)
    End Sub

    Public MustOverride Function policzPole() As Double



End Class
