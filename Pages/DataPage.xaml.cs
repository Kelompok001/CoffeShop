using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities.Collections;
using System;
using System.Collections.Generic;
using System.Data;
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
using System.Xml.Linq;

namespace CoffeShop.Pages
{
    /// <summary>
    /// Lógica de interacción para SoundsPage.xaml
    /// </summary>
    public partial class DataPage : Page
    {
        public DataPage()
        {
            InitializeComponent();
        }

        public void MakeOrder(object sender, RoutedEventArgs e)
        {
           
            Mydb db = new Mydb();

            Global.username = txtName.Text;
            Global.number = txtPhone.Text;


            if (addGenre(Global.username, Global.number))
            {
                Nav.Content = new MenuPage();
            }
            else
            {
                MessageBox.Show("Error");

            }
        }

        public Boolean addGenre(string username, string number)
        {
            Mydb db = new Mydb();

            string query = "INSERT INTO `customer` (customer_name, phone_number) VALUES (@customer_name, @phone_number);";

            MySqlParameter[] parameters = new MySqlParameter[2];
            parameters[0] = new MySqlParameter("@customer_name", MySqlDbType.VarChar);
            parameters[0].Value = username;

            parameters[1] = new MySqlParameter("@phone_number", MySqlDbType.VarChar);
            parameters[1].Value = number;

            if (db.setData(query, parameters) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void Nav_Navigated(object sender, NavigationEventArgs e)
        {

        }

        private void txtPhone_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
