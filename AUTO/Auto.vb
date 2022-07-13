Public MustInherit Class Auto
    Public odleglosc As Double
    Public cena_jedn As Double

    Protected Sub New(odleglosc As Double, cena_jedn As Double)
        Me.odleglosc = odleglosc
        Me.cena_jedn = cena_jedn
    End Sub

    Public MustOverride Function policzKosztPaliwa() As Double
End Class
