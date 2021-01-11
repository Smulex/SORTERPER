﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SORTERPER
{
    class Game
    {
        public List<Card> Cards { get; set; }
        public List<Player> Players { get; set; }

        public void CheckForPairManually(Player player, Card card1, Card card2)
        {
            if (card1.Number == card2.Number)
            {
                List<Card> itemsToRemove = new List<Card>
                {
                    card1, card2
                };

                foreach (Card value in itemsToRemove)
                {
                    player.Hand = player.Hand.Where(x => x != value).ToList();
                }

                if (!player.Hand.Any())
                {
                    player.Done = true;
                }
            }
        }

        public void CheckForPair(Player player)
        {
            //Checking all the card on the hand
            for (int i = 0; i < player.Hand.Count; i++)
            {
                for (int j = 0; j < player.Hand.Count; j++)
                {
                    //Checks that the card is not the same
                    if (player.Hand[i] != player.Hand[j])
                    {
                        if (player.Hand[i].Number == player.Hand[j].Number)
                        {
                            List<Card> itemsToRemove = new List<Card>
                            {
                                player.Hand[j], player.Hand[i]
                            };

                            foreach (Card value in itemsToRemove)
                            {
                                player.Hand = player.Hand.Where(x => x != value).ToList();
                            }

                            //Checks if the list is empty
                            if (!player.Hand.Any())
                            {
                                player.Done = true;
                            }
                        }
                    }
                }
            }
        }

        public void AddPlayer(string name)
        {
            //Adds one player
            Players.Add(new Player(name));
        }

        public void AddCards()
        {
            //Adding all the cards in a standard deck of 25 cards.
            for (int i = 1; i <= 12; i++)
            {
                foreach (Card.VariationType variation in (Card.VariationType[])Enum.GetValues(typeof(Card.VariationType)))
                {
                    Cards.Add(new Card(i, variation));
                }
            }
            Cards.Add(new Card(0));
        }

        public void ShuffleCards()
        {
            this.Cards = this.Cards.OrderBy(a => Guid.NewGuid()).ToList();
        }
    }
}
