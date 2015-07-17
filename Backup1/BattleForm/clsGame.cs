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
using System.Text;
using System.Windows.Forms;

namespace BattleForm
{
    public class clsGame
    {
        public static Form GameForm = new Form();
        public static clsTrainer player = new clsTrainer("player", new System.Drawing.PointF(0, 0));
        public static clsLevel level = new clsLevel();
        public static clsMap map;
        public static clsCollision physics = new clsCollision();
        public const int tilewidth = 30;
        public const int tileheight = 30;
        public static bool inbattle = false;
        public static System.Drawing.Point topleft, bottomright;

        //public static clsNPC johnson = new clsNPC("Johnson", new System.Drawing.Point(0,0), clsSprite.dir.Up, "johnson.dlg");

        public clsGame(Form frm)
        {
            GameForm = frm;
            CalculateBorders();
        }
        public static void CalculateBorders()
        {
            if (map != null)
            {
                topleft.X = (int)(GameForm.Width - player.position.X);
                topleft.Y = (int)(GameForm.Height - player.position.Y);
                bottomright.X = (int)(GameForm.Width + player.position.X);
                bottomright.Y = (int)(GameForm.Height + player.position.Y);

                if (topleft.X < GameForm.Width)
                    topleft.X = GameForm.Width;
                if (topleft.Y < GameForm.Height)
                    topleft.Y = GameForm.Height;
                if (bottomright.X > map.width * 30)
                    bottomright.X = map.width * 30;
                if (bottomright.Y > map.height * 30)
                    bottomright.Y = map.height * 30;
            }
        }
    }
}
