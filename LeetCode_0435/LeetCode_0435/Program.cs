//20230118 by hungyufeather@gmail.com
using System;
using System.Collections.Generic;

namespace LeetCode_0435
{
    public class Solution
    {
        public int EraseOverlapIntervals(int[][] intervals)
        {
            Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));
            int count = 0;
            int prevEnd = intervals[0][1];

            for(int i = 1; i < intervals.Length; i++)
            {
                if (intervals[i][0] < prevEnd)
                {
                    count++;
                    prevEnd = Math.Min(prevEnd, intervals[i][1]);
                }
                else prevEnd = intervals[i][1];
            }
            return count;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[][] input = new int[4][];
            input[0] = new[] { 1, 2 };
            input[1] = new[] { 2, 3 };
            input[2] = new[] { 3, 4 };
            input[3] = new[] { 1, 3 };
            Solution solution = new Solution();
            Console.WriteLine(solution.EraseOverlapIntervals(input));
            Console.ReadKey();
        }
    }
}
