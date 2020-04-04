Public Class Form3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim hydra2 As Form2 = New Form2()
        Dim hydra1 As Form3 = New Form3()
        Dim hydra4 As Form4 = New Form4()

        hydra2.Show()
        hydra1.Show()
        hydra4.Show()
        Me.Hide()

        hydra2.Location = New Point(Rnd() * 350, Rnd() * 140)
        hydra1.Location = New Point(Rnd() * 740, Rnd() * 260)
        hydra4.Location = New Point(Rnd() * 560, Rnd() * 330)
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopMost = True
    End Sub

    Private Sub Form3_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        e.Cancel = True
    End Sub
End Class