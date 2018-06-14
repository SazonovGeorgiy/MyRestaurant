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
using ConsoleApp1.Parse_and_Hash;
using WpfApp1.Notices;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для RestaurantWindow.xaml
    /// </summary>
    public partial class RestaurantWindow : Window
    {
        Restaurant curRest;
        public RestaurantWindow(Restaurant CurRest)
        {
            InitializeComponent();
            curRest = CurRest;
            Name.Content = curRest._name;
            Metro.Content = curRest._metroStation;
            Adress.Content = curRest._address;
            Phone.Content = curRest._phone;
            AddItems();
            if (CheckFav())
            {
                AddFav.Content = "Delete from favourites";
            }
            else
            {
                AddFav.Content = "Add to favourites";
            }
        }

        //если столы на это время есть, то добавляем время в список
        public void AddItems()
        {
            foreach (var item in curRest.Schedule)
            {
                if (item._freetables != 0)
                {
                    timeForBooking.Items.Add(item._time);
                }
            }
        }


        //метод для проверки наличия ресторана в избранном
        public bool CheckFav()
        {
            foreach (string rest in User.current.Favorites)
            {
                if (curRest._name == rest)
                {
                    return true;
                }
            }
            return false;
        }

        //при выборе времени проходимся по следующим элементам списка и смотрим, если разница 1 час, 
        //то значит добавляем во второй список возможность забронировать на 1 час дольше
        private void Time_Selected(object sender, SelectionChangedEventArgs e)
        {
            bool a = true;
            int i = 1;
            int sindex = timeForBooking.SelectedIndex;
            while (a)
            {
                tables.Items.Add(i.ToString());
                if (!Compare(sindex))
                {
                    a = false;
                }
                else
                {
                    i++;
                }
                sindex++;
            }
        }

        // сравниваем текущий элемент списка со следующим
        public bool Compare(int sindex)
        {
            try
            {
                string[] arr1 = curRest.Schedule[sindex]._time.Split(':');
                string[] arr2 = curRest.Schedule[sindex + 1]._time.Split(':');
                if (int.Parse(arr1[0]) + 1 == int.Parse(arr2[0]))
                {
                    return true;
                }
                return false;
            }
            catch (ArgumentOutOfRangeException)
            {
            MessageBox.Show("У нас проблемки");
            }
            return false;
        }


        //добавляем/удаляем ресторан из избранного
        private void AddFav_Click(object sender, RoutedEventArgs e)
        {
            if (CheckFav())
            {
                User.current.Favorites.Remove(curRest._name);
                Registration.Registrate();
                MessageBox.Show("Successfully deleted");
            }
            else
            {
                User.current.Favorites.Add(curRest._name);
                Registration.Registrate();
                MessageBox.Show("Successfully added");
            }
            var sE = new SuccessfullyEnter();
            sE.Show();
            Close();
        }

        //Бронь столика
        private void Booking (object sender, RoutedEventArgs e)
        {
            int count=0;
            if (tables.SelectedItem != null)
            {
                int.TryParse(tables.SelectedItem.ToString(), out count);
            }
            for (int i = 0; i < curRest.Schedule.Count; i++)
            {
                var schedule = curRest.Schedule;
                if (schedule[i]._time == timeForBooking.SelectedItem.ToString())
                {
                    for (int j = 0; j < count; j++)
                    {
                        string[] tArr = schedule[i + j]._time.Split(':');
                        schedule[i + j]._freetables--;
                    }
                }
            }
            WriteRestaurants.Write();
            MessageBox.Show("Successfully");
            string time = timeForBooking.SelectedItem.ToString();
            var rW = new MyReservation(time, count.ToString());
            rW.Show();
            Close();
        }

        private void Back(object sender, RoutedEventArgs e)
        {
            var sR = new SuccessfullyEnter();
            sR.Show();
            Close();
        }
    }
}
