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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(registro))
        Me.Label3 = New System.Windows.Forms.Label()
        Me._password = New System.Windows.Forms.TextBox()
        Me._username = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me._email = New System.Windows.Forms.TextBox()
        Me._name = New System.Windows.Forms.TextBox()
        Me._surname = New System.Windows.Forms.TextBox()
        Me.button = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Mark", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(38, 27)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(201, 26)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Create an account"
        '
        '_password
        '
        Me._password.BackColor = System.Drawing.Color.WhiteSmoke
        Me._password.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._password.Font = New System.Drawing.Font("Mark", 9.749998!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._password.ForeColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(86, Byte), Integer))
        Me._password.Location = New System.Drawing.Point(38, 208)
        Me._password.Margin = New System.Windows.Forms.Padding(0)
        Me._password.MaximumSize = New System.Drawing.Size(200, 20)
        Me._password.MaxLength = 20
        Me._password.MinimumSize = New System.Drawing.Size(200, 20)
        Me._password.Name = "_password"
        Me._password.Size = New System.Drawing.Size(200, 17)
        Me._password.TabIndex = 23
        Me._password.Text = "Password"
        '
        '_username
        '
        Me._username.BackColor = System.Drawing.Color.WhiteSmoke
        Me._username.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._username.Font = New System.Drawing.Font("Mark", 9.749998!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._username.ForeColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(86, Byte), Integer))
        Me._username.Location = New System.Drawing.Point(38, 173)
        Me._username.Margin = New System.Windows.Forms.Padding(0)
        Me._username.MaximumSize = New System.Drawing.Size(200, 20)
        Me._username.MaxLength = 50
        Me._username.MinimumSize = New System.Drawing.Size(200, 20)
        Me._username.Name = "_username"
        Me._username.Size = New System.Drawing.Size(200, 17)
        Me._username.TabIndex = 22
        Me._username.Text = "Username"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label1.Font = New System.Drawing.Font("Mark", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(109, 369)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(58, 19)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Sign in"
        '
        '_email
        '
        Me._email.BackColor = System.Drawing.Color.WhiteSmoke
        Me._email.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._email.Font = New System.Drawing.Font("Mark", 9.749998!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._email.ForeColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(86, Byte), Integer))
        Me._email.Location = New System.Drawing.Point(39, 138)
        Me._email.Margin = New System.Windows.Forms.Padding(0)
        Me._email.MaximumSize = New System.Drawing.Size(200, 20)
        Me._email.MaxLength = 20
        Me._email.MinimumSize = New System.Drawing.Size(200, 20)
        Me._email.Name = "_email"
        Me._email.Size = New System.Drawing.Size(200, 17)
        Me._email.TabIndex = 21
        Me._email.Text = "Email"
        '
        '_name
        '
        Me._name.BackColor = System.Drawing.Color.WhiteSmoke
        Me._name.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._name.Font = New System.Drawing.Font("Mark", 9.749998!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._name.ForeColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(86, Byte), Integer))
        Me._name.Location = New System.Drawing.Point(39, 68)
        Me._name.Margin = New System.Windows.Forms.Padding(0)
        Me._name.MaximumSize = New System.Drawing.Size(200, 20)
        Me._name.MaxLength = 20
        Me._name.MinimumSize = New System.Drawing.Size(200, 20)
        Me._name.Name = "_name"
        Me._name.Size = New System.Drawing.Size(200, 17)
        Me._name.TabIndex = 19
        Me._name.Text = "Name"
        '
        '_surname
        '
        Me._surname.BackColor = System.Drawing.Color.WhiteSmoke
        Me._surname.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._surname.Font = New System.Drawing.Font("Mark", 9.749998!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._surname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(86, Byte), Integer))
        Me._surname.Location = New System.Drawing.Point(39, 103)
        Me._surname.Margin = New System.Windows.Forms.Padding(0)
        Me._surname.MaximumSize = New System.Drawing.Size(200, 20)
        Me._surname.MaxLength = 20
        Me._surname.MinimumSize = New System.Drawing.Size(200, 20)
        Me._surname.Name = "_surname"
        Me._surname.Size = New System.Drawing.Size(200, 17)
        Me._surname.TabIndex = 20
        Me._surname.Text = "Surname"
        '
        'button
        '
        Me.button.FlatAppearance.BorderSize = 0
        Me.button.Font = New System.Drawing.Font("Mark", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button.ForeColor = System.Drawing.Color.White
        Me.button.Location = New System.Drawing.Point(101, 282)
        Me.button.Name = "button"
        Me.button.Size = New System.Drawing.Size(75, 75)
        Me.button.TabIndex = 25
        Me.button.Text = ">"
        Me.button.UseVisualStyleBackColor = True
        '
        'registro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(277, 414)
        Me.Controls.Add(Me.button)
        Me.Controls.Add(Me._surname)
        Me.Controls.Add(Me._name)
        Me.Controls.Add(Me._email)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me._password)
        Me.Controls.Add(Me._username)
        Me.Controls.Add(Me.Label3)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "registro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "League of Champs"
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
End Class
