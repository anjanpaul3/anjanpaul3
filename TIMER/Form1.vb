Public Class Form1
    Private CT As Integer = 0
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        CT = CT + 1
        Label1.Text = Now.ToString("dd-MMMM-yyyy hh:mm:ss tt" & "    " & CT)
    End Sub
End Class
