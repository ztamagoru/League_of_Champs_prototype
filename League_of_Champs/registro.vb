﻿Public Class registro
    Dim validator As New validador
    Dim extra As New extras

    Private Sub _username_Enter(sender As Object, e As EventArgs) Handles _username.Enter
        If _username.Text.Trim = "Username" Then

            _username.Text = String.Empty
            _username.ForeColor = Color.FromArgb(1, 60, 60, 65)
        End If
    End Sub

    Private Sub _username_Leave(sender As Object, e As EventArgs) Handles _username.Leave
        If _username.Text.Trim = String.Empty Then

            _username.Text = "Username"
            _username.ForeColor = Label1.ForeColor
        ElseIf _username.Text.trim = "Username" Then
            _username.ForeColor = Label1.ForeColor
        End If
    End Sub

    Private Sub _password_Enter(sender As Object, e As EventArgs) Handles _password.Enter
        If _password.Text.Trim = "Password" Then

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
        If _name.Text.Trim = "Name" Then

            _name.Text = String.Empty
            _name.ForeColor = Color.FromArgb(1, 60, 60, 65)
        End If
    End Sub

    Private Sub _name_Leave(sender As Object, e As EventArgs) Handles _name.Leave
        If _name.Text.Trim = String.Empty Then

            _name.Text = "Name"
            _name.ForeColor = Label1.ForeColor
        ElseIf _name.Text.trim = "Name" Then
            _name.ForeColor = Label1.ForeColor
        End If
    End Sub

    Private Sub _surname_Enter(sender As Object, e As EventArgs) Handles _surname.Enter
        If _surname.Text.Trim = "Surname" Then

            _surname.Text = String.Empty
            _surname.ForeColor = Color.FromArgb(1, 60, 60, 65)

        End If
    End Sub

    Private Sub _surname_Leave(sender As Object, e As EventArgs) Handles _surname.Leave
        If _surname.Text.Trim = String.Empty Then

            _surname.Text = "Surname"
            _surname.ForeColor = Label1.ForeColor
        ElseIf _surname.Text.trim = "Surname" Then
            _surname.ForeColor = Label1.ForeColor
        End If
    End Sub

    Private Sub _email_Enter(sender As Object, e As EventArgs) Handles _email.Enter
        If _email.Text.Trim = "Email" Then

            _email.Text = String.Empty
            _email.ForeColor = Color.FromArgb(1, 60, 60, 65)

        End If
    End Sub

    Private Sub _email_Leave(sender As Object, e As EventArgs) Handles _email.Leave
        If _email.Text.Trim = String.Empty Then

            _email.Text = "Email"
            _email.ForeColor = Label1.ForeColor
        ElseIf _email.Text.Trim = "Email" Then
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

            extra.mensajes(1)
        Else
            validation = validator.validarDatos(_username.Text.Trim, _password.Text.Trim, _email.Text.Trim)

            If validation = 0 Then
                solicitarCodigo.Show()
                Me.Enabled() = False
            Else
                extra.mensajes(validation)
            End If
        End If

    End Sub

    Private Sub _username_TextChanged(sender As Object, e As EventArgs) Handles _username.TextChanged
        If _username.Text.Trim.Length() < 8 Or _username.Text.Trim.Length() > 50 Then
            Me.ErrorProvider1.SetError(sender, "The username needs to have between 8 and 50 characters.")
        Else
            Me.ErrorProvider1.SetError(sender, "")
        End If
    End Sub

    Private Sub PictureBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseDown
        _password.PasswordChar = ""
    End Sub

    Private Sub PictureBox1_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseUp
        If _password.Text.Trim <> "Password" Then
            _password.PasswordChar = "·"
        End If

    End Sub
End Class