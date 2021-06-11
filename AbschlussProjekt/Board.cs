using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbschlussProjekt
{
    class Board
    {
        public Board(Deck deck, Trucks trucks, Kugellager kugellager, Rollenn rollen)
        {
            Deck = deck;
            Trucks = trucks;
            Kugellager = kugellager;
            Rollen = rollen;
            Pricezsm = Deck.Price + Trucks.Price + Kugellager.Price + Rollen.Price;
        }

        public Deck Deck { get; set; }
        public Trucks Trucks { get; set; }
        public Kugellager Kugellager { get; set; }
        public Rollenn Rollen { get; set; }
        public decimal Pricezsm { get; set; }

        public override string ToString() => Deck.Marke + " Board";

    }
}
