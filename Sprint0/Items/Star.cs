﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint0.Interfaces;
using Sprint0.Cycle;
using Sprint0.Sprites.SpriteFactory;
using System;
/*
Alex Clayton
Alex Contreras
Jared Israel
Leon Cai
Owen Tishenkel
Owen Huston
*/
namespace Sprint0.Items
{
    class Star : IItem, IDraw, IUpdate, IMovable
    {
        private String ItemName;
        private ISprite ItemSprite;
        private bool grounded = false;

        private Vector2 location = new Vector2(100, 200);
        public ISprite Sprite => ItemSprite;

        public Vector2 Position { get => location; set => throw new NotImplementedException(); }

        public Star(String itemName, Vector2 position) // Should I just use the gameobject manager? Items will probably include mushroom, star, coin
        {
            this.SetItem(itemName);
            location = position;
            this.ItemName = itemName;
        }

        public void SetItem(String spriteName)
        {
            this.ItemName = spriteName;
            this.ItemSprite = SpriteFactory.Instance.GetSprite(spriteName);
        }

        public bool GetGrounded()
        {
            return grounded;
        }
        public void SetGrounded(bool grounded)
        {
            this.grounded = grounded;
        }
        public string GetItemName()
        {
            return ItemName;
        }
        public void Move(int x, int y)
        {
            location = new Vector2(x, y);
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            Sprite.Draw(spriteBatch, location);
        }
        public void Update()
        {
            Sprite.Update(); // Will have to wire this to work as intended
        }

    }
}