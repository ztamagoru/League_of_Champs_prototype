Public Class solicitarCodigo
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
        Label1.Text = "A mail was sent to " + registro._email.Text.Trim

    End Sub
End Class