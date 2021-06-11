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
    /// Interaktionslogik für Rollen.xaml
    /// </summary>
    public partial class Rollen : Window
    {
        #region connectionstring
        const string connectionString = "server=localhost;uid=root;database=komponenten";
        #endregion
        public Rollen()
        {
            InitializeComponent();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var a = (DataViewer)gridd.DataContext;
            BitmapImage logo = new BitmapImage();
            logo.BeginInit();
            logo.UriSource = new Uri("pack://application:,,,/Img/" + (string)a.SelectedRollen.Bild);
            logo.EndInit();
            Deckbilder.Source = logo;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ObservableCollection<Kugellager> eintrag = new ObservableCollection<Kugellager>();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                // connect
                connection.Open();

                // command
                MySqlCommand cmd = new MySqlCommand("select * from kugellager", connection);

                // read result
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Kugellager c = new Kugellager((int)reader[0],(string)reader[3],Convert.ToDecimal(reader[4]),(string)reader[2],(int)reader[1]);
                        eintrag.Add(c);
                    }
                }
            }
            var a = (DataViewer)gridd.DataContext;
            a.Kugellager = eintrag;
            new Bearings().Show();
            this.Close();
        }
    }
}
