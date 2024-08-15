using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BST
{
    public class Node
    {
        public Node right { get; set; }

        public Node left { get; set; }

        public int val { get; set; }

        public Node(int val)
        {
            this.val = val;
        }
    }
}
