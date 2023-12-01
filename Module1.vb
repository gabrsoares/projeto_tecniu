Imports System.Data
Imports System.Data.SQLite

Module Module1
    Public diretorio, SQL, resp As String 'variaveis para utilização do banco de dados
    Public valor_cod_pedido As String 'armazena o valor do código do pedido
    Public mostrarCliente, mostrarFornecedor, mostrarPedido As Boolean 'variaveis para escolher a aba da listagem
    Public editarPedido As Boolean = False 'logica para esconder campos e redirecionamento
    Public editarCadastro As Boolean = False 'logica para esconder campos e redirecionamento
    Public editarContato As Boolean = False 'logica para esconder campos e redirecionamento
    Public btnBusca As Boolean = False 'logica para redirecionamento
    Public db As New SQLiteConnection()
    Public cmd As New SQLiteCommand(SQL, db)
    Public caminho = Application.StartupPath & "\Banco\db_tecniu.db"
    Public reader As SQLiteDataReader
    Public count As Integer

    Sub conectar_banco()  'conexão de banco de dados SQLite
        Try
            db.ConnectionString = "Data source=" & caminho
            db.Open()
        Catch ex As Exception
            MsgBox("Erro de conexão", MsgBoxStyle.Critical + vbOKOnly, "ERRO")
        End Try
    End Sub
    Sub limpar_campos()   'limpa os campos do formulário de cadastro de clientes e fornecedores
        Try
            With frm_cad_clientes
                .txt_empresa.Clear()
                .txt_atvd.Clear()
                .txt_cnpj.Clear()
                .txt_inscricao.Clear()
                .txt_site.Clear()
                .txt_cep.Clear()
                .txt_endereco.Clear()
                .txt_cidade.Clear()
                .txt_bairro.Clear()
                .txt_complemento.Clear()
                .txt_uf.Clear()
                .txt_referencia.Clear()
            End With
            With frm_cad_fornecedores
                .txt_empresa.Clear()
                .txt_atvd.Clear()
                .txt_cnpj.Clear()
                .txt_inscricao.Clear()
                .txt_cpf.Clear()
                .txt_site.Clear()
                .txt_cep.Clear()
                .txt_endereco.Clear()
                .txt_cidade.Clear()
                .txt_bairro.Clear()
                .txt_complemento.Clear()
                .txt_uf.Clear()
                .txt_referencia.Clear()
            End With
            With frm_cad_pedidos
                .txt_pedido.Clear()
                .txt_descricao.Clear()
                .txt_num_cliente.Clear()
                .txt_cliente.Clear()
                .txt_link_orcamento.Clear()
                .txt_link_os.Clear()
                .txt_previsao.Value = DateTime.Now.ToShortDateString
                .cmb_status.SelectedIndex = 0
                .txt_data_entrega.clear()
                .txt_valor.Clear()
                .cb_entregue.Checked = False
            End With
        Catch ex As Exception
            MsgBox("Não foi possivel limpar os campos", MsgBoxStyle.Critical + vbOKOnly, "ERRO")
        End Try

    End Sub
    Sub carregar_campos_cliente() 'altera os valores do combobox para o filtro de clientes
        Try
            With frm_listagem.cmb_tipo.Items
                .Add("EMPRESA")
                .Add("ATIVIDADE")
            End With
            frm_listagem.cmb_tipo.SelectedIndex = 0
        Catch ex As Exception
            MsgBox("Não foi possivel carregar os campos", MsgBoxStyle.Critical + vbOKOnly, "ERRO")
        End Try

    End Sub
    Sub carregar_campos_pedido() 'altera os valores do combobox para o filtro de pedidos
        Try
            With frm_listagem.cmb_tipo.Items
                .Add("PEDIDO")
                .Add("EMPRESA")
                .Add("STATUS")
                .Add("ENTREGUE")
            End With
            frm_listagem.cmb_tipo.SelectedIndex = 0
        Catch ex As Exception
            MsgBox("Não foi possivel carregar os campos", MsgBoxStyle.Critical + vbOKOnly, "ERRO")
        End Try
    End Sub

    Sub carregar_dados_cliente() 'carrega os dados dos clientes ao escolher o form de listagem
        If (db.State <> ConnectionState.Open) Then
            db.Open()
        End If
        SQL = "select * from tb_clientes where status='ATIVO' order by codcliente asc"
        cmd.CommandText = SQL
        With frm_listagem.dgv_clientes
            .Rows.Clear()
            reader = cmd.ExecuteReader()
            While reader.Read()
                .Rows.Add(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetValue(4),
                          reader.GetString(3), reader.GetString(6))
            End While
        End With
        reader.Close()
    End Sub

    Sub carregar_dados_fornecedor() 'carrega os dados dos fornecedores ao escolher o form de listagem
        If (db.State <> ConnectionState.Open) Then
            db.Open()
        End If
        SQL = "select * from tb_fornecedores where status='ATIVO' order by empresa asc"
        cmd.CommandText = SQL
        With frm_listagem.dgv_fornecedores
            .Rows.Clear()
            reader = cmd.ExecuteReader()
            While reader.Read()
                .Rows.Add(reader.GetString(1), reader.GetString(2), reader.GetValue(5), reader.GetString(3), reader.GetString(7), reader.GetString(8))
            End While
        End With
        reader.Close()
    End Sub

    Sub carregar_dados_pedido() 'carrega os dados dos pedidos ao escolher o form de listagem
        SQL = "select p.codpedido, p.pedido, c.empresa, p.descricao, p.data_entrega, p.status, p.valor, p.entregue from tb_pedidos p inner join tb_clientes c on c.codcliente = p.codcliente order by data asc"
        cmd.CommandText = SQL
        With frm_listagem.dgv_pedidos
            .Rows.Clear()
            If (db.State <> ConnectionState.Open) Then
                conectar_banco()
            End If
            reader = cmd.ExecuteReader()
            While reader.Read()
                .Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3),
                     reader.GetString(4), reader.GetString(5), reader.GetDouble(6).ToString("C"), reader.GetString(7))
            End While
        End With
        reader.Close()
    End Sub

    Sub limpar_cmb_filtro() 'limpa o combobox de filtro para não adicionar os valores de outras entradas
        frm_listagem.cmb_tipo.Items.Clear()
    End Sub

    Sub limpar_campos_contatos() 'limpa os campos de contatos
        With frm_contatos_clientes
            .txt_nome.Clear()
            .txt_apelido.Clear()
            .txt_cargo.Clear()
            .txt_empresa.Clear()
            .txt_telefone.Clear()
            .txt_email.Clear()
            .txt_celular.Clear()
            .txt_codcliente.Clear()
        End With
        With frm_contatos_fornecedores
            .txt_nome.Clear()
            .txt_apelido.Clear()
            .txt_cargo.Clear()
            .txt_empresa.Clear()
            .txt_telefone.Clear()
            .txt_email.Clear()
            .txt_celular.Clear()
            .txt_codfornecedor.Clear()
        End With
    End Sub

    Sub mostrar_clientes() 'logica para mostrar a tab apenas de clientes
        mostrarCliente = True
        mostrarFornecedor = False
        mostrarPedido = False
        With frm_listagem
            .tab_clientes.Parent = .tab_listagem
            .tab_fornecedor.Parent = Nothing
            .tab_pedidos.Parent = Nothing
        End With
    End Sub

    Sub mostrar_fornecedores() 'logica para mostrar a tab apenas de fornecedores

        mostrarCliente = False
        mostrarFornecedor = True
        mostrarPedido = False
        With frm_listagem
            .tab_clientes.Parent = Nothing
            .tab_fornecedor.Parent = .tab_listagem
            .tab_pedidos.Parent = Nothing
        End With
        frm_listagem.Show()
    End Sub

    Sub mostrar_pedidos() 'logica para mostrar a tab apenas de pedidos
        mostrarCliente = False
        mostrarFornecedor = False
        mostrarPedido = True
        With frm_listagem
            .tab_clientes.Parent = Nothing
            .tab_fornecedor.Parent = Nothing
            .tab_pedidos.Parent = .tab_listagem
        End With
        frm_listagem.Show()
    End Sub

End Module
