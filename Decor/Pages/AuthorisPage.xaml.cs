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
    /// Логика взаимодействия для AuthorisPage.xaml
    /// </summary>
    public partial class AuthorisPage : Page
    {
        public static User user { get; set; } 
        public AuthorisPage()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, RoutedEventArgs e)
        {
            string login = tbLogin.Text.Trim();
            string password = tbPass.Password.Trim();
            user = BDConnection.connection.User.Where(x => x.Login == login && x.Password == password).FirstOrDefault();
            if(user.IDRole == 1)
            {
                if (user != null)
                {
                    NavigationService.Navigate(new EmplMainPage(user));
                }
                else if (user == null)
                {
                    MessageBox.Show("Логин или пароль не верны");
                }
            }
            else if(user.IDRole == 2)
            {
                if (user != null)
                {
                    NavigationService.Navigate(new ClienMainPage(user));
                }
                else if (user == null)
                {
                    MessageBox.Show("Логин или пароль не верны");
                }
            }
            else if(user.IDRole == 3)
            {
                if (user != null)
                {
                    NavigationService.Navigate(new AdminMainPage(user));
                }
                else if (user == null)
                {
                    MessageBox.Show("Логин или пароль не верны");
                }
            }
            else if(user.IDRole == 4)
            {
                if (user != null)
                {
                    NavigationService.Navigate(new ManageMainPage(user));
                }
                else if (user == null)
                {
                    MessageBox.Show("Логин или пароль не верны");
                }
            }
            

        }

        private void btnGuest_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new GuestPage());
        }
    }
}
