Imports MySql.Data.MySqlClient

Public Class Listar_Sumarios
    Dim result As MySqlDataAdapter
    Dim table As New DataTable()

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        result = Module_BD.Executar_Sql_DataGridView("SELECT * FROM sumarios")

        result.Fill(table)

        DataGridView1.DataSource = table
    End Sub
End Class