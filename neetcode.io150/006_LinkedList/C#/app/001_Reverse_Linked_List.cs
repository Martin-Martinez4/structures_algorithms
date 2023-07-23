
using System.Collections.Generic;

namespace LinkedListSpace
{
    public partial class Solutions
    {
        /*
            Given the head of a singly linked list, reverse the list, and return the reversed list.

            Example 1:

            Input: head = [1,2,3,4,5]
            Output: [5,4,3,2,1]

            Example 2:

            Input: head = [1,2]
            Output: [2,1]
            Example 3:

            Input: head = []
            Output: []
            

            Constraints:

            The number of nodes in the list is the range [0, 5000].
            -5000 <= Node.val <= 5000
 
        */
        /*

        */

        /*  
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

        // Fast But used more memory
        public ListNode? ReverseList(ListNode head)
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


    }

    public static class EnumerableExtensions
    {
        public static int SumOfEvenNumbers(
            this IEnumerable<int> numbers
        )
        {
            int sum = 0;
            foreach (var number in numbers)
            {
                if (number % 2 == 0)
                {
                    sum += number;
                }
            }

            return sum;
        }
    }
}