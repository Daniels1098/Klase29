using System;
using System.Collections;
using System.Globalization;
using System.Linq;

namespace Day4
{
    class Program
    {
        static void Task1()
        {
            Console.WriteLine("*********** TASK 1 ************");
            {
                string[] vardi = { "Jānis", "Laura", "Kaspars", "Pēteris", "Sāra", "Aleksandrs", };
                string[] x = vardi.ToArray();
                int i = 0;
                do
                {
                    Console.Write(vardi[i] + ", ");
                    i++;
                }
                while (i < x.Length);
                Console.WriteLine(" ");
                Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            }
        }
        static void Task2()
        {
            Console.WriteLine("*********** TASK 2 ************");
            int[] sk = { 1, 3, 4, 8, 0, 23 };
            for (int i = 0; i < sk.Length; i++)
            {
                Console.Write(sk[i] + ", ");
            }
            Console.WriteLine(" ");
            for (int i = 0; i < sk.Length; i++)
                if (sk[i] > 5)
                {
                    Console.Write(sk[i] + ", ");
                }
            Console.WriteLine(" ");

            Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
        }
        static void Task3()
        {
            Console.WriteLine("*********** TASK 3 ************");
            Console.WriteLine(" ");
            string[] vardi = { "Jānis", "Laura", "Kaspars", "Juris", "Pēteris", "Sāra", "Jana", "Aleksandrs", };
            string[] x = vardi.ToArray();
            for (int i = 0; i < x.Length; i++)
            {
                Console.Write(vardi[i] + ", ");
            }
            Console.WriteLine(" ");
            for (int i = 0; i < x.Length; i++)
                if (vardi[i].Contains('J'))
                {
                    Console.Write(vardi[i] + ", ");
                }
            Console.WriteLine(" ");
            Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
        }
        static void Task4()
        {
            Console.WriteLine("*********** TASK 4 ************");
            Console.WriteLine("Ievadiet masīva vērtības");
            int[] mm = new int[10];
            //int b;
            //i = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < mm.Length; i++)
            {
               mm[i] = i;
            
            

                Console.WriteLine(" ");
                Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            }
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
