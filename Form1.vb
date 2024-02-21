Public Class Form1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        ' This code will only allow numeric characters in the text box
        If Char.IsControl(e.KeyChar) Then
            ' Allow control keys
            Return
        End If

        If Not Char.IsDigit(e.KeyChar) Then
            'ignore the keypress by setting Handled to True If not a digit,
            e.Handled = True

            MessageBox.Show("Only numeric values are allowed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub
End Class
