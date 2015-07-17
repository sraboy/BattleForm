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
    /// Represents an encounter with an opponent, a battle with either a trainer or wild Edjimon.
    /// </summary>
    public class clsBattle
    {
        private frmBattle BattleForm;
        public static clsEdjimon B_player, B_enemy;

        /// <summary>
        /// The type of the Edjimon dictates abilities and defenses.
        /// </summary>
        public enum type
        {
            normal = 0,
            grass = 1,
            fire = 2,
            water = 3,
            electric = 4,
            toxic = 5,
            ice = 6,
            metal = 7,
            rock = 8,
            airborne = 9,
            psychic = 10,
            undead = 11
        }

        public clsBattle(clsEdjimon player, clsEdjimon enemy)
        {
            B_player = player;
            B_enemy = enemy;

            BattleForm = new frmBattle(player, enemy);
            BattleForm.Show();
            BattleForm.Cycle(player, enemy, 0);
        }

        public static bool DoDamage(int hp_loss, ref clsEdjimon receiver)
        {
            receiver.currentHP -= hp_loss;

            //This tells the player if there was any damage. The form has the difference
            //of whether you did damage or he did.
            //HACK: This won't work for Sleep, Paralyze, etc when no damage is done.
                //possibly use another function for non-HP damage?           
            if (hp_loss == 0)
                return false;
            else return true;

            //TODO: hp_loss < 0, subtract damage from active edjimon
        }
    }
}
