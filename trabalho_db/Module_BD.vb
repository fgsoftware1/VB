Imports MySql.Data.MySqlClient

Module Module_BD
    Public myConnectionString As New MySqlConnection("server=localhost; uid=root; " &
                                                     "pwd=; database=trabalho_bd; SslMode=none")

    Function Executar_Sql_DataGridView(comando As String) As MySqlDataAdapter
        If (myConnectionString.State = ConnectionState.Closed) Then
            myConnectionString.Open()
        End If

        Try
            Dim result As New MySqlDataAdapter(comando, myConnectionString)

            myConnectionString.Close()

            Executar_Sql_DataGridView = result
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        End Try
    End Function

    Function Executar_Sql_Command(comando As String) As MySqlDataReader
        myConnectionString.Open()

        Try
            Dim query As New MySqlCommand(comando, myConnectionString)
            Dim result As MySqlDataReader = query.ExecuteReader

            Executar_Sql_Command = result
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Function
End Module
