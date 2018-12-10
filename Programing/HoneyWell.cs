using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Newtonsoft.Json.Linq;

namespace ConsoleApplication1
{
    public class HoneyWell
    {
        public  void Coding1()
        {
            var json = System.IO.File.ReadAllText(@"d:\test.json");

            //var objects = JArray.Parse(json); // parse as array  
            //foreach (JObject root in objects)
            //{
            //    foreach (KeyValuePair<String, JToken> app in root)
            //    {
            //        var appName = app.Key;
            //        var description = (String)app.Value["Description"];
            //        var value = (String)app.Value["Value"];

            //        Console.WriteLine(appName);
            //        Console.WriteLine(description);
            //        Console.WriteLine(value);
            //        Console.WriteLine("\n");
            //    }
            //}
        }

    }
}
