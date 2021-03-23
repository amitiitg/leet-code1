using System;
using System.Collections.Generic;
using System.Text;

namespace TestIdeas
{
    /**
     * Definition for singly-linked list.
     * public class ListNode {
     *     public int val;
     *     public ListNode next;
     *     public ListNode(int val=0, ListNode next=null) {
     *         this.val = val;
     *         this.next = next;
     *     }
     * }
     */
    public class MergeLL
    {
        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            ListNode mergedHead = null, mergeCurrent = null, currentL1 = l1, currentL2 = l2;

            if (l1 == null || l2 == null)
            {
                return (l1 == null) ? l2 : l1;
            }

            if (currentL1.vaue < currentL2.value)
            {
                mergeCurrent = currentL1;
                currentL1 = currentL1.next;
            }
            else
            {
                mergeCurrent = currentL2;
                currentL2 = currentL2.next;
            }

            mergedHead = mergeCurrent;
            while (currentL1 != null && currentL2 != null)
            {
                if (currentL1.val <= currentL2.val)
                {
                    mergeCurrent.next = currentL1;
                    currentL1 = currentL1.next;
                }
                else
                {
                    mergeCurrent.next = currentL2;
                    currentL2 = currentL2.next;
                }

                mergeCurrent = mergeCurrent.next;
            }

            if (currentL1 != null)
            {
                mergeCurrent.next = currentL1;
            }

            if (currentL2 != null)
            {
                mergeCurrent.next = currentL2;
            }

            return mergedHead;
        }
    }
}
