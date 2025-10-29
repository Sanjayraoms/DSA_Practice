public class Solution {
    public int SmallestNumber(int n) {
        while(true){
            if((n & (n+1)) == 0)
                return n;
            n++;
        }
        return 0;
    }
}