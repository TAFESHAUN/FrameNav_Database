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
    /// Interaction logic for frameTest.xaml
    /// </summary>
    public partial class frameTest : Page
    {
        private Repository _repo;
        public frameTest(Repository repo)
        {
            _repo = repo;
            InitializeComponent();
            DataContext = new Products();
        }

        private void Button_Click_Back(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Index(_repo));
        }

    }
}
