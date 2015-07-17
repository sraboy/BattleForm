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
    public class clsTrainer : clsSprite
    {
        public clsEdjimon[] edjimon = new clsEdjimon[6];

        public clsTrainer(string nameofsprite, PointF startpos) : base(nameofsprite, startpos)
        {
            for (int x = 0; x < 6; x++)
            {
                edjimon[x] = new clsEdjimon();
            }

            //HACK: Load this data from save_game file
            edjimon[0].number = "001";
            edjimon[0].name = "Treep";
            edjimon[0].type = clsBattle.type.grass;
            edjimon[0].currentHP = 17;
            edjimon[0].currentlevel = 1;
            edjimon[0].attacks[0] = "Punch";
            edjimon[0].maxHP = 17;
            edjimon[0].currentHP = 17;
            edjimon[0].attack = 6;
            edjimon[0].defense = 10;
            edjimon[0].accuracy = 50;
            edjimon[0].cel = 10;

            //TODO: clsTrainer - need to add ability to swap edjimon out of order
        }
    }
}
