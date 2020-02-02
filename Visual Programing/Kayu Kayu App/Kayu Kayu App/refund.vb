Imports MySql.Data.MySqlClient
Imports Kayu_Kayu_App.koneksi

Public Class refund

    Private Sub statusinput(idtransaksi As Boolean, idmenu As Boolean, namamenu As Boolean, qty As Boolean, harga As Boolean, totalharga As Boolean, nominal As Boolean, statustransaksi As Boolean, ketrefund As Boolean, username As Boolean)
        txtIdTransaksi.Enabled = idtransaksi
        txtIdMenu.Enabled = idmenu
        txtNamaMenu.Enabled = namamenu
        txtQTY.Enabled = qty
        txtHarga.Enabled = harga
        TxtTotalHarga.Enabled = totalharga
        txtNominalRefund.Enabled = nominal
        cmbStatusTransaksi.Enabled = statustransaksi
        txtKetRefund.Enabled = ketrefund
        txtUsername.Enabled = username
    End Sub

    Sub kondisi_bersih()
        txtIdTransaksi.Clear()
        txtIdMenu.Clear()
        txtNamaMenu.Clear()
        txtQTY.Clear()
        txtHarga.Clear()
        TxtTotalHarga.Clear()
        txtNominalRefund.Clear()
        cmbStatusTransaksi.Text = ""
        txtKetRefund.Clear()
    End Sub

    Private Sub refund_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        KoneksiBuka()
        tampildatafull()

        txtUsername.Text = home.lblUsername.Text

        statusinput(False, False, False, False, False, False, False, False, False, False)

    End Sub

    Private Sub tampildatafull()
        Try
            KoneksiBuka()

            Dim dt As DataTable
            Dim adapter As MySqlDataAdapter
            Dim query As String
            Dim data As Integer

            query = "select id_transaksi, id_menu, nama_menu, qty, harga_jual, total_harga, status_transaksi from detail_transaksi where status_transaksi = 'Berhasil'"
            adapter = New MySqlDataAdapter(query, conn)
            dt = New DataTable
            data = adapter.Fill(dt)

            If data > 0 Then
                dgvRefund.DataSource = dt
                dgvRefund.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                dgvRefund.Columns(0).HeaderText = "ID Transaksi"
                dgvRefund.Columns(1).HeaderText = "ID Menu"
                dgvRefund.Columns(2).HeaderText = "Nama Menu"
                dgvRefund.Columns(3).HeaderText = "QTY"
                dgvRefund.Columns(4).HeaderText = "Harga"
                dgvRefund.Columns(5).HeaderText = "Total Harga"
                dgvRefund.Columns(6).HeaderText = "Status Transaksi"
            Else
                dgvRefund.DataSource = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub


    Private Sub txtIdTransaksi_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIdTransaksi.KeyPress
        Try
            If e.KeyChar = Chr(13) Then
                    KoneksiBuka()
                    Try
                        Dim qSearch As String
                        qSearch = "select * from detail_transaksi where id_transaksi = '" & txtIdTransaksi.Text & "'"
                        cmd.CommandType = CommandType.Text
                        cmd.CommandText = qSearch
                        cmd.Connection = conn

                        rd = cmd.ExecuteReader

                        Using dt As New DataTable
                            dt.Load(rd)
                        If dt.Rows.Count = 0 Then
                            MsgBox("Data tidak Ditemukan", MsgBoxStyle.Information, "Information")
                        Else
                            dgvRefund.AutoGenerateColumns = False
                            dgvRefund.DataSource = dt
                        End If
                        End Using
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dgvRefund_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRefund.CellClick
        Dim i As Integer
        i = Me.dgvRefund.CurrentRow.Index
        With dgvRefund.Rows.Item(i)
            txtIdMenu.Text = .Cells(1).Value
            txtNamaMenu.Text = .Cells(2).Value
            txtQTY.Text = .Cells(3).Value
            txtHarga.Text = .Cells(4).Value
            TxtTotalHarga.Text = .Cells(5).Value
            cmbStatusTransaksi.Text = .Cells(6).Value
        End With
    End Sub

    Private Sub txtQTY_TextChanged(sender As Object, e As EventArgs) Handles txtQTY.TextChanged
        Try
            TxtTotalHarga.Text = Val(txtHarga.Text) * Val(txtQTY.Text)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        statusinput(True, False, False, True, False, False, True, True, True, False)
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If txtQTY.Text = "" Then
            MsgBox("QTY Harus diisi", MsgBoxStyle.Information, "Information")
            txtQTY.Focus()
            Exit Sub
        ElseIf txtNominalRefund.Text = "" Then
            MsgBox("No Meja Harus diisi", MsgBoxStyle.Information, "Information")
            txtNominalRefund.Focus()
            Exit Sub
        ElseIf cmbStatusTransaksi.Text = "" Then
            MsgBox("Status Transaksi Harus dipilih", MsgBoxStyle.Information, "Information")
            cmbStatusTransaksi.Focus()
            Exit Sub
        ElseIf txtKetRefund.Text = "" Then
            MsgBox("Keterangan Refund Harus diisi", MsgBoxStyle.Information, "Information")
            txtKetRefund.Focus()
            Exit Sub
        End If

        Try
            KoneksiBuka()

            Dim qInsert As String
            qInsert = "insert into refund (id_transaksi, id_menu, nama_menu, qty, harga_jual, total_harga, nominal_refund, status_transaksi, ket_refund, username, waktu_refund) VALUES ('" & txtIdTransaksi.Text & "', '" & txtIdMenu.Text & "', '" & txtNamaMenu.Text & "','" & txtQTY.Text & "', '" & txtHarga.Text & "','" & TxtTotalHarga.Text & "', '" & txtNominalRefund.Text & "', '" & cmbStatusTransaksi.Text & "','" & txtKetRefund.Text & "', '" & txtUsername.Text & "', '" & Format(Now, "yyyy-MM-dd HH:mm:ss") & "')"
            cmd.CommandType = CommandType.Text
            cmd.CommandText = qInsert
            cmd.Connection = conn
            cmd.ExecuteNonQuery()

            Dim qUpdate As String
            qUpdate = "UPDATE detail_transaksi SET qty='" & txtQTY.Text & "', total_harga='" & TxtTotalHarga.Text & "', status_transaksi='" & cmbStatusTransaksi.Text & "' where id_menu = '" & txtIdMenu.Text & "'"
            cmd.CommandType = CommandType.Text
            cmd.CommandText = qUpdate
            cmd.Connection = conn
            cmd.ExecuteNonQuery()
            

            MsgBox("Simpan dan Update Berhasil", MsgBoxStyle.Information, "information")
            tampildatafull()

            statusinput(False, False, False, False, False, False, False, False, False, False)
            kondisi_bersih()

        Catch ex As Exception
            MsgBox("Gagal Simpan" + ex.Message, MsgBoxStyle.Critical, "Terjadi Kesalahan")
        End Try
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        statusinput(False, False, False, False, False, False, False, False, False, False)
        kondisi_bersih()
    End Sub

    Private Sub txtQTY_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQTY.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub

    Private Sub txtNominalRefund_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNominalRefund.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub
End Class