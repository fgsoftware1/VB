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
        txt_nome = DataGridView1.Item("Nome", valor).Value
        txt_morada = DataGridView1.Item("Morada", valor).Value
        pic_imagem.ImageLocation = src & DataGridView1.Item("Imagem", valor).Value
    End Sub
End Class