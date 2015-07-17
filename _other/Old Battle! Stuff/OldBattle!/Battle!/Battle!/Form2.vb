Public Class Form2

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Form1.imgPlayer1.Image = PictureBox1.Image
        Form1.tolPlayer1.Image = PictureBox1.Image
        arrPlayerName(1) = InputBox("Name your Edjimon.", "What do you want your Edjimon's name to be?", "Edjimon")

        arrPlayerSpeed(1) = Int(Rnd() * 11) + 5
        arrPlayerAttack(1) = Int(Rnd() * 11) + 5
        arrPlayerDefense(1) = Int(Rnd() * 11) + 5
        arrPlayerHealth(1) = 12
        arrPlayerLevel(1) = 1
        arrCurrentHealth(1) = arrPlayerHealth(1)
        Form1.Button1.Enabled = True
        Form1.tolPlayer1.Text = arrPlayerName(1)
        Form1.tolPlayer1.ToolTipText = arrPlayerName(1) & vbNewLine & "LVL: " & arrPlayerLevel(1)
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Form1.imgPlayer1.Image = PictureBox2.Image
        Form1.tolPlayer1.Image = PictureBox2.Image
        arrPlayerName(1) = InputBox("Name your Edjimon.", "What do you want your Edjimon's name to be?", "Edjimon")

        arrPlayerSpeed(1) = Int(Rnd() * 11) + 5
        arrPlayerAttack(1) = Int(Rnd() * 11) + 5
        arrPlayerDefense(1) = Int(Rnd() * 11) + 5
        arrPlayerHealth(1) = 12
        arrPlayerLevel(1) = 1
        arrCurrentHealth(1) = arrPlayerHealth(1)
        Form1.Button1.Enabled = True
        Form1.tolPlayer1.Text = arrPlayerName(1)
        Form1.tolPlayer1.ToolTipText = arrPlayerName(1) & vbNewLine & "LVL: " & arrPlayerLevel(1)
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        Form1.imgPlayer1.Image = PictureBox3.Image
        Form1.tolPlayer1.Image = PictureBox3.Image
        arrPlayerName(1) = InputBox("Name your Edjimon.", "What do you want your Edjimon's name to be?", "Edjimon")

        arrPlayerSpeed(1) = Int(Rnd() * 11) + 5
        arrPlayerAttack(1) = Int(Rnd() * 11) + 5
        arrPlayerDefense(1) = Int(Rnd() * 11) + 5
        arrPlayerHealth(1) = 12
        arrPlayerLevel(1) = 1
        arrCurrentHealth(1) = arrPlayerHealth(1)
        Form1.Button1.Enabled = True
        Form1.tolPlayer1.Text = arrPlayerName(1)
        Form1.tolPlayer1.ToolTipText = arrPlayerName(1) & vbNewLine & "LVL: " & arrPlayerLevel(1)

        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class