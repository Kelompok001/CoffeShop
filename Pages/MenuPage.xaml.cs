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

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            PagesNavigation.Content = new CoffePage();
            welcome.Content = "Welcome " + Global.username;
            number.Content =  Global.number;
            Pesanan.Content = Global.Namaproduk;
            Harga.Content = "Rp" + Global.harga;




        }
        

       
    }
}
