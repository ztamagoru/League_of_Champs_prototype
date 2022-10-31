<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class registro
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(registro))
        Me.Label3 = New System.Windows.Forms.Label()
        Me._password = New System.Windows.Forms.TextBox()
        Me._username = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me._email = New System.Windows.Forms.TextBox()
        Me._name = New System.Windows.Forms.TextBox()
        Me._surname = New System.Windows.Forms.TextBox()
        Me.button = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(51, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(253, 31)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Create an account"
        '
        '_password
        '
        Me._password.BackColor = System.Drawing.Color.WhiteSmoke
        Me._password.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._password.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749998!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._password.ForeColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(86, Byte), Integer))
        Me._password.Location = New System.Drawing.Point(51, 256)
        Me._password.Margin = New System.Windows.Forms.Padding(0)
        Me._password.MaximumSize = New System.Drawing.Size(267, 20)
        Me._password.MaxLength = 20
        Me._password.MinimumSize = New System.Drawing.Size(250, 20)
        Me._password.Name = "_password"
        Me._password.Size = New System.Drawing.Size(250, 20)
        Me._password.TabIndex = 23
        Me._password.Text = "Password"
        '
        '_username
        '
        Me._username.BackColor = System.Drawing.Color.WhiteSmoke
        Me._username.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._username.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749998!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._username.ForeColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(86, Byte), Integer))
        Me._username.Location = New System.Drawing.Point(51, 213)
        Me._username.Margin = New System.Windows.Forms.Padding(0)
        Me._username.MaximumSize = New System.Drawing.Size(267, 20)
        Me._username.MaxLength = 50
        Me._username.MinimumSize = New System.Drawing.Size(267, 20)
        Me._username.Name = "_username"
        Me._username.Size = New System.Drawing.Size(267, 19)
        Me._username.TabIndex = 22
        Me._username.Text = "Username"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(145, 548)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(75, 24)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Sign in"
        '
        '_email
        '
        Me._email.BackColor = System.Drawing.Color.WhiteSmoke
        Me._email.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._email.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749998!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._email.ForeColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(86, Byte), Integer))
        Me._email.Location = New System.Drawing.Point(52, 170)
        Me._email.Margin = New System.Windows.Forms.Padding(0)
        Me._email.MaximumSize = New System.Drawing.Size(267, 20)
        Me._email.MaxLength = 20
        Me._email.MinimumSize = New System.Drawing.Size(267, 20)
        Me._email.Name = "_email"
        Me._email.Size = New System.Drawing.Size(267, 19)
        Me._email.TabIndex = 21
        Me._email.Text = "Email"
        '
        '_name
        '
        Me._name.BackColor = System.Drawing.Color.WhiteSmoke
        Me._name.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._name.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749998!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._name.ForeColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(86, Byte), Integer))
        Me._name.Location = New System.Drawing.Point(52, 84)
        Me._name.Margin = New System.Windows.Forms.Padding(0)
        Me._name.MaximumSize = New System.Drawing.Size(267, 20)
        Me._name.MaxLength = 20
        Me._name.MinimumSize = New System.Drawing.Size(267, 20)
        Me._name.Name = "_name"
        Me._name.Size = New System.Drawing.Size(267, 19)
        Me._name.TabIndex = 19
        Me._name.Text = "Name"
        '
        '_surname
        '
        Me._surname.BackColor = System.Drawing.Color.WhiteSmoke
        Me._surname.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._surname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749998!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._surname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(86, Byte), Integer))
        Me._surname.Location = New System.Drawing.Point(52, 127)
        Me._surname.Margin = New System.Windows.Forms.Padding(0)
        Me._surname.MaximumSize = New System.Drawing.Size(267, 20)
        Me._surname.MaxLength = 20
        Me._surname.MinimumSize = New System.Drawing.Size(267, 20)
        Me._surname.Name = "_surname"
        Me._surname.Size = New System.Drawing.Size(267, 19)
        Me._surname.TabIndex = 20
        Me._surname.Text = "Surname"
        '
        'button
        '
        Me.button.FlatAppearance.BorderSize = 0
        Me.button.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button.ForeColor = System.Drawing.Color.White
        Me.button.Location = New System.Drawing.Point(135, 441)
        Me.button.Margin = New System.Windows.Forms.Padding(4)
        Me.button.Name = "button"
        Me.button.Size = New System.Drawing.Size(100, 92)
        Me.button.TabIndex = 25
        Me.button.Text = ">"
        Me.button.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(51, 288)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(181, 60)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Entre 8 y 20 caracteres" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Mínimo 1 número" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Mínimo 1 mayúscula" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Mínimo 1 caracter e" &
    "special" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.ErrorProvider1.ContainerControl = Me
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.ImageLocation = "https://th.bing.com/th/id/R.a9147ba7e21b566f833b83a41416c947?rik=CXJMVmEGiClg%2bA" &
    "&pid=ImgRaw&r=0"
        Me.PictureBox1.Location = New System.Drawing.Point(305, 252)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(36, 28)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 27
        Me.PictureBox1.TabStop = False
        '
        'registro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(369, 607)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.button)
        Me.Controls.Add(Me._surname)
        Me.Controls.Add(Me._name)
        Me.Controls.Add(Me._email)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me._password)
        Me.Controls.Add(Me._username)
        Me.Controls.Add(Me.Label3)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "registro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "League of Champs"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents _password As TextBox
    Friend WithEvents _username As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents _email As TextBox
    Friend WithEvents _name As TextBox
    Friend WithEvents _surname As TextBox
    Friend WithEvents button As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents PictureBox1 As PictureBox
End Class
