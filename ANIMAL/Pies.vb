Public Class Pies : Implements IAnimal

    Public Sub odglos() Implements IAnimal.odglos
        Console.WriteLine("Pies szczeka....")
    End Sub

    Public Sub info() Implements IAnimal.info
        Console.WriteLine("Pies - zwierzę domowe...")
    End Sub

    Public Function LiczbaNog() As Integer Implements IAnimal.LiczbaNog
        Return 4
    End Function
End Class
