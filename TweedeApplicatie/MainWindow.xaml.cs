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

namespace TweedeApplicatie
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        int iTel = 0;
        private void btnTeller_Click(object sender, RoutedEventArgs e)
        {
            lblTeller.Content = iTel++;
        }


        private void btnKlik_Click(object sender, RoutedEventArgs e)
        {
            lblOutput.Content = "Hello World";
        }

    }
}
