using System.Text.RegularExpressions;

namespace SlidingWindow
{
    public partial class Solutions
    {
        /* Description
            You are given an array prices where prices[i] is the price of a given stock on the ith day.

            You want to maximize your profit by choosing a single day to buy one stock and choosing a different day in the future to sell that stock.

            Return the maximum profit you can achieve from this transaction. If you cannot achieve any profit, return 0.

            Example 1:

            Input: prices = [7,1,5,3,6,4]
            Output: 5
            Explanation: Buy on day 2 (price = 1) and sell on day 5 (price = 6), profit = 6-1 = 5.
            Note that buying on day 2 and selling on day 1 is not allowed because you must buy before you sell.
            Example 2:

            Input: prices = [7,6,4,3,1]
            Output: 0
            Explanation: In this case, no transactions are done and the max profit = 0.
        */
        // Left and right pointer
        // Left starts at 0 right starts at 1
        // If right encounters a number that is less than the left one move the left on to the right one. 
        // Keep track of the max and the index difference when the max was encountered
        public int MaxProfit(int[] prices)
        {

            int leftPntr = 0;
            int rightPntr = 1;
            int maxValue = 0;

            while (rightPntr < prices.Length)
            {
                int futurePrice = prices[rightPntr];
                int pastPrice = prices[leftPntr];
                int priceDiffernce = futurePrice - pastPrice;
                if (priceDiffernce > maxValue)
                {
                    maxValue = priceDiffernce;
                }

                if (futurePrice <= pastPrice)
                {
                    leftPntr = rightPntr;
                    if (rightPntr >= prices.Length)
                    {
                        break;
                    }
                }
                rightPntr++;
            }

            return maxValue;

        }
    }
}