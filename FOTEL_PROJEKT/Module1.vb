 Dim fotele As New List(Of Fotel) From
            {
            New Fotel With {.nazwahandlowa = "Ragnar", .material = "welur", .wysokosc = 90, .szerokosc = 60, .glebokosc = 60},
            New Fotel With {.nazwahandlowa = "Begnar", .material = "skóra", .wysokosc = 90, .szerokosc = 60, .glebokosc = 60},
            New Fotel With {.nazwahandlowa = "Roman", .material = "welur", .wysokosc = 100, .szerokosc = 50, .glebokosc = 55},
            New Fotel With {.nazwahandlowa = "Hildegarda", .material = "skóra", .wysokosc = 90, .szerokosc = 70, .glebokosc = 70},
            New Fotel With {.nazwahandlowa = "Nike", .material = "skóra ekologiczna", .wysokosc = 90, .szerokosc = 60, .glebokosc = 60},
            New Fotel With {.nazwahandlowa = "Biper", .material = "juka", .wysokosc = 110, .szerokosc = 60, .glebokosc = 60}
        }
        For Each ft In fotele
            With ft
                Console.WriteLine($"nazwa :{ .nazwahandlowa}, materiał: { .material}, wymiary -> { .wysokosc}cm x { .szerokosc}cm x { .glebokosc}cm")

            End With
        Next

        Console.ReadKey()
