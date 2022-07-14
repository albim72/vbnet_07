Public Class Form1
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = DateTime.Now.Ticks.ToString()

    End Sub

    Private Async Function Button1_Click(sender As Object, e As EventArgs) As Task Handles Button1.Click
        Dim akcja As Func(Of Object, Long) = Function(argument As Object)
                                                 MessageBox.Show($"Zatrzymanie akcji - {argument.ToString()}")
                                                 Return DateTime.Now.Ticks
                                             End Function
        Dim wynik1 As Long = akcja("synchronicznie")
        MessageBox.Show("Synchronicznie: " & wynik1.ToString())
    End Function
End Class
