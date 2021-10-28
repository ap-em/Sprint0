﻿
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sprint0;
namespace Sprint0.UtilityClasses
{
   public static class GameUtilities
    {
        public static Game game { get; set; }
        public static GameObjectManager gameObjectManager { get; set; }
        public static string emptyString = "";
        // magic number from GameObjectManager
        public static int dimension = 2;
        public static int bias = 16;
        public static int backgroundWidth = 6450;
        public static int backgroundHeight = 600;
        public static string left = "Left";
        public static string right = "Right";
        public static string top = "Top";
        public static string bottom = "Bottom";
        public static string worldOneOne = "1-1";
       

        // magic number in Game0
        public static float timeSpan = 1/30.0f;
        public static int marioInitialPosX = 50;
        public static int marioInitialPosY = 200;
        public static string marioSpriteName= "Sprint0.Mario";

        // magic number in Block
        public static int initialBlockPosX=200;
        public static int initialBlockPosY=200;

        // magic number in camera
        public const int upTransition = 140;

        //magic number in EnemyController
        public static int waitTime = 50;

        //magic number in item classes
        public static int itemPosX = 100;
        public static int itemPosY = 200;

        //magic number in level classes
        public static int maxRowLength = 1000;
        public static int maxNumberOfRows = 100;
        public static int boundryX = 998;
        public static int boundryY = 99;
        public static int worldSpacesScale = 32;
        public static int blockOnScreenX = 25;
        public static int blockOnScreenY = 20;

        //magic number in mario state machine
        public static int upperBounceValue = 14;
        public static int jumpXvalue = 5;
        public static int fireBallVelocityX = 10;
        public static int fuseTime = 30;
        public static  int currentMaxJumpTime = 5;
        public static  int maxJumpTime = 10;
        public static int Vx = 6;
        public static float VxF = 6f;
        public static int Vy = 10;
        public static float VairX = 4f;
        public static float gravity = 9.8f;
        public static int invinsibleTimer = 20;
        public static int invinsibleTimerStar = 100;
        public static int invinsibleTimerTakeDamage = 50;
        //to do : gravity part here

        //mario class
        public static int initialPosX= 100;
        public static int initialPosY = 100;




    }
}