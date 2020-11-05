using System;
using System.Collections.Generic;
using System.Text;

namespace Day7._1
{
    class uzd2
    {
        public static void PrintNameSurname(string nameSurname)
        {
            Console.WriteLine(nameSurname);
        }
        public static void PrintNameSurname(string name, string surname)
        {
            Console.WriteLine(name, surname);
        }
        public static void PrintNameAge(string name, string Age = "99")
        {
            Console.WriteLine($"{name} {Age}");
        }
    }
}   
