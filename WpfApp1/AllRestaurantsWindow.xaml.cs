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
using TeamProjectUI;
using WpfApp1.Notices;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для ResultWindow.xaml
    /// </summary>
    public partial class ResultWindow : Window
    {
        List<Restaurant> restaurants;
        public ResultWindow(List<Restaurant> restaurants)
        {
            this.restaurants = restaurants;
            List<string> rests = new List<string>();
            foreach (var r in restaurants)
            {
                rests.Add(r._name);
            }
            InitializeComponent();
            RestList.ItemsSource = rests;
        }

        private void Selected(object sender, SelectionChangedEventArgs e)
        {
            foreach (var rest in restaurants)
            {
                if (rest._name == RestList.SelectedItem.ToString())
                {
                    RestaurantWindow rw = new RestaurantWindow(rest);
                    rw.Show();
                    Close();
                }
            }
        }

        private void Back (object sender, RoutedEventArgs e)
        {
            var sW = new SuccessfullyEnter();
            sW.Show();
            Close();
        }
    }
}
