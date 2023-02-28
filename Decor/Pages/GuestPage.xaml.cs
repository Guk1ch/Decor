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
    /// Логика взаимодействия для GuestPage.xaml
    /// </summary>
    public partial class GuestPage : Page
    {
        public static List<Stuff> stuffs { get; set; } 
        public GuestPage()
        {
            InitializeComponent();
            stuffs = new List<Stuff>(BDConnection.connection.Stuff.ToList());
            DataContext = this;
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AuthorisPage());
        }

        private void lvGuest_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
