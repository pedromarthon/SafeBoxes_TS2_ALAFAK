﻿Public Class SplashScreen
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Hide()
        Frm_Login.Show()
    End Sub
End Class