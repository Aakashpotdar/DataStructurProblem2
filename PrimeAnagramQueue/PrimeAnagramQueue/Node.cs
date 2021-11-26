using System;
using System.Collections.Generic;
using System.Text;

namespace PrimeAnagramQueue
{
    class Node
    {
        public int data;

        public Node Next;
        public Node(int data)
        {
            this.data = data;
        }
    }
}
