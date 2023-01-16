//20230116 by hungyufeather@gmail.com
using System;
using System.Linq;

namespace LeetCode_1480
{
    public class Solution
    {
        public int[] RunningSum(int[] nums)
        {
            for (int i = 1; i < nums.Length; i++)
            {
                nums[i] += nums[i - 1];
            }
            return nums;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] input = new int[]{ 1, 2, 3, 4 };
            Solution solution = new Solution();
            solution.RunningSum(input).ToList().ForEach(Console.WriteLine);

            Console.ReadKey();
        }
    }
}
