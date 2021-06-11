using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbschlussProjekt
{
    class Kugellager
    {
        public Kugellager(int iD, string bild, decimal price, string marke, int aBEC)
        {
            ID = iD;
            Bild = bild;
            Price = price;
            Marke = marke;
            ABEC = aBEC;
        }

        public int ID { get; set; }
        public string Bild { get; set; }
        public decimal Price { get; set; }
        public string Marke { get; set; }
        public int ABEC { get; set; }



        public override string ToString() => Marke;
    }

    
}
