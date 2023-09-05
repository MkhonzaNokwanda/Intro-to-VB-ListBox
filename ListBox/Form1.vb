Public Class Form1
    Private Sub BtnGender_Click(sender As Object, e As EventArgs) Handles btnGender.Click
        Dim strGender As String

        strGender = lstGender.SelectedItem

        MessageBox.Show("You are" & " " & strGender)
    End Sub
End Class
