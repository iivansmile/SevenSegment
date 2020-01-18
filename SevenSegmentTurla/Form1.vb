Public Class Form1
    Dim Second As Int32 = -1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Second = Second + 1
        If (Second = 1) Then
            Button1.BackColor = Color.White
            Button2.BackColor = Color.White
            Button3.BackColor = Color.Blue
            Button4.BackColor = Color.Blue
            Button5.BackColor = Color.White
            Button6.BackColor = Color.White
            Button7.BackColor = Color.White
        ElseIf (Second = 2) Then
            Button1.BackColor = Color.Blue
            Button2.BackColor = Color.White
            Button3.BackColor = Color.Blue
            Button4.BackColor = Color.White
            Button5.BackColor = Color.Blue
            Button6.BackColor = Color.Blue
            Button7.BackColor = Color.Blue

        ElseIf (Second = 3) Then
            Button1.BackColor = Color.Blue
            Button2.BackColor = Color.White
            Button3.BackColor = Color.Blue
            Button4.BackColor = Color.Blue
            Button5.BackColor = Color.White
            Button6.BackColor = Color.Blue
            Button7.BackColor = Color.Blue

        ElseIf (Second = 4) Then
            Button1.BackColor = Color.White
            Button2.BackColor = Color.Blue
            Button3.BackColor = Color.Blue
            Button4.BackColor = Color.Blue
            Button5.BackColor = Color.White
            Button6.BackColor = Color.White
            Button7.BackColor = Color.Blue

        ElseIf (Second = 5) Then
            Button1.BackColor = Color.Blue
            Button2.BackColor = Color.Blue
            Button3.BackColor = Color.White
            Button4.BackColor = Color.Blue
            Button5.BackColor = Color.White
            Button6.BackColor = Color.Blue
            Button7.BackColor = Color.Blue

        ElseIf (Second = 6) Then
            Button1.BackColor = Color.Blue
            Button2.BackColor = Color.Blue
            Button3.BackColor = Color.White
            Button4.BackColor = Color.Blue
            Button5.BackColor = Color.Blue
            Button6.BackColor = Color.Blue
            Button7.BackColor = Color.Blue

        ElseIf (Second = 7) Then
            Button1.BackColor = Color.Blue
            Button2.BackColor = Color.Blue
            Button3.BackColor = Color.Blue
            Button4.BackColor = Color.Blue
            Button5.BackColor = Color.White
            Button6.BackColor = Color.White
            Button7.BackColor = Color.White

        ElseIf (Second = 8) Then
            Button1.BackColor = Color.Blue
            Button2.BackColor = Color.Blue
            Button3.BackColor = Color.Blue
            Button4.BackColor = Color.Blue
            Button5.BackColor = Color.Blue
            Button6.BackColor = Color.Blue
            Button7.BackColor = Color.Blue

        ElseIf (Second = 9) Then
            Button1.BackColor = Color.Blue
            Button2.BackColor = Color.Blue
            Button3.BackColor = Color.Blue
            Button4.BackColor = Color.Blue
            Button5.BackColor = Color.White
            Button6.BackColor = Color.Blue
            Button7.BackColor = Color.Blue

        Else
            Button1.BackColor = Color.Blue
            Button2.BackColor = Color.Blue
            Button3.BackColor = Color.Blue
            Button4.BackColor = Color.Blue
            Button5.BackColor = Color.Blue
            Button6.BackColor = Color.Blue
            Button7.BackColor = Color.White
            Second = 0
        End If
    End Sub
End Class
