Imports Form_Login.koneksi
Imports MySql.Data.MySqlClient

Public Class Detail_Transaksi

    Private Sub Detail_Transaksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

        query = "select * from detail_transaksi"
        adapter = New MySqlDataAdapter(query, conn)
        dt = New DataTable
        data = adapter.Fill(dt)

        If data > 0 Then
            tabeldetailtransaksi.DataSource = dt
            tabeldetailtransaksi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            tabeldetailtransaksi.Columns(0).HeaderText = "id_detail_transaksi"
            tabeldetailtransaksi.Columns(1).HeaderText = "id_transaksi"
            tabeldetailtransaksi.Columns(2).HeaderText = "no_meja"
            tabeldetailtransaksi.Columns(3).HeaderText = "qty"
            tabeldetailtransaksi.Columns(4).HeaderText = "diskon"
            tabeldetailtransaksi.Columns(5).HeaderText = "total_bayar"
        Else
            tabeldetailtransaksi.DataSource = Nothing
        End If
    End Sub

    Sub hapus_isi()
        tDetail.Clear()
        tTransaksi.Clear()
        tMeja.Clear()
        tQty.Clear()
        tDiskon.Clear()
        tTotal.Clear()
    End Sub

    Private Sub statusinput(detail As Boolean, transaksi As Boolean, meja As Boolean, qty As Boolean, diskon As Boolean, total As Boolean)
        tDetail.Enabled = detail
        tTransaksi.Enabled = transaksi
        tMeja.Enabled = meja
        tQty.Enabled = qty
        tDiskon.Enabled = diskon
        tTotal.Enabled = total
    End Sub

    Private Sub statustombol(tambah As Boolean, hapus As Boolean, ubah As Boolean)
        bTambah.Enabled = tambah
        bHapus.Enabled = hapus
        bUbah.Enabled = ubah
    End Sub

    Private Sub bTambah_Click(sender As Object, e As EventArgs) Handles bTambah.Click
        If bTambah.Text = "&Tambah" Then
            statusinput(True, True, True, True, True, True)
            statustombol(True, True, False)
            bTambah.Text = "Simpan"
            bHapus.Text = "Batal"
        ElseIf bTambah.Text = "Simpan" Then
            If tDetail.Text = "" Then
                MsgBox("ID Detail Harus diisi", MsgBoxStyle.Information, "Information")
                tDetail.Focus()
                Exit Sub
            ElseIf tTransaksi.Text = "" Then
                MsgBox("ID Transaksi Harus diisi", MsgBoxStyle.Information, "Information")
                tTransaksi.Focus()
                Exit Sub
            ElseIf tMeja.Text = "" Then
                MsgBox("No Meja Harus diisi", MsgBoxStyle.Information, "Information")
                tMeja.Focus()
                Exit Sub
            ElseIf tQty.Text = "" Then
                MsgBox("Quantity Harus diisi", MsgBoxStyle.Information, "Information")
                tQty.Focus()
                Exit Sub
            ElseIf tDiskon.Text = "" Then
                MsgBox("Jika Ada Harus diisi", MsgBoxStyle.Information, "Information")
                tDiskon.Focus()
                Exit Sub
            ElseIf tTotal.Text = "" Then
                MsgBox("Total Harus diisi", MsgBoxStyle.Information, "Information")
                tTotal.Focus()
                Exit Sub
            End If

            'conn.Open()
            Try
                Dim qInsert As String
                qInsert = "insert into detail_transaksi (id_detail_transaksi, id_transaksi, no_meja, qty, diskon, total_bayar)"
                qInsert = qInsert & "VALUES('" & tDetail.Text & "', '" & tTransaksi.Text & "', '" & tMeja.Text & "', '" & tQty.Text & "', '" & tDiskon.Text & "', '" & tTotal.Text & "')"
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
            statusinput(False, True, True, True, True, True)
        ElseIf bUbah.Text = "&Simpan" Then
            Try
                Dim qUpdate As String
                qUpdate = "UPDATE detail_transaksi SET id_transaksi='" & tTransaksi.Text & "', no_meja='" & tMeja.Text & "', qty='" & tQty.Text & "', diskon='" & tDiskon.Text & "', total_bayar='" & tTotal.Text & "' where id_detail_transaksi='" & tDetail.Text & "' "

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

    Private Sub tabeldetailtransaksi_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles tabeldetailtransaksi.CellContentClick
        Dim i As Integer
        i = Me.tabeldetailtransaksi.CurrentRow.Index
        'MsgBox("baris ke : " & i.ToString, MsgBoxStyle.Information, "informasi")
        'tNim.Text = tabelpegawai.Rows.Item(i).Cells(0).Value
        With tabeldetailtransaksi.Rows.Item(i)
            tDetail.Text = .Cells(0).Value
            tTransaksi.Text = .Cells(1).Value
            tMeja.Text = .Cells(2).Value
            tQty.Text = .Cells(3).Value
            tDiskon.Text = .Cells(4).Value
            tTotal.Text = .Cells(5).Value
        End With
        statustombol(True, True, True)
    End Sub

    Private Sub bHapus_Click(sender As Object, e As EventArgs) Handles bHapus.Click
        If bHapus.Text = "&Hapus" Then
            'If MsgBox("Yakin Mau Dihapus?", MsgBoxStyle.YesNo, "Pertanyaan") = MsgBoxResult.Yes.Yes Then
            If MsgBox("Yakin Mau Dihapus?", MsgBoxStyle.YesNo, "Pertanyaan") = Windows.Forms.DialogResult.Yes Then
                Try
                    Dim qDelete As String
                    qDelete = "delete from detail_transaksi where id_detail_transaksi='" & tDetail.Text & "' "
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