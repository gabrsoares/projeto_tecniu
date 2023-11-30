<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_list_contatos_c
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_list_contatos_c))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btn_voltar = New System.Windows.Forms.Button()
        Me.btn_atualizar = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cmb_tipo = New System.Windows.Forms.ComboBox()
        Me.txt_pesquisar = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgv_contatos = New System.Windows.Forms.DataGridView()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewImageColumn()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_contatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_voltar
        '
        Me.btn_voltar.Image = CType(resources.GetObject("btn_voltar.Image"), System.Drawing.Image)
        Me.btn_voltar.Location = New System.Drawing.Point(384, 168)
        Me.btn_voltar.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_voltar.Name = "btn_voltar"
        Me.btn_voltar.Size = New System.Drawing.Size(60, 57)
        Me.btn_voltar.TabIndex = 145
        Me.ToolTip1.SetToolTip(Me.btn_voltar, "Voltar para a escolha de listagens")
        Me.btn_voltar.UseVisualStyleBackColor = True
        '
        'btn_atualizar
        '
        Me.btn_atualizar.Image = CType(resources.GetObject("btn_atualizar.Image"), System.Drawing.Image)
        Me.btn_atualizar.Location = New System.Drawing.Point(464, 168)
        Me.btn_atualizar.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_atualizar.Name = "btn_atualizar"
        Me.btn_atualizar.Size = New System.Drawing.Size(60, 57)
        Me.btn_atualizar.TabIndex = 147
        Me.ToolTip1.SetToolTip(Me.btn_atualizar, "Voltar para a escolha de listagens")
        Me.btn_atualizar.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox2.Location = New System.Drawing.Point(0, 146)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(1020, 10)
        Me.PictureBox2.TabIndex = 146
        Me.PictureBox2.TabStop = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.White
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(421, 108)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(211, 20)
        Me.Label15.TabIndex = 144
        Me.Label15.Text = "Insira o parâmetro desejado:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.White
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(169, 52)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(778, 44)
        Me.Label14.TabIndex = 143
        Me.Label14.Text = "TECNIU PROJETOS E REPRESENTAÇÕES"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1020, 146)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 142
        Me.PictureBox1.TabStop = False
        '
        'cmb_tipo
        '
        Me.cmb_tipo.BackColor = System.Drawing.SystemColors.Window
        Me.cmb_tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_tipo.FormattingEnabled = True
        Me.cmb_tipo.Location = New System.Drawing.Point(219, 184)
        Me.cmb_tipo.Margin = New System.Windows.Forms.Padding(2)
        Me.cmb_tipo.Name = "cmb_tipo"
        Me.cmb_tipo.Size = New System.Drawing.Size(97, 21)
        Me.cmb_tipo.TabIndex = 140
        '
        'txt_pesquisar
        '
        Me.txt_pesquisar.Location = New System.Drawing.Point(40, 185)
        Me.txt_pesquisar.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_pesquisar.Name = "txt_pesquisar"
        Me.txt_pesquisar.Size = New System.Drawing.Size(157, 20)
        Me.txt_pesquisar.TabIndex = 139
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(41, 168)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 16)
        Me.Label1.TabIndex = 138
        Me.Label1.Text = "FILTRO"
        '
        'dgv_contatos
        '
        Me.dgv_contatos.AllowUserToAddRows = False
        Me.dgv_contatos.AllowUserToDeleteRows = False
        Me.dgv_contatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv_contatos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_contatos.BackgroundColor = System.Drawing.SystemColors.ControlLight
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_contatos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_contatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_contatos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column10, Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column9, Me.Column8})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_contatos.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_contatos.Location = New System.Drawing.Point(40, 245)
        Me.dgv_contatos.Margin = New System.Windows.Forms.Padding(2)
        Me.dgv_contatos.Name = "dgv_contatos"
        Me.dgv_contatos.ReadOnly = True
        Me.dgv_contatos.RowHeadersWidth = 62
        Me.dgv_contatos.RowTemplate.Height = 28
        Me.dgv_contatos.Size = New System.Drawing.Size(938, 318)
        Me.dgv_contatos.TabIndex = 148
        '
        'Column10
        '
        Me.Column10.HeaderText = "Código"
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        Me.Column10.Width = 76
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        Me.Column1.DefaultCellStyle = DataGridViewCellStyle2
        Me.Column1.FillWeight = 255.6818!
        Me.Column1.HeaderText = "Nome"
        Me.Column1.MinimumWidth = 8
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 69
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column2.FillWeight = 235.2273!
        Me.Column2.HeaderText = "Apelido"
        Me.Column2.MinimumWidth = 8
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 80
        '
        'Column3
        '
        Me.Column3.FillWeight = 27.27272!
        Me.Column3.HeaderText = "Cargo"
        Me.Column3.MinimumWidth = 8
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 69
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column4.FillWeight = 27.27272!
        Me.Column4.HeaderText = "Empresa"
        Me.Column4.MinimumWidth = 8
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column4.Width = 200
        '
        'Column5
        '
        Me.Column5.FillWeight = 27.27272!
        Me.Column5.HeaderText = "Telefone"
        Me.Column5.MinimumWidth = 8
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 86
        '
        'Column6
        '
        Me.Column6.FillWeight = 27.27272!
        Me.Column6.HeaderText = "Email"
        Me.Column6.MinimumWidth = 8
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 66
        '
        'Column9
        '
        Me.Column9.HeaderText = "Celular"
        Me.Column9.MinimumWidth = 6
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        Me.Column9.Width = 74
        '
        'Column8
        '
        Me.Column8.HeaderText = "Excluir"
        Me.Column8.Image = CType(resources.GetObject("Column8.Image"), System.Drawing.Image)
        Me.Column8.MinimumWidth = 8
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Width = 52
        '
        'frm_list_contatos_c
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1020, 609)
        Me.Controls.Add(Me.dgv_contatos)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.btn_voltar)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btn_atualizar)
        Me.Controls.Add(Me.cmb_tipo)
        Me.Controls.Add(Me.txt_pesquisar)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_list_contatos_c"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listagem de contatos"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_contatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents btn_voltar As Button
    Friend WithEvents btn_atualizar As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents cmb_tipo As ComboBox
    Friend WithEvents txt_pesquisar As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dgv_contatos As DataGridView
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewImageColumn
End Class
