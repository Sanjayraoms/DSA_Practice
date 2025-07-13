public class Solution {
    public IList<int> MajorityElement(int[] nums) {
        var freqCnt = new Dictionary<int,int>();

        foreach(int num in nums){
            if(freqCnt.ContainsKey(num))
                freqCnt[num]++;
            else
                freqCnt[num] = 1;
        }
        var res = new List<int>();
        foreach(int key in freqCnt.Keys){
            if(freqCnt[key] > nums.Length/3)
                res.Add(key);
        }
        return res;
    }
}