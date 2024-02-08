Public Class addpin
    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button9.Click, Button8.Click, Button7.Click, Button6.Click, Button5.Click, Button4.Click, Button3.Click, Button2.Click, Button10.Click, Button1.Click
        Dim btn = CType(sender, Button)
        If tbPin.Text.Length < 6 Then
            tbPin.Text &= btn.Text
            TextBox1.Enabled = False
        End If

        If tbPin.Text.Length = 6 Then
            textbox1.Enabled = True
            tbPin.Enabled = False
            TextBox1.Focus()
            If TextBox1.Text.Length < 6 Then
                TextBox1.Text &= btn.Text
            End If
        End If
    End Sub

    Private Sub addpin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Enabled = True
        lbnumber.Text = 688284762637
        lbcurrent.Text = "Time Deposit"
        lbname.Text = "Terry Perillo"
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        If tbPin.Text <> TextBox1.Text Then
            MsgBox("New PIN and Confirm PIN do not match. Please try again.")
            Return
        End If

        Dim connector As New Class1
        Dim success As Boolean = connector.updateUserwithdraw(textbox1.Text)

        If success Then
            MsgBox("Success")
            Form1.Show()
            Form1.TextBox1.Text = ""
            Hide()
        Else
            MsgBox("Failed to update PIN. Please try again.")
        End If
    End Sub

    Private Sub tbPin_TextChanged(sender As Object, e As EventArgs) Handles tbPin.TextChanged

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        TextBox1.Text = ""
        tbPin.Text = ""
        tbPin.Enabled = True
        TextBox1.Focus()
    End Sub
End Class