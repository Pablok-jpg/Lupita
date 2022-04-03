using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2
{
    class Deck
    {
        public int CP;
        public List<Card> deck = new List<Card>();

        internal void addCard (Card card)
        {
            if (CP >= card.CP)
            {
                deck.Add(card);
            }
            else throw new Exception("No tiene CP disponible para agregar la carta.");

        }

    }
}
