<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_listagem_clientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_listagem_clientes))
        Me.dgv_listagem = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_pesquisar = New System.Windows.Forms.TextBox()
        Me.cmb_tipo = New System.Windows.Forms.ComboBox()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewImageColumn()
        CType(Me.dgv_listagem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_listagem
        '
        Me.dgv_listagem.AllowUserToAddRows = False
        Me.dgv_listagem.AllowUserToDeleteRows = False
        Me.dgv_listagem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv_listagem.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_listagem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_listagem.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8})
        Me.dgv_listagem.Location = New System.Drawing.Point(56, 125)
        Me.dgv_listagem.Name = "dgv_listagem"
        Me.dgv_listagem.ReadOnly = True
        Me.dgv_listagem.RowHeadersWidth = 62
        Me.dgv_listagem.RowTemplate.Height = 28
        Me.dgv_listagem.Size = New System.Drawing.Size(1116, 391)
        Me.dgv_listagem.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(66, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "FILTRO"
        '
        'txt_pesquisar
        '
        Me.txt_pesquisar.Location = New System.Drawing.Point(70, 46)
        Me.txt_pesquisar.Name = "txt_pesquisar"
        Me.txt_pesquisar.Size = New System.Drawing.Size(233, 26)
        Me.txt_pesquisar.TabIndex = 2
        '
        'cmb_tipo
        '
        Me.cmb_tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_tipo.FormattingEnabled = True
        Me.cmb_tipo.Location = New System.Drawing.Point(339, 44)
        Me.cmb_tipo.Name = "cmb_tipo"
        Me.cmb_tipo.Size = New System.Drawing.Size(144, 28)
        Me.cmb_tipo.TabIndex = 3
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column1.FillWeight = 255.6818!
        Me.Column1.HeaderText = "Número"
        Me.Column1.MinimumWidth = 8
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 75
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column2.FillWeight = 235.2273!
        Me.Column2.HeaderText = "Empresa"
        Me.Column2.MinimumWidth = 8
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 150
        '
        'Column3
        '
        Me.Column3.FillWeight = 27.27272!
        Me.Column3.HeaderText = "Atividade"
        Me.Column3.MinimumWidth = 8
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 110
        '
        'Column4
        '
        Me.Column4.FillWeight = 27.27272!
        Me.Column4.HeaderText = "Inscrição Estadual"
        Me.Column4.MinimumWidth = 8
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 162
        '
        'Column5
        '
        Me.Column5.FillWeight = 27.27272!
        Me.Column5.HeaderText = "CNPJ"
        Me.Column5.MinimumWidth = 8
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 85
        '
        'Column6
        '
        Me.Column6.FillWeight = 27.27272!
        Me.Column6.HeaderText = "CEP"
        Me.Column6.MinimumWidth = 8
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 77
        '
        'Column7
        '
        Me.Column7.HeaderText = "Editar"
        Me.Column7.Image = CType(resources.GetObject("Column7.Image"), System.Drawing.Image)
        Me.Column7.MinimumWidth = 8
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 57
        '
        'Column8
        '
        Me.Column8.HeaderText = "Excluir"
        Me.Column8.Image = CType(resources.GetObject("Column8.Image"), System.Drawing.Image)
        Me.Column8.MinimumWidth = 8
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Width = 61
        '
        'frm_listagem_clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1229, 672)
        Me.Controls.Add(Me.cmb_tipo)
        Me.Controls.Add(Me.txt_pesquisar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgv_listagem)
        Me.Name = "frm_listagem_clientes"
        Me.Text = "frm_listagem_clientes"
        CType(Me.dgv_listagem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgv_listagem As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_pesquisar As TextBox
    Friend WithEvents cmb_tipo As ComboBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewImageColumn
    Friend WithEvents Column8 As DataGridViewImageColumn
End Class
