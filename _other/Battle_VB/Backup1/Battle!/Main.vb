Public Class Main

    'Private Sub cmdMap_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdMap.Click
    '    frmMap.Show()
    'End Sub

    Private Sub cmdWalknorth_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdWalkNorth.Click
        NorthClicks = NorthClicks + 1
        TierDetermine()
        MonsterDetermine()
        MapSpot()
        Label1.Text = NorthClicks
        Label4.Text = EastClicks
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        NorthClicks = 37
        EastClicks = 43
        Randomize()
        ChooseFirst.ShowDialog()
    End Sub

    Private Sub cmdwalkwest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdWalkWest.Click
        EastClicks = EastClicks - 1
        TierDetermine()
        MonsterDetermine()
        MapSpot()
        Label1.Text = NorthClicks
        Label4.Text = EastClicks
    End Sub

    Private Sub cmdWalkEast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdWalkEast.Click
        EastClicks = EastClicks + 1
        TierDetermine()
        MonsterDetermine()
        MapSpot()
        Label1.Text = NorthClicks
        Label4.Text = EastClicks
    End Sub

    Private Sub cmdWalkSouth_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdWalkSouth.Click
        NorthClicks = NorthClicks - 1
        TierDetermine()
        MonsterDetermine()
        MapSpot()
        Label1.Text = NorthClicks
        Label4.Text = EastClicks
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Stats.Show()
    End Sub

    Private Sub EndToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EndToolStripMenuItem.Click
        End
    End Sub

    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click
        SaveFileDialog1.ShowDialog()

    End Sub

    Private Sub imgToasti_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub MenuStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub
End Class



