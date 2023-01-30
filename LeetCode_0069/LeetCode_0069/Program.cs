//20230129 by hungyufeather@gmail.com
using System;

namespace LeetCode_0069
{
    public class Solution
    {
        public int MySqrt(int x)
        {
            if (x<=1) return x;
            int left = 1;
            int right = x;
            while(left<=right)
            {
                int mid = right + (left - right) / 2;
                int sqrt = x / mid;
                if (sqrt == mid) return mid;
                else if (sqrt < mid) right = mid - 1;
                else left = mid + 1;
            }
            return right;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int input = 8;
            Solution solution = new Solution();
            Console.WriteLine(solution.MySqrt(input));
            Console.ReadKey();
        }
    }
}
