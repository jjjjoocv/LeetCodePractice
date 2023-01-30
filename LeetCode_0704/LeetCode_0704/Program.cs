//20230130 by hungyufeather@gmail.com
using System;

namespace LeetCode_0704
{
    public class Solution
    {
        public int Search(int[] nums, int target)
        {
            //使用左閉右閉，包含左index的值，也包含右index的值
            int left = 0;
            int right = nums.Length - 1;
            while (left <= right)
            {
                int middle = left + (right - left) / 2;
                if (nums[middle] > target) right = middle - 1;//middle不包含在target內，下次判斷區間右邊 middle - 1
                else if (nums[middle] < target) left = middle + 1;//middle不包含在target內，下次判斷區間左邊 middle + 1
                else return middle;
            }
            return -1;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] input = new int[] { -1, 0, 3, 5, 9, 12 };
            int target = 9;
            Solution solution = new Solution();
            Console.WriteLine(solution.Search(input,target));
            Console.ReadKey();
        }
    }
}
