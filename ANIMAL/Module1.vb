Module Module1

    Sub Main()
        Dim buldog As IAnimal = New Pies()
        buldog.info()
        buldog.odglos()
        Console.WriteLine($"Liczba nóg psa: {buldog.LiczbaNog()}")
        Console.ReadKey()
    End Sub

End Module
