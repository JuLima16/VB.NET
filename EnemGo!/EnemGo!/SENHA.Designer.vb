<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SENHA
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SENHA))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TXT_LOGIN = New System.Windows.Forms.TextBox()
        Me.TXT_SENHA = New System.Windows.Forms.TextBox()
        Me.BTN_GRAVAR = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(121, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(328, 240)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'TXT_LOGIN
        '
        Me.TXT_LOGIN.BackColor = System.Drawing.Color.White
        Me.TXT_LOGIN.Font = New System.Drawing.Font("Arial Narrow", 12.0!)
        Me.TXT_LOGIN.ForeColor = System.Drawing.Color.Gray
        Me.TXT_LOGIN.Location = New System.Drawing.Point(185, 90)
        Me.TXT_LOGIN.Name = "TXT_LOGIN"
        Me.TXT_LOGIN.Size = New System.Drawing.Size(207, 26)
        Me.TXT_LOGIN.TabIndex = 1
        Me.TXT_LOGIN.Text = "Login"
        '
        'TXT_SENHA
        '
        Me.TXT_SENHA.BackColor = System.Drawing.Color.White
        Me.TXT_SENHA.Font = New System.Drawing.Font("Arial Narrow", 12.0!)
        Me.TXT_SENHA.ForeColor = System.Drawing.Color.Gray
        Me.TXT_SENHA.Location = New System.Drawing.Point(185, 132)
        Me.TXT_SENHA.Name = "TXT_SENHA"
        Me.TXT_SENHA.Size = New System.Drawing.Size(207, 26)
        Me.TXT_SENHA.TabIndex = 2
        Me.TXT_SENHA.Text = "Senha"
        '
        'BTN_GRAVAR
        '
        Me.BTN_GRAVAR.BackColor = System.Drawing.Color.Gainsboro
        Me.BTN_GRAVAR.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_GRAVAR.ForeColor = System.Drawing.Color.White
        Me.BTN_GRAVAR.Location = New System.Drawing.Point(236, 176)
        Me.BTN_GRAVAR.Name = "BTN_GRAVAR"
        Me.BTN_GRAVAR.Size = New System.Drawing.Size(93, 29)
        Me.BTN_GRAVAR.TabIndex = 26
        Me.BTN_GRAVAR.Text = "Logar"
        Me.BTN_GRAVAR.UseVisualStyleBackColor = False
        '
        'SENHA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(558, 299)
        Me.Controls.Add(Me.BTN_GRAVAR)
        Me.Controls.Add(Me.TXT_SENHA)
        Me.Controls.Add(Me.TXT_LOGIN)
        Me.Controls.Add(Me.PictureBox1)
        Me.MaximizeBox = False
        Me.Name = "SENHA"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ACESSO DE ADMINISTRADOR"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TXT_LOGIN As System.Windows.Forms.TextBox
    Friend WithEvents TXT_SENHA As System.Windows.Forms.TextBox
    Friend WithEvents BTN_GRAVAR As System.Windows.Forms.Button
End Class
