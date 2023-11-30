Imports System.ComponentModel

Public Class frm_cad_pedidos

    Private ano_atual As Integer = My.Settings.AnoAtual 'configuração criada para armazenar o ano de criação do projeto
    Private cod_pedido As String
    Private entregou As Boolean
    Private botaoVoltar As Boolean = False
    Private Sub frm_cad_pedidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        entregou = False 'reseta a checkbox para evitar problemas
        btnBusca = False 'validação para o botão de busca
        Try
            If (db.State <> ConnectionState.Open) Then
                conectar_banco()
            End If

            If editarPedido = True Then
                cb_entregue.Visible = True
                txt_data_entrega.Visible = True
                lbl_entrega.Visible = True
            Else
                cb_entregue.Visible = False
                txt_data_entrega.Visible = False
                lbl_entrega.Visible = False
            End If

            SQL = "select codpedido from tb_pedidos order by data desc limit 1" 'mostra apenas o ultimo registro
            cmd.CommandText = SQL
            reader = cmd.ExecuteReader()

            If DateTime.Now.Year <> ano_atual Then
                ano_atual = DateTime.Now.Year 'atualiza a variável para o ano atual
                My.Settings.AnoAtual = ano_atual 'altera a data da configuração ano atual, para manter a lógica do código
                My.Settings.Save()
                cod_pedido = $"001/{ano_atual.ToString().Substring(2)}" 'se o ano mudar, a contagem reseta, no formato "001/24" por exemplo
            Else
                If Not reader.Read() OrElse reader.IsDBNull(0) Then
                    cod_pedido = $"001/{ano_atual.ToString().Substring(2)}"
                Else
                    Dim ultimo_pedido As Integer = (reader.GetString(0)).Substring(0, 3)
                    cod_pedido = $"{(ultimo_pedido + 1).ToString("D3")}/{ano_atual.ToString().Substring(2)}" 'converte os tres primeiros caracteres em numero, adiciona mais um, e reconverte para string de novo
                End If

            End If
            reader.Close()
        Catch ex As Exception
            MsgBox("Erro ao carregar banco de dados!", MsgBoxStyle.Critical + vbOKOnly, "ERRO")
        End Try

    End Sub

    Private Sub txt_num_cliente_LostFocus(sender As Object, e As EventArgs) Handles txt_num_cliente.LostFocus
        Dim num_cliente As Integer
        If (db.State <> ConnectionState.Open) Then
            db.Open()
        End If
        If Integer.TryParse(txt_num_cliente.Text, num_cliente) Then
            SQL = "select * from tb_clientes where codcliente=" & num_cliente & ""
            cmd.CommandText = SQL
            reader = cmd.ExecuteReader()
            If Not reader.Read() Then
                resp = MsgBox("Cliente não encontrado, deseja verificar a listagem de clientes?", MsgBoxStyle.Question + vbYesNo, "AVISO")
                If resp = vbYes Then
                    'precisa fechar o form aqui
                    reader.Close()
                    db.Close()
                    mostrar_clientes()
                    btnBusca = True
                    Me.Hide()
                    frm_listagem.ShowDialog()
                End If
            Else
                txt_cliente.Text = (reader.GetString(1)).ToString()
            End If
        Else
            MsgBox("O valor inserido não é valido!", MsgBoxStyle.Critical + vbOKOnly, "AVISO")
        End If
        reader.Close()
    End Sub

    Private Sub btn_listagem_Click(sender As Object, e As EventArgs) Handles btn_listagem.Click
        btnBusca = True
        limpar_cmb_filtro()
        mostrarCliente = True
        mostrarFornecedor = False
        mostrarPedido = False
        With frm_listagem
            .tab_clientes.Parent = .tab_listagem
            .tab_fornecedor.Parent = Nothing
            .tab_pedidos.Parent = Nothing
        End With
        Me.Hide()
        frm_listagem.ShowDialog()
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        botaoVoltar = True
        db.Close()
        If (editarPedido) Then
            frm_listagem.Show()
        Else
            frm_menu.Show()
        End If
        Me.Close()
    End Sub

    Private Sub LimparCampos()
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
            End If
        Next
        txt_data_entrega.Clear()
        txt_previsao.Value = DateTime.Now.ToShortDateString
    End Sub

    Private Sub btn_limpar_Click(sender As Object, e As EventArgs) Handles btn_limpar.Click

        LimparCampos()

    End Sub

    Private Sub btn_encerrar_Click(sender As Object, e As EventArgs) Handles btn_encerrar.Click
        ' Exibe uma mensagem de confirmação ao fechar o formulário
        Dim resposta As DialogResult = MessageBox.Show("Deseja realmente sair?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        ' Se o usuário clicar em "Sim", o aplicativo será encerrado
        If resposta = DialogResult.Yes Then
            db.Close()
            Application.Exit()
        Else
        End If
    End Sub
    Private Sub frm_cad_pedidos_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        db.Close()
        If (Not botaoVoltar) Then
            If (Not btnBusca) Then
                If (editarPedido) Then
                    frm_listagem.Show()
                Else
                    frm_menu.Show()
                End If
            End If
        End If
        botaoVoltar = False 'reseta a condição do botão de voltar
    End Sub

    Private Sub btn_confirmar_Click(sender As Object, e As EventArgs) Handles btn_confirmar.Click
        Dim data_atual = DateTime.Now
        Dim statusEntregue As String
        Dim dataEntrega As String
        Try
            If entregou Then
                statusEntregue = "SIM"
            Else
                statusEntregue = "NAO"
            End If
            If txt_data_entrega.MaskCompleted = False Then
                dataEntrega = ""
            Else
                dataEntrega = txt_data_entrega.Text
            End If
            If (txt_pedido.Text = "" OrElse txt_descricao.Text = "" OrElse txt_num_cliente.Text = "" OrElse txt_cliente.Text = "" OrElse txt_valor.Text = "") Then
                MsgBox("Preencha todos os campos obrigatórios!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
            Else
                SQL = "select * from tb_pedidos where codpedido = '" & valor_cod_pedido & "'"
                cmd.CommandText = SQL
                reader = cmd.ExecuteReader()
                If Not reader.Read() Then
                    SQL = "insert into tb_pedidos values('" & cod_pedido & "', '" & txt_pedido.Text.ToUpper() & "', " &
                                    "'" & txt_num_cliente.Text & "', '" & txt_descricao.Text & "', '" & txt_link_orcamento.Text & "', " &
                                    "'" & data_atual & "', '" & txt_previsao.Text & "', '" & dataEntrega & "', '" & cmb_status.Text & "','" & txt_valor.Text & "', '" & txt_link_os.Text & "', '" & statusEntregue & "')"
                    reader.Close()
                    cmd.CommandText = SQL
                    cmd.ExecuteNonQuery()
                    MsgBox("Pedido criado com sucesso!", MsgBoxStyle.Information + vbOKOnly, "AVISO")
                    LimparCampos()
                Else
                    SQL = "update tb_pedidos set pedido='" & txt_pedido.Text.ToUpper() & "', descricao='" & txt_descricao.Text.ToUpper() & "', " &
                            "link_orcamento='" & txt_link_orcamento.Text & "', data_entrega='" & txt_data_entrega.Text & "', prev_entrega='" & txt_previsao.Text & "', " &
                            "status='" & cmb_status.Text & "', valor='" & txt_valor.Text & "', link_os='" & txt_link_os.Text & "', entregue='" & statusEntregue & "' where codpedido='" & valor_cod_pedido & "'"
                    reader.Close()
                    cmd.CommandText = SQL
                    cmd.ExecuteNonQuery()
                    MsgBox("Pedido atualizado com sucesso!", MsgBoxStyle.Information + vbOKOnly, "AVISO")
                    LimparCampos()
                End If
            End If

        Catch ex As Exception
            MsgBox("Erro ao criar/editar pedido", MsgBoxStyle.Critical + vbOKOnly, "ERRO")
        End Try
    End Sub

    Private Sub txt_valor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_valor.KeyPress
        Dim tamanhoTexto As Integer = txt_valor.Text.Length
        If e.KeyChar = "," Then
            txt_valor.Text = txt_valor.Text.Insert(txt_valor.SelectionStart, ".")
            e.Handled = True
            txt_valor.SelectionStart = txt_valor.SelectionStart + tamanhoTexto + 1
        End If
    End Sub

    Private Sub cb_entregue_CheckedChanged(sender As Object, e As EventArgs) Handles cb_entregue.CheckedChanged
        If cb_entregue.Checked = True Then
            entregou = True
        Else
            entregou = False
        End If
    End Sub
End Class