public class Main {
    
    // Private Sub cmdMap_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdMap.Click
    //     frmMap.Show()
    // End Sub
    private void cmdWalknorth_Click(object sender, System.EventArgs e) {
        NorthClicks = (NorthClicks + 1);
        TierDetermine();
        MonsterDetermine();
        MapSpot();
        Label1.Text = NorthClicks;
        Label4.Text = EastClicks;
    }
    
    private void Form1_Load(object sender, System.EventArgs e) {
        NorthClicks = 37;
        EastClicks = 43;
        Randomize();
        ChooseFirst.ShowDialog();
    }
    
    private void cmdwalkwest_Click(object sender, System.EventArgs e) {
        EastClicks = (EastClicks - 1);
        TierDetermine();
        MonsterDetermine();
        MapSpot();
        Label1.Text = NorthClicks;
        Label4.Text = EastClicks;
    }
    
    private void cmdWalkEast_Click(object sender, System.EventArgs e) {
        EastClicks = (EastClicks + 1);
        TierDetermine();
        MonsterDetermine();
        MapSpot();
        Label1.Text = NorthClicks;
        Label4.Text = EastClicks;
    }
    
    private void cmdWalkSouth_Click(object sender, System.EventArgs e) {
        NorthClicks = (NorthClicks - 1);
        TierDetermine();
        MonsterDetermine();
        MapSpot();
        Label1.Text = NorthClicks;
        Label4.Text = EastClicks;
    }
    
    private void Button3_Click(object sender, System.EventArgs e) {
        Stats.Show();
    }
    
    private void EndToolStripMenuItem_Click(object sender, System.EventArgs e) {
    }
    
    private void SaveToolStripMenuItem_Click(object sender, System.EventArgs e) {
        SaveFileDialog1.ShowDialog();
    }
    
    private void imgToasti_Click(object sender, System.EventArgs e) {
    }
    
    private void MenuStrip1_ItemClicked(object sender, System.Windows.Forms.ToolStripItemClickedEventArgs e) {
    }
}

