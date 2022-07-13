Module Module1

    Sub Main()

        Dim pr As IPojazd = New Pojazd()
        Dim sp As Double
        Dim ko As Double

        sp = pr.spalanie(45, 344)
        ko = pr.kosztprzejzadu(88, 700, 7.65)
        Console.WriteLine($"średnie spalanie [l/100km]: {Format(sp, "0.00")}")

        Console.WriteLine($"koszt przejazdu: {Format(ko, "0.00")} zł")

        Console.ReadKey()

    End Sub

End Module
