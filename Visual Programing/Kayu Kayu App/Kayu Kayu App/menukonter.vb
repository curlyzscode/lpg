Imports MySql.Data.MySqlClient
Imports Kayu_Kayu_App.koneksi

Public Class menukonter

    Private Sub statusinput(idmenu As Boolean, nama As Boolean, hargajual As Boolean, hargakonter As Boolean, kategori As Boolean, stok As Boolean, idkonter As Boolean, username As Boolean, waktu As Boolean)
        txtIdMenu.Enabled = idmenu
        txtNamaMenu.Enabled = nama
        txtHargaJual.Enabled = hargajual
        txtHargaKonter.Enabled = hargakonter
        cmbKategori.Enabled = kategori
        txtStok.Enabled = stok
        cmbIdKonter.Enabled = idkonter
        txtUsername.Enabled = username
    End Sub

    Private Sub statustombol(tambah As Boolean, simpan As Boolean, edit As Boolean, hapus As Boolean, batal As Boolean)
        btnTambah.Enabled = tambah
        btnSimpan.Enabled = simpan
        btnEdit.Enabled = edit
        btnHapus.Enabled = hapus
        btnBatal.Enabled = batal
    End Sub

    Sub kondisi_bersih()
        txtIdMenu.Clear()
        txtNamaMenu.Clear()
        txtHargaJual.Clear()
        txtHargaKonter.Clear()
        cmbKategori.Text = ""
        txtStok.Clear()
        cmbIdKonter.Text = ""
    End Sub

    Private Sub tampildata()
        Dim dt As DataTable
        Dim adapter As MySqlDataAdapter
        Dim query As String
        Dim data As Integer

        query = "select id_menu, nama_menu, harga_jual, harga_konter, kategori, stok, id_konter from menu "
        adapter = New MySqlDataAdapter(query, conn)
        dt = New DataTable
        data = adapter.Fill(dt)

        If data > 0 Then
            dgvMenu.DataSource = dt
            dgvMenu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            dgvMenu.Columns(0).HeaderText = "ID Menu"
            dgvMenu.Columns(1).HeaderText = "Nama Menu"
            dgvMenu.Columns(2).HeaderText = "Harga Jual"
            dgvMenu.Columns(3).HeaderText = "Harga Konter"
            dgvMenu.Columns(4).HeaderText = "Kategori"
            dgvMenu.Columns(5).HeaderText = "Stok"
            dgvMenu.Columns(6).HeaderText = "ID Konter"
        Else
            dgvMenu.DataSource = Nothing
        End If
    End Sub

    Sub tampilIdKonter()
        Try
            Dim qShow As String
            qShow = "select id_konter from konter"
            cmd.CommandText = qShow
            cmd.Connection = conn

            rd = cmd.ExecuteReader

            Do While rd.Read
                cmbIdKonter.Items.Add(rd("id_konter"))
            Loop

            KoneksiTutup()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub username()
        txtUsername.Text = login.txtUsername.Text
    End Sub

    Private Sub menukonter_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        KoneksiBuka()
        tampildata()
        tampilIdKonter()
        username()

        statusinput(False, False, False, False, False, False, False, False, False)
        statustombol(True, True, True, True, True)
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        statustombol(False, True, False, False, True)
        statusinput(True, True, True, True, True, True, True, False, False)
        cmbIdKonter.Focus()
    End Sub

    Private Sub txtHargaJual_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtHargaJual.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub

    Private Sub txtHargaKonter_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtHargaKonter.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub

    Private Sub txtStok_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtStok.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If txtIdMenu.Text = "" Then
            MsgBox("ID Menu Harus diisi", MsgBoxStyle.Information, "Information")
            txtIdMenu.Focus()
            Exit Sub
        ElseIf txtNamaMenu.Text = "" Then
            MsgBox("Nama Menu Harus diisi", MsgBoxStyle.Information, "Information")
            txtNamaMenu.Focus()
            Exit Sub
        ElseIf txtHargaJual.Text = "" Then
            MsgBox("Harga Jual Harus Diisi", MsgBoxStyle.Information, "Information")
            txtHargaJual.Focus()
            Exit Sub
        ElseIf txtHargaKonter.Text = "" Then
            MsgBox("Harga Konter Harus diisi", MsgBoxStyle.Information, "Information")
            txtHargaJual.Focus()
            Exit Sub
        ElseIf cmbKategori.Text = "" Then
            MsgBox("Kategori Harus dipilih", MsgBoxStyle.Information, "Information")
            cmbKategori.Focus()
            Exit Sub
        ElseIf txtStok.Text = "" Then
            MsgBox("Stok Harus Diisi", MsgBoxStyle.Information, "Information")
            txtStok.Focus()
            Exit Sub
        ElseIf cmbIdKonter.Text = "" Then
            MsgBox("ID Konter Harus Dipilih", MsgBoxStyle.Information, "Information")
            cmbIdKonter.Focus()
            Exit Sub
        End If

        Try
            KoneksiBuka()

            Dim qInsert As String
            qInsert = "insert into menu (id_menu, nama_menu, harga_jual, harga_konter, kategori, stok, id_konter, username_input, waktu_input) VALUES ('" & txtIdMenu.Text & "', '" & txtNamaMenu.Text & "', '" & txtHargaJual.Text & "', '" & txtHargaKonter.Text & "','" & cmbKategori.Text & "', '" & txtStok.Text & "','" & cmbIdKonter.Text & "','" & txtUsername.Text & "', '" & Format(Now, "yyyy-MM-dd HH:mm:ss") & "')"
            cmd.CommandType = CommandType.Text
            cmd.CommandText = qInsert
            cmd.Connection = conn
            cmd.ExecuteNonQuery()

            MsgBox("Simpan Berhasil", MsgBoxStyle.Information, "information")
            tampildata()

            statustombol(True, True, True, True, True)
            statusinput(False, False, False, False, False, False, False, False, False)
            kondisi_bersih()
            username()
        Catch ex As Exception
            MsgBox("Gagal Simpan" + ex.Message, MsgBoxStyle.Critical, "Terjadi Kesalahan")
        End Try
    End Sub


    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If btnEdit.Text = "&Edit" Then
            btnEdit.Text = "&Simpan"

            statustombol(False, False, True, False, True)
            statusinput(False, True, True, True, True, True, False, False, False)

        ElseIf btnEdit.Text = "&Simpan" Then
            btnEdit.Text = "&Edit"
            Try
                KoneksiBuka()
                Dim qUpdate As String
                qUpdate = "UPDATE menu SET id_menu='" & txtIdMenu.Text & "', nama_menu='" & txtNamaMenu.Text & "', harga_jual ='" & txtHargaJual.Text & "', harga_konter='" & txtHargaKonter.Text & "', kategori='" & cmbKategori.Text & "', stok ='" & txtStok.Text & "', id_konter='" & cmbIdKonter.Text & "', username_edit='" & txtUsername.Text & "', waktu_edit='" & Format(Now, "yyyy-MM-dd HH:mm:ss") & "' where id_menu = '" & txtIdMenu.Text & "'"

                cmd.CommandType = CommandType.Text
                cmd.CommandText = qUpdate
                cmd.Connection = conn
                cmd.ExecuteNonQuery()

                MsgBox("Simpan Setelah Di Edit Berhasil", MsgBoxStyle.Information, "information")
                tampildata()

                statustombol(True, True, True, True, True)
                statusinput(False, False, False, False, False, False, False, False, False)
                kondisi_bersih()

            Catch ex As Exception
                MsgBox("Gagal Simpan Ubah" + ex.Message, MsgBoxStyle.Critical, "Terjadi Kesalahan")
            End Try
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If MsgBox("Yakin Mau Dihapus?", MsgBoxStyle.YesNo, "Pertanyaan") = Windows.Forms.DialogResult.Yes Then
            Try
                KoneksiBuka()
                Dim qDelete As String
                qDelete = "delete from menu where id_menu='" & txtIdMenu.Text & "' "
                cmd.CommandType = CommandType.Text
                cmd.CommandText = qDelete
                cmd.Connection = conn
                cmd.ExecuteNonQuery()

                MsgBox("Hapus Berhasil", MsgBoxStyle.Information, "information")
                tampildata()

                statusinput(False, False, False, False, False, False, False, False, False)
                kondisi_bersih()
            Catch ex As Exception
                MsgBox("Hapus Gagal", MsgBoxStyle.Information, "information")
            End Try
        End If
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Try
            KoneksiTutup()

            If btnEdit.Text = "&Simpan" Then
                btnEdit.Text = "&Edit"

            End If

            tampildata()
            txtCari.Text = ""
            cmbKriteria.Text = "Kategori"
            statustombol(True, True, True, True, True)
            statusinput(False, False, False, False, False, False, False, False, False)
            kondisi_bersih()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub DGVPegawai_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMenu.CellClick
        Dim i As Integer
        i = Me.dgvMenu.CurrentRow.Index
        With dgvMenu.Rows.Item(i)
            txtIdMenu.Text = .Cells(0).Value
            txtNamaMenu.Text = .Cells(1).Value
            txtHargaJual.Text = .Cells(2).Value
            txtHargaKonter.Text = .Cells(3).Value
            cmbKategori.Text = .Cells(4).Value
            txtStok.Text = .Cells(5).Value
            cmbIdKonter.Text = .Cells(6).Value
        End With
    End Sub

    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        If txtCari.Text = "" Then
            MsgBox("Parameter tidak boleh kosong", MsgBoxStyle.Critical, "Info")
            txtCari.Focus()
        Else
            If cmbKriteria.Text = "ID Konter" Then
                Try
                    KoneksiBuka()

                    Dim qSearch As String
                    qSearch = "select * from menu where id_konter like '%" & txtCari.Text & "%'"
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
                            dgvMenu.AutoGenerateColumns = False
                            dgvMenu.DataSource = dt
                        End If
                    End Using
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

            ElseIf cmbKriteria.Text = "ID Menu" Then
                Try
                    KoneksiBuka()

                    Dim qSearch As String
                    qSearch = "select * from menu where id_menu like '%" & txtCari.Text & "%'"
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
                            dgvMenu.AutoGenerateColumns = False
                            dgvMenu.DataSource = dt
                        End If
                    End Using
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

            ElseIf cmbKriteria.Text = "Nama Menu" Then
                Try
                    KoneksiBuka()

                    Dim qSearch As String
                    qSearch = "select * from menu where nama_menu like '%" & txtCari.Text & "%'"
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
                            dgvMenu.AutoGenerateColumns = False
                            dgvMenu.DataSource = dt
                        End If
                    End Using
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

            ElseIf cmbKriteria.Text = "Harga Jual" Then
                Try
                    KoneksiBuka()

                    Dim qSearch As String
                    qSearch = "select * from menu where harga_jual like '%" & txtCari.Text & "%'"
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
                            dgvMenu.AutoGenerateColumns = False
                            dgvMenu.DataSource = dt
                        End If
                    End Using
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

            ElseIf cmbKriteria.Text = "Harga Konter" Then
                Try
                    KoneksiBuka()

                    Dim qSearch As String
                    qSearch = "select * from menu where harga_konter like '%" & txtCari.Text & "%'"
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
                            dgvMenu.AutoGenerateColumns = False
                            dgvMenu.DataSource = dt
                        End If
                    End Using
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

            ElseIf cmbKriteria.Text = "Stok" Then
                Try
                    KoneksiBuka()

                    Dim qSearch As String
                    qSearch = "select * from menu where stok like '%" & txtCari.Text & "%'"
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
                            dgvMenu.AutoGenerateColumns = False
                            dgvMenu.DataSource = dt
                        End If
                    End Using
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

            ElseIf cmbKriteria.Text = "Kategori" Then
                Try
                    KoneksiBuka()

                    Dim qSearch As String
                    qSearch = "select * from menu where kategori like '%" & txtCari.Text & "%'"
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
                            dgvMenu.AutoGenerateColumns = False
                            dgvMenu.DataSource = dt
                        End If
                    End Using
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        End If
    End Sub

    Sub CariKode()
        Try
            KoneksiBuka()

            cmd = New MySqlCommand
            cmd.Connection = conn
            str = "select * from menu where left(id_menu,1) = '" & cmbIdKonter.Text & "' in (select max(id_menu) from menu) order by id_menu DESC"
            cmd.CommandText = str

            rd = cmd.ExecuteReader

            rd.Read()

            If Not rd.HasRows Then
                txtIdMenu.Text = cmbIdKonter.Text + "0001"
            Else
                If Microsoft.VisualBasic.Left(rd.GetString(0), 6) <> cmbIdKonter.Text Then
                    txtIdMenu.Text = cmbIdKonter.Text + "0001"
                Else
                    txtIdMenu.Text = rd.Item("id_konter") + 1
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub cmbIdKonter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbIdKonter.SelectedIndexChanged
        Call CariKode()
    End Sub

End Class