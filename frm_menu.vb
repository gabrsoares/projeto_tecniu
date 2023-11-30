Public Class frm_menu


    Private Sub btn_cad_clientes_Click(sender As Object, e As EventArgs)
        Try
            frm_cad_clientes.ShowDialog()
        Catch ex As Exception
            MsgBox("Erro ao chamar formulário", MsgBoxStyle.Critical + vbOKOnly, "AVISO")
        End Try
    End Sub

    Private Sub btn_cad_clientes_MouseEnter(sender As Object, e As EventArgs) Handles btn_cad_clientes.MouseEnter
        ' Muda a cor de fundo quando o cursor entra no botão
        btn_cad_clientes.BackColor = Color.FromArgb(255, 204, 204)

        ' Muda a cor da borda 
        btn_cad_clientes.FlatAppearance.BorderColor = Color.Red
    End Sub

    Private Sub btn_cad_clientes_MouseLeave(sender As Object, e As EventArgs) Handles btn_cad_clientes.MouseLeave

        btn_cad_clientes.BackColor = Color.White
        btn_cad_clientes.FlatAppearance.BorderColor = Color.Red
    End Sub
    Private Sub btn_cad_fornecedores_MouseEnter(sender As Object, e As EventArgs) Handles btn_cad_fornecedores.MouseEnter

        btn_cad_fornecedores.BackColor = Color.FromArgb(255, 204, 204)
        btn_cad_fornecedores.FlatAppearance.BorderColor = Color.Red
    End Sub

    Private Sub btn_cad_fornecedores_MouseLeave(sender As Object, e As EventArgs) Handles btn_cad_fornecedores.MouseLeave
        btn_cad_fornecedores.BackColor = Color.White
        btn_cad_fornecedores.FlatAppearance.BorderColor = Color.Red
    End Sub
    Private Sub btn_cad_pedidos_MouseEnter(sender As Object, e As EventArgs) Handles btn_cad_pedidos.MouseEnter

        btn_cad_pedidos.BackColor = Color.FromArgb(255, 204, 204)
        btn_cad_pedidos.FlatAppearance.BorderColor = Color.Red
    End Sub

    Private Sub btn_cad_pedidos_MouseLeave(sender As Object, e As EventArgs) Handles btn_cad_pedidos.MouseLeave
        btn_cad_pedidos.BackColor = Color.White
        btn_cad_pedidos.FlatAppearance.BorderColor = Color.Red
    End Sub
    Private Sub btn_listagem_MouseEnter(sender As Object, e As EventArgs) Handles btn_listagem.MouseEnter

        btn_listagem.BackColor = Color.FromArgb(255, 204, 204)
        btn_listagem.FlatAppearance.BorderColor = Color.Red
    End Sub

    Private Sub btn_listagem_MouseLeave(sender As Object, e As EventArgs) Handles btn_listagem.MouseLeave
        btn_listagem.BackColor = Color.White
        btn_listagem.FlatAppearance.BorderColor = Color.Red
    End Sub




    Private Sub btn_cad_clientes_Click_1(sender As Object, e As EventArgs) Handles btn_cad_clientes.Click
        Try 'chama o formulário de cadastro de clientes
            Me.Hide()
            frm_cad_clientes.Show()
        Catch ex As Exception
            MsgBox("Erro ao chamar formulário", MsgBoxStyle.Critical + vbOKOnly, "AVISO")
        End Try
    End Sub

    Private Sub btn_cad_fornecedores_Click_1(sender As Object, e As EventArgs) Handles btn_cad_fornecedores.Click
        Try
            Me.Hide()
            Dim frm_cad_fornecedores As New frm_cad_fornecedores()
            frm_cad_fornecedores.Show()
        Catch ex As Exception
            MsgBox("Erro ao chamar formulário", MsgBoxStyle.Critical + vbOKOnly, "AVISO")
        End Try
    End Sub

    Private Sub btn_cad_pedidos_Click(sender As Object, e As EventArgs) Handles btn_cad_pedidos.Click
        Try
            limpar_campos()
            editarPedido = False
            Me.Hide()
            frm_cad_pedidos.ShowDialog()
        Catch ex As Exception
            MsgBox("Erro ao chamar formulário", MsgBoxStyle.Critical + vbOKOnly, "AVISO")
        End Try
    End Sub

    Private Sub btn_listagem_Click(sender As Object, e As EventArgs) Handles btn_listagem.Click
        Me.Hide()
        frm_escolha_listagem.ShowDialog()
    End Sub

    Private Sub frm_menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.CenterScreen
    End Sub

    Private Sub frm_menu_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            'Confirma se o usuário realmente deseja fechar o aplicativo
            resp = MsgBox("Deseja realmente sair?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "AVISO")
            If resp = vbYes Then
                db.Close()
                Application.Exit()
            Else
                ' Cancela o fechamento do formulário
                e.Cancel = True
            End If
        End If
    End Sub
End Class
