Module Module1

    'Stwórz po jednym obiekcie dla każdej z 3 klas i wykonaj dla każdego obieektu maksymalną
    'liczbę dostępnych metod

    Sub Main()

        Dim pk As PierwszaKlasa = New PierwszaKlasa(5, 8)
        pk.printAB()

        Console.WriteLine("*********************************")

        Dim dk As DrugaKlasa = New DrugaKlasa(3, 12, 7)
        dk.printAB()
        dk.printABC()
        Console.WriteLine($"suma a+b+c = {dk.suma()}")

        Console.WriteLine("*********************************")

        Dim tk As TrzeciaKlasa = New TrzeciaKlasa(98, 3, 1, 15)
        tk.printAB()
        tk.printABC()
        tk.printABCD()
        Console.WriteLine($"suma a+b+c+d = {tk.suma()}")



        Console.ReadKey()
    End Sub

End Module
