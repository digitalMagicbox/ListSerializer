using System;
using System.Collections.Generic;

namespace ListSerializer
{
    class Program
    {
        private const string Path = @"Numeric.xml";

        static void Main(string[] args)
        {
            var xml = new List<int>
            {
                1,2,3,4,5,6,7,8,9,10
            };

            ListSerializer.SaveToList<string>(Path, xml.ToHex());

            var loadXml = ListSerializer.LoadFromList<string>(Path);

            foreach(var i in loadXml)
            {
                Console.WriteLine(i.ToString());
            }

            var decList = loadXml.ToInt32();
            foreach (var i in decList)
            {
                Console.WriteLine(i.ToString());
            }

        }
    }
}
