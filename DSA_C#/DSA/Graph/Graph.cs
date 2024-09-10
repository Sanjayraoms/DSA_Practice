using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs
{
    public class Graph
    {
        IDictionary<int, List<int>> adjacencyList;

        public Graph()
        {
            adjacencyList = new Dictionary<int, List<int>>();
        }

        public void AddVertex(int vertex)
        {
            adjacencyList[vertex] = new List<int>();
        }

        public void AddEdge(int vertex1,int vertex2)
        {
            adjacencyList[vertex1].Add(vertex2);
            adjacencyList[vertex2].Add(vertex1);
        }
    }
}
