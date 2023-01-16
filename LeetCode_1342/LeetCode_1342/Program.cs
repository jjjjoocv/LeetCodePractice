//20230116 by hungyufeather@gmail.com
using System;

namespace LeetCode_1342
{
    public class Solution
    {
        public int NumberOfSteps(int num)
        {
            int step = 0;
            while (num != 0)
            {
                if (num % 2 == 0) num /= 2;
                else num -= 1;
                step++;
            }
            return step;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int num = 25;
            Solution solution = new Solution();
            Console.WriteLine(solution.NumberOfSteps(num));

            Console.ReadKey();
        }
    }
}
