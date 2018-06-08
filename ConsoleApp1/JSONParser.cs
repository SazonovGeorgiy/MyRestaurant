using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    public class JSONParser
    {
        const string fileName = "Restaurant.json";
        public List<Restaurant> parser ()
        {

            var c  = JsonConvert.DeserializeObject<Restaurants>(File.ReadAllText(fileName));
            return c.RestaurantsArray;
        }
    }

}
