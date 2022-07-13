Public Class Diesel : Inherits Auto

    Public Sub New(odleglosc As Double, cena_jedn As Double)
        MyBase.New(odleglosc, cena_jedn)
    End Sub

    Public Overrides Function policzKosztPaliwa() As Double
        Return 7.2 * odleglosc * cena_jedn / 100
    End Function
End Class
