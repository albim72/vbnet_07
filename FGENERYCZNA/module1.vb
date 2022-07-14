Module Module1

    Public Sub Swap(Of T)(ByRef a As T, ByRef b As T)
        Dim temp As T
        temp = a
        a = b
        b = temp

    End Sub

    Sub Main()

        Dim I As Integer = 18
        Dim J As Integer = 7

        Console.WriteLine($"początkowo wartość I = {I}")
        Console.WriteLine($"początkowo wartość J = {J}")
        Swap(Of Integer)(I, J)
        Console.WriteLine($"wartość I = {I}")
        Console.WriteLine($"wartość J = {J}")

        Dim S As String = "Olaf"
        Dim R As String = "Nadia"

        Console.WriteLine($"początkowo wartość S = {S}")
        Console.WriteLine($"początkowo wartość R = {R}")

        Swap(Of String)(S, R)

        Console.WriteLine($"wartość S = {S}")
        Console.WriteLine($"wartość R = {R}")



        Dim B As Boolean = False
        Dim Z As Boolean = True

        Console.WriteLine($"początkowo wartość B = {B}")
        Console.WriteLine($"początkowo wartość Z = {Z}")

        Swap(Of Boolean)(B, Z)

        Console.WriteLine($"wartość B = {B}")
        Console.WriteLine($"wartość Z = {Z}")

        Console.ReadKey()


    End Sub

End Module
