Imports MySql.Data.MySqlClient
Imports Kayu_Kayu_App.koneksi

Public Class transaksi

    Private Sub statusinput(idtransaksi As Boolean, idmenu As Boolean, nama As Boolean, kategori As Boolean, hargajual As Boolean, stok As Boolean, qty As Boolean, totalharga As Boolean, totalbayar As Boolean, diskon As Boolean, pembayaran As Boolean, kembalian As Boolean, username As Boolean, tanggal As Boolean, waktu As Boolean)
        txtIdTransaksi.Enabled = idtransaksi
        txtIdMenu.Enabled = idmenu
        txtNamaMenu.Enabled = nama
        txtKategori.Enabled = kategori
        txtHargaJual.Enabled = hargajual
        txtStok.Enabled = stok
        txtQTY.Enabled = qty
        txtTotalHarga.Enabled = totalharga
        txtTotalBayar.Enabled = totalbayar
        cmbDiskon.Enabled = diskon
        txtPembayaran.Enabled = pembayaran
        txtKembalian.Enabled = kembalian
        lblUsername.Enabled = username
        lblTanggal.Enabled = tanggal
        lblWaktu.Enabled = waktu
    End Sub

    Private Sub statustombol(proses As Boolean, batal As Boolean)
        btnProses.Enabled = proses
        btnBatal.Enabled = batal
    End Sub

    Sub kondisi_bersih_detail()
        txtIdMenu.Clear()
        txtNamaMenu.Clear()
        txtKategori.Clear()
        txtHargaJual.Clear()
        txtStok.Clear()
        txtQTY.Clear()
        txtTotalHarga.Clear()
    End Sub

    Sub kondisi_bersih_transaksi()
        txtNamaPelanggan.Clear()
        cmbNoMeja.Text = ""
    End Sub

    Sub bersih_grid()
        dgvTransaksi.Columns.Clear()
    End Sub

    Sub bersih_transaksi()
        txtTotalBayar.Text = "0"
        cmbDiskon.Text = ""
        txtPembayaran.Text = "0"
        txtKembalian.Text = "0"
    End Sub

    Sub hapus_grid()
            Try
            KoneksiBuka()
            Dim qDelete As String
            qDelete = "delete from detail_transaksi where id_transaksi='" & txtIdTransaksi.Text & "' "
                cmd.CommandType = CommandType.Text
                cmd.CommandText = qDelete
                cmd.Connection = conn
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox("Hapus Gagal", MsgBoxStyle.Information, "information")
            End Try
    End Sub

    Sub NoFaktur()
        Try
            KoneksiBuka()

            cmd = New MySqlCommand
            cmd.Connection = conn
            str = "select * from transaksi where id_transaksi in (select max(id_transaksi) from transaksi) order by id_transaksi DESC"
            cmd.CommandText = str

            rd = cmd.ExecuteReader

            rd.Read()

            If Not rd.HasRows Then
                txtIdTransaksi.Text = Format(Now, "yyMMdd") + "0001"
            Else
                If Microsoft.VisualBasic.Left(rd.GetString(0), 6) <> Format(Now, "yyMMdd") Then
                    txtIdTransaksi.Text = Format(Now, "yyMMdd") + "0001"
                Else
                    txtIdTransaksi.Text = rd.Item("id_transaksi") + 1
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub tampildata()
        Try
            KoneksiBuka()

            Dim dt As DataTable
            Dim adapter As MySqlDataAdapter
            Dim query As String
            Dim data As Integer

            query = "select id_menu, nama_menu, kategori , stok, harga_jual, qty, total_harga from detail_transaksi where id_transaksi = '" & txtIdTransaksi.Text & "'"
            adapter = New MySqlDataAdapter(query, conn)
            dt = New DataTable
            data = adapter.Fill(dt)

            If data > 0 Then
                dgvTransaksi.DataSource = dt
                dgvTransaksi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                dgvTransaksi.Columns(0).HeaderText = "ID Menu"
                dgvTransaksi.Columns(1).HeaderText = "Nama Menu"
                dgvTransaksi.Columns(2).HeaderText = "Kategori"
                dgvTransaksi.Columns(3).HeaderText = "Stok"
                dgvTransaksi.Columns(4).HeaderText = "Harga"
                dgvTransaksi.Columns(5).HeaderText = "QTY"
                dgvTransaksi.Columns(6).HeaderText = "Total Harga"
            Else
                dgvTransaksi.DataSource = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Sub total_bayar()
        Try
            Dim jumlah As Decimal = 0
            For i As Integer = 0 To dgvTransaksi.Rows.Count - 1
                jumlah = jumlah + dgvTransaksi.Rows(i).Cells(6).Value
                txtTotalBayar.Text = jumlah
            Next
            If txtTotalBayar.Text = "" Then
                txtTotalBayar.Text = "0"
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Sub kurangi_stok()
        Try

            KoneksiBuka()

            cmd = New MySqlCommand
            cmd.Connection = conn
            str = "select * from menu where id_menu = '" & txtIdMenu.Text & "'"
            cmd.CommandText = str

            rd = cmd.ExecuteReader

            If rd.HasRows = True Then
                cmd = New MySqlCommand
                cmd.Connection = conn
                str = "update menu set stok = '" & rd.Item("stok") - Val(txtQTY.Text) & "' where id_menu = '" & txtIdMenu.Text & "'"
                cmd.ExecuteNonQuery()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        
    End Sub

    Private Sub transaksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            KoneksiBuka()
            NoFaktur()
            tampildata()
            total_bayar()

            txtPembayaran.Text = ""
            txtKembalian.Text = "0"
            cmbDiskon.Text = ""
            txtTotalBayar.Text = "0"

            txtNamaPelanggan.Focus()
            lblUsername.Text = home.lblUsername.Text
            lblTanggal.Text = Format(Now, "yyyy-MM-dd")

            statusinput(False, True, False, False, False, False, True, False, False, True, True, False, False, False, False)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub txtIdMenu_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIdMenu.KeyPress
        Try
            KoneksiBuka()

            If e.KeyChar = Chr(13) Then
                cmd = New MySqlCommand
                cmd.Connection = conn
                str = "select * from menu where id_menu = '" & txtIdMenu.Text & "'"
                cmd.CommandText = str

                rd = cmd.ExecuteReader

                rd.Read()

                If rd.HasRows = True Then
                    txtNamaMenu.Text = rd.Item("nama_menu")
                    txtKategori.Text = rd.Item("kategori")
                    txtStok.Text = rd.Item("stok")
                    txtHargaJual.Text = rd.Item("harga_jual")
                    txtQTY.Focus()

                Else
                    kondisi_bersih_detail()
                    txtIdMenu.Focus()
                    MessageBox.Show("Barang Tidak Ditemukan!", "WARNING")
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub total_harga()
        txtTotalHarga.Text = Val(txtHargaJual.Text) * Val(txtQTY.Text)
    End Sub

    Private Sub txtQTY_TextChanged(sender As Object, e As EventArgs) Handles txtQTY.TextChanged
        Try
            total_harga()
        Catch ex As Exception
            MsgBox(ex.Message)
            txtTotalBayar.Text = "0"
        End Try
    End Sub

    Private Sub txtQTY_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQTY.KeyPress
        Try
            If e.KeyChar = Chr(13) Then
                Try
                    KoneksiBuka()

                    Dim qInsert As String
                    qInsert = "insert into detail_transaksi (id_transaksi, id_menu, nama_menu, kategori, stok, harga_jual, qty, total_harga, status_transaksi) VALUES ('" & txtIdTransaksi.Text & "','" & txtIdMenu.Text & "', '" & txtNamaMenu.Text & "', '" & txtKategori.Text & "','" & txtStok.Text & "', '" & txtHargaJual.Text & "','" & txtQTY.Text & "', '" & txtTotalHarga.Text & "', 'Berhasil')"
                    cmd.CommandType = CommandType.Text
                    cmd.CommandText = qInsert
                    cmd.Connection = conn
                    cmd.ExecuteNonQuery()

                    MsgBox("Simpan Berhasil", MsgBoxStyle.Information, "information")
                    tampildata()

                    statusinput(False, True, False, False, False, False, True, False, False, True, True, False, False, False, False)
                    kondisi_bersih_detail()
                    total_bayar()
                    txtIdMenu.Focus()

                Catch ex As Exception
                    MsgBox("Gagal Simpan" + ex.Message, MsgBoxStyle.Critical, "Terjadi Kesalahan")
                End Try

                KoneksiTutup()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtPembayaran_TextChanged(sender As Object, e As EventArgs) Handles txtPembayaran.TextChanged
        Try
            txtKembalian.Text = Val(txtPembayaran.Text) - Val(txtTotalBayar.Text)
        Catch ex As Exception
            txtKembalian.Text = "0"
        End Try
    End Sub


    Private Sub btnProses_Click(sender As Object, e As EventArgs) Handles btnProses.Click
        If txtNamaPelanggan.Text = "" Then
            MsgBox("Nama Pelanggan Harus diisi", MsgBoxStyle.Information, "Information")
            txtIdMenu.Focus()
            Exit Sub
        ElseIf cmbNoMeja.Text = "" Then
            MsgBox("No Meja Harus dipilih", MsgBoxStyle.Information, "Information")
            txtNamaMenu.Focus()
            Exit Sub
        End If

        Try
            KoneksiBuka()

            Dim qInsert As String
            qInsert = "insert into transaksi (id_transaksi, tanggal_transaksi, waktu_transaksi, nama_pelanggan, no_meja, username, diskon, total_bayar, pembayaran, kembalian) VALUES ('" & txtIdTransaksi.Text & "', '" & lblTanggal.Text & "', '" & lblWaktu.Text & "','" & txtNamaPelanggan.Text & "', '" & cmbNoMeja.Text & "','" & lblUsername.Text & "', '" & cmbDiskon.Text & "', '" & txtTotalBayar.Text & "','" & txtPembayaran.Text & "', '" & txtKembalian.Text & "')"
            cmd.CommandType = CommandType.Text
            cmd.CommandText = qInsert
            cmd.Connection = conn
            cmd.ExecuteNonQuery()

            MsgBox("Simpan Berhasil", MsgBoxStyle.Information, "information")
            tampildata()
            kurangi_stok()

            statusinput(False, True, False, False, False, False, True, False, False, True, True, False, False, False, False)
            kondisi_bersih_detail()
            bersih_transaksi()
            kondisi_bersih_transaksi()
            bersih_grid()
            NoFaktur()

        Catch ex As Exception
            MsgBox("Gagal Simpan" + ex.Message, MsgBoxStyle.Critical, "Terjadi Kesalahan")
        End Try
    End Sub

    Private Sub dgvTransaksi_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTransaksi.CellClick
        Try
            Dim i As Integer
            i = Me.dgvTransaksi.CurrentRow.Index
            With dgvTransaksi.Rows.Item(i)
                txtIdMenu.Text = .Cells(0).Value
                txtNamaMenu.Text = .Cells(1).Value
                txtKategori.Text = .Cells(2).Value
                txtStok.Text = .Cells(3).Value
                txtHargaJual.Text = .Cells(4).Value
                txtQTY.Text = .Cells(5).Value
                txtTotalHarga.Text = .Cells(6).Value
            End With
            total_bayar()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If txtIdMenu.Text = "" Then
            MsgBox("Pilih Menu yang akan Di Edit", MsgBoxStyle.Information, "information")
            dgvTransaksi.Focus()
        Else
            Try
                KoneksiBuka()
                Dim qUpdate As String
                qUpdate = "UPDATE detail_transaksi SET id_menu='" & txtIdMenu.Text & "', qty='" & txtQTY.Text & "', total_harga='" & txtTotalHarga.Text & "' where id_menu = '" & txtIdMenu.Text & "'"

                cmd.CommandType = CommandType.Text
                cmd.CommandText = qUpdate
                cmd.Connection = conn
                cmd.ExecuteNonQuery()

                MsgBox("Edit Berhasil", MsgBoxStyle.Information, "information")
                tampildata()
                total_bayar()
                kondisi_bersih_detail()

            Catch ex As Exception
                MsgBox("Gagal Simpan Ubah" + ex.Message, MsgBoxStyle.Critical, "Terjadi Kesalahan")
            End Try
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If txtIdMenu.Text = "" Then
            MsgBox("Pilih Menu yang akan Dihapus", MsgBoxStyle.Information, "information")
            dgvTransaksi.Focus()
        Else
            If MsgBox("Hapus Menu?", MsgBoxStyle.YesNo, "Pertanyaan") = Windows.Forms.DialogResult.Yes Then
                Try
                    KoneksiBuka()
                    Dim qDelete As String
                    qDelete = "delete from detail_transaksi where id_menu='" & txtIdMenu.Text & "' "
                    cmd.CommandType = CommandType.Text
                    cmd.CommandText = qDelete
                    cmd.Connection = conn
                    cmd.ExecuteNonQuery()

                    MsgBox("Hapus Berhasil", MsgBoxStyle.Information, "information")
                    tampildata()

                    kondisi_bersih_detail()
                    dgvTransaksi.Focus()
                Catch ex As Exception
                    MsgBox("Hapus Gagal", MsgBoxStyle.Information, "information")
                End Try
            End If
        End If
    End Sub


    Private Sub btnBatalMenu_Click(sender As Object, e As EventArgs) Handles btnBatalMenu.Click
        Try
            kondisi_bersih_detail()
            txtIdMenu.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Try
            If MsgBox("Batalkan Transaksi?", MsgBoxStyle.YesNo, "Pertanyaan") = Windows.Forms.DialogResult.Yes Then
                kondisi_bersih_detail()
                bersih_transaksi()
                kondisi_bersih_transaksi()
                bersih_grid()
                hapus_grid()

                txtNamaPelanggan.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub timeTransaksi_Tick(sender As Object, e As EventArgs) Handles timeTransaksi.Tick
        lblWaktu.Text = Format(Now, "HH:mm:ss")
    End Sub

    Private Sub cmbDiskon_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDiskon.SelectedIndexChanged
        Try
            Try
                txtTotalBayar.Text = Val(txtTotalBayar.Text) * Val(100 - cmbDiskon.Text) / 100
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub txtPembayaran_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPembayaran.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub
End Class