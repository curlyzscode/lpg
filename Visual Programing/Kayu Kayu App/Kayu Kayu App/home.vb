Public Class home

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        lblJam.Text = TimeOfDay
    End Sub

    Private Sub home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblUsername.Text = login.txtUsername.Text
    End Sub
End Class