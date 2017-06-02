using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Challanges
{
    /* You have an array of integers, and for each index you want to find the product of every integer except the integer at that index.
       Write a function GetProductsOfAllIntsExceptAtIndex() that takes an array of integers and returns an array of the products.
       For example, given:

       [1, 7, 3, 4]

       your function would return:

       [84, 12, 28, 21]

       by calculating:

       [7 * 3 * 4,  1 * 3 * 4,  1 * 7 * 4,  1 * 7 * 3]

       Do not use division in your solution.
       Gotchas


       Does your function work if the input array contains zeroes? Remember—no division.


       We can do this in O(n)O(n)O(n) time and O(n)O(n)O(n) space!

   */
    class Program
    {
        
        // Write the body of your function here
        public static int[] MyFunction(int[] arr)
        {
            List<int> list = arr.ToList();
            int[] product = new int[arr.Length];
            int prod = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                list.RemoveAt(i);
                foreach (var item in list)
                {
                    prod *= item;
                }
                product[i] = prod;
                list = arr.ToList();
                prod = 1;
             
            }

            return product;
        }

        public static void Main(string[] args)
        {
            // Run your function through some test cases here.
            // Remember: debugging is half the battle!
            int[] testInput = { 0, 0, 0, 0 };
            int[] testInput1 = { 10, 1, 5, 7 };
            int[] testInput2 = { 0, 3, 2, 0 };

            foreach (var val in MyFunction(testInput1))
            {
                Console.WriteLine(val);
              
            }
            Console.ReadLine();
        }
    }
}






