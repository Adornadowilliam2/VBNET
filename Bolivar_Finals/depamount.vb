Public Class depamount
    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button9.Click, Button8.Click, Button7.Click, Button6.Click, Button5.Click, Button4.Click, Button3.Click, Button2.Click, Button10.Click, Button1.Click
        Dim btn = CType(sender, Button)
        TextBox1.Text &= btn.Text
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        If TextBox1.Text <> "" Then
            TextBox1.Text = TextBox1.Text.Remove(TextBox1.Text.Count - 1)
        End If
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Dim result As DialogResult = MessageBox.Show("Do you want to close the form?", "Confirmation", MessageBoxButtons.YesNo)

        If result = DialogResult.Yes Then
            Close()
        ElseIf result = DialogResult.No Then
            Show()
        End If
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        deppin.Show()
        Hide()

        ' Call the updateUser method and pass the button value
        deposit.Tekken()

        ViewReceipt.lbamount.Text = TextBox1.Text
    End Sub
End Class