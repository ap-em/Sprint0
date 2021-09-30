﻿using Sprint0.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint0.Commands
{
    class CZeroPlayerYVelocity : ICommand
    {
        private Game0 gameHere;
        private string direction;
        public CZeroPlayerYVelocity(Game0 game, string directionRef)
        {
            gameHere = game;
            direction = directionRef;
        }
        public void Execute()
        {
            gameHere.link.StopMoving(direction);
        }
    }
}
