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
using FrameNav_Database.View;

namespace FrameNav_Database
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Repository _repo;
        public MainWindow()
        {
            InitializeComponent();
            _repo = new Repository();
            frame.Navigate(new View.Index(_repo));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            frame.Navigate(new View.Insert(_repo));
        }

        private void Button_Click_N(object sender, RoutedEventArgs e)
        {
            frame.Navigate(new View.frameTest(_repo));
            //Products prod = new Products;
        }
    }
}
