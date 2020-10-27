using System;
using System.Data;

namespace Day2
{
    class Program
    {

        // static void Main(string[] args);
        static void Task21()
        {
            Console.WriteLine("Ievadi pirmo skaitli robežās no 0 - 20");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ievadi otru skaitli robežās no 30 - 50");
            int y = Convert.ToInt32(Console.ReadLine());
            String xy = (20 > x && x > 0 && 30 < y && y < 50) ?
                "Summa = " + (x + y) : "Vienas vai abi mainīgie arpus robežām";
            Console.WriteLine(xy);
        }
        static void Task22()
        {

            Char[] maja = { 'a', 'b', 'c', 'd' };
            Char[] maja1 = { 'e', 'f', 'g', 'h' };
            Char[] maja2 = { 'i', 'j', 'k', 'l' };
            Char[] maja3 = { 'm', 'n', 'o', 'p' };
            Char[] maja4 = { 'r', 's', 't', 'u' };

            Console.WriteLine("Ierakstiet lietas nosaukumu: ");
            String lieta = Console.ReadLine().ToLower();
            char x = lieta.ToCharArray()[0];


            for (int i = 0; i < maja.Length; i++)
            
                if (x.Equals(maja[i]))
                {
                    Console.WriteLine(x + " Priekšmets jānovieto 1. stāvā.");
                }
                else if (x.Equals(maja1[i]))
                {
                    Console.WriteLine(" Priekšmets jānovieto 2. stāvā.");

                }
                else if (x.Equals(maja2[i]))
                {
                    Console.WriteLine(" Priekšmets jānovieto 3. stāvā.");
                }
                else if (x.Equals(maja3[i]))
                {
                    Console.WriteLine(" Priekšmets jānovieto 4. stāvā.");
                }
                else x.Equals(maja4[i]);
                {

                    Console.WriteLine(x + "Priekšmets jānovieto 5. stāvā.");
            }
            
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Ievadiet uzdevuma nr:");
            int Task = Convert.ToInt32(Console.ReadLine());
            NewMethod(Task);
        }
        static void NewMethod(int Task)
        {
            switch (Task)
            {
                case 1:
                    Task21();
                    break;

                case 2:
                    Task22();
                    break;
            }
        }
    }
}

    











