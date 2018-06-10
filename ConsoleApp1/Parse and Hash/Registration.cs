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
    public static class Registration
    {
        //const string FileName = "Users.json";
        public static void Registrate ()
        {

            using (var sw = new StreamWriter("../../../Users.json"))
            {
                using (var writer = new JsonTextWriter(sw))
                {
                    var serializer = new JsonSerializer();
                    serializer.Serialize(writer, User.users);
                }
            }

        }
    }
}
