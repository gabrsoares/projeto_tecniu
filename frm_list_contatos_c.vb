Public Class frm_list_contatos_c
    Private Sub frm_list_contatos_c_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'ao dar load, verifica se o banco de dados está aberto, e puxa todos os registros que estão com o status "ATIVO"
        If (db.State <> ConnectionState.Open) Then
            conectar_banco()
        End If
        editarContato = False
        cmb_tipo.Items.Clear() 'limpa o combobox e insere os itens
        With cmb_tipo.Items
            .Add("NOME")
            .Add("EMPRESA")
        End With
        cmb_tipo.SelectedIndex = 0
        SQL = "select con.codcontato, con.nome, con.apelido, con.cargo, cli.empresa, con.telefone, con.email, con.celular from tb_contatos_clientes con inner join tb_clientes cli on cli.codcliente = con.codcliente where cli.status ='ATIVO'"
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
    Private Sub btn_voltar_Click(sender As Object, e As EventArgs) Handles btn_voltar.Click 'volta para a escolha de listagem
        db.Close()
        frm_escolha_listagem.Show()
        Me.Close()
    End Sub

    Private Sub frm_list_contatos_c_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing 'volta para escolha de listagem ao apertar x
        db.Close()
        frm_escolha_listagem.Show()
    End Sub

    Private Sub btn_atualizar_Click(sender As Object, e As EventArgs) Handles btn_atualizar.Click
        'atualiza os registros
        If (db.State <> ConnectionState.Open) Then
            db.Open()
        End If
        SQL = "select con.codcontato, con.nome, con.apelido, con.cargo, cli.empresa, con.telefone, con.email, con.celular from tb_contatos_clientes con inner join tb_clientes cli on cli.codcliente = con.codcliente where cli.status ='ATIVO'"
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

    Private Sub txt_pesquisar_TextChanged(sender As Object, e As EventArgs) Handles txt_pesquisar.TextChanged
        'filtra os registros de acordo com o que foi preenchido no textbox e o que foi escolhido no combobox
        SQL = "select con.codcontato, con.nome, con.apelido, con.cargo, cli.empresa, con.telefone, con.email, con.celular from tb_contatos_clientes con inner join tb_clientes cli on cli.codcliente = con.codcliente where cli.status ='ATIVO' and con." & cmb_tipo.Text.ToLower() & " like '" & txt_pesquisar.Text.ToUpper() & "%'"
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
        'ativa ao clicar em excluir contato
        If dgv_contatos.CurrentRow.Cells(8).Selected Then
            resp = MsgBox("Deseja excluir o contato escolhido?", MsgBoxStyle.Information + vbYesNo, "AVISO")
            If resp = vbYes Then
                Dim excluir As String
                excluir = InputBox("Digite DELETAR para excluir o cliente (Em maíusculo),", MsgBoxStyle.Information)
                If excluir = "DELETAR" Then
                    SQL = "delete from tb_contatos_clientes where codcontato = '" & dgv_contatos.CurrentRow.Cells(0).Value & "'"
                    cmd.CommandText = SQL
                    cmd.ExecuteNonQuery()
                    MsgBox("Contato excluido com sucesso, por favor aperte no botão de atualizar.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                End If
            End If
        End If
    End Sub
End Class