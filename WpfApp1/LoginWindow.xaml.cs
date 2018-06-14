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
using ConsoleApp1.Parse_and_Hash;
using System.Security.Cryptography;
using WpfApp1.Notices;

namespace TeamProjectUI
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
            ReadUsers.Read();               //Считывание пользователей из Json
        }

        private void Registration (object sender, RoutedEventArgs e)
        {
            var rW = new RegistrationWindow();
            rW.Show();
            Close();
        }

        private void Enter(object sender, RoutedEventArgs e)
        {
            if (CheckLoginAndPassword())                    //Проверяем на корректно введеные данные
            {
                var sW = new SuccessfullyEnter();
                sW.Show();
                Close();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль!");
            }
        }

        private void VIP (object sender, RoutedEventArgs e)
        {
            var VW = new VIPWindow();
            VW.Show();
            Close();
        }

        public bool CheckLoginAndPassword()
        {
            if (User.users != null)
            {
                foreach (User user in User.users)
                {
                    if (Login.Text == user.Login && Hashing.GetHash(Password.Password) == user.Password)
                    {
                        User.current = user;
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
