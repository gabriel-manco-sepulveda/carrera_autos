Public Class Form1

    Dim dado1, dado2, dado3 As Integer

    Private Sub btncarrera_Click(sender As Object, e As EventArgs) Handles btncarrera.Click

        amarillo.Left = 0
        rosa.Left = 0
        verde.Left = 0

        Timer1.Enabled = True
        Timer2.Enabled = True
        Timer3.Enabled = True

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        dado1 = Math.Round(Rnd() * 25 + 5)
        amarillo.Left = amarillo.Left + dado1
        If amarillo.Left >= 550 Then

            Timer1.Enabled = False
            Timer2.Enabled = False
            Timer3.Enabled = False
            MsgBox("ganó el carro amarillo piloto Montoya")

        End If

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

        dado2 = Math.Round(Rnd() * 25 + 5)
        rosa.Left = rosa.Left + dado2
        If rosa.Left >= 550 Then

            Timer1.Enabled = False
            Timer2.Enabled = False
            Timer3.Enabled = False
            MsgBox("ganó el carro rosa piloto Schumacher")

        End If

    End Sub


    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick

        dado3 = Math.Round(Rnd() * 25 + 5)
        verde.Left = verde.Left + dado3
        If verde.Left >= 550 Then

            Timer1.Enabled = False
            Timer2.Enabled = False
            Timer3.Enabled = False
            MsgBox("ganó el carro verde piloto Raikkonen")

        End If

    End Sub


End Class
