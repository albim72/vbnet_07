Module Module1

    Sub Main()
        Dim os1 As Osoba = New Osoba("Olga", "Nowak", 27, 172, 56)
        os1.printOsoba()
        Console.WriteLine(os1.wiekza10lat())
        Console.WriteLine($"Czy osoba jest pracownikiem?? {os1.czyPracownik()}")


        Dim pr1 As Pracownik = New Pracownik("Paweł", "Bloch", 45, 176, 99, "ABC SA", "dyrektor", 12, 9800)
        pr1.printOsoba()
        pr1.printPracownik()
        Console.WriteLine(pr1.wiekza10lat())
        Console.WriteLine($"Czy osoba jest pracownikiem?? {pr1.czyPracownik()}")


        Dim s1 As Student = New Student("Ola", "Nowik", 22, 170, 56, 5454, "informatyka", 3, "ABC", "sekretarka", 1, 2300)
        s1.printOsoba()
        s1.printPracownik()
        s1.printStudent()
        Console.WriteLine($"Czy osoba jest pracownikiem?? {s1.czyPracownik()}")
        
        Dim sp1 As Sportowiec = New Sportowiec("Maria", "Nowak", 33, 176, 63, "biegi ultra", 8, "102km 18h 17min 45s")
        sp1.printOsoba()
        sp1.infosport()
        Console.WriteLine(sp1.wiekza10lat())
        Console.WriteLine($"Czy osoba jest pracownikiem?? {sp1.czyPracownik()}")
        
        
        Console.ReadKey()
    End Sub

End Module
