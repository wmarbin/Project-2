Imports MySql.Data.MySqlClient

Public Class welcome_pg

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=")
        Form4.Show()
        MyBase.Hide()

    End Sub

End Class
