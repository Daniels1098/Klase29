using System;

namespace Day7._1
{
    class Program
    {
        static void Task2()
        {
            Console.WriteLine("*********** TASK 2 ************");
            Console.WriteLine(" ");
            uzd2.PrintNameSurname("Daniels");
            uzd2.PrintNameSurname("Daniels", "Petrovskis");
            uzd2.PrintNameAge("Daniels", "30");
            uzd2.PrintNameAge("Daniels");
            Console.WriteLine(" ");
            Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
        }
        static void Task3()
        {
            Console.WriteLine("*********** TASK 3 ************");
            Console.WriteLine(" ");
            int[] array = { 2, 4, 6, 11, 1, 15 };
            uzd3.PrintArrayValues(array);

            string[] array1 = { "JA", "NE", "13", "SRS" };
            uzd3.PrintArrayValues(array1);
            Console.WriteLine(" ");
            Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
        }
        static void Task4()
        {
            Console.WriteLine("*********** TASK 4 ************");
            Console.WriteLine(" ");
            string[] name = { "Jānis", " ", "Pēteris", "Antons", "", "Andris" };
            uzd3.PrintArrayValues(name);
            Console.WriteLine(" ");
            uzd3.PrintArrayValues(name);
            name = uzd4.GetNonEmptyArray(name);
            uzd3.PrintArrayValues(name);

            Console.WriteLine(" ");
            Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
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
                    //   case 1:
                    //    Task2();
                    //    break;

                    case 2:
                        Task2();
                        break;
                    case 3:
                        Task3();
                        break;
                    case 4:
                        Task4();
                        break;
                    /*   case 5:
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
                     */    //  break;
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
