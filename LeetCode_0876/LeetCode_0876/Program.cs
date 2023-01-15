//20230116 by hungyufeather@gmail.com
using System;

namespace LeetCode_0876
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val=0, ListNode next=null)
        {
            this.val = val;
            this.next = next;
        }
    }

    public class Solution
    {
        public ListNode MiddleNode(ListNode head)
        {
            ListNode middle = head;
            ListNode end = head;
            while (end != null && end.next != null)
            {
                middle = middle.next;
                end = end.next.next;
            }
            return middle;
        }

        public ListNode CreateLinkList(int[] input)
        {
            //ListNode x5 = new ListNode() { val = 5, next = null };
            //ListNode x4 = new ListNode() { val = 4, next = x5 };
            //ListNode x3 = new ListNode() { val = 3, next = x4 };
            //ListNode x2 = new ListNode() { val = 2, next = x3 };
            //ListNode x1 = new ListNode() { val = 1, next = x2 };
            ListNode y = null;
            for (int i = input.Length; i > 0; i--)
            {
                ListNode x = new ListNode() { val = input[i - 1], next = y };
                y = x;
            }
            return y;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] input = new int[] { 1, 2, 3, 4, 5 };
            Solution solution = new Solution();
            var x1 = solution.CreateLinkList(input);
            Console.WriteLine(solution.MiddleNode(x1).val);

            Console.ReadKey();
        }
    }
}
