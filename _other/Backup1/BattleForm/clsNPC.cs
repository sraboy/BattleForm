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
using System.Drawing;

namespace BattleForm
{
    public class clsNPC
    {
        public Point position;
        public Bitmap[] spriteimage = new Bitmap[4];
        public string folder;
        public clsSprite.dir direction;
        
        public Bitmap CurrentImage
        {
            get
            {
                return spriteimage[0];
            }
        }

        public clsNPC(string imagefolder, Point pos, clsSprite.dir defaultdirection, string dialogloc)
        {
            this.position = pos;
            this.folder = imagefolder;
            this.direction = defaultdirection;
            Load(imagefolder);
        }

        public void Load(string imagefolder)
        {
            //up = 0, down = 1, left = 2, right =3

            spriteimage[0] = new Bitmap("NPCs\\" + imagefolder + "\\up.bmp");
            spriteimage[1] = new Bitmap("NPCs\\" + imagefolder + "\\down.bmp");
            spriteimage[2] = new Bitmap("NPCs\\" + imagefolder + "\\left.bmp");
            spriteimage[3] = new Bitmap("NPCs\\" + imagefolder + "\\right.bmp");

            for (int x = 0; x <= 3; x++)
            {
                spriteimage[x].MakeTransparent(Color.Lime);
            }
        }

        public void UpdateMap()
        {
            clsGame.map.passable[(int)this.position.X, (int)this.position.Y] = false;
        }
    }
}
