//20230119 by hungyufeather
using System;

namespace LeetCode_0452
{
    public class Solution
    {
        public int FindMinArrowShots(int[][] points)
        {
            if (points.Length < 2) return points.Length;//不用射箭 
            Array.Sort(points, (x1, x2) => x1[1].CompareTo(x2[1]));//陣列依xEnd值，由小排到大
            int balloonXEnd = points[0][1];//初始xEnd值最小氣球
            int arrowCount = 1;//初始必射一支箭

            foreach(var point in points)
            {
                if(point[0] > balloonXEnd)
                {
                    arrowCount++;
                    balloonXEnd = point[1];
                }
            }
            return arrowCount;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[][] input = new int[4][];
            input[0] = new int[] { 10, 16 };
            input[1] = new int[] { 2, 8 };
            input[2] = new int[] { 1, 6 };
            input[3] = new int[] { 7, 12 };
            Solution solution = new Solution();
            Console.WriteLine(solution.FindMinArrowShots(input));
        }
    }
}
