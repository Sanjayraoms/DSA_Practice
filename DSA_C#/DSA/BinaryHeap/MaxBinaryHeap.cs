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

        public void extractMax(out int? swap, out int[] heap1)
        {
            if (heap.Count == 0)
                swap = null;
            if(heap.Count == 1)
            {
                var last = heap[0];
                heap.RemoveAt(0);
                swap = last;
            }
            swap = heap[0];
            heap[0] = heap[heap.Count - 1];
            heap[heap.Count - 1] = (int)swap;
            heap.RemoveAt(heap.Count - 1);
            sinkDown();
            heap1 = heap.ToArray();
        }

        private void sinkDown()
        {
            var parentIndex = 0;
            var element = heap[0];
            int swap;
            while (true)
            {
                var leftChildIdx = 2 * parentIndex + 1;
                var rightChildIdx = 2 * parentIndex + 2;
                swap = -1;
                if(leftChildIdx < heap.Count)
                {
                    if (heap[leftChildIdx] > element)
                        swap = leftChildIdx;
                }
                if(rightChildIdx < heap.Count)
                {
                    if(heap[rightChildIdx] > element && (swap == -1 || heap[rightChildIdx] > heap[swap]))
                        swap = rightChildIdx;
                }
                if(swap == -1) break;
                heap[parentIndex] = heap[swap];
                heap[swap] = element;
                parentIndex = swap;
            }
        }
    }
}
