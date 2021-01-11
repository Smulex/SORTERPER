using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SORTERPER
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();

            game.AddCards();

            Console.ReadKey();
        }
    }
}
