/*  - Copyright 2007 
    - Steven Lavoie 
    - axessterminated@gmail.com
    - www.etheism.org
    This program is free software and may be used and distributed as outlined
    by the CodeProject Open License 1.0, found here: 
    http://www.codeproject.com/info/cpol10.aspx.
  
    The main points subject to the terms of the License are:
    * Source Code and Executable Files can be used in commercial applications;
    * Source Code and Executable Files can be redistributed; and
    * Source Code can be modified to create derivative works.
    * No claim of suitability, guarantee, or any warranty whatsoever is provided. The software is provided "as-is".
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BattleForm
{
    public partial class frmBattle : Form
    {
        public string picPlayer, picEnemy;
        public clsEdjimon edPlayer, edEnemy;
        private bool player_turn = false;

        public frmBattle(clsEdjimon edPlayer, clsEdjimon edEnemy)
        {
            InitializeComponent();
            this.pictureboxEnemy.Image = System.Drawing.Image.FromFile("img_edjimon\\" + edEnemy.name + ".bmp");
            this.pictureboxPlayer.Image = System.Drawing.Image.FromFile("img_edjimon\\" + edPlayer.name + ".bmp");
            this.lblEnemyName.Text = edEnemy.name;
            this.lblPlayerName.Text = edPlayer.name;
            this.lblEnemyType.Text = edEnemy.type.ToString();
            this.lblPlayerType.Text = edPlayer.type.ToString();
            this.pbEnemyHP.Maximum = edEnemy.maxHP;
            this.pbEnemyHP.Value = edEnemy.currentHP;
            this.pbPlayerHP.Maximum = edPlayer.maxHP;
            this.pbPlayerHP.Value = edPlayer.currentHP;

            this.edEnemy = edEnemy;
            this.edPlayer = edPlayer;
            clsGame.inbattle = true;

            if (edEnemy.speed < edPlayer.speed)
                player_turn = true;

            #region Write Button Text
            if (edPlayer.attacks[0] != "null")
            {
                btnAttack1.Enabled = true;
                btnAttack1.Visible = true;
                btnAttack1.Text = edPlayer.attacks[0];
            }
            if (edPlayer.attacks[1] != "null")
            {
                btnAttack2.Enabled = true;
                btnAttack2.Visible = true;
                btnAttack2.Text = edPlayer.attacks[1];
            }
            if (edPlayer.attacks[2] != "null")
            {
                btnAttack3.Enabled = true;
                btnAttack3.Visible = true;
                btnAttack3.Text = edPlayer.attacks[2];
            }
            if (edPlayer.attacks[3] != "null")
            {
                btnAttack4.Enabled = true;
                btnAttack4.Visible = true;
                btnAttack4.Text = edPlayer.attacks[3];
            }
            #endregion
        }

        /// <summary>
        /// Represents a turn in battle.
        /// </summary>
        /// <param name="edPlayer">The player's Edjimon.</param>
        /// <param name="edEnemy">The enemy's Edjimon.</param>
        /// <param name="playermove">What number move the player is using. ?CHECK THIS?</param>
        public void Cycle(clsEdjimon edPlayer, clsEdjimon edEnemy, int playermove)
        {            
            if (edEnemy.currentHP > 0 && edPlayer.currentHP > 0)
            {
                //if enemy gets first hit
                //HACK: Fix this. Why check speed AND player_turn? Speed should set player_turn.
                if (edEnemy.speed > edPlayer.speed && player_turn == false)
                {
                    //HACK: Random selection of enemy attack is inadequate. FIX ME
                    Random pickattack = new Random(System.DateTime.Today.Millisecond);
                    int attacktodo = 0;

                    for (int x = 0; x < 4; x++)
                    {
                        //The 99 is preceded with "null:" in the Edjimon's data.
                        //It means the Edjimon does not have a move for that slot.
                        if ((int)edEnemy.attack_types[x] != 99)
                        {
                            attacktodo = pickattack.Next(0, x);
                        }
                        else
                            break;
                    }

                    if (clsBattle.DoDamage(clsAttack.Attack(edEnemy.attack_types[attacktodo], edPlayer.type, edPlayer.accuracy, edEnemy.cel/*, true*/), ref clsBattle.B_player))
                        MessageBox.Show("He hit you!");
                    else
                        MessageBox.Show("He missed!");

                    pbPlayerHP.Value = edPlayer.currentHP;
                    pbEnemyHP.Value = edEnemy.currentHP;
                    Refresh();

                    //HACK: Speed + 100? May work permanently
                    /* After each attack, the opponent's speed increases by 100
                     * This is linear, and it makes sure the opponent has the next turn
                     */
                    clsBattle.B_player.speed += 100;
                    player_turn = true;

                    while (clsGame.inbattle == true && player_turn == false)
                    {
                        //it doesn't matter what you send to Cycle(x,x,HERE) for the enemy's attack
                        Cycle(edPlayer, edEnemy, 0);
                        //Set the HP bars on the window.
                        pbPlayerHP.Value = edPlayer.currentHP;
                        pbEnemyHP.Value = edEnemy.currentHP;
                        Refresh();
                    }
                }
            }
            else
            {
                clsGame.inbattle = false;

                //TODO: Save edjimon data back to player and opponent(if trainer)
                MessageBox.Show("Battle Done!");
                this.Close();
            }
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFlee_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yay!");
        }

        private void btnAttack1_Click(object sender, EventArgs e)
        {
            if (clsBattle.DoDamage(clsAttack.Attack(edPlayer.attack_types[0], edEnemy.type, edPlayer.accuracy, edEnemy.cel/*, false*/), ref clsBattle.B_enemy))
                MessageBox.Show("You hit him!");
            else
                MessageBox.Show("You missed!");
            clsBattle.B_enemy.speed += 100;
            player_turn = false;
            this.pbPlayerHP.Value = edPlayer.currentHP;
            this.pbEnemyHP.Value = edEnemy.currentHP;
            this.Refresh();
            Cycle(edPlayer, edEnemy, 0);
        }

        private void lblAttack_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not Implemented Yet: Show attack statistics");
        }
    }
}