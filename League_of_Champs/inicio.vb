Public Class inicio
    Private Sub TextBox1_Enter(sender As Object, e As EventArgs) Handles TextBox1.Enter
        If TextBox1.Text = "Username" And TextBox1.ForeColor = Label1.ForeColor Then

            TextBox1.Text = String.Empty
            TextBox1.ForeColor = Color.FromArgb(1, 60, 60, 65)

        End If
    End Sub

    Private Sub TextBox1_Leave(sender As Object, e As EventArgs) Handles TextBox1.Leave
        If TextBox1.Text = String.Empty Then

            TextBox1.Text = "Username"
            TextBox1.ForeColor = Label1.ForeColor

        End If
    End Sub

    Private Sub TextBox2_Enter(sender As Object, e As EventArgs) Handles TextBox2.Enter
        If TextBox2.Text = "Password" And TextBox2.ForeColor = Label1.ForeColor Then

            TextBox2.Text = String.Empty
            TextBox2.ForeColor = Color.FromArgb(1, 60, 60, 65)
            TextBox2.PasswordChar = "·"

        End If
    End Sub

    Private Sub TextBox2_Leave(sender As Object, e As EventArgs) Handles TextBox2.Leave
        If TextBox2.Text = String.Empty Then

            TextBox2.Text = "Password"
            TextBox2.ForeColor = Label1.ForeColor
            TextBox2.PasswordChar = ""

        End If
    End Sub

    '.....
End Class