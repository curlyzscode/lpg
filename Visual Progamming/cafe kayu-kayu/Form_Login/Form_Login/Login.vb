Imports Form_Login.koneksi
Imports MySql.Data.MySqlClient

Public Class Login

    Private Sub masuk_Click(sender As Object, e As EventArgs) Handles masuk.Click
        Try
            Call KoneksiBuka()
            Dim str As String
            str = "select * from user where username = ' " & txtUSer.Text & " ' and password = ' " & txtPass.Text & " '"

            CMD = New MySqlCommand(str, conn)
            RD = CMD.ExecuteReader

            If RD.HasRows Then
                MessageBox.Show("Welcome", "informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            Else
                RD.Close()
                MessageBox.Show("Login Gagal", "gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtUSer.Text = ""
                txtPass.Text = ""

                txtUSer.Focus()
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
