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
            var data  = JsonConvert.DeserializeObject<Restaurants>(File.ReadAllText(FileName));
            return data.RestaurantsArray; 
            
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
