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
    /// Interaktionslogik für WindowTrucks.xaml
    /// </summary>
    public partial class WindowTrucks : Window
    {

        #region connectionstring
        const string connectionString = "server=localhost;uid=root;database=komponenten";
        #endregion
        public WindowTrucks()
        {
            InitializeComponent();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var a = (DataViewer)gridd.DataContext;
            BitmapImage logo = new BitmapImage();
            logo.BeginInit();
            logo.UriSource = new Uri("pack://application:,,,/Img/" + (string)a.SelectedTrucks.Bild);
            logo.EndInit();
            Deckbilder.Source = logo;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ObservableCollection<Rollenn> eintrag = new ObservableCollection<Rollenn>();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                // connect
                connection.Open();

                // command
                MySqlCommand cmd = new MySqlCommand("select * from reifen", connection);

                // read result
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Rollenn c = new Rollenn((int)reader[0],(int)reader[1],(string)reader[2],(string)reader[3],Convert.ToDecimal(reader[4]));
                        eintrag.Add(c);
                    }
                }
            }
            var a = (DataViewer)gridd.DataContext;
            a.Rollen = eintrag;
            new Rollen().Show();
            this.Close();
        }
    }
}
