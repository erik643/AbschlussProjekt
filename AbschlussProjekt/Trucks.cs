using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbschlussProjekt
{
    class Trucks
    {
        public Trucks(int iD, string bild, decimal price, string marke, int breite)
        {
            ID = iD;
            Bild = bild;
            Price = price;
            Marke = marke;
            Breite = breite;
        }

        public int ID { get; set; }
        public string Bild { get; set; }
        public decimal Price { get; set; }
        public string Marke { get; set; }
        public int Breite { get; set; }

        public override string ToString()
        {
            return Marke;
        }
    }
}
