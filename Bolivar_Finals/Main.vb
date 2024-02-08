Public Class Main
    Private cl As New Class1
    Public session As New DataTable
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ac = accountview
        ac.lbnumber.Text = session.Rows(0)("account_number")
        ac.lbacctype.Text = session.Rows(0)("account_type")
        ac.fname.Text = session.Rows(0)("first_name")
        ac.lname.Text = session.Rows(0)("last_name")
        ac.lbaddress.Text = session.Rows(0)("address")
        ac.lbdate.Text = session.Rows(0)("birthdate")
        ac.lbbalance.Text = session.Rows(0)("account_balance")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        withdraw.Show()
        Hide()
        ViewReceipt.lbtrans.Text = "Withdraw"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Hide()
        deposit.Show()
        ViewReceipt.lbtrans.Text = "Deposit"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        accountview.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim result As DialogResult = MessageBox.Show("Cancel your current transaction?", "Confirmation", MessageBoxButtons.YesNo)

        If result = DialogResult.Yes Then
            Form1.Close()
            Close()
        ElseIf result = DialogResult.No Then
            Show()
        End If
    End Sub
End Class