<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SIMULADOS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SIMULADOS))
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TXT_CORREÇÃO = New System.Windows.Forms.Label()
        Me.TXT_PDF = New System.Windows.Forms.Label()
        Me.BTN_GRAVAR = New System.Windows.Forms.Button()
        Me.TXT_PLANO = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Carregar = New System.Windows.Forms.OpenFileDialog()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BTN_COR_REDAÇÃO = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PictureBox12 = New System.Windows.Forms.PictureBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BTN_REDACAO = New System.Windows.Forms.Panel()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BTN_SIMU = New System.Windows.Forms.Panel()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BTN_MATERIA = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BTN_PLANO = New System.Windows.Forms.Panel()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TXT_N = New System.Windows.Forms.TextBox()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.BTN_COR_REDAÇÃO.SuspendLayout()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BTN_REDACAO.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BTN_SIMU.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BTN_MATERIA.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BTN_PLANO.SuspendLayout()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.BackgroundImage = CType(resources.GetObject("Panel3.BackgroundImage"), System.Drawing.Image)
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel3.Controls.Add(Me.TXT_N)
        Me.Panel3.Controls.Add(Me.TXT_CORREÇÃO)
        Me.Panel3.Controls.Add(Me.TXT_PDF)
        Me.Panel3.Controls.Add(Me.BTN_GRAVAR)
        Me.Panel3.Controls.Add(Me.TXT_PLANO)
        Me.Panel3.Location = New System.Drawing.Point(314, -2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(551, 591)
        Me.Panel3.TabIndex = 8
        '
        'TXT_CORREÇÃO
        '
        Me.TXT_CORREÇÃO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXT_CORREÇÃO.Font = New System.Drawing.Font("Arial Narrow", 12.0!)
        Me.TXT_CORREÇÃO.ForeColor = System.Drawing.Color.Gray
        Me.TXT_CORREÇÃO.Location = New System.Drawing.Point(81, 279)
        Me.TXT_CORREÇÃO.Name = "TXT_CORREÇÃO"
        Me.TXT_CORREÇÃO.Size = New System.Drawing.Size(396, 26)
        Me.TXT_CORREÇÃO.TabIndex = 29
        Me.TXT_CORREÇÃO.Text = "PDF (correção)"
        Me.TXT_CORREÇÃO.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TXT_PDF
        '
        Me.TXT_PDF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXT_PDF.Font = New System.Drawing.Font("Arial Narrow", 12.0!)
        Me.TXT_PDF.ForeColor = System.Drawing.Color.Gray
        Me.TXT_PDF.Location = New System.Drawing.Point(81, 240)
        Me.TXT_PDF.Name = "TXT_PDF"
        Me.TXT_PDF.Size = New System.Drawing.Size(396, 26)
        Me.TXT_PDF.TabIndex = 28
        Me.TXT_PDF.Text = "PDF (simulado)"
        Me.TXT_PDF.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BTN_GRAVAR
        '
        Me.BTN_GRAVAR.BackColor = System.Drawing.Color.Gainsboro
        Me.BTN_GRAVAR.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_GRAVAR.ForeColor = System.Drawing.Color.White
        Me.BTN_GRAVAR.Location = New System.Drawing.Point(229, 359)
        Me.BTN_GRAVAR.Name = "BTN_GRAVAR"
        Me.BTN_GRAVAR.Size = New System.Drawing.Size(93, 37)
        Me.BTN_GRAVAR.TabIndex = 15
        Me.BTN_GRAVAR.Text = "Gravar"
        Me.BTN_GRAVAR.UseVisualStyleBackColor = False
        '
        'TXT_PLANO
        '
        Me.TXT_PLANO.Font = New System.Drawing.Font("Arial Narrow", 12.0!)
        Me.TXT_PLANO.ForeColor = System.Drawing.Color.Gray
        Me.TXT_PLANO.FormattingEnabled = True
        Me.TXT_PLANO.Items.AddRange(New Object() {"", "Pagos"})
        Me.TXT_PLANO.Location = New System.Drawing.Point(182, 317)
        Me.TXT_PLANO.Name = "TXT_PLANO"
        Me.TXT_PLANO.Size = New System.Drawing.Size(188, 28)
        Me.TXT_PLANO.TabIndex = 12
        Me.TXT_PLANO.Text = "Plano"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(251, 30)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 20)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "SIMULADOS"
        '
        'Carregar
        '
        Me.Carregar.FileName = "OpenFileDialog1"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.BTN_COR_REDAÇÃO)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.BTN_REDACAO)
        Me.Panel1.Controls.Add(Me.BTN_SIMU)
        Me.Panel1.Controls.Add(Me.BTN_MATERIA)
        Me.Panel1.Controls.Add(Me.BTN_PLANO)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(226, 591)
        Me.Panel1.TabIndex = 10
        '
        'BTN_COR_REDAÇÃO
        '
        Me.BTN_COR_REDAÇÃO.BackColor = System.Drawing.Color.Transparent
        Me.BTN_COR_REDAÇÃO.Controls.Add(Me.Label8)
        Me.BTN_COR_REDAÇÃO.Controls.Add(Me.PictureBox12)
        Me.BTN_COR_REDAÇÃO.Dock = System.Windows.Forms.DockStyle.Top
        Me.BTN_COR_REDAÇÃO.Location = New System.Drawing.Point(0, 460)
        Me.BTN_COR_REDAÇÃO.Name = "BTN_COR_REDAÇÃO"
        Me.BTN_COR_REDAÇÃO.Size = New System.Drawing.Size(224, 50)
        Me.BTN_COR_REDAÇÃO.TabIndex = 9
        Me.BTN_COR_REDAÇÃO.Visible = False
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label8.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(50, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(174, 50)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Redação"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox12
        '
        Me.PictureBox12.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox12.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox12.Name = "PictureBox12"
        Me.PictureBox12.Size = New System.Drawing.Size(48, 50)
        Me.PictureBox12.TabIndex = 3
        Me.PictureBox12.TabStop = False
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Transparent
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.PictureBox9)
        Me.Panel5.Controls.Add(Me.Label7)
        Me.Panel5.Controls.Add(Me.PictureBox7)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 402)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(224, 58)
        Me.Panel5.TabIndex = 7
        '
        'PictureBox9
        '
        Me.PictureBox9.BackgroundImage = CType(resources.GetObject("PictureBox9.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox9.Location = New System.Drawing.Point(180, 18)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox9.TabIndex = 29
        Me.PictureBox9.TabStop = False
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label7.Font = New System.Drawing.Font("Arial Narrow", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(35, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(187, 56)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Corrigir"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox7
        '
        Me.PictureBox7.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox7.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(35, 56)
        Me.PictureBox7.TabIndex = 3
        Me.PictureBox7.TabStop = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Transparent
        Me.Panel4.Controls.Add(Me.PictureBox6)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 352)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(224, 50)
        Me.Panel4.TabIndex = 7
        Me.Panel4.Visible = False
        '
        'PictureBox6
        '
        Me.PictureBox6.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox6.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(48, 50)
        Me.PictureBox6.TabIndex = 3
        Me.PictureBox6.TabStop = False
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(50, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(174, 50)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Redação"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BTN_REDACAO
        '
        Me.BTN_REDACAO.BackColor = System.Drawing.Color.Transparent
        Me.BTN_REDACAO.Controls.Add(Me.PictureBox5)
        Me.BTN_REDACAO.Controls.Add(Me.Label3)
        Me.BTN_REDACAO.Dock = System.Windows.Forms.DockStyle.Top
        Me.BTN_REDACAO.Location = New System.Drawing.Point(0, 302)
        Me.BTN_REDACAO.Name = "BTN_REDACAO"
        Me.BTN_REDACAO.Size = New System.Drawing.Size(224, 50)
        Me.BTN_REDACAO.TabIndex = 6
        Me.BTN_REDACAO.Visible = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox5.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(48, 50)
        Me.PictureBox5.TabIndex = 3
        Me.PictureBox5.TabStop = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(50, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(174, 50)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Simulados"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BTN_SIMU
        '
        Me.BTN_SIMU.BackColor = System.Drawing.Color.Transparent
        Me.BTN_SIMU.Controls.Add(Me.PictureBox4)
        Me.BTN_SIMU.Controls.Add(Me.Label2)
        Me.BTN_SIMU.Dock = System.Windows.Forms.DockStyle.Top
        Me.BTN_SIMU.Location = New System.Drawing.Point(0, 252)
        Me.BTN_SIMU.Name = "BTN_SIMU"
        Me.BTN_SIMU.Size = New System.Drawing.Size(224, 50)
        Me.BTN_SIMU.TabIndex = 5
        Me.BTN_SIMU.Visible = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox4.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(48, 50)
        Me.PictureBox4.TabIndex = 3
        Me.PictureBox4.TabStop = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(50, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(174, 50)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Matéria"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BTN_MATERIA
        '
        Me.BTN_MATERIA.BackColor = System.Drawing.Color.Transparent
        Me.BTN_MATERIA.Controls.Add(Me.PictureBox3)
        Me.BTN_MATERIA.Controls.Add(Me.Label1)
        Me.BTN_MATERIA.Dock = System.Windows.Forms.DockStyle.Top
        Me.BTN_MATERIA.Location = New System.Drawing.Point(0, 202)
        Me.BTN_MATERIA.Name = "BTN_MATERIA"
        Me.BTN_MATERIA.Size = New System.Drawing.Size(224, 50)
        Me.BTN_MATERIA.TabIndex = 4
        Me.BTN_MATERIA.Visible = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox3.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(48, 50)
        Me.PictureBox3.TabIndex = 3
        Me.PictureBox3.TabStop = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(50, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(174, 50)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Plano de Estudos"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BTN_PLANO
        '
        Me.BTN_PLANO.BackColor = System.Drawing.Color.Transparent
        Me.BTN_PLANO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BTN_PLANO.Controls.Add(Me.PictureBox10)
        Me.BTN_PLANO.Controls.Add(Me.Label5)
        Me.BTN_PLANO.Controls.Add(Me.PictureBox2)
        Me.BTN_PLANO.Dock = System.Windows.Forms.DockStyle.Top
        Me.BTN_PLANO.Location = New System.Drawing.Point(0, 144)
        Me.BTN_PLANO.Name = "BTN_PLANO"
        Me.BTN_PLANO.Size = New System.Drawing.Size(224, 58)
        Me.BTN_PLANO.TabIndex = 0
        '
        'PictureBox10
        '
        Me.PictureBox10.BackgroundImage = CType(resources.GetObject("PictureBox10.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox10.Location = New System.Drawing.Point(180, 18)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox10.TabIndex = 30
        Me.PictureBox10.TabStop = False
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Font = New System.Drawing.Font("Arial Narrow", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(35, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(187, 56)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Cadastrar"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(35, 56)
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(224, 144)
        Me.Panel2.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(42, 46)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(133, 42)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'TXT_N
        '
        Me.TXT_N.BackColor = System.Drawing.Color.White
        Me.TXT_N.Font = New System.Drawing.Font("Arial Narrow", 12.0!)
        Me.TXT_N.ForeColor = System.Drawing.Color.Gray
        Me.TXT_N.Location = New System.Drawing.Point(81, 204)
        Me.TXT_N.Name = "TXT_N"
        Me.TXT_N.Size = New System.Drawing.Size(396, 26)
        Me.TXT_N.TabIndex = 30
        Me.TXT_N.Text = "Nº (simulado)"
        '
        'SIMULADOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(938, 591)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "SIMULADOS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CADASTRO DE CONTÉUDOS"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.BTN_COR_REDAÇÃO.ResumeLayout(False)
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BTN_REDACAO.ResumeLayout(False)
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BTN_SIMU.ResumeLayout(False)
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BTN_MATERIA.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BTN_PLANO.ResumeLayout(False)
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TXT_PLANO As System.Windows.Forms.ComboBox
    Friend WithEvents BTN_GRAVAR As System.Windows.Forms.Button
    Friend WithEvents TXT_CORREÇÃO As System.Windows.Forms.Label
    Friend WithEvents TXT_PDF As System.Windows.Forms.Label
    Friend WithEvents Carregar As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents BTN_COR_REDAÇÃO As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents PictureBox12 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox9 As System.Windows.Forms.PictureBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents PictureBox7 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents BTN_REDACAO As System.Windows.Forms.Panel
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BTN_SIMU As System.Windows.Forms.Panel
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BTN_MATERIA As System.Windows.Forms.Panel
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BTN_PLANO As System.Windows.Forms.Panel
    Friend WithEvents PictureBox10 As System.Windows.Forms.PictureBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TXT_N As System.Windows.Forms.TextBox
End Class
