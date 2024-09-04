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
Console.WriteLine();
heap.InsertItem(60).ToList().ForEach(x => Console.Write($"{x} "));
Console.WriteLine();
heap.InsertItem(13).ToList().ForEach(x => Console.Write($"{x} "));
Console.WriteLine();

heap.extractMax(out int? max, out int[] heap1);
Console.WriteLine(max);
heap1.ToList().ForEach(x => Console.Write($"{x} "));

Console.WriteLine();

heap.extractMax(out int? max2, out int[] heap2);
Console.WriteLine(max2);
heap2.ToList().ForEach(x => Console.Write($"{x} "));