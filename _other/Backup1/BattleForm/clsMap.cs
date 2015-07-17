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
    /// <summary>
    /// This class is the physical map you walk on.
    /// It reads the map files to find tiles and
    /// reads information regarding whether or not a
    /// tile is passable.
    /// </summary>
    public class clsMap
    {
        System.IO.StreamReader sr;
        public int width, height;
        public Bitmap[] TileImages;
        public int[,] Tiles;
        public bool[,] passable;
        public bool[] walkable;

        public clsMap(string mapname, string tileset)
        {
            ReadMap(mapname, tileset);
        }

        private void ReadMap(string mapname, string tileset)
        {
            sr = new System.IO.StreamReader("maps\\" + mapname);
            int y, x,typesoftiles;
            string ln = sr.ReadLine();
            string[] str, line, line2; //why do we have line1 and line2? Try getting rid of one

            str = ln.Split(',');
            width = System.Convert.ToInt32(str[0]) - 1;
            height = System.Convert.ToInt32(str[1]) - 1;
            Tiles = new int[width + 1, height + 1];

            passable = new bool[width + 1, height + 1];
            typesoftiles = System.Convert.ToInt32(sr.ReadLine());
            walkable = new bool[typesoftiles];
            TileImages = new Bitmap[typesoftiles];

            /* This will read in the information
             * about whether or not a tile is
             * passable.
             */
            while (ln != "#END LEGEND")
            {
                ln = sr.ReadLine();
                if (ln != "#LEGEND" && ln != "#END LEGEND")
                {
                    line2 = ln.Split('=');
                    walkable[System.Convert.ToInt32(line2[0]) - 1] = System.Convert.ToBoolean(line2[1]);
                    //walkable[1] = true;
                }
            }

            for (y = 0; y <= height; y++)
            {
                ln = sr.ReadLine();
                line = ln.Split(',');
                
                for (x = 0; x <= width; x++)
                {
                    Tiles[x, y] = Convert.ToInt32(line[x]);//new Bitmap("tiles\\" + tileset + "\\" + (line[currentcolumn]).ToString() + ".JPG");
                    passable[x, y] = walkable[System.Convert.ToInt32(line[x]) - 1 ];
                }
            }

            for (int z = 1; z <= typesoftiles; z++)
            {
                TileImages[z - 1] = new Bitmap("tiles\\" + tileset + "\\" + z.ToString() + ".JPG");
            }

        }

    }
}
