Public Class Form1
    Dim wyb As Byte
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub rbDiesel_CheckedChanged(sender As Object, e As EventArgs) Handles rbDiesel.CheckedChanged
        wyb = 1
    End Sub

    Private Sub rbBenzyna_CheckedChanged(sender As Object, e As EventArgs) Handles rbBenzyna.CheckedChanged
        wyb = 2
    End Sub

    Private Sub rbElektryk_CheckedChanged(sender As Object, e As EventArgs) Handles rbElektryk.CheckedChanged
        wyb = 3
    End Sub

    Private Sub btnPolicz_Click(sender As Object, e As EventArgs) Handles btnPolicz.Click
        Dim odl As String = tbOdl.Text
        Dim cena As String = tbCena.Text

        Dim ds As Diesel = New Diesel(Convert.ToDouble(odl), Convert.ToDouble(cena))
        Dim bn As Benzyna = New Benzyna(Convert.ToDouble(odl), Convert.ToDouble(cena))
        Dim el As Elektryk = New Elektryk(Convert.ToDouble(odl), Convert.ToDouble(cena))

        Select Case (wyb)
            Case 1
                tbWynik.Text = ds.policzKosztPaliwa().ToString()
            Case 2
                tbWynik.Text = bn.policzKosztPaliwa().ToString()
            Case 3
                tbWynik.Text = el.policzKosztPaliwa().ToString()
        End Select
    End Sub
End Class
