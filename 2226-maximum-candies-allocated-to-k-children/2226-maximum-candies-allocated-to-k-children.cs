public class Solution {
    public int MaximumCandies(int[] candies, long k) {
        long total = 0;
        foreach(int candy in candies){
            total += candy;
        }
        int res = 0;
        if(total < k)
            return res;

        long l = 1, r = total/k;
        while(l <= r){
            long mid = (l+r)/2;
            long count = 0;
            foreach(int pile in candies){
                count += pile/mid;
                if(count >= k)
                    break;
            }
            if(count >= k){
                res = (int)mid;
                l = mid + 1;
            }else{
                r = mid - 1;
            }
        }
        return res;
    }
}