using System;

namespace Day5
{
    class Program
    {
        static void Task1()
        {
            Console.WriteLine("*********** TASK 1 ************");
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

                     /*   case 2:
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
                            */
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
