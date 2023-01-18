//20230118 by hungyufeather@gmail.com
using System;
using System.Collections.Generic;

namespace LeetCode_0605
{
    public class Solution
    {
        public bool CanPlaceFlowers(int[] flowerbed, int n)
        {
            for (int i = 0; i < flowerbed.Length; i++)
            {
                if ((i == 0 || flowerbed[i - 1] == 0) && flowerbed[i] == 0 && (i == flowerbed.Length - 1 || flowerbed[i + 1] == 0))
                {
                    flowerbed[i] = 1;
                    n--;
                }
                if (n <= 0) return true;
            }
            return false;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
            int[] input = new int[] { 1, 0, 0, 0, 1 };
            Solution solution = new Solution();
            Console.WriteLine(solution.CanPlaceFlowers(input, num));
            Console.ReadKey();
        }
    }
}
