using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Even_Fibonacci_Num
{
    class Program
    {
        static void Main(string[] args)
        {
            int limit = 4000000;
            Console.Write(evenFibSum(limit));
            Fibonacci();
        }

        public static void Fibonacci()
        {
            int result = 0;

            int fibNum1 = 1;
            int fibNum2 = 1;

            while (fibNum1 <= 4000000)
            {
                if (fibNum1 % 2 == 0)
                    result += fibNum1;

                int fibNum2Aux = fibNum1;
                fibNum1 = fibNum2 + fibNum1;
                fibNum2 = fibNum2Aux;
            }
            Console.WriteLine("Sum of even fibonacci numbers below 4 million is: " + result);
        }

        static int evenFibSum(int limit)
        {
            if (limit < 2)
                return 0;

            // Initialize first two even 
            // prime numbers and their sum 
            long ef1 = 0, ef2 = 2;
            long sum = ef1 + ef2;

            // calculating sum of even  
            // Fibonacci value 
            while (ef2 <= limit)
            {

                // get next even value of  
                // Fibonacci sequence 
                long ef3 = 4 * ef2 + ef1;

                // If we go beyond limit, 
                // we break loop 
                if (ef3 > limit)
                    break;

                // Move to next even number 
                // and update sum 
                ef1 = ef2;
                ef2 = ef3;
                sum += ef2;
            }

            return (int)sum;
        }
    }
}
