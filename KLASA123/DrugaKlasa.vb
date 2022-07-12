'Zbuduj klasę DrugaKlasa dziedzczącą klasę PierwszaKlasa,
'dodaj pole Integer -> c oraz przekaż z dziedziczenia (a,b)
'zbuduj metodę printABC -> wyświetl wszystkie 3 wartości
'zbuduj metodę suma() -> wykonaj sumowanie wszysktich 3 wartości

Public Class DrugaKlasa
 Public c As Integer

    Public Sub New(a As Integer, b As Integer, c As Integer)
        MyBase.New(a, b)
        Me.c = c
    End Sub

    Public Function printABC() As String
        Console.WriteLine($"a = {a}, b = {b}, c = {c}")
    End Function

 Public Overridable Function suma() As Integer
        Return a + b + c
    End Function
End Class
