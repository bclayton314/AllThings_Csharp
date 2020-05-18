using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algos_Structs1
{
    class Algo_Structs1
    {
        //Remove Duplicates from Sorted Array
        /*Given a sorted array nums, remove the duplicates 
         * in-place such that each element appear only once 
         * and return the new length.
          Do not allocate extra space for another array, 
          you must do this by modifying the input array 
          in-place with O(1) extra memory.
        */
        static void Main(string[] args)
        {
            //int[] array = {0, 0, 1, 1, 1, 2, 2, 3, 3, 4};

            //int endOfList = DeleteDuplicates(array);

            //for (int i = 0; i < endOfList; i++)
            //{
            //    Console.WriteLine(array[i]);
            //}

           
        }

        public static int DeleteDuplicates(int[] array)
        {
            if (array.Length == 0)
                return 0;

            int endOfList = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[endOfList] != array[i])
                {
                    endOfList++;
                    array[endOfList] = array[i];
                }
                
            }
            return endOfList + 1;
        }

        //Rotate Array
        /*Given an array, rotate the array to the right 
        by k steps, where k is non-negative.

        Follow up:

        Try to come up as many solutions as you can, 
        there are at least 3 different ways to solve 
        this problem.
        Could you do it in-place with O(1) extra space?
        */

        //public static int RotateArray(int[] array1, int k)
        //{
        //    k = array1.Length;
        //    reverse(array1, 0, array1.Length - 1);
        //    reverse(array1, 0, k - 1);
        //    reverse(array1, k, array1.Length - 1);
        //}
        //public void reverse(int[] array1, int start, int end)
        //{
        //    while (start < end)
        //    {
        //        int temp = array1[start];
        //        array1[start] = array1[end];
        //        array1[end] = temp;
        //        start++;
        //        end--;
        //    }
        //}

        //public static int MultThreeFive()
        //{
        //    int limit = 1000;
        //    int sum = 0;

        //    for (int i = 0; i < limit; i++)
        //    {
        //        if (i % 3 == 0 || i % 5 == 0)
        //            sum += i;
        //    }

        //    return sum;


        //}
    }
}
