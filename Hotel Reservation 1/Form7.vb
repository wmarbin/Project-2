Public Class Form7

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form4.Show()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedItem = "PinakaDATO Suite Room" Then

            PictureBox2.Hide()
            PictureBox3.Hide()
            PictureBox4.Hide()
            PictureBox5.Hide()
            PictureBox6.Hide()
            PictureBox7.Hide()
            PictureBox8.Hide()
            PictureBox9.Hide()
            PictureBox10.Hide()
            PictureBox11.Hide()

            RichTextBox11.Hide()
            PictureBox1.Show()
            RichTextBox1.Show()

        ElseIf ComboBox1.SelectedItem = "Medyo DATO Suite Room" Then
            PictureBox1.Hide()

            PictureBox3.Hide()
            PictureBox4.Hide()
            PictureBox5.Hide()
            PictureBox6.Hide()
            PictureBox7.Hide()
            PictureBox8.Hide()
            PictureBox9.Hide()
            PictureBox10.Hide()
            PictureBox11.Hide()

            RichTextBox11.Hide()
            PictureBox2.Show()
            RichTextBox2.Show()

        ElseIf ComboBox1.SelectedItem = "DATO-DATOAN Suite Room" Then
            PictureBox1.Hide()
            PictureBox2.Hide()
            PictureBox4.Hide()
            PictureBox5.Hide()
            PictureBox6.Hide()
            PictureBox7.Hide()
            PictureBox8.Hide()
            PictureBox9.Hide()
            PictureBox10.Hide()
            PictureBox11.Hide()
          
            RichTextBox11.Hide()
            PictureBox3.Show()
            RichTextBox3.Show()

        ElseIf ComboBox1.SelectedItem = "Pinaka-MAYKAYA Suite Room" Then
            PictureBox1.Hide()
            PictureBox2.Hide()
            PictureBox3.Hide()
            PictureBox5.Hide()
            PictureBox6.Hide()
            PictureBox7.Hide()
            PictureBox8.Hide()
            PictureBox9.Hide()
            PictureBox10.Hide()
            PictureBox11.Hide()

            RichTextBox11.Hide()
            PictureBox4.Show()
            RichTextBox4.Show()

        ElseIf ComboBox1.SelectedItem = "Medyo MAYKAYA Room" Then
            PictureBox1.Hide()
            PictureBox2.Hide()
            PictureBox3.Hide()
            PictureBox4.Hide()
            PictureBox6.Hide()
            PictureBox7.Hide()
            PictureBox8.Hide()
            PictureBox9.Hide()
            PictureBox10.Hide()
            PictureBox11.Hide()

            RichTextBox11.Hide()
            PictureBox5.Show()
            RichTextBox5.Show()

        ElseIf ComboBox1.SelectedItem = "KAYA-KAYAHA Room" Then
            PictureBox1.Hide()
            PictureBox2.Hide()
            PictureBox3.Hide()
            PictureBox4.Hide()
            PictureBox5.Hide()
            PictureBox7.Hide()
            PictureBox8.Hide()
            PictureBox9.Hide()
            PictureBox10.Hide()
            PictureBox11.Hide()


            RichTextBox11.Hide()
            PictureBox6.Show()
            RichTextBox6.Show()

        ElseIf ComboBox1.SelectedItem = "POBRE Room" Then
            PictureBox1.Hide()
            PictureBox2.Hide()
            PictureBox3.Hide()
            PictureBox4.Hide()
            PictureBox5.Hide()
            PictureBox6.Hide()
            PictureBox8.Hide()
            PictureBox9.Hide()
            PictureBox10.Hide()
            PictureBox11.Hide()

            RichTextBox11.Hide()
            PictureBox7.Show()
            RichTextBox7.Show()

        ElseIf ComboBox1.SelectedItem = "Mas-POBRE Room" Then
            PictureBox1.Hide()
            PictureBox2.Hide()
            PictureBox3.Hide()
            PictureBox4.Hide()
            PictureBox5.Hide()
            PictureBox6.Hide()
            PictureBox7.Hide()
            PictureBox9.Hide()
            PictureBox10.Hide()
            PictureBox11.Hide()

            RichTextBox11.Hide()
            PictureBox8.Show()
            RichTextBox8.Show()

        ElseIf ComboBox1.SelectedItem = "Pinaka-POBRE Room" Then
            PictureBox1.Hide()
            PictureBox2.Hide()
            PictureBox3.Hide()
            PictureBox4.Hide()
            PictureBox5.Hide()
            PictureBox6.Hide()
            PictureBox7.Hide()
            PictureBox8.Hide()
            PictureBox10.Hide()
            PictureBox11.Hide()

            RichTextBox11.Hide()
            PictureBox9.Show()
            RichTextBox9.Show()

        ElseIf ComboBox1.SelectedItem = "Pinaka-AFFORDABLE Suite Room" Then
            PictureBox1.Hide()
            PictureBox2.Hide()
            PictureBox3.Hide()
            PictureBox4.Hide()
            PictureBox5.Hide()
            PictureBox6.Hide()
            PictureBox7.Hide()
            PictureBox8.Hide()
            PictureBox9.Hide()
            PictureBox11.Hide()

            RichTextBox11.Hide()
            PictureBox10.Show()
            RichTextBox10.Show()
        End If
    End Sub

End Class