Public Class entpin
    Dim cl As New Class1
    Dim session As New DataTable
    Private Sub entpin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Text = Module1.input
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        tbPin.Text = ""
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Dim result As DialogResult = MessageBox.Show("Cancel your current transaction?", "Confirmation", MessageBoxButtons.YesNo)

        If result = DialogResult.Yes Then
            Close()
        ElseIf result = DialogResult.No Then
            Show()
        End If
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        session = cl.login(Label2.Text, tbPin.Text)

        If session.Rows.Count > 0 Then
            MsgBox("Log in successful")
            Main.session = session
            Main.Show()
            Hide()

        Else
            If tbPin.Text = "" Then
                If session.Columns.Contains("account_number") Then

                    addpin.Show()
                    Hide()
                Else
                    MsgBox("There is no input inserted")
                End If
            Else
                MsgBox("Incorrect, my friend")
            End If
        End If
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button9.Click, Button8.Click, Button7.Click, Button6.Click, Button5.Click, Button4.Click, Button3.Click, Button2.Click, Button10.Click, Button1.Click
        Dim btn = CType(sender, Button)
        If tbPin.Text.Length < 6 Then
            tbPin.Text &= btn.Text
        End If
    End Sub
End Class