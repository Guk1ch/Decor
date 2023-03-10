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
    /// Логика взаимодействия для ClienMainPage.xaml
    /// </summary>
    public partial class ClienMainPage : Page
    {
        public static List<Stuff> stuffs { get; set; }
        public ClienMainPage(User user)
        {
            InitializeComponent();
            stuffs = new List<Stuff>(BDConnection.connection.Stuff.ToList());
            DataContext = this;
        }
        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AuthorisPage());
        }


        private void btnCreateOrder_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
