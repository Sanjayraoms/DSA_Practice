// See https://aka.ms/new-console-template for more information
using BST;

Console.WriteLine("Hello, World!");

var bst = new BinarySearchTree();

bst.Insert(10);
bst.Insert(15);
bst.Insert(6);
bst.Insert(13);
bst.Insert(20);
bst.Insert(3);
bst.Insert(8);
bst.Insert(7);
bst.Insert(2);

Console.WriteLine($"Is 5 present : {bst.find(5)}");
Console.WriteLine($"Is 20 present : {bst.find(20)}");
//var visited = bst.BFS();
//Console.WriteLine($"Breadth first Search visited :");

var visited = bst.DFSPreOrder();
Console.WriteLine($"Depth first Pre Order visited :");
visited.ToList().ForEach(x => Console.Write($"{x} "));
Console.WriteLine();

var visited1 = bst.DFSPostOrder();
Console.WriteLine($"Depth first Post Order visited :");
visited1.ToList().ForEach(x => Console.Write($"{x} "));
Console.WriteLine();

var visited2 = bst.DFSInOrder();
Console.WriteLine($"Depth first In Order visited :");
visited2.ToList().ForEach(x => Console.Write($"{x} "));