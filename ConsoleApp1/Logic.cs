using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamProjectCore;

//main logic

namespace ConsoleApp1
{
    public class Logic
    {

      
        public List<Restaurant> FindATable(int currenttime, List<Restaurant> restaurants)
        {
            for (int i = 0; i < restaurants.Count; i++)
            {
                bool found = false;
                foreach (var item in restaurants[i].Schedule)
                {
                    var parts = item._time.Split(new[] { ':' }, StringSplitOptions.RemoveEmptyEntries);
                    int.TryParse(parts[0], out var time);
                    if (time == currenttime)
                    {
                        found = true;
                        restaurants[i].Schedule.Clear();
                        restaurants[i].Schedule.Add(item);
                        break;
                    }
                   

                }
                if (!found)
                {
                    restaurants[i].Schedule.Clear();
                }
            }
            return restaurants;
        }

        public int TimeHelper(int currentime)
        {
            return currentime + 1;

        }
    }
}
