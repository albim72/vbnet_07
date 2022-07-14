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
        
        'akcja asynchroniczna przez zadanie (task)

        Dim zadanie2 As Task(Of Long) = New Task(Of Long)(akcja, "zadanie")
        zadanie2.Start()
        MessageBox.Show("Akcja przez zadanie ruszyła...")
        Dim wynik2 As Long = zadanie2.Result
        MessageBox.Show("Asynchronicznie przez zadanie: " & wynik2.ToString())
         'akcja asynchroniczna przez ascync/await

        Dim zadanie3 As Task(Of Long) = New Task(Of Long)(akcja, "Async/Await")
        zadanie3.Start()
        MessageBox.Show("Akcja przez Async/Await ruszyła...")
        Dim wynik3 As Long = Await zadanie3

        MessageBox.Show("Asynchronicznie przez async/await: " & wynik3.ToString())
    End Function
End Class
