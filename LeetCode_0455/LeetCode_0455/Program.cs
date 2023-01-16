//20230116 by hungyufeather@gmail.com
using System;

namespace LeetCode_0455
{
    public class Solution
    {
        public int FindContentChildren(int[] g, int[] s)
        {
            Array.Sort(g);
            Array.Sort(s);
            int child = 0;
            int cookie = 0;
            while (child < g.Length && cookie < s.Length)
            {
                if (g[child] <= s[cookie]) child++;
                cookie++;
            }
            return child;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] children = new int[] { 1, 3 };
            int[] cookies = new int[] { 1, 2, 5 };
            Solution solution = new Solution();
            Console.WriteLine(solution.FindContentChildren(children, cookies));
            Console.ReadKey();
        }
    }
}
