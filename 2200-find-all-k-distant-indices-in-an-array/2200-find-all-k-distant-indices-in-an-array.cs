public class Solution {
    public IList<int> FindKDistantIndices(int[] nums, int key, int k) {
        List<int> keyIndices = new List<int>();
        for(int i = 0; i < nums.Length; i++){
            if(nums[i] == key)
                keyIndices.Add(i);
        }
        var resSet = new HashSet<int>();
        foreach(int keyIndx in keyIndices){
            resSet.Add(keyIndx);
            for(int j = keyIndx - k; j <= keyIndx + k; j++){
                if(j >= 0 && j < nums.Length)
                    resSet.Add(j);
            }
        }
        List<int> res = new List<int>();
        foreach(int val in resSet){
            res.Add(val);
        }
        res.Sort();
        return res;
    }
}