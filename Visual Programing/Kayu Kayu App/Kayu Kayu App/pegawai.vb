Imports MySql.Data.MySqlClient
Imports Kayu_Kayu_App.koneksi

Public Class pegawai

    Private Sub statusinput(username As Boolean, password As Boolean, status As Boolean, nama As Boolean, bagian As Boolean, jeniskelamin As Boolean, tempatlahir As Boolean, tanggallahir As Boolean, alamat As Boolean, nohp As Boolean, statuskerja As Boolean)
        txtUsername.Enabled = username
        txtPassword.Enabled = password
        cmbStatus.Enabled = status
        txtNamaPegawai.Enabled = nama
        cmbBagian.Enabled = bagian
        cmbJenisKelamin.Enabled = jeniskelamin
        txtTempatLahir.Enabled = tempatlahir
        dtpTanggalLahir.Enabled = tanggallahir
        txtAlamat.Enabled = alamat
        txtNoHp.Enabled = nohp
        cmbStatusKerja.Enabled = statuskerja
    End Sub

    Private Sub statustombol(tambah As Boolean, simpan As Boolean, edit As Boolean, hapus As Boolean, batal As Boolean)
        btnTambah.Enabled = tambah
        btnSimpan.Enabled = simpan
        btnEdit.Enabled = edit
        btnHapus.Enabled = hapus
        btnBatal.Enabled = batal
    End Sub

    Sub kondisi_bersih()
        txtUsername.Clear()
        txtPassword.Clear()
        cmbStatus.Text = ""
        txtNamaPegawai.Clear()
        cmbBagian.Text = ""
        cmbJenisKelamin.Text = ""
        txtTempatLahir.Clear()
        txtAlamat.Clear()
        txtNoHp.Clear()
        cmbStatusKerja.Text = ""
    End Sub

    Private Sub tampildata()
        Try
            Dim dt As DataTable
            Dim adapter As MySqlDataAdapter
            Dim query As String
            Dim data As Integer

            query = "select username, password, status, nama_user, bagian, jenis_kelamin, tempat_lahir, tanggal_lahir, alamat, no_hp from user where status_kerja = 'Aktif' "
            adapter = New MySqlDataAdapter(query, conn)
            dt = New DataTable
            data = adapter.Fill(dt)

            If data > 0 Then
                dgvPegawai.DataSource = dt
                dgvPegawai.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                dgvPegawai.Columns(0).HeaderText = "Username"
                dgvPegawai.Columns(1).HeaderText = "Password"
                dgvPegawai.Columns(2).HeaderText = "Status"
                dgvPegawai.Columns(3).HeaderText = "Nama"
                dgvPegawai.Columns(4).HeaderText = "Bagian"
                dgvPegawai.Columns(5).HeaderText = "Jenis Kelamin"
                dgvPegawai.Columns(6).HeaderText = "Tempat Lahir"
                dgvPegawai.Columns(7).HeaderText = "Tanggal Lahir"
                dgvPegawai.Columns(8).HeaderText = "Alamat"
                dgvPegawai.Columns(9).HeaderText = "No HP"
            Else
                dgvPegawai.DataSource = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        
    End Sub

    Private Sub pegawai_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            KoneksiBuka()
            tampildata()

            statusinput(False, False, False, False, False, False, False, False, False, False, False)
            statustombol(True, True, True, True, True)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Try
            statustombol(False, True, False, False, True)
            statusinput(True, True, True, True, True, True, True, True, True, True, True)
            txtUsername.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtNoHp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNoHp.KeyPress
        Try
            If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
            If txtUsername.Text = "" Then
                MsgBox("Username Harus diisi", MsgBoxStyle.Information, "Information")
                txtUsername.Focus()
                Exit Sub
            ElseIf txtPassword.Text = "" Then
                MsgBox("Password Harus diisi", MsgBoxStyle.Information, "Information")
                txtPassword.Focus()
                Exit Sub
            ElseIf cmbStatus.Text = "" Then
                MsgBox("Status harus dipilih", MsgBoxStyle.Information, "Information")
                cmbStatus.Focus()
                Exit Sub
            ElseIf txtNamaPegawai.Text = "" Then
                MsgBox("Nama Pegawai Harus diisi", MsgBoxStyle.Information, "Information")
                txtNamaPegawai.Focus()
                Exit Sub
            ElseIf cmbBagian.Text = "" Then
                MsgBox("Bagian Kerja Harus dipilih", MsgBoxStyle.Information, "Information")
                cmbBagian.Focus()
                Exit Sub
            ElseIf cmbJenisKelamin.Text = "" Then
                MsgBox("Jenis Kelamin Harus dipilih", MsgBoxStyle.Information, "Information")
                cmbJenisKelamin.Focus()
                Exit Sub
            ElseIf txtTempatLahir.Text = "" Then
                MsgBox("Tempat Lahir harus diisi", MsgBoxStyle.Information, "Information")
                txtTempatLahir.Focus()
                Exit Sub
            ElseIf dtpTanggalLahir.Text = "" Then
                MsgBox("Tanggal Lahir Harus diisi", MsgBoxStyle.Information, "Information")
                dtpTanggalLahir.Focus()
                Exit Sub
            ElseIf txtAlamat.Text = "" Then
                MsgBox("Alamat Harus diisi", MsgBoxStyle.Information, "Information")
                txtAlamat.Focus()
                Exit Sub
            ElseIf txtNoHp.Text = "" Then
                MsgBox("No HP Harus diisi", MsgBoxStyle.Information, "Information")
                txtNoHp.Focus()
                Exit Sub
            ElseIf cmbStatusKerja.Text = "" Then
            MsgBox("Status Kerja Harus dipilih", MsgBoxStyle.Information, "Information")
            cmbStatusKerja.Focus()
                Exit Sub
            End If

            Try
                KoneksiBuka()
                Dim qInsert As String
                qInsert = "insert into user (username, password, status, nama_user, bagian, jenis_kelamin, tempat_lahir, tanggal_lahir, alamat, no_hp, status_kerja) VALUES ('" & txtUsername.Text & "', '" & txtPassword.Text & "', '" & cmbStatus.Text & "', '" & txtNamaPegawai.Text & "','" & cmbBagian.Text & "', '" & cmbJenisKelamin.Text & "','" & txtTempatLahir.Text & "', '" & dtpTanggalLahir.Value.ToString("yyyy-MM-dd") & "', '" & txtAlamat.Text & "', '" & txtNoHp.Text & "', '" & cmbStatusKerja.Text & "')"
                cmd.CommandType = CommandType.Text
                cmd.CommandText = qInsert
                cmd.Connection = conn
                cmd.ExecuteNonQuery()

                MsgBox("Simpan Berhasil", MsgBoxStyle.Information, "information")
                tampildata()

                statustombol(True, True, True, True, True)
                statusinput(False, False, False, False, False, False, False, False, False, False, False)
                kondisi_bersih()
            Catch ex As Exception
                MsgBox("Gagal Simpan" + ex.Message, MsgBoxStyle.Critical, "Terjadi Kesalahan")
            End Try
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
            If btnEdit.Text = "&Edit" Then
                btnEdit.Text = "&Simpan"

                statustombol(False, False, True, False, True)
                statusinput(False, True, True, True, True, True, True, True, True, True, True)

            ElseIf btnEdit.Text = "&Simpan" Then
                btnEdit.Text = "&Edit"
                Try
                    KoneksiBuka()

                    Dim qUpdate As String
                    qUpdate = "UPDATE user SET username='" & txtUsername.Text & "', password='" & txtPassword.Text & "', status ='" & cmbStatus.Text & "', nama_user='" & txtNamaPegawai.Text & "', bagian='" & cmbBagian.Text & "', jenis_kelamin ='" & cmbJenisKelamin.Text & "', tempat_lahir='" & txtTempatLahir.Text & "', tanggal_lahir='" & dtpTanggalLahir.Value.ToString("yyyy-MM-dd") & "', alamat='" & txtAlamat.Text & "', no_hp='" & txtNoHp.Text & "', status_kerja='" & cmbStatusKerja.Text & "' where username='" & txtUsername.Text & "'"

                    cmd.CommandType = CommandType.Text
                    cmd.CommandText = qUpdate
                    cmd.Connection = conn
                    cmd.ExecuteNonQuery()

                    MsgBox("Simpan Setelah Di Edit Berhasil", MsgBoxStyle.Information, "information")
                    tampildata()

                    statustombol(True, True, True, True, True)
                    statusinput(False, False, False, False, False, False, False, False, False, False, False)
                    kondisi_bersih()

                Catch ex As Exception
                    MsgBox("Gagal Simpan Ubah" + ex.Message, MsgBoxStyle.Critical, "Terjadi Kesalahan")
                End Try
            End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Try
            If MsgBox("Yakin Mau Dihapus?", MsgBoxStyle.YesNo, "Pertanyaan") = Windows.Forms.DialogResult.Yes Then
                Try
                    KoneksiBuka()

                    Dim qDelete As String
                    qDelete = "delete from user where username='" & txtUsername.Text & "' "
                    cmd.CommandType = CommandType.Text
                    cmd.CommandText = qDelete
                    cmd.Connection = conn
                    cmd.ExecuteNonQuery()

                    MsgBox("Hapus Berhasil", MsgBoxStyle.Information, "information")
                    tampildata()

                    statusinput(False, False, False, False, False, False, False, False, False, False, False)
                    kondisi_bersih()
                Catch ex As Exception
                    MsgBox("Hapus Gagal", MsgBoxStyle.Information, "information")
                End Try
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Try
            If btnEdit.Text = "&Simpan" Then
                btnEdit.Text = "&Edit"

            End If

            tampildata()
            txtCari.Text = ""
            cmbKriteria.Text = "Kategori"
            statustombol(True, True, True, True, True)
            statusinput(False, False, False, False, False, False, False, False, False, False, False)
            kondisi_bersih()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        
    End Sub

    Private Sub dgvPegawai_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPegawai.CellClick
        Try
            Dim i As Integer
            i = Me.dgvPegawai.CurrentRow.Index
            With dgvPegawai.Rows.Item(i)
                txtUsername.Text = .Cells(0).Value
                txtPassword.Text = .Cells(1).Value
                cmbStatus.Text = .Cells(2).Value
                txtNamaPegawai.Text = .Cells(3).Value
                cmbBagian.Text = .Cells(4).Value
                cmbJenisKelamin.Text = .Cells(5).Value
                txtTempatLahir.Text = .Cells(6).Value
                dtpTanggalLahir.Value = .Cells(7).Value
                txtAlamat.Text = .Cells(8).Value
                txtNoHp.Text = .Cells(9).Value
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        Try
            If txtCari.Text = "" Then
                MsgBox("Parameter tidak boleh kosong", MsgBoxStyle.Critical, "Info")
                txtCari.Focus()
            Else
                KoneksiBuka()
                If cmbKriteria.Text = "Username" Then
                    Try
                        Dim qSearch As String
                        qSearch = "select * from user where username like '%" & txtCari.Text & "%'"
                        cmd.CommandType = CommandType.Text
                        cmd.CommandText = qSearch
                        cmd.Connection = conn

                        rd = cmd.ExecuteReader

                        Using dt As New DataTable
                            dt.Load(rd)
                            If dt.Rows.Count = 0 Then
                                'DataGridView1.DataSource = Nothing
                                MsgBox("Data tidak Ditemukan", MsgBoxStyle.Information, "Information")
                            Else
                                dgvPegawai.AutoGenerateColumns = False
                                dgvPegawai.DataSource = dt
                            End If
                        End Using
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                ElseIf cmbKriteria.Text = "Status" Then
                    Try
                        Dim qSearch As String
                        qSearch = "select * from user where status like '%" & txtCari.Text & "%'"
                        cmd.CommandType = CommandType.Text
                        cmd.CommandText = qSearch
                        cmd.Connection = conn

                        rd = cmd.ExecuteReader

                        Using dt As New DataTable
                            dt.Load(rd)
                            If dt.Rows.Count = 0 Then
                                'DataGridView1.DataSource = Nothing
                                MsgBox("Data tidak Ditemukan", MsgBoxStyle.Information, "Information")
                            Else
                                dgvPegawai.AutoGenerateColumns = False
                                dgvPegawai.DataSource = dt
                            End If
                        End Using
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                ElseIf cmbKriteria.Text = "Nama" Then
                    Try
                        Dim qSearch As String
                        qSearch = "select * from user where nama_user like '%" & txtCari.Text & "%'"
                        cmd.CommandType = CommandType.Text
                        cmd.CommandText = qSearch
                        cmd.Connection = conn

                        rd = cmd.ExecuteReader

                        Using dt As New DataTable
                            dt.Load(rd)
                            If dt.Rows.Count = 0 Then
                                'DataGridView1.DataSource = Nothing
                                MsgBox("Data tidak Ditemukan", MsgBoxStyle.Information, "Information")
                            Else
                                dgvPegawai.AutoGenerateColumns = False
                                dgvPegawai.DataSource = dt
                            End If
                        End Using
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                ElseIf cmbKriteria.Text = "Bagian" Then
                    Try
                        Dim qSearch As String
                        qSearch = "select * from user where bagian like '%" & txtCari.Text & "%'"
                        cmd.CommandType = CommandType.Text
                        cmd.CommandText = qSearch
                        cmd.Connection = conn

                        rd = cmd.ExecuteReader

                        Using dt As New DataTable
                            dt.Load(rd)
                            If dt.Rows.Count = 0 Then
                                'DataGridView1.DataSource = Nothing
                                MsgBox("Data tidak Ditemukan", MsgBoxStyle.Information, "Information")
                            Else
                                dgvPegawai.AutoGenerateColumns = False
                                dgvPegawai.DataSource = dt
                            End If
                        End Using
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                ElseIf cmbKriteria.Text = "Jenis Kelamin" Then
                    Try
                        Dim qSearch As String
                        qSearch = "select * from user where jenis_kelamin like '%" & txtCari.Text & "%'"
                        cmd.CommandType = CommandType.Text
                        cmd.CommandText = qSearch
                        cmd.Connection = conn

                        rd = cmd.ExecuteReader

                        Using dt As New DataTable
                            dt.Load(rd)
                            If dt.Rows.Count = 0 Then
                                'DataGridView1.DataSource = Nothing
                                MsgBox("Data tidak Ditemukan", MsgBoxStyle.Information, "Information")
                            Else
                                dgvPegawai.AutoGenerateColumns = False
                                dgvPegawai.DataSource = dt
                            End If
                        End Using
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                ElseIf cmbKriteria.Text = "Tanggal Lahir" Then
                    Try
                        Dim qSearch As String
                        qSearch = "select * from user where tanggal_lahir like '%" & txtCari.Text & "%'"
                        cmd.CommandType = CommandType.Text
                        cmd.CommandText = qSearch
                        cmd.Connection = conn

                        rd = cmd.ExecuteReader

                        Using dt As New DataTable
                            dt.Load(rd)
                            If dt.Rows.Count = 0 Then
                                'DataGridView1.DataSource = Nothing
                                MsgBox("Data tidak Ditemukan", MsgBoxStyle.Information, "Information")
                            Else
                                dgvPegawai.AutoGenerateColumns = False
                                dgvPegawai.DataSource = dt
                            End If
                        End Using
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                ElseIf cmbKriteria.Text = "Alamat" Then
                    Try
                        Dim qSearch As String
                        qSearch = "select * from user where alamat like '%" & txtCari.Text & "%'"
                        cmd.CommandType = CommandType.Text
                        cmd.CommandText = qSearch
                        cmd.Connection = conn

                        rd = cmd.ExecuteReader

                        Using dt As New DataTable
                            dt.Load(rd)
                            If dt.Rows.Count = 0 Then
                                'DataGridView1.DataSource = Nothing
                                MsgBox("Data tidak Ditemukan", MsgBoxStyle.Information, "Information")
                            Else
                                dgvPegawai.AutoGenerateColumns = False
                                dgvPegawai.DataSource = dt
                            End If
                        End Using
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cmbKriteria_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbKriteria.SelectedIndexChanged
        Try
            txtCari.Text = ""
            tampildata()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Class