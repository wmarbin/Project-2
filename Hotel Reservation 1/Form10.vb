Public Class Form10

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form4.Show()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedItem = "1. Go get World MAP" Then

            PictureBox2.Hide()
            PictureBox3.Hide()
            PictureBox4.Hide()
            PictureBox5.Hide()
            PictureBox6.Hide()
            PictureBox1.Show()


        ElseIf ComboBox1.SelectedItem = "2. Locate Bermuda's Triangle" Then
            PictureBox1.Hide()
            PictureBox3.Hide()
            PictureBox4.Hide()
            PictureBox5.Hide()
            PictureBox6.Hide()

            PictureBox2.Show()


        ElseIf ComboBox1.SelectedItem = "3. Fight the STORMS" Then
            PictureBox1.Hide()
            PictureBox2.Hide()
            PictureBox4.Hide()
            PictureBox5.Hide()
            PictureBox6.Hide()

            PictureBox3.Show()


        ElseIf ComboBox1.SelectedItem = "4. Reach Heaven Island" Then
            PictureBox1.Hide()
            PictureBox2.Hide()
            PictureBox3.Hide()
            PictureBox5.Hide()
            PictureBox6.Hide()
            PictureBox4.Show()


        ElseIf ComboBox1.SelectedItem = "5. YOU ARRIVED" Then
            PictureBox1.Hide()
            PictureBox2.Hide()
            PictureBox3.Hide()
            PictureBox4.Hide()
            PictureBox6.Hide()
            PictureBox5.Show()



        End If
    End Sub

End Class