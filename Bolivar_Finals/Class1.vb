Imports System.Data.Odbc

Public Class Class1
    Private conn As New OdbcConnection("DSN=atm")
    Private dta As New DataSet1


    Public Sub retrieveData(dgv As DataGridView)

        Try
            conn.Open()

            Dim sql As String = "SELECT u.account_id, u.account_number, u.acct_type_id, ut.account_type, u.pin, ai.first_name, ai.last_name,ai.address, ai.birthdate, ai.account_balance FROM tbl_accounts u JOIN tbl_account_types ut ON u.acct_type_id = ut.acct_type_id JOIN tbl_acct_info ai ON u.account_id = ai.account_id;"

            Dim adp As New OdbcDataAdapter(sql, conn)


            dta.Tables("session").Clear()


            adp.Fill(dta.Tables("session"))

            conn.Close()

            dgv.DataSource = dta.Tables("session")
            dgv.Refresh()

        Catch ex As Exception
            conn.Close()
            Console.WriteLine(ex.Message)
        End Try
    End Sub

    Public Function login(username As String, pin As String)
        Try
            conn.Open()
            Dim sql = "SELECT u.account_id, u.account_number, u.acct_type_id, ut.account_type, u.pin, ai.first_name, ai.last_name, ai.address, ai.birthdate, ai.account_balance FROM tbl_accounts u JOIN tbl_account_types ut ON u.acct_type_id = ut.acct_type_id JOIN tbl_acct_info ai ON u.account_id = ai.account_id = ut.acct_type_id WHERE u.acct_type_id = ut.acct_type_id AND u.account_number = ? AND u.pin = ?"

            Dim cmd As New OdbcCommand(sql, conn)
            cmd.Parameters.Add("@field1", OdbcType.VarChar, 255).Value = username
            cmd.Parameters.Add("@field2", OdbcType.VarChar, 255).Value = pin

            Dim adp As New OdbcDataAdapter
            adp.SelectCommand = cmd

            dta.Tables("session").Clear()

            adp.Fill(dta.Tables("session"))

            conn.Close()
        Catch ex As Exception
            conn.Close()
            Console.WriteLine(ex.Message)
        End Try

        Return dta.Tables("session")
    End Function
    Public Sub updateUserwithdraw(Totalbalance As Integer)
        Try
            conn.Open()

            Dim sql As String = "UPDATE tbl_acct_info SET account_balance = account_balance - ? WHERE acct_info_id = ?"
            Dim cmd As New OdbcCommand(sql, conn)

            ' Add parameters
            cmd.Parameters.Add("@account_balance", OdbcType.Int).Value = Totalbalance
            cmd.Parameters.Add("@acct_info_id", OdbcType.Int).Value = 1

            cmd.ExecuteNonQuery()

            conn.Close()
        Catch ex As Exception
            conn.Close()
            Console.WriteLine(ex.Message)
        End Try
    End Sub
    Public Sub updateUserDeposit(Totalbalance As Integer)
        Try
            conn.Open()

            Dim sql As String = "UPDATE tbl_acct_info SET account_balance = account_balance + ? WHERE acct_info_id = ?"
            Dim cmd As New OdbcCommand(sql, conn)

            ' Add parameters
            cmd.Parameters.Add("@account_balance", OdbcType.Int).Value = Totalbalance
            cmd.Parameters.Add("@acct_info_id", OdbcType.Int).Value = 1

            cmd.ExecuteNonQuery()

            conn.Close()
        Catch ex As Exception
            conn.Close()
            Console.WriteLine(ex.Message)
        End Try
    End Sub

    Public Function UpdateUserWithdraw(newpin As String) As Boolean
        Try
            conn.Open()
            Dim sql As String = "UPDATE tbl_accounts SET pin = ? WHERE account_id = ?"

            Dim cmd As New OdbcCommand(sql, conn)
            cmd.Parameters.Add("@pin", OdbcType.VarChar, 255).Value = newpin
            cmd.Parameters.Add("@account_id", OdbcType.Int).Value = 2

            Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

            conn.Close()

            Return rowsAffected > 0
        Catch ex As Exception
            conn.Close()
            Console.WriteLine(ex.Message)
            Return False
        End Try
    End Function
End Class