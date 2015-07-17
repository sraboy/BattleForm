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
    public class clsSprite
    {
        #region Globals
        public PointF position;// = new PointF(10 * clsGame.tilewidth, 8 * clsGame.tileheight);
        public String folder;
        public int frame;
        public Single multiplier = 1; //if this is a decimal, position must be rounded
        private int sframe;

        //Each sprite has 4 directions
        public const int numberofdirections = 4;
        //Each sprite has 3 motion frames
        public const int numberofframes = 3;

        //Which way the sprite faces
        public enum dir
        {
            Up = 0,
            Down = 1,
            Left = 2,
            Right = 3
        };

        public dir direction;
        public String spritename;
        public Bitmap[,] SpriteImage = new Bitmap[numberofdirections, numberofframes];
        public bool inmotion;
        #endregion

        #region Properties
        public Point TilePosition
        {
            get
            {
                return new Point((int)Math.Floor(position.X / clsGame.tilewidth), (int)Math.Floor(position.Y / clsGame.tileheight));
            }
        }
        #endregion

        /// <summary>
        /// Creates a new sprite with the ability to move and animate.
        /// </summary>
        /// <param name="nameofsprite">The name of the sprite to be created.</param>
        public clsSprite(string nameofsprite, PointF startpos)
        {
            this.position.X = startpos.X * clsGame.tilewidth;
            this.position.Y = startpos.Y * clsGame.tileheight;
            int currentdirection;
            int currentframe;

            for (currentdirection = 0; currentdirection < numberofdirections; currentdirection++)
            {
                for (currentframe = 0; currentframe < numberofframes; currentframe++)
                {
                    SpriteImage[currentdirection,currentframe] = new Bitmap("sprites\\" + nameofsprite.ToString() + "\\" + ReturnDirection(currentdirection).ToString() + (currentframe + 1) + ".gif"); /*(currentdirection, currentframe)*/
                    SpriteImage[currentdirection, currentframe].MakeTransparent(Color.Lime);
                }
            }
        }
        
        /// <summary>
        /// Cycle through frames in the sprite.
        /// </summary>
        public void Animate()
        {
            sframe += 1;
            if (sframe == 9)
            {
                sframe = 0;
                frame += 1;
                if (frame == 3)
                    frame = 0;
            }
        }

        #region Movement Methods
        public void MoveUp()
        {
            direction = dir.Up;
            this.Animate();
            clsGame.GameForm.Invalidate();

            if (clsGame.physics.Allow(dir.Up))
            {
                clsEvent.CheckEncounter(clsGame.player.TilePosition, clsGame.player.direction);
                if (!inmotion)
                {
                    inmotion = true;

                    for (int x = 1; x <= (clsGame.tileheight * multiplier); x++)
                    {
                        //move up one tile
                        position.Y -= (1 / multiplier);
                        this.Animate();
                        //Check for keypress and refresh form
                        System.Windows.Forms.Application.DoEvents();
                        clsGame.GameForm.Invalidate();
                    }
                    inmotion = false;
                }
            }
        }
        public void MoveDown()
        {
            direction = dir.Down;
            this.Animate();
            clsGame.GameForm.Invalidate();

            if (clsGame.physics.Allow(dir.Down))
            {
                clsEvent.CheckEncounter(clsGame.player.TilePosition, clsGame.player.direction);
                if (!inmotion)
                {
                    inmotion = true;

                    for (int x = 1; x <= (clsGame.tileheight * multiplier); x++)
                    {
                        //move up one tile
                        position.Y += (1 / multiplier);
                        this.Animate();
                        //Check for keypress and refresh form
                        System.Windows.Forms.Application.DoEvents();
                        clsGame.GameForm.Invalidate();
                    }
                    inmotion = false;
                }
            }
        }
        public void MoveLeft()
        {
            direction = dir.Left;
            this.Animate();
            clsGame.GameForm.Invalidate();

            if (clsGame.physics.Allow(dir.Left))
            {
                clsEvent.CheckEncounter(clsGame.player.TilePosition, clsGame.player.direction);
                if (!inmotion)
                {
                    inmotion = true;

                    for (int x = 1; x <= (clsGame.tilewidth * multiplier); x++)
                    {
                        //move up one tile
                        position.X -= (1 / multiplier);
                        this.Animate();
                        //Check for keypress and refresh form
                        System.Windows.Forms.Application.DoEvents();
                        clsGame.GameForm.Invalidate();
                    }
                    inmotion = false;
                }
            }
        }
        public void MoveRight()
        {
            direction = dir.Right;
            this.Animate();
            clsGame.GameForm.Invalidate();

            if (clsGame.physics.Allow(dir.Right))
            {
                clsEvent.CheckEncounter(clsGame.player.TilePosition, clsGame.player.direction);
                if (!inmotion)
                {
                    inmotion = true;

                    for (int x = 1; x <= (clsGame.tilewidth * multiplier); x++)
                    {
                        //move up one tile
                        position.X += (1 / multiplier);
                        this.Animate();
                        //Check for keypress and refresh form
                        System.Windows.Forms.Application.DoEvents();
                        clsGame.GameForm.Invalidate();
                    }
                    inmotion = false;
                }
            }
        }
        #endregion

        protected string ReturnDirection(int currentdirection)
        {
            switch ((dir)currentdirection)
            {
                case dir.Up:
                    return "up";
                case dir.Down:
                    return "down";
                case dir.Right:
                    return "right";
                case dir.Left:
                    return "left";
                default:
                    throw new ArgumentException("ReturnValue() requires a value from 'dir'");
            }
                
        }


    }
}
