using System;
using System.Collections.Generic;
using System.IO;

namespace csharp
{
    public class Program
    {
        static void Main(string[] args)
        {   
            var csv = new CSV();
            var c = csv.loadCsvFile(@"C:\csharp\ioDump.csv");
            foreach (var r in c) 
            {
                Console.WriteLine(r);
            }
        }
    }

public class CSV{
        public List<string> loadCsvFile(string filePath)
        {
            var reader = new StreamReader(File.OpenRead(filePath));
            List<string> cList = new List<string>();

            while(!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                cList.Add(line);
            }

            return cList;
        }
    }
}
