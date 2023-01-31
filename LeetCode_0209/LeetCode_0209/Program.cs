//20230131 by hungyufeather@gmail.com
using System;

namespace LeetCode_0209
{
    public class Solution
    {
        public int MinSubArrayLen(int target, int[] nums)
        {
            int n = nums.Length;
            int ans = int.MaxValue;
            int sum = 0;
            int start = 0;
            int end = 0;
            while (end < n)
            {
                sum += nums[end];
                while (sum >= target)
                {
                    ans = Math.Min(ans, end - start + 1);
                    sum -= nums[start];
                    start++;
                }
                end++;
            }
            return ans == int.MaxValue ? 0 : ans;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int target = 7;
            int[] input = new int[] { 2, 3, 1, 2, 4, 3 };
            Solution solution = new Solution();
            Console.WriteLine(solution.MinSubArrayLen(target,input));
            Console.ReadKey();
        }
    }
}
