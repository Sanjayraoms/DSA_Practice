public class Solution {
    public int DifferenceOfSums(int n, int m) {
        int divisible = 0;
        int nondivisible = 0;
        for(int i = 1; i <= n; i++){
            if(i%m == 0){
                divisible += i;
            }else
                nondivisible += i;
        }
        return nondivisible - divisible;
    }
}