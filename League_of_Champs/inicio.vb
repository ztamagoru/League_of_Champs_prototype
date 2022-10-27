Public Class inicio
    Private Sub inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim background As String = ".\fondo.jpg"

        Me.BackgroundImage = Image.FromFile(background)
    End Sub
End Class