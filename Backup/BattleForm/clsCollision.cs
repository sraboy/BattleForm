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
    /// The only real physics in this game is checking for a 2-D collision.
    /// </summary>
    public class clsCollision
    {
        public bool Allow(clsSprite.dir direction)
        {
            if (clsGame.inbattle == true)
                return false;
            else
            {
                //TODO: Figure out why I'm walking on some trees. Something about the +1/-1 math crap.
                switch (direction)
                {
                    case clsSprite.dir.Up:
                        //make sure tile above is on the map
                        if (clsGame.player.TilePosition.Y + 1 == (int)0)
                            return false;
                        //now make sure that tile is passable
                        if (clsGame.map.passable[clsGame.player.TilePosition.X, clsGame.player.TilePosition.Y])
                            return true;
                        else return false;
                    case clsSprite.dir.Down:
                        //make sure tile below is on the map
                        if (clsGame.player.TilePosition.Y == (clsGame.map.height - 1))
                            return false;
                        //now make sure that tile is passable
                        if (clsGame.map.passable[clsGame.player.TilePosition.X, clsGame.player.TilePosition.Y + 1])
                            return true;
                        else return false;
                    case clsSprite.dir.Left:
                        //make sure tile left is on map
                        if (clsGame.player.TilePosition.X == (int)0)
                            return false;
                        //now make sure tile is passable
                        if (clsGame.map.passable[clsGame.player.TilePosition.X - 1, clsGame.player.TilePosition.Y + 1])
                            return true;
                        else return false;
                    case clsSprite.dir.Right:
                        //make sure tile left is on map
                        if (clsGame.player.TilePosition.X == (clsGame.map.width))
                            return false;
                        //now make sure tile is passable
                        if (clsGame.map.passable[clsGame.player.TilePosition.X + 1, clsGame.player.TilePosition.Y + 1])
                            return true;
                        else return false;
                }
            }

            return false;
        }
    }
}
