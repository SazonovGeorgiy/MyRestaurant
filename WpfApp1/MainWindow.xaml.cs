using System;
using System.Collections.Generic;
using System.IO;
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
using TeamProjectCore;
namespace TeamProjectUI
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

        private void Welcome (object sender, RoutedEventArgs e)
        {
            var lW = new LoginWindow();
            lW.Show();
            Close();
        }

        private void Exit (object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}