﻿using System;
using System.Collections.Generic;
using System.Text;
using Sprint0.Interfaces;
using Sprint0.Sprites.SpriteFactory;

namespace Sprint0.Commands
{
    class CFixedSprite : ICommand
    {

        private static Game0 gameHere;

        public CFixedSprite(Game0 game)
        {
            gameHere = game;
        }
        
        public void Execute()
        {
          //  gameHere.sprite = SpriteFactory.Instance.GetSprite("GoldDoggo");
        }
    }
}
