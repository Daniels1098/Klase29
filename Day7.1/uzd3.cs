using System;
using System.Collections.Generic;
using System.Text;

namespace Day7._1
{
    class uzd3
    {
        public static void PrintArrayValues(int[] array)
        {
            Console.WriteLine("int arr");
            foreach (int i in array)
                Console.Write(i+", ");
            Console.WriteLine(" ");
        }
        public static void PrintArrayValues(string[] array1)
        {
            Console.WriteLine("String arr");
            foreach (string i in array1)
                Console.Write(i + ", ");
            Console.WriteLine(" ");
        }
    }
}
