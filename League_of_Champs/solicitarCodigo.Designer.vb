<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class solicitarCodigo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(solicitarCodigo))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.insertcode = New System.Windows.Forms.MaskedTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.button = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Mark", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(18, 17)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(152, 19)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "A code was sent to "
        '
        'insertcode
        '
        Me.insertcode.BackColor = System.Drawing.Color.WhiteSmoke
        Me.insertcode.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.insertcode.Font = New System.Drawing.Font("Mark", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.insertcode.ForeColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.insertcode.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite
        Me.insertcode.Location = New System.Drawing.Point(97, 72)
        Me.insertcode.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.insertcode.Mask = "###-###"
        Me.insertcode.Name = "insertcode"
        Me.insertcode.Size = New System.Drawing.Size(124, 26)
        Me.insertcode.TabIndex = 19
        Me.insertcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Mark", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(18, 46)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(128, 19)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Insert code here:"
        '
        'button
        '
        Me.button.FlatAppearance.BorderSize = 0
        Me.button.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button.ForeColor = System.Drawing.Color.White
        Me.button.Location = New System.Drawing.Point(247, 111)
        Me.button.Name = "button"
        Me.button.Size = New System.Drawing.Size(75, 42)
        Me.button.TabIndex = 21
        Me.button.Text = ">"
        Me.button.UseVisualStyleBackColor = True
        '
        'solicitarCodigo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(333, 167)
        Me.Controls.Add(Me.button)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.insertcode)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "solicitarCodigo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "League of Champs"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents insertcode As MaskedTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents button As Button
End Class
