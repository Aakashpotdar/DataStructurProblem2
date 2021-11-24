using System;
using System.Collections.Generic;
using System.Text;

namespace UnorderdList
{
    class Node
    {
        public string data;

        public Node Next;
        public Node(string data)
        {
            this.data = data;
        }
    }
}
