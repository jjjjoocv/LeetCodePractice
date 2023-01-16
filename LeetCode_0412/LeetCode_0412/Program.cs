//20230116 by hungyufeather@gmail.com
using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode_412
{
    public class Solution
    {
        public IList<string> FizzBuzz(int num)
        {
            List<string> xList = new List<string>();
            int i = 1;
            for (i = 1; i < num + 1; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                    xList.Add("FizzBuzz");
                else if (i % 3 == 0)
                    xList.Add("Fizz");
                else if (i % 5 == 0)
                    xList.Add("Buzz");
                else
                    xList.Add(i.ToString());
            }
            return xList;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int num = 18;
            Solution solution = new Solution();
            solution.FizzBuzz(num).ToList().ForEach(Console.WriteLine);

            Console.ReadKey();
        }
    }
}
