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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CoffeShop.Pages
{
    /// <summary>
    /// Interaction logic for Pesanan.xaml
    /// </summary>
    public partial class Pesanan : Page
    {
        public Pesanan()
        {
            InitializeComponent();
            
        }

        
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {

            NamaPesanan.Content = Global.Namaproduk;
            HargaPesanan.Content = "Rp" + Global.harga;
            Total.Content = "Rp" + Global.harga;
            

        }
    }
}
