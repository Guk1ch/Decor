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
using Decor.DataBase;

namespace Decor.Pages
{
    /// <summary>
    /// Логика взаимодействия для OrdersListPage.xaml
    /// </summary>
    public partial class OrdersListPage : Page
    {
        public static List<Order> orders { get; set; }
        public static List<Busket> buskets { get; set; }
        public OrdersListPage()
        {
            InitializeComponent();
            orders = new List<Order>(BDConnection.connection.Order.ToList());
            DataContext = this;
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void btnCreateOrder_Click(object sender, RoutedEventArgs e)
        {

        }

        private void lvGuest_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
