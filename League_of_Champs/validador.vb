Public Class validador
    Public user As String = "test"
    Public pass As String = "1234"

    Public Function validarDatos() As Boolean
        validarDatos = False

        If inicio._username.Text.Trim = user And
            inicio._password.Text.Trim = pass Then

            validarDatos = True
        End If

        Return validarDatos
    End Function


End Class