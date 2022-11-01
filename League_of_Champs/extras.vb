Public Class extras

    Public Function redondearBoton(btn As Button) As Button
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

        Raduis.AddLine(btn.Width, 20, btn.Width, btn.Height - 10)

        Raduis.AddArc(New Rectangle(btn.Width - 25, btn.Height - 25, 25, 25), 0, 90)

        Raduis.AddLine(btn.Width - 10, btn.Width, 20, btn.Height)

        Raduis.AddArc(New Rectangle(0, btn.Height - 20, 20, 20), 90, 90)

        Raduis.CloseFigure()

        btn.Region = New Region(Raduis)

        Return btn
    End Function

    Public Sub mensajes(opt As Integer)
        Select Case opt
            Case 1
                MessageBox.Show("Unfilled spaces left.",
                            "Error",
                            MessageBoxButtons.OK)
            Case 2
                MessageBox.Show("Incorrect username or password.",
                            "Error",
                            MessageBoxButtons.OK)
            Case 3
                MessageBox.Show("Invalid user",
                            "Error",
                            MessageBoxButtons.OK)
            Case 4
                MessageBox.Show("Invalid email",
                            "Error",
                            MessageBoxButtons.OK)
            Case 5
                MessageBox.Show("Invalid password",
                            "Error",
                            MessageBoxButtons.OK)
        End Select
    End Sub
End Class
