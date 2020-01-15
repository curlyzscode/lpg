Imports Form_Login.koneksi
Imports MySql.Data.MySqlClient

Public Class Pegawai
    Private Sub Pegawai_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        KoneksiBuka()
        tampildata()

        statusinput(False, False, False, False, False, False)
        statustombol(True, True, True)
    End Sub
    Private Sub tampildata()
        Dim dt As DataTable
        Dim adapter As MySqlDataAdapter
        Dim query As String
        Dim data As Integer

        query = "select * from pegawai"
        adapter = New MySqlDataAdapter(query, conn)
        dt = New DataTable
        data = adapter.Fill(dt)

        If data > 0 Then
            tabelpegawai.DataSource = dt
            tabelpegawai.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            tabelpegawai.Columns(0).HeaderText = "id_pegawai"
            tabelpegawai.Columns(1).HeaderText = "nama_pegawai"
            tabelpegawai.Columns(2).HeaderText = "tempat_lahir"
            tabelpegawai.Columns(3).HeaderText = "tanggal_lahir"
            tabelpegawai.Columns(4).HeaderText = "pekerjaan_bagian"
            tabelpegawai.Columns(5).HeaderText = "alamat"
            tabelpegawai.Columns(6).HeaderText = "no_hp"
        Else
            tabelpegawai.DataSource = Nothing
        End If
    End Sub

    Sub hapus_isi()
        tID.Clear()
        tNama.Clear()
        tTempat.Clear()
        tPekerjaan.Clear()
        tAlamat.Clear()
        tnohp.Clear()
    End Sub

    Private Sub statusinput(id As Boolean, nama As Boolean, tempat As Boolean, pekerjaan As Boolean, alamat As Boolean, nohp As Boolean)
        tID.Enabled = id
        tNama.Enabled = nama
        tTempat.Enabled = tempat
        tPekerjaan.Enabled = pekerjaan
        tAlamat.Enabled = alamat
        tnohp.Enabled = nohp
    End Sub

    Private Sub statustombol(tambah As Boolean, hapus As Boolean, ubah As Boolean)
        bTambah.Enabled = tambah
        bHapus.Enabled = hapus
        bUbah.Enabled = ubah
    End Sub

    Private Sub tabelpegawai_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles tabelpegawai.CellContentClick
        Dim i As Integer
        i = Me.tabelpegawai.CurrentRow.Index
        'MsgBox("baris ke : " & i.ToString, MsgBoxStyle.Information, "informasi")
        'tNim.Text = tabelpegawai.Rows.Item(i).Cells(0).Value
        With tabelpegawai.Rows.Item(i)
            tID.Text = .Cells(0).Value
            tNama.Text = .Cells(1).Value
            tTempat.Text = .Cells(2).Value
            DateTimePicker1.Value = .Cells(3).Value
            tAlamat.Text = .Cells(4).Value
            tnohp.Text = .Cells(5).Value
        End With

        statustombol(True, True, True)
    End Sub

    Private Sub bTambah_Click(sender As Object, e As EventArgs) Handles bTambah.Click
        If bTambah.Text = "&Tambah" Then
            statusinput(True, True, True, True, True, True)
            statustombol(True, True, False)
            bTambah.Text = "Simpan"
            bHapus.Text = "Batal"
        ElseIf bTambah.Text = "Simpan" Then
            If tID.Text = "" Then
                MsgBox("ID Harus diisi", MsgBoxStyle.Information, "Information")
                tID.Focus()
                Exit Sub
            ElseIf tNama.Text = "" Then
                MsgBox("NAMA Harus diisi", MsgBoxStyle.Information, "Information")
                tNama.Focus()
                Exit Sub
            ElseIf tTempat.Text = "" Then
                MsgBox("Tempat Lahir Harus diisi", MsgBoxStyle.Information, "Information")
                tTempat.Focus()
                Exit Sub
            ElseIf tPekerjaan.Text = "" Then
                MsgBox("Pekerjaan Harus diisi", MsgBoxStyle.Information, "Information")
                tTempat.Focus()
                Exit Sub
            ElseIf tAlamat.Text = "" Then
                MsgBox("Alamat Harus diisi", MsgBoxStyle.Information, "Information")
                tAlamat.Focus()
                Exit Sub
            ElseIf tNoHP.Text = "" Then
                MsgBox("No HP Harus diisi", MsgBoxStyle.Information, "Information")
                tNoHP.Focus()
                Exit Sub

            End If

            'conn.Open()
            Try
                Dim qInsert As String
                qInsert = "insert into pegawai (id_pegawai, nama_pegawai, tempat_lahir, tanggal_lahir, pekerjaan_bagian, alamat, no_hp)"
                qInsert = qInsert & "VALUES('" & tID.Text & "', '" & tNama.Text & "', '" & tTempat.Text & "', '" & DateTimePicker1.Value.ToString("yyyy-MM-dd") & "', '" & tPekerjaan.Text & "', '" & tAlamat.Text & "', '" & tnohp.Text & "' )"
                CMD.CommandType = CommandType.Text
                CMD.CommandText = qInsert
                CMD.Connection = conn
                CMD.ExecuteNonQuery()

                tampildata()

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
            statusinput(False, True, True, True, True, True)
        ElseIf bUbah.Text = "&Simpan" Then
            Try
                Dim qUpdate As String
                qUpdate = "UPDATE pegawai SET nama_pegawai='" & tNama.Text & "', tempat_lahir='" & tTempat.Text & "', tanggal_lahir='" & DateTimePicker1.Value.ToString("yyyy-MM-dd") & "', pekerjaan_bagian='" & tPekerjaan.Text & "', alamat='" & tAlamat.Text & "', no_hp='" & tnohp.Text & "' where id_pegawai='" & tID.Text & "' "

                CMD.CommandType = CommandType.Text
                CMD.CommandText = qUpdate
                CMD.Connection = conn
                CMD.ExecuteNonQuery()

                MsgBox("Simpan Ubah Berhasil", MsgBoxStyle.Information, "information")
                tampildata()

                bUbah.Text = "&Ubah"
                statustombol(True, True, False)
                statusinput(False, False, False, False, False, False)
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
                    qDelete = "delete from pegawai where id_pegawai='" & tID.Text & "' "
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
            statusinput(False, False, False, False, False, False)
            statustombol(True, False, True)
        End If
        hapus_isi()
    End Sub
End Class