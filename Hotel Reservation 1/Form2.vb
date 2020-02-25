Public Class Form2
    Dim a, b, c, d, ex, f, g, h, i, j, ansr
    Dim tenk = 10000
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        PictureBox1.Hide()
        PictureBox2.Hide()
        PictureBox3.Hide()
        PictureBox4.Hide()
        PictureBox5.Hide()
        PictureBox6.Hide()
        PictureBox7.Hide()
        PictureBox8.Hide()
        PictureBox9.Hide()
        PictureBox10.Hide()
        PictureBox11.Show()
        If ComboBox1.SelectedItem = "PinakaDATO Suite Room" Then
            PictureBox11.Hide()
            PictureBox1.Show()
            TextBox1.Text = "1,000,000.00"
            TextBox1.Enabled = False
        ElseIf ComboBox1.SelectedItem = "Medyo DATO Suite Room" Then
            PictureBox11.Hide()
            PictureBox2.Show()
            TextBox1.Text = "500,000.00"
            TextBox1.Enabled = False
        ElseIf ComboBox1.SelectedItem = "DATO-DATOAN Suite Room" Then
            PictureBox11.Hide()
            PictureBox3.Show()
            TextBox1.Text = "250,000.00"
            TextBox1.Enabled = False
        ElseIf ComboBox1.SelectedItem = "Pinaka-MAYKAYA Suite Room" Then
            PictureBox11.Hide()
            PictureBox4.Show()
            TextBox1.Text = "125,000.00"
            TextBox1.Enabled = False
        ElseIf ComboBox1.SelectedItem = "Medyo MAYKAYA Room" Then
            PictureBox11.Hide()
            PictureBox5.Show()
            TextBox1.Text = "62,500.00"
            TextBox1.Enabled = False
        ElseIf ComboBox1.SelectedItem = "KAYA-KAYAHA Room" Then
            PictureBox11.Hide()
            PictureBox6.Show()
            TextBox1.Text = "31,250.00"
            TextBox1.Enabled = False
        ElseIf ComboBox1.SelectedItem = "POBRE Room" Then
            PictureBox11.Hide()
            PictureBox7.Show()
            TextBox1.Text = "15,625.00"
            TextBox1.Enabled = False
        ElseIf ComboBox1.SelectedItem = "Mas-POBRE Room" Then
            PictureBox11.Hide()
            PictureBox8.Show()
            TextBox1.Text = "7,812.50"
            TextBox1.Enabled = False
        ElseIf ComboBox1.SelectedItem = "Pinaka-POBRE Room" Then
            PictureBox11.Hide()
            PictureBox9.Show()
            TextBox1.Text = "3,906.25"
            TextBox1.Enabled = False
        ElseIf ComboBox1.SelectedItem = "Pinaka-AFFORDABLE Suite Room" Then
            PictureBox11.Hide()
            PictureBox10.Show()
            TextBox1.Text = "FOR FREE"
            TextBox1.Enabled = False
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form3.Show()
        If ComboBox1.SelectedItem = "PinakaDATO Suite Room" Then
            Form3.TextBox9.Text = "PinakaDATO Suite Room"
            Form3.TextBox9.Enabled = False
            Form3.TextBox11.Text = TextBox1.Text
            Form3.TextBox11.Enabled = False
            Form3.TextBox13.Text = "1,010,000.00"
            Form3.TextBox13.Enabled = False
            Form3.TextBox15.Enabled = False
        ElseIf ComboBox1.SelectedItem = "Medyo DATO Suite Room" Then
            Form3.TextBox9.Text = "Medyo DATO Suite Room"
            Form3.TextBox9.Enabled = False
            Form3.TextBox11.Text = TextBox1.Text
            Form3.TextBox11.Enabled = False
            Form3.TextBox13.Text = "510,000.00"
            Form3.TextBox13.Enabled = False
            Form3.TextBox15.Enabled = False
        ElseIf ComboBox1.SelectedItem = "DATO-DATOAN Suite Room" Then
            Form3.TextBox9.Text = "DATO-DATOAN Suite Room"
            Form3.TextBox9.Enabled = False
            Form3.TextBox11.Text = TextBox1.Text
            Form3.TextBox11.Enabled = False
            Form3.TextBox13.Text = "260,000.00"
            Form3.TextBox13.Enabled = False
            Form3.TextBox15.Enabled = False
        ElseIf ComboBox1.SelectedItem = "Pinaka-MAYKAYA Suite Room" Then
            Form3.TextBox9.Text = "Pinaka-MAYKAYA Suite Room"
            Form3.TextBox9.Enabled = False
            Form3.TextBox11.Text = TextBox1.Text
            Form3.TextBox11.Enabled = False
            Form3.TextBox13.Text = "135,000.00"
            Form3.TextBox13.Enabled = False
            Form3.TextBox15.Enabled = False
        ElseIf ComboBox1.SelectedItem = "Medyo MAYKAYA Room" Then
            Form3.TextBox9.Text = "Medyo MAYKAYA Room"
            Form3.TextBox9.Enabled = False
            Form3.TextBox11.Text = TextBox1.Text
            Form3.TextBox11.Enabled = False
            Form3.TextBox13.Text = "72,500.00"
            Form3.TextBox13.Enabled = False
            Form3.TextBox15.Enabled = False
        ElseIf ComboBox1.SelectedItem = "KAYA-KAYAHA Room" Then
            Me.Hide()
            Form3.Show()
            Form3.TextBox9.Text = "KAYA-KAYAHA Room"
            Form3.TextBox9.Enabled = False
            Form3.TextBox11.Text = TextBox1.Text
            Form3.TextBox11.Enabled = False
            Form3.TextBox13.Text = "41,250.00"
            Form3.TextBox13.Enabled = False
            Form3.TextBox15.Enabled = False
        ElseIf ComboBox1.SelectedItem = "POBRE Room" Then
            Me.Hide()
            Form3.Show()
            Form3.TextBox9.Text = "POBRE Room"
            Form3.TextBox9.Enabled = False
            Form3.TextBox11.Text = TextBox1.Text
            Form3.TextBox11.Enabled = False
            Form3.TextBox13.Text = "25,625.00"
            Form3.TextBox13.Enabled = False
            Form3.TextBox15.Enabled = False
        ElseIf ComboBox1.SelectedItem = "Mas-POBRE Room" Then
            Me.Hide()
            Form3.Show()
            Form3.TextBox9.Text = "Mas-POBRE Room"
            Form3.TextBox9.Enabled = False
            Form3.TextBox11.Text = TextBox1.Text
            Form3.TextBox11.Enabled = False
            Form3.TextBox13.Text = "17,812.50"
            Form3.TextBox13.Enabled = False
            Form3.TextBox15.Enabled = False
        ElseIf ComboBox1.SelectedItem = "Pinaka-POBRE Room" Then
            Me.Hide()
            Form3.Show()
            Form3.TextBox9.Text = "Pinaka-POBRE Room"
            Form3.TextBox9.Enabled = False
            Form3.TextBox11.Text = TextBox1.Text
            Form3.TextBox11.Enabled = False
            Form3.TextBox13.Text = "13,906.25"
            Form3.TextBox13.Enabled = False
            Form3.TextBox15.Enabled = False
        ElseIf ComboBox1.SelectedItem = "Pinaka-AFFORDABLE Suite Room" Then
            Me.Hide()
            Form3.Show()
            Form3.TextBox9.Text = "Pinaka-AFFORDABLE Suite Room"
            Form3.TextBox9.Enabled = False
            Form3.TextBox11.Text = TextBox1.Text
            Form3.TextBox11.Enabled = False
            Form3.TextBox13.Text = "10,000.00"
            Form3.TextBox13.Enabled = False
            Form3.TextBox15.Enabled = False

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form4.Show()

    End Sub
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        RadioButton1.Text = "Locked"
        ComboBox1.Enabled = False
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        RadioButton2.Text = "Unlocked"
        ComboBox1.Enabled = True
    End Sub
End Class