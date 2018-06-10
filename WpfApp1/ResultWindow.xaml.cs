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
    /// Логика взаимодействия для ResultWindow.xaml
    /// </summary>
    public partial class ResultWindow : Window
    {
        List<ScheduleItem> result;
        public ResultWindow(List<ScheduleItem> result)
        {
            InitializeComponent();
            //PrintTables(result);
            Loaded += Tables_Loaded;
        }
        //public void PrintTables(List <ScheduleItem> result)
        //{
        //    foreach (var item in result)
        //    {
        //        Result.Text = item._time + item._freetables.ToString();
        //    }
        //}
        private void Tables_Loaded(object sender, RoutedEventArgs e)
        {
            Tables.ItemsSource = result;
        }

    }
}
