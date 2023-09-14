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
using FrameNav_Database.Data;

namespace FrameNav_Database.View
{
    /// <summary>
    /// Interaction logic for Index.xaml
    /// </summary>
    public partial class Index : Page
    {
        private Repository _repo;
        public Index(Repository repo)
        {
            _repo = repo;
            InitializeComponent();
            dgProdcut.ItemsSource = _repo.GetProduct();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //We can define our selected product
            Products product = (Products)dgProdcut.SelectedItem;

            switch ((sender as Button).Content)
            {
                case "Edit":
                    // Now pass selection as arguement with repo
                    NavigationService.Navigate(new Update(_repo, product));
                    break;
                case "Delete":
                    // Using RoutedEventArgs as the selected product exists in our data context
                    NavigationService.Navigate(new Delete(_repo, (Products)((Button)e.Source).DataContext));
                    break;
            }
        }
    }
}

