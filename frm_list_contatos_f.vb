Public Class frm_list_contatos_f
    Private Sub frm_list_contatos_f_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (db.State <> ConnectionState.Open) Then
            conectar_banco()
        End If
        cmb_tipo.Items.Clear() 'limpa o combobox e depois preenche
        With cmb_tipo.Items
            .Add("NOME")
            .Add("EMPRESA")
        End With
        cmb_tipo.SelectedIndex = 0
        SQL = "select con.codcontato, con.nome, con.apelido, con.cargo, for.empresa, con.telefone, con.email, con.celular from tb_contatos_fornecedores con inner join tb_fornecedores for on for.codfornecedor = con.codfornecedor where for.status ='ATIVO'"
        cmd.CommandText = SQL
        With dgv_contatos
            .Rows.Clear()
            reader = cmd.ExecuteReader()
            While reader.Read()
                .Rows.Add(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3),
                          reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7))
            End While
        End With
        reader.Close()
    End Sub
    Private Sub btn_voltar_Click(sender As Object, e As EventArgs) Handles btn_voltar.Click
        'volta para o formulário de listagem
        frm_escolha_listagem.Show()
        Me.Close()
    End Sub

    Private Sub frm_list_contatos_f_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        frm_escolha_listagem.Show() 'logica para caso feche pelo X
    End Sub

    Private Sub btn_atualizar_Click(sender As Object, e As EventArgs) Handles btn_atualizar.Click
        If (db.State <> ConnectionState.Open) Then
            db.Open()
        End If
        SQL = "select con.codcontato, con.nome, con.apelido, con.cargo, for.empresa, con.telefone, con.email, con.celular from tb_contatos_fornecedores con inner join tb_fornecedores for on for.codfornecedor = con.codfornecedor where for.status ='ATIVO'"
        cmd.CommandText = SQL
        With dgv_contatos
            .Rows.Clear()
            reader = cmd.ExecuteReader()
            While reader.Read() 'preenche o dgv com os dados obtidos pela busca no banco de dados
                .Rows.Add(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3),
                          reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7))
            End While
        End With
        reader.Close()
    End Sub

    Private Sub txt_pesquisar_TextChanged(sender As Object, e As EventArgs) Handles txt_pesquisar.TextChanged
        'logica para filtrar os registros do datagridview de acordo com o que for escrito e o que foi selecionado no combobox
        SQL = "select con.codcontato, con.nome, con.apelido, con.cargo, for.empresa, con.telefone, con.email, con.celular from tb_contatos_fornecedores con inner join tb_fornecedores for on for.codfornecedor = con.codfornecedor where for.status ='ATIVO' and con." & cmb_tipo.Text.ToLower() & " like '" & txt_pesquisar.Text.ToUpper() & "%'"
        cmd.CommandText = SQL
        cmd.ExecuteNonQuery()
        reader = cmd.ExecuteReader
        With dgv_contatos
            .Rows.Clear()
            While reader.Read()
                .Rows.Add(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7))
            End While
            reader.Close()
        End With
    End Sub

    Private Sub dgv_contatos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_contatos.CellContentClick
        'ao clicar na coluna de excluir, ativa a lógica abaixo
        If dgv_contatos.CurrentRow.Cells(8).Selected Then
            resp = MsgBox("Deseja excluir o contato escolhido?", MsgBoxStyle.Information + vbYesNo, "AVISO")
            If resp = vbYes Then
                Dim excluir As String
                excluir = InputBox("Digite DELETAR para excluir o cliente (Em maíusculo),", MsgBoxStyle.Information)
                If excluir = "DELETAR" Then
                    SQL = "delete from tb_contatos_fornecedores where codcontato = '" & dgv_contatos.CurrentRow.Cells(0).Value & "'"
                    cmd.CommandText = SQL
                    cmd.ExecuteNonQuery()
                    MsgBox("Contato excluido com sucesso, por favor aperte no botão de atualizar.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                End If
            End If
        End If
    End Sub
End Class