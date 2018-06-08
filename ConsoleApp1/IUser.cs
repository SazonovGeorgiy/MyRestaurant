using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamProjectCore
{
    public interface IUser
    {
        string HashedPassword { get; set; }
        long Phone { get; set; }
        string Login { get; set; }
        DateTime FavouriteDay { get; set; }
        DateTime FavouriteTime { get; set; }
    }
}
