public class Solution {
    public long RepairCars(int[] ranks, int cars) {
        long l = ranks.Min();
        long r = l * cars * cars;
        long mid = 0;
        long res =-1;
        while(l <= r){
            mid = (l+r)/2;
            var repaired = countRepaired(mid,cars,ranks);
            if(repaired >= cars){
                res = mid;
                r = mid-1;
            }else
                l = mid+1;
        }
        return res;
    }

    private int countRepaired(long time,int cars,int[] ranks){
        int counter = 0;
        foreach(int rank in ranks){
            counter += (int)Math.Sqrt(time/rank);
            if(counter >= cars)
                return counter;
        }
        return counter;
    }
}