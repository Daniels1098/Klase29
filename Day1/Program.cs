using System;

namespace Day1
{
    class Program
    {
        static void Task1()
        {
            string a = "Daniels Petrovskis";
            Console.WriteLine(a);
        }
        static void Task2()
        {
            int x = 10;
            double y = 10;
            bool z;
            string a;
             z = true;
             a = "Daniels";

            Console.WriteLine( y);
            Console.WriteLine(x);
            Console.WriteLine(z);
            Console.WriteLine(a);
        }
        static void Task3() 
        {
            int x;
            int y;
            x = 10;
            y = 15;
            int z = x + y;

            Console.WriteLine(z);
        }
        static void Task4() 
        {
            Console.WriteLine("Ievadiet vardu un uzvārdu");
            string x = Console.ReadLine();
            Console.WriteLine(x);

        }
        static void Task5() 
        {
            Console.WriteLine("Ievadiet vardu un uzvārdu");
            String x = Console.ReadLine();
            String y = Console.ReadLine();
            //Console.WriteLine(x);
            //Console.WriteLine(y);
            String m = x.Substring(0, 1).ToUpper(); // +x.Substring(1);
            String n = y.Substring(0, 1).ToUpper() + y.Substring(1);
            Console.WriteLine(m + x.Substring(1) + " " + n);
            Console.WriteLine(m+"."+ n);

            //Console.WriteLine("n");




        }

        static void Main(string[] argsa)
        {
            Console.WriteLine("Ievadiet  ciparu");
            String Task = Console.ReadLine();

            switch (Task) 
            {
                case "1":
                    Task1();
                    break;
                case "2":
                    Task2();
                    break;
                case "3":
                    Task3();
                    break;
                case "4":
                    Task4();
                    break;
                case "5":
                    Task5();
                    break;

            }
            
                
            //Task2();
            //Task3();
            //Task4();
            //Task5();
        }
    }
}
