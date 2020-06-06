using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC205_Quiz4
{
    class CSC205_Quiz4
    {


        static void Main(string[] args)
        {
            int x = userSum("Please enter 1st number: "); //Calling method with display message
            int y = userSum("Please enter 2nd number: "); //Calling method with second message

            int intSum = x + y; //Adding the two user inputs
            Console.WriteLine("Your sum is {0}.", intSum); //Displaying sum

        }
        static public int userSum(string str1)
        {  


            Console.WriteLine(str1);    //Printing the string parameter asking for user input
            int num1 = int.Parse(Console.ReadLine()); //Converting to integer type
            return num1; //Returning an integer value
            
        }
    }
}
            