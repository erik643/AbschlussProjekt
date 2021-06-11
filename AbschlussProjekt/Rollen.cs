using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbschlussProjekt
{
    class Rollenn
    {
        public Rollenn(int iD, int durchmesser, string marke, string bild, decimal price)
        {
            ID = iD;
            Durchmesser = durchmesser;
            Marke = marke;
            Bild = bild;
            Price = price;
        }

        public int ID { get; set; }

        public int Durchmesser { get; set; }
        public string Marke { get; set; }
        public string Bild { get; set; }
        public decimal Price { get; set; }

        public override string ToString() => Marke;
    }
}
