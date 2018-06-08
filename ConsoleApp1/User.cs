using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamProjectCore
{
    class User : IUser
    {
        
        public string Password { get; set; }
        public long Phone { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Login { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime FavouriteDay { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime FavouriteTime { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string HashedPassword { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string IUser.HashedPassword { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
