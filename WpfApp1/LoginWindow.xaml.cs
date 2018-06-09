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
using System.Windows.Shapes;
using TeamProjectCore;
using WpfApp1;

namespace TeamProjectUI
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public User user;
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void Registration (object sender, RoutedEventArgs e)
        {
            var rW = new RegistrationWindow();
            rW.Show();
            Close();
        }

        private void Enter(object sender, RoutedEventArgs e)
        {
            
        }

        private void VIP (object sender, RoutedEventArgs e)
        {
            var VW = new VIPWindow();
            VW.Show();
            Close();
        }
    }
}
