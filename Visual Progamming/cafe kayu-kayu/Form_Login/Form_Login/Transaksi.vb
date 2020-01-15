Imports Form_Login.koneksi
Imports MySql.Data.MySqlClient

Public Class Transaksi

    Private Sub Transaksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        KoneksiBuka()
        tampildata()

        statusinput(False, False, False)
        statustombol(True, True, True)
    End Sub

    Private Sub tampildata()
        Dim dt As DataTable
        Dim adapter As MySqlDataAdapter
        Dim query As String
        Dim data As Integer

        query = "select * from transaksi"
        adapter = New MySqlDataAdapter(query, conn)
        dt = New DataTable
        data = adapter.Fill(dt)

        If data > 0 Then
            tabelmenu.DataSource = dt
            tabelmenu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            tabelmenu.Columns(0).HeaderText = "id_transaksi"
            tabelmenu.Columns(1).HeaderText = "id_pelanggan"
            tabelmenu.Columns(2).HeaderText = "id_menu"
            tabelmenu.Columns(3).HeaderText = "tanggal"
        Else
            tabelmenu.DataSource = Nothing
        End If
    End Sub

    Sub hapus_isi()
        tID.Clear()
        tPelanggan.Clear()
        tMenu.Clear()
    End Sub

    Private Sub statusinput(id As Boolean, pelanggan As Boolean, menu As Boolean)
        tID.Enabled = id
        tPelanggan.Enabled = pelanggan
        tMenu.Enabled = menu
    End Sub

    Private Sub statustombol(tambah As Boolean, hapus As Boolean, ubah As Boolean)
        bTambah.Enabled = tambah
        bHapus.Enabled = hapus
        bUbah.Enabled = ubah
    End Sub

    Private Sub tabelmenu_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles tabelmenu.CellContentClick
        Dim i As Integer
        i = Me.tabelmenu.CurrentRow.Index
        'MsgBox("baris ke : " & i.ToString, MsgBoxStyle.Information, "informasi")
        'tNim.Text = tabelpegawai.Rows.Item(i).Cells(0).Value
        With tabelmenu.Rows.Item(i)
            tID.Text = .Cells(0).Value
            tPelanggan.Text = .Cells(1).Value
            tMenu.Text = .Cells(2).Value
            DateTimePicker1.Value = .Cells(3).Value
        End With
        statustombol(True, True, True)
    End Sub

    Private Sub bTambah_Click(sender As Object, e As EventArgs) Handles bTambah.Click
        If bTambah.Text = "&Tambah" Then
            statusinput(True, True, True)
            statustombol(True, True, False)
            bTambah.Text = "Simpan"
            bHapus.Text = "Batal"
        ElseIf bTambah.Text = "Simpan" Then
            If tID.Text = "" Then
                MsgBox("ID Harus diisi", MsgBoxStyle.Information, "Information")
                tID.Focus()
                Exit Sub
            ElseIf tPelanggan.Text = "" Then
                MsgBox("ID Pelanggan Harus diisi", MsgBoxStyle.Information, "Information")
                tPelanggan.Focus()
                Exit Sub
            ElseIf tMenu.Text = "" Then
                MsgBox("ID Menu Harus diisi", MsgBoxStyle.Information, "Information")
                tMenu.Focus()
                Exit Sub
            End If

            'conn.Open()
            Try
                Dim qInsert As String
                qInsert = "insert into transaksi (id_transaksi, id_pelanggan, id_menu, tanggal)"
                qInsert = qInsert & "VALUES('" & tID.Text & "', '" & tPelanggan.Text & "', '" & tMenu.Text & "', '" & DateTimePicker1.Value.ToString("yyyy-MM-dd") & "' )"
                CMD.CommandType = CommandType.Text
                CMD.CommandText = qInsert
                CMD.Connection = conn
                CMD.ExecuteNonQuery()

                tampildata()
                hapus_isi()
            Catch ex As Exception
                MsgBox("Gagal Simpan" + ex.Message, MsgBoxStyle.Critical, "Terjadi Kesalahan")
            End Try
            'conn.Close()
        End If
    End Sub

    Private Sub bUbah_Click(sender As Object, e As EventArgs) Handles bUbah.Click
        If bUbah.Text = "&Ubah" Then
            bUbah.Text = "&Simpan"
            bHapus.Text = "Batal"
            statustombol(False, True, True)
            statusinput(False, True, True)
        ElseIf bUbah.Text = "&Simpan" Then
            Try
                Dim qUpdate As String
                qUpdate = "UPDATE transaksi SET id_pelanggan='" & tPelanggan.Text & "', id_menu='" & tMenu.Text & "', tanggal='" & DateTimePicker1.Value.ToString("yyyy-MM-dd") & "' where id_transaksi='" & tID.Text & "' "

                CMD.CommandType = CommandType.Text
                CMD.CommandText = qUpdate
                CMD.Connection = conn
                CMD.ExecuteNonQuery()

                MsgBox("Simpan Ubah Berhasil", MsgBoxStyle.Information, "information")
                tampildata()

                bUbah.Text = "&Ubah"
                statustombol(True, True, False)
                statusinput(False, False, False)
                hapus_isi()
            Catch ex As Exception
                MsgBox("Gagal Simpan Ubah" + ex.Message, MsgBoxStyle.Critical, "Terjadi Kesalahan")
            End Try
        End If
    End Sub

    Private Sub bHapus_Click(sender As Object, e As EventArgs) Handles bHapus.Click
        If bHapus.Text = "&Hapus" Then
            'If MsgBox("Yakin Mau Dihapus?", MsgBoxStyle.YesNo, "Pertanyaan") = MsgBoxResult.Yes.Yes Then
            If MsgBox("Yakin Mau Dihapus?", MsgBoxStyle.YesNo, "Pertanyaan") = Windows.Forms.DialogResult.Yes Then
                Try
                    Dim qDelete As String
                    qDelete = "delete from transaksi where id_transaksi='" & tID.Text & "' "
                    CMD.CommandType = CommandType.Text
                    CMD.CommandText = qDelete
                    CMD.Connection = conn
                    CMD.ExecuteNonQuery()

                    MsgBox("Hapus Berhasil", MsgBoxStyle.Information, "information")
                    tampildata()

                Catch ex As Exception
                    MsgBox("Hapus Gagal", MsgBoxStyle.Information, "information")
                End Try
                hapus_isi()
                statustombol(True, False, False)
            End If
        End If

        If bHapus.Text = "Batal" Then
            bHapus.Text = "Hapus"
            bTambah.Text = "&Tambah"
            statusinput(False, False, False)
            statustombol(True, False, True)
        End If
        hapus_isi()
    End Sub
End Class