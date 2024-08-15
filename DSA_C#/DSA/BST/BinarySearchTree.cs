using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BST
{
    public class BinarySearchTree
    {
        public Node root { get; set; }

        public BinarySearchTree()
        {
            root = null;
        }

        public Node Insert(int val)
        {
            var newNode = new Node(val);
            if (root == null)
            {
                root = newNode;
            }
            else
            {
                var currentNode = root;
                while (currentNode != null)
                {
                    if (newNode.val > currentNode.val)
                    {
                        if (currentNode.right == null)
                        {
                            currentNode.right = newNode;
                            break;
                        }
                        else
                            currentNode = currentNode.right;
                    }
                    else
                    {
                        if (currentNode.left == null)
                        {
                            currentNode.left = newNode;
                            break;
                        }
                        else
                            currentNode = currentNode.left;
                    }
                }
            }

            return root;
        }
    }
}