Imports System.ComponentModel
Imports System.Data.SQLite

Public Class frm_cad_clientes
    Private botaoVoltar = False 'reseta a logica dos dois botões
    Private btnContato = False
    Private Sub frm_cad_clientes_Load(sender As Object, e As EventArgs) Handles Me.Load
        btnContato = False
        Try
            If (db.State <> ConnectionState.Open) Then 'se o banco de dados ja estiver aberto, evita erros ao abrir novamente
                conectar_banco()
            End If
        Catch ex As Exception
            MsgBox("Não foi possivel conectar ao banco de dados", MsgBoxStyle.Critical + vbOKOnly, "ERRO")
        End Try

    End Sub

    Private Sub txt_inscricao_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_inscricao.KeyPress
        'validação para preenchimento numérico do campo de inscrição, permite apenas a entrada de números.
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> Convert.ToChar(Keys.Back) Then
            e.Handled = True
        End If
    End Sub
    Private Sub txt_cep_DoubleClick(sender As Object, e As EventArgs) Handles txt_cep.DoubleClick 'limpa os campos de endereço ao clicar 2x no cep
        txt_cep.Clear()
        txt_endereco.Clear()
        txt_cidade.Clear()
        txt_bairro.Clear()
        txt_uf.Clear()
    End Sub

    Private Sub btn_cadastro_Click(sender As Object, e As EventArgs) Handles btn_cadastro.Click
        Try
            'validação dos campos obrigatórios, os que possuem máscara tem uma validação diferente, verifica se está completo ou não
            If (txt_empresa.Text = "" OrElse txt_atvd.Text = "" OrElse txt_cnpj.MaskCompleted = False OrElse txt_cep.MaskCompleted = False) Then
                MsgBox("Preencha os campos obrigatórios!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Atenção!!!")
            Else
                SQL = "select * from tb_clientes where cnpj='" & txt_cnpj.Text & "'" 'query string pra filtrar o registro para aquele cnpj
                cmd.CommandText = SQL
                reader = cmd.ExecuteReader()
                If Not reader.Read() Then 'verificação com o filtro de query string acima para o reader encontrar ou não o registro.
                    SQL = "insert into tb_clientes (empresa, atividade, cnpj, inscricao, site, cep, endereco, cidade, bairro, complemento, uf, referencia, status) values ('" & txt_empresa.Text.ToUpper() & "'," &
                        "'" & txt_atvd.Text.ToUpper() & "', '" & txt_cnpj.Text & "', '" & txt_inscricao.Text.ToUpper() & "', " &
                        "'" & txt_site.Text.ToUpper() & "', '" & txt_cep.Text & "', '" & txt_endereco.Text.ToUpper() & "', " &
                        "'" & txt_cidade.Text.ToUpper() & "', '" & txt_bairro.Text.ToUpper() & "', '" & txt_complemento.Text.ToUpper() & "', " &
                        "'" & txt_uf.Text.ToUpper() & "', '" & txt_referencia.Text.ToUpper() & "', 'ATIVO')"
                    reader.Close()
                    cmd.CommandText = SQL
                    cmd.ExecuteNonQuery()
                    MsgBox("Cliente cadastrado com sucesso!", MsgBoxStyle.Information + vbOKOnly, "AVISO")
                    resp = MsgBox("Deseja cadastrar um contato para este cliente?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "AVISO")
                    If resp = vbYes Then 'abre o formulario de contatos
                        btnContato = True
                        SQL = "select * from tb_clientes where cnpj='" & txt_cnpj.Text & "'"
                        cmd.CommandText = SQL
                        reader = cmd.ExecuteReader()
                        If reader.Read() Then
                            With frm_contatos_clientes
                                .txt_codcliente.Text = reader.GetInt32(0)
                                .txt_empresa.Text = reader.GetString(1)
                            End With
                            reader.Close()
                            Me.Close()
                            frm_contatos_clientes.ShowDialog()
                        End If
                    End If
                    limpar_campos()
                Else 'reader encontrou registro, entao pergunta se quer atualizar ou nao
                    resp = MsgBox("Cliente já cadastrado, deseja atualizar os dados de cadastro?", MsgBoxStyle.Question + vbYesNo, "AVISO")
                    If resp = vbYes Then
                        SQL = "update tb_clientes Set empresa='" & txt_empresa.Text.ToUpper() & "', atividade='" & txt_atvd.Text.ToUpper() & "'," &
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
                reader.Close()
            End If
        Catch ex As Exception
            MsgBox("Erro ao cadastrar cliente", MsgBoxStyle.Critical + vbOKOnly, "AVISO")
        End Try
    End Sub



    Private Sub btn_voltar_Click(sender As Object, e As EventArgs) Handles btn_voltar.Click 'volta para o menu
        botaoVoltar = True
        db.Close()
        If (editarCadastro) Then 'verifica se o formulário foi aberto pela listagem ou pelo menu
            frm_listagem.Show()
            editarCadastro = False
        Else
            frm_menu.Show()
        End If
        Me.Close()
    End Sub

    Private Sub LimparCampos() 'logica para limpar os campos do formulario
        txt_cep.Clear()
        txt_cnpj.Clear()
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

    Private Sub btn_limpar_Click(sender As Object, e As EventArgs) Handles btn_limpar.Click
        LimparCampos()
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click 'verifica se o usuário quer fechar o programa
        resp = MsgBox("Deseja realmente fechar o programa?", MsgBoxStyle.Question + vbYesNo, "AVISO")
        If resp = vbYes Then
            db.Close()
            Application.Exit()
        End If
    End Sub

    Private Sub frm_cad_clientes_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        db.Close()
        If (Not botaoVoltar) Then 'verifica se o o formulario fechou pelo x ou pelo botão de voltar
            If editarCadastro = True Then 'caso o usuario estivesse editando um cadastro, volta para a tela de listagem
                frm_listagem.Show()
                editarCadastro = False
            Else
                If (btnContato = True) Then
                    frm_menu.Hide()
                Else
                    frm_menu.Show()
                End If

            End If
        End If

    End Sub

End Class
