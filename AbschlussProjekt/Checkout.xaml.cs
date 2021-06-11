using MySql.Data.MySqlClient;
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
    /// Interaktionslogik für Checkout.xaml
    /// </summary>
    public partial class Checkout : Window
    {
        #region connectionstring
        const string connectionString = "server=localhost;uid=root;database=komponenten";
        #endregion
        public Checkout()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var a = (DataViewer)gridd.DataContext;
            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "insert into Rechnungen(Quantity , Price) values(@nm, @nmm)";
                    cmd.Parameters.AddWithValue("@nm", a.Boards.Count);
                    cmd.Parameters.AddWithValue("@nmm", a.gsmtprice);
                    int inserted = cmd.ExecuteNonQuery();

                }

                conn.Close();

            }
            MessageBox.Show("Oder is placed. Your recipe is in our Database.");
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var a =(DataViewer)gridd.DataContext;
            a.SelectedDeck = null;
            a.SelectedKugellager = null;
            a.SelectedRollen = null;
            a.SelectedTrucks = null;
            a.CheckoutSelectedBoard = null;
            new Window1().Show();
            this.Close();
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var a = (DataViewer)gridd.DataContext;
            BitmapImage logo = new BitmapImage();
            logo.BeginInit();
            logo.UriSource = new Uri("pack://application:,,,/Img/" + (string)a.CheckoutSelectedBoard.Deck.Bild);
            logo.EndInit();
            Deckbilder.Source = logo;


            BitmapImage logo2 = new BitmapImage();
            logo2.BeginInit();
            logo2.UriSource = new Uri("pack://application:,,,/Img/" + (string)a.CheckoutSelectedBoard.Trucks.Bild);
            logo2.EndInit();
            truckks.Source = logo2;

            BitmapImage logo3 = new BitmapImage();
            logo3.BeginInit();
            logo3.UriSource = new Uri("pack://application:,,,/Img/" + (string)a.CheckoutSelectedBoard.Kugellager.Bild);
            logo3.EndInit();
            bearings.Source = logo3;


            BitmapImage logo4 = new BitmapImage();
            logo4.BeginInit();
            logo4.UriSource = new Uri("pack://application:,,,/Img/" + (string)a.CheckoutSelectedBoard.Rollen.Bild);
            logo4.EndInit();
            wheels.Source = logo4;

        }
    }
}
