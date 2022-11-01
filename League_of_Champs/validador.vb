Imports System.Net.Mail
Imports System.Text.RegularExpressions
Public Class validador
    ' hardcodeado de momento únicamente por el prototipo, más adelante se verán removidos del aplicativo
    Public user As String = "test1234"
    Public pass As String = "hola1234"
    Public email As String = "you@example.com"
    Public code As String = ""

    Public Overloads Function validarDatos() As Boolean
        validarDatos = False

        ' sujeto a cambios: 
        If inicio._username.Text.Trim = user And
            inicio._password.Text.Trim = pass Then

            validarDatos = True
        End If

        Return validarDatos
    End Function

    Public Overloads Function validarDatos(username As String, password As String, mail As String) As Integer
        Dim validP As Boolean = Regex.IsMatch(password, "^(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[a-zA-Z]).{8,20}$")
        Dim validM As Boolean
        Dim validU As Boolean

        ' sujeto a cambios:
        If Regex.IsMatch(mail, "[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?") = True And
            email <> mail Then
            validM = True
        End If

        ' sujeto a cambios:
        If username.Length() > 7 And username <> user Then
            validU = True
        End If

        If validU And validM And validP Then
            validarDatos = 0

            enviarCodigo()
        ElseIf Not validU Then
            validarDatos = 3

        ElseIf Not validM Then
            validarDatos = 4

        ElseIf Not validP Then
            validarDatos = 5
        End If

        Return validarDatos
    End Function

    Private Sub enviarCodigo()
        Dim num As New Random()

        For i = 1 To 7
            If i = 4 Then
                code += "-"
            Else
                code += $"{num.Next(1, 9)}"
            End If
        Next


        Dim smtp_server As New SmtpClient("smtp.gmail.com", 587)
        Dim e_mail As New MailMessage
        Dim text As String

        text = "Dear " + registro._name.Text.Trim + "," + vbCrLf +
            "Please verify your email adress to complete your League of Champs account." + vbCrLf +
            "Code: " + code + vbCrLf + vbCrLf +
            "Thank you," + vbCrLf + "The League of Champs Team"

        smtp_server.UseDefaultCredentials = False
        smtp_server.Credentials = New Net.NetworkCredential("mariazdanovitchet24@gmail.com", "vwjivhvrptbucxue")
        smtp_server.EnableSsl = True

        e_mail = New MailMessage
        e_mail.From = New MailAddress("mariazdanovitchet24@gmail.com")
        e_mail.To.Add(registro._email.Text.Trim)
        e_mail.Subject = "League of Champs - Verify your email adress"
        e_mail.IsBodyHtml = False
        e_mail.Body = text

        smtp_server.SendMailAsync(e_mail)

        'Try
        '    smtp_server.SendMailAsync(e_mail)
        'Catch ex As Exception
        '    Debug.Write(ex.Message)
        '    MessageBox.Show("Error. Mail doesn't exist." + vbCrLf +
        '                    "Please insert an existing email.",
        '                    "Error",
        '                    MessageBoxButtons.OK)

        '    solicitarCodigo.Hide()
        '    registro.Enabled = True
        'End Try
    End Sub

    Public Sub validarCodigo()
        Dim _code As String = solicitarCodigo.insertcode.Text.Trim

        MsgBox(_code)
    End Sub
End Class