public class ChooseFirst {
    
    private void PictureBox1_Click(object sender, System.EventArgs e) {
        Main.imgPlayer1.Image = PictureBox1.Image;
        Main.tolPlayer1.Image = PictureBox1.Image;
        arrPlayerName(1) = InputBox("Name your Edjimon.", "What do you want your Edjimon\'s name to be?", "Edjimon");
        arrPlayerSpeed(1) = (Int((Rnd() * 11)) + 5);
        arrPlayerAttack(1) = (Int((Rnd() * 11)) + 5);
        arrPlayerDefense(1) = (Int((Rnd() * 11)) + 5);
        arrPlayerHealth(1) = 12;
        arrPlayerLevel(1) = 1;
        arrCurrentHealth(1) = arrPlayerHealth(1);
        Main.Button1.Enabled = true;
        Main.tolPlayer1.Text = arrPlayerName(1);
        Main.tolPlayer1.ToolTipText = (arrPlayerName(1) + ("\r\n" + ("LVL: " + arrPlayerLevel(1))));
        this.Hide();
        Main.Show();
    }
    
    private void PictureBox2_Click(object sender, System.EventArgs e) {
        Main.imgPlayer1.Image = PictureBox2.Image;
        Main.tolPlayer1.Image = PictureBox2.Image;
        arrPlayerName(1) = InputBox("Name your Edjimon.", "What do you want your Edjimon\'s name to be?", "Edjimon");
        arrPlayerSpeed(1) = (Int((Rnd() * 11)) + 5);
        arrPlayerAttack(1) = (Int((Rnd() * 11)) + 5);
        arrPlayerDefense(1) = (Int((Rnd() * 11)) + 5);
        arrPlayerHealth(1) = 12;
        arrPlayerLevel(1) = 1;
        arrCurrentHealth(1) = arrPlayerHealth(1);
        Main.Button1.Enabled = true;
        Main.tolPlayer1.Text = arrPlayerName(1);
        Main.tolPlayer1.ToolTipText = (arrPlayerName(1) + ("\r\n" + ("LVL: " + arrPlayerLevel(1))));
        this.Hide();
        Main.Show();
    }
    
    private void PictureBox3_Click(object sender, System.EventArgs e) {
        Main.imgPlayer1.Image = PictureBox3.Image;
        Main.tolPlayer1.Image = PictureBox3.Image;
        arrPlayerName(1) = InputBox("Name your Edjimon.", "What do you want your Edjimon\'s name to be?", "Edjimon");
        arrPlayerSpeed(1) = (Int((Rnd() * 11)) + 5);
        arrPlayerAttack(1) = (Int((Rnd() * 11)) + 5);
        arrPlayerDefense(1) = (Int((Rnd() * 11)) + 5);
        arrPlayerHealth(1) = 12;
        arrPlayerLevel(1) = 1;
        arrCurrentHealth(1) = arrPlayerHealth(1);
        Main.Button1.Enabled = true;
        Main.tolPlayer1.Text = arrPlayerName(1);
        Main.tolPlayer1.ToolTipText = (arrPlayerName(1) + ("\r\n" + ("LVL: " + arrPlayerLevel(1))));
        this.Hide();
        Main.Show();
    }
    
    private void Form2_Load(object sender, System.EventArgs e) {
    }
}

