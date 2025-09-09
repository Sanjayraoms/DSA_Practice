public class Solution {
    public int[] SumZero(int n) {
        var res = new List<int>();
        if((n & 1) == 1){
            res.Add(0);
            n--;
        }
        int curr = 1;
        while(n > 0){
            res.Add(curr);
            res.Add(-curr);
            curr++;
            n = n-2;
        }
        return res.ToArray();
    }
}