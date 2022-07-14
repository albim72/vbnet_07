Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim proc As Process = Nothing
        Try
            Dim batDir As String = String.Format("C:\Temp")
            proc = New Process()
            proc.StartInfo.WorkingDirectory = batDir
            proc.StartInfo.FileName = "testbat.bat"
            proc.StartInfo.CreateNoWindow = False
            proc.Start()

            proc.WaitForExit()
            MessageBox.Show("Plik bat został wykonany!")
        Catch ex As Exception
            Console.WriteLine(ex.StackTrace.ToString())
        End Try
    End Sub
End Class
