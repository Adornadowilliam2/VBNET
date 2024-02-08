Public Class deposit
    Public cla As New Class1
    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button9.Click, Button8.Click, Button7.Click, Button6.Click, Button5.Click, Button4.Click, Button3.Click, Button2.Click, Button10.Click, Button1.Click
        deppin.Show()
        Hide()
        Dim btn = CType(sender, Button)
        ViewReceipt.lbamount.Text = btn.Text

        ' Convert the button text to an integer
        Dim buttonValue As Integer = btn.Text


        cla.updateUserDeposit(buttonValue)
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        depamount.Show()
        Hide()
    End Sub

    Private Sub deposit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub
    Public Sub Tekken()
        cla.updateUserDeposit(depamount.TextBox1.Text)
    End Sub
End Class