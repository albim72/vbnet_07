Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lvp.View = View.Details
        lvp.Columns.Add("Pracownik", 300, HorizontalAlignment.Right)
        lvp.Columns.Add("ID", 40, HorizontalAlignment.Left)
        lvp.Columns.Add("Stanowisko", 100, HorizontalAlignment.Left)

        Dim str(3) As String
        Dim lv As ListViewItem
        str(0) = "Jan Kowalski"
        str(1) = "1"
        str(2) = "Prezes"
        lv = New ListViewItem(str)
        lvp.Items.Add(lv)


        Dim str1(3) As String
        Dim lv1 As ListViewItem
        str1(0) = "Olga Kot"
        str1(1) = "2"
        str1(2) = "księgowa"
        lv1 = New ListViewItem(str1)
        lvp.Items.Add(lv1)

        Dim str2(3) As String
        Dim lv2 As ListViewItem
        str2(0) = "Anna Nowak"
        str2(1) = "3"
        str2(2) = "Sekretarka"
        lv2 = New ListViewItem(str2)
        lvp.Items.Add(lv2)
    End Sub
End Class
