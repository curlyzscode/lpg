Imports MySql.Data.MySqlClient

Module koneksi

    Public conn As MySqlConnection
    Public cmd As MySqlCommand
    Public rd As MySqlDataReader
    Public da As MySqlDataAdapter
    Public ds As DataSet
    Public str As String
    Public re As DataTableReader
    Public cari As DataTable

    'Koneksi VB.net Dengan Database Mysql
    Sub KoneksiBuka()
        conn = New MySqlConnection

        conn.ConnectionString = "server=localhost;user=root;password=;database=kayukayu;Convert Zero Datetime=True"
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
        Catch ex As Exception
            MsgBox("Koneksi Gagal" & Err.Description)
        End Try
    End Sub

    Public Sub KoneksiTutup()
        Try
            conn.Close()
        Catch ex As Exception

        End Try
    End Sub

End Module
