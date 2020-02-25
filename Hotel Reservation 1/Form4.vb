Public Class Form4

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        If ListBox1.SelectedItem = "CHECK IN / RESERVATION" Then
            Me.Hide()
            Form2.Show()
        ElseIf ListBox1.SelectedItem = "ROOMS" Then
            Me.Hide()
            Form7.Show()
            Form7.RichTextBox1.Hide()
            Form7.RichTextBox2.Hide()
            Form7.RichTextBox3.Hide()
            Form7.RichTextBox4.Hide()
            Form7.RichTextBox5.Hide()
            Form7.RichTextBox6.Hide()
            Form7.RichTextBox7.Hide()
            Form7.RichTextBox8.Hide()
            Form7.RichTextBox9.Hide()
            Form7.RichTextBox10.Hide()

            Form7.PictureBox1.Hide()
            Form7.PictureBox2.Hide()
            Form7.PictureBox3.Hide()
            Form7.PictureBox4.Hide()
            Form7.PictureBox5.Hide()
            Form7.PictureBox6.Hide()
            Form7.PictureBox7.Hide()
            Form7.PictureBox8.Hide()
            Form7.PictureBox9.Hide()
            Form7.PictureBox10.Hide()

            Form7.PictureBox1.BorderStyle = BorderStyle.Fixed3D
            Form7.PictureBox2.BorderStyle = BorderStyle.Fixed3D
            Form7.PictureBox3.BorderStyle = BorderStyle.Fixed3D
            Form7.PictureBox4.BorderStyle = BorderStyle.Fixed3D
            Form7.PictureBox5.BorderStyle = BorderStyle.Fixed3D
            Form7.PictureBox6.BorderStyle = BorderStyle.Fixed3D
            Form7.PictureBox7.BorderStyle = BorderStyle.Fixed3D
            Form7.PictureBox8.BorderStyle = BorderStyle.Fixed3D
            Form7.PictureBox9.BorderStyle = BorderStyle.Fixed3D
            Form7.PictureBox10.BorderStyle = BorderStyle.Fixed3D

            Form7.RichTextBox11.Show()
            Form7.PictureBox11.Show()

        ElseIf ListBox1.SelectedItem = "DINING" Then
            Me.Hide()
            Form8.Show()
            Form8.RichTextBox1.Hide()
            Form8.RichTextBox2.Hide()
            Form8.RichTextBox3.Hide()
            Form8.RichTextBox4.Hide()
          
            Form8.PictureBox1.Hide()
            Form8.PictureBox2.Hide()
            Form8.PictureBox3.Hide()
            Form8.PictureBox4.Hide()
        
            Form8.PictureBox1.BorderStyle = BorderStyle.Fixed3D
            Form8.PictureBox2.BorderStyle = BorderStyle.Fixed3D
            Form8.PictureBox3.BorderStyle = BorderStyle.Fixed3D
            Form8.PictureBox4.BorderStyle = BorderStyle.Fixed3D
            Form8.PictureBox5.BorderStyle = BorderStyle.Fixed3D

            Form8.RichTextBox5.Show()
            Form8.PictureBox5.Show()

        ElseIf ListBox1.SelectedItem = "FACILITIES" Then
            Me.Hide()
            Form9.Show()


        ElseIf ListBox1.SelectedItem = "LOCATION" Then
            Me.Hide()
            Form10.Show()
            Form10.RichTextBox5.Enabled = False


        ElseIf ListBox1.SelectedItem = "ABOUT US" Then
            Me.Hide()
            Form11.Show()
            Form11.Label8.Hide()
        End If
    End Sub
End Class