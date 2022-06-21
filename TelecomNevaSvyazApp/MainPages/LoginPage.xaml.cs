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
using TelecomNevaSvyazApp.DataBase.Entity;

namespace TelecomNevaSvyazApp.MainPages
{
    /// <summary>
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void BtnLoginClick(object sender, RoutedEventArgs e)
        {
            Client client = EfModel.Init().Clients.FirstOrDefault(u => u.Email == TBLogin.Text && u.FirstName == TBPassword.Text);

        if(client == null)
            {
                MessageBox.Show("Неверный логин или пароль");
                return;
            }
            else
            {
                NavigationService.Navigate(new AdminPage());
            }
        }

        private void BtnLoginGostClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MainMenuPage());
        }
    }
}
