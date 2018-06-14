using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace TeamProjectCore
{
#region Parser
    public class JsonParser
    {
        const string FileName = "../../../Restaurant.json";

        public static List<Restaurant> ParsIt () //Парсинг и распределение по листам
        {
            List<Restaurant> list = new List<Restaurant>();
            using (var sr = new StreamReader(FileName))
            {
                using (var reader = new JsonTextReader(sr))
                {
                    var serializer = new JsonSerializer();
                    list = serializer.Deserialize<List<Restaurant>>(reader);
                }
            }
            return list; 
        }
    }

    [DataContract]
    public class Restaurants
    {
        [DataMember]
        public List<Restaurant> RestaurantsArray;

    }
    #endregion

}
