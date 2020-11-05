using System;
using System.Collections.Generic;
using System.Text;

namespace Day6
{
    class BeginUzd2
    {
        public static void PrintMyName(string name, string surname)
        {
          //  string a = "Daniels";
          //  string b = "Petrovskis";
            var x = name.ToUpper()[0];
            Console.WriteLine($"{x}.{surname}");
        }
    }
}
