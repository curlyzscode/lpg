Imports MySql.Data.MySqlClient
Imports Kayu_Kayu_App.koneksi

Public Class home

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        lblJam.Text = Format(Now, "HH:mm:ss")
    End Sub

    Private Sub home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblUsername.Text = login.txtUsername.Text

        HitungCountMenu()
        HitungCountKonter()
        HitungCountPegawai()
        HitungCountTransaksi()

    End Sub

    Sub HitungCountMenu()
        Try
            KoneksiBuka()
            Dim Count As String
            Count = "select count(*) from menu"
            cmd.CommandType = CommandType.Text
            cmd.CommandText = Count
            cmd.Connection = conn
            CountMenu.Text = cmd.ExecuteScalar.ToString
        Catch ex As Exception
            MsgBox("Terjadi kesalahan! " & ex.Message)
        End Try
    End Sub

    Sub HitungCountKonter()
        Try
            KoneksiBuka()

            Dim Count As String
            Count = "select count(*) from konter"
            cmd.CommandType = CommandType.Text
            cmd.CommandText = Count
            cmd.Connection = conn
            CountKonter.Text = cmd.ExecuteScalar.ToString
        Catch ex As Exception
            MsgBox("Terjadi kesalahan! " & ex.Message)
        End Try
    End Sub

    Sub HitungCountPegawai()
        Try
            KoneksiBuka()

            Dim Count As String
            Count = "select count(*) from user"
            cmd.CommandType = CommandType.Text
            cmd.CommandText = Count
            cmd.Connection = conn
            CountPegawai.Text = cmd.ExecuteScalar.ToString
        Catch ex As Exception
            MsgBox("Terjadi kesalahan! " & ex.Message)
        End Try
    End Sub

    Sub HitungCountTransaksi()
        Try
            KoneksiBuka()

            Dim Count As String
            Count = "select count(*) from transaksi"
            cmd.CommandType = CommandType.Text
            cmd.CommandText = Count
            cmd.Connection = conn
            CountTransaksi.Text = cmd.ExecuteScalar.ToString
        Catch ex As Exception
            MsgBox("Terjadi kesalahan! " & ex.Message)
        End Try
    End Sub


End Class