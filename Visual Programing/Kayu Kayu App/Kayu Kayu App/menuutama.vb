Public Class menuutama

    Private Sub menuutama_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            PanelUtama.Controls.Clear()
            home.TopLevel = False
            PanelUtama.Controls.Add(home)
            home.Show()
        Catch ex As Exception
            MsgBox("Terjadi kesalahan! " & ex.Message)
        End Try
    End Sub

    Private Sub btnHomepage_Click(sender As Object, e As EventArgs) Handles btnHomepage.Click
        Try
            PanelUtama.Controls.Clear()
            home.TopLevel = False
            PanelUtama.Controls.Add(home)
            home.Show()
        Catch ex As Exception
            MsgBox("Terjadi kesalahan! " & ex.Message)
        End Try
    End Sub

    Private Sub btnPegawai_Click(sender As Object, e As EventArgs) Handles btnPegawai.Click
        Try
            PanelUtama.Controls.Clear()
            pegawai.TopLevel = False
            PanelUtama.Controls.Add(pegawai)
            pegawai.Show()
        Catch ex As Exception
            MsgBox("Terjadi kesalahan! " & ex.Message)
        End Try
    End Sub

    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        Try
            PanelUtama.Controls.Clear()
            menukonter.TopLevel = False
            PanelUtama.Controls.Add(menukonter)
            menukonter.Show()
        Catch ex As Exception
            MsgBox("Terjadi kesalahan! " & ex.Message)
        End Try
    End Sub

    Private Sub btnKonter_Click(sender As Object, e As EventArgs) Handles btnKonter.Click
        Try
            PanelUtama.Controls.Clear()
            konter.TopLevel = False
            PanelUtama.Controls.Add(konter)
            konter.Show()
        Catch ex As Exception
            MsgBox("Terjadi kesalahan! " & ex.Message)
        End Try
    End Sub

    Private Sub btnRefund_Click(sender As Object, e As EventArgs) Handles btnRefund.Click
        Try
            PanelUtama.Controls.Clear()
            refund.TopLevel = False
            PanelUtama.Controls.Add(refund)
            refund.Show()
        Catch ex As Exception
            MsgBox("Terjadi kesalahan! " & ex.Message)
        End Try
    End Sub

    Private Sub btnLaporan_Click(sender As Object, e As EventArgs) Handles btnLaporan.Click
        Try
            PanelUtama.Controls.Clear()
            laporan.TopLevel = False
            PanelUtama.Controls.Add(laporan)
            laporan.Show()
        Catch ex As Exception
            MsgBox("Terjadi kesalahan! " & ex.Message)
        End Try
    End Sub

    Private Sub btnTransaksi_Click(sender As Object, e As EventArgs) Handles btnTransaksi.Click
        Try
            PanelUtama.Controls.Clear()
            transaksi.TopLevel = False
            PanelUtama.Controls.Add(transaksi)
            transaksi.Show()
        Catch ex As Exception
            MsgBox("Terjadi kesalahan! " & ex.Message)
        End Try
    End Sub


    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        If MsgBox("Yakin Keluar Dari Aplikasi", MsgBoxStyle.OkCancel, "Warning") = Windows.Forms.DialogResult.OK Then
            Me.Close()
            login.Close()
        Else
            Me.Show()
        End If
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Try
            Me.WindowState = FormWindowState.Minimized
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Try
            If MsgBox("Tutup Aplikasi", MsgBoxStyle.YesNo, "Information") = MsgBoxResult.Yes Then
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        
    End Sub

    Private Sub btnAbout_Click(sender As Object, e As EventArgs) Handles btnAbout.Click
        Try
            PanelUtama.Controls.Clear()
            about.TopLevel = False
            PanelUtama.Controls.Add(about)
            about.Show()
        Catch ex As Exception
            MsgBox("Terjadi kesalahan! " & ex.Message)
        End Try
    End Sub
    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        Try
            PanelUtama.Controls.Clear()
            help.TopLevel = False
            PanelUtama.Controls.Add(help)
            help.Show()
        Catch ex As Exception
            MsgBox("Terjadi kesalahan! " & ex.Message)
        End Try
    End Sub
End Class
