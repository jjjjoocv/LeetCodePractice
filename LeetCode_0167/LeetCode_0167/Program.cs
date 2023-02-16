//20230216 by hungyufeather@gmail.com
using System;

namespace LeetCode_0167
{
    public class Solution
    {
        public int[] IndexArray (int[] numbers, int target)
        {
            int left = 0;
            int right = numbers.Length - 1;
            while (left < right)
            {
                if (numbers[left] + numbers[right] == target) break;
                else if (numbers[left] + numbers[right] > target) right--;
                else left++;
            }
            return new int[2] { left + 1, right + 1 };
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] input = new int[4] { 2, 7, 11, 15 };
            int target = 9;
            Solution solution = new Solution();
            Console.WriteLine($"[{solution.IndexArray(input,target)[0]},{solution.IndexArray(input, target)[1]}]");
            Console.ReadKey();
        }
    }
}
