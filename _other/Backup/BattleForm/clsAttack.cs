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
using System.Collections;//.Generic;
using System.Text;

namespace BattleForm
{
    public static class clsAttack
    {
        /// <summary>
        /// This is a numerical representation of the attack
        /// matrix from the Edjipedia. The damage is either 
        /// half, full, or double depending on the types
        /// of the attacker and defender.
        /// </summary>
        public static double[,] typematrix = new double[12, 12]
        {
            {1,1,1,1,1,1,1,2,2,1,0.5,0.5},
            {1,1,2,1,0.5,0.5,1,1,1,2,1,1},
            {1,0.5,1,2,1,1,0.5,1,2,1,1,1},
            {1,1,0.5,1,2,2,1,1,0.5,1,1,1},
            {1,2,1,0.5,1,1,2,1,1,0.5,1,1},
            {1,2,1,0.5,1,1,1,0.5,1,1,1,2},
            {1,1,2,1,0.5,1,1,2,1,0.5,1,1},
            {0.5,1,1,1,1,2,0.5,1,1,1,2,1},
            {0.5,1,0.5,2,1,1,1,1,1,1,2,1},
            {1,0.5,1,1,2,1,2,1,1,1,1,0.5},
            {2,1,1,1,1,1,1,0.5,0.5,1,1,2},
            {2,1,1,1,1,0.5,1,1,1,2,0.5,1}
        };

        /// <summary>
        /// Determines the results of each attack in a battle.
        /// </summary>
        /// <param name="attacker">Type of the attacker's move</param>
        /// <param name="defender">Type of the defender</param>
        /// <param name="acc">Attacker's accuracy rating</param>
        /// <param name="cel">Defender's evasiveness rating</param>
        // /// <param name="wild">Wild Edjimon or trainer?</param>
        /// <returns>Amount of HP lost to defender. A negative number signifies Attacker's loss.</returns>
        public static int Attack(clsBattle.type attacker, clsBattle.type defender, int acc , int cel)// ,bool wild)
        {
            double hp_loss = 0;

            //TODO: Simulate emotion, weather, injuries with percentage.
            
            //The chance is simply based on weather
            double chance = ProbableAttack(/*see TODO at definition*/);

            /* Chance increases in a non-linear manner.
             * The more accurate the chance, the smaller the
             * effect of your accuracy rating has on the
             * attack hit possibility. Additionally, CEL value is
             * less and less effective as the accuracy increases.
             */
            chance += ((100 - chance) * ((double)acc / 100)); 
            chance -= ((100 - chance) * ((double)cel / 100));

            if (ProbableAttack() < (int)chance)
            {
                //custom formula to calculate HP lost in an attack
                hp_loss = (double)Math.Abs((decimal)((((clsBattle.B_enemy.attack - clsBattle.B_player.defense) * .5)) * (typematrix[(int)attacker, (int)defender])));
            }
            return (int)hp_loss;
        }


        private static int ProbableAttack()//TODO: Add 0-3 case check for percentage based on weather
        {
            //HACK: Use weather, not just 80%
            Random r = new Random(System.DateTime.Now.Millisecond);
            int x = (int)r.Next(80, 101);

            return x;
        }      

        //TODO: NegativeAttack() - Some attacks will hurt the attacker; determine those here.
    }
}
