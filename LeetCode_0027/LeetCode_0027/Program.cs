//20230130 by hungyufeather@gmail.com
using System;

namespace LeetCode_0027
{
    public class Solution
    {
        public int RemoveElement(int[] nums, int val)
        {
            //快慢雙指針
            int slowIndex = 0;
            for (int fastIndex = 0; fastIndex < nums.Length; fastIndex++)
            {
                if (nums[fastIndex] != val)
                {
                    nums[slowIndex] = nums[fastIndex];
                    slowIndex++;
                }
            }
            return slowIndex;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int [] input = new int[] { 3, 2, 2, 3 };
            int val = 3;
            Solution solution = new Solution();
            Console.WriteLine(solution.RemoveElement(input,val));
            Console.ReadKey();
        }
    }
}
