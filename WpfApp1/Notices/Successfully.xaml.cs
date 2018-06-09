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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Successfully.xaml
    /// </summary>
    public partial class Successfully : Window
    {
        
        public Successfully()
        {
            
            InitializeComponent();
        }

        private void Find (object sender, RoutedEventArgs e)
        {
            List<Restaurant> restaurants = JsonParser.ParsIt();
            int currentTime = DateTime.Now.Minute;
            Logic logic = new Logic();
            currentTime = logic.TimeHelper(currentTime);
            var result = logic.FindATable(currentTime, restaurants);
        }
    }
}
