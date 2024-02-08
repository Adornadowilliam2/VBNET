Public Class database
    Public cla As New Class1
    Private Sub database_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cla.retrieveData(dgv)
    End Sub
End Class