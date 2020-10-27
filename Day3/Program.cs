using System;

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
            int[] Array = { 1, 6, 7, 78, 9, 9 };
            for (int i = 0; i < Array.Length; i++)
                Console.Write(Array[i]+",");
        }
        static void Task2() 
        {
            Console.WriteLine("Vai Jūs vēlaties pusdienas? (atbilde True/False");
            String x = Console.ReadLine().ToLower();

            bool x = true;
            {
                Console.WriteLine("Jūsu pusdienas ir gatavas");
            }

            if (x == true && x != true ) ? 


        }


        static void Main(string[] args)
        {
            Console.WriteLine("Ievadiet uzdevuma nr:");
            int Task = Convert.ToInt32(Console.ReadLine());
            NewMethod(Task);
            static void NewMethod(int Task)
            {
                switch (Task)
                {
                    case 1:
                        Task1();
                        break;

                    case 2:
                        // Task2();
                        break;

                }
            }
        }
    }
}

