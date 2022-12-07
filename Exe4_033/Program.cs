using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe4_033
{
    class Node
    {
        public int info;
        public Node next;
        public Node (int i, Node n)
        {
            info = i;
            next = n;
        }
    }

    class Stacks
    {
        Node top;
        public Stacks()
        {
            top = null;
        }

    }
}
