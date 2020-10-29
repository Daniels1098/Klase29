using System;
using System.Data;

namespace Day2
{
    class Program
    {

        // static void Main(string[] args);
        static void Task21()
        {
            Console.WriteLine("----------TASK 1 ---------");
            Console.WriteLine("Ievadi pirmo skaitli robežās no 0 - 20");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ievadi otru skaitli robežās no 30 - 50");
            int y = Convert.ToInt32(Console.ReadLine());
            String xy = (20 > x && x > 0 && 30 < y && y < 50) ?
                "Summa = " + (x + y) : "Vienas vai abi mainīgie arpus robežām";
            Console.WriteLine(xy);
            Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
        }

        static void Task22()
        {
            Console.WriteLine("----------TASK 2 ---------");
            Console.WriteLine("Ierakstiet lietas nosaukumu: ");
            String lieta = Console.ReadLine();
            char x = lieta.ToLower()[0];

            if (x == 'a' || x == 'b' || x == 'c' || x == 'd')
            {
                Console.WriteLine(x + " Priekšmets jānovieto 1. stāvā.");
            }
            else if (x == 'e' || x == 'f' || x == 'g' || x == 'h')
            {
                Console.WriteLine(" Priekšmets jānovieto 2. stāvā.");
            }
            else if (x == 'i' || x == 'j' || x == 'k' || x == 'l')
            {
                Console.WriteLine(" Priekšmets jānovieto 3. stāvā.");
            }
            else if (x == 'm' || x == 'n' || x == 'o' || x == 'p')
            {
                Console.WriteLine(" Priekšmets jānovieto 4. stāvā.");
            }
            else if (x == 'r' || x == 's' || x == 't' || x == 'u')
            {
                Console.WriteLine(x + "Priekšmets jānovieto 5. stāvā.");
            }
            else Console.WriteLine(x + "Priekšmets jānovieto 5. stāvā.");
            Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
        }
        enum Eglitesveids
        {
            Tradicionālā,
            Sudrabeglīte
        }
        static void Task23()
        {
            Console.WriteLine("----------TASK 3 ---------");
            Console.WriteLine("Ieraksti kāda egli esi iegadajies tradicionalo vai sudraba: ");
            var e = Console.ReadLine().ToLower();
            {
                if (e.Contains("s"))
                {
                    Console.WriteLine("Eglīti novietot tikai kamīnzālē.");
                }
                else if (e.Contains("t"))
                {
                    Console.WriteLine("Ievadi eglites paramterus:");
                    Console.WriteLine("Eglītes augstums: ");
                    int x = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Eglītes zaru diametrs: ");
                    int y = Convert.ToInt32(Console.ReadLine());
                    if (50 <= x && x < 100 && 100 <= y && y < 150)
                    {
                        Console.WriteLine("Eglīti novietot viesistaba 1.");
                    }
                    else if (100 <= x && x < 150 && 150 <= y && y < 200)
                    {
                        Console.WriteLine("Eglīti novietot viesistaba 2.");
                    }
                    else if (150 <= x && x <= 300 && 200 <= y && y <= 300)
                    {
                        Console.WriteLine("Eglīti novietot kamīnzālē.");
                    }
                }
                else
                {
                    Console.WriteLine("Nederīgi eglītes parametri.");
                }
            }
        }
        static void Task24()
        {
            Console.WriteLine("----------TASK 4 (Extra) ---------");
            Console.WriteLine("Spēlētājs 1 Ievadiet savu vārdu: ");
            string a = Console.ReadLine();
            Console.WriteLine("Spēlētājs 2 Ievadiet savu vārdu: ");
            string b = Console.ReadLine();
            Console.WriteLine("3 reizes ievadi " + a + " punktus");
            int c = 0;
            for (int i = 0; i < 3; i++)
            {
                c += Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("3 reizes ievadi " + b + " punktus");
            int d = 0;
            for (int i = 0; i < 3; i++)
            {
                d += Convert.ToInt32(Console.ReadLine());
            }
            if (c == d)
            {
                Console.WriteLine("Rezūltāti ir vienādi.");
            }
            else
            {
                string cd = (c < d && c > d) ? $"Uzvar spelētājs NR 2." : "Uzvar spēlētājs nr 1.";
                Console.WriteLine(cd);
                Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            }
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine(" ");
                Console.WriteLine("Ievadiet uzdevuma nr. no 1 - 4, vai 99 lai izietu no programmas.");
                int Task = Convert.ToInt32(Console.ReadLine());

                switch (Task)
                {
                    case 1:
                        Task21();
                        break;

                    case 2:
                        Task22();
                        break;
                    case 3:
                        Task23();
                        break;
                    case 4:
                        Task24();
                        break;
                    case 99:
                        return;
                    default:
                        Console.WriteLine($"Uzdevums '{Task}'  nav nodefinēts");
                        break;
                }
            }
        }
    }
}













