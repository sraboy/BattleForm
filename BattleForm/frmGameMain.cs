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
    public partial class frmGameMain : Form
    {
        //bool fullscreen = false;


        public frmGameMain()
        {
            this.Size = new Size(660, 480);
            clsGame Game = new clsGame(this);
            clsGame.level.LoadLevel("world-1");
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(!clsGame.player.inmotion)
            {
                switch (e.KeyCode)
                {
                    case Keys.Up:
                        clsGame.player.MoveUp();
                        clsEvent.CheckEncounter(clsGame.player.TilePosition, clsGame.player.direction);
                        break;
                    case Keys.Down:
                        clsGame.player.MoveDown();
                        break;
                    case Keys.Left:
                        clsGame.player.MoveLeft();
                        break;
                    case Keys.Right:
                        clsGame.player.MoveRight();
                        break;
                    //case Keys.F:
                    //    if (!fullscreen)
                    //    {
                    //        this.FormBorderStyle = FormBorderStyle.None;
                    //        this.WindowState = FormWindowState.Maximized;
                    //    }
                    //    else if (fullscreen == true)
                    //    {
                    //        this.FormBorderStyle = FormBorderStyle.Sizable;
                    //        this.WindowState = FormWindowState.Normal;
                    //        //this.MinimizeBox = true;
                    //        //this.MaximizeBox = true;
                    //        this.Size = new Size(640, 480);
                    //        this.Refresh();
                    //    }
                    //    break;
                    case Keys.Escape:
                        this.Close();
                        break;
                }
            }

            this.Text = "Current Position: " + clsGame.player.position.ToString();
            this.Text += " --- Tile Positon: " + '(' + clsGame.player.TilePosition.X + ',' + clsGame.player.TilePosition.Y + ')';
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.UserPaint, true);
            
        }

        /// <summary>
        /// Gives us a black background when the method is empty
        /// </summary>
        /// <param name="e">Color to paint</param>
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            //base.OnPaintBackground(e);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Quit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                e.Cancel = true;
        }
    }
}