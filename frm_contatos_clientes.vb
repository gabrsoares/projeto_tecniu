Public Class frm_contatos_clientes
    Private Sub frm_contatos_clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.CenterScreen
        If (db.State <> ConnectionState.Open) Then
            conectar_banco()
        End If
    End Sub

    Private Sub btn_confirma_Click(sender As Object, e As EventArgs) Handles btn_confirma.Click
        Dim telefone As String = If(txt_telefone.MaskCompleted = False, "", txt_telefone.Text) 'validação para caso esteja vazio, não enviar a máscara ()_____... vazia
        Dim celular As String = If(txt_celular.MaskCompleted = False, "", txt_celular.Text) 'validação para caso esteja vazio, não enviar a máscara ()_____... vazia

        Try

            If (txt_codcliente.Text = "" OrElse txt_empresa.Text = "" OrElse txt_nome.Text = "" OrElse txt_cargo.Text = "") Then
                MsgBox("Preencha todos os campos obrigatórios!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
            Else
                If celular = "" And telefone = "" And txt_email.Text = "" Then 'validação para inserir pelo menos uma forma de contato
                    MsgBox("Preencha pelo menos uma forma de contato!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                Else
                    reader.Close()
                    'validação para checar se ja existem os 3 tipos de contato para a empresa com os mesmos valores
                    SQL = "select * from tb_contatos_clientes where (telefone='" & telefone & "' and email='" & txt_email.Text & "' and celular='" & celular & "') and empresa='" & txt_empresa.Text & "'"
                    cmd.CommandText = SQL
                    reader = cmd.ExecuteReader()
                    If reader.Read() Then
                        MsgBox("Dados de contato já cadastrados para esta empresa!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                    Else
                        reader.Close()
                        SQL = "insert into tb_contatos_clientes (nome, apelido, cargo, empresa, telefone, email, celular, codcliente) values('" & txt_nome.Text.ToUpper() & "', " &
                                        "'" & txt_apelido.Text.ToUpper() & "', '" & txt_cargo.Text.ToUpper() & "', '" & txt_empresa.Text.ToUpper() & "', '" & telefone & "', '" & txt_email.Text.ToUpper() & "', " &
                                        "'" & celular & "', '" & txt_codcliente.Text & "')"
                        cmd.CommandText = SQL
                        cmd.ExecuteNonQuery()
                        MsgBox("Contato cadastrado com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                        resp = MsgBox("Deseja cadastrar um novo contato?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "AVISO")
                        If resp = vbYes Then
                            txt_nome.Clear()
                            txt_apelido.Clear()
                            txt_telefone.Clear()
                            txt_celular.Clear()
                            txt_cargo.Clear()
                            txt_email.Clear()
                        Else
                            limpar_campos_contatos()
                            frm_menu.Show()
                            Me.Close()
                        End If
                    End If
                End If
            End If

        Catch ex As Exception
            MsgBox("Não foi possível cadastrar o contato!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERRO")
        End Try

    End Sub

    Private Sub txt_codcliente_LostFocus(sender As Object, e As EventArgs) Handles txt_codcliente.LostFocus
        SQL = "select * from tb_clientes where codcliente='" & txt_codcliente.Text & "'"
        cmd.CommandText = SQL
        reader = cmd.ExecuteReader()
        If reader.Read() Then
            txt_empresa.Text = reader.GetString(1)
        Else
            resp = MsgBox("Código de cliente não encontrado, deseja consultar os clientes?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "AVISO")
            If resp = vbYes Then
                reader.Close()
                db.Close()
                mostrar_clientes()
                Me.Close()
            End If
        End If
        reader.Close()
    End Sub

    Private Sub LimparCampos()
        txt_celular.Clear()
        txt_telefone.Clear()

        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is TextBox Then
                ' Limpa TextBox
                DirectCast(ctrl, TextBox).Clear()
            End If
        Next
    End Sub

    Private Sub btn_limpar_Click(sender As Object, e As EventArgs) Handles btn_limpar.Click
        LimparCampos()
    End Sub

    Private Sub btn_voltar_clientes_Click(sender As Object, e As EventArgs) Handles btn_voltar_clientes.Click
        db.Close()
        Me.Close()

        ' Abre o próximo formulário
        frm_menu.Show()
    End Sub

    Private Sub frm_contatos_clientes_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            frm_menu.Show()
        End If
    End Sub
End Class

