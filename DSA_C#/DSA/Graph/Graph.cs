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

        public void RemoveEdge(int vertex1, int vertex2)
        {
            adjacencyList[vertex1].Remove(vertex2);
            adjacencyList[vertex2].Remove(vertex1);
        }

        public void RemoveVertex(int vertex)
        {
            var neighbours = adjacencyList[vertex].ToList();
            foreach (var item in neighbours)
            {
                RemoveEdge(item, vertex);
            }
            adjacencyList.Remove(vertex);
        }
    }
}
