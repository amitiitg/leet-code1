using System;
using System.Collections.Generic;
using System.Text;

namespace TestIdeas.Medium
{
    class SwapPairs
    {
        public ListNode SwapPairs1(ListNode head)
        {
            ListNode curr = head, next = null, prev = null;
            if (curr == null)
            {
                return head;
            }

            next = curr.next;
            ListNode nHead = head;
            while (curr != null && next != null)
            {
                if (prev != null)
                {
                    prev.next = next;
                }
                else
                {
                    nHead = next;
                }
                prev = curr;

                curr.next = next.next;
                next.next = curr;
                curr = curr.next;
                next = curr.next;
            }

            return nHead;
        }
    }
}
