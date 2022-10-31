Imports System.Text.RegularExpressions
Public Class validador
    Public user As String = "test1234"
    Public pass As String = "hola1234"
    Public email As String = "you@example.com"

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
            validarDatos = 3
        End If
        If Not validU(username) Then
            validarDatos = 4
        ElseIf Not validarMail(email) Then
            validarDatos = 5
        ElseIf Not validPass(password) Then
            validarDatos = 6
        Else
            validarDatos = 7
        End If

        Return validarDatos
    End Function

    Private Function validPass(password) As Boolean
        Return Regex.IsMatch(password, "^(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[a-zA-Z]).{8,20}$")
    End Function

    Private Function validarMail(mail As String) As Boolean
        Return Regex.IsMatch(email,
        "[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?")
    End Function

    Private Function validU(username As String) As Boolean
        If username.Length() > 7 And username <> user Then
            Return True
        End If

        Return False
    End Function
End Class