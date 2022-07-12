Module Module1

    Sub Main()

        Dim cars As New List(Of Car) From
            {
            New Car With {.Name = "car1", .Color = "blue", .Speed = 200},
            New Car With {.Name = "car2", .Color = "blue", .Speed = 200},
            New Car With {.Name = "car3", .Color = "green", .Speed = 180},
            New Car With {.Name = "car4", .Color = "green", .Speed = 240},
            New Car With {.Name = "car5", .Color = "green", .Speed = 220},
            New Car With {.Name = "car6", .Color = "green", .Speed = 200},
            New Car With {.Name = "car7", .Color = "grey", .Speed = 176},
            New Car With {.Name = "car8", .Color = "grey", .Speed = 200},
            New Car With {.Name = "car9", .Color = "grey", .Speed = 280},
            New Car With {.Name = "car10", .Color = "navy", .Speed = 300},
            New Car With {.Name = "car11", .Color = "navy", .Speed = 220},
            New Car With {.Name = "car12", .Color = "navy", .Speed = 200}
        }

        cars.Sort()

        For Each tCar As Car In cars
            Console.Write(tCar.Color.PadRight(5) & " ")
            Console.Write(tCar.Speed.ToString & " ")
            Console.Write(tCar.Name)
            Console.WriteLine()
        Next

        Console.ReadKey()
    End Sub

End Module
