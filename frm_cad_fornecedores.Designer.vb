<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_cad_fornecedores
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_cad_fornecedores))
        Me.txt_cep = New System.Windows.Forms.MaskedTextBox()
        Me.txt_cnpj = New System.Windows.Forms.MaskedTextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_referencia = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_uf = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_complemento = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_bairro = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_cidade = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_endereco = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_site = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_inscricao = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_atvd = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_empresa = New System.Windows.Forms.TextBox()
        Me.txt_cpf = New System.Windows.Forms.MaskedTextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.btn_limpar = New System.Windows.Forms.Button()
        Me.btn_cadastro = New System.Windows.Forms.Button()
        Me.btn_voltar = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip2 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip3 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip4 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip5 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_cep
        '
        Me.txt_cep.Location = New System.Drawing.Point(784, 385)
        Me.txt_cep.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_cep.Mask = "00000-999"
        Me.txt_cep.Name = "txt_cep"
        Me.txt_cep.Size = New System.Drawing.Size(320, 22)
        Me.txt_cep.TabIndex = 5
        '
        'txt_cnpj
        '
        Me.txt_cnpj.Location = New System.Drawing.Point(285, 321)
        Me.txt_cnpj.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_cnpj.Mask = "99,999,999/9999-99"
        Me.txt_cnpj.Name = "txt_cnpj"
        Me.txt_cnpj.Size = New System.Drawing.Size(320, 22)
        Me.txt_cnpj.TabIndex = 2
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(780, 560)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(208, 20)
        Me.Label12.TabIndex = 49
        Me.Label12.Text = "PONTO DE REFERÊNCIA"
        '
        'txt_referencia
        '
        Me.txt_referencia.Location = New System.Drawing.Point(784, 580)
        Me.txt_referencia.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_referencia.Name = "txt_referencia"
        Me.txt_referencia.Size = New System.Drawing.Size(320, 22)
        Me.txt_referencia.TabIndex = 11
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(281, 624)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(31, 20)
        Me.Label11.TabIndex = 47
        Me.Label11.Text = "UF"
        '
        'txt_uf
        '
        Me.txt_uf.Location = New System.Drawing.Point(285, 644)
        Me.txt_uf.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_uf.Name = "txt_uf"
        Me.txt_uf.Size = New System.Drawing.Size(320, 22)
        Me.txt_uf.TabIndex = 12
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(780, 496)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(140, 20)
        Me.Label10.TabIndex = 45
        Me.Label10.Text = "COMPLEMENTO"
        '
        'txt_complemento
        '
        Me.txt_complemento.Location = New System.Drawing.Point(784, 516)
        Me.txt_complemento.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_complemento.Name = "txt_complemento"
        Me.txt_complemento.Size = New System.Drawing.Size(320, 22)
        Me.txt_complemento.TabIndex = 9
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(281, 560)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(73, 20)
        Me.Label9.TabIndex = 43
        Me.Label9.Text = "BAIRRO"
        '
        'txt_bairro
        '
        Me.txt_bairro.Location = New System.Drawing.Point(285, 580)
        Me.txt_bairro.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_bairro.Name = "txt_bairro"
        Me.txt_bairro.Size = New System.Drawing.Size(320, 22)
        Me.txt_bairro.TabIndex = 10
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(780, 430)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 20)
        Me.Label8.TabIndex = 41
        Me.Label8.Text = "CIDADE"
        '
        'txt_cidade
        '
        Me.txt_cidade.Location = New System.Drawing.Point(784, 449)
        Me.txt_cidade.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_cidade.Name = "txt_cidade"
        Me.txt_cidade.Size = New System.Drawing.Size(320, 22)
        Me.txt_cidade.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(281, 494)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(104, 20)
        Me.Label7.TabIndex = 39
        Me.Label7.Text = "ENDEREÇO"
        '
        'txt_endereco
        '
        Me.txt_endereco.Location = New System.Drawing.Point(285, 513)
        Me.txt_endereco.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_endereco.Name = "txt_endereco"
        Me.txt_endereco.Size = New System.Drawing.Size(320, 22)
        Me.txt_endereco.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(780, 366)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 20)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "CEP*"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(281, 430)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 20)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "SITE"
        '
        'txt_site
        '
        Me.txt_site.Location = New System.Drawing.Point(285, 449)
        Me.txt_site.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_site.Name = "txt_site"
        Me.txt_site.Size = New System.Drawing.Size(320, 22)
        Me.txt_site.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(780, 302)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(194, 20)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "INSCRIÇÃO ESTADUAL"
        '
        'txt_inscricao
        '
        Me.txt_inscricao.Location = New System.Drawing.Point(784, 321)
        Me.txt_inscricao.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_inscricao.Name = "txt_inscricao"
        Me.txt_inscricao.Size = New System.Drawing.Size(320, 22)
        Me.txt_inscricao.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(281, 302)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 20)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "CNPJ*"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(780, 238)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 20)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "ATIVIDADE*"
        '
        'txt_atvd
        '
        Me.txt_atvd.Location = New System.Drawing.Point(784, 257)
        Me.txt_atvd.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_atvd.Name = "txt_atvd"
        Me.txt_atvd.Size = New System.Drawing.Size(320, 22)
        Me.txt_atvd.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(281, 238)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 20)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "EMPRESA*"
        '
        'txt_empresa
        '
        Me.txt_empresa.Location = New System.Drawing.Point(285, 257)
        Me.txt_empresa.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_empresa.Name = "txt_empresa"
        Me.txt_empresa.Size = New System.Drawing.Size(320, 22)
        Me.txt_empresa.TabIndex = 0
        '
        'txt_cpf
        '
        Me.txt_cpf.Location = New System.Drawing.Point(285, 385)
        Me.txt_cpf.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_cpf.Mask = "999,999,999-99"
        Me.txt_cpf.Name = "txt_cpf"
        Me.txt_cpf.Size = New System.Drawing.Size(320, 22)
        Me.txt_cpf.TabIndex = 4
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(281, 366)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(48, 20)
        Me.Label13.TabIndex = 54
        Me.Label13.Text = "CPF*"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1253, 146)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 125
        Me.PictureBox1.TabStop = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.White
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(200, 48)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(969, 54)
        Me.Label14.TabIndex = 127
        Me.Label14.Text = "TECNIU PROJETOS E REPRESENTAÇÕES"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.White
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(429, 119)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(399, 25)
        Me.Label15.TabIndex = 129
        Me.Label15.Text = "Insira os dados para cadastro do fornecedor:"
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Image = CType(resources.GetObject("btn_cancelar.Image"), System.Drawing.Image)
        Me.btn_cancelar.Location = New System.Drawing.Point(93, 523)
        Me.btn_cancelar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(80, 65)
        Me.btn_cancelar.TabIndex = 16
        Me.ToolTip4.SetToolTip(Me.btn_cancelar, "Encerrar o programa")
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'btn_limpar
        '
        Me.btn_limpar.BackColor = System.Drawing.Color.Transparent
        Me.btn_limpar.Image = CType(resources.GetObject("btn_limpar.Image"), System.Drawing.Image)
        Me.btn_limpar.Location = New System.Drawing.Point(93, 353)
        Me.btn_limpar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_limpar.Name = "btn_limpar"
        Me.btn_limpar.Size = New System.Drawing.Size(80, 69)
        Me.btn_limpar.TabIndex = 14
        Me.ToolTip2.SetToolTip(Me.btn_limpar, "Limpar os dados inseridos")
        Me.btn_limpar.UseVisualStyleBackColor = False
        '
        'btn_cadastro
        '
        Me.btn_cadastro.AccessibleDescription = ""
        Me.btn_cadastro.BackColor = System.Drawing.Color.Transparent
        Me.btn_cadastro.Image = CType(resources.GetObject("btn_cadastro.Image"), System.Drawing.Image)
        Me.btn_cadastro.Location = New System.Drawing.Point(93, 265)
        Me.btn_cadastro.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_cadastro.Name = "btn_cadastro"
        Me.btn_cadastro.Size = New System.Drawing.Size(80, 69)
        Me.btn_cadastro.TabIndex = 13
        Me.ToolTip1.SetToolTip(Me.btn_cadastro, "Confirmar os dados")
        Me.btn_cadastro.UseVisualStyleBackColor = False
        '
        'btn_voltar
        '
        Me.btn_voltar.Image = CType(resources.GetObject("btn_voltar.Image"), System.Drawing.Image)
        Me.btn_voltar.Location = New System.Drawing.Point(93, 437)
        Me.btn_voltar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_voltar.Name = "btn_voltar"
        Me.btn_voltar.Size = New System.Drawing.Size(80, 70)
        Me.btn_voltar.TabIndex = 15
        Me.ToolTip3.SetToolTip(Me.btn_voltar, "Voltar para o menu")
        Me.btn_voltar.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PictureBox2.Location = New System.Drawing.Point(0, 172)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(1423, 12)
        Me.PictureBox2.TabIndex = 134
        Me.PictureBox2.TabStop = False
        '
        'frm_cad_fornecedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1253, 750)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_limpar)
        Me.Controls.Add(Me.btn_cadastro)
        Me.Controls.Add(Me.btn_voltar)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txt_cpf)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txt_cep)
        Me.Controls.Add(Me.txt_cnpj)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txt_referencia)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txt_uf)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txt_complemento)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txt_bairro)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txt_cidade)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt_endereco)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_site)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_inscricao)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_atvd)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_empresa)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frm_cad_fornecedores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CADASTRO DE FORNECEDORES"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_cep As MaskedTextBox
    Friend WithEvents txt_cnpj As MaskedTextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txt_referencia As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txt_uf As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txt_complemento As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_bairro As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_cidade As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_endereco As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_site As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_inscricao As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_atvd As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_empresa As TextBox
    Friend WithEvents txt_cpf As MaskedTextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents btn_cancelar As Button
    Friend WithEvents btn_limpar As Button
    Friend WithEvents btn_cadastro As Button
    Friend WithEvents btn_voltar As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents ToolTip2 As ToolTip
    Friend WithEvents ToolTip3 As ToolTip
    Friend WithEvents ToolTip4 As ToolTip
    Friend WithEvents ToolTip5 As ToolTip
End Class
