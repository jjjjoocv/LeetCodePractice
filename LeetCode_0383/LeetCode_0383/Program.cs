//20230116 by hungyufeather@gmail.com
using System;

namespace LeetCode_0383
{
    public class Solution
    {
        public bool CanConstruct(string ransomNote, string magazine)
        {
            if (ransomNote.Length > magazine.Length) return false;
            for (int i = 0; i < ransomNote.Length; i++)
            {
                int str = magazine.IndexOf(ransomNote[i]);
                if (str == -1) return false;
                magazine = magazine.Remove(str, 1);
            }
            return true;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string ransomNote = "ab";
            string magazine = "bba";
            Solution solution = new Solution();
            Console.WriteLine(solution.CanConstruct(ransomNote, magazine));
            Console.ReadKey();
        }
    }
}
