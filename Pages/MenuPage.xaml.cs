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
using MySqlX.XDevAPI.Common;

namespace CoffeShop.Pages
{
    /// <summary>
    /// Lógica de interacción para HomePage.xaml
    /// </summary>
    public partial class MenuPage : Page
    {
        //public string Namaproduk { get; set; }

        /*private string _productName;
        public string ProductName
        {
            get { return _productName; }
            set
            {
                _productName = value;
                // Raise PropertyChanged event here if you're using MVVM
            }
        }*/

        public MenuPage()
        {
            InitializeComponent();
            //DataContext = this;
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



        public void nfungsi()
        {
            /*Mydb db = new Mydb();
            //string query = "SELECT product.product_name FROM keranjang INNER JOIN product ON keranjang.product_id=product.product_id WHERE product.product_id = 2 LIMIT 1;";
            string query = "SELECT product_name FROM `product` WHERE product_id = 2;";
            string colum = "product.product_name";
            MySqlParameter[] parameters = new MySqlParameter[2];

            parameters[0] = new MySqlParameter("@id", MySqlDbType.Int32);
            parameters[0].Value = product_id;

            string result = db.AmbilData(query, colum, parameters);
            NamaProduk.Content = result;

            return result;*/

            string query = "server=localhost;port=3306;username=root;password=;database=coffee_shop";
            SqlConnection con = new SqlConnection(query);
            con.Open();
            string query1 = "SELECT product.product_name FROM keranjang INNER JOIN product ON keranjang.product_id=product.product_id WHERE product.product_id = 2 LIMIT 1;";

            SqlCommand cmd = new SqlCommand(query1, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                NamaProduk.Content = dr.GetValue(0).ToString();
                //NamaProduk.Content = Global.Namaproduk;
                //textBox1.Text = dr.GetValue(0).ToString();
            }
            //ProductName = dr.GetValue(0).ToString();

        }


        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            PagesNavigation.Content = new CoffePage();
            NavPage.Content = new Pesanan();
            welcome.Content = "Welcome " + Global.username;
            number.Content =  Global.number;
            

           
            

          
            


        }

        private void printbll(object sender, RoutedEventArgs e)
        {
            PagesNavigation.Navigate(new System.Uri("Pages/PaymentPage.xaml", UriKind.RelativeOrAbsolute));
        }
    }
}
