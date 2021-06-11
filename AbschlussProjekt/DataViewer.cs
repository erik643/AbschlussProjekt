using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace AbschlussProjekt
{
    class DataViewer
    {

        public ObservableCollection<Deck> Decks { get; set; } = new ObservableCollection<Deck>();

        public Deck SelectedDeck { get; set; }






        public ObservableCollection<Trucks> Trucks { get; set; } = new ObservableCollection<Trucks>();

        public Trucks SelectedTrucks { get; set; }




        public ObservableCollection<Rollenn> Rollen { get; set; } = new ObservableCollection<Rollenn>();

        public Rollenn SelectedRollen { get; set; }





        public ObservableCollection<Kugellager> Kugellager { get; set; } = new ObservableCollection<Kugellager>();

        public Kugellager SelectedKugellager { get; set; }




        public Board FertigesBoard { get; set; }
        public ObservableCollection<Board> Boards { get; set; } = new ObservableCollection<Board>();

        public decimal gsmtprice { get; set; }

        public Board CheckoutSelectedBoard { get; set; }

    }
}
