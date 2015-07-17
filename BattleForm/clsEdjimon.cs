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
    /// Represents the creature, "Edjimon". This creature has stats dictating its abilities, hit points, speed, etc.
    /// </summary>
    public class clsEdjimon
    {

        #region Globals   
        //TODO: weight?

        /// <summary>
        /// Internal variable that specifies 0-5, where the Edjimon lies in the clsTrainer array.
        /// It is used in frmBattle when saving the information back to the game copy of the Edjimon.
        /// </summary>
        public int arraypos;

        /// <summary>
        /// The number represents the odds of seeing the Edjimon in the wild.
        /// 1: 89%
        /// 2: 10%
        /// 3: 1%
        /// </summary>
        //TODO: Add another level at 50%-60% ?
        public int rarity;
        
        /// <summary>
        /// Experience points add up so an Edjimon may increase in level and therefore their stats increase.
        /// </summary>
        public int experience;
        
        /// <summary>
        /// Used for wild Edjimon. Dictates lowest level that can be encountered on that map.
        /// </summary>
        public int minlevel;
        
        /// <summary>
        /// Used for wild Edjimon. Dictates highest level that can be encountered on that map.
        /// </summary>
        public int maxlevel;

        /// <summary>
        /// The current level of the Edjimon. The level dictates the stats.
        /// </summary>
        public int currentlevel;

        /// <summary>
        /// If the Edjimon's HP is full, this is what it will be.
        /// This increases with level.
        /// </summary>
        public int maxHP;
        
        /// <summary>
        /// The current HP.
        /// This increases with level.
        /// </summary>
        public int currentHP;
        
        /// <summary>
        /// The attack rating calculated by a formula based on level.
        /// This increases with level.
        /// </summary>
        public int attack;

        /// <summary>
        /// The defense rating calculated by a formula based on level.
        /// This increases with level.
        /// </summary>
        public int defense;

        /// <summary>
        /// The speed rating calculated by a formula based on level.
        /// This determines who goes first in a battle.
        /// This increases with level.
        /// </summary>
        public int speed;

        /// <summary>
        /// The accuracy rating calculated by a formula based on level.
        /// The higher the rating, the less likely the Edjimon is to miss his opponent.
        /// This increases with level.
        /// </summary>
        public int accuracy;
        
        //TODO: levelup will be levelup[level]=exppoints_required
        /// <summary>
        /// Contains the experience points required to level up.
        /// The index equals the level and the value is the requirement for that level.
        /// </summary>
        public int[] levelup;

        /// <summary>
        /// The evasiveness rating calculated by a formula based on level.
        /// The higher the rating, the less likely the Edjimon is to miss his opponent.
        /// This increases with level.
        /// </summary>
        public int cel;

        //TODO: clsEdjimon - will contain the front and rear view for battle screen
        /// <summary>
        /// Contains the pictures for the battle screen.
        /// </summary>
        public System.Drawing.Bitmap[] pics;

        /// <summary>
        /// The actual name of the Edjimon as prescribed by the Edjidex.
        /// </summary>
        public string name;
        
        /// <summary>
        /// The user-defined nickname.
        /// This is not used for wild edjimon.
        /// </summary>
        public int nickname;
        
        /// <summary>
        /// The Edjidex-prescribed number for the Edjimon.
        /// It is a string so that it stays at 3 digits at all times.
        /// </summary>
        public string number;

        /// <summary>
        /// Edjimon have strengths and weaknesses based upon the attack type or Edjimon type.
        /// </summary>
        public clsBattle.type type;

        /// <summary>
        /// Defines the type of each of the attacks.
        /// </summary>
        public clsBattle.type[] attack_types = new clsBattle.type[4];

        /// <summary>
        /// The names of the attacks.
        /// </summary>
        public string[] attacks = new string[4];
        #endregion
        #region Edjimon File Format
        /* .edjimon file format
                001
                Treep
                Grass
                #LEVELS
                world1:3-6
                world2:4-27
                #END LEVELS
                #RARITY
                world1:1
                world2:2
                #END RARITY
                #BASE
                HP:15
                ATK:9
                DEF:8
                SPD:4
                ACC:5
                #END BASE
                #ATTACKS
                attack1
                attack2
                attack3
                attack4
                #END ATTACKS
             */
        #endregion

        /// <summary>
        /// Create a specific edjimon.
        /// </summary>
        /// <param name="num">Pass the number of the Edjimon so the information can be read from a .edjimon file.</param>
        public clsEdjimon(int num)
        {
            //CreateMe(num);
                        // Temporary variables used in reading information from .edjimon file
            string str;
            string[] str2 = new string[2];

            System.IO.StreamReader s = new System.IO.StreamReader("edjimon\\" + num.ToString() + ".edjimon");
            this.number = s.ReadLine();
            this.name = s.ReadLine();
            this.type = (clsBattle.type)Convert.ToInt32(s.ReadLine());

            while (!s.EndOfStream)
            {
                str = s.ReadLine();
                //TODO: Add parsing of semicolons for comments in scripting engine
                //TODO: Move scripting engine to its own class
                switch (str.Trim())
                {
                    case "#LEVELS":
                        str2 = s.ReadLine().Split(':');
                        if (str2[0] == clsGame.level.levelname)
                        {
                            str2 = str2[1].ToString().Split(',');
                            this.minlevel = Convert.ToInt32(str2[0]);
                            this.maxlevel = Convert.ToInt32(str2[1]);
                        }
                        break;
                    case "#RARITY":
                        str2 = s.ReadLine().Split(':');
                        if (str2[0] == clsGame.level.levelname)
                        {
                            this.rarity = Convert.ToInt32(str2[1]);
                        }
                        break;
                    case "#BASE":
                        str2 = s.ReadLine().Split(':');
                        this.maxHP = Convert.ToInt32(str2[1]);
                        this.currentHP = this.maxHP;
                        str2 = s.ReadLine().Split(':');
                        this.attack = Convert.ToInt32(str2[1]);
                        str2 = s.ReadLine().Split(':');
                        this.defense = Convert.ToInt32(str2[1]);
                        str2 = s.ReadLine().Split(':');
                        this.speed = Convert.ToInt32(str2[1]);
                        str2 = s.ReadLine().Split(':');
                        this.accuracy = Convert.ToInt32(str2[1]);
                        str2 = s.ReadLine().Split(':');
                        this.cel = Convert.ToInt32(str2[1]);
                        break;
                    case "#ATTACKS":
                        for (int x = 0; x < 4; x++)
                        {
                            str2 = s.ReadLine().Split(':');
                            this.attacks[x] = str2[0];
                            this.attack_types[x] = (clsBattle.type)Convert.ToInt32(str2[1]);
                        }
                        break;
                    case "#COMMENT":
                        str = s.ReadLine();
                        while (str != "#END COMMENT")
                            str = s.ReadLine();
                        break;
                }
            }
        }

        /// <summary>
        /// Create an edjimon.
        /// </summary>
        public clsEdjimon()
        {
        }

        //void CreateMe(int num)
        //{
        //    clsParser EdjimonReader = new clsParser();
        //    this = EdjimonReader.ParseEdjimon(num);
        //}
    }
}
