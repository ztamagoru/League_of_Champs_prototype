Imports System.Text.RegularExpressions

Public Class solicitarCodigo
    Dim extra As New extras

    Private Sub solicitarCodigo_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim resp As MsgBoxResult

        resp = MessageBox.Show("Do you want to cancel this operation?",
            "League of Champs", MessageBoxButtons.YesNo)

        If resp = vbYes Then
            registro.Enabled = True
        ElseIf resp = vbNo Then
            e.Cancel = True
        End If
    End Sub

    Private Sub solicitarCodigo_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Dim ocult, input, pattern As String

        input = registro._email.Text.Trim
        pattern = "(?<=[\w]{3})[\w-\._\+ %]*(?=[\w]{1}@)"

        ocult = Regex.Replace(input, pattern, "*")

        Label1.Text = "A mail was sent to " + ocult
    End Sub

    Private Sub solicitarCodigo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        extra.redondearBoton(button)
    End Sub
End Class