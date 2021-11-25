using System;
using System.Collections.Generic;
using System.Text;

namespace Hashing
{
    class LinkedListClass
    {
        internal Node head;
        public void add(int number)
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

        public void delete(int number)
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
        public int search(int number)
        {
            Node temp = this.head;
            while (temp.Next != null)
            {
                if (number == temp.data)
                {
                    Console.WriteLine(temp.data + " the num is present ");
                    break;
                }
                temp = temp.Next;
            }
            return temp.data;
        }
    }
}
