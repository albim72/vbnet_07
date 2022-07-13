Imports System.Configuration

Module Module1

    Sub Main()

        Dim connectionString As String =
            ConfigurationManager.ConnectionStrings("connect_db.My.MySettings.GARDENConnectionString").ToString

        Dim db As New gardenDataContext(connectionString)

        Dim newProdukt As New Produkty()
        newProdukt.IDProduktu = 1116
        newProdukt.NazwaProduktu = "szampon czerwony"
        newProdukt.CenaJednostkowa = 33

        db.Produkty.InsertOnSubmit(newProdukt)
        db.SubmitChanges()


        Dim printProdukt As Produkty =
            db.Produkty.FirstOrDefault(Function(e) e.IDProduktu.Equals(2))

        Console.WriteLine($"Produkt -> nazwa: {printProdukt.NazwaProduktu}, id: {printProdukt.IDProduktu},
cena jednostkowa: {printProdukt.CenaJednostkowa}, nazwa łacińska: {printProdukt.NazwaŁacińska}")

        Console.ReadKey()


    End Sub

End Module
