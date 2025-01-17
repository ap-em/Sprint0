﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Microsoft.Xna.Framework;
using Sprint0.Interfaces;
using Sprint0.Timers;
using Sprint0.UtilityClasses;

namespace Sprint0.Enemies
{
    class ChargeEnemyChargeState : IEnemyState
    {
        private string ID = "ChargeEnemyChargeState";
        private Timer chargeTimer;
        private bool grounded;
        private IEnemy enemy;
        private string direction;
        private Vector2 velocity;

        public ChargeEnemyChargeState(IEnemy enemyRef, string directionRef)
        {
            Debug.WriteLine("CHARGE STATE");

            enemy = enemyRef;
            chargeTimer = new Timer(GameUtilities.chargeEnemyChargeTime, FinishCharging);
            TimerManager.Instance.AddToTimerList(chargeTimer);
            direction = directionRef;
            velocity = new Vector2(0, GameUtilities.gravity);
        }

        public void BigUpBounce(Rectangle rectangle)
        {
        }

        public void DownBounce(Rectangle rectangle)
        {
            enemy.Position = new Vector2(enemy.Position.X, enemy.Position.Y + rectangle.Height);
        }

        public bool GetGrounded()
        {
            return grounded;
        }

        public void GetKicked(Rectangle rec)
        {
        }

        public string GetStateID()
        {
            return ID;
        }

        public Vector2 GetVelocity()
        {
            return velocity;
        }

        public void LeftBounce(Rectangle rectangle)
        {
            Debug.WriteLine(" charge LEFT BOUNCE");

        }

        public void MoveLeft()
        {
            //
        }

        public void MoveRight()
        {
            //
        }

        public void RightBounce(Rectangle rectangle)
        {
            Debug.WriteLine("Charge right BOUNCE");

        }

        public void SetGrounded(bool grounded)
        {
            this.grounded = grounded;
        }

        public void SetXVelocity(float x)
        {
        }

        public void SetYVelocity(float y)
        {
        }

        public void TakeDamage()
        {
            enemy.SetHealth(enemy.GetHealth() - 1);
            enemy.CurrentState = new ChargeEnemySquashedState(enemy);
            enemy.StartRemovalTimer(100);
        }

        public void UpBounce(Rectangle rectangle)
        {
            grounded = true;
            enemy.Position = new Vector2(enemy.Position.X, enemy.Position.Y - rectangle.Height);
        }

        private void FinishCharging()
        {
            if (enemy.GetHealth()>0)
            {
                enemy.CurrentState = new ChargeEnemyAttackState(enemy, direction);
            }
        }

        public void Update()
        {
            
        }
    }
}
