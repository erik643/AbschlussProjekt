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
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace AbschlussProjekt
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        #region connectionstring
        const string connectionString = "server=localhost;uid=root;database=komponenten";
        #endregion
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ObservableCollection<Deck> eintrag = new ObservableCollection<Deck>();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                // connect
                connection.Open();

                // command
                MySqlCommand cmd = new MySqlCommand("select * from deck", connection);

                // read result
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Deck c = new Deck((int)reader[0], (string)reader[3], Convert.ToDecimal(reader[4]),(string)reader[2], Convert.ToDecimal(reader[1]));
                        eintrag.Add(c);
                    }
                }
            }
            var a =(DataViewer)gridd.DataContext;
            a.Decks = eintrag;
            new Window1().Show();
            this.Close();
        }
    }
}
