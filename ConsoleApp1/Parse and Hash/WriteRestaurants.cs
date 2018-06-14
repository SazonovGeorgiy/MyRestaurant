using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using TeamProjectCore;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace ConsoleApp1.Parse_and_Hash
{
    public class WriteRestaurants
    {
        public static void Write()
        {

            using (var sw = new StreamWriter("../../../Restaurant.json"))
            {
                using (var writer = new JsonTextWriter(sw))
                {
                    var serializer = new JsonSerializer();
                    serializer.Serialize(writer, Restaurant.restaurants);
                }
            }

        }
    }
}
