Public Class inicio
    Private Sub inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim background As String = "fondo"
        Dim logo As String = "logo"

        PictureBox2.Image = My.Resources.ResourceManager.GetObject(logo)

        'Me.BackgroundImage = My.Resources.ResourceManager.GetObject(background)
        'Me.BackgroundImageLayout = ImageLayout.Zoom
    End Sub
End Class