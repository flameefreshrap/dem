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
    /// Interaction logic for AdminPage.xaml
    /// </summary>
    public partial class AdminPage : Page
    {
        public AdminPage()
        {
            InitializeComponent();
            UpdateData();
        }

        private void UpdateData()
        {
            IEnumerable<Service> product = EfModel.Init().Services.Where(u => u.Title.Contains(tbSearch.Text));
            switch (cbTime.SelectedIndex)
            {
                case 0:
                    product = product.OrderBy(u => u.Cost);
                    break;
                case 1:
                    product = product.OrderByDescending(u => u.Cost);
                    break;
            }

            LvContent.ItemsSource = product.ToList();
        }

        private void BtnBuy(object sender, RoutedEventArgs e)
        {

        }

        private void SortEvent(object sender, SelectionChangedEventArgs e)
        {

        }

        private void TbSearchClick(object sender, TextChangedEventArgs e)
        {

        }
    }
}
