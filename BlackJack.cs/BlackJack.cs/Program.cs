﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlackJack.cs.Game;

namespace BlackJack.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Play pl = new Play();
            pl.PlayGame();
                       
            Console.ReadLine();
        }
        
    }
}
