<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class inicio
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(inicio))
        Me._username = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me._password = New System.Windows.Forms.TextBox()
        Me.button = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_username
        '
        Me._username.BackColor = System.Drawing.Color.WhiteSmoke
        Me._username.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._username.Font = New System.Drawing.Font("Mark", 9.749998!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._username.ForeColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(86, Byte), Integer))
        Me._username.Location = New System.Drawing.Point(37, 157)
        Me._username.Margin = New System.Windows.Forms.Padding(0)
        Me._username.MaximumSize = New System.Drawing.Size(200, 20)
        Me._username.MaxLength = 50
        Me._username.MinimumSize = New System.Drawing.Size(200, 20)
        Me._username.Name = "_username"
        Me._username.Size = New System.Drawing.Size(200, 17)
        Me._username.TabIndex = 9
        Me._username.Text = "Username"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label1.Font = New System.Drawing.Font("Mark", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(66, 483)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(143, 19)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Create an account"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Location = New System.Drawing.Point(-4, -6)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(283, 558)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label2.Location = New System.Drawing.Point(284, 522)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(381, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Prototipo v1.0.10 - Todo lo mostrado en pantalla se encuentra sujeto a cambios"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label3.Font = New System.Drawing.Font("Mark", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(97, 113)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(80, 26)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Sign in"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.White
        Me.PictureBox3.Image = Global.League_of_Champs.My.Resources.Resources.miLogoBlue
        Me.PictureBox3.Location = New System.Drawing.Point(141, 44)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(100, 32)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 13
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.White
        Me.PictureBox2.Image = Global.League_of_Champs.My.Resources.Resources._002_RG_2021_FULL_LOCKUP_RED
        Me.PictureBox2.Location = New System.Drawing.Point(35, 44)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(100, 32)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 12
        Me.PictureBox2.TabStop = False
        '
        '_password
        '
        Me._password.BackColor = System.Drawing.Color.WhiteSmoke
        Me._password.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._password.Font = New System.Drawing.Font("Mark", 9.749998!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._password.ForeColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(86, Byte), Integer))
        Me._password.Location = New System.Drawing.Point(37, 195)
        Me._password.Margin = New System.Windows.Forms.Padding(0)
        Me._password.MaximumSize = New System.Drawing.Size(200, 20)
        Me._password.MaxLength = 20
        Me._password.MinimumSize = New System.Drawing.Size(200, 20)
        Me._password.Name = "_password"
        Me._password.Size = New System.Drawing.Size(200, 17)
        Me._password.TabIndex = 11
        Me._password.Text = "Password"
        '
        'button
        '
        Me.button.FlatAppearance.BorderSize = 0
        Me.button.Font = New System.Drawing.Font("Mark", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button.ForeColor = System.Drawing.Color.White
        Me.button.Location = New System.Drawing.Point(100, 385)
        Me.button.Name = "button"
        Me.button.Size = New System.Drawing.Size(75, 75)
        Me.button.TabIndex = 17
        Me.button.Text = ">"
        Me.button.UseVisualStyleBackColor = True
        '
        'inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.League_of_Champs.My.Resources.Resources.fondo
        Me.ClientSize = New System.Drawing.Size(780, 547)
        Me.Controls.Add(Me.button)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me._password)
        Me.Controls.Add(Me._username)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "inicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "League of Champs"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents _username As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents _password As TextBox
    Friend WithEvents button As Button
End Class
