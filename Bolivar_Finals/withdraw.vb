Public Class withdraw
    Public cla As New Class1
    Private Sub Button10_Click(sender As Object, e As EventArgs)
        deppin.Show()
        Hide()
        Dim btn = CType(sender, Button)
        ViewReceipt.lbcurreny.Text = btn.Text

        ' Convert the button text to an integer
        Dim buttonValue As Integer = btn.Text


        cla.updateUserwithdraw(buttonValue)
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Hide()
        withamount.Show()
    End Sub

    Private Sub withdraw_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Public Sub Tekken()
        cla.updateUserwithdraw(withamount.TextBox1.Text)
    End Sub

    Private Sub Button10_Click_1(sender As Object, e As EventArgs) Handles Button9.Click, Button8.Click, Button7.Click, Button6.Click, Button5.Click, Button4.Click, Button3.Click, Button2.Click, Button10.Click, Button1.Click
        deppin.Show()
        Hide()
        Dim btn = CType(sender, Button)
        ViewReceipt.lbamount.Text = btn.Text

        ' Convert the button text to an integer
        Dim buttonValue As Integer = btn.Text


        cla.updateUserwithdraw(buttonValue)
    End Sub
End Class