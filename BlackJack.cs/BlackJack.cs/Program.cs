using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Model md = new Model();
            md.Play();
           
            Console.ReadLine();
        }
        
    }
}
