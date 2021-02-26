Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button6.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button6.Hide()
        Button7.Hide()
        Button8.Hide()
        Button9.Hide()
        Button10.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Button7.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Button8.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Button9.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Button10.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TextBox1.Text = "FBJVC-3CMTX-D8DVP-RTQCT-92494"
        Button6.Hide()
        ' If RadioButton1.Checked Then
        'TextBox1.Text = "Berhasil 1"

        'ElseIf RadioButton2.Checked Then
        'TextBox1.Text = "Berhasil 2"

        'ElseIf RadioButton3.Checked Then
        ''TextBox1.Text = "Berhasil 3"

        'ElseIf RadioButton4.Checked Then
        'TextBox1.Text = "Berhasil 4"

        'ElseIf RadioButton5.Checked Then
        'TextBox1.Text = "Berhasil 5"
        'End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        TextBox1.Text = "BWG7X-J98B3-W34RT-33B3R-JVYW9"
        Button7.Hide()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        TextBox1.Text = "RBCXF-CVBGR-382MK-DFHJ4-C69G8"
        Button8.Hide()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        TextBox1.Text = "YCFHQ-9DWCY-DKV88-T2TMH-G7BHP"
        Button9.Hide()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        TextBox1.Text = "4D974-9QX42-9Y43G-YJ7JG-JDYBP"
        Button10.Hide()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Form2.Show()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        End
    End Sub
End Class
