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
using WpfApp1.Notices;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для FavoriteWindow.xaml
    /// </summary>
    public partial class FavoriteWindow : Window
    {
        List<Restaurant> restaurants;
        public FavoriteWindow(List<Restaurant> restaurants)
        {
            InitializeComponent();
            this.restaurants = restaurants;
            RestList.ItemsSource = User.current.Favorites;
        }

        private void Selected(object sender, SelectionChangedEventArgs e)
        {
            foreach (var rest in restaurants)
            {
                if (rest._name == RestList.SelectedItem.ToString())
                {
                    Console.WriteLine(rest.Schedule.Count);
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
