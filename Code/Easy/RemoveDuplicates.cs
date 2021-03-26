using System;
using System.Collections.Generic;
using System.Text;

namespace TestIdeas.Easy
{
    class RemoveDuplicates
    {
        public ListNode DeleteDuplicatesFromList(ListNode head)
        {
            ListNode prev = null, curr = head, newHead = head;

            while (curr != null)
            {
                if (prev != null && prev.val == curr.val)
                {
                    prev.next = curr.next;
                }
                else
                {
                    prev = curr;
                }

                curr = curr.next;
            }

            return newHead;
        }
    }
}
