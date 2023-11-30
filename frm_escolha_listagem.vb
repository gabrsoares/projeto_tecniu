Public Class frm_escolha_listagem
    Private Sub btn_clientes_Click(sender As Object, e As EventArgs) Handles btn_clientes.Click
        db.Close()
        limpar_cmb_filtro()
        mostrar_clientes()
        Me.Hide()
        frm_listagem.Show()
    End Sub

    Private Sub btn_fornecedores_Click(sender As Object, e As EventArgs) Handles btn_fornecedores.Click
        db.Close()
        limpar_cmb_filtro()
        Me.Hide()
        mostrar_fornecedores()
    End Sub

    Private Sub btn_pedidos_Click(sender As Object, e As EventArgs) Handles btn_pedidos.Click
        db.Close()
        limpar_cmb_filtro()
        Me.Hide()
        mostrar_pedidos()
    End Sub

    Private Sub frm_escolha_listagem_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then 'se o usuário apertou no x, volta pro menu
            frm_menu.Show()
        End If
    End Sub

    Private Sub btn_clientes_MouseEnter(sender As Object, e As EventArgs) Handles btn_clientes.MouseEnter
        ' Muda a cor de fundo quando o cursor entra no botão
        btn_clientes.BackColor = Color.FromArgb(255, 204, 204)

        ' Muda a cor da borda 
        btn_clientes.FlatAppearance.BorderColor = Color.Red
    End Sub

    Private Sub btn_cad_clientes_MouseLeave(sender As Object, e As EventArgs) Handles btn_clientes.MouseLeave

        btn_clientes.BackColor = Color.White
        btn_clientes.FlatAppearance.BorderColor = Color.Red
    End Sub
    Private Sub btn_fornecedores_MouseLeave(sender As Object, e As EventArgs) Handles btn_fornecedores.MouseLeave
        btn_fornecedores.BackColor = Color.White
        btn_fornecedores.FlatAppearance.BorderColor = Color.Red
    End Sub

    Private Sub btn_fornecedores_MouseEnter(sender As Object, e As EventArgs) Handles btn_fornecedores.MouseEnter

        btn_fornecedores.BackColor = Color.FromArgb(255, 204, 204)
        btn_fornecedores.FlatAppearance.BorderColor = Color.Red
    End Sub

    Private Sub btn_pedidos_MouseLeave(sender As Object, e As EventArgs) Handles btn_pedidos.MouseLeave
        btn_pedidos.BackColor = Color.White
        btn_pedidos.FlatAppearance.BorderColor = Color.Red
    End Sub
    Private Sub btn_pedidos_MouseEnter(sender As Object, e As EventArgs) Handles btn_pedidos.MouseEnter

        btn_pedidos.BackColor = Color.FromArgb(255, 204, 204)
        btn_pedidos.FlatAppearance.BorderColor = Color.Red
    End Sub

    Private Sub btn_contato_forn_MouseEnter(sender As Object, e As EventArgs) Handles btn_contato_forn.MouseEnter

        btn_contato_forn.BackColor = Color.FromArgb(255, 204, 204)
        btn_contato_forn.FlatAppearance.BorderColor = Color.Red
    End Sub

    Private Sub btn_contato_forn_MouseLeave(sender As Object, e As EventArgs) Handles btn_contato_forn.MouseLeave
        btn_contato_forn.BackColor = Color.White
        btn_contato_forn.FlatAppearance.BorderColor = Color.Red
    End Sub

    Private Sub btn_contatos_clientes_MouseEnter(sender As Object, e As EventArgs) Handles btn_contatos_clientes.MouseEnter

        btn_contatos_clientes.BackColor = Color.FromArgb(255, 204, 204)
        btn_contatos_clientes.FlatAppearance.BorderColor = Color.Red
    End Sub

    Private Sub btn_contatos_clientes_MouseLeave(sender As Object, e As EventArgs) Handles btn_contatos_clientes.MouseLeave
        btn_contatos_clientes.BackColor = Color.White
        btn_contatos_clientes.FlatAppearance.BorderColor = Color.Red
    End Sub
    Public Sub New()
        ' Este é o construtor do formulário
        InitializeComponent()

        ' Centraliza o formulário na tela
        Me.StartPosition = FormStartPosition.CenterScreen
    End Sub

    Private Sub btn_contatos_clientes_Click(sender As Object, e As EventArgs) Handles btn_contatos_clientes.Click
        Me.Hide()
        frm_list_contatos_c.ShowDialog()
    End Sub

    Private Sub btn_contato_forn_Click(sender As Object, e As EventArgs) Handles btn_contato_forn.Click
        Me.Hide()
        frm_list_contatos_f.ShowDialog()
    End Sub

    Private Sub btn_voltar_Click(sender As Object, e As EventArgs) Handles btn_voltar.Click
        Me.Hide()
        frm_menu.Show()
    End Sub

End Class

