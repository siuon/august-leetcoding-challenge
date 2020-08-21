using System.Net.Mime;
using System.Collections.Generic;
using System;

namespace _020_Reorder_List
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Given a singly linked list L: L0→L1→…→Ln-1→Ln,
                reorder it to: L0→Ln→L1→Ln-1→L2→Ln-2→…

                You may not modify the values in the list's nodes, only nodes itself may be changed.

                Example 1:

                Given 1->2->3->4, reorder it to 1->4->2->3.
            */

            var head = new ListNode(1);
            head.next = new ListNode(2);
            head.next.next = new ListNode(3);
            head.next.next.next = new ListNode(4);

            var solution = new Solution();

            solution.ReorderList(head);
        }
    }

    /*
     * Definition for singly-linked list.
     */
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    public class Solution
    {
        public void ReorderList(ListNode head)
        {
            throw new NotImplementedException();
        }
    }
}
