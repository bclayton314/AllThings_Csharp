using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hmwrk_Week4
{
    class Program
    {
        static void Main(string[] args)
        {
            //int i = 0;
            //int j = 0;
            //int[] storeVal = new int[5];

            //while (i <= 4)
            //{
            //    Console.WriteLine("please enter the sales values (only multiples of 100 please) for store {0}: ", i + 1);
            //    storeVal[i] = int.Parse(Console.ReadLine());
            //    i++;
            //}

            //Console.WriteLine("\nSALES BAR CHART\n(Each * = $100)");

            //while (j <= 4)
            //{
            //    //used int becasue we're dealing with whole numbers,
            //    //would change to float if necessary
            //    int storeVal2 = storeVal[j] / 100;
            //    string storeDisplay = DisplayAsterisks(storeVal2);
            //    Console.Write($"Store {j + 1}: {storeDisplay}\n");
            //    j++;
            //}


            //Run a test, find out why the symbols keep being flushed to the left
            //https://docs.microsoft.com/en-us/dotnet/csharp/methods
            Console.WriteLine("Asterisks: " + DisplayAsterisks(5));

        }

        public static string DisplayAsterisks(int num)
        {
            char aster1 = char.Parse("*");
            int i = 1;
            while (i <= num)
            {
                Console.Write(aster1);
                i++;
            }
            return null;
        }
    }
}
