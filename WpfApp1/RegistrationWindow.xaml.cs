using ConsoleApp1.Parse_and_Hash;
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
    /// Логика взаимодействия для RegistrationWindow.xaml
    /// </summary>
    public partial class RegistrationWindow : Window
    {
        User user;
        List<User> users = new List<User>();

        public RegistrationWindow()
        {
            InitializeComponent();
        }

        public void Registrate(object sender, RoutedEventArgs e)
        {
            var _login = Login.Text;
            var _password = Hashing.GetHash(Password.Password);
            Enum _day = null;
            DateTime _time = DateTime.MinValue;
            long.TryParse(Phone.Text, out var _phone);

            //Было бы неплохо создать определенный метод CheckData для работы со всем этим добром

            if (Login.Text != "" && Password.Password != "" && Phone.Text != "")
            {
                try
                {
                    _day = ((DayOfWeek)Enum.Parse(typeof(DayOfWeek), FavouriteDay.Text));
                    _time = Convert.ToDateTime(FavouriteTime.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("You have to inscribe day of deek in the gap Favourite Day" +
                        " and time in the gap Favourite Time (Example: Friday," +
                        " 17:00. Please try again.", "Data Error");
                }
                catch (ArgumentException)
                {
                    MessageBox.Show("We select tables based on your preferences. Add them please.","Preferences error");
                }
            }
            else
            {
                MessageBox.Show("You have to fill the gaps with stars. It's necessary.", "Error");
            }

            user = new User(_login, _password, _phone, _day, _time);
            Registration.Registrate(user);
            users.Add(user);

            //Необходимо сделать вызов окна доступным только при всех верно введенных данных
            var sW = new Successfully();
            sW.Show();
            Close();
        }
        public void Exit(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
