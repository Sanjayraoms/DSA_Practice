public class Solution {
    public int FindLHS(int[] nums) {
        Dictionary<int,int> freqs = new();

        foreach(int num in nums){
            if(freqs.ContainsKey(num))
                freqs[num]++;
            else
                freqs[num] = 1;
        }
        var res = 0;
        foreach(var key in freqs.Keys){
            if(freqs.ContainsKey(key+1))
                res = Math.Max(res,freqs[key]+freqs[key+1]);
        }
        return res;
    }
}