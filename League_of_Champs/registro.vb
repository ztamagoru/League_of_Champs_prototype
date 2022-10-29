Public Class registro
    Dim validator As New validador
    Dim extra As New extras

    Private Sub _username_Enter(sender As Object, e As EventArgs) Handles _username.Enter
        If _username.Text.Trim = "Username" And _username.ForeColor = Label1.ForeColor Then

            _username.Text = String.Empty
            _username.ForeColor = Color.FromArgb(1, 60, 60, 65)

        End If
    End Sub

    Private Sub _username_Leave(sender As Object, e As EventArgs) Handles _username.Leave
        If _username.Text.Trim = String.Empty Then

            _username.Text = "Username"
            _username.ForeColor = Label1.ForeColor

        End If
    End Sub

    Private Sub _password_Enter(sender As Object, e As EventArgs) Handles _password.Enter
        If _password.Text.Trim = "Password" And _password.ForeColor = Label1.ForeColor Then

            _password.Text = String.Empty
            _password.ForeColor = Color.FromArgb(1, 60, 60, 65)
            _password.PasswordChar = "·"

        End If
    End Sub

    Private Sub _password_Leave(sender As Object, e As EventArgs) Handles _password.Leave
        If _password.Text.Trim = String.Empty Then

            _password.Text = "Password"
            _password.ForeColor = Label1.ForeColor
            _password.PasswordChar = ""

        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        inicio.Show()
        Me.Hide()
    End Sub

    Private Sub registro_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        End
    End Sub

    Private Sub registro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        extra.redondearBoton(button)
    End Sub

    Private Sub _name_Enter(sender As Object, e As EventArgs) Handles _name.Enter
        If _name.Text.Trim = "Name" And _name.ForeColor = Label1.ForeColor Then

            _name.Text = String.Empty
            _name.ForeColor = Color.FromArgb(1, 60, 60, 65)

        End If
    End Sub

    Private Sub _name_Leave(sender As Object, e As EventArgs) Handles _name.Leave
        If _name.Text.Trim = String.Empty Then

            _name.Text = "Name"
            _name.ForeColor = Label1.ForeColor

        End If
    End Sub

    Private Sub _surname_Enter(sender As Object, e As EventArgs) Handles _surname.Enter
        If _surname.Text.Trim = "Surname" And _surname.ForeColor = Label1.ForeColor Then

            _surname.Text = String.Empty
            _surname.ForeColor = Color.FromArgb(1, 60, 60, 65)

        End If
    End Sub

    Private Sub _surname_Leave(sender As Object, e As EventArgs) Handles _surname.Leave
        If _surname.Text.Trim = String.Empty Then

            _surname.Text = "Surname"
            _surname.ForeColor = Label1.ForeColor

        End If
    End Sub

    Private Sub _email_Enter(sender As Object, e As EventArgs) Handles _email.Enter
        If _email.Text.Trim = "Email" And _email.ForeColor = Label1.ForeColor Then

            _email.Text = String.Empty
            _email.ForeColor = Color.FromArgb(1, 60, 60, 65)

        End If
    End Sub

    Private Sub _email_Leave(sender As Object, e As EventArgs) Handles _email.Leave
        If _email.Text.Trim = String.Empty Then

            _email.Text = "Email"
            _email.ForeColor = Label1.ForeColor

        End If
    End Sub

    Private Sub button_Click(sender As Object, e As EventArgs) Handles button.Click
        Dim validation As Integer

        If _name.Text.Trim = "Name" Or
                _surname.Text.Trim = "Surname" Or
                _email.Text.Trim = "Email" Or
                _username.Text.Trim = "Username" Or
                _password.Text.Trim = "Password" Then

            MessageBox.Show("Unfilled spaces left.",
                            "Error",
                            MessageBoxButtons.OK)
        Else
            validation = validator.validarDatos(_username.Text.Trim, _password.Text.Trim, _email.Text.Trim)

            Select Case validation
                Case 0
                    MsgBox("error")

                Case 1
                    MsgBox("usuario inexistente")

            End Select
        End If
    End Sub
End Class