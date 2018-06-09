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

        List<Restaurant> restaurants = null;
        List<ScheduleItem> tables;
     

        public List<ScheduleItem> FindATable(int currenttime, List<Restaurant> restaurants)
        {
            int j = 0;
            for (j = 0; j < restaurants.Count; j++)
            {

            }
            for (int i = 0; i < 14; i++)
            {
            }
            return tables;
        }
        public int TimeHelper(int currentime)
        {
            if (currentime % 60 == 0) return currentime % 60;
            return currentime / 60 + 1;
        }
    }
}
