public class Solution {
    public int MySqrt(int x) {
        long low = 1;
        long high = x;
        while(low <= high){
            long mid = (low+high)/2;
            if(mid*mid == x){
                return (int)mid;
            }else if(mid*mid > x){
                high = mid - 1;
            }else{
                low = mid+1;
            }
        }
        return (int)high;
    }
}