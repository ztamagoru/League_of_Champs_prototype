Public Class inicio
    Dim validator As New validador
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

    Private Sub inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        extra.redondearBoton(button)
        Label2.Parent = PictureBox4
    End Sub

    Private Sub button_Click(sender As Object, e As EventArgs) Handles button.Click
        Dim exists As Boolean
        Dim errornum As Integer

        If _username.Text.Trim = "Username" Or
            _password.Text.Trim = "Password" Then
            errornum = 1

            extra.mensajes(errornum)
        Else
            exists = validator.validarDatos()

            If exists = True Then
                ' muestra el siguiente form
                MsgBox("congratulations! u did it!")
            Else
                errornum = 2

                extra.mensajes(errornum)
            End If
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        registro.Show()
        Me.Hide()
    End Sub
End Class