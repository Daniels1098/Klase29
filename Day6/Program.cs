using System;

namespace Day6
{
    class Program
    {
        static void Task1()
        {
            Console.WriteLine("*********** TASK 1 ************");
            BeginUzd1.PrintGreeting();
            BeginUzd1.PrintGreeting();
            BeginUzd1.PrintGreeting();

            Console.WriteLine(" ");
            Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
        }
        static void Task2()
        {
            Console.WriteLine("*********** TASK 2 ************");

            BeginUzd2.PrintMyName("Daniels", "Petrovskis");
            Console.WriteLine("");

            Console.WriteLine(" ");
            Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
        }
        static void Task3()
        {
            Console.WriteLine("*********** TASK 3 ************");
            BeginUzd3.PrintNameSurname(BeginUzd3.GetNameSurname());
            Console.WriteLine("Uzraksti vārdu.");

            Console.WriteLine(" ");
            Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
        }
        static void Task4()
        {
            Console.WriteLine("*********** TASK 4 ************");
            Console.WriteLine("Uzraksti skaitli: ");
            int n = Convert.ToInt32(Console.ReadLine());

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
