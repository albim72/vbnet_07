Public Class Benzyna : Inherits Auto

    Public Sub New(odleglosc As Double, cena_jedn As Double)
        MyBase.New(odleglosc, cena_jedn)
    End Sub

    Public Overrides Function policzKosztPaliwa() As Double
        Return 8.8 * odleglosc * cena_jedn / 100
    End Function
End Class
