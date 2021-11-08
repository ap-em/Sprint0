﻿using Sprint0.Enemies;
using Sprint0.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;

namespace Sprint0.Commands
{
    class CDamageEnemy : ICommand
    {
        private Enemy enemy;
        private Mario mario;
        public CDamageEnemy(Enemy enemyRefernce, Mario mario, Rectangle rec)
        {
            enemy = enemyRefernce;
        }
        public void Execute()
        {
            enemy.TakeDamage();
        }
    }
}