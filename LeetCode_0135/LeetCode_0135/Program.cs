//20230117 by hungyufeather@gmail.com
using System;
using System.Linq;

namespace LeetCode_0135
{
    public class Solution
    {
        public int Candy(int[] ratings)
        {
            int count = ratings.Length;
            if (count == 1) return count;
            int[] candy = new int[count];
            Array.Fill(candy, 1);

            for (int i = 1; i < count; i++)
            {
                if (ratings[i - 1] < ratings[i]) candy[i] = candy[i-1] + 1;
            }
            for (int i = count - 1; i > 0; i--)
            {
                if (ratings[i - 1] > ratings[i]) candy[i - 1] = Math.Max(candy[i - 1], candy[i] + 1);
            }
            return candy.Sum();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] input = new int[] { 1, 0, 2 };
            Solution solution = new Solution();
            Console.WriteLine(solution.Candy(input));
            Console.ReadKey();
        }
    }
}
