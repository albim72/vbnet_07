Public Class Box

    Public szerokosc As Double
    Public glebokosc As Double
    Public wysokosc As Double

    Public Sub set_szerokosc(ByVal szer As Double)
        szerokosc = szer
    End Sub


    Public Sub set_wysokosc(ByVal wys As Double)
        wysokosc = wys
    End Sub

    Public Sub set_glebokosc(ByVal gleb As Double)
        glebokosc = gleb
    End Sub

    Public Function getObjetosc() As Double
        Return szerokosc * wysokosc * glebokosc
    End Function



End Class
