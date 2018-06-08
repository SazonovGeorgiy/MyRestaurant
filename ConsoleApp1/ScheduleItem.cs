using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    [DataContract]
    class ScheduleItem
    {
        [DataMember]
        public string _time;
        [DataMember]
        public int _freetables;
    }
}
