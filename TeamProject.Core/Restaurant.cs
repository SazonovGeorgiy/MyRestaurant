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
        public string _name;
        [DataMember]
        List<ScheduleItem> Schedule = new List<ScheduleItem>();
        [DataMember]
        public long _phone;
        [DataMember]
        public string _metroStation;
        [DataMember]
        public string _address;
        [DataMember]
        public string _tables;


    }
}
