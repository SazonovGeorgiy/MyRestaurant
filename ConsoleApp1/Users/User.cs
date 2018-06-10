using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamProjectCore
{
    public class User: IUser
    {
        public static List<User> users = new List<User>();
        public static User current;
        public User(string login, string password, long phone)
        {
            Password = password;
            Login = login;
            Phone = phone;
        }
        public string Password { get; set; }
        public long Phone { get; set; }
        public string Login { get; set; }
    }
}
