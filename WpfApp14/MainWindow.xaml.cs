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

namespace WpfApp14
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void btn_oldrunner_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("Runner/AuthRunner.xaml", UriKind.Relative));
        }

        private void btn_newrunner_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("Runner/RegRunner.xaml", UriKind.Relative));
        }

        private void btn_Login_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("Runner/AuthRunner.xaml", UriKind.Relative));
        }
    }
}
