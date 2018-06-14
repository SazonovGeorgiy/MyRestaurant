using ConsoleApp1;
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

namespace WpfApp1.Notices
{
    /// <summary>
    /// Логика взаимодействия для SuccessfullyEnter.xaml
    /// </summary>
    public partial class SuccessfullyEnter : Window
    {
        public SuccessfullyEnter()
        {
            InitializeComponent();
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Find(object sender, RoutedEventArgs e)
        {
            List<Restaurant> restaurants = JsonParser.ParsIt();
            Restaurant.restaurants = restaurants;
            var rW = new ResultWindow(restaurants);
            rW.Show();
            Close();
        }

        private void Favorite(object sender, RoutedEventArgs e)
        {
            List<Restaurant> restaurants = JsonParser.ParsIt();
            FavoriteWindow fw = new FavoriteWindow(restaurants);
            fw.Show();
            Close();
        }

        private void AllReservation(object sender, RoutedEventArgs e)
        {
            //var rW = new MyReservation();
            //rW.Show();
            //Close();
            
        }
    }
    
}
