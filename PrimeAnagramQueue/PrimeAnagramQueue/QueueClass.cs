using System;
using System.Collections.Generic;
using System.Text;

namespace PrimeAnagramQueue
{
    class QueueClass
    {
        internal Node head;
        public void Enque(int number)
        {
            Node node = new Node(number);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while (temp.Next != null)
                {
                    temp = temp.Next;
                }
                temp.Next = node;
            }
            Console.WriteLine(node.data + " added in the linked list");
        }
        internal void Display()
        {
            Node temp = this.head;
            if (this.head == null)
            {
                Console.WriteLine("the list is empty");
                return;
            }
            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.Next;
            }
            Console.WriteLine();
        }
    }
}
