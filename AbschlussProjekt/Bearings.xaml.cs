using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace AbschlussProjekt
{
    /// <summary>
    /// Interaktionslogik für Bearings.xaml
    /// </summary>
    public partial class Bearings : Window
    {
        public Bearings()
        {
            InitializeComponent();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var a = (DataViewer)gridd.DataContext;
            BitmapImage logo = new BitmapImage();
            logo.BeginInit();
            logo.UriSource = new Uri("pack://application:,,,/Img/" + (string)a.SelectedKugellager.Bild);
            logo.EndInit();
            Deckbilder.Source = logo;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var a = (DataViewer)gridd.DataContext;
            Board b = new Board(a.SelectedDeck,a.SelectedTrucks,a.SelectedKugellager,a.SelectedRollen);
            a.FertigesBoard = b;
            a.Boards.Add(a.FertigesBoard);
            a.gsmtprice +=b.Pricezsm;
            new Checkout().Show();
            this.Close();
        }
    }
}
