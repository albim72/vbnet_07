Module Module1

    Sub Main()

        Dim pr As Prostokat = New Prostokat(4.5, 7.2)
        Console.WriteLine($"Pole prostokąta wynosi: {pr.policzPole()}")

        Dim tr As Trojkat = New Trojkat(4.4, 6.7)
        Console.WriteLine($"Pole trójkąta wynosi: {tr.policzPole()}")

        Dim trp As Trapez = New Trapez(6.8, 4.8, 4.6)
        Console.WriteLine($"Pole trapezu wynosi: {trp.policzPole()}")
        
        Dim kl As Kolo = New Kolo(5.5)
        Console.WriteLine($"Pole koła wynosi: {kl.policzPole()}")


        Console.ReadKey()

    End Sub

End Module
