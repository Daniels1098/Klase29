using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json;

namespace HomeWork1
{
    class Utilis
    {
        public static void getValue()
        {
            float x = float.Parse(Console.ReadLine());
            Console.Write("Ievadi skaitli y: ");
            float y = float.Parse(Console.ReadLine());
            Console.Write("Ievadi aritmētisko operāciju (+, -, / vai *): ");
            string u = Console.ReadLine();
            if (u.Equals("+"))
            {
                 Console.WriteLine($"{x} + {y} = {x + y}");
            }
            if (u.Equals("-"))
            {
                Console.WriteLine($"{x} - {y} = {x - y}");
            }
            if (u.Equals("/"))
            {
                Console.WriteLine($"{x} / {y} = {x / y}");
            }
            if (u.Equals("*"))
            {
                Console.WriteLine($"{x} * {y} = {x * y}");
            } 
            else
            {
                Console.WriteLine("Sistēma neatpazīst simbolu");
            }
        }
    }
}
      
            




    
