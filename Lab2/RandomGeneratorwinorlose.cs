﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    // Random class to return 0 or 1 ,so we can decide if the user guessed the match result right or not
    class RandomGeneratorwinorlose
    {
       public Random randomwinorlose1 = new Random();

        public int RandomWinorlose()
        {
            int randomwinorlose;
            randomwinorlose = randomwinorlose1.Next(0, 3);//1 or 0
           
            return randomwinorlose;
        }
    }
}
