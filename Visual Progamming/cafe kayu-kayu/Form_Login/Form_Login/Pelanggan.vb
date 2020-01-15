Imports Form_Login.koneksi
Imports MySql.Data.MySqlClient
Public Class Pelanggan

    Private Sub Pelanggan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        KoneksiBuka()
        tampildata()

        statusinput(False, False)
        statustombol(True, True, True)
    End Sub

    Private Sub tampildata()
        Dim dt As DataTable
        Dim adapter As MySqlDataAdapter
        Dim query As String
        Dim data As Integer

        query = "select * from pelanggan"
        adapter = New MySqlDataAdapter(query, conn)
        dt = New DataTable
        data = adapter.Fill(dt)

        If data > 0 Then
            tabelpelanggan.DataSource = dt
            tabelpelanggan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            tabelpelanggan.Columns(0).HeaderText = "id_pelanggan"
            tabelpelanggan.Columns(1).HeaderText = "nama_pelanggan"
        Else
            tabelpelanggan.DataSource = Nothing
        End If
    End Sub

    Sub hapus_isi()
        tPelanggan.Clear()
        tNama.Clear()
    End Sub

    Private Sub statusinput(pelanggan As Boolean, nama As Boolean)
        tPelanggan.Enabled = pelanggan
        tNama.Enabled = nama
    End Sub

    Private Sub statustombol(tambah As Boolean, hapus As Boolean, ubah As Boolean)
        bTambah.Enabled = tambah
        bHapus.Enabled = hapus
        bUbah.Enabled = ubah
    End Sub

    Private Sub tabelpelanggan_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles tabelpelanggan.CellContentClick
        Dim i As Integer
        i = Me.tabelpelanggan.CurrentRow.Index
        'MsgBox("baris ke : " & i.ToString, MsgBoxStyle.Information, "informasi")
        'tNim.Text = tabelpegawai.Rows.Item(i).Cells(0).Value
        With tabelpelanggan.Rows.Item(i)
            tPelanggan.Text = .Cells(0).Value
            tNama.Text = .Cells(1).Value
        End With
        statustombol(True, True, True)
    End Sub

    Private Sub bTambah_Click(sender As Object, e As EventArgs) Handles bTambah.Click
        If bTambah.Text = "&Tambah" Then
            statusinput(True, True)
            statustombol(True, True, False)
            bTambah.Text = "Simpan"
            bHapus.Text = "Batal"
        ElseIf bTambah.Text = "Simpan" Then
            If tPelanggan.Text = "" Then
                MsgBox("ID Harus diisi", MsgBoxStyle.Information, "Information")
                tPelanggan.Focus()
                Exit Sub
            ElseIf tNama.Text = "" Then
                MsgBox("NAMA Harus diisi", MsgBoxStyle.Information, "Information")
                tNama.Focus()
                Exit Sub
            End If

            'conn.Open()
            Try
                Dim qInsert As String
                qInsert = "insert into pelanggan (id_pelanggan, nama_pelanggan)"
                qInsert = qInsert & "VALUES('" & tPelanggan.Text & "', '" & tNama.Text & "')"
                CMD.CommandType = CommandType.Text
                CMD.CommandText = qInsert
                CMD.Connection = conn
                CMD.ExecuteNonQuery()

                tampildata()

            Catch ex As Exception
                MsgBox("Gagal Simpan" + ex.Message, MsgBoxStyle.Critical, "Terjadi Kesalahan")
            End Try
            'conn.Close()
            bTambah.Text = "&Tambah"
            statusinput(False, False)
            statustombol(True, False, False)
        End If
    End Sub

    Private Sub bUbah_Click(sender As Object, e As EventArgs) Handles bUbah.Click
        If bUbah.Text = "&Ubah" Then
            bUbah.Text = "&Simpan"
            bHapus.Text = "Batal"
            statustombol(False, True, True)
            statusinput(False, True)
        ElseIf bUbah.Text = "&Simpan" Then

            Try
                Dim qUpdate As String
                qUpdate = "UPDATE pelanggan SET nama_pelanggan='" & tNama.Text & "'"
                qUpdate = qUpdate & "' where id_pegawai='" & tPelanggan.Text & "'"

                CMD.CommandType = CommandType.Text
                CMD.CommandText = qUpdate
                CMD.Connection = conn
                CMD.ExecuteNonQuery()

                MsgBox("Simpan Ubah Berhasil", MsgBoxStyle.Information, "information")
                tampildata()

                bUbah.Text = "&Ubah"
                statustombol(True, True, False)
                statusinput(False, False)
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
                    qDelete = "delete from pelanggan where id_pelanggan='" & tPelanggan.Text & "' "
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
            bHapus.Text = "&Hapus"
            bTambah.Text = "&Tambah"
            statusinput(False, False)
            statustombol(True, False, False)
        End If
        hapus_isi()
    End Sub
End Class