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
End Class