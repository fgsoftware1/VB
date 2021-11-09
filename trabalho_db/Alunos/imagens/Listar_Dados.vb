Imports System.IO
Imports MySql.Data.MySqlClient

Public Class Listar_Dados
    Private Sub btn_carregar_Click(sender As Object, e As EventArgs) Handles btn_carregar.Click
        Dim result As MySqlDataAdapter
        Dim table As New DataTable()

        result = Module_BD.Executar_Sql_DataGridView("SELECT * FROM alunos")

        result.Fill(table)

        DataGridView1.DataSource = table
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim valor As Integer
        Dim src = AppDomain.CurrentDomain.BaseDirectory

        src = Directory.GetParent(src).Parent.Parent.FullName & "\imagens\"
        valor = DataGridView1.CurrentRow.Index

        txt_id.Text = DataGridView1.Item("ID_Aluno", valor).Value
        txt_nome.Text = DataGridView1.Item("Nome", valor).Value
        txt_morada.Text = DataGridView1.Item("Morada", valor).Value
        pic_imagem.ImageLocation = src & DataGridView1.Item("Imagem", valor).Value
    End Sub

    Private Sub btn_adicionar_Click(sender As Object, e As EventArgs) Handles btn_adicionar.Click
        Inserir_aluno.Show()
        'Me.Hide()
    End Sub

    Private Sub btn_alterar_Click(sender As Object, e As EventArgs) Handles btn_alterar.Click
        If txt_id.Text <> "" Then
            Module_BD.ID = txt_id.Text

        End If
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        Dim valor = MsgBox("Deseja eliminar o regista da BD?", vbExclamation + vbYesNo, "Eliminar dados?")

        If (valor = vbYes) Then
            Dim result = Module_BD.Executar_Sql_Command("DELETE FROM alunos WHERE ID_Aluno =" & Val(txt_id.Text))

            If IsNothing(result) Then
                MsgBox("Nao foi possivel emliminar o ID!", vbCritical + vbOK, "Erro ao eliminar")
                Exit Sub
            ElseIf result.RecordsAffected = 1 Then
                MsgBox("Dados eliminados com sucesso!", vbInformation + vbOK, "Sucesso ao eliminar")
                Me.Controls.Clear()
                InitializeComponent()
            End If
        End If
    End Sub
End Class