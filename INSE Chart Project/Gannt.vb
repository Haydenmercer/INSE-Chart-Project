Public Class Gannt

    Private Sub newWorkItem_Click(sender As Object, e As EventArgs) Handles newWorkItem.Click
        Dim newItem As NewGanttItem
        newItem = New NewGanttItem
        newItem.Visible = True
    End Sub

End Class