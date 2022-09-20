using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO:

            // Create an int Array and populate numbers 1-10
            int[] arrayOne = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

            /* Create two Lists of type int.
             * Name one List "evens"
             * Name the other List "odds"
             */
            List<int> evens = new List<int>();
            List<int> odds = new List<int>();

            /* Using either a foreach or for loop,
             * nest an if statement to check to see
             *  if a number is even or odd.
             * Then add those numbers to either the evens List
             * or the odds List
             */

            foreach (int num in arrayOne)
                if (num % 2 == 0)
                    evens.Add(num);
                else odds.Add(num);
            /* Now using foeach or for loops,
             * display each List of even and odd numbers
             *
             * Try to be creative in your display
             */
            Console.WriteLine("Between 1 and 10, the even digits are:");
            Console.WriteLine();
            evens.ForEach(x => Console.WriteLine(x));

            Console.WriteLine("Between 1 and 10, the odd digits are:");
            Console.WriteLine();
            odds.ForEach(x => Console.WriteLine(x));

        }
    }
}
