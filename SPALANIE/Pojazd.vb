Public Class Pojazd : Implements IPojazd, IDanePojazdu

    Public marka As String
    Public model As String
    Public poj As Double
    Public rocznik As Integer

    Public Sub New(marka As String, model As String, poj As Double, rocznik As Integer)
        Me.marka = marka
        Me.model = model
        Me.poj = poj
        Me.rocznik = rocznik
    End Sub

    Public Function spalanie(spal As Double, odl As Double) As Double Implements IPojazd.spalanie
        Return spal * 100 / odl
    End Function

    Public Function kosztprzejzadu(spal As Double, odl As Double, cena_l As Double) As Double Implements IPojazd.kosztprzejzadu
        Return spalanie(spal, odl) * (odl / 100) * cena_l
    End Function
    
    Public Function pojazdinfo() As String Implements IDanePojazdu.pojazdinfo
        Return $"Pojazd -> marka: {marka}, model: {model}, pojemność silnika: {poj}, rocznik: {rocznik}."
    End Function
End Class
