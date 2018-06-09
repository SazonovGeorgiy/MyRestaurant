using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamProjectCore
{
    public interface IUser
    {
        string Password { get; set; }
        long Phone { get; set; }
        string Login { get; set; }
        Enum FavouriteDay { get; set; }
        DateTime FavouriteTime { get; set; }
    }
}
