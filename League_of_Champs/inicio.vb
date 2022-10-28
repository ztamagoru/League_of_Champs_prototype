Public Class inicio
    Dim validator As New validador

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
        redondearBoton(button)
    End Sub

    Private Sub redondearBoton(btn As Button)
        btn.FlatStyle = FlatStyle.Flat
        btn.FlatAppearance.BorderSize = 0
        btn.BackColor = Color.Red
        btn.ForeColor = Color.White
        btn.Cursor = Cursors.Hand

        Dim Raduis As New Drawing2D.GraphicsPath

        Raduis.StartFigure()

        Raduis.AddArc(New Rectangle(0, 0, 20, 20), 180, 90)

        Raduis.AddLine(10, 0, btn.Width - 20, 0)

        Raduis.AddArc(New Rectangle(btn.Width - 20, 0, 20, 20), -90, 90)

        Raduis.AddLine(button.Width, 20, btn.Width, btn.Height - 10)

        Raduis.AddArc(New Rectangle(btn.Width - 25, btn.Height - 25, 25, 25), 0, 90)

        Raduis.AddLine(btn.Width - 10, btn.Width, 20, btn.Height)

        Raduis.AddArc(New Rectangle(0, btn.Height - 20, 20, 20), 90, 90)

        Raduis.CloseFigure()

        button.Region = New Region(Raduis)
    End Sub

    Private Sub button_Click(sender As Object, e As EventArgs) Handles button.Click
        Dim exists As Boolean

        If _username.Text.Trim = "Username" Or
            _password.Text.Trim = "Password" Then
            MessageBox.Show("Unfilled spaces left.",
                            "Error",
                            MessageBoxButtons.OK)
        Else
            exists = validator.validarDatos()

            If exists = True Then
                ' muestra el siguiente form
                MsgBox("congratulations! u did it!")
            Else
                MessageBox.Show("Incorrect username or password.",
                            "Error",
                            MessageBoxButtons.OK)
            End If
        End If
    End Sub
End Class