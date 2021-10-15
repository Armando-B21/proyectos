Public Class Form1
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Static a As Integer
        a = a + 1
        If a = 1 Then
            Label1.ForeColor = Color.Red
        ElseIf a = 2 Then
            Label1.ForeColor = Color.Blue
        ElseIf a = 3 Then
            Label1.ForeColor = Color.Orange
        ElseIf a = 4 Then
            Label1.ForeColor = Color.Yellow
        ElseIf a = 5 Then
            Label1.ForeColor = Color.Cyan
        ElseIf a = 6 Then
            Label1.ForeColor = Color.White
        ElseIf a >= 0 Then
            a = 0
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        End
    End Sub
End Class
