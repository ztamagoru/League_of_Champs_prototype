Public Class registro
    Dim extra As New extras

    Private Sub _username_Enter(sender As Object, e As EventArgs) Handles _username.Enter
        If _username.Text = "Username" And _username.ForeColor = Label1.ForeColor Then

            _username.Text = String.Empty
            _username.ForeColor = Color.FromArgb(1, 60, 60, 65)

        End If
    End Sub

    Private Sub _username_Leave(sender As Object, e As EventArgs) Handles _username.Leave
        If _username.Text = String.Empty Then

            _username.Text = "Username"
            _username.ForeColor = Label1.ForeColor

        End If
    End Sub

    Private Sub _password_Enter(sender As Object, e As EventArgs) Handles _password.Enter
        If _password.Text = "Password" And _password.ForeColor = Label1.ForeColor Then

            _password.Text = String.Empty
            _password.ForeColor = Color.FromArgb(1, 60, 60, 65)
            _password.PasswordChar = "·"

        End If
    End Sub

    Private Sub _password_Leave(sender As Object, e As EventArgs) Handles _password.Leave
        If _password.Text = String.Empty Then

            _password.Text = "Password"
            _password.ForeColor = Label1.ForeColor
            _password.PasswordChar = ""

        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Hide()
        inicio.Show()
    End Sub

    Private Sub registro_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        End
    End Sub

    Private Sub registro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        extra.redondearBoton(button)
    End Sub
End Class