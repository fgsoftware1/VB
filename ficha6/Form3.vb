Public Class Form3
    Private Sub btn_adicionar_Click(sender As Object, e As EventArgs) Handles btn_adicionar.Click
        Dim valor As String

        valor = InputBox("introduza o valor: ", "inserir valores")

        ListBox1.Items.Add(valor)

        txt_quantidade.Text = ListBox1.Items.Count

    End Sub

    Private Sub ListBox1_Click(sender As Object, e As EventArgs) Handles ListBox1.Click
        If ListBox1.Items.Count = 0 Then
            MsgBox("sem dados para selecionar", vbOKOnly + vbCritical, "sem dados")
            Exit Sub
        End If

        Dim index As Integer

        index = ListBox1.SelectedIndex

        txt_indice.Text = index
        txt_posicao.Text = index + 1
        txt_item.Text = ListBox1.Items.Item(index)
    End Sub
End Class