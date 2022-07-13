Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListView1.FullRowSelect = True
        ListView1.HideSelection = False

        ListView1.View = View.Details

        Dim h0 As New ColumnHeader
        Dim h1 As New ColumnHeader
        Dim h2 As New ColumnHeader

        h0.Text = "kolumna 0"
        h1.Text = "kolumna 1"
        h2.Text = "kolumna 2"

        ListView1.Columns.Add(h0)
        ListView1.Columns.Add(h1)
        ListView1.Columns.Add(h2)

        For i As Integer = 0 To 10
            With ListView1.Items.Add($"przypadek {i} - 0")
                .SubItems.Add($"przypdek {i} -1")
                .SubItems.Add($"przypdek {i} -2")
                .SubItems.Add($"przypdek {i} -3")

            End With
        Next
    End Sub

    Function GetListSubItemFromPoint(ByVal lv As ListView,
                                     ByVal X As Integer,
                                     ByVal Y As Integer,
                                     Optional ByRef retRow As Integer = 0,
                                     Optional ByRef retCol As Integer = 0) As Boolean

        Dim flag As Boolean
        Dim item As ListViewItem
        Dim col, row As Integer

        Try
            flag = lv.FullRowSelect
            If flag = False Then
                lv.FullRowSelect = True
            End If
            If lv.Items.Count <= 0 And lv.Columns.Count > 0 Then
                lv.BeginUpdate()
                With ListView1.Items.Add(".")
                    For col = 0 To lv.Columns.Count - 1
                        .SubItems.Add("..")

                    Next
                    Y = .GetBounds(ItemBoundsPortion.Label).Y

                End With
                item = lv.GetItemAt(X, Y)
                row = -1
            Else
                item = lv.GetItemAt(X, Y)
            End If
            lv.FullRowSelect = flag

            If Not item Is Nothing Then
                Dim I As Integer = 0
                Dim R As Rectangle = item.GetBounds(ItemBoundsPortion.Label)
                Do While I < item.SubItems.Count
                    If R.Contains(X, Y) Then
                        retRow = IIf(row = -1, -1, item.Index)
                        retCol = I
                        GetListSubItemFromPoint = True
                        Exit Do
                    End If

                    R.X = R.X + lv.Columns(I).Width
                    R.Width = lv.Columns(I + 1).Width
                    I = I + 1

                Loop
            End If

        Catch ex As Exception
        Finally
            If row = -1 Then
                lv.Items.Clear()
                lv.EndUpdate()
            End If
        End Try


    End Function



    Private Sub ListView1_MouseDown(sender As Object, e As MouseEventArgs) Handles ListView1.MouseDown
        Dim col, row
        If GetListSubItemFromPoint(ListView1, e.X, e.Y, row, col) = True Then
            Me.Text = $"Item# => {row} -- SubItem# => {col}"
        Else
            MsgBox("Klikaj proszę na elementy ListView a  nie na tło....")
        End If
    End Sub
End Class
