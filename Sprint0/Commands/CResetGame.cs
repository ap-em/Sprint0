﻿using Sprint0.HUD;
using Sprint0.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint0.Commands
{
    class CResetGame : ICommand
    {
        IMario mario;

        public CResetGame(IMario mario)
        {
            this.mario = mario;
        }

        public void Execute()
        {
            //reset score and time
            HUDManager.Instance.GetHUD((IGameObject)mario).Reset();
            HUDManager.Instance.GetHUD((IGameObject)mario).ResetLives();
            GameObjectManager.Instance.RemoveAllObjects();
            Game0.Instance.soundInfo.StopLoopedSound("OverworldTheme");
            Game0.Instance.soundInfo.PlaySound("OverworldTheme", true);
            LevelFactory.Instance.CreateLevel(1);
        }
    }
}