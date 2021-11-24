using System;
using System.Collections.Generic;
using System.Text;

namespace UnorderdList
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
            Console.WriteLine(node.data + " \nadded in the linked list");
        }

        public void delete(string number)
        {
            Node temp = head;
            while (temp.Next != null)
            {
                if (number == temp.data)
                {
                    head = temp.Next;
                    break;
                }
                else if (number == temp.Next.data)
                {
                    temp.Next = temp.Next.Next;
                    break;
                }
                temp = temp.Next;
            }
            while (temp.Next != null)
            {
                temp = temp.Next;
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
