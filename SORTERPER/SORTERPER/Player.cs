using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SORTERPER
{
    class Player
    {
        public List<Card> Hand { get; set; }
        public bool Done { get; set; }

        public Player()
        {
            Hand = new List<Card>();
            Done = false;
        }

        public Card TakeCardAtIndex(int index)
        {
            //Store the card taken so we can return it
            Card CardTaken = this.Hand[index];
            this.Hand.RemoveAt(index);
            return (CardTaken);
        }
    }
}
