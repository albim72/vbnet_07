'Zbuduj klasę TrzeciaKlasa dziedzczącą klasę DrugaKlasa,
'dodaj pole Integer -> d oraz przekaż z dziedziczenia (a,b,c)
'zbuduj metodę printABCD -> wyświetl wszystkie 4 wartości
'zbuduj metodę suma() -> wykonaj sumowanie wszysktich 4 wartości
'metoda suma nie jest nową metodą tylko przesłoniętą metodą suma() z DrugaKlasa (Overridable)

Public Class TrzeciaKlasa
  Public d As Integer

    Public Sub New(a As Integer, b As Integer, c As Integer, d As Integer)
        MyBase.New(a, b, c)
        Me.d = d
    End Sub

    Public Function printABCD() As String
        Console.WriteLine($"a = {a}, b = {b}, c = {c}, d={d}")
    End Function

    Public Overrides Function suma() As Integer
         Return MyBase.suma() + d
    End Function

End Class
