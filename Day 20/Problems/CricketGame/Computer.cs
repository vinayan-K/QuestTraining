﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CricketGame
{
    internal class Computer
    {
        public int Score { get; set; }
        public Computer()
        {
            Score = 0;
        }
        public void AddScore(int score)
        {
            Score += score;
        }
    }
}
