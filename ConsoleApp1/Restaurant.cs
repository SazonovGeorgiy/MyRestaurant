using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    [DataContract]
    public class Restaurant
    {
        [DataMember]
        public string Name;
        [DataMember]
        List<ScheduleItem> Schedule = new List<ScheduleItem>();
    }
}
