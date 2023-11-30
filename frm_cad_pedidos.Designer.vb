<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_cad_pedidos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_cad_pedidos))
        Me.Label11 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btn_listagem = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btn_encerrar = New System.Windows.Forms.Button()
        Me.btn_limpar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_valor = New System.Windows.Forms.TextBox()
        Me.btn_confirmar = New System.Windows.Forms.Button()
        Me.cmb_status = New System.Windows.Forms.ComboBox()
        Me.txt_link_orcamento = New System.Windows.Forms.TextBox()
        Me.txt_descricao = New System.Windows.Forms.TextBox()
        Me.txt_num_cliente = New System.Windows.Forms.TextBox()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_link_os = New System.Windows.Forms.TextBox()
        Me.lbl_entrega = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_cliente = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_pedido = New System.Windows.Forms.TextBox()
        Me.cb_entregue = New System.Windows.Forms.CheckBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip2 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip3 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip4 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip5 = New System.Windows.Forms.ToolTip(Me.components)
        Me.txt_previsao = New System.Windows.Forms.DateTimePicker()
        Me.txt_data_entrega = New System.Windows.Forms.MaskedTextBox()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.White
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(424, 88)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(195, 20)
        Me.Label11.TabIndex = 127
        Me.Label11.Text = "Insira os dados do pedido:"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PictureBox2.Location = New System.Drawing.Point(2, 139)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(940, 6)
        Me.PictureBox2.TabIndex = 126
        Me.PictureBox2.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(158, 31)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(778, 44)
        Me.Label9.TabIndex = 125
        Me.Label9.Text = "TECNIU PROJETOS E REPRESENTAÇÕES"
        '
        'btn_listagem
        '
        Me.btn_listagem.BackColor = System.Drawing.Color.Transparent
        Me.btn_listagem.Image = CType(resources.GetObject("btn_listagem.Image"), System.Drawing.Image)
        Me.btn_listagem.Location = New System.Drawing.Point(338, 239)
        Me.btn_listagem.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_listagem.Name = "btn_listagem"
        Me.btn_listagem.Size = New System.Drawing.Size(35, 35)
        Me.btn_listagem.TabIndex = 124
        Me.ToolTip5.SetToolTip(Me.btn_listagem, "Consultar o nº do cliente")
        Me.btn_listagem.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(942, 146)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 123
        Me.PictureBox1.TabStop = False
        '
        'btn_encerrar
        '
        Me.btn_encerrar.Image = CType(resources.GetObject("btn_encerrar.Image"), System.Drawing.Image)
        Me.btn_encerrar.Location = New System.Drawing.Point(114, 392)
        Me.btn_encerrar.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_encerrar.Name = "btn_encerrar"
        Me.btn_encerrar.Size = New System.Drawing.Size(60, 53)
        Me.btn_encerrar.TabIndex = 15
        Me.ToolTip4.SetToolTip(Me.btn_encerrar, "Fechar o programa")
        Me.btn_encerrar.UseVisualStyleBackColor = True
        '
        'btn_limpar
        '
        Me.btn_limpar.BackColor = System.Drawing.Color.Transparent
        Me.btn_limpar.Image = CType(resources.GetObject("btn_limpar.Image"), System.Drawing.Image)
        Me.btn_limpar.Location = New System.Drawing.Point(114, 254)
        Me.btn_limpar.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_limpar.Name = "btn_limpar"
        Me.btn_limpar.Size = New System.Drawing.Size(60, 56)
        Me.btn_limpar.TabIndex = 13
        Me.ToolTip2.SetToolTip(Me.btn_limpar, "Limpar os campos preenchidos")
        Me.btn_limpar.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(210, 405)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 16)
        Me.Label2.TabIndex = 120
        Me.Label2.Text = "PREÇO*"
        '
        'txt_valor
        '
        Me.txt_valor.Location = New System.Drawing.Point(212, 425)
        Me.txt_valor.Name = "txt_valor"
        Me.txt_valor.Size = New System.Drawing.Size(159, 20)
        Me.txt_valor.TabIndex = 10
        '
        'btn_confirmar
        '
        Me.btn_confirmar.AccessibleDescription = ""
        Me.btn_confirmar.BackColor = System.Drawing.Color.Transparent
        Me.btn_confirmar.Image = CType(resources.GetObject("btn_confirmar.Image"), System.Drawing.Image)
        Me.btn_confirmar.Location = New System.Drawing.Point(114, 182)
        Me.btn_confirmar.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_confirmar.Name = "btn_confirmar"
        Me.btn_confirmar.Size = New System.Drawing.Size(60, 56)
        Me.btn_confirmar.TabIndex = 12
        Me.ToolTip1.SetToolTip(Me.btn_confirmar, "Salvar os dados")
        Me.btn_confirmar.UseVisualStyleBackColor = False
        '
        'cmb_status
        '
        Me.cmb_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_status.FormattingEnabled = True
        Me.cmb_status.Items.AddRange(New Object() {"NÃO PAGO", "PAGO"})
        Me.cmb_status.Location = New System.Drawing.Point(511, 368)
        Me.cmb_status.Margin = New System.Windows.Forms.Padding(2)
        Me.cmb_status.Name = "cmb_status"
        Me.cmb_status.Size = New System.Drawing.Size(99, 21)
        Me.cmb_status.TabIndex = 8
        '
        'txt_link_orcamento
        '
        Me.txt_link_orcamento.Location = New System.Drawing.Point(212, 314)
        Me.txt_link_orcamento.Name = "txt_link_orcamento"
        Me.txt_link_orcamento.Size = New System.Drawing.Size(211, 20)
        Me.txt_link_orcamento.TabIndex = 5
        '
        'txt_descricao
        '
        Me.txt_descricao.Location = New System.Drawing.Point(511, 201)
        Me.txt_descricao.Name = "txt_descricao"
        Me.txt_descricao.Size = New System.Drawing.Size(241, 20)
        Me.txt_descricao.TabIndex = 2
        '
        'txt_num_cliente
        '
        Me.txt_num_cliente.Location = New System.Drawing.Point(212, 255)
        Me.txt_num_cliente.Name = "txt_num_cliente"
        Me.txt_num_cliente.Size = New System.Drawing.Size(120, 20)
        Me.txt_num_cliente.TabIndex = 4
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Image = CType(resources.GetObject("btn_cancelar.Image"), System.Drawing.Image)
        Me.btn_cancelar.Location = New System.Drawing.Point(114, 322)
        Me.btn_cancelar.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(60, 57)
        Me.btn_cancelar.TabIndex = 14
        Me.ToolTip3.SetToolTip(Me.btn_cancelar, "Voltar para o menu")
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(209, 295)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(148, 16)
        Me.Label13.TabIndex = 110
        Me.Label13.Text = "LINK DO ORÇAMENTO"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(508, 295)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(194, 16)
        Me.Label10.TabIndex = 109
        Me.Label10.Text = "LINK DA ORDEM DE SERVIÇO"
        '
        'txt_link_os
        '
        Me.txt_link_os.Location = New System.Drawing.Point(511, 315)
        Me.txt_link_os.Name = "txt_link_os"
        Me.txt_link_os.Size = New System.Drawing.Size(241, 20)
        Me.txt_link_os.TabIndex = 6
        '
        'lbl_entrega
        '
        Me.lbl_entrega.AutoSize = True
        Me.lbl_entrega.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_entrega.Location = New System.Drawing.Point(508, 405)
        Me.lbl_entrega.Name = "lbl_entrega"
        Me.lbl_entrega.Size = New System.Drawing.Size(135, 16)
        Me.lbl_entrega.TabIndex = 107
        Me.lbl_entrega.Text = "DATA DE ENTREGA"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(509, 347)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 16)
        Me.Label7.TabIndex = 106
        Me.Label7.Text = "STATUS"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(509, 181)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 16)
        Me.Label6.TabIndex = 105
        Me.Label6.Text = "DESCRIÇÃO*"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(209, 347)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(166, 16)
        Me.Label5.TabIndex = 104
        Me.Label5.Text = "PREVISÃO DE ENTREGA"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(509, 234)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 16)
        Me.Label4.TabIndex = 103
        Me.Label4.Text = "CLIENTE"
        '
        'txt_cliente
        '
        Me.txt_cliente.BackColor = System.Drawing.Color.White
        Me.txt_cliente.Enabled = False
        Me.txt_cliente.Location = New System.Drawing.Point(511, 255)
        Me.txt_cliente.Name = "txt_cliente"
        Me.txt_cliente.ReadOnly = True
        Me.txt_cliente.Size = New System.Drawing.Size(176, 20)
        Me.txt_cliente.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(211, 234)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 16)
        Me.Label3.TabIndex = 101
        Me.Label3.Text = "Nº DO CLIENTE*"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(211, 183)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 16)
        Me.Label1.TabIndex = 100
        Me.Label1.Text = "PEDIDO*"
        '
        'txt_pedido
        '
        Me.txt_pedido.Location = New System.Drawing.Point(212, 202)
        Me.txt_pedido.Name = "txt_pedido"
        Me.txt_pedido.Size = New System.Drawing.Size(211, 20)
        Me.txt_pedido.TabIndex = 1
        '
        'cb_entregue
        '
        Me.cb_entregue.AutoSize = True
        Me.cb_entregue.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_entregue.Location = New System.Drawing.Point(212, 464)
        Me.cb_entregue.Margin = New System.Windows.Forms.Padding(2)
        Me.cb_entregue.Name = "cb_entregue"
        Me.cb_entregue.Size = New System.Drawing.Size(102, 20)
        Me.cb_entregue.TabIndex = 11
        Me.cb_entregue.Text = "ENTREGUE"
        Me.cb_entregue.UseVisualStyleBackColor = True
        '
        'txt_previsao
        '
        Me.txt_previsao.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txt_previsao.Location = New System.Drawing.Point(213, 368)
        Me.txt_previsao.Name = "txt_previsao"
        Me.txt_previsao.Size = New System.Drawing.Size(130, 20)
        Me.txt_previsao.TabIndex = 128
        '
        'txt_data_entrega
        '
        Me.txt_data_entrega.Location = New System.Drawing.Point(509, 425)
        Me.txt_data_entrega.Mask = "00/00/0000"
        Me.txt_data_entrega.Name = "txt_data_entrega"
        Me.txt_data_entrega.Size = New System.Drawing.Size(62, 20)
        Me.txt_data_entrega.TabIndex = 130
        Me.txt_data_entrega.ValidatingType = GetType(Date)
        '
        'frm_cad_pedidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(942, 519)
        Me.Controls.Add(Me.txt_data_entrega)
        Me.Controls.Add(Me.txt_previsao)
        Me.Controls.Add(Me.cb_entregue)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btn_listagem)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btn_encerrar)
        Me.Controls.Add(Me.btn_limpar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_valor)
        Me.Controls.Add(Me.btn_confirmar)
        Me.Controls.Add(Me.cmb_status)
        Me.Controls.Add(Me.txt_link_orcamento)
        Me.Controls.Add(Me.txt_descricao)
        Me.Controls.Add(Me.txt_num_cliente)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txt_link_os)
        Me.Controls.Add(Me.lbl_entrega)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_cliente)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_pedido)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frm_cad_pedidos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CADASTRO DE PEDIDOS"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label11 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label9 As Label
    Friend WithEvents btn_listagem As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btn_encerrar As Button
    Friend WithEvents btn_limpar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_valor As TextBox
    Friend WithEvents btn_confirmar As Button
    Friend WithEvents cmb_status As ComboBox
    Friend WithEvents txt_link_orcamento As TextBox
    Friend WithEvents txt_descricao As TextBox
    Friend WithEvents txt_num_cliente As TextBox
    Friend WithEvents btn_cancelar As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txt_link_os As TextBox
    Friend WithEvents lbl_entrega As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_cliente As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_pedido As TextBox
    Friend WithEvents cb_entregue As CheckBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents ToolTip4 As ToolTip
    Friend WithEvents ToolTip2 As ToolTip
    Friend WithEvents ToolTip3 As ToolTip
    Friend WithEvents ToolTip5 As ToolTip
    Friend WithEvents txt_previsao As DateTimePicker
    Friend WithEvents txt_data_entrega As MaskedTextBox
End Class
