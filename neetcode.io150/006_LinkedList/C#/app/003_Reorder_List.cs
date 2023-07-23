
using System.Collections.Generic;

namespace LinkedListSpace
{
    public partial class Solutions
    {
        /*
            You are given the head of a singly linked-list. The list can be represented as:

            L0 → L1 → … → Ln - 1 → Ln
            Reorder the list to be on the following form:

            L0 → Ln → L1 → Ln - 1 → L2 → Ln - 2 → …
            You may not modify the values in the list's nodes. Only nodes themselves may be changed.

            

            Example 1:


            Input: head = [1,2,3,4]
            Output: [1,4,2,3]
            Example 2:


            Input: head = [1,2,3,4,5]
            Output: [1,5,2,4,3]
            

            Constraints:

            The number of nodes in the list is in the range [1, 5 * 104].
            1 <= Node.val <= 1000
            
        */


        /*  
            - Get to half way point
                - Two pointer
                - slow proceeds by one
                - faster proceeds by two
                - When the fast pointer is null the slow pointer is at the half way point
            - Split the list into two
                - half way point is the head of the new list
                - reverse the new list
                - (maybe there is a way to do this in place) 
        */

        public ListNode? ReverseList2(ListNode head)
        {
            ListNode? currentNode = head;
            ListNode? lastNode = null;

            while(currentNode != null)
            {
                ListNode? nextNode = currentNode.next;
                currentNode.next = lastNode;
                lastNode = currentNode;
                currentNode = nextNode;
            }

            return lastNode;
        }

        public void ReorderList(ListNode head)
        {
            if(head == null || head.next == null) return;

            // Find midPoint
            ListNode? slowPntr = head;
            ListNode? fastPntr = head.next;
            int nodesToChange = 1;

            while(true)
            {
                if(fastPntr == null || fastPntr.next == null) break;
                slowPntr = slowPntr.next;
                nodesToChange++;
                fastPntr = fastPntr.next.next;
            }

            // Do Merge
            ListNode middleNode = slowPntr.next;
            slowPntr.next = null;

            ListNode firstList = head;
            ListNode secondList = ReverseList2(middleNode);

            while(secondList != null)
            {
                ListNode tempNode1 = firstList.next;
                ListNode tempNode2 = secondList.next;
                firstList.next = secondList;
                secondList.next = tempNode1;
                firstList = tempNode1;
                secondList = tempNode2;
            }

            return;



        }
        public void ReorderList2(ListNode head)
        {
            if(head == null || head.next == null) return;

            // Find midPoint
            ListNode? slowPntr = head;
            ListNode? fastPntr = head.next;
            
            while(true)
            {
                if(fastPntr == null || fastPntr.next == null) break;
                slowPntr = slowPntr.next;
                fastPntr = fastPntr.next.next;
            }

            // Do Merge
            ListNode middleNode = slowPntr.next;
            slowPntr.next = null;

            ListNode firstList = head;
            ListNode secondList = ReverseList2(middleNode);

            while(secondList != null)
            {
                ListNode tempNode1 = firstList.next;
                ListNode tempNode2 = secondList.next;
                firstList.next = secondList;
                secondList.next = tempNode1;
                firstList = tempNode1;
                secondList = tempNode2;
            }

            return;



        }


    }
}