public class Solution {
    public int SmallestChair(int[][] times, int targetFriend) {
        int targetStart = times[targetFriend][0];
        Array.Sort(times,(t1,t2) => t1[0]-t2[0]);
        var unOccupiedChairs = new SortedSet<int>();
        var leavingQueue = new PriorityQueue<int[],int>();
        int nextChair = 0;

        foreach(var time in times){
            var (start,end) = (time[0],time[1]);
            while(leavingQueue.Count > 0 && start >= leavingQueue.Peek()[0]){
                unOccupiedChairs.Add(leavingQueue.Dequeue()[1]);
            }

            var currChair = 0;
            if(unOccupiedChairs.Count > 0){
                currChair = unOccupiedChairs.First();
                unOccupiedChairs.Remove(currChair);
            }else{
                currChair = nextChair++;
            }

            if(start == targetStart)
                return currChair;
            
            leavingQueue.Enqueue([end, currChair],end);

        }
    return 0;
    }
}
