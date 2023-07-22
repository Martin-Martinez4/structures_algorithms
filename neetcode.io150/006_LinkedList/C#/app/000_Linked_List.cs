
using System.Collections.Generic;

namespace LinkedList
{
    public partial class LinkedList
    {
        //  Definition for singly-linked list.
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

        public class NodeList
        {
            private NodeList _head;

            public NodeList(ListNode head= null)
            {
                _head = head;
            }

            // Create list from List or array
        }

    }
}