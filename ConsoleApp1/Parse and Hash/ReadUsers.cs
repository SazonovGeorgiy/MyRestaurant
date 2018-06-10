using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using TeamProjectCore;

namespace ConsoleApp1.Parse_and_Hash
{
    [DataContract]
    public static class ReadUsers
    {
        //const string FileName = "Users.json";
        public static void Read()
        {
            using (var sr = new StreamReader("../../../Users.json"))
            {
                using (var reader = new JsonTextReader(sr))
                {
                    var serializer = new JsonSerializer();
                    User.users = serializer.Deserialize<List<User>>(reader);
                }
            }

        }
    }
}
