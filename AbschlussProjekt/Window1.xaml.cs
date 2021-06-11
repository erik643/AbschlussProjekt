using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaktionslogik für Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        #region connectionstring
        const string connectionString = "server=localhost;uid=root;database=komponenten";
        #endregion
        public Window1()
        {
            InitializeComponent();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var a = (DataViewer)gridd.DataContext;
            BitmapImage logo = new BitmapImage();
            logo.BeginInit();
            logo.UriSource = new Uri("pack://application:,,,/Img/" + (string)a.SelectedDeck.Bild);
            logo.EndInit();
            Deckbilder.Source = logo;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ObservableCollection<Trucks> eintrag = new ObservableCollection<Trucks>();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                // connect
                connection.Open();

                // command
                MySqlCommand cmd = new MySqlCommand("select * from trucks", connection);

                // read result
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Trucks c = new Trucks((int)reader[0],(string)reader[3],Convert.ToDecimal(reader[4]),(string)reader[2],(int)reader[1]);
                        eintrag.Add(c);
                    }
                }
            }
            var a = (DataViewer)gridd.DataContext;
            a.Trucks = eintrag;
            new WindowTrucks().Show();
            this.Close();
        }
    }
}
