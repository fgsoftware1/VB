Imports MySql.Data.MySqlClient

Public Class txt_data
    Private Sub Listar_Sumarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim result As MySqlDataAdapter
        Dim table As New DataTable()

        result = Module_BD.Executar_Sql_DataGridView("SELECT * FROM sumarios")

        result.Fill(table)

        DataGridView1.DataSource = table
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim valor As Integer

        valor = DataGridView1.CurrentRow.Index

        txt_id.Text = DataGridView1.Item("ID_Sumario", valor).Value
        txt_descricao.Text = DataGridView1.Item("Descricao", valor).Value
        txt_disciplina.Text = DataGridView1.Item("Disciplina", valor).Value
    End Sub

    Private Sub btn_inserir_Click(sender As Object, e As EventArgs) Handles btn_inserir.Click
        Inserir_Sumario.Show()
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        Dim valor = MsgBox("Deseja eliminar o regista da BD?", vbExclamation + vbYesNo, "Eliminar dados?")

        If (valor = vbYes) Then
            Dim result = Module_BD.Executar_Sql_Command("DELETE FROM sumarios WHERE ID_Sumario =" & Val(txt_id.Text))

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

    Private Sub btn_alterar_Click(sender As Object, e As EventArgs) Handles btn_alterar.Click
        If txt_id.Text <> "" Then
            Module_BD.ID = txt_id.Text
            Alterar_Sumario.Show()
        End If
    End Sub

    Private Sub btn_atualizar_Click(sender As Object, e As EventArgs) Handles btn_atualizar.Click
        Dim result As MySqlDataAdapter
        Dim table As New DataTable()

        result = Module_BD.Executar_Sql_DataGridView("SELECT * FROM sumarios")

        result.Fill(table)

        DataGridView1.DataSource = table
    End Sub
End Class