using System;
using System.Linq;

namespace Trading_Apple_Stocks
{

    /* Writing programming interview questions hasn't made me rich. Maybe trading Apple stocks will.

      Suppose we could access yesterday's stock prices as an array, where:

     The values are the price in dollars of Apple stock.
     A higher index indicates a later time.

     So if the stock cost $500 at 10:30am and $550 at 11:00am, then:

     stockPricesYesterday[60] = 500;

     Write an efficient function that takes stockPricesYesterday and returns the best profit I could have made from 1 purchase and 1 sale of 1 Apple stock yesterday.

     For example:

   int[] stockPricesYesterday = { 10, 7, 5, 8, 11, 9 };

 // Returns 6 (buying for $5 and selling for $11)
     GetMaxProfit(stockPricesYesterday);

     No "shorting"—you must buy before you sell.You may not buy and sell in the same time step (at least 1 minute must pass). 
     */
    class Program
    {
        public static int MyFunction(int[] appleStock)
        {
            // Write the body of your function here         
            return appleStock.Max() - appleStock.Take(Array.LastIndexOf(appleStock, appleStock.Max()) + 1).Min(); ;
        }

        public static void Main(string[] args)
        {
            // Run your function through some test cases here.
            // Remember: debugging is half the battle!
            int[] testInput = { 10,2,5,5,7,23,5};
            int[] testInput1 = { 10, 7, 5, 8, 11, 9 };
            Console.WriteLine(MyFunction(testInput1));
            Console.ReadLine();
        }


    }
}
