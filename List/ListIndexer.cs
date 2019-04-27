using System;
using System.Collections.Generic;
using System.Linq;

namespace cWritingFile
{
    class Program
    {
        
        static void Main(string[] args)
        {
            List<Indexer> MasterList = new List<Indexer>();
            var test = new Indexer(1, "Stay At Home");
            MasterList.Add(test);
            test = new Indexer(2, "Go Out To Eat");
            MasterList.Add(test);
            
            
            var xxx = MasterList.Find(x => x.IndexNo == 2);
            System.Console.WriteLine(xxx.TagName);
        }
    }

    public class Indexer
    {
        public int IndexNo { get; set; }
        public string TagName;
        public Indexer(int idx, string tName)
        {
            IndexNo = idx;
            TagName = tName;
        }

        public void Report()
        {
            System.Console.WriteLine(IndexNo);
            System.Console.WriteLine(TagName);
        }
    }
}
