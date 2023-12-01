Imports System.ComponentModel
Imports System.Data.SqlClient
Public Class frm_listagem
    Dim dgvEscolhido As DataGridView
    Private Sub frm_listagem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (db.State <> ConnectionState.Open) Then
            conectar_banco()
        End If
        If mostrarCliente = True Then 'o formulário de listagem possui 3 tabs e parametros de pesquisa para cada tipo, então a lógica aqui é para setar qual tab e qual fitlro eu quero
            carregar_campos_cliente()
            carregar_dados_cliente()
        ElseIf mostrarFornecedor = True Then
            carregar_campos_cliente()
            carregar_dados_fornecedor()
        Else
            carregar_campos_pedido()
            carregar_dados_pedido()
        End If
    End Sub

    Private Sub txt_pesquisar_TextChanged(sender As Object, e As EventArgs) Handles txt_pesquisar.TextChanged 'realiza o filtro de acordo com o valor escolhido na combobox
        If mostrarCliente = True Then
            SQL = "select * from tb_clientes where " & cmb_tipo.Text.ToLower() & " like '" & txt_pesquisar.Text.ToUpper() & "%'"
        ElseIf mostrarFornecedor = True Then
            SQL = "select * from tb_fornecedores where " & cmb_tipo.Text.ToLower() & " like '" & txt_pesquisar.Text.ToUpper() & "%'"
        Else
            If cmb_tipo.Text = "STATUS" Then 'ambas tabelas possuem a coluna de status, então nesse caso eu preciso definir o where com p. para evitar erro de ambiguidade
                SQL = "select p.codpedido, p.pedido, c.empresa, p.descricao, p.data_entrega, p.status, p.valor, p.entregue from tb_pedidos p inner join tb_clientes c on c.codcliente = p.codcliente where p.status LIKE '" & txt_pesquisar.Text.ToUpper() & "%' order by p.data asc"
            Else
                SQL = "select p.codpedido, p.pedido, c.empresa, p.descricao, p.data_entrega, p.status, p.valor, p.entregue from tb_pedidos p inner join tb_clientes c on c.codcliente = p.codcliente where " & cmb_tipo.Text.ToLower() & " LIKE '" & txt_pesquisar.Text.ToUpper() & "%' order by p.data asc"
            End If
        End If
        cmd.CommandText = SQL
        cmd.ExecuteNonQuery()
        'escolhe o datagridview de acordo com a aba escolhida
        If mostrarCliente = True Then
            dgvEscolhido = dgv_clientes
        ElseIf mostrarFornecedor = True Then
            dgvEscolhido = dgv_fornecedores
        Else
            dgvEscolhido = dgv_pedidos
        End If

        With dgvEscolhido 'puxa as informações do banco de dados para o dgv de acordo com o que foi escolhido

            .Rows.Clear()
            reader = cmd.ExecuteReader()
            While reader.Read()
                If mostrarCliente = True Then
                    .Rows.Add(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetValue(4),
                              reader.GetString(3), reader.GetString(6))
                ElseIf mostrarFornecedor = True Then
                    .Rows.Add(reader.GetString(1), reader.GetString(2), reader.GetValue(5), reader.GetString(3),
                              reader.GetString(4), reader.GetString(8))
                Else
                    .Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3),
                          reader.GetString(4), reader.GetString(5), reader.GetDouble(6).ToString("C"), reader.GetString(7))
                End If
            End While
            reader.Close()
        End With
    End Sub

    Private Sub dgv_clientes_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_clientes.CellContentClick
        'logicas que ativam ao apertar no botão de editar, add contato ou excluir
        Try
            With dgv_clientes
                If (db.State <> ConnectionState.Open) Then
                    db.Open()
                End If
                If .CurrentRow.Cells(6).Selected Then
                    resp = MsgBox("Deseja realmente editar esse contato?", MsgBoxStyle.Question + vbYesNo, "AVISO")
                    If resp = vbYes Then
                        If (db.State <> ConnectionState.Open) Then
                            db.Open()
                        End If
                        SQL = "select * from tb_clientes where cnpj ='" & .CurrentRow.Cells(4).Value & "'"
                        cmd.CommandText = SQL
                        reader = cmd.ExecuteReader()
                        If reader.Read() Then
                            With frm_cad_clientes
                                .txt_empresa.Text = reader.GetString(1)
                                .txt_atvd.Text = reader.GetString(2)
                                .txt_cnpj.Text = reader.GetString(3)
                                .txt_inscricao.Text = reader.GetValue(4)
                                .txt_site.Text = reader.GetString(5)
                                .txt_cep.Text = reader.GetString(6)
                                .txt_endereco.Text = reader.GetString(7)
                                .txt_cidade.Text = reader.GetString(8)
                                .txt_bairro.Text = reader.GetString(9)
                                .txt_complemento.Text = reader.GetString(10)
                                .txt_uf.Text = reader.GetString(11)
                                .txt_referencia.Text = reader.GetString(12)
                            End With
                            reader.Close()
                            db.Close()
                            editarCadastro = True
                            Me.Hide()
                            frm_cad_clientes.ShowDialog()
                        Else
                            MsgBox("Não foi possível encontrar o usuário selecionado!", MsgBoxStyle.Critical + vbOKOnly, "ERRO")
                        End If
                    End If
                ElseIf .CurrentRow.Cells(7).Selected Then
                    resp = MsgBox("Deseja adicionar um contato para esse cliente?", MsgBoxStyle.Question + vbYesNo, "AVISO")
                    If resp = vbYes Then
                        With frm_contatos_clientes
                            .txt_codcliente.Text = dgv_clientes.CurrentRow.Cells(0).Value
                            .txt_empresa.Text = dgv_clientes.CurrentRow.Cells(1).Value
                        End With
                        reader.Close()
                        Me.Close()
                        frm_escolha_listagem.Hide()
                        frm_contatos_clientes.ShowDialog()
                    End If
                ElseIf .CurrentRow.Cells(8).Selected Then
                    resp = MsgBox("Deseja realmente excluir esse cliente?", MsgBoxStyle.Question + vbYesNo, "AVISO")
                    If resp = vbYes Then
                        Dim excluir As String
                        excluir = InputBox("Digite DELETAR para excluir o cliente (Em maíusculo),", MsgBoxStyle.Information)
                        If excluir = "DELETAR" Then
                            SQL = "update tb_clientes set status='INATIVO' where cnpj='" & dgv_clientes.CurrentRow.Cells(4).Value & "'"
                            cmd.CommandText = SQL
                            cmd.ExecuteNonQuery()
                            MsgBox("Cliente excluído com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                            carregar_dados_cliente()
                        End If
                    End If
                End If
            End With
            db.Close()
        Catch ex As Exception
            MsgBox("Não foi possível listar os clientes!", MsgBoxStyle.Critical + vbOKOnly, "ERRO")
        End Try
    End Sub

    Private Sub dgv_fornecedores_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_fornecedores.CellContentClick
        Try
            'mesma logica do dgv_clientes
            With dgv_fornecedores
                If (db.State <> ConnectionState.Open) Then
                    db.Open()
                End If
                If .CurrentRow.Cells(6).Selected Then
                    resp = MsgBox("Deseja editar esse contato?", MsgBoxStyle.Question + vbYesNo, "AVISO")
                    If resp = vbYes Then
                        SQL = "select * from tb_fornecedores where cnpj ='" & .CurrentRow.Cells(3).Value & "'"
                        cmd.CommandText = SQL
                        reader = cmd.ExecuteReader()
                        If reader.Read() Then
                            With frm_cad_fornecedores
                                .txt_empresa.Text = reader.GetString(1)
                                .txt_atvd.Text = reader.GetString(2)
                                .txt_cnpj.Text = reader.GetString(3)
                                .txt_cpf.Text = reader.GetString(4)
                                .txt_inscricao.Text = reader.GetValue(5)
                                .txt_site.Text = reader.GetString(6)
                                .txt_cep.Text = reader.GetString(7)
                                .txt_endereco.Text = reader.GetString(8)
                                .txt_cidade.Text = reader.GetString(9)
                                .txt_bairro.Text = reader.GetString(10)
                                .txt_complemento.Text = reader.GetString(11)
                                .txt_uf.Text = reader.GetString(12)
                                .txt_referencia.Text = reader.GetString(13)
                            End With
                            reader.Close()
                            db.Close()
                            editarCadastro = True
                            Me.Hide()
                            frm_cad_fornecedores.ShowDialog()
                        Else
                            MsgBox("Não foi possível encontrar o fornecedor selecionado!", MsgBoxStyle.Critical + vbOKOnly, "ERRO")
                        End If
                    End If
                ElseIf .CurrentRow.Cells(7).Selected Then
                    resp = MsgBox("Deseja adicionar um contato para esse fornecedor?", MsgBoxStyle.Question + vbYesNo, "AVISO")
                    If resp = vbYes Then
                        With frm_contatos_fornecedores
                            .txt_codfornecedor.Text = dgv_fornecedores.CurrentRow.Cells(0).Value
                            .txt_empresa.Text = dgv_fornecedores.CurrentRow.Cells(1).Value
                        End With
                        reader.Close()
                        Me.Close()
                        frm_escolha_listagem.Hide()
                        frm_contatos_fornecedores.ShowDialog()
                    End If
                ElseIf .CurrentRow.Cells(8).Selected Then
                    resp = MsgBox("Deseja realmente excluir esse fornecedor?", MsgBoxStyle.Question + vbYesNo, "AVISO")
                    If resp = vbYes Then
                        Dim excluir As String
                        excluir = InputBox("Digite DELETAR para excluir o contato (Em maíusculo),", MsgBoxStyle.Information)
                        If excluir = "DELETAR" Then
                            SQL = "update tb_fornecedores set status='INATIVO' where cnpj='" & dgv_fornecedores.CurrentRow.Cells(3).Value & "'"
                            cmd.CommandText = SQL
                            cmd.ExecuteNonQuery()
                            MsgBox("Fornecedor excluído com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                            carregar_dados_fornecedor()
                        End If
                    End If
                End If
            End With
        Catch ex As Exception
            MsgBox("Erro ao atualizar cadastro", MsgBoxStyle.Critical + vbOKOnly, "ERRO")
        End Try
    End Sub

    Private Sub dgv_pedidos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_pedidos.CellContentClick
        'mesma logica do dgv_clientes e de fornecedores
        Try
            If (db.State <> ConnectionState.Open) Then
                db.Open()
            End If
            With dgv_pedidos
                If .CurrentRow.Cells(8).Selected Then
                    resp = MsgBox("Deseja editar esse pedido?", MsgBoxStyle.Question + vbYesNo, "AVISO")
                    If resp = vbYes Then
                        editarPedido = True
                        '.currenctrow.cells(x).value
                        SQL = "select p.pedido, p.descricao, p.codcliente, c.empresa, p.link_orcamento, p.link_os, p.prev_entrega,
                        p.data_entrega, p.valor, p.codpedido from tb_pedidos p INNER JOIN tb_clientes c on c.codcliente = p.codcliente where p.codpedido='" & .CurrentRow.Cells(0).Value & "'"
                        cmd.CommandText = SQL
                        reader = cmd.ExecuteReader()
                        If reader.Read() Then
                            With frm_cad_pedidos 'define a escolha do cmb de acordo com o que está no banco de dados
                                If .cmb_status.Text = "PAGO" Then
                                    .cmb_status.SelectedIndex = 1
                                Else
                                    .cmb_status.SelectedIndex = 0
                                End If
                                'preenche todos os campos do form de cadastro de acordo com os valores da string sql
                                .txt_pedido.Text = reader.GetString(0)
                                .txt_descricao.Text = reader.GetString(1)
                                .txt_num_cliente.Text = reader.GetInt32(2)
                                .txt_cliente.Text = reader.GetString(3)
                                .txt_link_orcamento.Text = reader.GetString(4)
                                .txt_link_os.Text = reader.GetString(5)
                                .txt_previsao.Value = reader.GetString(6)
                                .txt_data_entrega.Text = reader.GetString(7)
                                .txt_valor.Text = reader.GetDouble(8)
                            End With
                            valor_cod_pedido = reader.GetString(9)
                        Else
                            MsgBox("Cliente não encontrado", MsgBoxStyle.Critical + vbOKOnly, "AVISO")
                        End If
                        reader.Close()
                        db.Close()
                        editarCadastro = True 'ativa os campos escondidos no formulário de cadastro de pedidos
                        Me.Hide()
                        frm_cad_pedidos.ShowDialog()
                    End If
                ElseIf .CurrentRow.Cells(9).Selected Then
                    resp = MsgBox("Deseja realmente excluir esse pedido?", MsgBoxStyle.Question + vbYesNo, "AVISO")
                End If

            End With
        Catch ex As Exception
            MsgBox("Não foi possível editar/excluir o pedido.", MsgBoxStyle.Critical + vbOKOnly, "ERRO")
        End Try
    End Sub



    Private Sub btn_voltar_Click(sender As Object, e As EventArgs) Handles btn_voltar.Click
        'volta para o formulário anterior, por ter mais de uma entrada, é necessário a logica abaixo
        If (btnBusca = True) Then
            btnBusca = False
            Me.Close()
            frm_escolha_listagem.Hide()
            frm_cad_pedidos.Show()
        Else
            db.Close()
            Me.Close()
            frm_escolha_listagem.Show()
        End If

    End Sub

    Private Sub btn_atualizar_Click(sender As Object, e As EventArgs) Handles btn_atualizar.Click
        'atualiza os dados do datagridview
        If mostrarCliente = True Then
            carregar_dados_cliente()
        ElseIf mostrarFornecedor = True Then
            carregar_dados_fornecedor()
        Else
            carregar_dados_pedido()
        End If
    End Sub

    Private Sub frm_listagem_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then 'se o usuário apertou no x, volta pro menu de listagem
            frm_escolha_listagem.Show()
        End If
    End Sub
End Class