Public Class ViewReceipt
    Public session As New DataTable
    Private Sub ViewReceipt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbac.Text = session.Rows(0)("account_number")
        lbdate.Text = DateTime.Now.ToString("yyyy/MM/dd")
        lbtime.Text = DateTime.Now.ToString("hh:mm:ss tt")
        lbat.Text = session.Rows(0)("account_type")
        lbcurreny.Text = session.Rows(0)("account_balance")
        accountview.lbbalance.Text = lbamount.Text
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim result As DialogResult = MessageBox.Show("Do you want to make another transaction?", "Confirmation", MessageBoxButtons.YesNo)

        If result = DialogResult.Yes Then
            Main.Show()

            deppin.Close()
            Close()
            session = Nothing
        ElseIf result = DialogResult.No Then
            Form1.Show()
            Close()
            Form1.TextBox1.Text = ""
            entpin.tbPin.Text = ""
        End If
    End Sub
End Class