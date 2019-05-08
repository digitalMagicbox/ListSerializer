using System;
using System.Collections.Generic;
using System.Text;

namespace ListSerializer
{
    public static class Extensions
    {
        public static List<int> ToInt32(this List<string> hex)
        {
            var dec = new List<int>();
            foreach (var s in hex)
            {
                dec.Add(Convert.ToInt32(s, 16));
            }
            return dec;
        }

        public static List<string> ToHex(this List<int> dec)
        {
            var hex = new List<string>();
            foreach (var d in dec)
            {
                hex.Add($"0x{d.ToString("x8")}");
            }
            return hex;
        }
    }
}
