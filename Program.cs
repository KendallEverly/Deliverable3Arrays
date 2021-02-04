/*
 * Author: Kendall Everly
 * Date: 02/04/2021
 * Comments: This C# console application demonstrates the use of arrays without user input
 */
using System;

namespace Deliverable3Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //manually populated array
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25 };
            //itereate through array with foreach loop
            foreach (int i in numbers)
            {
                Console.Write("Element value = " + i + "\n");
            }
            //end foreach loop
        }
        //end of static
    }
    //end of class
}
//end of main
