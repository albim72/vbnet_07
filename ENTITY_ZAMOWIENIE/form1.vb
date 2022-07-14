Public Class Form1

    Dim context As GARDENEntities = New GARDENEntities
    Dim dane
    Dim klient
    Dim zap
    Dim drugiedane

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim query = From it In context.Klienci
                    Order By it.IDKlienta
                    Select it

        Dim comp As Klienci
        For Each comp In query
            klient = $"Dane klienta -> imię: {comp.Imię}, nazwisko: {comp.Nazwisko}, miasto: {comp.Miasto}" & vbCrLf
            dane = dane + klient

            tbWynik.Text = dane
        Next

    End Sub
End Class
