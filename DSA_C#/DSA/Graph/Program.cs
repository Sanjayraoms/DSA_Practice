// See https://aka.ms/new-console-template for more information
using Graphs;

Console.WriteLine("Hello, World!");

var g = new Graph();
g.AddVertex(2);
g.AddVertex(3);
g.AddVertex(5);
g.AddVertex(6);
g.AddVertex(7);

g.AddEdge(2, 3);
g.AddEdge(2, 7);
g.AddEdge(3, 5);
g.AddEdge(5, 6);
g.AddEdge(6, 7);

//g.RemoveEdge(6, 7);

g.RemoveVertex(2);



