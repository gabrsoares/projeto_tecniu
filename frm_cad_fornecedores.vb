Imports System.ComponentModel

Public Class frm_cad_fornecedores
    Private botaoVoltar = False
    Private criarContato As Boolean = False
    Private Sub frm_cad_fornecedores_Load(sender As Object, e As EventArgs) Handles Me.Load
        criarContato = False 'reseta a condição de criar contato
        Me.StartPosition = FormStartPosition.CenterScreen
        If (db.State <> ConnectionState.Open) Then 'só conecta o banco se ele estiver fechado, para evitar erros
            conectar_banco()
        End If
    End Sub

    Private Sub txt_inscricao_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_inscricao.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> Convert.ToChar(Keys.Back) Then 'logica para permitir apenas numeros no campo de inscricao
            e.Handled = True
        End If
    End Sub



    'Private Sub txt_cep_LostFocus(sender As Object, e As EventArgs) Handles txt_cep.LostFocus
    'SQL = "select * from tb_cep where cep='" & txt_cep.Text & "'"
    'cmd.CommandText = SQL
    'reader = cmd.ExecuteReader()
    'If reader.Read() Then
    ' txt_endereco.Text = reader.GetString(1)
    'txt_cidade.Text = reader.GetString(2)
    'txt_bairro.Text = reader.GetString(3)
    'txt_uf.Text = reader.GetString(4)
    'txt_site.Focus()
    'End If
    'reader.Close()
    'End Sub

    Private Sub txt_cep_DoubleClick(sender As Object, e As EventArgs) Handles txt_cep.DoubleClick 'limpa os campos de endereço ao clicar 2x no cep
        txt_cep.Clear()
        txt_endereco.Clear()
        txt_cidade.Clear()
        txt_bairro.Clear()
        txt_uf.Clear()
    End Sub



    Private Sub btn_voltar_Click(sender As Object, e As EventArgs) Handles btn_voltar.Click
        botaoVoltar = True
        db.Close()

        If editarCadastro = True Then 'verifica se o formulario foi aberto pela listagem ou pelo menu
            frm_listagem.Show()
            editarCadastro = False
        Else
            frm_menu.Show()
        End If
        Me.Close()
    End Sub

    Private Sub add_contato_Click(sender As Object, e As EventArgs) 'permite o usuario a adicionar contatos sem preencher o formulario
        db.Close()
        Me.Close()

        ' Abre o próximo formulário
        Dim frm_contatos As New frm_contatos_clientes()
        frm_contatos.Show()

    End Sub

    Private Sub btn_limpar_Click(sender As Object, e As EventArgs) Handles btn_limpar.Click

        LimparCampos()

    End Sub

    Private Sub LimparCampos() 'logica para limpar os campos do formulario
        txt_cnpj.Clear()
        txt_cep.Clear()
        txt_cpf.Clear()
        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is TextBox Then
                ' Limpa TextBox
                DirectCast(ctrl, TextBox).Clear()
            ElseIf TypeOf ctrl Is ComboBox Then
                ' Limpa ComboBox
                DirectCast(ctrl, ComboBox).SelectedIndex = -1
            ElseIf TypeOf ctrl Is CheckBox Then
                ' Desmarca CheckBox
                DirectCast(ctrl, CheckBox).Checked = False
            ElseIf TypeOf ctrl Is DateTimePicker Then
                ' Reseta DateTimePicker
                DirectCast(ctrl, DateTimePicker).Value = DateTime.Now
            End If
        Next
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        'verifica se o usuário quer fechar o programa
        resp = MsgBox("Deseja realmente fechar o programa?", MsgBoxStyle.Question + vbYesNo, "AVISO")
        If resp = vbYes Then
            db.Close()
            Application.Exit()
        End If
    End Sub

    Private Sub frm_cad_fornecedores_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        db.Close()
        If (Not criarContato) Then
            If (Not botaoVoltar) Then 'verificação se o botão de voltar foi pressionado, para evitar repetição de comando
                If editarCadastro = True Then
                    frm_listagem.Show()
                    editarCadastro = False
                Else
                    frm_menu.Show()
                End If
            End If
        End If
        criarContato = False
    End Sub

    Private Sub btn_cadastro_Click(sender As Object, e As EventArgs) Handles btn_cadastro.Click
        Try
            'validação dos campos obrigatórios, os que possuem máscara tem uma validação diferente, verifica se está completo ou não
            If (txt_empresa.Text = "" OrElse txt_atvd.Text = "" OrElse txt_cnpj.MaskCompleted = False OrElse txt_cpf.MaskCompleted = False OrElse txt_cep.MaskCompleted = False) Then
                MsgBox("Preencha os campos obrigatórios!", MsgBoxStyle.Information + vbOKOnly, "AVISO")
            Else
                SQL = "select * from tb_fornecedores where cnpj='" & txt_cnpj.Text & "'" 'query string pra filtrar o registro para aquele cnpj
                cmd.CommandText = SQL
                reader = cmd.ExecuteReader()
                If Not reader.Read() Then 'verificação com o filtro de query string acima para o reader encontrar ou não o registro.
                    SQL = "insert into tb_fornecedores (empresa, atividade, cnpj, cpf, inscricao, site, cep, endereco, cidade, bairro, complemento, uf, referencia, status) values ('" & txt_empresa.Text & "'," &
                            "'" & txt_atvd.Text.ToUpper() & "', '" & txt_cnpj.Text.ToUpper() & "', '" & txt_cpf.Text & "', '" & txt_inscricao.Text & "', " &
                            "'" & txt_site.Text.ToUpper() & "', '" & txt_cep.Text & "', '" & txt_endereco.Text.ToUpper() & "', " &
                            "'" & txt_cidade.Text.ToUpper() & "', '" & txt_bairro.Text.ToUpper() & "', '" & txt_complemento.Text.ToUpper() & "', " &
                            "'" & txt_uf.Text.ToUpper() & "', '" & txt_referencia.Text.ToUpper() & "', 'ATIVO')"
                    reader.Close()
                    cmd.CommandText = SQL
                    cmd.ExecuteNonQuery()
                    MsgBox("Fornecedor cadastrado com sucesso!", MsgBoxStyle.Information + vbOKOnly, "AVISO")
                    resp = MsgBox("Deseja cadastrar um contato para este fornecedor??", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "AVISO")
                    If resp = vbYes Then 'abre o formulario de contatos
                        criarContato = True
                        SQL = "select * from tb_fornecedores where cnpj='" & txt_cnpj.Text & "'"
                        cmd.CommandText = SQL
                        reader = cmd.ExecuteReader()
                        If reader.Read() Then
                            With frm_contatos_fornecedores
                                .txt_codfornecedor.Text = reader.GetInt32(0)
                                .txt_empresa.Text = reader.GetString(1)
                            End With
                            reader.Close()
                            Me.Close()
                            frm_contatos_fornecedores.ShowDialog()
                        End If
                    End If
                    reader.Close()
                    limpar_campos()
                Else 'o reader encontrou o registro e agora pergunta se o usuário quer atualizar o cadastro
                    resp = MsgBox("Fornecedor já cadastrado, deseja atualizar os dados de cadastro?", MsgBoxStyle.Question + vbYesNo, "AVISO")
                    If resp = vbYes Then
                        SQL = "update tb_fornecedores set empresa='" & txt_empresa.Text.ToUpper() & "', atividade='" & txt_atvd.Text.ToUpper() & "'," &
                            "inscricao='" & txt_inscricao.Text & "', site='" & txt_site.Text.ToUpper() & "', cep='" & txt_cep.Text & "', " &
                            "endereco='" & txt_endereco.Text.ToUpper() & "', cidade='" & txt_cidade.Text.ToUpper() & "', bairro='" & txt_bairro.Text.ToUpper() & "', " &
                            "complemento='" & txt_complemento.Text.ToUpper() & "', uf='" & txt_uf.Text.ToUpper() & "', referencia='" & txt_referencia.Text.ToUpper() & "' " &
                            "where cnpj='" & txt_cnpj.Text & "'"
                        reader.Close()
                        cmd.CommandText = SQL
                        cmd.ExecuteNonQuery()
                        MsgBox("Dados atualizados com sucesso!", MsgBoxStyle.Information + vbOKOnly, "AVISO")
                        limpar_campos()
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox("Erro ao cadastrar fornecedor", MsgBoxStyle.Critical + vbOKOnly, "AVISO")
        End Try
    End Sub

End Class