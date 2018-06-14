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
        

        public RegistrationWindow()
        {
            InitializeComponent();
        }

        public void Registrate(object sender, RoutedEventArgs e)
        {
            var _login = Login.Text;
            var _password = Hashing.GetHash(Password.Password);
            var _password2 = Hashing.GetHash(Password2.Password);
            long.TryParse(Phone.Text, out var _phone);
            
            if (_login != "" && _password != "" && Phone.Text != "")
            {
                if (_password == _password2)
                {
                    try
                    {
                        if (CheckEmailOnCorrect())
                        {
                            user = new User(_login, _password, _phone, new List<string>());
                            if (User.users == null) User.users = new List<User>();
                            User.users.Add(user);
                            User.current = user;
                            Registration.Registrate();
                        
                            var sW = new Successfully();
                            sW.Show();
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("Incorrectly entered E-mail");
                        }
                    }
                    catch (ArgumentException)
                    {
                        MessageBox.Show("We select tables based on your preferences. Add them please.","Preferences error");
                    }
                }
                else
                {
                    MessageBox.Show("Password don't match");
                }
            }
            else
            {
                MessageBox.Show("You have to fill the gaps with stars. It's necessary.", "Error");
            }
        }

        public bool CheckEmailOnCorrect()
        {
            foreach (char a in Login.Text)
            {
                if (a == '@')
                {
                    return true;
                }
            }

            return false;
        }

        public void Exit(object sender, RoutedEventArgs e)
        {
            Close();
        }

    }
}
