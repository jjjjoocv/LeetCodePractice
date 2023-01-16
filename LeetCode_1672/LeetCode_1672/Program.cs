//20230116 by hungyufeather@gmail.com
using System;
using System.Linq;

namespace LeetCode_1672
{
    public class Solution
    {
        public int MaximumWealth(int[][] accounts)
        {
            //int sum = 0;
            //int max = 0;
            //foreach (var array in accounts)
            //{
            //    sum = 0;
            //    foreach (var num in array) { sum += num; }
            //if (sum > max) { max = sum; }
            //}
            //return max;
            return accounts.Max(array => array.Sum());
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[][] input = new int[2][];
            input[0] = new int[2] { 3, 2 };
            input[1] = new int[3] { 1, 1, 3 };
            Solution solution = new Solution();
            Console.WriteLine(solution.MaximumWealth(input));

            Console.ReadKey();
        }
    }
}
