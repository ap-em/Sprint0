﻿using System;
using System.Collections.Generic;
using System.Text;
using Sprint0.Interfaces;
using Sprint0.Sprites;

/*TODO: WORK with Sprite factory to create the sprite*/

namespace Sprint0.Blocks
{
    class Block4State : IBlockState
    {
        private Block block;

        public Block4State(Block block)
        {
            this.block = block;
            //block.SetSprite(SpriteFactory.Instance.CreateNewSprite("block4"));
        }
        public void PrevBlock()
        {
            block.SetState(new Block3State(block));
        }
        public void NextBlock()
        {
            block.SetState(new Block5State(block));
        }
        public void Draw()
        {
            block.Draw();
        }
    }
}