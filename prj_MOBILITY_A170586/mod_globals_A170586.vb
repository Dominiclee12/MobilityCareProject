Module mod_globals_A170586

    Public myconnection As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DB_MOBILITYCARE_A170586.accdb;Persist Security Info=False;"
    Public myconnection2 As New OleDb.OleDbConnection(myconnection)
    Public current_date As String = Date.Now
    Public data_update As Boolean

    Public Function run_sql_query(mysql As String) As DataTable
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        Try
            myreader.Fill(mydatatable)
        Catch ex As Exception
            Beep()
            MsgBox("There is an error:" & vbCrLf & vbCrLf & ex.Message)
        End Try
        Return mydatatable
    End Function

    Public Sub run_sql_command(thissql As String)

        Dim mywriter As New OleDb.OleDbCommand(thissql, myconnection2)
        Dim mytransaction As OleDb.OleDbTransaction

        Try
            mywriter.Connection.Open()
            mywriter.ExecuteNonQuery()
            mywriter.Connection.Close()
            data_update = True

        Catch ex As Exception

            Beep()
            MsgBox("There is a mistake in the data you entered, as shown below" & vbCrLf & vbCrLf & ex.Message)

            mywriter.Connection.Close()
            data_update = False
        End Try

        Try
            myconnection2.Open()
            mytransaction = myconnection2.BeginTransaction
            mywriter.CommandText = “INSERT...”
            mywriter.ExecuteNonQuery()
            mywriter.CommandText = “UPDATE...”
            mywriter.ExecuteNonQuery()
            mywriter.CommandText = “DELETE...”
            mywriter.ExecuteNonQuery()
        Catch ex As Exception
        End Try
        mytransaction.Commit()
        myconnection2.Close()
    End Sub
End Module
