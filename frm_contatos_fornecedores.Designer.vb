<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_contatos_fornecedores
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_contatos_fornecedores))
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btn_limpar = New System.Windows.Forms.Button()
        Me.btn_confirma = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_cargo = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_apelido = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_nome = New System.Windows.Forms.TextBox()
        Me.btn_voltar_fornecedores = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_codfornecedor = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_empresa = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip2 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip3 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip4 = New System.Windows.Forms.ToolTip(Me.components)
        Me.txt_celular = New System.Windows.Forms.MaskedTextBox()
        Me.txt_telefone = New System.Windows.Forms.MaskedTextBox()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox2.Location = New System.Drawing.Point(0, 146)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(513, 10)
        Me.PictureBox2.TabIndex = 157
        Me.PictureBox2.TabStop = False
        '
        'btn_limpar
        '
        Me.btn_limpar.BackColor = System.Drawing.Color.Transparent
        Me.btn_limpar.Image = CType(resources.GetObject("btn_limpar.Image"), System.Drawing.Image)
        Me.btn_limpar.Location = New System.Drawing.Point(32, 283)
        Me.btn_limpar.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_limpar.Name = "btn_limpar"
        Me.btn_limpar.Size = New System.Drawing.Size(60, 56)
        Me.btn_limpar.TabIndex = 9
        Me.ToolTip1.SetToolTip(Me.btn_limpar, "Limpar os dados inseridos")
        Me.btn_limpar.UseVisualStyleBackColor = False
        '
        'btn_confirma
        '
        Me.btn_confirma.Image = CType(resources.GetObject("btn_confirma.Image"), System.Drawing.Image)
        Me.btn_confirma.Location = New System.Drawing.Point(31, 208)
        Me.btn_confirma.Name = "btn_confirma"
        Me.btn_confirma.Size = New System.Drawing.Size(60, 59)
        Me.btn_confirma.TabIndex = 8
        Me.ToolTip2.SetToolTip(Me.btn_confirma, "Cadastrar contato")
        Me.btn_confirma.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(176, 82)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(287, 20)
        Me.Label8.TabIndex = 156
        Me.Label8.Text = "insira os dados do contato na empresa:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(159, 49)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(324, 26)
        Me.Label9.TabIndex = 155
        Me.Label9.Text = "CADASTRO DE CONTATOS!"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(513, 146)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 154
        Me.PictureBox1.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(132, 324)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 15)
        Me.Label6.TabIndex = 152
        Me.Label6.Text = "Cargo"
        '
        'txt_cargo
        '
        Me.txt_cargo.Location = New System.Drawing.Point(128, 343)
        Me.txt_cargo.Name = "txt_cargo"
        Me.txt_cargo.Size = New System.Drawing.Size(147, 20)
        Me.txt_cargo.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(324, 254)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 15)
        Me.Label5.TabIndex = 151
        Me.Label5.Text = "Apelido"
        '
        'txt_apelido
        '
        Me.txt_apelido.Location = New System.Drawing.Point(320, 273)
        Me.txt_apelido.Name = "txt_apelido"
        Me.txt_apelido.Size = New System.Drawing.Size(147, 20)
        Me.txt_apelido.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(324, 319)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 15)
        Me.Label4.TabIndex = 148
        Me.Label4.Text = "Celular"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(132, 392)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 15)
        Me.Label3.TabIndex = 145
        Me.Label3.Text = "Telefone"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(324, 395)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 15)
        Me.Label2.TabIndex = 141
        Me.Label2.Text = "Email "
        '
        'txt_email
        '
        Me.txt_email.Location = New System.Drawing.Point(320, 413)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(147, 20)
        Me.txt_email.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(132, 254)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 15)
        Me.Label1.TabIndex = 138
        Me.Label1.Text = "Nome"
        '
        'txt_nome
        '
        Me.txt_nome.Location = New System.Drawing.Point(128, 273)
        Me.txt_nome.Name = "txt_nome"
        Me.txt_nome.Size = New System.Drawing.Size(147, 20)
        Me.txt_nome.TabIndex = 2
        '
        'btn_voltar_fornecedores
        '
        Me.btn_voltar_fornecedores.Image = CType(resources.GetObject("btn_voltar_fornecedores.Image"), System.Drawing.Image)
        Me.btn_voltar_fornecedores.Location = New System.Drawing.Point(31, 353)
        Me.btn_voltar_fornecedores.Name = "btn_voltar_fornecedores"
        Me.btn_voltar_fornecedores.Size = New System.Drawing.Size(60, 51)
        Me.btn_voltar_fornecedores.TabIndex = 10
        Me.ToolTip3.SetToolTip(Me.btn_voltar_fornecedores, "Voltar para o formulário  de clientes")
        Me.btn_voltar_fornecedores.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(125, 186)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(132, 15)
        Me.Label10.TabIndex = 161
        Me.Label10.Text = "Código Fornecedor"
        '
        'txt_codfornecedor
        '
        Me.txt_codfornecedor.Location = New System.Drawing.Point(128, 205)
        Me.txt_codfornecedor.Name = "txt_codfornecedor"
        Me.txt_codfornecedor.Size = New System.Drawing.Size(147, 20)
        Me.txt_codfornecedor.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(324, 186)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 15)
        Me.Label7.TabIndex = 159
        Me.Label7.Text = "Empresa"
        '
        'txt_empresa
        '
        Me.txt_empresa.Location = New System.Drawing.Point(320, 204)
        Me.txt_empresa.Name = "txt_empresa"
        Me.txt_empresa.Size = New System.Drawing.Size(147, 20)
        Me.txt_empresa.TabIndex = 1
        '
        'txt_celular
        '
        Me.txt_celular.Location = New System.Drawing.Point(320, 343)
        Me.txt_celular.Mask = "(00)000000000"
        Me.txt_celular.Name = "txt_celular"
        Me.txt_celular.Size = New System.Drawing.Size(147, 20)
        Me.txt_celular.TabIndex = 5
        Me.txt_celular.ValidatingType = GetType(Date)
        '
        'txt_telefone
        '
        Me.txt_telefone.Location = New System.Drawing.Point(128, 413)
        Me.txt_telefone.Mask = "(00)00000000"
        Me.txt_telefone.Name = "txt_telefone"
        Me.txt_telefone.Size = New System.Drawing.Size(147, 20)
        Me.txt_telefone.TabIndex = 6
        Me.txt_telefone.ValidatingType = GetType(Date)
        '
        'frm_contatos_fornecedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(513, 488)
        Me.Controls.Add(Me.txt_telefone)
        Me.Controls.Add(Me.txt_celular)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txt_codfornecedor)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt_empresa)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.btn_limpar)
        Me.Controls.Add(Me.btn_confirma)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_cargo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_apelido)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_email)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_nome)
        Me.Controls.Add(Me.btn_voltar_fornecedores)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_contatos_fornecedores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CONTATOS"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btn_limpar As Button
    Friend WithEvents btn_confirma As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_cargo As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_apelido As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_email As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_nome As TextBox
    Friend WithEvents btn_voltar_fornecedores As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents txt_codfornecedor As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_empresa As TextBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents ToolTip2 As ToolTip
    Friend WithEvents ToolTip3 As ToolTip
    Friend WithEvents ToolTip4 As ToolTip
    Friend WithEvents txt_celular As MaskedTextBox
    Friend WithEvents txt_telefone As MaskedTextBox
End Class
