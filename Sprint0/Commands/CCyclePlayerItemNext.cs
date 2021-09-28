﻿using Sprint0.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint0.Commands
{
    /*Owen Tishenkel 2021 CSE 3902*/
    class CCyclePlayerItemNext : ICommand
    {
        IItems item;
        public CCyclePlayerItemNext(IItems item)
        {
            this.item = item;

        }

        public void Execute()
        {
            item.NextItem();
        }
    }
}
