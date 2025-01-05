Module POSModule
    Public dbCON As New OleDb.OleDbConnection
    Public dbCMD As New OleDb.OleDbCommand
    Public dbADAP As New OleDb.OleDbDataAdapter
    Public dbDR As OleDb.OleDbDataReader
    Public dbDS As New DataSet

    Public totalAmount As Decimal = 0
    Public Sub database_connection()
        dbCON = New OleDb.OleDbConnection
        dbCON.ConnectionString = "provider=microsoft.jet.oledb.4.0;data source=" & Application.StartupPath & "\Database\dbasePOS.mdb"
        dbCON.Open()
    End Sub
    Public Sub Connection_State()
        If dbCON.State = ConnectionState.Closed Then
            dbCON.Open()
        End If
    End Sub
End Module
