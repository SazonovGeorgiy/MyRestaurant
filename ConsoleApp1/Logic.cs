using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamProjectCore;

namespace ConsoleApp1
{
    public class Logic
    {

        
        List<ScheduleItem> tables = new List<ScheduleItem>();


        public List<ScheduleItem> FindATable(int currenttime, List<Restaurant> restaurants)
        {
            for (int i = 0; i < restaurants.Count; i++)
            {
                foreach (var item in restaurants[i].Schedule)
                {
                    var parts = item._time.Split(new[] { ':' }, StringSplitOptions.RemoveEmptyEntries);
                    int.TryParse(parts[0], out var time);
                    if (time == currenttime)
                    {
                        tables.Add(item);
                    }
                    //First edition
                   
                }
            }
            return tables;
        }

        public int TimeHelper(int currentime)
        {
            return currentime + 1;

        }
    }
}
