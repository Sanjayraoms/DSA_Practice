public class Solution {
    public int MaxEvents(int[][] events) {
        Array.Sort(events,(a,b) => a[0] - b[0]);
        int day = 0, indx = 0, res = 0;
        int n = events.Length;
        PriorityQueue<int,int> pq = new();
        while(pq.Count > 0 || indx < n){
            if(pq.Count == 0){
                day = events[indx][0];
            }

            //Adding all the events which starts at this day based on completing day priority
            while(indx < n && events[indx][0] <= day){
                pq.Enqueue(events[indx][1],events[indx][1]);
                indx++;
            }

            //Attend the event based on least ending day
            pq.Dequeue();
            day++;
            res++;

            //Remove the event which is not attended and ending day is passed the current day
            while(pq.Count > 0 && pq.Peek() < day){
                pq.Dequeue();
            }
        }
        return res;
    }
}