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
namespace BattleForm
{
    partial class frmGameMain
    {
        #region Windows Garbage
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        #endregion
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // GameMain
            // 
            this.ClientSize = new System.Drawing.Size(652, 453);
            this.DoubleBuffered = true;
            this.Name = "GameMain";
            this.Text = "Edjimon 2.0";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);

        }
        #endregion

        void Form1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            clsGame.CalculateBorders();
            //for (int x = 0; x <= clsGame.map.width; x++)
            for (int x = 0; x <= clsGame.bottomright.X / 30; x++)
            {
                //for (int y = 0; y <= clsGame.map.height; y++)
                for (int y = 0; y <= clsGame.bottomright.Y / 30; y++)
                {
                    e.Graphics.DrawImage(clsGame.map.TileImages[clsGame.map.Tiles[x, y] - 1], new System.Drawing.Point(x * 30 - (int)clsGame.player.position.X + 300, y * 30 - (int)clsGame.player.position.Y + 240));
                    
                    /* Write TilePosition to tile
                     * e.Graphics.DrawString(x.ToString() + ',' + y.ToString(), this.Font, new System.Drawing.SolidBrush(System.Drawing.Color.Yellow),new System.Drawing.PointF(x*30, y*30));
                     */
                }
            }

            e.Graphics.DrawImage(clsGame.player.SpriteImage[(int)clsGame.player.direction, clsGame.player.frame], new System.Drawing.PointF(300, 240));// clsGame.player.position);
            //e.Graphics.DrawImage(clsGame.johnson.CurrentImage, new System.Drawing.PointF((int)((clsGame.johnson.position.X * 30) - clsGame.player.position.X + 300), (int)((clsGame.johnson.position.Y * 30) - clsGame.johnson.position.Y + 240)));
            //e.Graphics.DrawImage(clsGame.johnson.CurrentImage, new System.Drawing.PointF(360,240));//(int)(clsGame.johnson.position.X), (int)(clsGame.johnson.position.Y)));
           }
        
    }
}

