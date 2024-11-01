public class SmallestInfiniteSet {
    List<int> poppedValues;
        PriorityQueue<int, int> q;
        int prevsmallest = 0;
        public SmallestInfiniteSet()
        {
            prevsmallest++;
            q = new PriorityQueue<int, int>();
            q.Enqueue(prevsmallest, prevsmallest);
            poppedValues = new List<int>();
        }

        public int PopSmallest()
        {
            var currsmallest = q.Dequeue();
            poppedValues.Add(currsmallest);
            prevsmallest++;
            q.Enqueue(prevsmallest, prevsmallest);
            return currsmallest;
        }

        public void AddBack(int num)
        {
            if (poppedValues.Contains(num))
            {
                q.Enqueue(num, num);
                poppedValues.Remove(num);
            }
        }
}

/**
 * Your SmallestInfiniteSet object will be instantiated and called as such:
 * SmallestInfiniteSet obj = new SmallestInfiniteSet();
 * int param_1 = obj.PopSmallest();
 * obj.AddBack(num);
 */