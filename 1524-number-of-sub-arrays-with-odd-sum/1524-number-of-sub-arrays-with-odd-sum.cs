public class Solution {
    public int NumOfSubarrays(int[] arr) {
        int MOD = 100000007;
        int res = 0;
        long prefix_Sum = 0;
        int odd_cnt = 0;
        int even_cnt = 0;

        foreach(int num in arr){
            prefix_Sum += num;

            if(prefix_Sum % 2 == 1){
                res = (res + 1 + even_cnt) % MOD;
                odd_cnt++;
            }else{
                res = (res + odd_cnt) % MOD;
                even_cnt++;
            }
        } 
        return res;
    }
}