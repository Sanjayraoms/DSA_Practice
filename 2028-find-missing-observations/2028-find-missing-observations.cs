public class Solution {
    public int[] MissingRolls(int[] rolls, int mean, int n) {
        int m = rolls.Length;
        int mSum = 0;
        int[] nrolls = new int[n];

        foreach(int item in rolls)
           mSum += item;

        var nSum = mean*(m+n) - mSum;

        if(nSum < n || nSum > 6*n)
           return [];
        
        var baseVal = nSum/n;
        var remainder =  nSum % n;
        for(int i = 0; i<n; i++){
            nrolls[i] = baseVal + (i < remainder ? 1 : 0);
        }

        return nrolls;
    }
}