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
    /// Represents an event in the game, such as changing maps or a battle.
    /// </summary>
    static class clsEvent
    {
        /// <summary>
        /// Contains the position the sprite is moving from
        /// </summary>
        static private PointF oldpos;

        static public void CheckEncounter(Point tilepos, clsSprite.dir dir)
        {
            string[] levelname = clsGame.level.levelname.ToString().Split('-');
            //TODO: check if tilepos is next to NPC

            //check for house
            if (levelname[0] == "world")
            {
                if (clsGame.player.TilePosition.Y != clsGame.map.height - 1)
                {
                    //check if tilepos is tall grass
                    //if so, check for Edjimon
                    //add 1 so the bottom tile of the sprite is used
                    if (clsGame.map.Tiles[clsGame.player.TilePosition.X, clsGame.player.TilePosition.Y + 1] == 1)
                    {
                        //if you found one
                        if (CheckEdjimon())
                        {
                            clsGame.inbattle = true;
                            clsEdjimon wildedjimon = DetermineEdjimon();
                            clsBattle b = new clsBattle(clsGame.player.edjimon[0], wildedjimon);
                            clsGame.inbattle = false;
                        }
                    }
                    if (clsGame.player.TilePosition.Y + 1 != 0 && dir == clsSprite.dir.Up && clsGame.map.Tiles[clsGame.player.TilePosition.X, clsGame.player.TilePosition.Y] == 16)
                    {
                        oldpos = tilepos;
                        clsGame.level.LoadLevel("house-1");
                        clsGame.player.inmotion = false;
                    }
                }
            }

            //try to leave house
            if (levelname[0] == "house" && clsGame.player.TilePosition.Y != clsGame.map.height)
            {
                //do individual house-X checks inside here

                switch(dir)
                {
                    case clsSprite.dir.Up:
                        if (clsGame.map.Tiles[clsGame.player.TilePosition.X, clsGame.player.TilePosition.Y] == 4)
                        {
                            clsGame.level.LoadLevel("world-1");
                            clsGame.player.position.X = oldpos.X * 30;
                            clsGame.player.position.Y = (oldpos.Y) * 30;
                            //clsGame.player.inmotion = false;
                        }
                        break;
                    case clsSprite.dir.Down:
                        if (clsGame.map.Tiles[clsGame.player.TilePosition.X, clsGame.player.TilePosition.Y + 2] == 4)
                        {
                            clsGame.level.LoadLevel("world-1");
                            clsGame.player.position.X = oldpos.X * 30;
                            clsGame.player.position.Y = (oldpos.Y) * 30;
                            //clsGame.player.inmotion = false;
                        }
                        break;
                }
            }
        }
        static private bool CheckEdjimon()
        {
            Random rand = new Random(DateTime.Now.Millisecond);
            //hardcoded 15% chance of finding Edjimon in grass
            if (rand.Next(1, 100) <= 15)
                return true;
            else
                return false;
        }
        static private clsEdjimon DetermineEdjimon()
        {
            //TODO: After determining which Edjimon you ecounter, get level and stats
                //Stats must be calculated from the level found in the .edjimon file.
            Random r = new Random();
            int ed = r.Next(0, clsGame.level.edjimon.Length - 1);
            return new clsEdjimon(clsGame.level.edjimon[ed]);
        }
    }
}
