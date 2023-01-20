//20230120 by hungyufeather@gmail.com
using System;

namespace LeetCode_0122
{
    public class Solution
    {
        public int MaxProfit(int[] prices)
        {
            int maxProfit = 0;
            for (int i = 0; i < prices.Length - 1; i++)
            {
                if (prices[i] < prices[i + 1])
                {
                    maxProfit += prices[i + 1] - prices[i];
                }
            }
            return maxProfit;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] input = new int[] { 7, 1, 5, 3, 6, 4 };
            Solution solution = new Solution();
            Console.WriteLine(solution.MaxProfit(input));
            Console.ReadKey();
        }
    }
}
