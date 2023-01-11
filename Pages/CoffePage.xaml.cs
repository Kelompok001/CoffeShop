using MySql.Data.MySqlClient;
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
using System.Xml.Linq;

namespace CoffeShop.Pages
{
    /// <summary>
    /// Lógica de interacción para NotesPage.xaml
    /// </summary>
    public partial class CoffePage : Page
    {
        public CoffePage()
        {
            InitializeComponent();
        }

        private void FrappuchinoClk(object sender, RoutedEventArgs e)
        {
            Mydb db = new Mydb();

            if (addKeranjang(Global.Namaproduk, Global.harga))
            {
                MessageBox.Show("Added to cart");
                Global.Namaproduk = "Frappuchino";
                Global.harga = 25000;
                


            }
                    
            else
            {
                MessageBox.Show("Error");

            }
        }

        public Boolean addKeranjang(string NamaProduk, float harga)
        {
            Mydb db = new Mydb();
            int produk_id = 2;
            string query = "INSERT INTO `keranjang`VALUES ('',@product_id);";

            MySqlParameter[] parameters = new MySqlParameter[1];
            parameters[0] = new MySqlParameter("@product_id", MySqlDbType.VarChar);
            parameters[0].Value = produk_id;

            

            if (db.setData(query, parameters) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void EspressoClk(object sender, RoutedEventArgs e)
        {
            Mydb db = new Mydb();

            if (addKeranjang1(Global.Namaproduk, Global.harga))
            {
                MessageBox.Show("Added to cart");
                Global.Namaproduk = "Espresso";
                Global.harga = 10000;
            }

            else
            {
                MessageBox.Show("Error");

            }
        }

        public Boolean addKeranjang1(string NamaProduk, float harga)
        {
            Mydb db = new Mydb();
            int produk_id = 1;
            string query = "INSERT INTO `keranjang`VALUES ('',@product_id);";

            MySqlParameter[] parameters = new MySqlParameter[1];
            parameters[0] = new MySqlParameter("@product_id", MySqlDbType.VarChar);
            parameters[0].Value = produk_id;



            if (db.setData(query, parameters) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void MocachinoClk(object sender, RoutedEventArgs e)
        {
            Mydb db = new Mydb();

            if (addKeranjang2(Global.Namaproduk, Global.harga))
            {
                MessageBox.Show("Added to cart");
                Global.Namaproduk = "Mocachino";
                Global.harga = 22000;

            }

            else
            {
                MessageBox.Show("Error");

            }
        }

        public Boolean addKeranjang2(string NamaProduk, float harga)
        {
            Mydb db = new Mydb();
            int produk_id = 3;
            string query = "INSERT INTO `keranjang`VALUES ('',@product_id);";

            MySqlParameter[] parameters = new MySqlParameter[1];
            parameters[0] = new MySqlParameter("@product_id", MySqlDbType.VarChar);
            parameters[0].Value = produk_id;



            if (db.setData(query, parameters) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    
}
