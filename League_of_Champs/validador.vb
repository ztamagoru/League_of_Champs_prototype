Imports System.Net.Mail
Imports System.Text.RegularExpressions
Public Class validador
    Public user As String = "test1234"
    Public pass As String = "hola1234"
    Public email As String = "you@example.com"
    Public code As String

    Public Overloads Function validarDatos() As Boolean
        validarDatos = False

        If inicio._username.Text.Trim = user And
            inicio._password.Text.Trim = pass Then

            validarDatos = True
        End If

        Return validarDatos
    End Function

    Public Overloads Function validarDatos(username As String, password As String, email As String) As Integer
        If validU(username) And validarMail(email) And validPass(password) Then
            validarDatos = 0

            enviarCodigo()
        ElseIf Not validU(username) Then
            validarDatos = 3

        ElseIf Not validarMail(email) Then
            validarDatos = 4

        ElseIf Not validPass(password) Then
            validarDatos = 5
        End If

        Return validarDatos
    End Function

    Private Function validPass(password) As Boolean
        Return Regex.IsMatch(password, "^(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[a-zA-Z]).{8,20}$")
    End Function

    Private Function validarMail(mail As String) As Boolean
        If Regex.IsMatch(mail, "[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?") = True And
            mail <> email Then
            Return True
        End If

        Return False
    End Function

    Private Function validU(username As String) As Boolean
        If username.Length() > 7 And username <> user Then
            Return True
        End If

        Return False
    End Function

    Private Sub enviarCodigo()
        code = GenCode()

        Dim smtp_server As New SmtpClient("smtp.gmail.com", 587)
        Dim e_mail As New MailMessage
        Dim text As String

        text = "Dear *" + registro._name.Text.Trim + "* " + vbCrLf +
            "Please verify your email adress to complete your League of Champs account." + vbCrLf +
            "Code: " + code + vbCrLf + vbCrLf +
            "Thank you," + vbCrLf + "The League of Champs Team"

        smtp_server.UseDefaultCredentials = False
        smtp_server.Credentials = New Net.NetworkCredential("mariazdanovitchet24@gmail.com", "vwjivhvrptbucxue")
        smtp_server.Port = 587
        smtp_server.EnableSsl = True
        smtp_server.Host = "smtp.gmail.com"

        e_mail = New MailMessage
        e_mail.From = New MailAddress("mariazdanovitchet24@gmail.com")
        e_mail.To.Add(registro._email.Text.Trim)
        e_mail.Subject = "League of Champs - Verify your email adress"
        e_mail.IsBodyHtml = False
        e_mail.Body = text

        Try
            smtp_server.SendMailAsync(e_mail)
        Catch ex As Exception
            Debug.Write(ex.Message)
            MessageBox.Show("Error. Mail doesn't exist." + vbCrLf +
                            "Please insert an existing email.",
                            "Error",
                            MessageBoxButtons.OK)

            solicitarCodigo.Hide()
            registro.Enabled = True
        End Try
    End Sub

    Private Function GenCode() As String
        Dim num As New Random()
        Dim code_generated As String = ""
        For i = 1 To 6
            code_generated += $"{num.Next(1, 9)}"
        Next

        Return code_generated
    End Function
End Class