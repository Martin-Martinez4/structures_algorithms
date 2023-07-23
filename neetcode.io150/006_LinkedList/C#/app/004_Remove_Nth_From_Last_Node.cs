
using System.Collections.Generic;

namespace LinkedListSpace
{
    public partial class Solutions
    {
        /*
            Given the head of a linked list, remove the nth node from the end of the list and return its head.

            Example 1:

            Input: head = [1,2,3,4,5], n = 2
            Output: [1,2,3,5]
            Example 2:

            Input: head = [1], n = 1
            Output: []
            Example 3:

            Input: head = [1,2], n = 1
            Output: [1]

            Constraints:

            The number of nodes in the list is sz.
            1 <= sz <= 30
            0 <= Node.val <= 100
            1 <= n <= sz
 
        */
        /*
            - Slow and Fast Pointer
                - Fast pointer gets n .next head start
                - if fast Pointer.next is null save the current position of the slow pointer.  
        */

        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {

            if(n == 0)
            {
                return head;
            }
            ListNode dummy = new ListNode(0, head);
            ListNode slowPntr = dummy;
            ListNode fastPntr = head;

            for (int i = 0; i < n; i++)
            {

                fastPntr = fastPntr.next;
            }

            while (fastPntr != null)
            {
                slowPntr = slowPntr.next;
                fastPntr = fastPntr.next;
            }

            slowPntr.next = slowPntr.next.next;;

            return dummy.next;
        }

    }
}

