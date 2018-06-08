using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ConsoleApp1
{
    [DataContract]
    public class Restaurants
    {
        [DataMember]
        public List<Restaurant> RestaurantsArray;
        
    }
}