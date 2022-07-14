Public Class Form1

    Private nazwapliku As String = "tabela.xml"
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DataSet1.Clear()
        DataSet1.ReadXml(nazwapliku)
        DataGridView1.DataSource = DataSet1
        DataGridView1.DataMember = "osoba"
        Button1.Enabled = False
    End Sub

    Private Sub DataGridView1_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellValueChanged
        Button2.Enabled = True
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button2.Enabled = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        System.IO.File.Copy(nazwapliku, nazwapliku & ".txt", True)
        DataSet1.WriteXml(nazwapliku)
        Button2.Enabled = False
    End Sub
End Class
