﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SORTERPER
{
    class Card
    {
        public int Number { get; private set; }
        public VariationType Variation { get; private set; }
        public Card(int number)
        {
            Number = number;
        }

        public Card(int number, VariationType variationType)
        {
            Number = number;
            Variation = variationType;
        }

        public enum VariationType
        {
            A, B
        }
    }
}
