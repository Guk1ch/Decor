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
    /// Логика взаимодействия для EmplMainPage.xaml
    /// </summary>
    public partial class EmplMainPage : Page
    {
        public EmplMainPage(User user)
        {
            InitializeComponent();
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
