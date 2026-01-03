public class Solution {
    public int NumOfWays(int n) {
        long MOD = 1_000_000_007;
        long aba = 6;
        long abc = 6;

        for(int i = 1; i < n; i++){
            var nextaba = (3*aba + 2*abc) % MOD;
            var nextabc = (2*aba + 2*abc) % MOD;

            aba = nextaba;
            abc = nextabc;
        }
        return (int)((aba + abc) % MOD);
    }
}