using System;
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


            Play game = new Play();
            game.PlayGame();
            //var qw = SuitCard();
            //Console.WriteLine(qw);          
            Console.ReadLine();
        }
        enum Bar
        {
            q,
            w,
            e,
            r,
            t,
            y
        }
        public static string SuitCard()
        {
            Array values = Enum.GetValues(typeof(Bar));
            //Random random = new Random();
            //Suits randomSuit = (Suits)values.GetValue(random.Next(values.Length));
            Bar randomSuit = (Bar)values.GetValue(1);
            return randomSuit.ToString();
        }
    }
}
