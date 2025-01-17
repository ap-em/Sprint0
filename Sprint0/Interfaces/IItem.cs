﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;
/*
Alex Clayton
Alex Contreras
Jared Israel
Leon Cai
Owen Tishenkel
Owen Huston
*/
/*
 * Alexander Clayton CSE 3902 09/15/2021
 * Modified by Owen Tishenkel CSE 3902 9/25/2021
 * Modified again by Owen Tishenkel CSE 3902 10/1/2021
 * hey guys 10/22/21 alex clayton
 */
namespace Sprint0.Interfaces
{
    /*
     * This interface can be used for the compass, map, key, heart container, trifroce, boomerang, bow, etc. Items that are toggled to be able to use once unlocked
     */
    public interface IItem : IGameObject
    {
        String GetItemName();
        void ItemCollision(IMario mario);
    }
}
