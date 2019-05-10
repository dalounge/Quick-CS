using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace c_json
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader r = new StreamReader(@"C:\productOS\productOs.json"))
            {
                var json = r.ReadToEnd();
                var x = JsonConvert.DeserializeObject<Dictionary<string, Items>>(json);
                
                foreach (var y in x["Wonderware InTouch Edge HMI 2017 (Update 2)"].OS)
                {
                    Console.WriteLine(y);
                }
            }
        }
    }

    public class Items
    {
        public List<string> OS { get; set; }
    }
}
