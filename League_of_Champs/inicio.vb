

Public Class inicio
    Private Sub TextBox1_Enter(sender As Object, e As EventArgs) Handles TextBox1.Enter
        If TextBox1.Text = "Username" And TextBox1.ForeColor = Label1.ForeColor Then

            TextBox1.Text = String.Empty
            TextBox1.ForeColor = Color.FromArgb(1, 60, 60, 65)

        End If
    End Sub

    Private Sub TextBox1_Leave(sender As Object, e As EventArgs) Handles TextBox1.Leave
        If TextBox1.Text = String.Empty Then

            TextBox1.Text = "Username"
            TextBox1.ForeColor = Label1.ForeColor

        End If
    End Sub

    Private Sub TextBox2_Enter(sender As Object, e As EventArgs) Handles TextBox2.Enter
        If TextBox2.Text = "Password" And TextBox2.ForeColor = Label1.ForeColor Then

            TextBox2.Text = String.Empty
            TextBox2.ForeColor = Color.FromArgb(1, 60, 60, 65)
            TextBox2.PasswordChar = "·"

        End If
    End Sub

    Private Sub TextBox2_Leave(sender As Object, e As EventArgs) Handles TextBox2.Leave
        If TextBox2.Text = String.Empty Then

            TextBox2.Text = "Password"
            TextBox2.ForeColor = Label1.ForeColor
            TextBox2.PasswordChar = ""

        End If
    End Sub

    Private Sub inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        redondearBoton(button)
    End Sub

    Private Sub redondearBoton(btn As Button)
        btn.FlatStyle = FlatStyle.Flat
        btn.FlatAppearance.BorderSize = 0
        btn.BackColor = Color.Red
        btn.ForeColor = Color.White
        btn.Cursor = Cursors.Hand

        Dim Raduis As New Drawing2D.GraphicsPath

        Raduis.StartFigure()

        Raduis.AddArc(New Rectangle(0, 0, 20, 20), 180, 90)

        Raduis.AddLine(10, 0, btn.Width - 20, 0)

        Raduis.AddArc(New Rectangle(btn.Width - 20, 0, 20, 20), -90, 90)

        Raduis.AddLine(button.Width, 20, btn.Width, btn.Height - 10)

        Raduis.AddArc(New Rectangle(btn.Width - 25, btn.Height - 25, 25, 25), 0, 90)

        Raduis.AddLine(btn.Width - 10, btn.Width, 20, btn.Height)

        Raduis.AddArc(New Rectangle(0, btn.Height - 20, 20, 20), 90, 90)

        Raduis.CloseFigure()

        button.Region = New Region(Raduis)
    End Sub

    Private Sub button_Click(sender As Object, e As EventArgs) Handles button.Click

    End Sub
End Class