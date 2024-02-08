Public Class deppin
    Dim cl As New Class1
    Dim session As New DataTable
    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button9.Click, Button8.Click, Button7.Click, Button6.Click, Button5.Click, Button4.Click, Button3.Click, Button2.Click, Button10.Click, Button1.Click
        Dim btn = CType(sender, Button)
        TextBox1.Text &= btn.Text
    End Sub

    Private Sub deppin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Text = Module1.input
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        TextBox1.Text = ""
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
        session = cl.login(Label2.Text, TextBox1.Text)
        'MsgBox("Hello world")
        If session.Rows.Count = 1 Then
            MsgBox("Log in successful")
            ViewReceipt.session = session
            ViewReceipt.Show()
            Hide()
        Else
            MsgBox("Incorrect, my friend")
        End If
    End Sub
End Class