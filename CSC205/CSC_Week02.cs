using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace CSC205_mod_intro
{
    class Program
    {
        static void Main(string[] args)
        {
            //WEEK 2
            //Problem 1
            Console.WriteLine(WriteAverage(2, 7));

            //Problem 2
            //SEE BELOW

            //Problem 3
            WriteEuropean("Monday", 13, "January", 1999);

            //Problem 4
            //SEE BELOW

            //Problem 5
            WriteAmerican("Monday", 13, "January", 1999);

        }
        static double WriteAverage(int x, int y)
        {
            double result = ((double)x + (double)y) / 2;
            return result;
        }
        //public static void WriteEuropean(string day, int date, string month, int year)
        //{
        //    Console.WriteLine("Please enter a day(Monday - Sunday: ");
        //    string day = Console.ReadLine();
        //    Console.WriteLine("Please enter a date(1 - 31): ");
        //    int date = int.Parse(Console.ReadLine());
        //    Console.WriteLine("Please enter a month(January - December): ");
        //    string month = Console.ReadLine();
        //    Console.WriteLine("Please enter a year(#): ");
        //    int year = int.Parse(Console.ReadLine());
        //}
        public static void WriteEuropean(string day, int date, string month, int year)
        {
        Console.WriteLine("The date in Europe is: {0} {1} {2}, {3}", day, date, month, year);
        }
        public static void WriteAmerican(string day, int date, string month, int year)
        {
            Console.WriteLine("The date in America is: {0}, {1} {2}, {3}", day, month, date, year);
        }
    }
}
