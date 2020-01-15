Imports MySql.Data.MySqlClient

Module koneksi

    Public conn As New MySqlConnection
    Public MySQLReader As MySqlDataReader
    Public CMD As New MySqlCommand
    Public DA As New MySqlDataAdapter
    Public RD As MySqlDataReader
    Public DS As DataSet
    Public str As String


    Public Sub KoneksiBuka()
        If conn.State = ConnectionState.Closed Then
            Dim mystring As String
            mystring = "server=localhost;user=root;password=;database=kayukayu"
            Try
                conn.ConnectionString = mystring
                conn.Open()
            Catch ex As Exception
                MsgBox("Koneksi Gagal!", MsgBoxStyle.Critical, "Error")
            End Try
        End If
    End Sub

    Public Sub KoneksiTutup()
        Try
            conn.Close()
        Catch ex As Exception

        End Try
    End Sub


End Module

