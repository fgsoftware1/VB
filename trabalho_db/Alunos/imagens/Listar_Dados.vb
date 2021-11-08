Imports MySql.Data.MySqlClient

Public Class Listar_Dados
    Private Sub btn_carregar_Click(sender As Object, e As EventArgs) Handles btn_carregar.Click
        Dim result As MySqlDataAdapter
        Dim table As New DataTable()

        result = Module_BD.Executar_Sql_DataGridView("SELECT * FROM alunos")

        result.Fill(table)

        DataGridView1.DataSource = table
    End Sub
End Class