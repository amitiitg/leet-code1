using System;
using System.Collections.Generic;
using System.Text;

namespace TestIdeas.Medium
{
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

    class RemoveNthNode
    {
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            ListNode curr = head;
            int length = 0;
            while (curr != null)
            {
                curr = curr.next;
                length++;
            }

            if (length - n + 1 > 0)
            {
                return RemoveNthFromStart(head, length - n + 1);
            }

            return head;
        }

        public ListNode RemoveNthFromStart(ListNode head, int n)
        {
            ListNode curr = head, prev = null;
            int count = 1;

            while (count < n && curr != null)
            {
                count++;
                prev = curr;
                curr = curr.next;
            }

            if (curr != null)
            {
                prev.next = curr.next;
            }

            return head;
        }
    }
}
