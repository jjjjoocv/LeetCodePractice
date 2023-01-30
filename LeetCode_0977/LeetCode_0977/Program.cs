//20230130 by hungyufeather@gmail.com
using System;

namespace LeetCode_0977
{
    public class Solution
    {
        public int[] SortedSquares(int[] nums)
        {
            //頭尾雙指針向內逼近
            int leftIndex = 0;
            int rightIndex = nums.Length - 1;
            //由大到小抓值，從尾部向頭部存值
            int[] square = new int[nums.Length];
            int j = nums.Length - 1;
            while (leftIndex <= rightIndex)
            {
                if (nums[leftIndex] * nums[leftIndex] < nums[rightIndex] * nums[rightIndex])
                {
                    square[j] = nums[rightIndex] * nums[rightIndex];
                    rightIndex--;
                }
                else
                {
                    square[j] = nums[leftIndex] * nums[leftIndex];
                    leftIndex++;
                }
                j--;
            }
            return square;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] input = new int[] { -4, -1, 0, 3, 10 };
            Solution solution = new Solution();
            int[] square = solution.SortedSquares(input);
            foreach (int item in square)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
