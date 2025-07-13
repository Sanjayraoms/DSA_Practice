using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs
{
    public class GraphChar
    {
        IDictionary<char, List<char>> adjacencyList;

        public GraphChar()
        {
            adjacencyList = new Dictionary<char, List<char>>();
        }

        public void AddVertex(char ch)
        {
            adjacencyList[ch] = new List<char>();
        }

        public void AddEdge(char vertex1, char vertex2)
        {
            adjacencyList[vertex1].Add(vertex2);
            adjacencyList[vertex2].Add(vertex1);
        }

        public List<char> depthFirstRecursive(char start)
        {
            List<char> visited = new List<char>();
            void DFS(char start)
            {
                visited.Add(start);
                foreach (char c in adjacencyList[start])
                {
                    if (!visited.Contains(c))
                    {
                        DFS(c);
                    }
                }
            }
            DFS(start);
            return visited;
        }

        public List<char> depthFirstIterative(char start)
        {
            List<char> visited = new List<char>();
            Stack<char> stack = new Stack<char>();
            stack.Push(start);

            while (stack.Count > 0)
            {
                var popped = stack.Pop();
                if (!visited.Contains(popped))
                    visited.Add(popped);
                else
                    continue;
                foreach (char ch in adjacencyList[popped])
                {
                    stack.Push(ch);
                }
            }
            return visited;
        }

        public List<int> BreadthFirstSearch(char start)
        {
            return new List<int>();
        }
    }
}
