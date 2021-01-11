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

            //Add all the cards in a standard deck of 25 card deck.
            for (int i = 1; i <= 12; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    game.Cards.Add(new Card(i));
                }
            }
            game.Cards.Add(new Card(0));

            Console.ReadKey();
        }
    }
}
