using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
using CoffeShop.Pages;
using MySql.Data.MySqlClient;

namespace CoffeShop.Pages
{
    /// <summary>
    /// Lógica de interacción para HomePage.xaml
    /// </summary>
    public partial class MenuPage : Page
    {
        public MenuPage()
        {
            InitializeComponent();

            
        }









        private void rdPayment_Click(object sender, RoutedEventArgs e)
        {
            PagesNavigation.Navigate(new System.Uri("Pages/PaymentPage.xaml", UriKind.RelativeOrAbsolute));
        }

        private void ClkCoffe(object sender, RoutedEventArgs e)
        {
            PagesNavigation.Content = new CoffePage();
        }

        private void AllClick(object sender, RoutedEventArgs e)
        {
            PagesNavigation.Content = new All();
        }

        private void NonCoffe(object sender, RoutedEventArgs e)
        {
            PagesNavigation.Content = new NonCoffe();
        }

        private void Snack(object sender, RoutedEventArgs e)
        {
            PagesNavigation.Content = new Snack();
        }

        private void Food(object sender, RoutedEventArgs e)
        {
            PagesNavigation.Content = new Food();
        }



        public string nfungsi(int product_id) {
            Mydb db = new Mydb();
            string query = "SELECT product_name FROM `product` WHERE product_id = 1;";
            string colum = "product_name";
            MySqlParameter[] parameters = new MySqlParameter[1];

            parameters[0] = new MySqlParameter("@id", MySqlDbType.Int32);
            parameters[0].Value = product_id;

            return db.AmbilData(query,colum, parameters);
        }

        
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            PagesNavigation.Content = new CoffePage();
            welcome.Content = "Welcome " + Global.username;
            number.Content =  Global.number;
            

           
            

          
            


        }

        private void printbll(object sender, RoutedEventArgs e)
        {
            PagesNavigation.Navigate(new System.Uri("Pages/PaymentPage.xaml", UriKind.RelativeOrAbsolute));
        }
    }
}
