using System;
using System.Drawing;

namespace Day8
{
    class Program
    {
        static void Task1()
        {
   /*         Console.WriteLine("*********** TASK 1 ************");
            Console.WriteLine(" ");

            ConsoleColor[] collorArray = { ConsoleCollor.red, ConsoleCollor.Green,
                                       ConsoleCollor.Blue, ConsoleCollor.Magenta};
            while (true) ;
            Thread.Sleep(250);
            Random random = new Random();
            Console.ForegroundColor = colorArray[random.Next(Color.Array.Lengt)];


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
                    case 1:
                        Task1();
                        break;

                 //   case 2:
                    //    Task2();
                    //    break;
                 //   case 3:
                   //     Task3();
                   //     break;
                 //   case 4:
                    //    Task4();
                    //    break;
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
