
using System.Text;

namespace LinkedListSpace
{
    //  * Definition for singly-linked list.
    public class ListNode
    {
        public int val;
        public ListNode? next;
        public ListNode(int val = 0, ListNode? next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    public class MyLinkedList
    {
        private ListNode? _head;
        public MyLinkedList()
        {
            _head = null;

        }

        public MyLinkedList(int value)
        {
            _head = new ListNode(value);

        }

        public MyLinkedList(ListNode node=null)
        {
            _head = node;

        }

        public MyLinkedList(IEnumerable<int> values)
        {
            foreach(int value in values)
            {
                this.Push(value);
            }
        }

        public ListNode? getHeadNode ()
        {
            return this._head;
        }

        public string PrintList()
        {
            if (this._head == null)
            {
                return "[]";
            }

            ListNode? currentNode = this._head;

            StringBuilder sb = new StringBuilder("[");

            while (currentNode != null)
            {
                if (currentNode.next != null)
                {
                    sb.AppendFormat($"{currentNode.val},");

                }
                else
                {

                    sb.AppendFormat($"{currentNode.val}]");
                }

                currentNode = currentNode.next;
            }

            return sb.ToString();
        }

        public void Push(int value)
        {
            if(this._head == null)
            {
                this._head = new ListNode(value);
                return;
            }

            ListNode currentNode = this._head;

            while(currentNode.next != null)
            {
                currentNode = currentNode.next;
            }

            currentNode.next = new ListNode(value);
            
            return;
            
        }
        
        public void Push(IEnumerable<int> values)
        {
            foreach(int value in values)
            {
                this.Push(value);
            }
            
        }

    }

}