using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortePerUI
{
    class Player
    {
        public List<Card> Hand { get; set; }
        public string Name { get; set; }
        public bool Done { get; set; }

        public Player(string name)
        {
            Hand = new List<Card>();
            Name = name;
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
