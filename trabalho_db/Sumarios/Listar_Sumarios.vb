Imports MySql.Data.MySqlClient

Public Class Listar_Sumarios
    Private Sub Listar_Sumarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim result As MySqlDataAdapter
        Dim table As New DataTable()

        result = Module_BD.Executar_Sql_DataGridView("SELECT * FROM sumarios")

        result.Fill(table)

        DataGridView1.DataSource = table
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim valor As Integer
        Dim src = AppDomain.CurrentDomain.BaseDirectory

        valor = DataGridView1.CurrentRow.Index

        txt_id.Text = DataGridView1.Item("ID_Aluno", valor).Value
        txt_nome.Text = DataGridView1.Item("Nome", valor).Value
        txt_morada.Text = DataGridView1.Item("Morada", valor).Value
    End Sub
End Class