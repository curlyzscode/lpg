Imports MySql.Data.MySqlClient
Imports Kayu_Kayu_App.koneksi

Public Class konter
    Private Sub statusinput(idkonter As Boolean, nama As Boolean, owner As Boolean, nik As Boolean, alamat As Boolean, nohp As Boolean)
        txtIdKonter.Enabled = idkonter
        txtNamaKonter.Enabled = nama
        txtOwner.Enabled = owner
        txtNik.Enabled = nik
        txtAlamat.Enabled = alamat
        txtNoHp.Enabled = nohp
    End Sub

    Private Sub statustombol(tambah As Boolean, simpan As Boolean, edit As Boolean, hapus As Boolean, batal As Boolean)
        btnTambah.Enabled = tambah
        btnSimpan.Enabled = simpan
        btnEdit.Enabled = edit
        btnHapus.Enabled = hapus
        btnBatal.Enabled = batal
    End Sub

    Sub kondisi_bersih()
        txtIdKonter.Clear()
        txtNamaKonter.Clear()
        txtOwner.Clear()
        txtNik.Clear()
        txtAlamat.Clear()
        txtNoHp.Clear()
    End Sub

    Private Sub tampildata()
        Dim dt As DataTable
        Dim adapter As MySqlDataAdapter
        Dim query As String
        Dim data As Integer

        query = "select id_konter, nama_konter, owner, nik, alamat, no_hp from konter "
        adapter = New MySqlDataAdapter(query, conn)
        dt = New DataTable
        data = adapter.Fill(dt)

        If data > 0 Then
            dgvKonter.DataSource = dt
            dgvKonter.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            dgvKonter.Columns(0).HeaderText = "ID Konter"
            dgvKonter.Columns(1).HeaderText = "Nama Konter"
            dgvKonter.Columns(2).HeaderText = "Owner"
            dgvKonter.Columns(3).HeaderText = "NIK"
            dgvKonter.Columns(4).HeaderText = "Alamat"
            dgvKonter.Columns(5).HeaderText = "No HP"
        Else
            dgvKonter.DataSource = Nothing
        End If
    End Sub

    Private Sub konter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        KoneksiBuka()
        tampildata()

        statusinput(False, False, False, False, False, False)
        statustombol(True, True, True, True, True)
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        statustombol(False, True, False, False, True)
        statusinput(True, True, True, True, True, True)
        txtIdKonter.Focus()
    End Sub


    Private Sub txtNoHp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNoHp.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub

    Private Sub txtNik_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNik.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If txtIdKonter.Text = "" Then
            MsgBox("ID Konter Harus diisi", MsgBoxStyle.Information, "Information")
            txtIdKonter.Focus()
            Exit Sub
        ElseIf txtNamaKonter.Text = "" Then
            MsgBox("Nama Konter Harus diisi", MsgBoxStyle.Information, "Information")
            txtNamaKonter.Focus()
            Exit Sub
        ElseIf txtOwner.Text = "" Then
            MsgBox("Nama Owner harus diisi", MsgBoxStyle.Information, "Information")
            txtOwner.Focus()
            Exit Sub
        ElseIf txtNik.Text = "" Then
            MsgBox("NIK Owner Harus diisi", MsgBoxStyle.Information, "Information")
            txtNik.Focus()
            Exit Sub
        ElseIf txtAlamat.Text = "" Then
            MsgBox("Alamat Harus diisi", MsgBoxStyle.Information, "Information")
            txtAlamat.Focus()
            Exit Sub
        ElseIf txtNoHp.Text = "" Then
            MsgBox("No HP Harus diisi", MsgBoxStyle.Information, "Information")
            txtNoHp.Focus()
            Exit Sub
        End If

        Try
            Dim qInsert As String
            qInsert = "insert into konter (id_konter, nama_konter, owner, nik, alamat, no_hp) VALUES ('" & txtIdKonter.Text & "', '" & txtNamaKonter.Text & "', '" & txtOwner.Text & "', '" & txtNik.Text & "','" & txtAlamat.Text & "', '" & txtNoHp.Text & "')"
            cmd.CommandType = CommandType.Text
            cmd.CommandText = qInsert
            cmd.Connection = conn
            cmd.ExecuteNonQuery()

            MsgBox("Simpan Berhasil", MsgBoxStyle.Information, "information")
            tampildata()

            statustombol(True, True, True, True, True)
            statusinput(False, False, False, False, False, False)
            kondisi_bersih()
        Catch ex As Exception
            MsgBox("Gagal Simpan" + ex.Message, MsgBoxStyle.Critical, "Terjadi Kesalahan")
        End Try
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If btnEdit.Text = "&Edit" Then
            btnEdit.Text = "&Simpan"

            statustombol(False, False, True, False, True)
            statusinput(False, True, True, True, True, True)

        ElseIf btnEdit.Text = "&Simpan" Then
            btnEdit.Text = "&Edit"
            Try
                Dim qUpdate As String
                qUpdate = "UPDATE konter SET id_konter='" & txtIdKonter.Text & "', nama_konter='" & txtNamaKonter.Text & "', owner ='" & txtOwner.Text & "', nik='" & txtNik.Text & "', alamat='" & txtAlamat.Text & "', no_hp='" & txtNoHp.Text & "' where id_konter='" & txtIdKonter.Text & "'"

                cmd.CommandType = CommandType.Text
                cmd.CommandText = qUpdate
                cmd.Connection = conn
                cmd.ExecuteNonQuery()

                MsgBox("Simpan Setelah Di Edit Berhasil", MsgBoxStyle.Information, "information")
                tampildata()

                statustombol(True, True, True, True, True)
                statusinput(False, False, False, False, False, False)
                kondisi_bersih()

            Catch ex As Exception
                MsgBox("Gagal Simpan Ubah" + ex.Message, MsgBoxStyle.Critical, "Terjadi Kesalahan")
            End Try
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If MsgBox("Yakin Mau Dihapus?", MsgBoxStyle.YesNo, "Pertanyaan") = Windows.Forms.DialogResult.Yes Then
            Try
                Dim qDelete As String
                qDelete = "delete from konter where id_konter='" & txtIdKonter.Text & "' "
                cmd.CommandType = CommandType.Text
                cmd.CommandText = qDelete
                cmd.Connection = conn
                cmd.ExecuteNonQuery()

                MsgBox("Hapus Berhasil", MsgBoxStyle.Information, "information")
                tampildata()

                statusinput(False, False, False, False, False, False)
                kondisi_bersih()
            Catch ex As Exception
                MsgBox("Hapus Gagal", MsgBoxStyle.Information, "information")
            End Try
        End If
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Try
            If btnEdit.Text = "&Simpan" Then
                btnEdit.Text = "&Edit"

            End If

            tampildata()
            txtCari.Text = ""
            statustombol(True, True, True, True, True)
            statusinput(False, False, False, False, False, False)
            kondisi_bersih()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        
    End Sub

    Private Sub dgvKonter_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvKonter.CellClick
        Dim i As Integer
        i = Me.dgvKonter.CurrentRow.Index
        With dgvKonter.Rows.Item(i)
            txtIdKonter.Text = .Cells(0).Value
            txtNamaKonter.Text = .Cells(1).Value
            txtOwner.Text = .Cells(2).Value
            txtNik.Text = .Cells(3).Value
            txtAlamat.Text = .Cells(4).Value
            txtNoHp.Text = .Cells(5).Value
        End With
    End Sub

    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        If txtCari.Text = "" Then
            MsgBox("Parameter tidak boleh kosong", MsgBoxStyle.Critical, "Info")
            txtCari.Focus()
        Else
            Try
                Dim qSearch As String
                qSearch = "select * from konter where nama_konter like '%" & txtCari.Text & "%'"
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
                        dgvKonter.AutoGenerateColumns = False
                        dgvKonter.DataSource = dt
                    End If
                End Using
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
End Class