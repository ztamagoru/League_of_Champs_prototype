Public Class validador
    Public user As String = "test"
    Public pass As String = "1234"
    Public email As String = ""

    Public Overloads Function validarDatos() As Boolean
        validarDatos = False

        If inicio._username.Text.Trim = user And
            inicio._password.Text.Trim = pass Then

            validarDatos = True
        End If

        Return validarDatos
    End Function

    Public Overloads Function validarDatos(username As String, password As String, email As String) As Integer
        validarDatos = 0

        If validU(username) = True Then
            validarDatos = 1
        End If


        Return validarDatos
    End Function

    Private Function validarMail(mail As String) As Boolean
        validarMail = True


        Dim x As String
        Dim y, p, arr, ca, cp As Integer


        ca = 0
        cp = 0

        For i = 1 To Len(mail)
            x = GetChar(mail, i)
            y = Asc(x)

            If y = 64 Then
                arr = i
                ca = ca + 1
            End If

            If y = 46 Then
                p = i
                cp = cp + 1
            End If
        Next

        If arr < 2 Or ca <> 1 Then
            validarMail = False
        End If

        If validarMail = True Then
            If p + 1 < arr Or cp <> 1 Or (Len(mail) - 3) < p Then
                validarMail = False
            End If
        End If

        Return validarMail
    End Function

    Private Function validU(username As String) As Boolean
        validU = False

        If username <> user Then
            validU = True
        End If

        Return validU
    End Function
End Class