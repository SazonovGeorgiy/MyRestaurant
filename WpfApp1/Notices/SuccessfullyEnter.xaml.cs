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
            int currentTime = DateTime.Now.Hour;
            Logic logic = new Logic();
            currentTime = logic.TimeHelper(currentTime);
            List<Restaurant> result = logic.FindATable(currentTime, restaurants);
            //var rW = new ResultWindow(result);
            //rW.Show();
            Close();
        }
    }
    
}
