Public Class Form8


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form4.Show()
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedItem = "The BAR" Then
            PictureBox2.Hide()
            PictureBox3.Hide()
            PictureBox4.Hide()
            PictureBox5.Hide()

            RichTextBox5.Hide()
            PictureBox1.Show()
            RichTextBox1.Show()

        ElseIf ComboBox1.SelectedItem = "The PATISSIERE" Then
            PictureBox1.Hide()
            PictureBox3.Hide()
            PictureBox4.Hide()
            PictureBox5.Hide()

            RichTextBox5.Hide()
            PictureBox2.Show()
            RichTextBox2.Show()

        ElseIf ComboBox1.SelectedItem = "The CAFE" Then
            PictureBox1.Hide()
            PictureBox2.Hide()
            PictureBox4.Hide()
            PictureBox5.Hide()

            RichTextBox5.Hide()
            PictureBox3.Show()
            RichTextBox3.Show()

        ElseIf ComboBox1.SelectedItem = "The RESTAURANT" Then
            PictureBox1.Hide()
            PictureBox2.Hide()
            PictureBox3.Hide()
            PictureBox5.Hide()

            RichTextBox5.Hide()
            PictureBox4.Show()
            RichTextBox4.Show()

        End If

    End Sub

End Class