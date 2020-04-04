Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopMost = True
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        e.Cancel = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim hydra2 As Form2 = New Form2()
        Dim hydra3 As Form3 = New Form3()
        Dim hydra4 As Form4 = New Form4()

        hydra2.Show()
        hydra3.Show()
        hydra4.Show()
        Me.Hide()

        hydra2.Location = New Point(Rnd() * 350, Rnd() * 140)
        hydra3.Location = New Point(Rnd() * 740, Rnd() * 260)
        hydra4.Location = New Point(Rnd() * 560, Rnd() * 330)
    End Sub
End Class
