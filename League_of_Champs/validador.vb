Imports System.Net.Mail
Imports System.Text.RegularExpressions
Public Class validador
    ' hardcodeado de momento únicamente por el prototipo, más adelante se verán removidos del aplicativo
    Public Shared fname As String = "vimalasitra"
    Public Shared sname As String = "daryaka"
    Public Shared user As String = "test1234"
    Public Shared pass As String = "hola1234"
    Public Shared mail As String = "you@example.com"
    Public Shared ncode As String


    Public Overloads Function validarDatos() As Boolean
        validarDatos = False

        ' sujeto a cambios: 
        If inicio._username.Text.Trim = user And
            inicio._password.Text.Trim = pass Then

            validarDatos = True
        End If

        Return validarDatos
    End Function

    Public Overloads Function validarDatos(username As String, password As String, email As String) As Integer
        Dim validP As Boolean = Regex.IsMatch(password, "^(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[a-zA-Z]).{8,20}$")
        Dim validM As Boolean
        Dim validU As Boolean

        ' sujeto a cambios:
        If Regex.IsMatch(email, "[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?") And
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
        Dim generatedCode As String = ""

        For i = 1 To 7
            If i = 4 Then
                generatedCode += "-"
            Else
                generatedCode += $"{num.Next(1, 9)}"
            End If
        Next

        Debug.WriteLine(generatedCode)

        Dim smtp_server As New SmtpClient("smtp.gmail.com", 587)
        Dim e_mail As New MailMessage
        Dim text As String

        text = "Dear " + registro._name.Text.Trim + "," + vbCrLf +
            "Please verify your email adress to complete your League of Champs account." + vbCrLf +
            "Code: " + generatedCode + vbCrLf + vbCrLf +
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

        Debug.WriteLine(generatedCode)

        ncode = generatedCode

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

    Public Function validarCodigo() As Boolean
        Dim insertcode As String = solicitarCodigo.insertcode.Text

        Debug.WriteLine("Ingresado: " + insertcode)
        Debug.WriteLine("Generado: " + ncode)

        If ncode = insertcode Then
            registrarUsuario()

            Return True
        End If
        Return False
    End Function

    Private Sub registrarUsuario()
        ' sujeto a cambios:

        Dim name, surname, username, email, password As String

        name = registro._name.Text.Trim
        surname = registro._surname.Text.Trim
        username = registro._username.Text.Trim
        email = registro._email.Text.Trim
        password = registro._password.Text.Trim

        fname = name
        sname = surname
        user = username
        mail = email
        pass = password
    End Sub
End Class