using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2
{
    public class Card
    {
        internal string name;
        public Rarity rarity;
        private int cP;

        public int CP { get => cP; set => cP = value; }

        public enum Affinity
        {
            Knight,
            Mage,
            Undead
        }
        public enum Rarity
        {
            Common,
            Rare,
            SuperRare,
            UltraRare,
        }


    }
}
