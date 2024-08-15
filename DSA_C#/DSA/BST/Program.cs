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

Console.WriteLine($"Is 5 present : {bst.find(5)}");
Console.WriteLine($"Is 20 present : {bst.find(20)}");