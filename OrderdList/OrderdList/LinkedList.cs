using System;
using System.Collections.Generic;
using System.Text;

namespace OrderdList
{
    class LinkedList
    {
        Node head;
        public void add(string number)
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
        }
        internal void Display()
        {
            Node temp1 = this.head;
            if (this.head == null)
            {
                Console.WriteLine("the Queue is empty");
                return;
            }
            while (temp1 != null)
            {
                Console.WriteLine(temp1.data + " ");
                temp1 = temp1.Next;
            }
            Console.WriteLine();
        }
    }
}
