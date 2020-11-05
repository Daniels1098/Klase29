using System;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Schema;

namespace Day3
{
    class Program
    {
        enum Weekdays
        {
            Monday = 1,
            tuesday = 2,
            Wensday = 3,
            Thursday = 4,
            Friday = 5,
            Satyrday = 6,
            Sundayday = 7,
        }
        // WeekDays = WeekDays.Monday;
        static void Task1()
        {
            Console.WriteLine("*********** TASK 1 ************");
            int[] Array = { 1, 6, 7, 78, 9, 9 };
            for (int i = 0; i < Array.Length; i++)
                Console.Write(+Array[i] + ",");
            Console.WriteLine(" ");
            Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
        }

        static void Task2()
        {
            Console.WriteLine("*********** TASK 2 ************");
            Console.WriteLine("Vai Jūs vēlaties pusdienas? (atbilde True/False");
            String x = Console.ReadLine().ToLower();
            bool v = bool.Parse(x);
            if (!v)
            {
                Console.WriteLine("Jums pusdienas nebūs");
            }
            else
            {
                Console.WriteLine("Jūsu pusdienas ir gatavas");
            }
            Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
        }
        static void Task3()
        {
            Console.WriteLine("*********** TASK 3 ************");
            int x = 0;
            while (x < 20)
            {
                Console.WriteLine(true);
                x++;
            }
            if (x >= 21)
            {
                Console.WriteLine(false);
            }
            Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
        }
        static void Task4()
        {
            Console.WriteLine("*********** TASK 4 ************");
            Console.WriteLine("Ievadiet skaitli: ");
            int x = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < x;)
            {
                Console.WriteLine($"Hello World");
                i++;
            }

            Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
        }
        static void Task5()
        {
            Console.WriteLine("*********** TASK 5 ************");
            int[] masivs = { 100, 200, 233, 66, 77, 98 };

            Console.Write(masivs[0] + "....");
            Console.Write(masivs.Last());
            Console.WriteLine(" ");
            Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");

        }
        static void Task6()
        {
            Console.WriteLine("*********** TASK 6 ************");
            int[] masivs = new int[7] { 7, 4, 7, 3, 6, 9, 2 };
            foreach (int number in masivs)
            {
                Console.Write( number+",");

            }
            Console.WriteLine("   ");
            int x = Array.IndexOf(masivs, 3);
            masivs[x] = 10;
            foreach (int number in masivs)
            {
                Console.Write(masivs+",");
            }
            Console.WriteLine(" ");
            Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
        }
        static void Task7()
        {
            Console.WriteLine("*********** TASK 7 ************");
            string[] array = new string[] { "Janis", "Peteris", "Andris" };
            Console.WriteLine(String.Join(",", array));
            Console.WriteLine(array[1]);
            string[] array1 = new string[] { "Janis", "Peteris", "Jēkabs" };
            Console.WriteLine(String.Join(",", array1));
            Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
        }
        static void Task8()
        {
            Console.WriteLine("*********** TASK 8 ************");
            Weekdays wd = Weekdays.Friday;
            Console.WriteLine(wd);
            Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
        }
        static void Task9()
        {
            Console.WriteLine("*********** TASK 9, DIE HARD ************");
            Console.WriteLine("Ievadi skaitli līdz 20 (ieskaitot)");
            string ievade = Console.ReadLine();
            int j;

            while (!int.TryParse(ievade, out j))
            {
                Console.WriteLine("Kļuda, ievadi ciparu!");
                Console.ReadLine();
            }
             j = Convert.ToInt32(Console.ReadLine());
           
            int i = 1;
            do
            {
                Console.WriteLine( i+"x"+j+"="+(i * j));
                i++;
            } while (i <= j && j <= 20);
            Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
        
    
                
            
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine(" ");
                Console.WriteLine("Ievadiet uzdevuma nr:");
                int Task = Convert.ToInt32(Console.ReadLine());
                switch (Task)
                {
                    case 1:
                        Task1();
                        break;

                    case 2:
                        Task2();
                        break;
                    case 3:
                        Task3();
                        break;
                    case 4:
                        Task4();
                        break;
                    case 5:
                        Task5();
                        break;
                    case 6:
                        Task6();
                        break;
                    case 7:
                        Task7();
                        break;
                    case 8:
                        Task8();
                        break;
                    case 9:
                        Task9();
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

