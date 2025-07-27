public class Solution {
    public int CountHillValley(int[] nums) {
        int res = 0;

        //Removing adjacent equal elements
        List<int> compressed = new();
        for(int i = 0; i < nums.Length; i++){
            if(compressed.Count == 0 || nums[i]!=nums[i-1])
                compressed.Add(nums[i]);
        }
        for(int i = 1; i < compressed.Count-1; i++){
            if((compressed[i] > compressed[i-1] && compressed[i] > compressed[i+1])||
               (compressed[i] < compressed[i-1] && compressed[i] < compressed[i+1]))
               res++;
        }  
        return res;   
    }
}