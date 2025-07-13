public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
       var res = new List<IList<int>>();
       Array.Sort(nums);
       for(int i = 0; i < nums.Length; i++){
            if(nums[i] > 0)
                break;
            if(i > 0 && nums[i] == nums[i-1])
                continue;
            var l = i+1;
            var r = nums.Length-1;
            while(l < r){
                var sum = nums[i]+nums[l]+nums[r];
                if(sum > 0)
                    r--;
                else if(sum < 0)
                    l++;
                else{
                    res.Add(new List<int>(){nums[i],nums[l],nums[r]});
                    l++;
                    r--;
                    while(l < r && nums[l] == nums[l-1]){
                        l++;
                    }
                }
            }
       }
       return res;
    }
}