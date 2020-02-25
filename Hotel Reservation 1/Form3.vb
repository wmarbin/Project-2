Imports MySql.Data.MySqlClient
Public Class Form3
    Dim x As Double
    Dim y As Double
    Dim z As Double

    Dim str As String = "server=localhost; uid=root; pwd=; database=dbprofile"
    Dim con As New MySqlConnection(str)

    Sub load()
        Dim query As String = "select *from profile"
        Dim adpt As New MySqlDataAdapter(query, con)

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "dd/MM/yyyy"
        DateTimePicker2.Format = DateTimePickerFormat.Custom
        DateTimePicker2.CustomFormat = "dd/MM/yyyy"
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form2.Show()

    End Sub

    Private Sub TextBox11_TextChanged(sender As Object, e As EventArgs) Handles TextBox11.TextChanged
        TextBox11.Text = Form2.TextBox1.Text
        TextBox11.Enabled = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form6.Show()
        Dim cmd As MySqlCommand
        con.Open()
        Try
            cmd = con.CreateCommand
            cmd.CommandText = "insert into profile (lname,fname,country,company,idtyp,idnom,roomtyp,roomnom,date,rate,nomchi,nomadu,romser,tot,amnt,bal)values(@lname,@fname,@country,@company,@idtyp,@idnom,@roomtyp,@roomnom,@date,@rate,@nomchi,@nomadu,@romser,@tot,@amnt,@bal)"
            cmd.Parameters.AddWithValue("@lname", TextBox1.Text)
            cmd.Parameters.AddWithValue("@fname", TextBox2.Text)
            cmd.Parameters.AddWithValue("@country", TextBox3.Text)
            cmd.Parameters.AddWithValue("@company", TextBox4.Text)
            cmd.Parameters.AddWithValue("@idtyp", ComboBox1.SelectedItem)
            cmd.Parameters.AddWithValue("@idnom", TextBox8.Text)
            cmd.Parameters.AddWithValue("@roomtyp", TextBox9.Text)
            cmd.Parameters.AddWithValue("@roomnom", ComboBox2.SelectedItem)
            cmd.Parameters.AddWithValue("@datein", DateTimePicker1.Text)
            cmd.Parameters.AddWithValue("@rate", TextBox11.Text)
            cmd.Parameters.AddWithValue("@nomchi", TextBox7.Text)
            cmd.Parameters.AddWithValue("@nomadu", TextBox10.Text)
            cmd.Parameters.AddWithValue("@romser", TextBox12.Text)
            cmd.Parameters.AddWithValue("@tot", TextBox13.Text)
            cmd.Parameters.AddWithValue("@amt", TextBox14.Text)
            cmd.Parameters.AddWithValue("@bal", TextBox15.Text)
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        If TextBox9.Text = "PinakaDATO Suite Room" Then
            x = Val(1010000)
            y = Val(TextBox14.Text)
            z = x - y
            If z < 1 Then
                z = z * -1
                Form6.Label26.Text = "CHANGE"
                Form6.TextBox15.Text = "P     " & z
                Form6.TextBox15.Enabled = False
            Else
                Form6.TextBox15.Text = "P     " & z
                Form6.TextBox15.Enabled = False
            End If
        ElseIf TextBox9.Text = "Medyo DATO Suite Room" Then
            x = Val(510000)
            y = Val(TextBox14.Text)
            z = x - y
            If z < 1 Then
                z = z * -1
                Form6.Label26.Text = "CHANGE"
                Form6.TextBox15.Text = "P     " & z
                Form6.TextBox15.Enabled = False
            Else
                Form6.TextBox15.Text = "P     " & z
                Form6.TextBox15.Enabled = False
            End If
        ElseIf TextBox9.Text = "DATO-DATOAN Suite Room" Then
            x = Val(260000)
            y = Val(TextBox14.Text)
            z = x - y
            If z < 1 Then
                z = z * -1
                Form6.Label26.Text = "CHANGE"
                Form6.TextBox15.Text = "P     " & z
                Form6.TextBox15.Enabled = False
            Else
                Form6.TextBox15.Text = "P     " & z
                Form6.TextBox15.Enabled = False
            End If
        ElseIf TextBox9.Text = "Pinaka-MAYKAYA Suite Room" Then
            x = Val(135000)
            y = Val(TextBox14.Text)
            z = x - y
            If z < 1 Then
                z = z * -1
                Form6.Label26.Text = "CHANGE"
                Form6.TextBox15.Text = "P     " & z
                Form6.TextBox15.Enabled = False
            Else
                Form6.TextBox15.Text = "P     " & z
                Form6.TextBox15.Enabled = False
            End If
        ElseIf TextBox9.Text = "Medyo MAYKAYA Room" Then
            x = Val(72500)
            y = Val(TextBox14.Text)
            z = x - y
            If z < 1 Then
                z = z * -1
                Form6.Label26.Text = "CHANGE"
                Form6.TextBox15.Text = "P     " & z
                Form6.TextBox15.Enabled = False
            Else
                Form6.TextBox15.Text = "P     " & z
                Form6.TextBox15.Enabled = False
            End If
        ElseIf TextBox9.Text = "KAYA-KAYAHA Room" Then
            x = Val(41250)
            y = Val(TextBox14.Text)
            z = x - y
            If z < 1 Then
                z = z * -1
                Form6.Label26.Text = "CHANGE"
                Form6.TextBox15.Text = "P     " & z
                Form6.TextBox15.Enabled = False
            Else
                Form6.TextBox15.Text = "P     " & z
                Form6.TextBox15.Enabled = False
            End If
        ElseIf TextBox9.Text = "POBRE Room" Then
            x = Val(25625)
            y = Val(TextBox14.Text)
            z = x - y
            If z < 1 Then
                z = z * -1
                Form6.Label26.Text = "CHANGE"
                Form6.TextBox15.Text = "P     " & z
                Form6.TextBox15.Enabled = False
            Else
                Form6.TextBox15.Text = "P     " & z
                Form6.TextBox15.Enabled = False
            End If

        ElseIf TextBox9.Text = "Mas-POBRE Room" Then
            x = Val(17812.5)
            y = Val(TextBox14.Text)
            z = x - y
            If z < 1 Then
                z = z * -1
                Form6.Label26.Text = "CHANGE"
                Form6.TextBox15.Text = "P     " & z
                Form6.TextBox15.Enabled = False
            Else
                Form6.TextBox15.Text = "P     " & z
                Form6.TextBox15.Enabled = False
            End If
        ElseIf TextBox9.Text = "Pinaka-POBRE Room" Then
            x = Val(13906.25)
            y = Val(TextBox14.Text)
            z = x - y
            If z < 1 Then
                z = z * -1
                Form6.Label26.Text = "CHANGE"
                Form6.TextBox15.Text = "P     " & z
                Form6.TextBox15.Enabled = False
            Else
                Form6.TextBox15.Text = "P     " & z
                Form6.TextBox15.Enabled = False
            End If
        ElseIf TextBox9.Text = "Pinaka-AFFORDABLE Suite Room" Then
            x = Val(10000)
            y = Val(TextBox14.Text)
            z = x - y
            If z < 1 Then
                z = z * -1
                Form6.Label26.Text = "CHANGE"
                Form6.TextBox15.Text = "P     " & z
                Form6.TextBox15.Enabled = False
            Else
                Form6.TextBox15.Text = "P     " & z
                Form6.TextBox15.Enabled = False
            End If
        End If


        Form6.TextBox1.Text = TextBox1.Text
        Form6.TextBox1.Enabled = False

        Form6.TextBox2.Text = TextBox2.Text
        Form6.TextBox2.Enabled = False

        Form6.TextBox3.Text = TextBox3.Text
        Form6.TextBox3.Enabled = False

        Form6.TextBox4.Text = TextBox4.Text
        Form6.TextBox4.Enabled = False

        Form6.TextBox7.Text = TextBox7.Text
        Form6.TextBox7.Enabled = False

        Form6.TextBox8.Text = TextBox8.Text
        Form6.TextBox8.Enabled = False

        Form6.TextBox9.Text = TextBox9.Text
        Form6.TextBox9.Enabled = False

        Form6.TextBox10.Text = TextBox10.Text
        Form6.TextBox10.Enabled = False

        Form6.TextBox11.Text = TextBox11.Text
        Form6.TextBox11.Enabled = False

        Form6.TextBox12.Text = TextBox12.Text
        Form6.TextBox12.Enabled = False

        Form6.TextBox13.Text = TextBox13.Text
        Form6.TextBox13.Enabled = False

        Form6.TextBox14.Text = TextBox14.Text
        Form6.TextBox14.Enabled = False

        Form6.ComboBox1.SelectedItem = ComboBox1.SelectedItem
        Form6.ComboBox1.Enabled = False

        Form6.ComboBox2.SelectedItem = ComboBox2.SelectedItem
        Form6.ComboBox2.Enabled = False


        Form6.DateTimePicker1.Value = DateTimePicker1.Value
        Form6.DateTimePicker1.Enabled = False

        Form6.DateTimePicker2.Value = DateTimePicker2.Value
        Form6.DateTimePicker2.Enabled = False



    End Sub
End Class