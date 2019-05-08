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

            ListSerializer.SaveToList<int>(Path, xml);

            var loadXml = ListSerializer.LoadFromList<int>(Path);

            foreach(var i in loadXml)
            {
                Console.WriteLine(i.ToString());
            }
        }
    }
}
