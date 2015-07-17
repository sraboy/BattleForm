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

namespace BattleForm
{
    /// <summary>
    /// LVL file format:
    /// mapfile.map
    /// tilesetName
    /// PlayerStartTileX,PlayerStartTileY
    /// NPCs:2
    /// NPC_1_name, folderOfImages, x,y, direction, dialoguelocation
    /// NPC_2_name, folderOfImages, x,y, direction, dialoguelocation
    /// </summary>
    public class clsLevel
    {
        System.IO.StreamReader reader;
        public string levelname;
        public int[] edjimon;

        public void LoadLevel(string level)
        {
            this.levelname = level;
            reader = new System.IO.StreamReader("levels\\" + level + ".lvl");
            string map, tileset;
            map = reader.ReadLine();
            tileset = reader.ReadLine();
            clsGame.map = new clsMap(map, tileset);
            string[] s;
            //read position of player
            s = reader.ReadLine().Split(',');

            //since it's tilepos, mult by 30
            clsGame.player.position.X = Convert.ToInt32(s[0]) * 30;
            clsGame.player.position.Y = Convert.ToInt32(s[1]) * 30;

            //Read the amount of NPCs
            s = reader.ReadLine().Split(':');
            int numberOfNPCs;
            numberOfNPCs = Convert.ToInt32(s[1]);

            string dir;
            clsSprite.dir direction;
            //loop through to add each NPC
            for (int x = 0; x < numberOfNPCs; x++)
            {
                s = reader.ReadLine().Split(',');
                dir = s[4];

                switch (dir)
                {
                    case "Down":
                        direction = clsSprite.dir.Down;
                        break;
                    case "Up":
                        direction = clsSprite.dir.Up;
                        break;
                    case "Left":
                        direction = clsSprite.dir.Left;
                        break;
                    case "Right":
                        direction = clsSprite.dir.Right;
                        break;
                }                
            }

            //Read the amount of Edjimon
            s = reader.ReadLine().Split(':');
            if (s[1] != "0")
            {
                int numberofEdjimon;
                numberofEdjimon = Convert.ToInt32(s[1]);
                edjimon = new int[numberofEdjimon];

                s = reader.ReadLine().Split(',');

                for (int x = 0; x < numberofEdjimon; x++)
                {
                    edjimon[x] = Convert.ToInt32(s[x]);
                }
            }
            clsGame.GameForm.Invalidate();
            reader.Close();
        }
    }
}
