using System;

namespace _016_Best_Time_to_Buy_and_Sell_Stock_III
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Say you have an array for which the ith element is the price of a given stock on day i.

                Design an algorithm to find the maximum profit. You may complete at most two transactions.

                Note: You may not engage in multiple transactions at the same time (i.e., you must sell the stock before you buy again).

                Example 1:

                Input: [3,3,5,0,0,3,1,4]
                Output: 6

                Explanation: Buy on day 4 (price = 0) and sell on day 6 (price = 3), profit = 3-0 = 3.
                             Then buy on day 7 (price = 1) and sell on day 8 (price = 4), profit = 4-1 = 3.
            */

            var prices = new int[] { 3, 3, 5, 0, 0, 3, 1, 4 };

            var solution = new Solution();

            Console.WriteLine(solution.MaxProfit(prices) == 6);
        }
    }

    public class Solution
    {
        public int MaxProfit(int[] prices)
        {
            throw new NotImplementedException();
        }
    }
}
