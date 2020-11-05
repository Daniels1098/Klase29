using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Day7._1
{
    class uzd4
    {
        public static string[] GetNonEmptyArray(string[] name)
        {
            List<string> list = new List<string>();
            Console.WriteLine("String arr");
            foreach (string item in name)
            {
                if (!String.IsNullOrEmpty(item))
                {
                    list.Add(item);
                }
            }
            return list.ToArray();
        }   
    }
}
