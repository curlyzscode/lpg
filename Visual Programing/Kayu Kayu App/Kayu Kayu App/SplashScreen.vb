Public Class SplashScreen

    Private Sub timerSplashScreen_Tick(sender As Object, e As EventArgs) Handles timerSplashScreen.Tick
        If timerSplashScreen.Interval = 6000 Then
            login.Show()
            Me.Close()
            timerSplashScreen.Stop()
        End If
    End Sub

    Private Sub SplashScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        timerSplashScreen.Start()
    End Sub
End Class