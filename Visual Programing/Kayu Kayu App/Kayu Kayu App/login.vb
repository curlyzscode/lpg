Imports MySql.Data.MySqlClient
Imports Kayu_Kayu_App.koneksi

Public Class login

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        KoneksiBuka()
        txtPassword.PasswordChar = "*"
        txtUsername.Clear()
        txtPassword.Clear()
    End Sub


    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        If txtUsername.Text = "" Or txtPassword.Text = "" Or cmbStatusLogin.SelectedItem = "" Then
            MsgBox("Data Belum Lengkap, Pastikan Semua Field Di Isi")
            Exit Sub

        Else
            If cmbStatusLogin.Text = "" Then cmbStatusLogin.Focus() : Exit Sub
            If txtUsername.Text = "" Then txtUsername.Focus() : Exit Sub
            If txtPassword.Text = "" Then txtPassword.Focus() : Exit Sub

            'perintah untuk mencari nama tertentu
            cmd = New MySqlCommand
            cmd.Connection = conn
            str = " SELECT username,password FROM user WHERE username= '" & txtUsername.Text & "' AND password = '" & txtPassword.Text & "' AND status = '" & cmbStatusLogin.Text & "'"
            cmd.CommandText = str

            rd = cmd.ExecuteReader

            If rd.HasRows = True And cmbStatusLogin.SelectedItem = "Admin" Then
                MessageBox.Show("Selamat Anda Berhasil Login Sebagai Admin", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                menuutama.Show()
                Me.Hide()
            ElseIf rd.HasRows = True And cmbStatusLogin.SelectedItem = "Pegawai" Then
                MessageBox.Show("Selamat Anda Berhasil Login Sebagai Pegawai", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                menuutama.Show()
                menuutama.btnMenu.Enabled = False
                menuutama.btnKonter.Enabled = False
                menuutama.btnPegawai.Enabled = False
                Me.Hide()
            Else
                'agar dapat mengulang ketika salah memasukkan username dan password
                cmd.Dispose()
                rd.Dispose()
                MessageBox.Show("Login Gagal, Username dan Password Tidak Sesuai", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                'hapus semua field
                txtPassword.Text = ""
                txtUsername.Text = ""

                'Focus di username
                txtUsername.Focus()
            End If
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

End Class