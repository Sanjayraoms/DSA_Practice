using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryHeap
{
    public class MaxBinaryHeap
    {
        List<int> heap = new List<int>();

        public int[] InsertItem(int val)
        {
            heap.Add(val);
            bubbleUp();
            return heap.ToArray();
        }
        
        private void bubbleUp()
        {
            var currentIndex = heap.Count - 1;
            while (currentIndex > 0)
            {
                var parentIndex = (int)Math.Floor((double)((currentIndex - 1) / 2));
                if (heap[currentIndex] > heap[parentIndex])
                {
                    var temp = heap[parentIndex];
                    heap[parentIndex] = heap[currentIndex];
                    heap[currentIndex] = temp;
                    currentIndex = parentIndex;
                }
                else
                    return;
            }

        }
    }
}
