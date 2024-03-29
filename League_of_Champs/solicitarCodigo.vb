﻿Imports System.Text.RegularExpressions

Public Class solicitarCodigo
    Dim extra As New extras
    Dim validator As New validador

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

        ocult = Regex.Replace(input, pattern, "**")

        Label1.Text = "A mail was sent to " + ocult
    End Sub

    Private Sub solicitarCodigo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        extra.redondearBoton(button)
    End Sub

    Private Sub button_Click(sender As Object, e As EventArgs) Handles button.Click
        If validator.validarCodigo() Then
            registro.Enabled = True
            registro.Hide()
            inicio.Show()

            MessageBox.Show("Account created succesfully.",
                        "League of Champs",
                        MessageBoxButtons.OK)

            Me.Hide()
        Else
            extra.mensajes(6)
        End If
    End Sub
End Class