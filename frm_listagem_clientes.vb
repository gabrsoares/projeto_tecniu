Public Class frm_listagem_clientes
    Private Sub frm_listagem_clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar_banco()
        carregar_campos_cliente()
        carregar_dados_cliente()
    End Sub

    Private Sub txt_pesquisar_TextChanged(sender As Object, e As EventArgs) Handles txt_pesquisar.TextChanged
        SQL = "select * from tb_clientes where " & cmb_tipo.Text.ToLower() & " like '" & txt_pesquisar.Text.ToUpper() & "%'"
        rs = db.Execute(SQL)

        With dgv_listagem
            .Rows.Clear()

            Do While rs.EOF = False
                .Rows.Add(rs.Fields(12).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value, rs.Fields(0).Value, rs.Fields(5).Value)
                rs.MoveNext()
            Loop
        End With
    End Sub

    Private Sub dgv_listagem_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_listagem.CellContentClick
        Try
            With dgv_listagem
                If .CurrentRow.Cells(6).Selected Then
                    resp = MsgBox("Deseja realmente editar esse contato?", MsgBoxStyle.Question + vbYesNo, "AVISO")
                    If resp = vbYes Then
                        SQL = "select * from tb_clientes where cnpj ='" & .CurrentRow.Cells(4).Value.ToString() & "'"
                        rs = db.Execute(SQL)
                        If rs.EOF = False Then
                            With frm_cad_clientes
                                .txt_empresa.Text = rs.Fields(1).Value
                                .txt_atvd.Text = rs.Fields(2).Value
                                .txt_cnpj.Text = rs.Fields(0).Value
                                .txt_inscricao.Text = rs.Fields(3).Value
                                .txt_site.Text = rs.Fields(4).Value
                                .txt_cep.Text = rs.Fields(5).Value
                                .txt_endereco.Text = rs.Fields(6).Value
                                .txt_cidade.Text = rs.Fields(7).Value
                                .txt_bairro.Text = rs.Fields(8).Value
                                .txt_complemento.Text = rs.Fields(9).Value
                                .txt_uf.Text = rs.Fields(10).Value
                                .txt_referencia.Text = rs.Fields(11).Value
                            End With
                            frm_cad_clientes.ShowDialog()
                        Else
                            MsgBox("Não foi possível encontrar o usuário selecionado!", MsgBoxStyle.Critical + vbOKOnly, "ERRO")
                        End If
                    End If
                ElseIf .CurrentRow.Cells(7).Selected Then
                    resp = MsgBox("Deseja realmente excluir esse contato?", MsgBoxStyle.Question + vbYesNo, "AVISO")
                End If
            End With
        Catch ex As Exception
            MsgBox("Não foi possível listar os clientes!", MsgBoxStyle.Critical + vbOKOnly, "ERRO")
        End Try
    End Sub
End Class