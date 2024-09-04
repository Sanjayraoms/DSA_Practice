// See https://aka.ms/new-console-template for more information
using BinaryHeap;

Console.WriteLine("Hello, World!");

MaxBinaryHeap heap = new MaxBinaryHeap();
heap.InsertItem(10);
heap.InsertItem(20).ToList().ForEach(x => Console.Write($"{x} "));
Console.WriteLine();
heap.InsertItem(30).ToList().ForEach(x => Console.Write($"{x} "));
Console.WriteLine();
heap.InsertItem(40).ToList().ForEach(x => Console.Write($"{x} "));
Console.WriteLine();
heap.InsertItem(15).ToList().ForEach(x => Console.Write($"{x} "));
Console.WriteLine();
heap.InsertItem(50).ToList().ForEach(x=> Console.Write($"{x} "));


