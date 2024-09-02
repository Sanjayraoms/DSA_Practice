using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
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

        public bool find(int val)
        {
            var currentNode = root;
            while (currentNode != null)
            {
                if(currentNode.val == val)
                    return true;
                else
                {
                    if (val > currentNode.val)
                        currentNode = currentNode.right;
                    else
                        currentNode = currentNode.left;
                }
            }
            return false;
        }

        public int[] BFS()
        {
            Queue<Node> nodes = new Queue<Node>();
            List<int> visited = new List<int>();
            if(root == null)
                return visited.ToArray();
            nodes.Enqueue(root);
            while (nodes.Count > 0)
            {
                var node = nodes.Dequeue();
                visited.Add(node.val);
                if (node.left != null)
                    nodes.Enqueue(node.left);
                if(node.right != null)
                    nodes.Enqueue(node.right);
            }
            return visited.ToArray();
        }

        public int[] DFSPreOrder()
        {
            List<int> vals = new List<int>();
            var currentNode = root;
            void Traverse(Node node)
            {
                vals.Add(node.val);
                if(node.left != null) Traverse(node.left);
                if(node.right!= null) Traverse(node.right);
            }
            Traverse(currentNode);
            return vals.ToArray();
        }

        public int[] DFSPostOrder()
        {
            var vals = new List<int>();
            var currentNode = root;
            void Traverse(Node node)
            {
                if(node.left != null) Traverse(node.left);
                if(node.right !=null) Traverse(node.right);
                vals.Add(node.val);
            }
            Traverse(currentNode);
            return vals.ToArray();
        }

        public int[] DFSInOrder()
        {
            var vals = new List<int>();
            var currentNode = root;
            void Traverse(Node node)
            {
                if (node.left != null) Traverse(node.left);
                vals.Add(node.val);
                if (node.right != null) Traverse(node.right);
            }
            Traverse(currentNode);
            return vals.ToArray();
        }
    }
}