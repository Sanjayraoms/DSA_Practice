public class Solution {
    public IList<int> FindKDistantIndices(int[] nums, int key, int k) {
        var resSet = new HashSet<int>();
        for(int i = 0; i < nums.Length; i++){
            if(nums[i] == key){
                for(int j = i - k; j <= i + k; j++){
                    if(j >= 0 && j < nums.Length)
                        resSet.Add(j);
                }
            }
        }
        List<int> res = new List<int>();
        foreach(int val in resSet){
            res.Add(val);
        }
        return res;
    }
}