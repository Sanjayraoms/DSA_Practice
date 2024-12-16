public class Solution {
    public int TwoCitySchedCost(int[][] costs) {
        int totalCost = 0;
        foreach(int[] cost in costs){
            totalCost += cost[0];
        }
        var pq = new PriorityQueue<int,int>();
        for(int i = 0; i< costs.Length; i++){
            var diff = costs[i][1] - costs[i][0];
            pq.Enqueue(i,diff);
        }
        int len = costs.Length/2;
        while(len-- > 0){
            var dq = pq.Dequeue();
            totalCost = totalCost - costs[dq][0] + costs[dq][1];
        }
        return totalCost;
    }
}