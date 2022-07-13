Public Class Pojazd : Implements IPojazd

    Public Function spalanie(spal As Double, odl As Double) As Double Implements IPojazd.spalanie
        Return spal * 100 / odl
    End Function

    Public Function kosztprzejzadu(spal As Double, odl As Double, cena_l As Double) As Double Implements IPojazd.kosztprzejzadu
        Return spalanie(spal, odl) * (odl / 100) * cena_l
    End Function
End Class
